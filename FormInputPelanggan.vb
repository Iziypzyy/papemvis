Public Class FormInputPelanggan

    ' TOMBOL SIMPAN
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        ' VALIDASI INPUT
        If txtKode.Text = "" Or
           txtNama.Text = "" Or
           txtNoTelp.Text = "" Or
           txtKota.Text = "" Then

            MessageBox.Show("Semua data harus diisi!",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            Exit Sub
        End If

        ' MODE TAMBAH
        If Me.Text = "Tambah Pelanggan" Then

            FormPelanggan.DgvPelanggan.Rows.Add(
                txtKode.Text,
                txtNama.Text,
                txtNoTelp.Text,
                txtKota.Text
            )

            MessageBox.Show("Data pelanggan berhasil ditambahkan!",
                            "Berhasil",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

        Else

            ' MODE UBAH
            Dim row As DataGridViewRow =
                FormPelanggan.DgvPelanggan.SelectedRows(0)

            row.Cells(0).Value = txtKode.Text
            row.Cells(1).Value = txtNama.Text
            row.Cells(2).Value = txtNoTelp.Text
            row.Cells(3).Value = txtKota.Text

            MessageBox.Show("Data pelanggan berhasil diubah!",
                            "Berhasil",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

        End If

        ' Tutup form
        Me.Close()

    End Sub

    ' TOMBOL BATAL
    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click

        Me.Close()

    End Sub

    ' VALIDASI INPUT ANGKA
    Private Sub txtNoTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoTelp.KeyPress

        ' Hanya boleh angka dan backspace
        If Not Char.IsDigit(e.KeyChar) And
           Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

End Class