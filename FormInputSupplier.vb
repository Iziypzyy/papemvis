Imports MySql.Data.MySqlClient

Public Class FormInputSupplier

    Public Property Kode As String = ""
    Public Property Nama As String = ""
    Public Property Telepon As String = ""
    Public Property Kota As String = ""
    Public Property ModeEdit As Boolean = False

    Private Sub FormInputSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModeEdit Then
            txtKode.Text = Kode
            txtNama.Text = Nama
            txtTelp.Text = Telepon
            txtKota.Text = Kota
            txtKode.ReadOnly = True
        Else
            txtKode.Text = GenerateKode()
            txtKode.ReadOnly = True
        End If
        txtNama.Focus()
    End Sub

    Private Function GenerateKode() As String
        Try
            Dim query As String = "SELECT IFNULL(MAX(CAST(SUBSTRING(kode_supplier, 2) AS UNSIGNED)), 0) FROM supplier"
            Dim maxNumObj As Object = ExecScalar(query)
            Dim maxNum As Integer = 0
            If maxNumObj IsNot Nothing AndAlso Integer.TryParse(maxNumObj.ToString(), maxNum) Then
                ' ok
            End If
            Return "S" & (maxNum + 1).ToString("D3")
        Catch
            Return "S001"
        End Try
    End Function

    Private Sub BtnSimpanInput_Click(sender As Object, e As EventArgs) Handles btnSimpanInput.Click
        Dim nama As String = txtNama.Text.Trim()
        Dim telepon As String = txtTelp.Text.Trim()
        Dim kota As String = txtKota.Text.Trim()

        If nama = "" Then
            MessageBox.Show("Nama supplier wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            If ModeEdit Then
                Dim sqlUpdate As String = "UPDATE supplier SET nama_supplier = @nama, telepon = @telepon, kota = @kota WHERE kode_supplier = @kode"
                Dim paramsUpdate As New Dictionary(Of String, Object) From {
                    {"@nama", nama},
                    {"@telepon", telepon},
                    {"@kota", kota},
                    {"@kode", txtKode.Text.Trim()}
                }
                ExecNonQuery(sqlUpdate, paramsUpdate)
                MessageBox.Show("Data supplier berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
                Return
            End If

            ' INSERT dengan retry: setiap percobaan generate kode terbaru dari DB
            Dim attempts As Integer = 0
            Dim maxAttempts As Integer = 6
            Dim inserted As Boolean = False

            While Not inserted AndAlso attempts < maxAttempts
                attempts += 1
                Dim kodeTry As String = GenerateKode() ' selalu ambil nilai terbaru sebelum insert
                Try
                    Dim sqlInsert As String = "INSERT INTO supplier (kode_supplier, nama_supplier, telepon, kota) VALUES (@kode, @nama, @telepon, @kota)"
                    Dim paramsInsert As New Dictionary(Of String, Object) From {
                        {"@kode", kodeTry},
                        {"@nama", nama},
                        {"@telepon", telepon},
                        {"@kota", kota}
                    }
                    ExecNonQuery(sqlInsert, paramsInsert)

                    ' berhasil insert
                    inserted = True
                    txtKode.Text = kodeTry
                    MessageBox.Show("Supplier berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.Kode = kodeTry
                    Me.Nama = nama
                    Me.Telepon = telepon
                    Me.Kota = kota

                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                    Return

                Catch ex As Exception
                    ' Jika ini MySQL duplicate key error (1062) coba ulang dengan kode baru
                    Dim mysqlEx = TryCast(ex, MySqlException)
                    If mysqlEx IsNot Nothing AndAlso mysqlEx.Number = 1062 Then
                        ' jika masih punya kesempatan, ulangi loop dengan kode baru
                        If attempts >= maxAttempts Then
                            MessageBox.Show("Gagal menambah supplier karena kode duplikat berulang. Silakan coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        Else
                            ' sedikit delay agar nilai MAX berubah jika ada proses lain (opsional)
                            System.Threading.Thread.Sleep(50)
                            Continue While
                        End If
                    Else
                        ' error lain: tampilkan dan keluar
                        Throw
                    End If
                End Try
            End While

            If Not inserted Then
                MessageBox.Show("Gagal menambah supplier setelah beberapa percobaan. Periksa koneksi atau coba ulang.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data." & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class