Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class FormUser

    ' LOAD FORM
    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbLevel.SelectedIndex = 0
        cmbStatus.SelectedIndex = 0
        LoadDataDB()
    End Sub

    Public Sub LoadDataDB()
        dgvUsers.Rows.Clear()
        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()
                Dim query As String =
                    "SELECT username, nama_lengkap, level, status, created_at FROM users ORDER BY id_user"
                Using cmd As New MySqlCommand(query, conn)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        Do While dr.Read()
                            dgvUsers.Rows.Add(
                                dr("username").ToString(),
                                dr("nama_lengkap").ToString(),
                                dr("level").ToString(),
                                dr("status").ToString(),
                                Convert.ToDateTime(dr("created_at")).ToString("dd/MM/yyyy HH:mm")
                            )
                        Loop
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data user!" & vbNewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
        If txtUsername.Text = "" Or txtNamaLengkap.Text = "" Or
           cmbLevel.Text = "" Or cmbStatus.Text = "" Then
            MessageBox.Show("Semua data wajib diisi!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()
                Dim query As String =
                    "INSERT INTO users (username, nama_lengkap, password, level, status) " &
                    "VALUES (@user, @nama, '12345', @level, @status)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@user", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@nama", txtNamaLengkap.Text)
                    cmd.Parameters.AddWithValue("@level", cmbLevel.Text)
                    cmd.Parameters.AddWithValue("@status", cmbStatus.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Data user berhasil ditambahkan! Password default: 12345", "Berhasil",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            BersihkanForm()
            LoadDataDB()
        Catch ex As Exception
            MessageBox.Show("Gagal menambah user!" & vbNewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' TOMBOL UBAH
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If dgvUsers.CurrentRow Is Nothing Then
            MessageBox.Show("Pilih data user yang ingin diubah!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()
                Dim query As String =
                    "UPDATE users SET nama_lengkap = @nama, level = @level, status = @status " &
                    "WHERE username = @user"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nama", txtNamaLengkap.Text)
                    cmd.Parameters.AddWithValue("@level", cmbLevel.Text)
                    cmd.Parameters.AddWithValue("@status", cmbStatus.Text)
                    cmd.Parameters.AddWithValue("@user", txtUsername.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Data user berhasil diubah!", "Berhasil",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            BersihkanForm()
            LoadDataDB()
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah user!" & vbNewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' TOMBOL HAPUS
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvUsers.CurrentRow Is Nothing Then
            MessageBox.Show("Pilih data user yang ingin dihapus!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Yakin ingin menghapus user ini?", "Konfirmasi Hapus",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            Dim username As String = dgvUsers.CurrentRow.Cells("colUsername").Value.ToString()
            Try
                Using conn As MySqlConnection = KoneksiDB.GetConnection()
                    Dim query As String = "DELETE FROM users WHERE username = @user"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@user", username)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Data berhasil dihapus!", "Berhasil",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                BersihkanForm()
                LoadDataDB()
            Catch ex As Exception
                MessageBox.Show("Gagal menghapus user!" & vbNewLine & ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' RESET PASSWORD
    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        If txtUsername.Text = "" Then
            MessageBox.Show("Pilih user yang ingin di-reset password!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Reset password user '" & txtUsername.Text & "' menjadi '12345' ?",
            "Konfirmasi Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            Try
                Using conn As MySqlConnection = KoneksiDB.GetConnection()
                    Dim query As String = "UPDATE users SET password = '12345' WHERE username = @user"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@user", txtUsername.Text)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Password berhasil di-reset menjadi 12345!", "Berhasil",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Gagal reset password!" & vbNewLine & ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
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
            If username.Contains(keyword) Or nama.Contains(keyword) Or level.Contains(keyword) Then
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