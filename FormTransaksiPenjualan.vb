Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Drawing.Printing
Imports System.Globalization

Public Class FormTransaksiPenjualan

    Private dtKeranjang As New DataTable()
    Private printText As String = ""

    Private Sub FormTransaksiPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' agar form menerima KeyDown walau fokus di control
        Me.KeyPreview = True

        InitializeKeranjang()
        LoadPelanggan()
        LoadBarang()
        GenerateNoTransaksi()
    End Sub

    ' ================== KERANJANG ==================
    Private Sub InitializeKeranjang()
        dtKeranjang.Columns.Clear()
        dtKeranjang.Columns.Add("kode_barang", GetType(String))
        dtKeranjang.Columns.Add("nama_barang", GetType(String))
        dtKeranjang.Columns.Add("qty", GetType(Integer))
        dtKeranjang.Columns.Add("harga", GetType(Decimal))
        dtKeranjang.Columns.Add("subtotal", GetType(Decimal))

        ' jangan auto-generate karena kolom sudah didefinisikan di Designer
        DgvKeranjang.AutoGenerateColumns = False

        ' pastikan nama kolom designer sesuai, lalu map DataPropertyName
        ColKodeBarang.DataPropertyName = "kode_barang"
        ColNamaBarang.DataPropertyName = "nama_barang"
        ColQty.DataPropertyName = "qty"
        ColHarga.DataPropertyName = "harga"
        ColSubTotal.DataPropertyName = "subtotal"

        ' format tampilan kolom angka
        ColHarga.DefaultCellStyle.Format = "N0"
        ColHarga.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        ColSubTotal.DefaultCellStyle.Format = "N0"
        ColSubTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        ColQty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DgvKeranjang.DataSource = dtKeranjang
    End Sub

    ' isi nomor baris setelah data binding selesai
    Private Sub DgvKeranjang_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DgvKeranjang.DataBindingComplete
        For i As Integer = 0 To DgvKeranjang.Rows.Count - 1
            If Not DgvKeranjang.Rows(i).IsNewRow Then
                DgvKeranjang.Rows(i).Cells("ColNo").Value = (i + 1).ToString()
            End If
        Next
    End Sub

    ' ================== PELANGGAN ==================
    Private Sub LoadPelanggan()
        Dim dt As DataTable = ExecSelect("SELECT kode_pelanggan, nama_pelanggan FROM pelanggan ORDER BY kode_pelanggan")
        CboPelanggan.DataSource = dt
        CboPelanggan.DisplayMember = "nama_pelanggan"
        CboPelanggan.ValueMember = "kode_pelanggan"
        CboPelanggan.SelectedIndex = -1
    End Sub

    ' ================== BARANG ==================
    Private Sub LoadBarang()
        Dim dt As DataTable = ExecSelect("SELECT kode_barang, nama_barang, harga, stok FROM barang")
        CboBarang.DataSource = dt
        CboBarang.DisplayMember = "nama_barang"
        CboBarang.ValueMember = "kode_barang"
        CboBarang.SelectedIndex = -1
    End Sub

    ' ================== NO TRANSAKSI ==================
    Private Sub GenerateNoTransaksi()
        TxtNoTransaksi.Text = "TRX-" & Format(Now, "yyyyMMddHHmmss")
    End Sub

    ' ================== PILIH BARANG ==================
    Private Sub CboBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboBarang.SelectedIndexChanged
        If CboBarang.SelectedIndex < 0 Then
            TxtHarga.Text = "0"
            HitungSubtotalItem()
            Return
        End If

        Dim row As DataRowView = CType(CboBarang.SelectedItem, DataRowView)
        TxtHarga.Text = row("harga").ToString()
        HitungSubtotalItem()
    End Sub

    Private Sub NudQty_ValueChanged(sender As Object, e As EventArgs) Handles NudQty.ValueChanged
        HitungSubtotalItem()
    End Sub

    Private Sub HitungSubtotalItem()
        Dim harga As Decimal = 0D
        Decimal.TryParse(TxtHarga.Text, NumberStyles.AllowThousands Or NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, harga)
        Dim qty As Integer = CInt(NudQty.Value)
        TxtSubTotalItem.Text = (harga * qty).ToString("N0")
    End Sub

    ' ================== TAMBAH ITEM (BTN +) ==================
    Private Sub BtnPlus_Click(sender As Object, e As EventArgs) Handles BtnPlus.Click
        If CboBarang.SelectedIndex < 0 Then
            MessageBox.Show("Pilih barang terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim row As DataRowView = CType(CboBarang.SelectedItem, DataRowView)
        Dim kode As String = row("kode_barang").ToString()
        Dim nama As String = row("nama_barang").ToString()
        Dim harga As Decimal = Convert.ToDecimal(row("harga"))
        Dim qty As Integer = CInt(NudQty.Value)
        Dim subtotal As Decimal = harga * qty

        ' Jika barang sudah ada di keranjang, tambah qty
        Dim found As DataRow = Nothing
        For Each r As DataRow In dtKeranjang.Rows
            If r("kode_barang").ToString() = kode Then
                found = r
                Exit For
            End If
        Next

        If found IsNot Nothing Then
            found("qty") = CInt(found("qty")) + qty
            found("subtotal") = CDec(found("qty")) * CDec(found("harga"))
        Else
            dtKeranjang.Rows.Add(kode, nama, qty, harga, subtotal)
        End If

        HitungTotal()
    End Sub

    ' ================== HAPUS ITEM (BTN -) ==================
    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        If DgvKeranjang.CurrentRow IsNot Nothing Then
            Dim idx = DgvKeranjang.CurrentRow.Index
            If idx >= 0 AndAlso idx < dtKeranjang.Rows.Count Then
                dtKeranjang.Rows.RemoveAt(idx)
            End If
        End If
        HitungTotal()
    End Sub

    ' ================== TOTAL ==================
    Private Sub HitungTotal()
        Dim total As Decimal = 0D
        Dim totalItem As Integer = 0
        For Each r As DataRow In dtKeranjang.Rows
            total += CDec(r("subtotal"))
            totalItem += CInt(r("qty"))
        Next

        Dim diskon As Decimal = 0D
        Decimal.TryParse(TxtDiskon.Text, NumberStyles.AllowThousands Or NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, diskon)
        Dim grandTotal As Decimal = total - diskon
        If grandTotal < 0 Then grandTotal = 0

        LblTotalVal.Text = total.ToString("N0")
        LblGrandTotalVal.Text = grandTotal.ToString("N0")
        LblTotalItemVal.Text = totalItem.ToString()
    End Sub

    Private Sub TxtDiskon_TextChanged(sender As Object, e As EventArgs) Handles TxtDiskon.TextChanged
        HitungTotal()
    End Sub

    Private Sub FormTransaksiPenjualan_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control And e.KeyCode = Keys.P Then
            BtnPlus.PerformClick()
            e.SuppressKeyPress = True
        ElseIf e.Control And e.KeyCode = Keys.M Then
            BtnMin.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    ' =====================================
    ' TOMBOL PROSES - simpan penjualan ke DB, update stok, siapkan struk
    ' =====================================
    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        If dtKeranjang.Rows.Count = 0 Then
            MessageBox.Show("Keranjang kosong. Tambahkan barang terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim noTrans As String = TxtNoTransaksi.Text.Trim()
        Dim kodePelanggan As Object = If(CboPelanggan.SelectedValue, DBNull.Value)
        Dim tgl As DateTime = DtpTanggal.Value
        Dim total As Decimal = 0
        Dim diskon As Decimal = 0
        Decimal.TryParse(If(TxtDiskon.Text, "0").ToString().Replace(".", ""), diskon)

        For Each r As DataRow In dtKeranjang.Rows
            total += CDec(r("subtotal"))
        Next
        Dim grandTotal As Decimal = total - diskon
        If grandTotal < 0 Then grandTotal = 0

        ' Simpan ke DB dalam transaction
        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()
                Using tx = conn.BeginTransaction()
                    Try
                        ' Insert master penjualan
                        Dim sqlIns As String =
                            "INSERT INTO penjualan (no_transaksi, kode_pelanggan, tgl_penjualan, total, diskon, grand_total, created_by)
                             VALUES (@no, @pel, @tgl, @total, @diskon, @grand, @user)"
                        Using cmd As New MySqlCommand(sqlIns, conn, tx)
                            cmd.Parameters.AddWithValue("@no", noTrans)
                            If kodePelanggan Is DBNull.Value Then
                                cmd.Parameters.AddWithValue("@pel", DBNull.Value)
                            Else
                                cmd.Parameters.AddWithValue("@pel", kodePelanggan.ToString())
                            End If
                            cmd.Parameters.AddWithValue("@tgl", tgl)
                            cmd.Parameters.AddWithValue("@total", total)
                            cmd.Parameters.AddWithValue("@diskon", diskon)
                            cmd.Parameters.AddWithValue("@grand", grandTotal)
                            cmd.Parameters.AddWithValue("@user", Environment.UserName)
                            cmd.ExecuteNonQuery()
                        End Using

                        ' Ambil id yang baru
                        Dim idPenjualan As Long
                        Using cmdId As New MySqlCommand("SELECT LAST_INSERT_ID()", conn, tx)
                            idPenjualan = Convert.ToInt64(cmdId.ExecuteScalar())
                        End Using

                        ' Proses setiap item: cek stok, insert detail, update stok
                        For Each r As DataRow In dtKeranjang.Rows
                            Dim kode As String = r("kode_barang").ToString()
                            Dim nama As String = r("nama_barang").ToString()
                            Dim qty As Integer = CInt(r("qty"))
                            Dim harga As Decimal = CDec(r("harga"))
                            Dim subtotal As Decimal = CDec(r("subtotal"))

                            ' Cek stok saat ini
                            Dim stokNow As Integer = 0
                            Using cmdCheck As New MySqlCommand("SELECT stok FROM barang WHERE kode_barang = @kode FOR UPDATE", conn, tx)
                                cmdCheck.Parameters.AddWithValue("@kode", kode)
                                Dim obj = cmdCheck.ExecuteScalar()
                                If obj IsNot Nothing AndAlso IsNumeric(obj) Then Integer.TryParse(obj.ToString(), stokNow)
                            End Using

                            If stokNow < qty Then
                                tx.Rollback()
                                MessageBox.Show($"Stok tidak cukup untuk {nama}. Stok saat ini: {stokNow}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return
                            End If

                            ' Insert detail
                            Dim sqlDet As String =
                                "INSERT INTO detail_penjualan (id_penjualan, kode_barang, nama_barang, qty, harga, subtotal)
                                 VALUES (@id, @kode, @nama, @qty, @harga, @sub)"
                            Using cmdDet As New MySqlCommand(sqlDet, conn, tx)
                                cmdDet.Parameters.AddWithValue("@id", idPenjualan)
                                cmdDet.Parameters.AddWithValue("@kode", kode)
                                cmdDet.Parameters.AddWithValue("@nama", nama)
                                cmdDet.Parameters.AddWithValue("@qty", qty)
                                cmdDet.Parameters.AddWithValue("@harga", harga)
                                cmdDet.Parameters.AddWithValue("@sub", subtotal)
                                cmdDet.ExecuteNonQuery()
                            End Using

                            ' Kurangi stok
                            Dim sqlUpd As String = "UPDATE barang SET stok = IFNULL(stok,0) - @qty WHERE kode_barang = @kode"
                            Using cmdUpd As New MySqlCommand(sqlUpd, conn, tx)
                                cmdUpd.Parameters.AddWithValue("@qty", qty)
                                cmdUpd.Parameters.AddWithValue("@kode", kode)
                                cmdUpd.ExecuteNonQuery()
                            End Using
                        Next

                        tx.Commit()

                        ' Siapkan struk untuk dicetak (gunakan data keranjang saat ini)
                        PreparePrintTextSale(noTrans, tgl, kodePelanggan, total, diskon, grandTotal)

                        MessageBox.Show("Transaksi berhasil diproses.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Reset form
                        dtKeranjang.Rows.Clear()
                        HitungTotal()
                        GenerateNoTransaksi()
                    Catch exInner As Exception
                        tx.Rollback()
                        Throw
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memproses transaksi." & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =====================================
    ' SIAPKAN TEKS STRUK UNTUK PENJUALAN
    ' =====================================
    Private Sub PreparePrintTextSale(noTrans As String, tgl As DateTime, kodePelangganObj As Object, total As Decimal, diskon As Decimal, grandTotal As Decimal)
        Dim namaPelanggan As String = ""
        Try
            If kodePelangganObj IsNot Nothing AndAlso Not kodePelangganObj Is DBNull.Value Then
                Dim kode = kodePelangganObj.ToString()
                Dim dt = ExecSelect("SELECT nama_pelanggan FROM pelanggan WHERE kode_pelanggan = @kode", New Dictionary(Of String, Object) From {{"@kode", kode}})
                If dt.Rows.Count > 0 Then namaPelanggan = dt.Rows(0)("nama_pelanggan").ToString()
            End If
        Catch
            namaPelanggan = ""
        End Try

        Dim sb As New System.Text.StringBuilder()
        sb.AppendLine("===== STRUK PENJUALAN =====")
        sb.AppendLine("No: " & noTrans)
        sb.AppendLine("Tanggal: " & tgl.ToString("dd/MM/yyyy HH:mm"))
        If namaPelanggan <> "" Then sb.AppendLine("Pelanggan: " & namaPelanggan)
        sb.AppendLine(New String("-"c, 32))
        sb.AppendLine(String.Format("{0,-6} {1,-16} {2,3} {3,10}", "Kode", "Nama", "Qty", "Subtotal"))
        sb.AppendLine(New String("-"c, 32))

        For Each r As DataRow In dtKeranjang.Rows
            Dim kode = r("kode_barang").ToString()
            Dim nama = r("nama_barang").ToString()
            Dim qty = CInt(r("qty"))
            Dim subtotalVal As Decimal = CDec(r("subtotal"))
            Dim namaShort = If(nama.Length <= 16, nama, nama.Substring(0, 16))
            sb.AppendLine(String.Format("{0,-6} {1,-16} {2,3} {3,10}", kode, namaShort, qty, subtotalVal.ToString("N0")))
        Next

        sb.AppendLine(New String("-"c, 32))
        sb.AppendLine("Total: " & total.ToString("N0"))
        sb.AppendLine("Diskon: " & diskon.ToString("N0"))
        sb.AppendLine("Grand Total: " & grandTotal.ToString("N0"))
        sb.AppendLine(New String("=", 32))

        printText = sb.ToString()
    End Sub

    ' =====================================
    ' TOMBOL CETAK STRUK - preview
    ' =====================================
    Private Sub BtnCetak_Click(sender As Object, e As EventArgs) Handles BtnCetak.Click
        If String.IsNullOrWhiteSpace(printText) Then
            MessageBox.Show("Belum ada struk untuk dicetak. Proses transaksi terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Dim pd As New PrintDocument()
            AddHandler pd.PrintPage, AddressOf OnPrintPage
            Dim preview As New PrintPreviewDialog()
            preview.Document = pd
            preview.Width = 600
            preview.Height = 600
            preview.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan preview cetak." & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub OnPrintPage(sender As Object, ev As PrintPageEventArgs)
        Dim font As New Font("Consolas", 9)
        ev.Graphics.DrawString(printText, font, Brushes.Black, New PointF(10, 10))
        ev.HasMorePages = False
    End Sub

    ' =====================================
    ' TOMBOL BATAL
    ' =====================================
    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        If MessageBox.Show("Batalkan transaksi ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class