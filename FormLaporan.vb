Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class FormLaporan

    ' 1. Event saat Form pertama kali dimuat
    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDari.Value = DateTime.Now.AddMonths(-1)
        dtpSampai.Value = DateTime.Now
        LoadDataLaporan()
    End Sub

    ' 2. Logika untuk mengisi data ke tabel dari database
    Private Sub LoadDataLaporan()
        dgvLaporan.Rows.Clear()

        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()
                ' Ambil dari VIEW v_laporan_harian dengan filter tanggal
                Dim query As String =
                    "SELECT tanggal, total_transaksi, total_penjualan, estimasi_laba " &
                    "FROM v_laporan_harian " &
                    "WHERE tanggal BETWEEN @dari AND @sampai " &
                    "ORDER BY tanggal DESC"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@dari", dtpDari.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@sampai", dtpSampai.Value.ToString("yyyy-MM-dd"))

                    Dim totalTransaksi As Long = 0
                    Dim totalPenjualan As Double = 0
                    Dim totalLaba As Double = 0

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        Do While dr.Read()
                            Dim tanggal As String = Convert.ToDateTime(dr("tanggal")).ToString("dd/MM/yyyy")
                            Dim trx As String = dr("total_transaksi").ToString()
                            Dim penjualan As Double = Convert.ToDouble(dr("total_penjualan"))
                            Dim laba As Double = Convert.ToDouble(dr("estimasi_laba"))

                            dgvLaporan.Rows.Add(
                                tanggal,
                                trx,
                                Format(penjualan, "###,###,##0"),
                                Format(laba, "###,###,##0")
                            )

                            totalTransaksi += Convert.ToInt64(dr("total_transaksi"))
                            totalPenjualan += penjualan
                            totalLaba += laba
                        Loop
                    End Using

                    ' Update label summary
                    lblTotalTransaksi.Text = totalTransaksi.ToString()
                    lblTotalPenjualan.Text = Format(totalPenjualan, "###,###,##0")
                    lblTotalLaba.Text = Format(totalLaba, "###,###,##0")
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat laporan!" & vbNewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        UpdateChartBars()
    End Sub

    ' 3. Logika untuk mengatur visualisasi Grafik Batang (tetap seperti aslinya)
    Private Sub UpdateChartBars()
        pnlBar1.Height = 50
        pnlBar2.Height = 30
        pnlBar3.Height = 90
        pnlBar4.Height = 60
        pnlBar5.Height = 40
        pnlBar6.Height = 110
    End Sub

    ' 4. Tombol Filter Data
    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        MessageBox.Show("Menampilkan laporan dari " & dtpDari.Value.ToShortDateString &
                        " hingga " & dtpSampai.Value.ToShortDateString)
        LoadDataLaporan()
    End Sub

    ' 5. Event saat Tab berpindah
    Private Sub tabControlLaporan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControlLaporan.SelectedIndexChanged
        If tabControlLaporan.SelectedTab Is tabStok Then
            ' Load data khusus stok
        ElseIf tabControlLaporan.SelectedTab Is tabPembelian Then
            ' Load data khusus pembelian
        End If
    End Sub

End Class