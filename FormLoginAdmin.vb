Imports MySql.Data.MySqlClient

Public Class FormLoginAdmin

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim username As String = TextBoxUsername.Text.Trim()
        Dim password As String = TextBoxPassword.Text.Trim()

        If username = "" OrElse password = "" Then
            MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim conn As MySqlConnection = KoneksiDB.GetConnection()
            Dim query As String = "SELECT nama_lengkap, level FROM users WHERE username = @u AND password = @p AND status = 'Aktif'"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@u", username)
            cmd.Parameters.AddWithValue("@p", password)

            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            If dr.Read() Then
                Dim namaUser As String = dr("nama_lengkap").ToString()
                MessageBox.Show("Login berhasil! Selamat datang " & namaUser & ".", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                FormDashboard.Show()
                Me.Hide()
            Else
                MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBoxPassword.Clear()
                TextBoxUsername.Focus()
            End If

            dr.Close()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Gagal terhubung ke database!" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonBatal_Click(sender As Object, e As EventArgs) Handles ButtonBatal.Click
        Me.Hide()
        FormLoginPelanggan.Show()
    End Sub

    Private Sub FormLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Kosong sengaja dibiarkan untuk event form load
    End Sub

End Class