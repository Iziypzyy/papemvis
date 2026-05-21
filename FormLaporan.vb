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

                ' 1. Query disinkronkan kolomnya
                Dim query As String =
                "SELECT tanggal, total_transaksi, total_barang_terjual, total_pendapatan_bersih " &
                "FROM laporan_harian " &
                "WHERE tanggal BETWEEN @dari AND @sampai " &
                "ORDER BY tanggal DESC"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@dari", dtpDari.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@sampai", dtpSampai.Value.ToString("yyyy-MM-dd"))

                    Dim totalTransaksi As Integer = 0
                    Dim totalPenjualan As Double = 0
                    Dim totalLaba As Double = 0

                    Using dr As MySqlDataReader = cmd.ExecuteReader()

                        While dr.Read()

                            Dim tanggal As String = Format(CDate(dr("tanggal")), "dd/MM/yyyy")
                            Dim transaksi As Integer = Convert.ToInt32(dr("total_transaksi"))

                            ' Nama kolom disamakan dengan SQL Select
                            Dim penjualan As Double = Convert.ToDouble(dr("total_barang_terjual"))
                            Dim laba As Double = Convert.ToDouble(dr("total_pendapatan_bersih"))

                            ' Memasukkan data ke baris Grid DataGridView
                            dgvLaporan.Rows.Add(
                            tanggal,
                            transaksi,
                            Format(penjualan, "N0"),
                            Format(laba, "N0")
                        )

                            totalTransaksi += transaksi
                            totalPenjualan += penjualan
                            totalLaba += laba

                        End While

                    End Using

                    ' Menampilkan ringkasan laporan ke komponen label di bawah form
                    lblTotalTransaksi.Text = totalTransaksi.ToString("N0")
                    lblTotalPenjualan.Text = totalPenjualan.ToString("N0")
                    lblTotalLaba.Text = totalLaba.ToString("N0")

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