Imports MySql.Data.MySqlClient

Public Class FormInputPelanggan

    ' TOMBOL SIMPAN
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If txtKode.Text.Trim = "" Or txtNama.Text.Trim = "" Then

            MessageBox.Show(
                "Kode dan nama harus diisi!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Exit Sub

        End If

        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()

                If Me.Text = "Tambah Pelanggan" Then

                    Dim query As String =
                        "INSERT INTO pelanggan 
                        (kode_pelanggan, nama_pelanggan, email, password)
                        VALUES
                        (@kode, @nama, @email, @pass)"

                    Using cmd As New MySqlCommand(query, conn)

                        cmd.Parameters.AddWithValue("@kode", txtKode.Text)
                        cmd.Parameters.AddWithValue("@nama", txtNama.Text)
                        cmd.Parameters.AddWithValue("@email", txtNoTelp.Text)
                        cmd.Parameters.AddWithValue("@pass", "12345")

                        cmd.ExecuteNonQuery()

                    End Using

                    MessageBox.Show(
                        "Data pelanggan berhasil ditambahkan!",
                        "Berhasil",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    )

                Else

                    Dim query As String =
                        "UPDATE pelanggan 
                         SET nama_pelanggan = @nama
                         WHERE kode_pelanggan = @kode"

                    Using cmd As New MySqlCommand(query, conn)

                        cmd.Parameters.AddWithValue("@nama", txtNama.Text)
                        cmd.Parameters.AddWithValue("@kode", txtKode.Text)

                        cmd.ExecuteNonQuery()

                    End Using

                    MessageBox.Show(
                        "Data pelanggan berhasil diubah!",
                        "Berhasil",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    )

                End If

            End Using

            Me.Close()

        Catch ex As Exception

            MessageBox.Show(
                "Gagal menyimpan data!" & vbNewLine & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    ' TOMBOL BATAL
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click

        Me.Close()

    End Sub

    ' VALIDASI INPUT ANGKA
    Private Sub txtNoTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoTelp.KeyPress

        If Not Char.IsDigit(e.KeyChar) And
           Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

End Class