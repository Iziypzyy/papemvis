Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class FormLoginPelanggan

    ' 1. Logika Pindah ke Form Registrasi
    Private Sub LlblDaftar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LlblDaftar.LinkClicked
        FormRegis.Show()
        Me.Hide()
    End Sub

    ' 2. Logika Pindah ke Form Login Admin
    Private Sub LlblAdminArea_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LlblAdminArea.LinkClicked
        FormLoginAdmin.Show()
        Me.Hide()
    End Sub

    ' 3. Logika Tombol Login Pelanggan
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtEmail.Text.Trim() = "" Or TxtPassword.Text.Trim() = "" Then
            MessageBox.Show("Email dan Password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' === KONEKSI DATABASE ===
        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()
                Dim query As String =
                    "SELECT nama_pelanggan FROM pelanggan " &
                    "WHERE email = @email AND password = @pass"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@email", TxtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@pass", TxtPassword.Text.Trim())

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            MessageBox.Show("Login Berhasil! Selamat berbelanja, " & dr("nama_pelanggan").ToString() & ".",
                                            "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ' Tambahkan navigasi ke form belanja jika sudah ada
                        Else
                            MessageBox.Show("Email atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            TxtPassword.Clear()
                            TxtEmail.Focus()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal terhubung ke database!" & vbNewLine & ex.Message,
                            "Error Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Menutup aplikasi saat klik X
    Private Sub FormLoginPelanggan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub FormLoginPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class