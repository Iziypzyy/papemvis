Public Class FormInputBarang
    ' Siapkan Property untuk menampung data dari/ke Form Utama
    Public Property Kode As String
    Public Property Nama As String
    Public Property Kategori As String
    Public Property Ukuran As String
    Public Property Warna As String
    Public Property Harga As String
    Public Property Stok As String
    Public Property ModeEdit As Boolean = False

    Private Sub FormInputBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Isi komponen dengan data (jika ada)
        txtKode.Text = Kode
        txtNama.Text = Nama
        cbKategori.Text = Kategori
        txtUkuran.Text = Ukuran
        txtWarna.Text = Warna
        txtHarga.Text = Harga
        txtStok.Text = Stok

        If ModeEdit Then
            txtKode.ReadOnly = True
            txtNama.Focus()
        End If
    End Sub

    ' --- VALIDASI HANYA ANGKA ---
    Private Sub AngkaOnly_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress, txtStok.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Tolak selain angka
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Cek jangan ada yang kosong
        If txtKode.Text.Trim = "" Or txtNama.Text.Trim = "" Or cbKategori.Text = "" Then
            MessageBox.Show("Kode, Nama, dan Kategori wajib diisi!", "Peringatan")
            Exit Sub
        End If

        ' Masukkan balik ke Property
        Kode = txtKode.Text
        Nama = txtNama.Text
        Kategori = cbKategori.Text
        Ukuran = txtUkuran.Text
        Warna = txtWarna.Text
        Harga = txtHarga.Text
        Stok = txtStok.Text

        Me.DialogResult = DialogResult.OK
    End Sub
End Class