Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class FormInputPelanggan

    ' TOMBOL SIMPAN
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        ' VALIDASI INPUT
        If txtKode.Text = "" Or txtNama.Text = "" Then
            MessageBox.Show("Kode dan Nama harus diisi!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()

                If Me.Text = "Tambah Pelanggan" Then
                    ' MODE TAMBAH — INSERT
                    Dim query As String =
                        "INSERT INTO pelanggan (kode_pelanggan, nama_pelanggan, email, password) " &
                        "VALUES (@kode, @nama, @email, @pass)"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@kode", txtKode.Text)
                        cmd.Parameters.AddWithValue("@nama", txtNama.Text)
                        cmd.Parameters.AddWithValue("@email", txtNoTelp.Text) ' txtNoTelp dipakai untuk email saat tambah manual
                        cmd.Parameters.AddWithValue("@pass", "12345")        ' password default
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Data pelanggan berhasil ditambahkan!", "Berhasil",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' MODE UBAH — UPDATE
                    Dim query As String =
                        "UPDATE pelanggan SET nama_pelanggan = @nama " &
                        "WHERE kode_pelanggan = @kode"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@nama", txtNama.Text)
                        cmd.Parameters.AddWithValue("@kode", txtKode.Text)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Data pelanggan berhasil diubah!", "Berhasil",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data!" & vbNewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Close()
    End Sub

    ' TOMBOL BATAL
    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    ' VALIDASI INPUT ANGKA (untuk no telp)
    Private Sub txtNoTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoTelp.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class