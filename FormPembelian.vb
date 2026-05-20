Imports MySql.Data.MySqlClient

Public Class Form8

    ' =====================================
    ' LOAD FORM
    ' =====================================
    Private Sub FormPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpTanggal.Value = DateTime.Now

        LoadDataDB()

    End Sub

    ' =====================================
    ' MENAMPILKAN DATA PEMBELIAN
    ' =====================================
    Private Sub LoadDataDB()

        dgvDetailPembelian.Rows.Clear()

        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()

                Dim query As String =
                    "SELECT " &
                    "dp.kode_barang, " &
                    "dp.nama_barang, " &
                    "dp.qty, " &
                    "dp.harga_satuan, " &
                    "dp.subtotal " &
                    "FROM detail_pembelian dp " &
                    "INNER JOIN pembelian p " &
                    "ON dp.id_pembelian = p.id_pembelian " &
                    "ORDER BY p.tgl_pembelian DESC, dp.id_detail " &
                    "LIMIT 20"

                Using cmd As New MySqlCommand(query, conn)

                    Using dr As MySqlDataReader = cmd.ExecuteReader()

                        While dr.Read()

                            dgvDetailPembelian.Rows.Add(
                                dr("kode_barang").ToString(),
                                dr("nama_barang").ToString(),
                                dr("qty").ToString(),
                                Convert.ToDouble(dr("harga_satuan")).ToString("N0"),
                                Convert.ToDouble(dr("subtotal")).ToString("N0")
                            )

                        End While

                    End Using
                End Using
            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Gagal memuat data pembelian!" &
                Environment.NewLine &
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

        HitungRingkasan()

    End Sub

    ' =====================================
    ' HITUNG TOTAL PEMBELIAN
    ' =====================================
    Private Sub HitungRingkasan()

        Dim totalItem As Integer = 0
        Dim subTotal As Double = 0
        Dim ongkir As Double = 0

        For Each row As DataGridViewRow In dgvDetailPembelian.Rows

            If row.IsNewRow Then Continue For

            totalItem += Val(row.Cells("colQty").Value)

            subTotal += Val(
                row.Cells("colSubTotal").Value.ToString().
                Replace(".", "").
                Replace(",", "")
            )

        Next

        Double.TryParse(txtOngkir.Text, ongkir)

        lblOutputTotalItem.Text = totalItem.ToString()
        lblOutputTotal.Text = subTotal.ToString("N0")
        lblOutputGrandTotal.Text = (subTotal + ongkir).ToString("N0")

    End Sub

    ' =====================================
    ' SAAT ONGKIR BERUBAH
    ' =====================================
    Private Sub txtOngkir_TextChanged(sender As Object, e As EventArgs) Handles txtOngkir.TextChanged

        HitungRingkasan()

    End Sub

    ' =====================================
    ' TOMBOL BATAL
    ' =====================================
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click

        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Batalkan transaksi ini?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If konfirmasi = DialogResult.Yes Then

            Me.Close()

        End If

    End Sub

End Class