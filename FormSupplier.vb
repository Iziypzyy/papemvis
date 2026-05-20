Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class FormSupplier

    ' LOAD DATA SAAT FORM DIBUKA
    Private Sub FormSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataDB()
    End Sub

    Public Sub LoadDataDB()
        DgvSupplier.Rows.Clear()
        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()
                Dim query As String = "SELECT kode_supplier, nama_supplier, telepon, kota FROM supplier ORDER BY kode_supplier"
                Using cmd As New MySqlCommand(query, conn)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        Do While dr.Read()
                            DgvSupplier.Rows.Add(
                                dr("kode_supplier").ToString(),
                                dr("nama_supplier").ToString(),
                                dr("telepon").ToString(),
                                dr("kota").ToString()
                            )
                        Loop
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data supplier!" & vbNewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Tombol TAMBAH
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim frm As New FormInputSupplier()
        frm.Text = "Tambah Supplier Baru"
        If frm.ShowDialog() = DialogResult.OK Then
            Try
                Using conn As MySqlConnection = KoneksiDB.GetConnection()
                    Dim query As String =
                        "INSERT INTO supplier (kode_supplier, nama_supplier, telepon, kota) " &
                        "VALUES (@kode, @nama, @telp, @kota)"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@kode", frm.Kode)
                        cmd.Parameters.AddWithValue("@nama", frm.Nama)
                        cmd.Parameters.AddWithValue("@telp", frm.Telepon)
                        cmd.Parameters.AddWithValue("@kota", frm.Kota)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                LoadDataDB()
            Catch ex As Exception
                MessageBox.Show("Gagal menambah supplier!" & vbNewLine & ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' Tombol UBAH
    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        If DgvSupplier.CurrentRow IsNot Nothing Then
            Dim frm As New FormInputSupplier()
            frm.Kode = DgvSupplier.CurrentRow.Cells(0).Value.ToString()
            frm.Nama = DgvSupplier.CurrentRow.Cells(1).Value.ToString()
            frm.Telepon = DgvSupplier.CurrentRow.Cells(2).Value.ToString()
            frm.Kota = DgvSupplier.CurrentRow.Cells(3).Value.ToString()
            frm.ModeEdit = True

            If frm.ShowDialog() = DialogResult.OK Then
                Try
                    Using conn As MySqlConnection = KoneksiDB.GetConnection()
                        Dim query As String =
                            "UPDATE supplier SET nama_supplier = @nama, telepon = @telp, kota = @kota " &
                            "WHERE kode_supplier = @kode"
                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@nama", frm.Nama)
                            cmd.Parameters.AddWithValue("@telp", frm.Telepon)
                            cmd.Parameters.AddWithValue("@kota", frm.Kota)
                            cmd.Parameters.AddWithValue("@kode", frm.Kode)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using
                    MessageBox.Show("Data berhasil diperbarui!")
                    LoadDataDB()
                Catch ex As Exception
                    MessageBox.Show("Gagal mengubah supplier!" & vbNewLine & ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    ' Tombol HAPUS
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If DgvSupplier.CurrentRow IsNot Nothing Then
            Dim tanya As DialogResult = MessageBox.Show("Yakin mau hapus data ini?", "Konfirmasi",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If tanya = DialogResult.Yes Then
                Dim kode As String = DgvSupplier.CurrentRow.Cells(0).Value.ToString()
                Try
                    Using conn As MySqlConnection = KoneksiDB.GetConnection()
                        Dim query As String = "DELETE FROM supplier WHERE kode_supplier = @kode"
                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@kode", kode)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using
                    MessageBox.Show("Data berhasil dibuang!")
                    LoadDataDB()
                Catch ex As Exception
                    MessageBox.Show("Gagal menghapus supplier!" & vbNewLine & ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Pilih dulu data mana yang mau didepak!")
        End If
    End Sub

    ' Tombol Cari
    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Dim keyword As String = txtCari.Text.ToLower()
        For Each row As DataGridViewRow In DgvSupplier.Rows
            If Not row.IsNewRow Then
                Dim kode As String = row.Cells(0).Value.ToString().ToLower()
                Dim nama As String = row.Cells(1).Value.ToString().ToLower()
                Dim kota As String = row.Cells(3).Value.ToString().ToLower()
                If kode.Contains(keyword) Or nama.Contains(keyword) Or kota.Contains(keyword) Then
                    row.Visible = True
                Else
                    row.Visible = False
                End If
            End If
        Next
    End Sub
End Class