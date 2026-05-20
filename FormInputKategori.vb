Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class FormInputKategori

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        ' VALIDASI
        If txtKodeKategori.Text = "" Then
            MessageBox.Show("Kode kategori wajib diisi!")
            txtKodeKategori.Focus()
            Exit Sub
        End If

        If txtNamaKategori.Text = "" Then
            MessageBox.Show("Nama kategori wajib diisi!")
            txtNamaKategori.Focus()
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()

                If Me.Text = "Tambah Kategori" Then
                    ' MODE TAMBAH — INSERT ke database
                    Dim query As String =
                        "INSERT INTO kategori (kode_kategori, nama_kategori, keterangan) " &
                        "VALUES (@kode, @nama, @ket)"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@kode", txtKodeKategori.Text)
                        cmd.Parameters.AddWithValue("@nama", txtNamaKategori.Text)
                        cmd.Parameters.AddWithValue("@ket", txtKeterangan.Text)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Data berhasil ditambahkan!")

                Else
                    ' MODE UBAH — UPDATE di database
                    Dim query As String =
                        "UPDATE kategori SET nama_kategori = @nama, keterangan = @ket " &
                        "WHERE kode_kategori = @kode"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@nama", txtNamaKategori.Text)
                        cmd.Parameters.AddWithValue("@ket", txtKeterangan.Text)
                        cmd.Parameters.AddWithValue("@kode", txtKodeKategori.Text)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Data berhasil diubah!")
                End If

            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data!" & vbNewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Close()
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class