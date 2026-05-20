Imports MySql.Data.MySqlClient

Public Class FormDataBarang

    ' LOAD DATA SAAT FORM DIBUKA
    Private Sub FormDataBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadDataDB()

    End Sub

    Public Sub LoadDataDB()

        DgvDataBarang.Rows.Clear()

        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()

                Dim query As String =
                    "SELECT 
                        b.kode_barang,
                        b.nama_barang,
                        k.nama_kategori,
                        b.ukuran,
                        b.warna,
                        b.harga,
                        b.stok
                     FROM barang b
                     LEFT JOIN kategori k
                        ON b.kode_kategori = k.kode_kategori
                     ORDER BY b.kode_barang"

                Using cmd As New MySqlCommand(query, conn)

                    Using dr As MySqlDataReader = cmd.ExecuteReader()

                        While dr.Read()

                            DgvDataBarang.Rows.Add(
                                dr("kode_barang").ToString(),
                                dr("nama_barang").ToString(),
                                dr("nama_kategori").ToString(),
                                dr("ukuran").ToString(),
                                dr("warna").ToString(),
                                Format(Convert.ToDouble(dr("harga")), "###,###,##0"),
                                dr("stok").ToString()
                            )

                        End While

                    End Using
                End Using
            End Using

            UpdateTotalData()

        Catch ex As Exception

            MessageBox.Show(
                "Gagal memuat data barang!" & vbNewLine & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    ' TOMBOL TAMBAH
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click

        Dim frm As New FormInputBarang()

        If frm.ShowDialog() = DialogResult.OK Then

            Try
                Using conn As MySqlConnection = KoneksiDB.GetConnection()

                    Dim kodeKat As String = ""

                    Dim cekKat As String =
                        "SELECT kode_kategori
                         FROM kategori
                         WHERE nama_kategori = @nama"

                    Using cmdKat As New MySqlCommand(cekKat, conn)

                        cmdKat.Parameters.AddWithValue("@nama", frm.Kategori)

                        Dim result = cmdKat.ExecuteScalar()

                        If result IsNot Nothing Then
                            kodeKat = result.ToString()
                        End If

                    End Using

                    Dim query As String =
                        "INSERT INTO barang
                        (kode_barang, nama_barang, kode_kategori, ukuran, warna, harga, stok)
                        VALUES
                        (@kode, @nama, @kat, @ukuran, @warna, @harga, @stok)"

                    Using cmd As New MySqlCommand(query, conn)

                        cmd.Parameters.AddWithValue("@kode", frm.Kode)
                        cmd.Parameters.AddWithValue("@nama", frm.Nama)
                        cmd.Parameters.AddWithValue("@kat", kodeKat)
                        cmd.Parameters.AddWithValue("@ukuran", frm.Ukuran)
                        cmd.Parameters.AddWithValue("@warna", frm.Warna)
                        cmd.Parameters.AddWithValue("@harga", frm.Harga)
                        cmd.Parameters.AddWithValue("@stok", frm.Stok)

                        cmd.ExecuteNonQuery()

                    End Using
                End Using

                LoadDataDB()

            Catch ex As Exception

                MessageBox.Show(
                    "Gagal menambah barang!" & vbNewLine & ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

            End Try

        End If

    End Sub

    ' TOMBOL UBAH
    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click

        If DgvDataBarang.CurrentRow IsNot Nothing Then

            Dim frm As New FormInputBarang()

            With DgvDataBarang.CurrentRow

                frm.Kode = .Cells(0).Value.ToString()
                frm.Nama = .Cells(1).Value.ToString()
                frm.Kategori = .Cells(2).Value.ToString()
                frm.Ukuran = .Cells(3).Value.ToString()
                frm.Warna = .Cells(4).Value.ToString()
                frm.Harga = .Cells(5).Value.ToString().Replace(".", "")
                frm.Stok = .Cells(6).Value.ToString()

            End With

            frm.ModeEdit = True

            If frm.ShowDialog() = DialogResult.OK Then

                Try
                    Using conn As MySqlConnection = KoneksiDB.GetConnection()

                        Dim kodeKat As String = ""

                        Dim cekKat As String =
                            "SELECT kode_kategori
                             FROM kategori
                             WHERE nama_kategori = @nama"

                        Using cmdKat As New MySqlCommand(cekKat, conn)

                            cmdKat.Parameters.AddWithValue("@nama", frm.Kategori)

                            Dim result = cmdKat.ExecuteScalar()

                            If result IsNot Nothing Then
                                kodeKat = result.ToString()
                            End If

                        End Using

                        Dim query As String =
                            "UPDATE barang
                             SET nama_barang = @nama,
                                 kode_kategori = @kat,
                                 ukuran = @ukuran,
                                 warna = @warna,
                                 harga = @harga,
                                 stok = @stok
                             WHERE kode_barang = @kode"

                        Using cmd As New MySqlCommand(query, conn)

                            cmd.Parameters.AddWithValue("@nama", frm.Nama)
                            cmd.Parameters.AddWithValue("@kat", kodeKat)
                            cmd.Parameters.AddWithValue("@ukuran", frm.Ukuran)
                            cmd.Parameters.AddWithValue("@warna", frm.Warna)
                            cmd.Parameters.AddWithValue("@harga", frm.Harga)
                            cmd.Parameters.AddWithValue("@stok", frm.Stok)
                            cmd.Parameters.AddWithValue("@kode", frm.Kode)

                            cmd.ExecuteNonQuery()

                        End Using
                    End Using

                    LoadDataDB()

                Catch ex As Exception

                    MessageBox.Show(
                        "Gagal mengubah barang!" & vbNewLine & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    )

                End Try

            End If

        End If

    End Sub

    ' UPDATE DETAIL DATA
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

    Private Sub UpdateTotalData()

        LblTotalData.Text = "Total Data : " & DgvDataBarang.Rows.Count

    End Sub

    ' TOMBOL HAPUS
    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapusItem.Click

        If DgvDataBarang.CurrentRow IsNot Nothing Then

            Dim namaBarang As String =
                DgvDataBarang.CurrentRow.Cells(1).Value.ToString()

            Dim kodeBarang As String =
                DgvDataBarang.CurrentRow.Cells(0).Value.ToString()

            Dim tanya As DialogResult =
                MessageBox.Show(
                    "Apakah Anda yakin ingin menghapus barang: " & namaBarang & "?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                )

            If tanya = DialogResult.Yes Then

                Try
                    Using conn As MySqlConnection = KoneksiDB.GetConnection()

                        Dim query As String =
                            "DELETE FROM barang
                             WHERE kode_barang = @kode"

                        Using cmd As New MySqlCommand(query, conn)

                            cmd.Parameters.AddWithValue("@kode", kodeBarang)

                            cmd.ExecuteNonQuery()

                        End Using
                    End Using

                    LoadDataDB()

                    LblValKode.Text = "-"
                    LblValNama.Text = "-"
                    LblValKategori.Text = "-"
                    LblValHarga.Text = "0"
                    LblValStok.Text = "0"

                Catch ex As Exception

                    MessageBox.Show(
                        "Gagal menghapus barang!" & vbNewLine & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    )

                End Try

            End If

        Else

            MessageBox.Show(
                "Pilih data barang terlebih dahulu!",
                "Informasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

        End If

    End Sub

    ' PENCARIAN DATA
    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged

        Dim keyword As String =
            TxtCari.Text.ToLower().Trim()

        For Each row As DataGridViewRow In DgvDataBarang.Rows

            If Not row.IsNewRow Then

                Dim kode As String =
                    row.Cells(0).Value.ToString().ToLower()

                Dim nama As String =
                    row.Cells(1).Value.ToString().ToLower()

                Dim kategori As String =
                    row.Cells(2).Value.ToString().ToLower()

                If kode.Contains(keyword) OrElse
                   nama.Contains(keyword) OrElse
                   kategori.Contains(keyword) Then

                    row.Visible = True

                Else

                    row.Visible = False

                End If

            End If

        Next

        UpdateTotalData()

    End Sub

End Class