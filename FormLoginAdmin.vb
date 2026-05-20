Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class FormLoginAdmin

    ' 1. Logika saat tombol Login diklik
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim username As String = TextBoxUsername.Text.Trim()
        Dim password As String = TextBoxPassword.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' === KONEKSI DATABASE ===
        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()
                Dim query As String =
                    "SELECT nama_lengkap, level FROM users " &
                    "WHERE username = @u AND password = @p AND status = 'Aktif'"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@p", password)

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            ' Simpan info user aktif (bisa dipakai di form lain)
                            My.Application.Info.Version.ToString() ' placeholder
                            MessageBox.Show("Login Berhasil! Selamat datang " & dr("nama_lengkap").ToString() & ".",
                                            "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            FormDashboard.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            TextBoxPassword.Clear()
                            TextBoxUsername.Focus()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal terhubung ke database!" & vbNewLine & ex.Message,
                            "Error Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' 2. Logika saat tombol Batal diklik
    Private Sub ButtonBatal_Click(sender As Object, e As EventArgs) Handles ButtonBatal.Click
        Me.Hide()
        FormLoginPelanggan.Show()
    End Sub

    ' 3. Menangani penutupan form secara manual (tombol X)
    Private Sub FormLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class