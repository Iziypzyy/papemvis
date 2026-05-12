Public Class Form8

    ' 1. Inisialisasi data saat form dimuat
    Private Sub FormPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set tanggal ke hari ini
        dtpTanggal.Value = DateTime.Now

        ' Tambahkan data contoh ke tabel detail
        dgvDetailPembelian.Rows.Add("B001", "Kemeja Formal Slim Fit", "20", "150000", "3000000")
        dgvDetailPembelian.Rows.Add("B002", "Celana Chino Khaki", "15", "110000", "1650000")

        ' Hitung total awal
        HitungRingkasan()
    End Sub

    ' 2. Fungsi untuk menghitung total, item, dan grand total
    Private Sub HitungRingkasan()
        Dim totalItem As Integer = 0
        Dim subTotal As Double = 0
        Dim ongkir As Double = 0

        ' Iterasi setiap baris di DataGridView
        For Each row As DataGridViewRow In dgvDetailPembelian.Rows
            If Not row.IsNewRow Then
                totalItem += Val(row.Cells("colQty").Value)
                subTotal += Val(row.Cells("colSubTotal").Value)
            End If
        Next

        ' Ambil nilai ongkir dari textbox
        Double.TryParse(txtOngkir.Text, ongkir)

        ' Update label output
        lblOutputTotalItem.Text = totalItem.ToString()
        lblOutputTotal.Text = subTotal.ToString("N0") ' Format angka dengan pemisah ribuan
        lblOutputGrandTotal.Text = (subTotal + ongkir).ToString("N0")
    End Sub

    ' 3. Update perhitungan saat nilai ongkir berubah
    Private Sub txtOngkir_TextChanged(sender As Object, e As EventArgs) Handles txtOngkir.TextChanged
        HitungRingkasan()
    End Sub

    ' 4. Logika tombol Batal
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        If MessageBox.Show("Batalkan transaksi ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class