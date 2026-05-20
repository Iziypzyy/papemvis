Public Class FormRegis

    Private Sub FormRegis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' PASSWORD MODE
        TxtPassword.PasswordChar = "•"c
        TxtKonfirmasi.PasswordChar = "•"c

        TxtNama.Focus()

    End Sub

    Private Sub BtnDaftar_Click(sender As Object, e As EventArgs) Handles BtnDaftar.Click

        Dim nama As String = TxtNama.Text.Trim()
        Dim email As String = TxtEmail.Text.Trim()
        Dim telepon As String = TxtNoTelepon.Text.Trim()
        Dim alamat As String = TxtAlamat.Text.Trim()
        Dim password As String = TxtPassword.Text.Trim()
        Dim konfirmasi As String = TxtKonfirmasi.Text.Trim()

        ' VALIDASI INPUT
        If nama = "" Then

            MessageBox.Show(
                "Nama lengkap belum diisi!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            TxtNama.Focus()
            Exit Sub

        End If

        If email = "" Then

            MessageBox.Show(
                "Email belum diisi!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            TxtEmail.Focus()
            Exit Sub

        End If

        If telepon = "" Then

            MessageBox.Show(
                "Nomor telepon belum diisi!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            TxtNoTelepon.Focus()
            Exit Sub

        End If

        If alamat = "" Then

            MessageBox.Show(
                "Alamat belum diisi!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            TxtAlamat.Focus()
            Exit Sub

        End If

        If password = "" Then

            MessageBox.Show(
                "Password belum diisi!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            TxtPassword.Focus()
            Exit Sub

        End If

        If konfirmasi = "" Then

            MessageBox.Show(
                "Konfirmasi password belum diisi!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            TxtKonfirmasi.Focus()
            Exit Sub

        End If

        ' VALIDASI PASSWORD
        If password <> konfirmasi Then

            MessageBox.Show(
                "Konfirmasi password tidak sama!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            TxtKonfirmasi.Clear()
            TxtKonfirmasi.Focus()

            Exit Sub

        End If

        ' VALIDASI PANJANG PASSWORD
        If password.Length < 5 Then

            MessageBox.Show(
                "Password minimal 5 karakter!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            TxtPassword.Focus()

            Exit Sub

        End If

        ' REGISTRASI BERHASIL
        MessageBox.Show(
            "Registrasi berhasil!" & vbCrLf &
            "Silakan login menggunakan akun Anda.",
            "Sukses",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

        ' CLEAR FORM
        TxtNama.Clear()
        TxtEmail.Clear()
        TxtNoTelepon.Clear()
        TxtAlamat.Clear()
        TxtPassword.Clear()
        TxtKonfirmasi.Clear()

        ' PINDAH KE LOGIN
        Me.Hide()
        FormLoginPelanggan.Show()

    End Sub

    Private Sub LlblSudahPunyaAkun_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LlblSudahPunyaAkun.LinkClicked

        ' PINDAH KE FORM LOGIN
        Me.Hide()
        FormLoginPelanggan.Show()

    End Sub

End Class