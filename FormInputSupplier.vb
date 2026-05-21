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
            ' Mengambil kode_supplier urutan paling terakhir/terbesar
            Dim query As String = "SELECT kode_supplier FROM supplier ORDER BY kode_supplier DESC LIMIT 1"
            Dim maxCodeObj As Object = ExecScalar(query)

            If maxCodeObj IsNot Nothing AndAlso maxCodeObj IsNot DBNull.Value Then
                Dim lastCode As String = maxCodeObj.ToString()
                Dim numStr As String = lastCode.Substring(1)
                Dim nextNum As Integer = Integer.Parse(numStr) + 1
                Return "S" & nextNum.ToString("D3")
            Else
                Return "S001" ' Jika tabel supplier masih kosong
            End If
        Catch ex As Exception
            Throw New Exception("Gagal membuat kode otomatis: " & ex.Message)
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

        ' 1. MODE EDIT
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

        ' 2. MODE TAMBAH BARU
        Dim kodeFix As String = GenerateKode()
        Dim suksesInsert As Boolean = False

        Try
            Dim sqlInsert As String = "INSERT INTO supplier (kode_supplier, nama_supplier, telepon, kota) VALUES (@kode, @nama, @telepon, @kota)"
            Dim paramsInsert As New Dictionary(Of String, Object) From {
                {"@kode", kodeFix},
                {"@nama", nama},
                {"@telepon", telepon},
                {"@kota", kota}
            }
            ExecNonQuery(sqlInsert, paramsInsert)
            suksesInsert = True

        Catch ex As Exception
            ' Sisi perbaikan: ex yang di-TryCast, bukan kodeFix!
            Dim mysqlEx As MySqlException = TryCast(ex, MySqlException)

            ' Jaga-jaga kalau ExecNonQuery membungkus error-nya di dalam ApplicationException
            If mysqlEx Is Nothing AndAlso ex.InnerException IsNot Nothing Then
                mysqlEx = TryCast(ex.InnerException, MySqlException)
            End If

            ' Jika error karena Duplikat (1062), coba generate ulang SEKALI LAGI
            If mysqlEx IsNot Nothing AndAlso mysqlEx.Number = 1062 Then
                kodeFix = GenerateKode() ' Ambil nomor paling baru hasil increment DB

                Dim paramsInsertRetry As New Dictionary(Of String, Object) From {
                    {"@kode", kodeFix},
                    {"@nama", nama},
                    {"@telepon", telepon},
                    {"@kota", kota}
                }
                Dim sqlInsert As String = "INSERT INTO supplier (kode_supplier, nama_supplier, telepon, kota) VALUES (@kode, @nama, @telepon, @kota)"
                ExecNonQuery(sqlInsert, paramsInsertRetry)
                suksesInsert = True
            Else
                ' Jika errornya bukan karena duplikat, lempar ke catch luar
                Throw ex
            End If
        End Try

        ' Jika sukses tersimpan, set properti dan tutup form
        If suksesInsert Then
            MessageBox.Show("Supplier berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Kode = kodeFix
            Me.Nama = nama
            Me.Telepon = telepon
            Me.Kota = kota

            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

End Class