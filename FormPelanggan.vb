Imports MySql.Data.MySqlClient

Public Class FormPelanggan

    ' =========================
    ' LOAD FORM
    ' =========================
    Private Sub FormPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    ' =========================
    ' MENAMPILKAN DATA
    ' =========================
    Private Sub TampilData()

        DgvPelanggan.Rows.Clear()

        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()

                Dim query As String =
                    "SELECT kode_pelanggan, nama_pelanggan, email, created_at 
                     FROM pelanggan 
                     ORDER BY kode_pelanggan"

                Using cmd As New MySqlCommand(query, conn)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()

                        While dr.Read()

                            DgvPelanggan.Rows.Add(
                                dr("kode_pelanggan").ToString(),
                                dr("nama_pelanggan").ToString(),
                                dr("email").ToString(),
                                Format(CDate(dr("created_at")), "dd/MM/yyyy")
                            )

                        End While

                    End Using
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show(
                "Data pelanggan gagal dimuat!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try

    End Sub

    ' =========================
    ' TOMBOL TAMBAH
    ' =========================
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click

        FormInputPelanggan.txtKode.Clear()
        FormInputPelanggan.txtNama.Clear()
        FormInputPelanggan.txtNoTelp.Clear()
        FormInputPelanggan.txtKota.Clear()

        FormInputPelanggan.Text = "Tambah Pelanggan"
        FormInputPelanggan.ShowDialog()

        TampilData()

    End Sub

    ' =========================
    ' TOMBOL UBAH
    ' =========================
    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click

        If DgvPelanggan.SelectedRows.Count = 0 Then
            MessageBox.Show(
                "Pilih data terlebih dahulu!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Exit Sub
        End If

        Dim row As DataGridViewRow = DgvPelanggan.SelectedRows(0)

        FormInputPelanggan.txtKode.Text = row.Cells(0).Value.ToString()
        FormInputPelanggan.txtNama.Text = row.Cells(1).Value.ToString()
        FormInputPelanggan.txtNoTelp.Text = row.Cells(2).Value.ToString()
        FormInputPelanggan.txtKota.Text = row.Cells(3).Value.ToString()

        FormInputPelanggan.Text = "Ubah Pelanggan"
        FormInputPelanggan.ShowDialog()

        TampilData()

    End Sub

    ' =========================
    ' TOMBOL HAPUS
    ' =========================
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click

        If DgvPelanggan.SelectedRows.Count = 0 Then
            MessageBox.Show(
                "Pilih data yang ingin dihapus!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Exit Sub
        End If

        Dim kode As String = DgvPelanggan.SelectedRows(0).Cells(0).Value.ToString()

        Dim konfirmasi As DialogResult =
            MessageBox.Show(
                "Yakin ingin menghapus data ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

        If konfirmasi = DialogResult.Yes Then

            Try
                Using conn As MySqlConnection = KoneksiDB.GetConnection()

                    Dim query As String =
                        "DELETE FROM pelanggan 
                         WHERE kode_pelanggan = @kode"

                    Using cmd As New MySqlCommand(query, conn)

                        cmd.Parameters.AddWithValue("@kode", kode)
                        cmd.ExecuteNonQuery()

                    End Using

                End Using

                MessageBox.Show(
                    "Data berhasil dihapus!",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                TampilData()

            Catch ex As Exception

                MessageBox.Show(
                    "Data gagal dihapus!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

            End Try

        End If

    End Sub

    ' =========================
    ' PENCARIAN DATA
    ' =========================
    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged

        Dim keyword As String = TxtCari.Text.ToLower()

        For Each row As DataGridViewRow In DgvPelanggan.Rows

            If row.IsNewRow Then Continue For

            Dim kode As String = row.Cells(0).Value.ToString().ToLower()
            Dim nama As String = row.Cells(1).Value.ToString().ToLower()
            Dim email As String = row.Cells(2).Value.ToString().ToLower()

            If kode.Contains(keyword) Or
               nama.Contains(keyword) Or
               email.Contains(keyword) Then

                row.Visible = True

            Else

                row.Visible = False

            End If

        Next

    End Sub

End Class