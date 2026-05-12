Public Class FormPelanggan

    ' 1. Menyiapkan data awal saat form dimuat
    Private Sub FormPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menambahkan data contoh ke dalam tabel
        DgvPelanggan.Rows.Add("P001", "Budi Santoso", "08123456789", "Jakarta")
        DgvPelanggan.Rows.Add("P002", "Andi Wijaya", "08567891234", "Surabaya")

        ' Mengatur agar tombol Simpan tidak aktif di awal
        BtnSimpan.Enabled = False
    End Sub

    ' 2. Logika untuk tombol Tambah
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        ' Fokus ke area input atau aktifkan tombol Simpan
        BtnSimpan.Enabled = True
        MessageBox.Show("Silahkan masukkan data pelanggan baru.", "Tambah Data")
    End Sub

    ' 3. Logika untuk fitur Cari Pelanggan
    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        Dim kataKunci As String = TxtCari.Text.ToLower()

        If kataKunci = "" Or kataKunci = "cari pelanggan..." Then
            MessageBox.Show("Masukkan nama pelanggan yang ingin dicari.", "Informasi")
            Return
        End If

        ' Contoh logika sederhana: Menandai baris yang sesuai
        For Each row As DataGridViewRow In DgvPelanggan.Rows
            If row.Cells("ColNamaPelanggan").Value.ToString().ToLower().Contains(kataKunci) Then
                row.Selected = True
                DgvPelanggan.FirstDisplayedScrollingRowIndex = row.Index
                Exit Sub
            End If
        Next
    End Sub

    ' 4. Membersihkan teks placeholder pada kotak pencarian
    Private Sub TxtCari_Enter(sender As Object, e As EventArgs) Handles TxtCari.Enter
        If TxtCari.Text = "Cari pelanggan..." Then
            TxtCari.Text = ""
            TxtCari.ForeColor = Color.Black
        End If
    End Sub

End Class