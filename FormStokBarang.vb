Public Class FormStokBarang

    ' 1. Inisialisasi data stok saat form dibuka
    Private Sub FormStokBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menambahkan data contoh (Kode, Nama, Stok, Stok Min, Satuan, Status)
        dgvStok.Rows.Add("B001", "Kemeja Flanel Blue", "15", "10", "Pcs", "")
        dgvStok.Rows.Add("B002", "Celana Bahan Black", "5", "10", "Pcs", "")
        dgvStok.Rows.Add("B003", "Kaos Polos Putih", "25", "15", "Pcs", "")
        dgvStok.Rows.Add("B004", "Jaket Denim Indigo", "3", "5", "Pcs", "")

        ' Memproses status dan warna baris
        UpdateStatusStok()

        ' Update label total data
        lblTotalData.Text = "Total Data : " & dgvStok.Rows.Count
    End Sub

    ' 2. Logika untuk menentukan status "Aman" atau "Menipis"
    Private Sub UpdateStatusStok()
        For Each row As DataGridViewRow In dgvStok.Rows
            If Not row.IsNewRow Then
                Dim stok As Integer = Val(row.Cells("colStok").Value)
                Dim stokMin As Integer = Val(row.Cells("colStokMin").Value)

                ' Membandingkan stok saat ini dengan stok minimum
                If stok <= stokMin Then
                    row.Cells("colStatus").Value = "MENIPIS"
                    row.Cells("colStatus").Style.ForeColor = Color.Red
                    ' Memberikan warna latar belakang tipis pada baris yang menipis
                    row.DefaultCellStyle.BackColor = Color.MistyRose
                Else
                    row.Cells("colStatus").Value = "AMAN"
                    row.Cells("colStatus").Style.ForeColor = Color.Green
                    row.DefaultCellStyle.BackColor = Color.White
                End If
            End If
        Next
    End Sub

    ' 3. Fitur pencarian barang secara real-time
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Dim kataKunci As String = txtCari.Text.ToLower()

        ' Menyembunyikan placeholder saat mulai mengetik
        If kataKunci = "cari barang..." Then Exit Sub

        For Each row As DataGridViewRow In dgvStok.Rows
            If Not row.IsNewRow Then
                ' Mencari berdasarkan Nama Barang atau Kode Barang
                Dim namaBarang As String = row.Cells("colNama").Value.ToString().ToLower()
                Dim kodeBarang As String = row.Cells("colKode").Value.ToString().ToLower()

                If namaBarang.Contains(kataKunci) Or kodeBarang.Contains(kataKunci) Then
                    row.Visible = True
                Else
                    ' CurrencyManager digunakan agar tidak error saat menyembunyikan baris aktif
                    dgvStok.CurrentCell = Nothing
                    row.Visible = False
                End If
            End If
        Next
    End Sub

End Class