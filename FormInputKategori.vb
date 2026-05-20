Imports MySql.Data.MySqlClient

Public Class FormInputKategori

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If txtKodeKategori.Text.Trim = "" Then

            MessageBox.Show(
                "Kode kategori wajib diisi!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtKodeKategori.Focus()
            Exit Sub

        End If

        If txtNamaKategori.Text.Trim = "" Then

            MessageBox.Show(
                "Nama kategori wajib diisi!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtNamaKategori.Focus()
            Exit Sub

        End If

        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()

                If Me.Text = "Tambah Kategori" Then

                    Dim query As String =
                        "INSERT INTO kategori 
                        (kode_kategori, nama_kategori, keterangan)
                        VALUES
                        (@kode, @nama, @ket)"

                    Using cmd As New MySqlCommand(query, conn)

                        cmd.Parameters.AddWithValue("@kode", txtKodeKategori.Text)
                        cmd.Parameters.AddWithValue("@nama", txtNamaKategori.Text)
                        cmd.Parameters.AddWithValue("@ket", txtKeterangan.Text)

                        cmd.ExecuteNonQuery()

                    End Using

                    MessageBox.Show(
                        "Data berhasil ditambahkan!",
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    )

                Else

                    Dim query As String =
                        "UPDATE kategori 
                         SET nama_kategori = @nama,
                             keterangan = @ket
                         WHERE kode_kategori = @kode"

                    Using cmd As New MySqlCommand(query, conn)

                        cmd.Parameters.AddWithValue("@nama", txtNamaKategori.Text)
                        cmd.Parameters.AddWithValue("@ket", txtKeterangan.Text)
                        cmd.Parameters.AddWithValue("@kode", txtKodeKategori.Text)

                        cmd.ExecuteNonQuery()

                    End Using

                    MessageBox.Show(
                        "Data berhasil diubah!",
                        "Informasi",
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

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click

        Me.Close()

    End Sub

End Class