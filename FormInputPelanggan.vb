Imports MySql.Data.MySqlClient

Public Class FormInputPelanggan

    Public Property Kode As String
    Public Property ModeEdit As Boolean = False

    Private Sub FormInputPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModeEdit Then
            ' kode sudah diisi oleh pemanggil, tampilkan saja
            lblKode.Text = Kode
        Else
            ' bila pemanggil belum mengisi kode, generate
            If String.IsNullOrWhiteSpace(lblKode.Text) Then
                lblKode.Text = "PLG001"
            End If
        End If
    End Sub

    Private Sub btnSimpanInput_Click(sender As Object, e As EventArgs) Handles btnSimpanInput.Click
        ' Validasi sederhana
        If Not ValidationModule.Require(txtNama.Text, "Nama Pelanggan") Then Exit Sub

        Dim nama = txtNama.Text.Trim()
        Dim telp = txtTelp.Text.Trim()
        Dim kota = txtKota.Text.Trim()
        Dim kode = lblKode.Text.Trim()

        Try
            If ModeEdit Then
                Dim sql As String = "UPDATE pelanggan SET nama_pelanggan = @nama, telepon = @telp, alamat = @kota WHERE kode_pelanggan = @kode"
                Dim p As New Dictionary(Of String, Object) From {
                    {"@nama", nama},
                    {"@telp", telp},
                    {"@kota", kota},
                    {"@kode", kode}
                }
                DataModule.ExecNonQuery(sql, p)
                MessageBox.Show("Data pelanggan berhasil diubah.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
                Return
            End If

            ' Insert baru — gunakan retry kecil untuk menghindari duplicate pada kondisi konkruensi
            Dim attempts As Integer = 0
            Dim maxAttempts As Integer = 6
            Dim inserted As Boolean = False

            While Not inserted AndAlso attempts < maxAttempts
                attempts += 1
                ' ambil kode terbaru dari pemanggil (pemanggil sudah set GenerateKode)
                kode = lblKode.Text.Trim()
                Dim sqlInsert As String = "INSERT INTO pelanggan (kode_pelanggan, nama_pelanggan, telepon, alamat, created_at) VALUES (@kode, @nama, @telp, @kota, NOW())"
                Dim p As New Dictionary(Of String, Object) From {
                    {"@kode", kode},
                    {"@nama", nama},
                    {"@telp", telp},
                    {"@kota", kota}
                }
                Try
                    DataModule.ExecNonQuery(sqlInsert, p)
                    inserted = True
                    MessageBox.Show("Pelanggan berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                    Return
                Catch ex As MySqlException
                    If ex.Number = 1062 Then
                        ' duplikat, generate kode baru dari DB dan ulangi
                        lblKode.Text = GenerateKodeFromDb()
                        System.Threading.Thread.Sleep(40)
                        Continue While
                    Else
                        Throw
                    End If
                End Try
            End While

            If Not inserted Then
                MessageBox.Show("Gagal menambah pelanggan setelah beberapa percobaan. Coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan pelanggan!" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GenerateKodeFromDb() As String
        Try
            Dim sql As String = "SELECT IFNULL(MAX(CAST(SUBSTRING(kode_pelanggan,4) AS UNSIGNED)),0) FROM pelanggan"
            Dim obj = DataModule.ExecScalar(sql)
            Dim maxNum As Integer = 0
            If obj IsNot Nothing AndAlso Integer.TryParse(obj.ToString(), maxNum) Then
                ' ok
            End If
            Return "PLG" & (maxNum + 1).ToString("D3")
        Catch
            Return "PLG001"
        End Try
    End Function

End Class