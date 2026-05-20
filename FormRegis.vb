Public Class FormRegis
    ' 1. Logika tombol Daftar
    Private Sub BtnDaftar_Click(sender As Object, e As EventArgs) Handles BtnDaftar.Click
        ' Cek apakah ada field yang kosong
        If TxtNama.Text.Trim() = "" Or TxtEmail.Text.Trim() = "" Or TxtPassword.Text.Trim() = "" Then
            MessageBox.Show("Data tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Cek apakah Password dan Konfirmasi sama
        If TxtPassword.Text <> TxtKonfirmasi.Text Then
            MessageBox.Show("Konfirmasi password tidak sesuai!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtKonfirmasi.Clear()
            TxtKonfirmasi.Focus()
            Return
        End If

        ' Jika semua OK (Simulasi simpan data)
        MessageBox.Show("Registrasi akun berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        FormLoginPelanggan.Show()
        Me.Hide()
    End Sub

    ' 2. Logika balik ke Login
    Private Sub LlblSudahPunyaAkun_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LlblSudahPunyaAkun.LinkClicked
        FormLoginPelanggan.Show()
        Me.Hide()
    End Sub

    ' Tutup aplikasi kalau klik X
    Private Sub FormRegis_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub FormRegis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class