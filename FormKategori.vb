Public Class FormKategori

    ' LOAD FORM
    Private Sub FormKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadDataDummy()

    End Sub

    ' LOAD DATA DUMMY
    Private Sub LoadDataDummy()

        DgvKategori.Rows.Clear()

        DgvKategori.Rows.Add("KAT001", "Kemeja", "Pakaian formal pria lengan panjang dan pendek")
        DgvKategori.Rows.Add("KAT002", "Kaos", "Pakaian santai bahan katun")
        DgvKategori.Rows.Add("KAT003", "Celana", "Berbagai jenis celana panjang dan pendek")
        DgvKategori.Rows.Add("KAT004", "Jaket", "Pakaian luaran untuk cuaca dingin")
        DgvKategori.Rows.Add("KAT005", "Aksesoris", "Ikat pinggang, dompet, dan topi")

    End Sub

    ' TAMBAH DATA
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click

        ' KOSONGKAN INPUT
        FormInputKategori.txtKodeKategori.Clear()
        FormInputKategori.txtNamaKategori.Clear()
        FormInputKategori.txtKeterangan.Clear()

        ' UBAH JUDUL FORM
        FormInputKategori.Text = "Tambah Kategori"

        ' TAMPILKAN FORM
        FormInputKategori.ShowDialog()

    End Sub

    ' UBAH DATA
    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click

        If DgvKategori.SelectedRows.Count = 0 Then

            MessageBox.Show(
                "Pilih data kategori terlebih dahulu!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Exit Sub

        End If

        ' AMBIL DATA DARI DGV
        Dim row As DataGridViewRow = DgvKategori.SelectedRows(0)

        ' KIRIM DATA KE FORM INPUT
        FormInputKategori.txtKodeKategori.Text = row.Cells(0).Value.ToString()
        FormInputKategori.txtNamaKategori.Text = row.Cells(1).Value.ToString()
        FormInputKategori.txtKeterangan.Text = row.Cells(2).Value.ToString()

        ' GANTI JUDUL FORM
        FormInputKategori.Text = "Ubah Kategori"

        ' TAMPILKAN FORM
        FormInputKategori.ShowDialog()

    End Sub

    ' HAPUS DATA
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click

        If DgvKategori.SelectedRows.Count = 0 Then

            MessageBox.Show(
                "Pilih data yang ingin dihapus!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Exit Sub

        End If

        Dim hasil As DialogResult

        hasil = MessageBox.Show(
            "Yakin ingin menghapus data kategori ini?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then

            DgvKategori.Rows.RemoveAt(DgvKategori.SelectedRows(0).Index)

            MessageBox.Show(
                "Data berhasil dihapus!",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

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

            If kode.Contains(keyword) Or
               nama.Contains(keyword) Or
               ket.Contains(keyword) Then

                row.Visible = True

            Else

                row.Visible = False

            End If

        Next

    End Sub

End Class