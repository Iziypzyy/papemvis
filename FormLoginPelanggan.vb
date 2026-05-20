Imports MySql.Data.MySqlClient

Public Class FormLoginPelanggan

    ' =========================
    ' PINDAH KE FORM REGISTRASI
    ' =========================
    Private Sub LlblDaftar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LlblDaftar.LinkClicked

        FormRegis.Show()
        Me.Hide()

    End Sub

    ' =========================
    ' PINDAH KE LOGIN ADMIN
    ' =========================
    Private Sub LlblAdminArea_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LlblAdminArea.LinkClicked

        FormLoginAdmin.Show()
        Me.Hide()

    End Sub

    ' =========================
    ' TOMBOL LOGIN
    ' =========================
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        If TxtEmail.Text.Trim = "" Or TxtPassword.Text.Trim = "" Then

            MessageBox.Show(
                "Email dan Password wajib diisi!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Exit Sub

        End If

        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()

                Dim query As String =
                    "SELECT nama_pelanggan 
                     FROM pelanggan 
                     WHERE email = @email 
                     AND password = @password"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@email", TxtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@password", TxtPassword.Text.Trim())

                    Using dr As MySqlDataReader = cmd.ExecuteReader()

                        If dr.Read() Then

                            MessageBox.Show(
                                "Login berhasil! Selamat datang, " &
                                dr("nama_pelanggan").ToString(),
                                "Informasi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                                )
                            FormDashboard.Show()
                            Me.Hide()


                            ' Form berikutnya bisa ditambahkan di sini
                            ' Contoh:
                            ' FormDashboard.Show()
                            ' Me.Hide()

                        Else

                            MessageBox.Show(
                                "Email atau Password salah!",
                                "Login Gagal",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            )

                            TxtPassword.Clear()
                            TxtEmail.Focus()

                        End If

                    End Using
                End Using
            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Koneksi database gagal!" & vbNewLine & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    ' =========================
    ' SAAT FORM DITUTUP
    ' =========================
    Private Sub FormLoginPelanggan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Application.Exit()

    End Sub

    ' =========================
    ' LOAD FORM
    ' =========================
    Private Sub FormLoginPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class