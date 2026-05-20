Public Class FormLoginPelanggan

    Private Sub FormLoginPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' PASSWORD MODE
        TxtPassword.PasswordChar = "•"c

        ' FOCUS KE EMAIL
        TxtEmail.Focus()

    End Sub

    Private Sub TxtEmail_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail.TextChanged

    End Sub

    Private Sub TxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        Dim email As String = TxtEmail.Text.Trim()
        Dim password As String = TxtPassword.Text.Trim()

        ' VALIDASI INPUT KOSONG
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

        ' LOGIN DUMMY
        If email = "pelanggan@gmail.com" And password = "12345" Then

            MessageBox.Show(
                "Login berhasil!",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Me.Hide()
            FormDashboard.Show()

        Else

            MessageBox.Show(
                "Email atau password salah!",
                "Login Gagal",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

            TxtPassword.Clear()
            TxtPassword.Focus()

        End If

    End Sub

    Private Sub LlblDaftar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LlblDaftar.LinkClicked

        ' PINDAH KE FORM REGISTRASI
        Me.Hide()
        FormRegis.Show()

    End Sub

    Private Sub LlblAdminArea_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LlblAdminArea.LinkClicked

        ' PINDAH KE LOGIN ADMIN
        Me.Hide()
        FormLoginAdmin.Show()

    End Sub

End Class