Public Class FormUser

    ' LOAD FORM
    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' DATA DUMMY
        dgvUsers.Rows.Add("admin", "Administrator Utama", "Administrator", "Aktif", "20/05/2026 08:15")
        dgvUsers.Rows.Add("kasir01", "Budi Santoso", "Kasir", "Aktif", "19/05/2026 14:20")
        dgvUsers.Rows.Add("gudang01", "Andi Wijaya", "Gudang", "Non-Aktif", "18/05/2026 10:05")

        ' Default combobox
        cmbLevel.SelectedIndex = 0
        cmbStatus.SelectedIndex = 0

    End Sub

    ' SAAT DATA DIKLIK
    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = dgvUsers.Rows(e.RowIndex)

            txtUsername.Text = row.Cells("colUsername").Value.ToString()
            txtNamaLengkap.Text = row.Cells("colNamaLengkap").Value.ToString()
            cmbLevel.SelectedItem = row.Cells("colLevel").Value.ToString()
            cmbStatus.SelectedItem = row.Cells("colStatus").Value.ToString()

        End If

    End Sub

    ' TOMBOL TAMBAH
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        ' VALIDASI
        If txtUsername.Text = "" Or
           txtNamaLengkap.Text = "" Or
           cmbLevel.Text = "" Or
           cmbStatus.Text = "" Then

            MessageBox.Show("Semua data wajib diisi!",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            Exit Sub
        End If

        ' TAMBAH DATA
        dgvUsers.Rows.Add(
            txtUsername.Text,
            txtNamaLengkap.Text,
            cmbLevel.Text,
            cmbStatus.Text,
            DateTime.Now.ToString("dd/MM/yyyy HH:mm")
        )

        MessageBox.Show("Data user berhasil ditambahkan!",
                        "Berhasil",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

        BersihkanForm()

    End Sub

    ' TOMBOL UBAH
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click

        ' Cek row yang dipilih
        If dgvUsers.CurrentRow Is Nothing Then

            MessageBox.Show("Pilih data user yang ingin dihapus!",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)

            Exit Sub

        End If

        Dim row As DataGridViewRow = dgvUsers.CurrentRow

        ' UPDATE DATA
        row.Cells("colUsername").Value = txtUsername.Text
        row.Cells("colNamaLengkap").Value = txtNamaLengkap.Text
        row.Cells("colLevel").Value = cmbLevel.Text
        row.Cells("colStatus").Value = cmbStatus.Text

        MessageBox.Show("Data user berhasil diubah!",
                        "Berhasil",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

        BersihkanForm()

    End Sub

    ' TOMBOL HAPUS
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        ' Cek row yang dipilih
        If dgvUsers.CurrentRow Is Nothing Then

            MessageBox.Show("Pilih data user yang ingin dihapus!",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)

            Exit Sub

        End If

        ' Konfirmasi hapus
        Dim konfirmasi As DialogResult

        konfirmasi = MessageBox.Show(
        "Yakin ingin menghapus user ini?",
        "Konfirmasi Hapus",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If konfirmasi = DialogResult.Yes Then

            dgvUsers.Rows.Remove(dgvUsers.CurrentRow)

            MessageBox.Show("Data berhasil dihapus!",
                        "Berhasil",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

            BersihkanForm()

        End If

    End Sub

    ' RESET PASSWORD
    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click

        If txtUsername.Text = "" Then

            MessageBox.Show("Pilih user yang ingin di-reset password!",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            Exit Sub

        End If

        Dim konfirmasi As DialogResult

        konfirmasi = MessageBox.Show(
            "Reset password user '" & txtUsername.Text & "' menjadi '12345' ?",
            "Konfirmasi Reset",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If konfirmasi = DialogResult.Yes Then

            MessageBox.Show("Password berhasil di-reset menjadi 12345!",
                            "Berhasil",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

        End If

    End Sub

    ' SEARCH USER
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

        Dim keyword As String = txtCari.Text.ToLower()

        For Each row As DataGridViewRow In dgvUsers.Rows

            If row.IsNewRow Then Continue For

            Dim username As String = row.Cells("colUsername").Value.ToString().ToLower()
            Dim nama As String = row.Cells("colNamaLengkap").Value.ToString().ToLower()
            Dim level As String = row.Cells("colLevel").Value.ToString().ToLower()

            If username.Contains(keyword) Or
               nama.Contains(keyword) Or
               level.Contains(keyword) Then

                row.Visible = True

            Else

                row.Visible = False

            End If

        Next

    End Sub

    ' UPLOAD FOTO
    Private Sub btnAmbilFoto_Click(sender As Object, e As EventArgs) Handles btnAmbilFoto.Click

        Dim openFile As New OpenFileDialog

        openFile.Title = "Pilih Foto"
        openFile.Filter = "File Gambar|*.jpg;*.jpeg;*.png"

        If openFile.ShowDialog = DialogResult.OK Then

            picAvatar.Image = Image.FromFile(openFile.FileName)

        End If

    End Sub

    ' MEMBERSIHKAN FORM
    Private Sub BersihkanForm()

        txtUsername.Clear()
        txtNamaLengkap.Clear()

        cmbLevel.SelectedIndex = -1
        cmbStatus.SelectedIndex = -1

        picAvatar.Image = Nothing

        dgvUsers.ClearSelection()

    End Sub

End Class