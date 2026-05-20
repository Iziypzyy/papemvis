Public Class FormPelanggan

    ' LOAD FORM
    Private Sub FormPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' DATA DUMMY
        DgvPelanggan.Rows.Add("P001", "Budi Santoso", "08123456789", "Jakarta")
        DgvPelanggan.Rows.Add("P002", "Andi Wijaya", "08567891234", "Surabaya")
        DgvPelanggan.Rows.Add("P003", "Reza Saputra", "08991234567", "Bandung")
        DgvPelanggan.Rows.Add("P004", "Fadil Akbar", "08129876543", "Samarinda")

    End Sub

    ' TOMBOL TAMBAH
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click

        ' Kosongkan textbox
        FormInputPelanggan.txtKode.Text = ""
        FormInputPelanggan.txtNama.Text = ""
        FormInputPelanggan.txtNoTelp.Text = ""
        FormInputPelanggan.txtKota.Text = ""

        ' Mode tambah
        FormInputPelanggan.Text = "Tambah Pelanggan"

        ' Tampilkan form input
        FormInputPelanggan.ShowDialog()

    End Sub

    ' TOMBOL UBAH
    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click

        ' Cek apakah ada data dipilih
        If DgvPelanggan.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data pelanggan terlebih dahulu!",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Ambil data dari DataGridView
        Dim row As DataGridViewRow = DgvPelanggan.SelectedRows(0)

        ' Kirim data ke FormInputPelanggan
        FormInputPelanggan.txtKode.Text = row.Cells(0).Value.ToString()
        FormInputPelanggan.txtNama.Text = row.Cells(1).Value.ToString()
        FormInputPelanggan.txtNoTelp.Text = row.Cells(2).Value.ToString()
        FormInputPelanggan.txtKota.Text = row.Cells(3).Value.ToString()

        ' Mode ubah
        FormInputPelanggan.Text = "Ubah Pelanggan"

        ' Tampilkan form
        FormInputPelanggan.ShowDialog()

    End Sub

    ' TOMBOL HAPUS
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click

        ' Cek apakah ada data dipilih
        If DgvPelanggan.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data yang ingin dihapus!",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Konfirmasi hapus
        Dim hasil As DialogResult

        hasil = MessageBox.Show("Yakin ingin menghapus data pelanggan ini?",
                                "Konfirmasi Hapus",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then

            DgvPelanggan.Rows.RemoveAt(DgvPelanggan.SelectedRows(0).Index)

            MessageBox.Show("Data berhasil dihapus!",
                            "Informasi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

        End If

    End Sub

    ' SEARCH DATA
    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged

        Dim keyword As String = TxtCari.Text.ToLower()

        For Each row As DataGridViewRow In DgvPelanggan.Rows

            If row.IsNewRow Then Continue For

            Dim nama As String = row.Cells(1).Value.ToString().ToLower()
            Dim kode As String = row.Cells(0).Value.ToString().ToLower()
            Dim kota As String = row.Cells(3).Value.ToString().ToLower()

            ' Tampilkan hanya data yang cocok
            If nama.Contains(keyword) Or
               kode.Contains(keyword) Or
               kota.Contains(keyword) Then

                row.Visible = True

            Else

                row.Visible = False

            End If

        Next

    End Sub

End Class