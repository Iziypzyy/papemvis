Public Class FormLoginAdmin

    ' 1. Logika saat tombol Login diklik
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        ' Mengambil input dari user dan menghapus spasi di awal/akhir
        Dim username As String = TextBoxUsername.Text.Trim()
        Dim password As String = TextBoxPassword.Text.Trim()

        ' Validasi apakah textbox kosong
        If username = "" Or password = "" Then
            MessageBox.Show("Username dan Password tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Cek kredensial admin
        If username = "admin" And password = "1234" Then
            MessageBox.Show("Login Berhasil! Selamat datang Admin.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Membuka FormDashboard dan menyembunyikan FormLogin
            FormDashboard.Show()
            Me.Hide()
        Else
            ' Jika username atau password salah
            MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Mengosongkan password dan fokus kembali ke username
            TextBoxPassword.Clear()
            TextBoxUsername.Focus()
        End If
    End Sub

    ' 2. Logika saat tombol Batal diklik
    Private Sub ButtonBatal_Click(sender As Object, e As EventArgs) Handles ButtonBatal.Click
        ' Kembali ke Login Pelanggan
        Me.Hide()
        FormLoginPelanggan.Show()
    End Sub

    ' 3. Menangani penutupan form secara manual (tombol X)
    Private Sub FormLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Memastikan aplikasi benar-benar berhenti saat form ditutup
        Application.Exit()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class