Imports MySql.Data.MySqlClient

Public Class FormLaporan

    ' =========================
    ' LOAD FORM
    ' =========================
    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpDari.Value = DateTime.Now.AddMonths(-1)
        dtpSampai.Value = DateTime.Now

        LoadDataLaporan()

    End Sub

    ' =========================
    ' MENAMPILKAN DATA LAPORAN
    ' =========================
    Private Sub LoadDataLaporan()

        dgvLaporan.Rows.Clear()

        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()

                Dim query As String =
                    "SELECT tanggal, total_transaksi, total_penjualan, estimasi_laba
                     FROM v_laporan_harian
                     WHERE tanggal BETWEEN @dari AND @sampai
                     ORDER BY tanggal DESC"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue(
                        "@dari",
                        dtpDari.Value.ToString("yyyy-MM-dd")
                    )

                    cmd.Parameters.AddWithValue(
                        "@sampai",
                        dtpSampai.Value.ToString("yyyy-MM-dd")
                    )

                    Dim totalTransaksi As Integer = 0
                    Dim totalPenjualan As Double = 0
                    Dim totalLaba As Double = 0

                    Using dr As MySqlDataReader = cmd.ExecuteReader()

                        While dr.Read()

                            Dim tanggal As String =
                                Format(CDate(dr("tanggal")), "dd/MM/yyyy")

                            Dim transaksi As Integer =
                                Convert.ToInt32(dr("total_transaksi"))

                            Dim penjualan As Double =
                                Convert.ToDouble(dr("total_penjualan"))

                            Dim laba As Double =
                                Convert.ToDouble(dr("estimasi_laba"))

                            dgvLaporan.Rows.Add(
                                tanggal,
                                transaksi,
                                Format(penjualan, "###,###,##0"),
                                Format(laba, "###,###,##0")
                            )

                            totalTransaksi += transaksi
                            totalPenjualan += penjualan
                            totalLaba += laba

                        End While

                    End Using

                    ' Menampilkan ringkasan laporan
                    lblTotalTransaksi.Text = totalTransaksi.ToString()
                    lblTotalPenjualan.Text = Format(totalPenjualan, "###,###,##0")
                    lblTotalLaba.Text = Format(totalLaba, "###,###,##0")

                End Using
            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Laporan gagal dimuat!" & vbNewLine & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

        UpdateChartBars()

    End Sub

    ' =========================
    ' VISUALISASI GRAFIK
    ' =========================
    Private Sub UpdateChartBars()

        pnlBar1.Height = 50
        pnlBar2.Height = 30
        pnlBar3.Height = 90
        pnlBar4.Height = 60
        pnlBar5.Height = 40
        pnlBar6.Height = 110

    End Sub

    ' =========================
    ' TOMBOL FILTER DATA
    ' =========================
    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click

        MessageBox.Show(
            "Menampilkan laporan dari " &
            dtpDari.Value.ToShortDateString() &
            " sampai " &
            dtpSampai.Value.ToShortDateString(),
            "Informasi",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

        LoadDataLaporan()

    End Sub

    ' =========================
    ' PERPINDAHAN TAB
    ' =========================
    Private Sub tabControlLaporan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabControlLaporan.SelectedIndexChanged

        If tabControlLaporan.SelectedTab Is tabStok Then

            ' Load data stok di sini

        ElseIf tabControlLaporan.SelectedTab Is tabPembelian Then

            ' Load data pembelian di sini

        End If

    End Sub

End Class