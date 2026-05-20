Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class Form8

    ' 1. Inisialisasi data saat form dimuat
    Private Sub FormPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTanggal.Value = DateTime.Now
        LoadDataDB()
    End Sub

    ' Load data detail pembelian terakhir dari database
    Private Sub LoadDataDB()
        dgvDetailPembelian.Rows.Clear()
        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()
                ' Ambil detail dari pembelian terakhir yang ada
                Dim query As String =
                    "SELECT dp.kode_barang, dp.nama_barang, dp.qty, dp.harga_satuan, dp.subtotal " &
                    "FROM detail_pembelian dp " &
                    "INNER JOIN pembelian p ON dp.id_pembelian = p.id_pembelian " &
                    "ORDER BY p.tgl_pembelian DESC, dp.id_detail " &
                    "LIMIT 20"

                Using cmd As New MySqlCommand(query, conn)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        Do While dr.Read()
                            dgvDetailPembelian.Rows.Add(
                                dr("kode_barang").ToString(),
                                dr("nama_barang").ToString(),
                                dr("qty").ToString(),
                                Format(Convert.ToDouble(dr("harga_satuan")), "###,###,##0"),
                                Format(Convert.ToDouble(dr("subtotal")), "###,###,##0")
                            )
                        Loop
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Jika gagal, tampilkan data kosong agar form tidak crash
        End Try

        HitungRingkasan()
    End Sub

    ' 2. Fungsi untuk menghitung total, item, dan grand total
    Private Sub HitungRingkasan()
        Dim totalItem As Integer = 0
        Dim subTotal As Double = 0
        Dim ongkir As Double = 0

        For Each row As DataGridViewRow In dgvDetailPembelian.Rows
            If Not row.IsNewRow Then
                totalItem += Val(row.Cells("colQty").Value)
                subTotal += Val(row.Cells("colSubTotal").Value.ToString().Replace(".", ""))
            End If
        Next

        Double.TryParse(txtOngkir.Text, ongkir)

        lblOutputTotalItem.Text = totalItem.ToString()
        lblOutputTotal.Text = subTotal.ToString("N0")
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