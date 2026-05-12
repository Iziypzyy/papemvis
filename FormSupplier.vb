Public Class FormSupplier
    ' Tombol TAMBAH: Membuka form kosong
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim frm As New FormInputSupplier()
        frm.Text = "Tambah Supplier Baru"

        ' Jika user klik Simpan di form input
        If frm.ShowDialog() = DialogResult.OK Then
            DgvSupplier.Rows.Add(frm.Kode, frm.Nama, frm.Telepon, frm.Kota)
        End If
    End Sub

    ' Tombol UBAH: Memasukkan data lama ke form input
    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        ' Pastikan ada baris yang dipilih
        If DgvSupplier.CurrentRow IsNot Nothing Then
            Dim frm As New FormInputSupplier()

            ' 1. Ambil data langsung dari sel DGV ke Form Input
            frm.Kode = DgvSupplier.CurrentRow.Cells(0).Value.ToString()
            frm.Nama = DgvSupplier.CurrentRow.Cells(1).Value.ToString()
            frm.Telepon = DgvSupplier.CurrentRow.Cells(2).Value.ToString()
            frm.Kota = DgvSupplier.CurrentRow.Cells(3).Value.ToString()
            frm.ModeEdit = True

            ' 2. Jika user klik Simpan di Form Input
            If frm.ShowDialog() = DialogResult.OK Then
                ' 3. Update langsung sel di baris yang sedang terpilih
                DgvSupplier.CurrentRow.Cells(1).Value = frm.Nama
                DgvSupplier.CurrentRow.Cells(2).Value = frm.Telepon
                DgvSupplier.CurrentRow.Cells(3).Value = frm.Kota

                MessageBox.Show("Data berhasil diperbarui!")
            End If
        End If
    End Sub

    ' Tombol HAPUS: Menghapus baris yang sedang dipilih
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        ' Pastikan ada baris yang dipilih
        If DgvSupplier.CurrentRow IsNot Nothing Then
            ' Konfirmasi dulu ke user biar nggak sengaja kehapus
            Dim tanya As DialogResult = MessageBox.Show("Yakin mau hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If tanya = DialogResult.Yes Then
                ' Hapus baris yang sedang dipilih
                DgvSupplier.Rows.RemoveAt(DgvSupplier.CurrentRow.Index)
                MessageBox.Show("Data berhasil dibuang!")
            End If
        Else
            MessageBox.Show("Pilih dulu data mana yang mau didepak!")
        End If
    End Sub

    ' Tombol Cari: Mencari data berdasarkan Nama dan Kode Supplier
    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Dim keyword As String = txtCari.Text.ToLower()

        ' Loop semua baris di DGV
        For Each row As DataGridViewRow In DgvSupplier.Rows
            ' Pastikan baris bukan baris kosong baru
            If Not row.IsNewRow Then
                ' Ambil nilai Kode (Cell 0) dan Nama (Cell 1)
                Dim kode As String = row.Cells(0).Value.ToString().ToLower()
                Dim nama As String = row.Cells(1).Value.ToString().ToLower()
                Dim kota As String = row.Cells(3).Value.ToString().ToLower()

                ' Jika keyword cocok dengan Kode ATAU Nama
                If kode.Contains(keyword) Or nama.Contains(keyword) Or kota.Contains(keyword) Then
                    row.Visible = True ' Tampilkan
                Else
                    row.Visible = False ' Sembunyikan
                End If
            End If
        Next
    End Sub
End Class