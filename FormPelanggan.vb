Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class FormPelanggan

    ' LOAD FORM
    Private Sub FormPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataDB()
    End Sub

    ' LOAD DATA DARI DATABASE
    Public Sub LoadDataDB()
        DgvPelanggan.Rows.Clear()
        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()
                ' Catatan: kolom no_telepon & kota tidak ada di tabel pelanggan (sesuai SQL)
                ' Tampilkan kode, nama, email, tgl daftar
                Dim query As String =
                    "SELECT kode_pelanggan, nama_pelanggan, email, created_at " &
                    "FROM pelanggan ORDER BY kode_pelanggan"
                Using cmd As New MySqlCommand(query, conn)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        Do While dr.Read()
                            DgvPelanggan.Rows.Add(
                                dr("kode_pelanggan").ToString(),
                                dr("nama_pelanggan").ToString(),
                                dr("email").ToString(),
                                Convert.ToDateTime(dr("created_at")).ToString("dd/MM/yyyy")
                            )
                        Loop
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data pelanggan!" & vbNewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' TOMBOL TAMBAH
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        FormInputPelanggan.txtKode.Text = ""
        FormInputPelanggan.txtNama.Text = ""
        FormInputPelanggan.txtNoTelp.Text = ""
        FormInputPelanggan.txtKota.Text = ""
        FormInputPelanggan.Text = "Tambah Pelanggan"
        FormInputPelanggan.ShowDialog()
        LoadDataDB()
    End Sub

    ' TOMBOL UBAH
    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        If DgvPelanggan.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data pelanggan terlebih dahulu!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim row As DataGridViewRow = DgvPelanggan.SelectedRows(0)
        FormInputPelanggan.txtKode.Text = row.Cells(0).Value.ToString()
        FormInputPelanggan.txtNama.Text = row.Cells(1).Value.ToString()
        FormInputPelanggan.txtNoTelp.Text = row.Cells(2).Value.ToString()
        FormInputPelanggan.txtKota.Text = row.Cells(3).Value.ToString()
        FormInputPelanggan.Text = "Ubah Pelanggan"
        FormInputPelanggan.ShowDialog()
        LoadDataDB()
    End Sub

    ' TOMBOL HAPUS
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If DgvPelanggan.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data yang ingin dihapus!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim kode As String = DgvPelanggan.SelectedRows(0).Cells(0).Value.ToString()
        Dim hasil As DialogResult = MessageBox.Show("Yakin ingin menghapus data pelanggan ini?",
                                                    "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            Try
                Using conn As MySqlConnection = KoneksiDB.GetConnection()
                    Dim query As String = "DELETE FROM pelanggan WHERE kode_pelanggan = @kode"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@kode", kode)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Data berhasil dihapus!", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadDataDB()
            Catch ex As Exception
                MessageBox.Show("Gagal menghapus data!" & vbNewLine & ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' SEARCH DATA
    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        Dim keyword As String = TxtCari.Text.ToLower()
        For Each row As DataGridViewRow In DgvPelanggan.Rows
            If row.IsNewRow Then Continue For
            Dim nama As String = row.Cells(1).Value.ToString().ToLower()
            Dim kode As String = row.Cells(0).Value.ToString().ToLower()
            Dim email As String = row.Cells(2).Value.ToString().ToLower()
            If nama.Contains(keyword) Or kode.Contains(keyword) Or email.Contains(keyword) Then
                row.Visible = True
            Else
                row.Visible = False
            End If
        Next
    End Sub

End Class