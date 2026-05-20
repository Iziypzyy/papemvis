Imports MySql.Data.MySqlClient

Public Class FormRegis

    ' TOMBOL DAFTAR
    Private Sub BtnDaftar_Click(sender As Object, e As EventArgs) Handles BtnDaftar.Click

        If TxtNama.Text.Trim = "" Or
           TxtEmail.Text.Trim = "" Or
           TxtPassword.Text.Trim = "" Then

            MessageBox.Show(
                "Data tidak boleh kosong!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Exit Sub

        End If

        If TxtPassword.Text <> TxtKonfirmasi.Text Then

            MessageBox.Show(
                "Konfirmasi password tidak sesuai!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

            TxtKonfirmasi.Clear()
            TxtKonfirmasi.Focus()

            Exit Sub

        End If

        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()

                ' Cek email
                Dim cekQuery As String =
                    "SELECT COUNT(*) 
                     FROM pelanggan 
                     WHERE email = @email"

                Using cmdCek As New MySqlCommand(cekQuery, conn)

                    cmdCek.Parameters.AddWithValue(
                        "@email",
                        TxtEmail.Text.Trim()
                    )

                    Dim jumlah As Integer =
                        Convert.ToInt32(cmdCek.ExecuteScalar())

                    If jumlah > 0 Then

                        MessageBox.Show(
                            "Email sudah terdaftar!",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        )

                        TxtEmail.Focus()

                        Exit Sub

                    End If

                End Using

                ' Generate kode pelanggan
                Dim kodeBaru As String = ""

                Dim queryKode As String =
                    "SELECT COUNT(*) FROM pelanggan"

                Using cmdKode As New MySqlCommand(queryKode, conn)

                    Dim total As Integer =
                        Convert.ToInt32(cmdKode.ExecuteScalar())

                    kodeBaru = "P" & (total + 1).ToString("D3")

                End Using

                ' Simpan data pelanggan
                Dim insertQuery As String =
                    "INSERT INTO pelanggan
                     (kode_pelanggan, nama_pelanggan, email, password)
                     VALUES
                     (@kode, @nama, @email, @password)"

                Using cmdInsert As New MySqlCommand(insertQuery, conn)

                    cmdInsert.Parameters.AddWithValue("@kode", kodeBaru)
                    cmdInsert.Parameters.AddWithValue("@nama", TxtNama.Text.Trim())
                    cmdInsert.Parameters.AddWithValue("@email", TxtEmail.Text.Trim())
                    cmdInsert.Parameters.AddWithValue("@password", TxtPassword.Text)

                    cmdInsert.ExecuteNonQuery()

                End Using

            End Using

            MessageBox.Show(
                "Registrasi berhasil!",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            FormLoginPelanggan.Show()
            Me.Hide()

        Catch ex As Exception

            MessageBox.Show(
                "Gagal menyimpan data!" & vbNewLine & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    ' KEMBALI KE LOGIN
    Private Sub LlblSudahPunyaAkun_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LlblSudahPunyaAkun.LinkClicked

        FormLoginPelanggan.Show()
        Me.Hide()

    End Sub

    ' TUTUP APLIKASI
    Private Sub FormRegis_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Application.Exit()

    End Sub

    Private Sub FormRegis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class