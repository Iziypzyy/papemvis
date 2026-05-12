Public Class FormKategori

    ' 1. Event saat Form pertama kali dibuka
    Private Sub FormKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Memuat data awal ke dalam tabel
        LoadDataDummy()
    End Sub

    ' 2. Logika untuk mengisi data ke tabel (DataGridView)
    Private Sub LoadDataDummy()
        ' Bersihkan tabel agar tidak terjadi duplikasi data saat load ulang
        DgvKategori.Rows.Clear()

        ' Menambahkan data kategori contoh (Kode Kategori, Nama Kategori, Keterangan)
        DgvKategori.Rows.Add("KAT001", "Kemeja", "Pakaian formal pria lengan panjang dan pendek")
        DgvKategori.Rows.Add("KAT002", "Kaos", "Pakaian santai bahan katun")
        DgvKategori.Rows.Add("KAT003", "Celana", "Berbagai jenis celana panjang dan pendek")
        DgvKategori.Rows.Add("KAT004", "Jaket", "Pakaian luaran untuk cuaca dingin")
        DgvKategori.Rows.Add("KAT005", "Aksesoris", "Ikat pinggang, dompet, dan topi")
    End Sub

    ' 3. Tombol aksi untuk manipulasi data
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        ' Placeholder untuk logika menambah baris baru atau membuka form input
        MessageBox.Show("Fungsi Tambah Kategori diaktifkan")
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        ' Placeholder untuk logika menyimpan data ke database
        MessageBox.Show("Data berhasil disimpan (Simulasi)")
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        ' Mengecek apakah ada baris yang dipilih sebelum mengubah
        If DgvKategori.SelectedRows.Count > 0 Then
            Dim namaKategori As String = DgvKategori.SelectedRows(0).Cells("ColNamaKategori").Value.ToString()
            MessageBox.Show("Mengubah kategori: " & namaKategori)
        Else
            MessageBox.Show("Pilih kategori yang ingin diubah terlebih dahulu!")
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        ' Logika menghapus baris yang dipilih dari tabel
        If DgvKategori.SelectedRows.Count > 0 Then
            Dim konfirmasi = MessageBox.Show("Hapus kategori ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If konfirmasi = DialogResult.Yes Then
                DgvKategori.Rows.RemoveAt(DgvKategori.SelectedRows(0).Index)
            End If
        End If
    End Sub

    ' 4. Logika Pencarian
    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        ' Placeholder untuk fungsi filter atau pencarian data
        MessageBox.Show("Fungsi Cari diaktifkan")
    End Sub

End Class