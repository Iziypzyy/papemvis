<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengaturanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As ToolStripMenuItem

    Friend WithEvents LoginMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarMenuItem As ToolStripMenuItem
    Friend WithEvents DataBarangMenuItem As ToolStripMenuItem
    Friend WithEvents KategoriMenuItem As ToolStripMenuItem
    Friend WithEvents SupplierMenuItem As ToolStripMenuItem
    Friend WithEvents PelangganMenuItem As ToolStripMenuItem
    Friend WithEvents UserMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanMenuItem As ToolStripMenuItem
    Friend WithEvents PembelianMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPenjualanMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanStokMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPembelianMenuItem As ToolStripMenuItem
    Friend WithEvents CetakStrukMenuItem As ToolStripMenuItem
    Friend WithEvents ProfilTokoMenuItem As ToolStripMenuItem
    Friend WithEvents BackupDatabaseMenuItem As ToolStripMenuItem
    Friend WithEvents RestoreDatabaseMenuItem As ToolStripMenuItem
    Friend WithEvents TentangAplikasiMenuItem As ToolStripMenuItem
    Friend WithEvents PanduanMenuItem As ToolStripMenuItem

    Friend WithEvents PanelSidebar As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents LblLogoIcon As Label
    Friend WithEvents LblBrand As Label
    Friend WithEvents LblBrandSub As Label

    Friend WithEvents BtnDashboard As Button
    Friend WithEvents BtnDataBarang As Button
    Friend WithEvents BtnKategori As Button
    Friend WithEvents BtnSupplier As Button
    Friend WithEvents BtnPelanggan As Button
    Friend WithEvents BtnPenjualan As Button
    Friend WithEvents BtnPembelian As Button
    Friend WithEvents BtnStok As Button
    Friend WithEvents BtnLaporan As Button
    Friend WithEvents BtnUser As Button
    Friend WithEvents BtnLogout As Button

    Friend WithEvents PanelContent As Panel
    Friend WithEvents LblWelcome As Label
    Friend WithEvents LblSubtitle As Label
    Friend WithEvents LblDate As Label
    Friend WithEvents LblTime As Label

    Friend WithEvents PanelCardProduk As Panel
    Friend WithEvents PanelCardStok As Panel
    Friend WithEvents PanelCardPenjualan As Panel
    Friend WithEvents PanelCardPelanggan As Panel

    Friend WithEvents LblProdukIcon As Label
    Friend WithEvents LblProdukTitle As Label
    Friend WithEvents LblProdukValue As Label
    Friend WithEvents LblProdukInfo As Label

    Friend WithEvents LblStokIcon As Label
    Friend WithEvents LblStokTitle As Label
    Friend WithEvents LblStokValue As Label
    Friend WithEvents LblStokInfo As Label

    Friend WithEvents LblPenjualanIcon As Label
    Friend WithEvents LblPenjualanTitle As Label
    Friend WithEvents LblPenjualanValue As Label
    Friend WithEvents LblPenjualanInfo As Label

    Friend WithEvents LblPelangganIcon As Label
    Friend WithEvents LblPelangganTitle As Label
    Friend WithEvents LblPelangganValue As Label
    Friend WithEvents LblPelangganInfo As Label

    Friend WithEvents PanelGrafik As Panel
    Friend WithEvents LblGrafikTitle As Label
    Friend WithEvents LblGrafikText As Label
    Friend WithEvents LblGrafikTanggal As Label

    Friend WithEvents PanelTopProduk As Panel
    Friend WithEvents LblTopProdukTitle As Label
    Friend WithEvents DgvTopProduk As DataGridView

    Friend WithEvents PanelNotifikasi As Panel
    Friend WithEvents LblNotifikasiTitle As Label
    Friend WithEvents LblNotif1 As Label
    Friend WithEvents LblNotif2 As Label
    Friend WithEvents LblNotif3 As Label

    Friend WithEvents PanelInfo As Panel
    Friend WithEvents LblInfoTitle As Label
    Friend WithEvents LblInfoUser As Label
    Friend WithEvents LblInfoLevel As Label
    Friend WithEvents LblInfoVersi As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()

        Me.MenuStrip1 = New MenuStrip()
        Me.FileToolStripMenuItem = New ToolStripMenuItem()
        Me.MasterDataToolStripMenuItem = New ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New ToolStripMenuItem()
        Me.PengaturanToolStripMenuItem = New ToolStripMenuItem()
        Me.BantuanToolStripMenuItem = New ToolStripMenuItem()

        Me.LoginMenuItem = New ToolStripMenuItem()
        Me.LogoutMenuItem = New ToolStripMenuItem()
        Me.KeluarMenuItem = New ToolStripMenuItem()
        Me.DataBarangMenuItem = New ToolStripMenuItem()
        Me.KategoriMenuItem = New ToolStripMenuItem()
        Me.SupplierMenuItem = New ToolStripMenuItem()
        Me.PelangganMenuItem = New ToolStripMenuItem()
        Me.UserMenuItem = New ToolStripMenuItem()
        Me.PenjualanMenuItem = New ToolStripMenuItem()
        Me.PembelianMenuItem = New ToolStripMenuItem()
        Me.LaporanPenjualanMenuItem = New ToolStripMenuItem()
        Me.LaporanStokMenuItem = New ToolStripMenuItem()
        Me.LaporanPembelianMenuItem = New ToolStripMenuItem()
        Me.CetakStrukMenuItem = New ToolStripMenuItem()
        Me.ProfilTokoMenuItem = New ToolStripMenuItem()
        Me.BackupDatabaseMenuItem = New ToolStripMenuItem()
        Me.RestoreDatabaseMenuItem = New ToolStripMenuItem()
        Me.TentangAplikasiMenuItem = New ToolStripMenuItem()
        Me.PanduanMenuItem = New ToolStripMenuItem()

        Me.PanelSidebar = New Panel()
        Me.PanelLogo = New Panel()
        Me.LblLogoIcon = New Label()
        Me.LblBrand = New Label()
        Me.LblBrandSub = New Label()

        Me.BtnDashboard = New Button()
        Me.BtnDataBarang = New Button()
        Me.BtnKategori = New Button()
        Me.BtnSupplier = New Button()
        Me.BtnPelanggan = New Button()
        Me.BtnPenjualan = New Button()
        Me.BtnPembelian = New Button()
        Me.BtnStok = New Button()
        Me.BtnLaporan = New Button()
        Me.BtnUser = New Button()
        Me.BtnLogout = New Button()

        Me.PanelContent = New Panel()
        Me.LblWelcome = New Label()
        Me.LblSubtitle = New Label()
        Me.LblDate = New Label()
        Me.LblTime = New Label()

        Me.PanelCardProduk = New Panel()
        Me.PanelCardStok = New Panel()
        Me.PanelCardPenjualan = New Panel()
        Me.PanelCardPelanggan = New Panel()

        Me.LblProdukIcon = New Label()
        Me.LblProdukTitle = New Label()
        Me.LblProdukValue = New Label()
        Me.LblProdukInfo = New Label()

        Me.LblStokIcon = New Label()
        Me.LblStokTitle = New Label()
        Me.LblStokValue = New Label()
        Me.LblStokInfo = New Label()

        Me.LblPenjualanIcon = New Label()
        Me.LblPenjualanTitle = New Label()
        Me.LblPenjualanValue = New Label()
        Me.LblPenjualanInfo = New Label()

        Me.LblPelangganIcon = New Label()
        Me.LblPelangganTitle = New Label()
        Me.LblPelangganValue = New Label()
        Me.LblPelangganInfo = New Label()

        Me.PanelGrafik = New Panel()
        Me.LblGrafikTitle = New Label()
        Me.LblGrafikText = New Label()
        Me.LblGrafikTanggal = New Label()

        Me.PanelTopProduk = New Panel()
        Me.LblTopProdukTitle = New Label()
        Me.DgvTopProduk = New DataGridView()

        Me.PanelNotifikasi = New Panel()
        Me.LblNotifikasiTitle = New Label()
        Me.LblNotif1 = New Label()
        Me.LblNotif2 = New Label()
        Me.LblNotif3 = New Label()

        Me.PanelInfo = New Panel()
        Me.LblInfoTitle = New Label()
        Me.LblInfoUser = New Label()
        Me.LblInfoLevel = New Label()
        Me.LblInfoVersi = New Label()

        CType(Me.DgvTopProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        'FORM
        Me.AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(1200, 760)
        Me.BackColor = Color.FromArgb(246, 248, 252)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Name = "Form1"
        Me.Text = "Sistem Manajemen Toko Pakaian Pria"

        'MENU STRIP
        Me.MenuStrip1.BackColor = Color.White
        Me.MenuStrip1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Me.MenuStrip1.Location = New Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New Size(1200, 30)

        Me.FileToolStripMenuItem.Text = "File"
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        Me.PengaturanToolStripMenuItem.Text = "Pengaturan"
        Me.BantuanToolStripMenuItem.Text = "Bantuan"

        Me.LoginMenuItem.Text = "Login"
        Me.LogoutMenuItem.Text = "Logout"
        Me.KeluarMenuItem.Text = "Keluar"

        Me.DataBarangMenuItem.Text = "Data Barang"
        Me.KategoriMenuItem.Text = "Kategori"
        Me.SupplierMenuItem.Text = "Supplier"
        Me.PelangganMenuItem.Text = "Pelanggan"
        Me.UserMenuItem.Text = "User / Admin"

        Me.PenjualanMenuItem.Text = "Penjualan"
        Me.PembelianMenuItem.Text = "Pembelian / Stok Masuk"

        Me.LaporanPenjualanMenuItem.Text = "Laporan Penjualan"
        Me.LaporanStokMenuItem.Text = "Laporan Stok Barang"
        Me.LaporanPembelianMenuItem.Text = "Laporan Pembelian"
        Me.CetakStrukMenuItem.Text = "Cetak Struk"

        Me.ProfilTokoMenuItem.Text = "Profil Toko"
        Me.BackupDatabaseMenuItem.Text = "Backup Database"
        Me.RestoreDatabaseMenuItem.Text = "Restore Database"

        Me.TentangAplikasiMenuItem.Text = "Tentang Aplikasi"
        Me.PanduanMenuItem.Text = "Panduan Penggunaan"

        Me.FileToolStripMenuItem.DropDownItems.Add(Me.LoginMenuItem)
        Me.FileToolStripMenuItem.DropDownItems.Add(Me.LogoutMenuItem)
        Me.FileToolStripMenuItem.DropDownItems.Add(New ToolStripSeparator())
        Me.FileToolStripMenuItem.DropDownItems.Add(Me.KeluarMenuItem)

        Me.MasterDataToolStripMenuItem.DropDownItems.Add(Me.DataBarangMenuItem)
        Me.MasterDataToolStripMenuItem.DropDownItems.Add(Me.KategoriMenuItem)
        Me.MasterDataToolStripMenuItem.DropDownItems.Add(Me.SupplierMenuItem)
        Me.MasterDataToolStripMenuItem.DropDownItems.Add(Me.PelangganMenuItem)
        Me.MasterDataToolStripMenuItem.DropDownItems.Add(New ToolStripSeparator())
        Me.MasterDataToolStripMenuItem.DropDownItems.Add(Me.UserMenuItem)

        Me.TransaksiToolStripMenuItem.DropDownItems.Add(Me.PenjualanMenuItem)
        Me.TransaksiToolStripMenuItem.DropDownItems.Add(Me.PembelianMenuItem)

        Me.LaporanToolStripMenuItem.DropDownItems.Add(Me.LaporanPenjualanMenuItem)
        Me.LaporanToolStripMenuItem.DropDownItems.Add(Me.LaporanStokMenuItem)
        Me.LaporanToolStripMenuItem.DropDownItems.Add(Me.LaporanPembelianMenuItem)
        Me.LaporanToolStripMenuItem.DropDownItems.Add(New ToolStripSeparator())
        Me.LaporanToolStripMenuItem.DropDownItems.Add(Me.CetakStrukMenuItem)

        Me.PengaturanToolStripMenuItem.DropDownItems.Add(Me.ProfilTokoMenuItem)
        Me.PengaturanToolStripMenuItem.DropDownItems.Add(Me.BackupDatabaseMenuItem)
        Me.PengaturanToolStripMenuItem.DropDownItems.Add(Me.RestoreDatabaseMenuItem)

        Me.BantuanToolStripMenuItem.DropDownItems.Add(Me.TentangAplikasiMenuItem)
        Me.BantuanToolStripMenuItem.DropDownItems.Add(Me.PanduanMenuItem)

        Me.MenuStrip1.Items.Add(Me.FileToolStripMenuItem)
        Me.MenuStrip1.Items.Add(Me.MasterDataToolStripMenuItem)
        Me.MenuStrip1.Items.Add(Me.TransaksiToolStripMenuItem)
        Me.MenuStrip1.Items.Add(Me.LaporanToolStripMenuItem)
        Me.MenuStrip1.Items.Add(Me.PengaturanToolStripMenuItem)
        Me.MenuStrip1.Items.Add(Me.BantuanToolStripMenuItem)

        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1

        'SIDEBAR
        Me.PanelSidebar.BackColor = Color.FromArgb(3, 28, 48)
        Me.PanelSidebar.Location = New Point(0, 30)
        Me.PanelSidebar.Name = "PanelSidebar"
        Me.PanelSidebar.Size = New Size(232, 730)
        Me.PanelSidebar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Me.Controls.Add(Me.PanelSidebar)

        Me.PanelLogo.BackColor = Color.FromArgb(3, 28, 48)
        Me.PanelLogo.Location = New Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New Size(232, 120)
        Me.PanelSidebar.Controls.Add(Me.PanelLogo)

        Me.LblLogoIcon.Text = "▰"
        Me.LblLogoIcon.ForeColor = Color.FromArgb(218, 173, 36)
        Me.LblLogoIcon.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold)
        Me.LblLogoIcon.TextAlign = ContentAlignment.MiddleCenter
        Me.LblLogoIcon.Location = New Point(0, 8)
        Me.LblLogoIcon.Size = New Size(232, 38)
        Me.PanelLogo.Controls.Add(Me.LblLogoIcon)

        Me.LblBrand.Text = "GENTLEMEN"
        Me.LblBrand.ForeColor = Color.FromArgb(218, 173, 36)
        Me.LblBrand.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        Me.LblBrand.TextAlign = ContentAlignment.MiddleCenter
        Me.LblBrand.Location = New Point(0, 45)
        Me.LblBrand.Size = New Size(232, 34)
        Me.PanelLogo.Controls.Add(Me.LblBrand)

        Me.LblBrandSub.Text = "MEN'S WEAR"
        Me.LblBrandSub.ForeColor = Color.White
        Me.LblBrandSub.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        Me.LblBrandSub.TextAlign = ContentAlignment.MiddleCenter
        Me.LblBrandSub.Location = New Point(0, 76)
        Me.LblBrandSub.Size = New Size(232, 25)
        Me.PanelLogo.Controls.Add(Me.LblBrandSub)

        'BUTTON SIDEBAR
        Me.BtnDashboard.Text = "⌂   Dashboard"
        Me.BtnDashboard.TextAlign = ContentAlignment.MiddleLeft
        Me.BtnDashboard.FlatStyle = FlatStyle.Flat
        Me.BtnDashboard.FlatAppearance.BorderSize = 0
        Me.BtnDashboard.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.BtnDashboard.ForeColor = Color.White
        Me.BtnDashboard.BackColor = Color.FromArgb(0, 102, 204)
        Me.BtnDashboard.Location = New Point(18, 130)
        Me.BtnDashboard.Size = New Size(196, 40)
        Me.BtnDashboard.Padding = New Padding(10, 0, 0, 0)
        Me.PanelSidebar.Controls.Add(Me.BtnDashboard)

        Me.BtnDataBarang.Text = "▦   Data Barang"
        Me.BtnDataBarang.TextAlign = ContentAlignment.MiddleLeft
        Me.BtnDataBarang.FlatStyle = FlatStyle.Flat
        Me.BtnDataBarang.FlatAppearance.BorderSize = 0
        Me.BtnDataBarang.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.BtnDataBarang.ForeColor = Color.White
        Me.BtnDataBarang.BackColor = Color.FromArgb(3, 28, 48)
        Me.BtnDataBarang.Location = New Point(18, 176)
        Me.BtnDataBarang.Size = New Size(196, 40)
        Me.BtnDataBarang.Padding = New Padding(10, 0, 0, 0)
        Me.PanelSidebar.Controls.Add(Me.BtnDataBarang)

        Me.BtnKategori.Text = "▣   Kategori"
        Me.BtnKategori.TextAlign = ContentAlignment.MiddleLeft
        Me.BtnKategori.FlatStyle = FlatStyle.Flat
        Me.BtnKategori.FlatAppearance.BorderSize = 0
        Me.BtnKategori.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.BtnKategori.ForeColor = Color.White
        Me.BtnKategori.BackColor = Color.FromArgb(3, 28, 48)
        Me.BtnKategori.Location = New Point(18, 222)
        Me.BtnKategori.Size = New Size(196, 40)
        Me.BtnKategori.Padding = New Padding(10, 0, 0, 0)
        Me.PanelSidebar.Controls.Add(Me.BtnKategori)

        Me.BtnSupplier.Text = "●   Supplier"
        Me.BtnSupplier.TextAlign = ContentAlignment.MiddleLeft
        Me.BtnSupplier.FlatStyle = FlatStyle.Flat
        Me.BtnSupplier.FlatAppearance.BorderSize = 0
        Me.BtnSupplier.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.BtnSupplier.ForeColor = Color.White
        Me.BtnSupplier.BackColor = Color.FromArgb(3, 28, 48)
        Me.BtnSupplier.Location = New Point(18, 268)
        Me.BtnSupplier.Size = New Size(196, 40)
        Me.BtnSupplier.Padding = New Padding(10, 0, 0, 0)
        Me.PanelSidebar.Controls.Add(Me.BtnSupplier)

        Me.BtnPelanggan.Text = "●   Pelanggan"
        Me.BtnPelanggan.TextAlign = ContentAlignment.MiddleLeft
        Me.BtnPelanggan.FlatStyle = FlatStyle.Flat
        Me.BtnPelanggan.FlatAppearance.BorderSize = 0
        Me.BtnPelanggan.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.BtnPelanggan.ForeColor = Color.White
        Me.BtnPelanggan.BackColor = Color.FromArgb(3, 28, 48)
        Me.BtnPelanggan.Location = New Point(18, 314)
        Me.BtnPelanggan.Size = New Size(196, 40)
        Me.BtnPelanggan.Padding = New Padding(10, 0, 0, 0)
        Me.PanelSidebar.Controls.Add(Me.BtnPelanggan)

        Me.BtnPenjualan.Text = "▤   Penjualan"
        Me.BtnPenjualan.TextAlign = ContentAlignment.MiddleLeft
        Me.BtnPenjualan.FlatStyle = FlatStyle.Flat
        Me.BtnPenjualan.FlatAppearance.BorderSize = 0
        Me.BtnPenjualan.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.BtnPenjualan.ForeColor = Color.White
        Me.BtnPenjualan.BackColor = Color.FromArgb(3, 28, 48)
        Me.BtnPenjualan.Location = New Point(18, 360)
        Me.BtnPenjualan.Size = New Size(196, 40)
        Me.BtnPenjualan.Padding = New Padding(10, 0, 0, 0)
        Me.PanelSidebar.Controls.Add(Me.BtnPenjualan)

        Me.BtnPembelian.Text = "▥   Pembelian"
        Me.BtnPembelian.TextAlign = ContentAlignment.MiddleLeft
        Me.BtnPembelian.FlatStyle = FlatStyle.Flat
        Me.BtnPembelian.FlatAppearance.BorderSize = 0
        Me.BtnPembelian.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.BtnPembelian.ForeColor = Color.White
        Me.BtnPembelian.BackColor = Color.FromArgb(3, 28, 48)
        Me.BtnPembelian.Location = New Point(18, 406)
        Me.BtnPembelian.Size = New Size(196, 40)
        Me.BtnPembelian.Padding = New Padding(10, 0, 0, 0)
        Me.PanelSidebar.Controls.Add(Me.BtnPembelian)

        Me.BtnStok.Text = "▧   Stok"
        Me.BtnStok.TextAlign = ContentAlignment.MiddleLeft
        Me.BtnStok.FlatStyle = FlatStyle.Flat
        Me.BtnStok.FlatAppearance.BorderSize = 0
        Me.BtnStok.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.BtnStok.ForeColor = Color.White
        Me.BtnStok.BackColor = Color.FromArgb(3, 28, 48)
        Me.BtnStok.Location = New Point(18, 452)
        Me.BtnStok.Size = New Size(196, 40)
        Me.BtnStok.Padding = New Padding(10, 0, 0, 0)
        Me.PanelSidebar.Controls.Add(Me.BtnStok)

        Me.BtnLaporan.Text = "□   Laporan"
        Me.BtnLaporan.TextAlign = ContentAlignment.MiddleLeft
        Me.BtnLaporan.FlatStyle = FlatStyle.Flat
        Me.BtnLaporan.FlatAppearance.BorderSize = 0
        Me.BtnLaporan.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.BtnLaporan.ForeColor = Color.White
        Me.BtnLaporan.BackColor = Color.FromArgb(3, 28, 48)
        Me.BtnLaporan.Location = New Point(18, 498)
        Me.BtnLaporan.Size = New Size(196, 40)
        Me.BtnLaporan.Padding = New Padding(10, 0, 0, 0)
        Me.PanelSidebar.Controls.Add(Me.BtnLaporan)

        Me.BtnUser.Text = "◉   User"
        Me.BtnUser.TextAlign = ContentAlignment.MiddleLeft
        Me.BtnUser.FlatStyle = FlatStyle.Flat
        Me.BtnUser.FlatAppearance.BorderSize = 0
        Me.BtnUser.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.BtnUser.ForeColor = Color.White
        Me.BtnUser.BackColor = Color.FromArgb(3, 28, 48)
        Me.BtnUser.Location = New Point(18, 544)
        Me.BtnUser.Size = New Size(196, 40)
        Me.BtnUser.Padding = New Padding(10, 0, 0, 0)
        Me.PanelSidebar.Controls.Add(Me.BtnUser)

        Me.BtnLogout.Text = "↪   Logout"
        Me.BtnLogout.TextAlign = ContentAlignment.MiddleLeft
        Me.BtnLogout.FlatStyle = FlatStyle.Flat
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.BtnLogout.ForeColor = Color.FromArgb(255, 90, 90)
        Me.BtnLogout.BackColor = Color.FromArgb(3, 28, 48)
        Me.BtnLogout.Location = New Point(18, 600)
        Me.BtnLogout.Size = New Size(196, 40)
        Me.BtnLogout.Padding = New Padding(10, 0, 0, 0)
        Me.PanelSidebar.Controls.Add(Me.BtnLogout)

        'CONTENT
        Me.PanelContent.BackColor = Color.FromArgb(246, 248, 252)
        Me.PanelContent.Location = New Point(232, 30)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New Size(968, 730)
        Me.PanelContent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Me.Controls.Add(Me.PanelContent)

        Me.LblWelcome.Text = "Selamat Datang, Admin!"
        Me.LblWelcome.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        Me.LblWelcome.ForeColor = Color.FromArgb(25, 25, 25)
        Me.LblWelcome.Location = New Point(38, 38)
        Me.LblWelcome.Size = New Size(430, 42)
        Me.PanelContent.Controls.Add(Me.LblWelcome)

        Me.LblSubtitle.Text = "Berikut ringkasan informasi toko hari ini."
        Me.LblSubtitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
        Me.LblSubtitle.ForeColor = Color.FromArgb(45, 45, 45)
        Me.LblSubtitle.Location = New Point(40, 78)
        Me.LblSubtitle.Size = New Size(430, 28)
        Me.PanelContent.Controls.Add(Me.LblSubtitle)

        Me.LblDate.Text = "▦ Rabu, 22 Mei 2024"
        Me.LblDate.Font = New Font("Segoe UI", 10.0F)
        Me.LblDate.ForeColor = Color.FromArgb(35, 35, 35)
        Me.LblDate.Location = New Point(650, 52)
        Me.LblDate.Size = New Size(190, 25)
        Me.PanelContent.Controls.Add(Me.LblDate)

        Me.LblTime.Text = "◷ 10:30:45"
        Me.LblTime.Font = New Font("Segoe UI", 10.0F)
        Me.LblTime.ForeColor = Color.FromArgb(35, 35, 35)
        Me.LblTime.Location = New Point(835, 52)
        Me.LblTime.Size = New Size(120, 25)
        Me.PanelContent.Controls.Add(Me.LblTime)

        'CARD PRODUK
        Me.PanelCardProduk.BackColor = Color.White
        Me.PanelCardProduk.BorderStyle = BorderStyle.FixedSingle
        Me.PanelCardProduk.Location = New Point(38, 130)
        Me.PanelCardProduk.Size = New Size(205, 105)
        Me.PanelContent.Controls.Add(Me.PanelCardProduk)

        Me.LblProdukIcon.Text = "■"
        Me.LblProdukIcon.BackColor = Color.FromArgb(30, 105, 255)
        Me.LblProdukIcon.ForeColor = Color.White
        Me.LblProdukIcon.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        Me.LblProdukIcon.TextAlign = ContentAlignment.MiddleCenter
        Me.LblProdukIcon.Location = New Point(16, 28)
        Me.LblProdukIcon.Size = New Size(48, 48)
        Me.PanelCardProduk.Controls.Add(Me.LblProdukIcon)

        Me.LblProdukTitle.Text = "TOTAL PRODUK"
        Me.LblProdukTitle.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        Me.LblProdukTitle.ForeColor = Color.FromArgb(40, 50, 80)
        Me.LblProdukTitle.Location = New Point(78, 18)
        Me.LblProdukTitle.Size = New Size(125, 24)
        Me.PanelCardProduk.Controls.Add(Me.LblProdukTitle)

        Me.LblProdukValue.Text = "156"
        Me.LblProdukValue.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        Me.LblProdukValue.ForeColor = Color.Black
        Me.LblProdukValue.Location = New Point(78, 42)
        Me.LblProdukValue.Size = New Size(125, 32)
        Me.PanelCardProduk.Controls.Add(Me.LblProdukValue)

        Me.LblProdukInfo.Text = "Produk"
        Me.LblProdukInfo.Font = New Font("Segoe UI", 9.0F)
        Me.LblProdukInfo.ForeColor = Color.FromArgb(60, 60, 60)
        Me.LblProdukInfo.Location = New Point(78, 74)
        Me.LblProdukInfo.Size = New Size(125, 22)
        Me.PanelCardProduk.Controls.Add(Me.LblProdukInfo)

        'CARD STOK
        Me.PanelCardStok.BackColor = Color.White
        Me.PanelCardStok.BorderStyle = BorderStyle.FixedSingle
        Me.PanelCardStok.Location = New Point(270, 130)
        Me.PanelCardStok.Size = New Size(205, 105)
        Me.PanelContent.Controls.Add(Me.PanelCardStok)

        Me.LblStokIcon.Text = "♦"
        Me.LblStokIcon.BackColor = Color.FromArgb(255, 181, 0)
        Me.LblStokIcon.ForeColor = Color.White
        Me.LblStokIcon.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        Me.LblStokIcon.TextAlign = ContentAlignment.MiddleCenter
        Me.LblStokIcon.Location = New Point(16, 28)
        Me.LblStokIcon.Size = New Size(48, 48)
        Me.PanelCardStok.Controls.Add(Me.LblStokIcon)

        Me.LblStokTitle.Text = "STOK MENIPIS"
        Me.LblStokTitle.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        Me.LblStokTitle.ForeColor = Color.FromArgb(40, 50, 80)
        Me.LblStokTitle.Location = New Point(78, 18)
        Me.LblStokTitle.Size = New Size(125, 24)
        Me.PanelCardStok.Controls.Add(Me.LblStokTitle)

        Me.LblStokValue.Text = "18"
        Me.LblStokValue.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        Me.LblStokValue.ForeColor = Color.Black
        Me.LblStokValue.Location = New Point(78, 42)
        Me.LblStokValue.Size = New Size(125, 32)
        Me.PanelCardStok.Controls.Add(Me.LblStokValue)

        Me.LblStokInfo.Text = "Produk"
        Me.LblStokInfo.Font = New Font("Segoe UI", 9.0F)
        Me.LblStokInfo.ForeColor = Color.FromArgb(60, 60, 60)
        Me.LblStokInfo.Location = New Point(78, 74)
        Me.LblStokInfo.Size = New Size(125, 22)
        Me.PanelCardStok.Controls.Add(Me.LblStokInfo)

        'CARD PENJUALAN
        Me.PanelCardPenjualan.BackColor = Color.White
        Me.PanelCardPenjualan.BorderStyle = BorderStyle.FixedSingle
        Me.PanelCardPenjualan.Location = New Point(502, 130)
        Me.PanelCardPenjualan.Size = New Size(205, 105)
        Me.PanelContent.Controls.Add(Me.PanelCardPenjualan)

        Me.LblPenjualanIcon.Text = "$"
        Me.LblPenjualanIcon.BackColor = Color.FromArgb(35, 166, 75)
        Me.LblPenjualanIcon.ForeColor = Color.White
        Me.LblPenjualanIcon.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        Me.LblPenjualanIcon.TextAlign = ContentAlignment.MiddleCenter
        Me.LblPenjualanIcon.Location = New Point(16, 28)
        Me.LblPenjualanIcon.Size = New Size(48, 48)
        Me.PanelCardPenjualan.Controls.Add(Me.LblPenjualanIcon)

        Me.LblPenjualanTitle.Text = "PENJUALAN HARI INI"
        Me.LblPenjualanTitle.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        Me.LblPenjualanTitle.ForeColor = Color.FromArgb(40, 50, 80)
        Me.LblPenjualanTitle.Location = New Point(78, 18)
        Me.LblPenjualanTitle.Size = New Size(125, 24)
        Me.PanelCardPenjualan.Controls.Add(Me.LblPenjualanTitle)

        Me.LblPenjualanValue.Text = "Rp 5.250.000"
        Me.LblPenjualanValue.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Me.LblPenjualanValue.ForeColor = Color.Black
        Me.LblPenjualanValue.Location = New Point(78, 44)
        Me.LblPenjualanValue.Size = New Size(125, 30)
        Me.PanelCardPenjualan.Controls.Add(Me.LblPenjualanValue)

        Me.LblPenjualanInfo.Text = "Total Penjualan"
        Me.LblPenjualanInfo.Font = New Font("Segoe UI", 9.0F)
        Me.LblPenjualanInfo.ForeColor = Color.FromArgb(60, 60, 60)
        Me.LblPenjualanInfo.Location = New Point(78, 74)
        Me.LblPenjualanInfo.Size = New Size(125, 22)
        Me.PanelCardPenjualan.Controls.Add(Me.LblPenjualanInfo)

        'CARD PELANGGAN
        Me.PanelCardPelanggan.BackColor = Color.White
        Me.PanelCardPelanggan.BorderStyle = BorderStyle.FixedSingle
        Me.PanelCardPelanggan.Location = New Point(734, 130)
        Me.PanelCardPelanggan.Size = New Size(205, 105)
        Me.PanelContent.Controls.Add(Me.PanelCardPelanggan)

        Me.LblPelangganIcon.Text = "●"
        Me.LblPelangganIcon.BackColor = Color.FromArgb(145, 85, 230)
        Me.LblPelangganIcon.ForeColor = Color.White
        Me.LblPelangganIcon.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        Me.LblPelangganIcon.TextAlign = ContentAlignment.MiddleCenter
        Me.LblPelangganIcon.Location = New Point(16, 28)
        Me.LblPelangganIcon.Size = New Size(48, 48)
        Me.PanelCardPelanggan.Controls.Add(Me.LblPelangganIcon)

        Me.LblPelangganTitle.Text = "TOTAL PELANGGAN"
        Me.LblPelangganTitle.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
        Me.LblPelangganTitle.ForeColor = Color.FromArgb(40, 50, 80)
        Me.LblPelangganTitle.Location = New Point(78, 18)
        Me.LblPelangganTitle.Size = New Size(125, 24)
        Me.PanelCardPelanggan.Controls.Add(Me.LblPelangganTitle)

        Me.LblPelangganValue.Text = "125"
        Me.LblPelangganValue.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        Me.LblPelangganValue.ForeColor = Color.Black
        Me.LblPelangganValue.Location = New Point(78, 42)
        Me.LblPelangganValue.Size = New Size(125, 32)
        Me.PanelCardPelanggan.Controls.Add(Me.LblPelangganValue)

        Me.LblPelangganInfo.Text = "Pelanggan"
        Me.LblPelangganInfo.Font = New Font("Segoe UI", 9.0F)
        Me.LblPelangganInfo.ForeColor = Color.FromArgb(60, 60, 60)
        Me.LblPelangganInfo.Location = New Point(78, 74)
        Me.LblPelangganInfo.Size = New Size(125, 22)
        Me.PanelCardPelanggan.Controls.Add(Me.LblPelangganInfo)

        'PANEL GRAFIK
        Me.PanelGrafik.BackColor = Color.White
        Me.PanelGrafik.BorderStyle = BorderStyle.FixedSingle
        Me.PanelGrafik.Location = New Point(38, 260)
        Me.PanelGrafik.Name = "PanelGrafik"
        Me.PanelGrafik.Size = New Size(455, 245)
        Me.PanelContent.Controls.Add(Me.PanelGrafik)

        Me.LblGrafikTitle.Text = "Grafik Penjualan 7 Hari Terakhir"
        Me.LblGrafikTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.LblGrafikTitle.ForeColor = Color.Black
        Me.LblGrafikTitle.Location = New Point(18, 18)
        Me.LblGrafikTitle.Size = New Size(300, 25)
        Me.PanelGrafik.Controls.Add(Me.LblGrafikTitle)

        Me.LblGrafikText.Text = "8.000.000 |                         *" & vbCrLf &
                                "6.000.000 |                 *      /" & vbCrLf &
                                "4.000.000 |      *----*    / \   *" & vbCrLf &
                                "2.000.000 | *---/      \--*" & vbCrLf &
                                "        0 +------------------------"
        Me.LblGrafikText.Font = New Font("Consolas", 10.0F, FontStyle.Bold)
        Me.LblGrafikText.ForeColor = Color.FromArgb(0, 102, 255)
        Me.LblGrafikText.Location = New Point(25, 60)
        Me.LblGrafikText.Size = New Size(390, 120)
        Me.PanelGrafik.Controls.Add(Me.LblGrafikText)

        Me.LblGrafikTanggal.Text = "16/05      17/05      18/05      19/05      20/05      21/05      22/05"
        Me.LblGrafikTanggal.Font = New Font("Segoe UI", 8.0F)
        Me.LblGrafikTanggal.ForeColor = Color.FromArgb(70, 70, 70)
        Me.LblGrafikTanggal.Location = New Point(35, 188)
        Me.LblGrafikTanggal.Size = New Size(400, 25)
        Me.PanelGrafik.Controls.Add(Me.LblGrafikTanggal)

        'PANEL TOP PRODUK
        Me.PanelTopProduk.BackColor = Color.White
        Me.PanelTopProduk.BorderStyle = BorderStyle.FixedSingle
        Me.PanelTopProduk.Location = New Point(515, 260)
        Me.PanelTopProduk.Name = "PanelTopProduk"
        Me.PanelTopProduk.Size = New Size(420, 245)
        Me.PanelContent.Controls.Add(Me.PanelTopProduk)

        Me.LblTopProdukTitle.Text = "Top 5 Produk Terlaris"
        Me.LblTopProdukTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.LblTopProdukTitle.Location = New Point(18, 18)
        Me.LblTopProdukTitle.Size = New Size(250, 25)
        Me.PanelTopProduk.Controls.Add(Me.LblTopProdukTitle)

        Me.DgvTopProduk.Location = New Point(18, 58)
        Me.DgvTopProduk.Name = "DgvTopProduk"
        Me.DgvTopProduk.Size = New Size(380, 165)
        Me.DgvTopProduk.BackgroundColor = Color.White
        Me.DgvTopProduk.BorderStyle = BorderStyle.None
        Me.DgvTopProduk.RowHeadersVisible = False
        Me.DgvTopProduk.AllowUserToAddRows = False
        Me.DgvTopProduk.AllowUserToDeleteRows = False
        Me.DgvTopProduk.ReadOnly = True
        Me.DgvTopProduk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvTopProduk.EnableHeadersVisualStyles = False
        Me.DgvTopProduk.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245)
        Me.DgvTopProduk.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Me.DgvTopProduk.DefaultCellStyle.Font = New Font("Segoe UI", 9.0F)

        Me.DgvTopProduk.Columns.Add("No", "No")
        Me.DgvTopProduk.Columns.Add("NamaBarang", "Nama Barang")
        Me.DgvTopProduk.Columns.Add("Terjual", "Terjual")

        Me.DgvTopProduk.Columns(0).FillWeight = 35
        Me.DgvTopProduk.Columns(1).FillWeight = 140
        Me.DgvTopProduk.Columns(2).FillWeight = 55

        Me.DgvTopProduk.Rows.Add("1", "Kemeja Formal", "45")
        Me.DgvTopProduk.Rows.Add("2", "Kaos Polos Pria", "40")
        Me.DgvTopProduk.Rows.Add("3", "Celana Chino", "32")
        Me.DgvTopProduk.Rows.Add("4", "Polo Shirt", "28")
        Me.DgvTopProduk.Rows.Add("5", "Jaket Bomber", "22")

        Me.PanelTopProduk.Controls.Add(Me.DgvTopProduk)

        'PANEL NOTIFIKASI
        Me.PanelNotifikasi.BackColor = Color.White
        Me.PanelNotifikasi.BorderStyle = BorderStyle.FixedSingle
        Me.PanelNotifikasi.Location = New Point(38, 525)
        Me.PanelNotifikasi.Name = "PanelNotifikasi"
        Me.PanelNotifikasi.Size = New Size(455, 160)
        Me.PanelContent.Controls.Add(Me.PanelNotifikasi)

        Me.LblNotifikasiTitle.Text = "Notifikasi"
        Me.LblNotifikasiTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.LblNotifikasiTitle.Location = New Point(18, 16)
        Me.LblNotifikasiTitle.Size = New Size(200, 25)
        Me.PanelNotifikasi.Controls.Add(Me.LblNotifikasiTitle)

        Me.LblNotif1.Text = "- 18 produk dengan stok menipis"
        Me.LblNotif1.Font = New Font("Segoe UI", 10.0F)
        Me.LblNotif1.ForeColor = Color.Red
        Me.LblNotif1.Location = New Point(22, 55)
        Me.LblNotif1.Size = New Size(390, 25)
        Me.PanelNotifikasi.Controls.Add(Me.LblNotif1)

        Me.LblNotif2.Text = "- 2 pesanan pembelian belum diterima"
        Me.LblNotif2.Font = New Font("Segoe UI", 10.0F)
        Me.LblNotif2.ForeColor = Color.Black
        Me.LblNotif2.Location = New Point(22, 85)
        Me.LblNotif2.Size = New Size(390, 25)
        Me.PanelNotifikasi.Controls.Add(Me.LblNotif2)

        Me.LblNotif3.Text = "- Backup data terakhir: 22/05/2024 08:00"
        Me.LblNotif3.Font = New Font("Segoe UI", 10.0F)
        Me.LblNotif3.ForeColor = Color.Black
        Me.LblNotif3.Location = New Point(22, 115)
        Me.LblNotif3.Size = New Size(410, 25)
        Me.PanelNotifikasi.Controls.Add(Me.LblNotif3)

        'PANEL INFORMASI SISTEM
        Me.PanelInfo.BackColor = Color.White
        Me.PanelInfo.BorderStyle = BorderStyle.FixedSingle
        Me.PanelInfo.Location = New Point(515, 525)
        Me.PanelInfo.Name = "PanelInfo"
        Me.PanelInfo.Size = New Size(420, 160)
        Me.PanelContent.Controls.Add(Me.PanelInfo)

        Me.LblInfoTitle.Text = "Informasi Sistem"
        Me.LblInfoTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Me.LblInfoTitle.ForeColor = Color.FromArgb(20, 50, 110)
        Me.LblInfoTitle.Location = New Point(18, 16)
        Me.LblInfoTitle.Size = New Size(250, 25)
        Me.PanelInfo.Controls.Add(Me.LblInfoTitle)

        Me.LblInfoUser.Text = "User Aktif              :   admin"
        Me.LblInfoUser.Font = New Font("Segoe UI", 10.0F)
        Me.LblInfoUser.Location = New Point(22, 55)
        Me.LblInfoUser.Size = New Size(350, 25)
        Me.PanelInfo.Controls.Add(Me.LblInfoUser)

        Me.LblInfoLevel.Text = "Level                   :   Administrator"
        Me.LblInfoLevel.Font = New Font("Segoe UI", 10.0F)
        Me.LblInfoLevel.Location = New Point(22, 85)
        Me.LblInfoLevel.Size = New Size(350, 25)
        Me.PanelInfo.Controls.Add(Me.LblInfoLevel)

        Me.LblInfoVersi.Text = "Versi Aplikasi          :   1.0.0.0"
        Me.LblInfoVersi.Font = New Font("Segoe UI", 10.0F)
        Me.LblInfoVersi.Location = New Point(22, 115)
        Me.LblInfoVersi.Size = New Size(350, 25)
        Me.PanelInfo.Controls.Add(Me.LblInfoVersi)

        CType(Me.DgvTopProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

End Class