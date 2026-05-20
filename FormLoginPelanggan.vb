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
        ' Validasi sederhana biar gak kosong
        If TxtEmail.Text.Trim() = "" Or TxtPassword.Text.Trim() = "" Then
            MessageBox.Show("Email dan Password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Logika cek database bisa ditaruh di sini nanti
        MessageBox.Show("Login Berhasil! Selamat berbelanja.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Menutup aplikasi saat klik X
    Private Sub FormLoginPelanggan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub FormLoginPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class