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
            Dim maxNum As Object = ExecScalar(query)

            Return "S" & (CInt(maxNum) + 1).ToString("D3")
        Catch
            Return "S001"
        End Try
    End Function

    Private Sub BtnSimpanInput_Click(sender As Object, e As EventArgs) Handles btnSimpanInput.Click
        Dim kode As String = txtKode.Text.Trim()
        Dim nama As String = txtNama.Text.Trim()
        Dim telepon As String = txtTelp.Text.Trim()
        Dim kota As String = txtKota.Text.Trim()

        If kode = "" OrElse nama = "" Then
            MessageBox.Show("Kode dan nama supplier wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            If ModeEdit Then
                Dim sqlUpdate As String = "UPDATE supplier SET nama_supplier = @nama, telepon = @telepon, kota = @kota WHERE kode_supplier = @kode"
                Dim params As New Dictionary(Of String, Object) From {
                    {"@nama", nama},
                    {"@telepon", telepon},
                    {"@kota", kota},
                    {"@kode", kode}
                }
                ExecNonQuery(sqlUpdate, params)
                MessageBox.Show("Data supplier berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim sqlInsert As String = "INSERT INTO supplier (kode_supplier, nama_supplier, telepon, kota) VALUES (@kode, @nama, @telepon, @kota)"
                Dim params As New Dictionary(Of String, Object) From {
                    {"@kode", kode},
                    {"@nama", nama},
                    {"@telepon", telepon},
                    {"@kota", kota}
                }
                ExecNonQuery(sqlInsert, params)
                MessageBox.Show("Supplier berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Me.Kode = kode
            Me.Nama = nama
            Me.Telepon = telepon
            Me.Kota = kota

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data." & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class