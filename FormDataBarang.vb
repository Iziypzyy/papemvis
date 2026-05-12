Public Class FormDataBarang
    ' --- TOMBOL TAMBAH ---
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim frm As New FormInputBarang()
        If frm.ShowDialog() = DialogResult.OK Then
            ' Tambah baris baru ke DataGridView
            DgvDataBarang.Rows.Add(frm.Kode, frm.Nama, frm.Kategori, frm.Ukuran, frm.Warna, frm.Harga, frm.Stok)
            UpdateTotalData()
        End If
    End Sub

    ' --- TOMBOL UBAH ---
    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        If DgvDataBarang.CurrentRow IsNot Nothing Then
            Dim frm As New FormInputBarang()
            ' Kirim data ke Form Input
            With DgvDataBarang.CurrentRow
                frm.Kode = .Cells(0).Value.ToString()
                frm.Nama = .Cells(1).Value.ToString()
                frm.Kategori = .Cells(2).Value.ToString()
                frm.Ukuran = .Cells(3).Value.ToString()
                frm.Warna = .Cells(4).Value.ToString()
                frm.Harga = .Cells(5).Value.ToString()
                frm.Stok = .Cells(6).Value.ToString()
            End With
            frm.ModeEdit = True

            If frm.ShowDialog() = DialogResult.OK Then
                ' Update baris yang dipilih
                With DgvDataBarang.CurrentRow
                    .Cells(1).Value = frm.Nama
                    .Cells(2).Value = frm.Kategori
                    .Cells(3).Value = frm.Ukuran
                    .Cells(4).Value = frm.Warna
                    .Cells(5).Value = frm.Harga
                    .Cells(6).Value = frm.Stok
                End With
            End If
        End If
    End Sub

    ' --- UPDATE PANEL DETAIL SAAT KLIK TABEL ---
    Private Sub DgvDataBarang_SelectionChanged(sender As Object, e As EventArgs) Handles DgvDataBarang.SelectionChanged
        If DgvDataBarang.CurrentRow IsNot Nothing Then
            With DgvDataBarang.CurrentRow
                LblValKode.Text = .Cells(0).Value.ToString()
                LblValNama.Text = .Cells(1).Value.ToString()
                LblValKategori.Text = .Cells(2).Value.ToString()
                LblValHarga.Text = .Cells(5).Value.ToString()
                LblValStok.Text = .Cells(6).Value.ToString()
            End With
        End If
    End Sub

    ' Fungsi pembantu untuk update label Total Data
    Private Sub UpdateTotalData()
        LblTotalData.Text = "Total Data : " & DgvDataBarang.Rows.Count
    End Sub

    ' --- TOMBOL HAPUS ---
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        ' Cek apakah ada baris yang sedang dipilih
        If DgvDataBarang.CurrentRow IsNot Nothing Then

            ' Ambil Nama Barang untuk ditampilkan di pesan konfirmasi
            Dim namaBarang As String = DgvDataBarang.CurrentRow.Cells(1).Value.ToString()

            ' Tampilkan kotak dialog konfirmasi (Yes/No)
            Dim tanya As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus barang: " & namaBarang & "?",
                                                    "Konfirmasi Hapus",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning)

            ' Validasi Hapus
            If tanya = DialogResult.Yes Then
                DgvDataBarang.Rows.RemoveAt(DgvDataBarang.CurrentRow.Index)

                ' Update label total data setelah penghapusan
                UpdateTotalData()

                ' Kosongkan detail di panel bawah karena datanya sudah tidak ada
                LblValKode.Text = "-"
                LblValNama.Text = "-"
                LblValKategori.Text = "-"
                LblValHarga.Text = "0"
                LblValStok.Text = "0"
            End If
        Else
            MessageBox.Show("Silakan pilih baris barang yang ingin dihapus terlebih dahulu!", "Informasi")
        End If
    End Sub

    ' --- PENCARIAN DATA ---
    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        ' Ambil kata kunci dan bersihkan spasi
        Dim keyword As String = TxtCari.Text.ToLower().Trim()

        For Each row As DataGridViewRow In DgvDataBarang.Rows
            If Not row.IsNewRow Then
                ' Ambil data dari kolom yang diinginkan
                Dim kode As String = row.Cells(0).Value.ToString().ToLower()
                Dim nama As String = row.Cells(1).Value.ToString().ToLower()
                Dim kategori As String = row.Cells(2).Value.ToString().ToLower()

                ' Cek apakah keyword ada di salah satu kolom tersebut
                If kode.Contains(keyword) OrElse nama.Contains(keyword) OrElse kategori.Contains(keyword) Then
                    row.Visible = True
                Else
                    row.Visible = False
                End If
            End If
        Next

        ' Update label total data setelah difilter
        UpdateTotalData()
    End Sub
End Class