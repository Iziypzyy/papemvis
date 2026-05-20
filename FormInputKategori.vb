Public Class FormInputKategori

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click

        ' VALIDASI
        If txtKodeKategori.Text = "" Then

            MessageBox.Show("Kode kategori wajib diisi!")
            txtKodeKategori.Focus()
            Exit Sub

        End If

        If txtNamaKategori.Text = "" Then

            MessageBox.Show("Nama kategori wajib diisi!")
            txtNamaKategori.Focus()
            Exit Sub

        End If

        ' MODE TAMBAH
        If Me.Text = "Tambah Kategori" Then

            FormKategori.DgvKategori.Rows.Add(
                txtKodeKategori.Text,
                txtNamaKategori.Text,
                txtKeterangan.Text
            )

            MessageBox.Show("Data berhasil ditambahkan!")

        Else

            ' MODE UBAH

            Dim row As DataGridViewRow =
                FormKategori.DgvKategori.SelectedRows(0)

            row.Cells(0).Value = txtKodeKategori.Text
            row.Cells(1).Value = txtNamaKategori.Text
            row.Cells(2).Value = txtKeterangan.Text

            MessageBox.Show("Data berhasil diubah!")

        End If

        Me.Close()

    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click

        Me.Close()
    End Sub
End Class