Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnDashboard.Cursor = Cursors.Hand
        BtnDataBarang.Cursor = Cursors.Hand
        BtnKategori.Cursor = Cursors.Hand
        BtnSupplier.Cursor = Cursors.Hand
        BtnPelanggan.Cursor = Cursors.Hand
        BtnPenjualan.Cursor = Cursors.Hand
        BtnPembelian.Cursor = Cursors.Hand
        BtnStok.Cursor = Cursors.Hand
        BtnLaporan.Cursor = Cursors.Hand
        BtnUser.Cursor = Cursors.Hand
        BtnLogout.Cursor = Cursors.Hand
    End Sub

    Private Sub ResetSidebarColor()
        BtnDashboard.BackColor = Color.FromArgb(3, 28, 48)
        BtnDataBarang.BackColor = Color.FromArgb(3, 28, 48)
        BtnKategori.BackColor = Color.FromArgb(3, 28, 48)
        BtnSupplier.BackColor = Color.FromArgb(3, 28, 48)
        BtnPelanggan.BackColor = Color.FromArgb(3, 28, 48)
        BtnPenjualan.BackColor = Color.FromArgb(3, 28, 48)
        BtnPembelian.BackColor = Color.FromArgb(3, 28, 48)
        BtnStok.BackColor = Color.FromArgb(3, 28, 48)
        BtnLaporan.BackColor = Color.FromArgb(3, 28, 48)
        BtnUser.BackColor = Color.FromArgb(3, 28, 48)
        BtnLogout.BackColor = Color.FromArgb(3, 28, 48)
    End Sub

    Private Sub SetActiveButton(btn As Button)
        ResetSidebarColor()
        btn.BackColor = Color.FromArgb(0, 102, 204)
    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        SetActiveButton(BtnDashboard)
        MessageBox.Show("Dashboard sedang aktif.", "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnDataBarang_Click(sender As Object, e As EventArgs) Handles BtnDataBarang.Click
        SetActiveButton(BtnDataBarang)
        MessageBox.Show("Form Data Barang dibuka.", "Master Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnKategori_Click(sender As Object, e As EventArgs) Handles BtnKategori.Click
        SetActiveButton(BtnKategori)
        MessageBox.Show("Form Kategori dibuka.", "Master Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnSupplier_Click(sender As Object, e As EventArgs) Handles BtnSupplier.Click
        SetActiveButton(BtnSupplier)
        MessageBox.Show("Form Supplier dibuka.", "Master Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnPelanggan_Click(sender As Object, e As EventArgs) Handles BtnPelanggan.Click
        SetActiveButton(BtnPelanggan)
        MessageBox.Show("Form Pelanggan dibuka.", "Master Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnPenjualan_Click(sender As Object, e As EventArgs) Handles BtnPenjualan.Click
        SetActiveButton(BtnPenjualan)
        MessageBox.Show("Form Transaksi Penjualan dibuka.", "Transaksi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnPembelian_Click(sender As Object, e As EventArgs) Handles BtnPembelian.Click
        SetActiveButton(BtnPembelian)
        MessageBox.Show("Form Pembelian / Stok Masuk dibuka.", "Transaksi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnStok_Click(sender As Object, e As EventArgs) Handles BtnStok.Click
        SetActiveButton(BtnStok)
        MessageBox.Show("Form Stok Barang dibuka.", "Stok", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnLaporan_Click(sender As Object, e As EventArgs) Handles BtnLaporan.Click
        SetActiveButton(BtnLaporan)
        MessageBox.Show("Form Laporan dibuka.", "Laporan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnUser_Click(sender As Object, e As EventArgs) Handles BtnUser.Click
        SetActiveButton(BtnUser)
        MessageBox.Show("Form User / Admin dibuka.", "User", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim tanya As DialogResult

        tanya = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?",
                                "Konfirmasi Logout",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question)

        If tanya = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub LoginMenuItem_Click(sender As Object, e As EventArgs) Handles LoginMenuItem.Click
        MessageBox.Show("Menu Login dibuka.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LogoutMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutMenuItem.Click
        BtnLogout.PerformClick()
    End Sub

    Private Sub KeluarMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarMenuItem.Click
        BtnLogout.PerformClick()
    End Sub

    Private Sub DataBarangMenuItem_Click(sender As Object, e As EventArgs) Handles DataBarangMenuItem.Click
        BtnDataBarang.PerformClick()
    End Sub

    Private Sub KategoriMenuItem_Click(sender As Object, e As EventArgs) Handles KategoriMenuItem.Click
        BtnKategori.PerformClick()
    End Sub

    Private Sub SupplierMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierMenuItem.Click
        BtnSupplier.PerformClick()
    End Sub

    Private Sub PelangganMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganMenuItem.Click
        BtnPelanggan.PerformClick()
    End Sub

    Private Sub UserMenuItem_Click(sender As Object, e As EventArgs) Handles UserMenuItem.Click
        BtnUser.PerformClick()
    End Sub

    Private Sub PenjualanMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanMenuItem.Click
        BtnPenjualan.PerformClick()
    End Sub

    Private Sub PembelianMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianMenuItem.Click
        BtnPembelian.PerformClick()
    End Sub

    Private Sub LaporanPenjualanMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPenjualanMenuItem.Click
        BtnLaporan.PerformClick()
        MessageBox.Show("Laporan Penjualan dibuka.", "Laporan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LaporanStokMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanStokMenuItem.Click
        BtnLaporan.PerformClick()
        MessageBox.Show("Laporan Stok Barang dibuka.", "Laporan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LaporanPembelianMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPembelianMenuItem.Click
        BtnLaporan.PerformClick()
        MessageBox.Show("Laporan Pembelian dibuka.", "Laporan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CetakStrukMenuItem_Click(sender As Object, e As EventArgs) Handles CetakStrukMenuItem.Click
        MessageBox.Show("Fitur Cetak Struk dibuka.", "Cetak Struk", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ProfilTokoMenuItem_Click(sender As Object, e As EventArgs) Handles ProfilTokoMenuItem.Click
        MessageBox.Show("Pengaturan Profil Toko dibuka.", "Pengaturan", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BackupDatabaseMenuItem_Click(sender As Object, e As EventArgs) Handles BackupDatabaseMenuItem.Click
        MessageBox.Show("Backup Database diproses.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub RestoreDatabaseMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreDatabaseMenuItem.Click
        MessageBox.Show("Restore Database diproses.", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TentangAplikasiMenuItem_Click(sender As Object, e As EventArgs) Handles TentangAplikasiMenuItem.Click
        MessageBox.Show("Sistem Manajemen Toko Pakaian Pria" & vbCrLf &
                        "Versi 1.0.0.0" & vbCrLf &
                        "Dibuat dengan Visual Basic Windows Forms.",
                        "Tentang Aplikasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub PanduanMenuItem_Click(sender As Object, e As EventArgs) Handles PanduanMenuItem.Click
        MessageBox.Show("Gunakan Master Data untuk mengelola data utama." & vbCrLf &
                        "Gunakan Transaksi untuk penjualan dan pembelian." & vbCrLf &
                        "Gunakan Laporan untuk melihat rekap dan cetak data.",
                        "Panduan Penggunaan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

End Class