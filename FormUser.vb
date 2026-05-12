Public Class FormUser

    ' 1. Logika saat baris di tabel diklik (mengisi input otomatis)
    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        ' Pastikan yang diklik adalah baris data, bukan header
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvUsers.Rows(e.RowIndex)

            txtUsername.Text = row.Cells("colUsername").Value.ToString()
            txtNamaLengkap.Text = row.Cells("colNamaLengkap").Value.ToString()
            cmbLevel.SelectedItem = row.Cells("colLevel").Value.ToString()
            cmbStatus.SelectedItem = row.Cells("colStatus").Value.ToString()
        End If
    End Sub

    ' 2. Logika Reset Password
    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        If txtUsername.Text = "" Then
            MessageBox.Show("Pilih user yang ingin di-reset password-nya!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim konfirmasi = MessageBox.Show("Reset password untuk user '" & txtUsername.Text & "' menjadi '12345'?",
                                         "Konfirmasi Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            ' Di sini nanti akan ada kode untuk update password di database
            MessageBox.Show("Password berhasil di-reset!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class