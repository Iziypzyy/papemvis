Public Class FormLaporan

    ' 1. Event saat Form pertama kali dimuat
    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Atur rentang tanggal default (misal: sebulan terakhir)
        dtpDari.Value = DateTime.Now.AddMonths(-1)
        dtpSampai.Value = DateTime.Now

        ' Isi data awal ke tabel dan grafik
        LoadDataLaporan()
    End Sub

    ' 2. Logika untuk mengisi data ke tabel dan visualisasi grafik
    Private Sub LoadDataLaporan()
        ' Bersihkan baris lama di DataGridView
        dgvLaporan.Rows.Clear()

        ' Menambahkan data contoh transaksi (Tanggal, Total Transaksi, Penjualan, Laba)
        dgvLaporan.Rows.Add("16/05/2026", "5", "2.500.000", "1.000.000")
        dgvLaporan.Rows.Add("17/05/2026", "3", "1.200.000", "500.000")
        dgvLaporan.Rows.Add("18/05/2026", "8", "4.800.000", "2.100.000")
        dgvLaporan.Rows.Add("20/05/2026", "4", "3.100.000", "1.200.000")
        dgvLaporan.Rows.Add("21/05/2026", "10", "1.400.000", "480.000")

        ' Update label rangkuman (Summary) di bagian bawah
        lblTotalTransaksi.Text = "30"
        lblTotalPenjualan.Text = "13.000.000"
        lblTotalLaba.Text = "5.280.000"

        ' Panggil fungsi untuk mengatur tinggi batang grafik
        UpdateChartBars()
    End Sub

    ' 3. Logika untuk mengatur visualisasi Grafik Batang (Faux Chart)
    Private Sub UpdateChartBars()
        ' Kita mengatur tinggi (Height) panel secara manual berdasarkan data
        ' Semakin besar nilai penjualan, semakin tinggi panelnya
        pnlBar1.Height = 50  ' Data tgl 16
        pnlBar2.Height = 30  ' Data tgl 17
        pnlBar3.Height = 90  ' Data tgl 18 (Tertinggi)
        pnlBar4.Height = 60  ' Data tgl 20
        pnlBar5.Height = 40  ' Data tgl 21
        pnlBar6.Height = 110 ' Data tgl 22

        ' Catatan: Lokasi Y harus disesuaikan agar batang tetap menempel di bawah
        ' Biasanya dihitung: (Titik Dasar Grafik - Tinggi Batang)
    End Sub

    ' 4. Tombol Filter Data
    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        ' Logika untuk menyaring data berdasarkan dtpDari dan dtpSampai
        MessageBox.Show("Menampilkan laporan dari " & dtpDari.Value.ToShortDateString &
                        " hingga " & dtpSampai.Value.ToShortDateString)

        LoadDataLaporan()
    End Sub

    ' 5. Event saat Tab berpindah
    Private Sub tabControlLaporan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControlLaporan.SelectedIndexChanged
        ' Memberikan respon berbeda saat user pindah ke tab Stok atau Pembelian
        If tabControlLaporan.SelectedTab Is tabStok Then
            ' Load data khusus stok
        ElseIf tabControlLaporan.SelectedTab Is tabPembelian Then
            ' Load data khusus pembelian
        End If
    End Sub

End Class