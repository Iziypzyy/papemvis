Public Class FormInputSupplier
    ' Properti untuk menampung data
    Public Property Kode As String
    Public Property Nama As String
    Public Property Telepon As String
    Public Property Kota As String
    Public Property ModeEdit As Boolean = False

    ' Saat form muncul, isi TextBox dengan data yang ada (jika ada)
    Private Sub FormInputSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModeEdit Then
            txtKode.Text = Kode
            txtNama.Text = Nama
            txtTelp.Text = Telepon
            txtKota.Text = Kota
            ' Kode tidak boleh diubah saat edit
            txtKode.Enabled = False
        End If
    End Sub

    Private Sub BtnSimpanInput_Click(sender As Object, e As EventArgs) Handles btnSimpanInput.Click
        ' 1. Cek apakah ada field yang kosong
        If txtKode.Text.Trim = "" Or
       txtNama.Text.Trim = "" Or
       txtTelp.Text.Trim = "" Or
       txtKota.Text.Trim = "" Then

            ' Tampilkan pesan peringatan
            MessageBox.Show("Semua data harus diisi, tidak boleh ada yang kosong!",
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            ' Berhenti di sini, jangan lanjut ke proses simpan
            Return
        End If

        ' 2. Jika semua sudah terisi, baru masukkan ke Properti
        Kode = txtKode.Text
        Nama = txtNama.Text
        Telepon = txtTelp.Text
        Kota = txtKota.Text

        ' Berikan sinyal OK ke Form Utama
        Me.DialogResult = DialogResult.OK
    End Sub
End Class