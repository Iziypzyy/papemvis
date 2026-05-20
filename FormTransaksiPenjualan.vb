Imports MySql.Data.MySqlClient
Imports MySqlConnector

' ============================================================
'  FormTransaksiPenjualan.vb  –  Kasir / Transaksi Penjualan
'  Terkoneksi ke tabel: penjualan, detail_penjualan, barang, pelanggan
' ============================================================

Public Class FormTransaksiPenjualan

    ' Menyimpan item keranjang belanja sementara
    Private dtKeranjang As New DataTable()

    Private Sub FormTransaksiPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializeKeranjang()
        LoadPelanggan()
        LoadBarang()
        GenerateNoTransaksi()
        TxtHarga.ReadOnly = True
        TxtSubTotalItem.ReadOnly = True
    End Sub

    ' ── Inisialisasi tabel keranjang di DataGridView ──────────
    Private Sub InicializeKeranjang()
        dtKeranjang.Columns.Add("kode_barang", GetType(String))
        dtKeranjang.Columns.Add("nama_barang", GetType(String))
        dtKeranjang.Columns.Add("qty", GetType(Integer))
        dtKeranjang.Columns.Add("harga_satuan", GetType(Decimal))
        dtKeranjang.Columns.Add("subtotal", GetType(Decimal))

        ' Bind ke DataGridView (sesuaikan nama kolom dengan desainer)
        DgvDetail.DataSource = dtKeranjang
    End Sub

    ' ── Load ComboBox Pelanggan ───────────────────────────────
    Private Sub LoadPelanggan()
        Try
            Dim dt As DataTable = ExecSelect(
                "SELECT kode_pelanggan, nama_pelanggan FROM pelanggan ORDER BY nama_pelanggan"
            )
            Dim dtTambah As DataTable = dt.Copy()
            dtTambah.Rows.InsertAt(dtTambah.NewRow(), 0)
            dtTambah.Rows(0)("kode_pelanggan") = ""
            dtTambah.Rows(0)("nama_pelanggan") = "-- Umum / Tanpa Pelanggan --"

            CbPelanggan.DataSource = dtTambah
            CbPelanggan.DisplayMember = "nama_pelanggan"
            CbPelanggan.ValueMember = "kode_pelanggan"
            CbPelanggan.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Gagal memuat pelanggan: " & ex.Message)
        End Try
    End Sub

    ' ── Load ComboBox Barang ──────────────────────────────────
    Private Sub LoadBarang()
        Try
            Dim dt As DataTable = ExecSelect(
                "SELECT kode_barang, CONCAT(nama_barang,' - Rp ',FORMAT(harga,0)) AS label, harga " &
                "FROM barang WHERE stok > 0 ORDER BY nama_barang"
            )
            CbBarang.DataSource = dt
            CbBarang.DisplayMember = "label"
            CbBarang.ValueMember = "kode_barang"
            CbBarang.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Gagal memuat barang: " & ex.Message)
        End Try
    End Sub

    ' ── Generate nomor transaksi otomatis ────────────────────
    Private Sub GenerateNoTransaksi()
        Dim prefix As String = "TRX-" & Format(Date.Now, "yyyyMMdd") & "-"
        Dim maxNum As Object = ExecScalar(
            "SELECT IFNULL(MAX(CAST(SUBSTRING_INDEX(no_transaksi,'-',-1) AS UNSIGNED)),0) " &
            "FROM penjualan WHERE no_transaksi LIKE @prefix",
            New Dictionary(Of String, Object) From {{"@prefix", prefix & "%"}}
        )
        TxtNoTransaksi.Text = prefix & (CInt(maxNum) + 1).ToString("D3")
        TxtNoTransaksi.ReadOnly = True
    End Sub

    ' ── Saat barang dipilih di ComboBox ──────────────────────
    Private Sub CbBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbBarang.SelectedIndexChanged
        If CbBarang.SelectedIndex < 0 Then Return

        Dim dt As DataTable = CType(CbBarang.DataSource, DataTable)
        Dim row As DataRow = dt.Rows(CbBarang.SelectedIndex)
        Dim harga As Decimal = CDec(row("harga"))

        TxtHarga.Text = harga.ToString("N0")
        HitungSubTotalItem()
    End Sub

    ' ── Hitung subtotal item ──────────────────────────────────
    Private Sub NudQty_ValueChanged(sender As Object, e As EventArgs) Handles NudQty.ValueChanged
        HitungSubTotalItem()
    End Sub

    Private Sub HitungSubTotalItem()
        Dim harga As Decimal = If(TxtHarga.Text = "", 0, CDec(TxtHarga.Text.Replace(",", "").Replace(".", "")))
        Dim qty As Integer = CInt(NudQty.Value)
        Dim subtotal As Decimal = harga * qty
        TxtSubTotalItem.Text = subtotal.ToString("N0")
    End Sub

    ' ── Tambah item ke keranjang ──────────────────────────────
    Private Sub BtnTambahItem_Click(sender As Object, e As EventArgs) Handles BtnTambahItem.Click
        If CbBarang.SelectedIndex < 0 Then
            MessageBox.Show("Pilih barang terlebih dahulu!",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim kode As String = CbBarang.SelectedValue.ToString()
        Dim nama As String = CType(CbBarang.DataSource, DataTable).Rows(CbBarang.SelectedIndex)("label").ToString()
        nama = nama.Split("-")(0).Trim()    ' ambil hanya nama barang
        Dim harga As Decimal = CDec(TxtHarga.Text.Replace(",", "").Replace(".", ""))
        Dim qty As Integer = CInt(NudQty.Value)
        Dim subtotal As Decimal = harga * qty

        ' Cek apakah barang sudah ada di keranjang → update qty
        Dim existing As DataRow() = dtKeranjang.Select("kode_barang='" & kode & "'")
        If existing.Length > 0 Then
            existing(0)("qty") = CInt(existing(0)("qty")) + qty
            existing(0)("subtotal") = CDec(existing(0)("harga_satuan")) * CInt(existing(0)("qty"))
        Else
            dtKeranjang.Rows.Add(kode, nama, qty, harga, subtotal)
        End If

        HitungTotal()
        CbBarang.SelectedIndex = -1
        NudQty.Value = 1
        TxtHarga.Clear()
        TxtSubTotalItem.Clear()
    End Sub

    ' ── Hapus item dari keranjang ─────────────────────────────
    Private Sub BtnHapusItem_Click(sender As Object, e As EventArgs) Handles BtnHapusItem.Click
        If DgvDetail.CurrentRow IsNot Nothing AndAlso DgvDetail.CurrentRow.Index >= 0 Then
            dtKeranjang.Rows.RemoveAt(DgvDetail.CurrentRow.Index)
            HitungTotal()
        End If
    End Sub

    ' ── Hitung total transaksi ────────────────────────────────
    Private Sub HitungTotal()
        Dim total As Decimal = 0
        For Each row As DataRow In dtKeranjang.Rows
            total += CDec(row("subtotal"))
        Next
        TxtTotal.Text = total.ToString("N0")
        HitungKembalian()
    End Sub

    ' ── Hitung kembalian ─────────────────────────────────────
    Private Sub TxtBayar_TextChanged(sender As Object, e As EventArgs) Handles TxtBayar.TextChanged
        HitungKembalian()
    End Sub

    Private Sub HitungKembalian()
        Dim total As Decimal = If(TxtTotal.Text = "", 0, CDec(TxtTotal.Text.Replace(",", "").Replace(".", "")))
        Dim bayar As Decimal = 0
        If TxtBayar.Text <> "" Then Decimal.TryParse(TxtBayar.Text, bayar)
        TxtKembalian.Text = (bayar - total).ToString("N0")
    End Sub

    ' ── Simpan Transaksi ──────────────────────────────────────
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If dtKeranjang.Rows.Count = 0 Then
            MessageBox.Show("Keranjang belanja kosong!",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim total As Decimal = CDec(TxtTotal.Text.Replace(",", "").Replace(".", ""))
        Dim bayar As Decimal = 0
        If Not Decimal.TryParse(TxtBayar.Text, bayar) OrElse bayar < total Then
            MessageBox.Show("Jumlah bayar kurang dari total!",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim kembalian As Decimal = bayar - total
        Dim kodePelanggan As String = If(CbPelanggan.SelectedValue IsNot Nothing, CbPelanggan.SelectedValue.ToString(), "")

        Try
            Using conn = KoneksiDB()
                Using trx = conn.BeginTransaction()
                    Try
                        ' ── INSERT header penjualan ──────────────
                        Dim sqlHeader As String =
                            "INSERT INTO penjualan (no_transaksi,kode_pelanggan,id_user,total,bayar,kembalian,keterangan) " &
                            "VALUES (@notrans,@kpel,@iduser,@total,@bayar,@kembalian,@ket)"

                        Using cmd As New MySqlCommand(sqlHeader, conn, trx)
                            cmd.Parameters.AddWithValue("@notrans", TxtNoTransaksi.Text)
                            cmd.Parameters.AddWithValue("@kpel", If(kodePelanggan = "", DBNull.Value, kodePelanggan))
                            cmd.Parameters.AddWithValue("@iduser", FormLoginAdmin.LoginIdUser)
                            cmd.Parameters.AddWithValue("@total", total)
                            cmd.Parameters.AddWithValue("@bayar", bayar)
                            cmd.Parameters.AddWithValue("@kembalian", kembalian)
                            cmd.Parameters.AddWithValue("@ket", "")
                            cmd.ExecuteNonQuery()
                        End Using

                        ' Ambil ID penjualan yang baru saja diinsert
                        Dim idPenjualan As Long
                        Using cmdId As New MySqlCommand("SELECT LAST_INSERT_ID()", conn, trx)
                            idPenjualan = CLng(cmdId.ExecuteScalar())
                        End Using

                        ' ── INSERT detail & update stok ──────────
                        For Each row As DataRow In dtKeranjang.Rows
                            Dim sqlDetail As String =
                                "INSERT INTO detail_penjualan (id_penjualan,kode_barang,nama_barang,qty,harga_satuan,subtotal) " &
                                "VALUES (@idpen,@kode,@nama,@qty,@harga,@sub)"

                            Using cmdDet As New MySqlCommand(sqlDetail, conn, trx)
                                cmdDet.Parameters.AddWithValue("@idpen", idPenjualan)
                                cmdDet.Parameters.AddWithValue("@kode", row("kode_barang"))
                                cmdDet.Parameters.AddWithValue("@nama", row("nama_barang"))
                                cmdDet.Parameters.AddWithValue("@qty", row("qty"))
                                cmdDet.Parameters.AddWithValue("@harga", row("harga_satuan"))
                                cmdDet.Parameters.AddWithValue("@sub", row("subtotal"))
                                cmdDet.ExecuteNonQuery()
                            End Using

                            ' Kurangi stok barang
                            Using cmdStok As New MySqlCommand(
                                "UPDATE barang SET stok = stok - @qty WHERE kode_barang = @kode",
                                conn, trx
                            )
                                cmdStok.Parameters.AddWithValue("@qty", row("qty"))
                                cmdStok.Parameters.AddWithValue("@kode", row("kode_barang"))
                                cmdStok.ExecuteNonQuery()
                            End Using
                        Next

                        trx.Commit()

                        MessageBox.Show(
                            "Transaksi berhasil disimpan!" & Environment.NewLine &
                            "No: " & TxtNoTransaksi.Text & Environment.NewLine &
                            "Kembalian: Rp " & kembalian.ToString("N0"),
                            "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information
                        )

                        ' Reset form
                        dtKeranjang.Rows.Clear()
                        TxtTotal.Clear()
                        TxtBayar.Clear()
                        TxtKembalian.Clear()
                        GenerateNoTransaksi()
                        LoadBarang()

                    Catch exInner As Exception
                        trx.Rollback()
                        Throw
                    End Try
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan transaksi: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ── Batal ────────────────────────────────────────────────
    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        If MessageBox.Show("Batalkan transaksi ini?", "Konfirmasi",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            dtKeranjang.Rows.Clear()
            TxtTotal.Clear()
            TxtBayar.Clear()
            TxtKembalian.Clear()
            GenerateNoTransaksi()
        End If
    End Sub

End Class