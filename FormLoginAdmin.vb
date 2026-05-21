Imports MySql.Data.MySqlClient

Public Class FormLoginAdmin

    ' 1. Event saat tombol Login diklik
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim username As String = TextBoxUsername.Text.Trim()
        Dim password As String = TextBoxPassword.Text.Trim()

        ' Validasi input kosong
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

                MessageBox.Show("Login berhasil! Selamat datang, " & namaUser & ".", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Tampilkan Dashboard Admin dan sembunyikan Form Login
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

    ' 2. Event Show/Hide Password
    Private Sub CheckBoxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPassword.CheckedChanged
        If CheckBoxShowPassword.Checked = True Then
            ' Hapus karakter bintang untuk menampilkan teks asli
            TextBoxPassword.PasswordChar = ControlChars.NullChar
        Else
            ' Kembalikan karakter menjadi bintang
            TextBoxPassword.PasswordChar = "*"c
        End If
    End Sub

    ' 3. Event saat tombol Batal diklik
    Private Sub ButtonBatal_Click(sender As Object, e As EventArgs) Handles ButtonBatal.Click
        ' Kosongkan isian form
        TextBoxUsername.Clear()
        TextBoxPassword.Clear()
        CheckBoxShowPassword.Checked = False
        TextBoxUsername.Focus()
    End Sub

    ' 4. Event saat form disilang (Tutup aplikasi sepenuhnya)
    Private Sub FormLoginAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    ' 5. Event Load (opsional dibiarkan kosong jika tidak ada kebutuhan spesifik)
    Private Sub FormLoginAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup awal memastikan kursor ada di textbox username
        TextBoxUsername.Focus()
    End Sub

End Class