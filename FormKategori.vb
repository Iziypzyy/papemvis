Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class FormKategori

    ' LOAD FORM
    Private Sub FormKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataDB()
    End Sub

    ' LOAD DATA DARI DATABASE (menggantikan LoadDataDummy)
    Public Sub LoadDataDB()
        DgvKategori.Rows.Clear()

        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()
                Dim query As String = "SELECT kode_kategori, nama_kategori, keterangan FROM kategori ORDER BY kode_kategori"
                Using cmd As New MySqlCommand(query, conn)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        Do While dr.Read()
                            DgvKategori.Rows.Add(
                                dr("kode_kategori").ToString(),
                                dr("nama_kategori").ToString(),
                                dr("keterangan").ToString()
                            )
                        Loop
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data kategori!" & vbNewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' TAMBAH DATA
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        FormInputKategori.txtKodeKategori.Clear()
        FormInputKategori.txtNamaKategori.Clear()
        FormInputKategori.txtKeterangan.Clear()
        FormInputKategori.Text = "Tambah Kategori"
        FormInputKategori.ShowDialog()
        LoadDataDB() ' Refresh setelah tambah
    End Sub

    ' UBAH DATA
    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        If DgvKategori.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data kategori terlebih dahulu!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim row As DataGridViewRow = DgvKategori.SelectedRows(0)
        FormInputKategori.txtKodeKategori.Text = row.Cells(0).Value.ToString()
        FormInputKategori.txtNamaKategori.Text = row.Cells(1).Value.ToString()
        FormInputKategori.txtKeterangan.Text = row.Cells(2).Value.ToString()
        FormInputKategori.Text = "Ubah Kategori"
        FormInputKategori.ShowDialog()
        LoadDataDB() ' Refresh setelah ubah
    End Sub

    ' HAPUS DATA
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If DgvKategori.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data yang ingin dihapus!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim kode As String = DgvKategori.SelectedRows(0).Cells(0).Value.ToString()
        Dim hasil As DialogResult = MessageBox.Show("Yakin ingin menghapus data kategori ini?",
                                                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            Try
                Using conn As MySqlConnection = KoneksiDB.GetConnection()
                    Dim query As String = "DELETE FROM kategori WHERE kode_kategori = @kode"
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
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Dim keyword As String = txtCari.Text.ToLower()

        For Each row As DataGridViewRow In DgvKategori.Rows
            If row.IsNewRow Then Continue For

            Dim kode As String = row.Cells(0).Value.ToString().ToLower()
            Dim nama As String = row.Cells(1).Value.ToString().ToLower()
            Dim ket As String = row.Cells(2).Value.ToString().ToLower()

            If kode.Contains(keyword) Or nama.Contains(keyword) Or ket.Contains(keyword) Then
                row.Visible = True
            Else
                row.Visible = False
            End If
        Next
    End Sub

End Class