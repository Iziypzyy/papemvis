Imports MySql.Data.MySqlClient

Public Class FormSupplier

    ' =========================
    ' LOAD DATA SAAT FORM DIBUKA
    ' =========================
    Private Sub FormSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataDB()
    End Sub

    ' =========================
    ' MENAMPILKAN DATA SUPPLIER
    ' =========================
    Public Sub LoadDataDB()

        DgvSupplier.Rows.Clear()

        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()

                Dim query As String =
                    "SELECT kode_supplier, nama_supplier, telepon, kota " &
                    "FROM supplier ORDER BY kode_supplier"

                Using cmd As New MySqlCommand(query, conn)

                    Using dr As MySqlDataReader = cmd.ExecuteReader()

                        While dr.Read()

                            DgvSupplier.Rows.Add(
                                dr("kode_supplier").ToString(),
                                dr("nama_supplier").ToString(),
                                dr("telepon").ToString(),
                                dr("kota").ToString()
                            )

                        End While

                    End Using
                End Using
            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Gagal memuat data supplier!" &
                Environment.NewLine &
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    ' =========================
    ' TAMBAH DATA SUPPLIER
    ' =========================
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click

        Dim frm As New FormInputSupplier()

        frm.Text = "Tambah Supplier"

        If frm.ShowDialog() = DialogResult.OK Then

            Try
                Using conn As MySqlConnection = KoneksiDB.GetConnection()

                    Dim query As String =
                        "INSERT INTO supplier " &
                        "(kode_supplier, nama_supplier, telepon, kota) " &
                        "VALUES (@kode, @nama, @telepon, @kota)"

                    Using cmd As New MySqlCommand(query, conn)

                        cmd.Parameters.AddWithValue("@kode", frm.Kode)
                        cmd.Parameters.AddWithValue("@nama", frm.Nama)
                        cmd.Parameters.AddWithValue("@telepon", frm.Telepon)
                        cmd.Parameters.AddWithValue("@kota", frm.Kota)

                        cmd.ExecuteNonQuery()

                    End Using
                End Using

                MessageBox.Show(
                    "Data supplier berhasil ditambahkan!",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                LoadDataDB()

            Catch ex As Exception

                MessageBox.Show(
                    "Gagal menambah supplier!" &
                    Environment.NewLine &
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

            End Try

        End If

    End Sub

    ' =========================
    ' UBAH DATA SUPPLIER
    ' =========================
    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click

        If DgvSupplier.CurrentRow Is Nothing Then

            MessageBox.Show(
                "Pilih data supplier terlebih dahulu!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Exit Sub

        End If

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
                        "UPDATE supplier SET " &
                        "nama_supplier = @nama, " &
                        "telepon = @telepon, " &
                        "kota = @kota " &
                        "WHERE kode_supplier = @kode"

                    Using cmd As New MySqlCommand(query, conn)

                        cmd.Parameters.AddWithValue("@nama", frm.Nama)
                        cmd.Parameters.AddWithValue("@telepon", frm.Telepon)
                        cmd.Parameters.AddWithValue("@kota", frm.Kota)
                        cmd.Parameters.AddWithValue("@kode", frm.Kode)

                        cmd.ExecuteNonQuery()

                    End Using
                End Using

                MessageBox.Show(
                    "Data supplier berhasil diubah!",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                LoadDataDB()

            Catch ex As Exception

                MessageBox.Show(
                    "Gagal mengubah supplier!" &
                    Environment.NewLine &
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

            End Try

        End If

    End Sub

    ' =========================
    ' HAPUS DATA SUPPLIER
    ' =========================
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click

        If DgvSupplier.CurrentRow Is Nothing Then

            MessageBox.Show(
                "Pilih data supplier yang ingin dihapus!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Exit Sub

        End If

        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Yakin ingin menghapus data supplier ini?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If konfirmasi = DialogResult.Yes Then

            Dim kode As String =
                DgvSupplier.CurrentRow.Cells(0).Value.ToString()

            Try
                Using conn As MySqlConnection = KoneksiDB.GetConnection()

                    Dim query As String =
                        "DELETE FROM supplier WHERE kode_supplier = @kode"

                    Using cmd As New MySqlCommand(query, conn)

                        cmd.Parameters.AddWithValue("@kode", kode)

                        cmd.ExecuteNonQuery()

                    End Using
                End Using

                MessageBox.Show(
                    "Data supplier berhasil dihapus!",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                LoadDataDB()

            Catch ex As Exception

                MessageBox.Show(
                    "Gagal menghapus supplier!" &
                    Environment.NewLine &
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

            End Try

        End If

    End Sub

    ' =========================
    ' CARI DATA SUPPLIER
    ' =========================
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

        Dim keyword As String = txtCari.Text.ToLower()

        For Each row As DataGridViewRow In DgvSupplier.Rows

            If row.IsNewRow Then Continue For

            Dim kode As String =
                row.Cells(0).Value.ToString().ToLower()

            Dim nama As String =
                row.Cells(1).Value.ToString().ToLower()

            Dim kota As String =
                row.Cells(3).Value.ToString().ToLower()

            If kode.Contains(keyword) OrElse
               nama.Contains(keyword) OrElse
               kota.Contains(keyword) Then

                row.Visible = True

            Else

                row.Visible = False

            End If

        Next

    End Sub

End Class