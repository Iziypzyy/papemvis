Public Class FormTransaksiPenjualan
    ' Menghitung subtotal otomatis saat Qty berubah
    Private Sub NudQty_ValueChanged(sender As Object, e As EventArgs) Handles NudQty.ValueChanged
        HitungSubTotalItem()
    End Sub

    Private Sub HitungSubTotalItem()
        ' Val() digunakan untuk mengubah teks menjadi angka agar bisa dihitung
        Dim harga As Double = Val(TxtHarga.Text.Replace(".", "")) ' Menghilangkan titik ribuan jika ada
        Dim qty As Integer = NudQty.Value
        Dim subtotal As Double = harga * qty

        ' Menampilkan hasil dengan format ribuan
        TxtSubTotalItem.Text = Format(subtotal, "###,###,##0")
    End Sub

    Private Sub FormTransaksiPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class