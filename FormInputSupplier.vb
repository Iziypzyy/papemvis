Imports MySql.Data.MySqlClient

' ============================================================
'  FormInputSupplier.vb  –  Tambah / Ubah Supplier
'  Terkoneksi ke tabel: supplier
' ============================================================

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
            txtTelepon.Text = Telepon
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
            Dim maxNum As Object = ExecScalar(
                "SELECT IFNULL(MAX(CAST(SUBSTRING(kode_supplier,2) AS UNSIGNED)),0) FROM supplier"
            )
            Return "S" & (CInt(maxNum) + 1).ToString("D3")
        Catch
            Return "S001"
        End Try
    End Function

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim kode As String = txtKode.Text.Trim()
        Dim nama As String = txtNama.Text.Trim()
        Dim telepon As String = txtTelepon.Text.Trim()
        Dim kota As String = txtKota.Text.Trim()

        If kode = "" OrElse nama = "" Then
            MessageBox.Show("Kode dan Nama Supplier wajib diisi!",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If ModeEdit Then
                ExecNonQuery(
                    "UPDATE supplier SET nama_supplier=@nama, telepon=@telepon, kota=@kota " &
                    "WHERE kode_supplier=@kode",
                    New Dictionary(Of String, Object) From {
                        {"@nama", nama}, {"@telepon", telepon},
                        {"@kota", kota}, {"@kode", kode}
                    }
                )
                MessageBox.Show("Supplier berhasil diperbarui!",
                                "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ExecNonQuery(
                    "INSERT INTO supplier (kode_supplier,nama_supplier,telepon,kota) VALUES (@kode,@nama,@telepon,@kota)",
                    New Dictionary(Of String, Object) From {
                        {"@kode", kode}, {"@nama", nama},
                        {"@telepon", telepon}, {"@kota", kota}
                    }
                )
                MessageBox.Show("Supplier berhasil ditambahkan!",
                                "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Me.Kode = kode
            Me.Nama = nama
            Me.Telepon = telepon
            Me.Kota = kota

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class