Imports MySql.Data.MySqlClient

Public Class FormInputBarang

    Public Property Kode As String
    Public Property Nama As String
    Public Property Kategori As String
    Public Property Ukuran As String
    Public Property Warna As String
    Public Property Harga As String
    Public Property Stok As String
    Public Property ModeEdit As Boolean = False

    Private Sub FormInputBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadKategoriDB()

        txtKode.Text = Kode
        txtNama.Text = Nama
        cbKategori.Text = Kategori
        txtUkuran.Text = Ukuran
        txtWarna.Text = Warna
        txtHarga.Text = Harga
        txtStok.Text = Stok

        If ModeEdit Then

            txtKode.ReadOnly = True
            txtNama.Focus()

        End If

    End Sub

    Private Sub LoadKategoriDB()

        cbKategori.Items.Clear()

        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()

                Dim query As String =
                    "SELECT nama_kategori
                     FROM kategori
                     ORDER BY nama_kategori"

                Using cmd As New MySqlCommand(query, conn)

                    Using dr As MySqlDataReader = cmd.ExecuteReader()

                        While dr.Read()

                            cbKategori.Items.Add(
                                dr("nama_kategori").ToString()
                            )

                        End While

                    End Using
                End Using
            End Using

        Catch ex As Exception

            ' Biarkan kosong jika gagal load kategori

        End Try

    End Sub

    ' VALIDASI ANGKA
    Private Sub AngkaOnly_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress, txtStok.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso
           Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    ' TOMBOL SIMPAN
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If txtKode.Text.Trim = "" Or
           txtNama.Text.Trim = "" Or
           cbKategori.Text.Trim = "" Then

            MessageBox.Show(
                "Kode, nama, dan kategori wajib diisi!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Exit Sub

        End If

        Kode = txtKode.Text
        Nama = txtNama.Text
        Kategori = cbKategori.Text
        Ukuran = txtUkuran.Text
        Warna = txtWarna.Text
        Harga = txtHarga.Text
        Stok = txtStok.Text

        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

End Class