Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.Data
Imports System.Globalization

Public Class Form8

    Private printText As String = ""

    ' =====================================
    ' LOAD FORM
    ' =====================================
    Private Sub FormPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTanggal.Value = DateTime.Now
        txtNoPembelian.Text = GenerateNoPembelian()
        LoadSuppliers()
        LoadDataDB()

    End Sub

    ' =====================================
    ' MENAMPILKAN DATA PEMBELIAN (history)
    ' =====================================
    Private Sub LoadDataDB()
        dgvDetailPembelian.Rows.Clear()

        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()
                Dim query As String =
                    "SELECT dp.kode_barang, dp.nama_barang, dp.qty, dp.harga_satuan, dp.subtotal
                     FROM detail_pembelian dp
                     INNER JOIN pembelian p ON dp.id_pembelian = p.id_pembelian
                     ORDER BY p.tgl_pembelian DESC, dp.id_detail
                     LIMIT 20"

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
            MessageBox.Show("Gagal memuat data pembelian!" & vbNewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

            Dim qtyVal As Integer = 0
            Integer.TryParse(If(row.Cells("colQty").Value, "0").ToString(), qtyVal)
            totalItem += qtyVal

            Dim subVal As Double = 0
            Double.TryParse(If(row.Cells("colSubTotal").Value, "0").ToString(), NumberStyles.AllowThousands Or NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, subVal)
            subTotal += subVal
        Next

        Double.TryParse(txtOngkir.Text, NumberStyles.AllowThousands Or NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, ongkir)

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
    ' GENERATE NO PEMBELIAN OTOMATIS (PB001 ...)
    ' =====================================
    Private Function GenerateNoPembelian() As String
        Try
            Dim sql As String = "SELECT IFNULL(MAX(CAST(SUBSTRING(no_pembelian,3) AS UNSIGNED)),0) FROM pembelian"
            Dim obj = DataModule.ExecScalar(sql)
            Dim maxNum As Integer = 0
            If obj IsNot Nothing AndAlso Integer.TryParse(obj.ToString(), maxNum) Then
            End If
            Return "PB" & (maxNum + 1).ToString("D3")
        Catch
            Return "PB001"
        End Try
    End Function

    ' =====================================
    ' LOAD DAFTAR SUPPLIER KE COMBOBOX
    ' =====================================
    Private Sub LoadSuppliers()
        Try
            Dim dt As DataTable = DataModule.ExecSelect("SELECT kode_supplier, nama_supplier FROM supplier ORDER BY kode_supplier")
            cmbSupplier.DisplayMember = "nama_supplier"
            cmbSupplier.ValueMember = "kode_supplier"
            cmbSupplier.DataSource = dt
            If dt.Rows.Count = 0 Then cmbSupplier.Text = ""
        Catch ex As Exception
            MessageBox.Show("Gagal memuat daftar supplier." & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =====================================
    ' TOMBOL CARI SUPPLIER (buka form supplier)
    ' =====================================
    Private Sub btnCariSupplier_Click(sender As Object, e As EventArgs) Handles btnCariSupplier.Click
        Try
            Dim frm As New FormSupplier()
            frm.ShowDialog()
            LoadSuppliers()
        Catch ex As Exception
            MessageBox.Show("Gagal membuka daftar supplier." & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =====================================
    ' TOMBOL SIMPAN: simpan pembelian + detail + update stok
    ' =====================================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Validasi dasar
        If dgvDetailPembelian.Rows.Count = 0 Then
            MessageBox.Show("Tidak ada item pembelian.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbSupplier.SelectedValue Is Nothing OrElse cmbSupplier.SelectedValue.ToString() = "" Then
            MessageBox.Show("Pilih supplier terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' periksa setiap baris: qty>0 dan harga>0
        For Each row As DataGridViewRow In dgvDetailPembelian.Rows
            If row.IsNewRow Then Continue For
            Dim qty As Integer = 0
            Integer.TryParse(If(row.Cells("colQty").Value, "0").ToString(), qty)
            If qty <= 0 Then
                MessageBox.Show("Qty harus lebih besar dari 0 pada barang: " & If(row.Cells("colNama").Value, "").ToString(), "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Dim harga As Double = 0
            Double.TryParse(If(row.Cells("colHarga").Value, "0").ToString(), Globalization.NumberStyles.AllowThousands Or Globalization.NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, harga)
            If harga <= 0 Then
                MessageBox.Show("Harga harus lebih besar dari 0 pada barang: " & If(row.Cells("colNama").Value, "").ToString(), "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Next

        Dim noPembelian As String = txtNoPembelian.Text.Trim()
        Dim kodeSupplier As String = cmbSupplier.SelectedValue.ToString()
        Dim tglPembelian As DateTime = dtpTanggal.Value
        Dim ongkir As Double = 0
        Double.TryParse(txtOngkir.Text, ongkir)

        ' Hitung total dari grid
        Dim total As Double = 0
        For Each row As DataGridViewRow In dgvDetailPembelian.Rows
            If row.IsNewRow Then Continue For
            Dim s = If(row.Cells("colSubTotal").Value, "0").ToString()
            Dim v As Double = 0
            Double.TryParse(s, v)
            total += v
        Next

        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()
                Using tx = conn.BeginTransaction()
                    Try
                        Dim sqlIns As String =
                            "INSERT INTO pembelian (no_pembelian, kode_supplier, tgl_pembelian, total, ongkir, created_by)
                             VALUES (@no, @sup, @tgl, @total, @ongkir, @user)"
                        Using cmd As New MySqlCommand(sqlIns, conn, tx)
                            cmd.Parameters.AddWithValue("@no", noPembelian)
                            cmd.Parameters.AddWithValue("@sup", kodeSupplier)
                            cmd.Parameters.AddWithValue("@tgl", tglPembelian)
                            cmd.Parameters.AddWithValue("@total", total)
                            cmd.Parameters.AddWithValue("@ongkir", ongkir)
                            cmd.Parameters.AddWithValue("@user", Environment.UserName)
                            cmd.ExecuteNonQuery()
                        End Using

                        Dim idPembelian As Long = 0
                        Using cmdId As New MySqlCommand("SELECT LAST_INSERT_ID()", conn, tx)
                            idPembelian = Convert.ToInt64(cmdId.ExecuteScalar())
                        End Using

                        For Each row As DataGridViewRow In dgvDetailPembelian.Rows
                            If row.IsNewRow Then Continue For

                            Dim kodeBarang = If(row.Cells("colKode").Value, "").ToString()
                            Dim namaBarang = If(row.Cells("colNama").Value, "").ToString()
                            Dim qty As Integer = 0
                            Integer.TryParse(If(row.Cells("colQty").Value, "0").ToString(), qty)
                            Dim harga As Double = 0
                            Double.TryParse(If(row.Cells("colHarga").Value, "0").ToString().Replace(".", "").Replace(",", ""), harga)
                            Dim subtotal As Double = 0
                            Double.TryParse(If(row.Cells("colSubTotal").Value, "0").ToString().Replace(".", "").Replace(",", ""), subtotal)

                            Dim sqlDet As String =
                                "INSERT INTO detail_pembelian (id_pembelian, kode_barang, nama_barang, qty, harga_satuan, subtotal)
                                 VALUES (@id, @kode, @nama, @qty, @harga, @sub)"
                            Using cmdDet As New MySqlCommand(sqlDet, conn, tx)
                                cmdDet.Parameters.AddWithValue("@id", idPembelian)
                                cmdDet.Parameters.AddWithValue("@kode", kodeBarang)
                                cmdDet.Parameters.AddWithValue("@nama", namaBarang)
                                cmdDet.Parameters.AddWithValue("@qty", qty)
                                cmdDet.Parameters.AddWithValue("@harga", harga)
                                cmdDet.Parameters.AddWithValue("@sub", subtotal)
                                cmdDet.ExecuteNonQuery()
                            End Using

                            Dim sqlUpdStok As String = "UPDATE barang SET stok = IFNULL(stok,0) + @qty WHERE kode_barang = @kode"
                            Using cmdUpd As New MySqlCommand(sqlUpdStok, conn, tx)
                                cmdUpd.Parameters.AddWithValue("@qty", qty)
                                cmdUpd.Parameters.AddWithValue("@kode", kodeBarang)
                                cmdUpd.ExecuteNonQuery()
                            End Using
                        Next

                        tx.Commit()

                        MessageBox.Show("Pembelian berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        txtNoPembelian.Text = GenerateNoPembelian()
                        dgvDetailPembelian.Rows.Clear()
                        HitungRingkasan()
                        LoadDataDB()

                        PreparePrintText(noPembelian, tglPembelian, kodeSupplier, total, ongkir, total + ongkir)
                    Catch exInner As Exception
                        tx.Rollback()
                        Throw
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan pembelian!" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =====================================
    ' SIAPKAN TEKS UNTUK CETAK (Sederhana)
    ' =====================================
    Private Sub PreparePrintText(noPembelian As String, tgl As DateTime, kodeSupplier As String, total As Double, ongkir As Double, grandTotal As Double)
        Dim supplierName As String = ""
        Try
            Dim sql = "SELECT nama_supplier FROM supplier WHERE kode_supplier = @kode"
            Dim dt = DataModule.ExecSelect(sql, New Dictionary(Of String, Object) From {{"@kode", kodeSupplier}})
            If dt.Rows.Count > 0 Then supplierName = dt.Rows(0)("nama_supplier").ToString()
        Catch
        End Try

        Dim sb As New System.Text.StringBuilder()
        sb.AppendLine("NOTA PEMBELIAN")
        sb.AppendLine("No: " & noPembelian)
        sb.AppendLine("Tanggal: " & tgl.ToString("dd/MM/yyyy"))
        sb.AppendLine("Supplier: " & supplierName & " (" & kodeSupplier & ")")
        sb.AppendLine(New String("-"c, 40))
        sb.AppendLine("Kode    Nama                         Qty    Harga     Subtotal")
        sb.AppendLine(New String("-"c, 40))

        For Each row As DataGridViewRow In dgvDetailPembelian.Rows
            If row.IsNewRow Then Continue For
            Dim kode = If(row.Cells("colKode").Value, "").ToString()
            Dim nama = If(row.Cells("colNama").Value, "").ToString()
            Dim qty = If(row.Cells("colQty").Value, "").ToString()
            Dim harga = If(row.Cells("colHarga").Value, "").ToString()
            Dim subtotalStr = If(row.Cells("colSubTotal").Value, "").ToString()
            Dim namaShort As String = If(nama.Length <= 25, nama, nama.Substring(0, 25))
            Dim line = String.Format("{0,-6} {1,-25} {2,4} {3,12} {4,12}", kode, namaShort, qty, harga.PadLeft(10), subtotalStr.PadLeft(10))
            sb.AppendLine(line)
        Next

        sb.AppendLine(New String("-"c, 40))
        sb.AppendLine("Total: " & total.ToString("N0"))
        sb.AppendLine("Ongkir: " & ongkir.ToString("N0"))
        sb.AppendLine("Grand Total: " & grandTotal.ToString("N0"))
        printText = sb.ToString()
    End Sub

    ' =====================================
    ' TOMBOL CETAK - preview
    ' =====================================
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If String.IsNullOrEmpty(printText) Then
            MessageBox.Show("Belum ada data nota untuk dicetak. Simpan transaksi terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Dim pd As New PrintDocument()
            AddHandler pd.PrintPage, AddressOf OnPrintPage
            Dim preview As New PrintPreviewDialog()
            preview.Document = pd
            preview.Width = 800
            preview.Height = 600
            preview.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Gagal membuka preview cetak." & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub OnPrintPage(sender As Object, ev As PrintPageEventArgs)
        Dim font As New Font("Consolas", 10)
        ev.Graphics.DrawString(printText, font, Brushes.Black, New PointF(10, 10))
        ev.HasMorePages = False
    End Sub

    ' =====================================
    ' TOMBOL BATAL
    ' =====================================
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        If MessageBox.Show("Batalkan transaksi ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    ' =====================================
    ' DATA GRID HELPERS: default values, recalc subtotal & ringkasan
    ' =====================================
    Private Sub dgvDetailPembelian_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles dgvDetailPembelian.DefaultValuesNeeded
        Try
            e.Row.Cells("colQty").Value = 1
            e.Row.Cells("colHarga").Value = "0"
            e.Row.Cells("colSubTotal").Value = "0"
        Catch
        End Try
    End Sub

    Private Sub dgvDetailPembelian_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetailPembelian.CellEndEdit
        If e.RowIndex < 0 Then Return

        Dim row = dgvDetailPembelian.Rows(e.RowIndex)

        Try
            Dim qty As Integer = 0
            Integer.TryParse(If(row.Cells("colQty").Value, "0").ToString(), qty)

            Dim harga As Double = 0
            Double.TryParse(If(row.Cells("colHarga").Value, "0").ToString(), NumberStyles.AllowThousands Or NumberStyles.AllowDecimalPoint, CultureInfo.CurrentCulture, harga)

            Dim subtotal As Double = qty * harga
            row.Cells("colSubTotal").Value = subtotal.ToString("N0")
        Catch
        End Try

        HitungRingkasan()
    End Sub

    Private Sub dgvDetailPembelian_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvDetailPembelian.RowsRemoved
        HitungRingkasan()
    End Sub

End Class