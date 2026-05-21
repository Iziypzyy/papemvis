Imports MySql.Data.MySqlClient

Public Class FormPelanggan

    Private Sub FormPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataDB()
    End Sub

    Private Sub LoadDataDB()
        DgvPelanggan.Rows.Clear()
        Try
            Dim sql As String = "SELECT kode_pelanggan, nama_pelanggan, telepon, IFNULL(alamat,'') AS alamat FROM pelanggan ORDER BY kode_pelanggan"
            Dim dt As DataTable = DataModule.ExecSelect(sql)
            For Each r As DataRow In dt.Rows
                DgvPelanggan.Rows.Add(r("kode_pelanggan").ToString(), r("nama_pelanggan").ToString(), r("telepon").ToString(), r("alamat").ToString())
            Next
            LblTotalData.Text = "Total Data : " & DgvPelanggan.Rows.Count.ToString()
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data pelanggan!" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Generate kode otomatis PLG### (mengambil nilai MAX dari DB tiap kali dipanggil)
    Private Function GenerateKode() As String
        Try
            Dim sql As String = "SELECT IFNULL(MAX(CAST(SUBSTRING(kode_pelanggan,4) AS UNSIGNED)),0) FROM pelanggan"
            Dim obj = DataModule.ExecScalar(sql)
            Dim maxNum As Integer = 0
            If obj IsNot Nothing AndAlso Integer.TryParse(obj.ToString(), maxNum) Then
                ' ok
            End If
            Return "PLG" & (maxNum + 1).ToString("D3")
        Catch
            Return "PLG001"
        End Try
    End Function

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim frm As New FormInputPelanggan()
        frm.ModeEdit = False
        frm.Kode = GenerateKode()
        frm.lblKode.Text = frm.Kode
        If frm.ShowDialog() = DialogResult.OK Then
            LoadDataDB()
        End If
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        If DgvPelanggan.CurrentRow Is Nothing Then
            MessageBox.Show("Pilih data pelanggan terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim kode = DgvPelanggan.CurrentRow.Cells(0).Value.ToString()
        Dim nama = DgvPelanggan.CurrentRow.Cells(1).Value.ToString()
        Dim telp = DgvPelanggan.CurrentRow.Cells(2).Value.ToString()
        Dim kota = DgvPelanggan.CurrentRow.Cells(3).Value.ToString()

        Dim frm As New FormInputPelanggan()
        frm.ModeEdit = True
        frm.Kode = kode
        frm.txtNama.Text = nama
        frm.txtTelp.Text = telp
        frm.txtKota.Text = kota
        frm.lblKode.Text = kode

        If frm.ShowDialog() = DialogResult.OK Then
            LoadDataDB()
        End If
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If DgvPelanggan.CurrentRow Is Nothing Then
            MessageBox.Show("Pilih data pelanggan terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim kode = DgvPelanggan.CurrentRow.Cells(0).Value.ToString()
        Dim nama = DgvPelanggan.CurrentRow.Cells(1).Value.ToString()

        If MessageBox.Show("Yakin ingin menghapus pelanggan: " & nama & " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim sql As String = "DELETE FROM pelanggan WHERE kode_pelanggan = @kode"
                Dim p As New Dictionary(Of String, Object) From {{"@kode", kode}}
                DataModule.ExecNonQuery(sql, p)
                MessageBox.Show("Data pelanggan berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadDataDB()
            Catch ex As Exception
                MessageBox.Show("Gagal menghapus pelanggan!" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        Dim keyword As String = TxtCari.Text.ToLower().Trim()
        For Each row As DataGridViewRow In DgvPelanggan.Rows
            If row.IsNewRow Then Continue For
            Dim kode As String = row.Cells(0).Value.ToString().ToLower()
            Dim nama As String = row.Cells(1).Value.ToString().ToLower()
            Dim kota As String = row.Cells(3).Value.ToString().ToLower()
            row.Visible = (kode.Contains(keyword) OrElse nama.Contains(keyword) OrElse kota.Contains(keyword))
        Next
        LblTotalData.Text = "Total Data : " & DgvPelanggan.Rows.Cast(Of DataGridViewRow)().Count(Function(r) r.Visible AndAlso Not r.IsNewRow).ToString()
    End Sub

End Class