Imports MySql.Data.MySqlClient

Public Class FormTransaksiPenjualan

    Private dtKeranjang As New DataTable()

    Private Sub FormTransaksiPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeKeranjang()
        LoadPelanggan()
        LoadBarang()
        GenerateNoTransaksi()
    End Sub

    ' ================== KERANJANG ==================
    Private Sub InitializeKeranjang()

        dtKeranjang.Columns.Add("kode_barang", GetType(String))
        dtKeranjang.Columns.Add("nama_barang", GetType(String))
        dtKeranjang.Columns.Add("qty", GetType(Integer))
        dtKeranjang.Columns.Add("harga", GetType(Decimal))
        dtKeranjang.Columns.Add("subtotal", GetType(Decimal))

        DgvKeranjang.DataSource = dtKeranjang

    End Sub

    ' ================== PELANGGAN ==================
    Private Sub LoadPelanggan()

        Dim dt As DataTable = ExecSelect(
            "SELECT kode_pelanggan, nama_pelanggan FROM pelanggan"
        )

        CboPelanggan.DataSource = dt
        CboPelanggan.DisplayMember = "nama_pelanggan"
        CboPelanggan.ValueMember = "kode_pelanggan"

    End Sub

    ' ================== BARANG ==================
    Private Sub LoadBarang()

        Dim dt As DataTable = ExecSelect(
            "SELECT kode_barang, nama_barang, harga FROM barang WHERE stok > 0"
        )

        CboBarang.DataSource = dt
        CboBarang.DisplayMember = "nama_barang"
        CboBarang.ValueMember = "kode_barang"

    End Sub

    ' ================== NO TRANSAKSI ==================
    Private Sub GenerateNoTransaksi()
        TxtNoTransaksi.Text = "TRX-" & Format(Now, "yyyyMMddHHmmss")
    End Sub

    ' ================== PILIH BARANG ==================
    Private Sub CboBarang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboBarang.SelectedIndexChanged

        If CboBarang.SelectedIndex < 0 Then Exit Sub

        Dim row As DataRowView = CType(CboBarang.SelectedItem, DataRowView)
        TxtHarga.Text = row("harga").ToString()

        HitungSubtotalItem()

    End Sub

    Private Sub NudQty_ValueChanged(sender As Object, e As EventArgs) Handles NudQty.ValueChanged
        HitungSubtotalItem()
    End Sub

    Private Sub HitungSubtotalItem()

        Dim harga As Decimal = Val(TxtHarga.Text)
        Dim qty As Integer = NudQty.Value

        TxtSubTotalItem.Text = (harga * qty).ToString()

    End Sub

    ' ================== TAMBAH ITEM (BTN +) ==================
    Private Sub BtnPlus_Click(sender As Object, e As EventArgs) Handles BtnPlus.Click

        If CboBarang.SelectedIndex < 0 Then Exit Sub

        Dim row As DataRowView = CType(CboBarang.SelectedItem, DataRowView)

        Dim kode As String = row("kode_barang").ToString()
        Dim nama As String = row("nama_barang").ToString()
        Dim harga As Decimal = CDec(row("harga"))
        Dim qty As Integer = NudQty.Value
        Dim subtotal As Decimal = harga * qty

        dtKeranjang.Rows.Add(kode, nama, qty, harga, subtotal)

        HitungTotal()

    End Sub

    ' ================== HAPUS ITEM (BTN -) ==================
    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click

        If DgvKeranjang.CurrentRow IsNot Nothing Then
            dtKeranjang.Rows.RemoveAt(DgvKeranjang.CurrentRow.Index)
        End If

        HitungTotal()

    End Sub

    ' ================== TOTAL ==================
    Private Sub HitungTotal()

        Dim total As Decimal = 0

        For Each r As DataRow In dtKeranjang.Rows
            total += CDec(r("subtotal"))
        Next

        LblTotalVal.Text = total.ToString("N0")

        Dim diskon As Decimal = Val(TxtDiskon.Text)
        Dim grandTotal As Decimal = total - diskon

        LblGrandTotalVal.Text = grandTotal.ToString("N0")

    End Sub

End Class