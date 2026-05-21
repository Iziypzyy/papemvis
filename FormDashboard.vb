Imports MySql.Data.MySqlClient

Public Class FormDashboard

    Private WithEvents waktuTimer As New Timer()

    ' ==========================================
    ' 1. EVENT KETIKA FORM DASHBOARD DIBUKA
    ' ==========================================
    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelDate.Text = Format(Date.Now, "dddd, dd MMMM yyyy")
        LabelTime.Text = Format(Date.Now, "HH:mm:ss")

        waktuTimer.Interval = 1000
        waktuTimer.Start()

        LoadDashboard()
        LoadTopProduk()
    End Sub

    Private Sub waktuTimer_Tick(sender As Object, e As EventArgs) Handles waktuTimer.Tick
        LabelTime.Text = Format(Date.Now, "HH:mm:ss")
    End Sub

    ' ==========================================
    ' 2. FUNGSI LOAD DATA DASHBOARD (DATABASE)
    ' ==========================================
    Private Sub LoadDashboard()
        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()
                Dim query As String = "SELECT * FROM v_dashboard"

                Using cmd As New MySqlCommand(query, conn)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            LabelProdukValue.Text = dr("total_produk").ToString()
                            LabelStokValue.Text = dr("produk_stok_menipis").ToString()
                            LabelPenjualanValue.Text = "Rp " & Format(Convert.ToDouble(dr("penjualan_hari_ini")), "###,###,##0")
                            LabelPelangganValue.Text = dr("total_pelanggan").ToString()

                            LabelNotif1.Text = "- " & dr("produk_stok_menipis").ToString() & " produk dengan stok menipis"
                        End If
                    End Using
                End Using
            End Using

            LabelNotif2.Text = "- Sistem berjalan normal"
            LabelNotif3.Text = "- Backup data terakhir : " & Format(Date.Now, "dd/MM/yyyy HH:mm")

            LabelInfoUser.Text = "User Aktif              :   admin"
            LabelInfoLevel.Text = "Level                   :   Administrator"
            LabelInfoVersi.Text = "Versi Aplikasi          :   1.0.0.0"

        Catch ex As Exception
            ' Jika XAMPP belum nyala / database error, akan masuk ke sini
            LabelProdukValue.Text = "-"
            LabelStokValue.Text = "-"
            LabelPenjualanValue.Text = "Rp 0"
            LabelPelangganValue.Text = "-"

            LabelNotif1.Text = "- Gagal terhubung ke Database"
            LabelNotif2.Text = "- Pastikan XAMPP/MySQL aktif"
            LabelNotif3.Text = "- Menunggu koneksi..."
        End Try
    End Sub

    Private Sub LoadTopProduk()
        TableTopProduk.Controls.Clear()

        ' Buat Header Tabel
        TableTopProduk.Controls.Add(BuatLabelTable("No", True), 0, 0)
        TableTopProduk.Controls.Add(BuatLabelTable("Nama Produk", True), 1, 0)
        TableTopProduk.Controls.Add(BuatLabelTable("Terjual", True), 2, 0)

        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()
                Dim query As String = "SELECT nama_barang, SUM(qty) AS total_terjual FROM detail_penjualan GROUP BY nama_barang ORDER BY total_terjual DESC LIMIT 5"

                Using cmd As New MySqlCommand(query, conn)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        Dim no As Integer = 1
                        While dr.Read()
                            TableTopProduk.Controls.Add(BuatLabelTable(no.ToString()), 0, no)
                            TableTopProduk.Controls.Add(BuatLabelTable(dr("nama_barang").ToString()), 1, no)
                            TableTopProduk.Controls.Add(BuatLabelTable(dr("total_terjual").ToString()), 2, no)
                            no += 1
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            TableTopProduk.Controls.Add(BuatLabelTable("-"), 0, 1)
            TableTopProduk.Controls.Add(BuatLabelTable("Menunggu Database..."), 1, 1)
            TableTopProduk.Controls.Add(BuatLabelTable("-"), 2, 1)
        End Try
    End Sub

    Private Function BuatLabelTable(teks As String, Optional header As Boolean = False) As Label
        Dim lbl As New Label With {
            .Text = teks,
            .Dock = DockStyle.Fill,
            .TextAlign = ContentAlignment.MiddleCenter,
            .Margin = New Padding(0)
        }

        If header Then
            lbl.Font = New Font("Segoe UI", 9, FontStyle.Bold)
            lbl.BackColor = Color.FromArgb(230, 230, 230)
        Else
            lbl.Font = New Font("Segoe UI", 9, FontStyle.Regular)
            lbl.BackColor = Color.White
        End If
        Return lbl
    End Function

    ' ==========================================
    ' 3. FUNGSI TOMBOL SIDEBAR (KIRI)
    ' ==========================================
    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        LoadDashboard()
        LoadTopProduk()
    End Sub

    Private Sub BtnDataBarang_Click(sender As Object, e As EventArgs) Handles BtnDataBarang.Click
        ' HAPUS tanda kutip tunggal (') di bawah ini jika FormDataBarang sudah Anda buat!
        ' FormDataBarang.Show() 
        TampilkanPesanError("Data Barang")
    End Sub

    Private Sub BtnKategori_Click(sender As Object, e As EventArgs) Handles BtnKategori.Click
        ' HAPUS tanda kutip tunggal (') di bawah ini jika FormKategori sudah Anda buat!
        ' FormKategori.Show()
        TampilkanPesanError("Kategori")
    End Sub

    Private Sub BtnSupplier_Click(sender As Object, e As EventArgs) Handles BtnSupplier.Click
        ' HAPUS tanda kutip tunggal (') di bawah ini jika FormSupplier sudah Anda buat!
        ' FormSupplier.Show()
        TampilkanPesanError("Supplier")
    End Sub

    Private Sub BtnPelanggan_Click(sender As Object, e As EventArgs) Handles BtnPelanggan.Click
        MessageBox.Show("Modul Pelanggan dinonaktifkan untuk akses Admin.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnPenjualan_Click(sender As Object, e As EventArgs) Handles BtnPenjualan.Click
        ' HAPUS tanda kutip tunggal (') di bawah ini jika FormTransaksiPenjualan sudah Anda buat!
        ' FormTransaksiPenjualan.Show()
        TampilkanPesanError("Transaksi Penjualan")
    End Sub

    Private Sub BtnPembelian_Click(sender As Object, e As EventArgs) Handles BtnPembelian.Click
        ' HAPUS tanda kutip tunggal (') di bawah ini jika FormPembelian (atau Form8) sudah Anda buat!
        ' Form8.Show() 
        TampilkanPesanError("Pembelian")
    End Sub

    Private Sub BtnStok_Click(sender As Object, e As EventArgs) Handles BtnStok.Click
        ' HAPUS tanda kutip tunggal (') di bawah ini jika FormStokBarang sudah Anda buat!
        ' FormStokBarang.Show()
        TampilkanPesanError("Stok Barang")
    End Sub

    Private Sub BtnLaporan_Click(sender As Object, e As EventArgs) Handles BtnLaporan.Click
        ' HAPUS tanda kutip tunggal (') di bawah ini jika FormLaporan sudah Anda buat!
        ' FormLaporan.Show()
        TampilkanPesanError("Laporan Utama")
    End Sub

    Private Sub BtnUser_Click(sender As Object, e As EventArgs) Handles BtnUser.Click
        ' HAPUS tanda kutip tunggal (') di bawah ini jika FormUser sudah Anda buat!
        ' FormUser.Show()
        TampilkanPesanError("Manajemen User")
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        If MessageBox.Show("Yakin ingin mengakhiri sesi dan logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Hide()
            ' Karena Anda SUDAH MEMBUAT FormLoginAdmin, ini aman untuk dipanggil:
            Try
                FormLoginAdmin.Show()
            Catch ex As Exception
                Application.Exit()
            End Try
        End If
    End Sub

    ' ==========================================
    ' 4. FUNGSI MENU STRIP (MENU ATAS)
    ' ==========================================
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        MessageBox.Show("Anda saat ini sudah berada di dalam sistem sebagai Admin.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        BtnLogout.PerformClick()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub DataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem.Click
        BtnDataBarang.PerformClick()
    End Sub

    Private Sub KategoriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KategoriToolStripMenuItem.Click
        BtnKategori.PerformClick()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        BtnSupplier.PerformClick()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        BtnPelanggan.PerformClick()
    End Sub

    Private Sub UserAdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserAdminToolStripMenuItem.Click
        BtnUser.PerformClick()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        BtnPenjualan.PerformClick()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem.Click
        BtnPembelian.PerformClick()
    End Sub

    Private Sub LaporanPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPenjualanToolStripMenuItem.Click
        TampilkanPesanError("Laporan Penjualan")
    End Sub

    Private Sub LaporanStokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanStokToolStripMenuItem.Click
        TampilkanPesanError("Laporan Stok")
    End Sub

    Private Sub LaporanPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPembelianToolStripMenuItem.Click
        TampilkanPesanError("Laporan Pembelian")
    End Sub

    Private Sub CetakStrukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CetakStrukToolStripMenuItem.Click
        TampilkanPesanError("Cetak Struk")
    End Sub

    Private Sub ProfilTokoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilTokoToolStripMenuItem.Click
        MessageBox.Show("Modul Pengaturan Profil Toko belum diaktifkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BackupDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupDatabaseToolStripMenuItem.Click
        MessageBox.Show("Fitur Backup Database sedang dalam pemeliharaan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub RestoreDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreDatabaseToolStripMenuItem.Click
        MessageBox.Show("Fitur Restore Database sedang dalam pemeliharaan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TentangAplikasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TentangAplikasiToolStripMenuItem.Click
        MessageBox.Show("Sistem Manajemen Toko Pakaian Pria" & Environment.NewLine & "Gentlemen Men's Wear - Versi 1.0", "Tentang Aplikasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub PanduanPenggunaanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PanduanPenggunaanToolStripMenuItem.Click
        MessageBox.Show("Panduan penggunaan belum tersedia.", "Bantuan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' ==========================================
    ' 5. FUNGSI BANTUAN (HELPER)
    ' ==========================================
    Private Sub TampilkanPesanError(namaModul As String)
        MessageBox.Show("Form untuk modul [" & namaModul & "] belum dibuat." & Environment.NewLine & "Silakan buat form tersebut di Solution Explorer, lalu buka kode ini dan hapus tanda kutip tunggal (') pada baris fungsinya.", "Modul Belum Tersedia", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class