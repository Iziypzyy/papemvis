<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboard
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

    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KategoriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserAdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanStokToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CetakStrukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfilTokoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackupDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestoreDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TentangAplikasiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanduanPenggunaanToolStripMenuItem As ToolStripMenuItem

    Friend WithEvents PanelSidebar As Panel
    Friend WithEvents LabelLogoIcon As Label
    Friend WithEvents LabelBrand As Label
    Friend WithEvents LabelBrandSub As Label

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
    Friend WithEvents LabelWelcome As Label
    Friend WithEvents LabelSubtitle As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents LabelTime As Label

    Friend WithEvents PanelProduk As Panel
    Friend WithEvents PanelStok As Panel
    Friend WithEvents PanelPenjualan As Panel
    Friend WithEvents PanelPelanggan As Panel

    Friend WithEvents LabelProdukIcon As Label
    Friend WithEvents LabelProdukTitle As Label
    Friend WithEvents LabelProdukValue As Label
    Friend WithEvents LabelProdukInfo As Label

    Friend WithEvents LabelStokIcon As Label
    Friend WithEvents LabelStokTitle As Label
    Friend WithEvents LabelStokValue As Label
    Friend WithEvents LabelStokInfo As Label

    Friend WithEvents LabelPenjualanIcon As Label
    Friend WithEvents LabelPenjualanTitle As Label
    Friend WithEvents LabelPenjualanValue As Label
    Friend WithEvents LabelPenjualanInfo As Label

    Friend WithEvents LabelPelangganIcon As Label
    Friend WithEvents LabelPelangganTitle As Label
    Friend WithEvents LabelPelangganValue As Label
    Friend WithEvents LabelPelangganInfo As Label

    Friend WithEvents PanelGrafik As Panel
    Friend WithEvents LabelGrafikTitle As Label
    Friend WithEvents LabelGrafik1 As Label
    Friend WithEvents LabelGrafik2 As Label
    Friend WithEvents LabelGrafik3 As Label
    Friend WithEvents LabelGrafik4 As Label
    Friend WithEvents LabelGrafik5 As Label
    Friend WithEvents LabelGrafikTanggal As Label

    Friend WithEvents PanelTopProduk As Panel
    Friend WithEvents LabelTopProdukTitle As Label
    Friend WithEvents TableTopProduk As TableLayoutPanel

    Friend WithEvents PanelNotifikasi As Panel
    Friend WithEvents LabelNotifikasiTitle As Label
    Friend WithEvents LabelNotif1 As Label
    Friend WithEvents LabelNotif2 As Label
    Friend WithEvents LabelNotif3 As Label

    Friend WithEvents PanelInfo As Panel
    Friend WithEvents LabelInfoTitle As Label
    Friend WithEvents LabelInfoUser As Label
    Friend WithEvents LabelInfoLevel As Label
    Friend WithEvents LabelInfoVersi As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        LoginToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        MasterDataToolStripMenuItem = New ToolStripMenuItem()
        DataBarangToolStripMenuItem = New ToolStripMenuItem()
        KategoriToolStripMenuItem = New ToolStripMenuItem()
        SupplierToolStripMenuItem = New ToolStripMenuItem()
        PelangganToolStripMenuItem = New ToolStripMenuItem()
        UserAdminToolStripMenuItem = New ToolStripMenuItem()
        TransaksiToolStripMenuItem = New ToolStripMenuItem()
        PenjualanToolStripMenuItem = New ToolStripMenuItem()
        PembelianToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        LaporanPenjualanToolStripMenuItem = New ToolStripMenuItem()
        LaporanStokToolStripMenuItem = New ToolStripMenuItem()
        LaporanPembelianToolStripMenuItem = New ToolStripMenuItem()
        CetakStrukToolStripMenuItem = New ToolStripMenuItem()
        PengaturanToolStripMenuItem = New ToolStripMenuItem()
        ProfilTokoToolStripMenuItem = New ToolStripMenuItem()
        BackupDatabaseToolStripMenuItem = New ToolStripMenuItem()
        RestoreDatabaseToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem = New ToolStripMenuItem()
        TentangAplikasiToolStripMenuItem = New ToolStripMenuItem()
        PanduanPenggunaanToolStripMenuItem = New ToolStripMenuItem()
        PanelSidebar = New Panel()
        LabelLogoIcon = New Label()
        LabelBrand = New Label()
        LabelBrandSub = New Label()
        BtnDashboard = New Button()
        BtnDataBarang = New Button()
        BtnKategori = New Button()
        BtnSupplier = New Button()
        BtnPelanggan = New Button()
        BtnPenjualan = New Button()
        BtnPembelian = New Button()
        BtnStok = New Button()
        BtnLaporan = New Button()
        BtnUser = New Button()
        BtnLogout = New Button()
        PanelContent = New Panel()
        LabelWelcome = New Label()
        LabelSubtitle = New Label()
        LabelDate = New Label()
        LabelTime = New Label()
        PanelProduk = New Panel()
        LabelProdukIcon = New Label()
        LabelProdukTitle = New Label()
        LabelProdukValue = New Label()
        LabelProdukInfo = New Label()
        PanelStok = New Panel()
        LabelStokIcon = New Label()
        LabelStokTitle = New Label()
        LabelStokValue = New Label()
        LabelStokInfo = New Label()
        PanelPenjualan = New Panel()
        LabelPenjualanIcon = New Label()
        LabelPenjualanTitle = New Label()
        LabelPenjualanValue = New Label()
        LabelPenjualanInfo = New Label()
        PanelPelanggan = New Panel()
        LabelPelangganIcon = New Label()
        LabelPelangganTitle = New Label()
        LabelPelangganValue = New Label()
        LabelPelangganInfo = New Label()
        PanelGrafik = New Panel()
        LabelGrafikTitle = New Label()
        LabelGrafik1 = New Label()
        LabelGrafik2 = New Label()
        LabelGrafik3 = New Label()
        LabelGrafik4 = New Label()
        LabelGrafik5 = New Label()
        LabelGrafikTanggal = New Label()
        PanelTopProduk = New Panel()
        LabelTopProdukTitle = New Label()
        TableTopProduk = New TableLayoutPanel()
        PanelNotifikasi = New Panel()
        LabelNotifikasiTitle = New Label()
        LabelNotif1 = New Label()
        LabelNotif2 = New Label()
        LabelNotif3 = New Label()
        PanelInfo = New Panel()
        LabelInfoTitle = New Label()
        LabelInfoUser = New Label()
        LabelInfoLevel = New Label()
        LabelInfoVersi = New Label()
        MenuStrip1.SuspendLayout()
        PanelSidebar.SuspendLayout()
        PanelContent.SuspendLayout()
        PanelProduk.SuspendLayout()
        PanelStok.SuspendLayout()
        PanelPenjualan.SuspendLayout()
        PanelPelanggan.SuspendLayout()
        PanelGrafik.SuspendLayout()
        PanelTopProduk.SuspendLayout()
        PanelNotifikasi.SuspendLayout()
        PanelInfo.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.White
        MenuStrip1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, MasterDataToolStripMenuItem, TransaksiToolStripMenuItem, LaporanToolStripMenuItem, PengaturanToolStripMenuItem, BantuanToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(960, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LoginToolStripMenuItem, LogoutToolStripMenuItem, KeluarToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(47, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' LoginToolStripMenuItem
        ' 
        LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        LoginToolStripMenuItem.Size = New Size(142, 26)
        LoginToolStripMenuItem.Text = "Login"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(142, 26)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(142, 26)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' MasterDataToolStripMenuItem
        ' 
        MasterDataToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DataBarangToolStripMenuItem, KategoriToolStripMenuItem, SupplierToolStripMenuItem, PelangganToolStripMenuItem, UserAdminToolStripMenuItem})
        MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        MasterDataToolStripMenuItem.Size = New Size(109, 24)
        MasterDataToolStripMenuItem.Text = "Master Data"
        ' 
        ' DataBarangToolStripMenuItem
        ' 
        DataBarangToolStripMenuItem.Name = "DataBarangToolStripMenuItem"
        DataBarangToolStripMenuItem.Size = New Size(186, 26)
        DataBarangToolStripMenuItem.Text = "Data Barang"
        ' 
        ' KategoriToolStripMenuItem
        ' 
        KategoriToolStripMenuItem.Name = "KategoriToolStripMenuItem"
        KategoriToolStripMenuItem.Size = New Size(186, 26)
        KategoriToolStripMenuItem.Text = "Kategori"
        ' 
        ' SupplierToolStripMenuItem
        ' 
        SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        SupplierToolStripMenuItem.Size = New Size(186, 26)
        SupplierToolStripMenuItem.Text = "Supplier"
        ' 
        ' PelangganToolStripMenuItem
        ' 
        PelangganToolStripMenuItem.Name = "PelangganToolStripMenuItem"
        PelangganToolStripMenuItem.Size = New Size(186, 26)
        PelangganToolStripMenuItem.Text = "Pelanggan"
        ' 
        ' UserAdminToolStripMenuItem
        ' 
        UserAdminToolStripMenuItem.Name = "UserAdminToolStripMenuItem"
        UserAdminToolStripMenuItem.Size = New Size(186, 26)
        UserAdminToolStripMenuItem.Text = "User / Admin"
        ' 
        ' TransaksiToolStripMenuItem
        ' 
        TransaksiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PenjualanToolStripMenuItem, PembelianToolStripMenuItem})
        TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        TransaksiToolStripMenuItem.Size = New Size(88, 24)
        TransaksiToolStripMenuItem.Text = "Transaksi"
        ' 
        ' PenjualanToolStripMenuItem
        ' 
        PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        PenjualanToolStripMenuItem.Size = New Size(261, 26)
        PenjualanToolStripMenuItem.Text = "Penjualan"
        ' 
        ' PembelianToolStripMenuItem
        ' 
        PembelianToolStripMenuItem.Name = "PembelianToolStripMenuItem"
        PembelianToolStripMenuItem.Size = New Size(261, 26)
        PembelianToolStripMenuItem.Text = "Pembelian / Stok Masuk"
        ' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LaporanPenjualanToolStripMenuItem, LaporanStokToolStripMenuItem, LaporanPembelianToolStripMenuItem, CetakStrukToolStripMenuItem})
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(80, 24)
        LaporanToolStripMenuItem.Text = "Laporan"
        ' 
        ' LaporanPenjualanToolStripMenuItem
        ' 
        LaporanPenjualanToolStripMenuItem.Name = "LaporanPenjualanToolStripMenuItem"
        LaporanPenjualanToolStripMenuItem.Size = New Size(238, 26)
        LaporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan"
        ' 
        ' LaporanStokToolStripMenuItem
        ' 
        LaporanStokToolStripMenuItem.Name = "LaporanStokToolStripMenuItem"
        LaporanStokToolStripMenuItem.Size = New Size(238, 26)
        LaporanStokToolStripMenuItem.Text = "Laporan Stok Barang"
        ' 
        ' LaporanPembelianToolStripMenuItem
        ' 
        LaporanPembelianToolStripMenuItem.Name = "LaporanPembelianToolStripMenuItem"
        LaporanPembelianToolStripMenuItem.Size = New Size(238, 26)
        LaporanPembelianToolStripMenuItem.Text = "Laporan Pembelian"
        ' 
        ' CetakStrukToolStripMenuItem
        ' 
        CetakStrukToolStripMenuItem.Name = "CetakStrukToolStripMenuItem"
        CetakStrukToolStripMenuItem.Size = New Size(238, 26)
        CetakStrukToolStripMenuItem.Text = "Cetak Struk"
        ' 
        ' PengaturanToolStripMenuItem
        ' 
        PengaturanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProfilTokoToolStripMenuItem, BackupDatabaseToolStripMenuItem, RestoreDatabaseToolStripMenuItem})
        PengaturanToolStripMenuItem.Name = "PengaturanToolStripMenuItem"
        PengaturanToolStripMenuItem.Size = New Size(104, 24)
        PengaturanToolStripMenuItem.Text = "Pengaturan"
        ' 
        ' ProfilTokoToolStripMenuItem
        ' 
        ProfilTokoToolStripMenuItem.Name = "ProfilTokoToolStripMenuItem"
        ProfilTokoToolStripMenuItem.Size = New Size(215, 26)
        ProfilTokoToolStripMenuItem.Text = "Profil Toko"
        ' 
        ' BackupDatabaseToolStripMenuItem
        ' 
        BackupDatabaseToolStripMenuItem.Name = "BackupDatabaseToolStripMenuItem"
        BackupDatabaseToolStripMenuItem.Size = New Size(215, 26)
        BackupDatabaseToolStripMenuItem.Text = "Backup Database"
        ' 
        ' RestoreDatabaseToolStripMenuItem
        ' 
        RestoreDatabaseToolStripMenuItem.Name = "RestoreDatabaseToolStripMenuItem"
        RestoreDatabaseToolStripMenuItem.Size = New Size(215, 26)
        RestoreDatabaseToolStripMenuItem.Text = "Restore Database"
        ' 
        ' BantuanToolStripMenuItem
        ' 
        BantuanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TentangAplikasiToolStripMenuItem, PanduanPenggunaanToolStripMenuItem})
        BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        BantuanToolStripMenuItem.Size = New Size(82, 24)
        BantuanToolStripMenuItem.Text = "Bantuan"
        ' 
        ' TentangAplikasiToolStripMenuItem
        ' 
        TentangAplikasiToolStripMenuItem.Name = "TentangAplikasiToolStripMenuItem"
        TentangAplikasiToolStripMenuItem.Size = New Size(244, 26)
        TentangAplikasiToolStripMenuItem.Text = "Tentang Aplikasi"
        ' 
        ' PanduanPenggunaanToolStripMenuItem
        ' 
        PanduanPenggunaanToolStripMenuItem.Name = "PanduanPenggunaanToolStripMenuItem"
        PanduanPenggunaanToolStripMenuItem.Size = New Size(244, 26)
        PanduanPenggunaanToolStripMenuItem.Text = "Panduan Penggunaan"
        ' 
        ' PanelSidebar
        ' 
        PanelSidebar.BackColor = Color.FromArgb(CByte(3), CByte(28), CByte(48))
        PanelSidebar.Controls.Add(LabelLogoIcon)
        PanelSidebar.Controls.Add(LabelBrand)
        PanelSidebar.Controls.Add(LabelBrandSub)
        PanelSidebar.Controls.Add(BtnDashboard)
        PanelSidebar.Controls.Add(BtnDataBarang)
        PanelSidebar.Controls.Add(BtnKategori)
        PanelSidebar.Controls.Add(BtnSupplier)
        PanelSidebar.Controls.Add(BtnPelanggan)
        PanelSidebar.Controls.Add(BtnPenjualan)
        PanelSidebar.Controls.Add(BtnPembelian)
        PanelSidebar.Controls.Add(BtnStok)
        PanelSidebar.Controls.Add(BtnLaporan)
        PanelSidebar.Controls.Add(BtnUser)
        PanelSidebar.Controls.Add(BtnLogout)
        PanelSidebar.Location = New Point(0, 22)
        PanelSidebar.Margin = New Padding(2, 2, 2, 2)
        PanelSidebar.Name = "PanelSidebar"
        PanelSidebar.Size = New Size(186, 586)
        PanelSidebar.TabIndex = 1
        ' 
        ' LabelLogoIcon
        ' 
        LabelLogoIcon.Font = New Font("Segoe UI", 28F, FontStyle.Bold)
        LabelLogoIcon.ForeColor = Color.FromArgb(CByte(218), CByte(173), CByte(36))
        LabelLogoIcon.Location = New Point(0, 16)
        LabelLogoIcon.Margin = New Padding(2, 0, 2, 0)
        LabelLogoIcon.Name = "LabelLogoIcon"
        LabelLogoIcon.Size = New Size(186, 32)
        LabelLogoIcon.TabIndex = 0
        LabelLogoIcon.Text = "▰"
        LabelLogoIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelBrand
        ' 
        LabelBrand.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        LabelBrand.ForeColor = Color.FromArgb(CByte(218), CByte(173), CByte(36))
        LabelBrand.Location = New Point(0, 48)
        LabelBrand.Margin = New Padding(2, 0, 2, 0)
        LabelBrand.Name = "LabelBrand"
        LabelBrand.Size = New Size(186, 28)
        LabelBrand.TabIndex = 1
        LabelBrand.Text = "GENTLEMEN"
        LabelBrand.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelBrandSub
        ' 
        LabelBrandSub.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        LabelBrandSub.ForeColor = Color.White
        LabelBrandSub.Location = New Point(0, 74)
        LabelBrandSub.Margin = New Padding(2, 0, 2, 0)
        LabelBrandSub.Name = "LabelBrandSub"
        LabelBrandSub.Size = New Size(186, 21)
        LabelBrandSub.TabIndex = 2
        LabelBrandSub.Text = "MEN'S WEAR"
        LabelBrandSub.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnDashboard
        ' 
        BtnDashboard.BackColor = Color.FromArgb(CByte(0), CByte(102), CByte(204))
        BtnDashboard.FlatAppearance.BorderSize = 0
        BtnDashboard.FlatStyle = FlatStyle.Flat
        BtnDashboard.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        BtnDashboard.ForeColor = Color.White
        BtnDashboard.Location = New Point(14, 112)
        BtnDashboard.Margin = New Padding(2, 2, 2, 2)
        BtnDashboard.Name = "BtnDashboard"
        BtnDashboard.Padding = New Padding(8, 0, 0, 0)
        BtnDashboard.Size = New Size(157, 32)
        BtnDashboard.TabIndex = 3
        BtnDashboard.Text = "⌂   Dashboard"
        BtnDashboard.TextAlign = ContentAlignment.MiddleLeft
        BtnDashboard.UseVisualStyleBackColor = False
        ' 
        ' BtnDataBarang
        ' 
        BtnDataBarang.BackColor = Color.FromArgb(CByte(3), CByte(28), CByte(48))
        BtnDataBarang.FlatAppearance.BorderSize = 0
        BtnDataBarang.FlatStyle = FlatStyle.Flat
        BtnDataBarang.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        BtnDataBarang.ForeColor = Color.White
        BtnDataBarang.Location = New Point(14, 149)
        BtnDataBarang.Margin = New Padding(2, 2, 2, 2)
        BtnDataBarang.Name = "BtnDataBarang"
        BtnDataBarang.Padding = New Padding(8, 0, 0, 0)
        BtnDataBarang.Size = New Size(157, 32)
        BtnDataBarang.TabIndex = 4
        BtnDataBarang.Text = "▦   Data Barang"
        BtnDataBarang.TextAlign = ContentAlignment.MiddleLeft
        BtnDataBarang.UseVisualStyleBackColor = False
        ' 
        ' BtnKategori
        ' 
        BtnKategori.BackColor = Color.FromArgb(CByte(3), CByte(28), CByte(48))
        BtnKategori.FlatAppearance.BorderSize = 0
        BtnKategori.FlatStyle = FlatStyle.Flat
        BtnKategori.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        BtnKategori.ForeColor = Color.White
        BtnKategori.Location = New Point(14, 186)
        BtnKategori.Margin = New Padding(2, 2, 2, 2)
        BtnKategori.Name = "BtnKategori"
        BtnKategori.Padding = New Padding(8, 0, 0, 0)
        BtnKategori.Size = New Size(157, 32)
        BtnKategori.TabIndex = 5
        BtnKategori.Text = "▣   Kategori"
        BtnKategori.TextAlign = ContentAlignment.MiddleLeft
        BtnKategori.UseVisualStyleBackColor = False
        ' 
        ' BtnSupplier
        ' 
        BtnSupplier.BackColor = Color.FromArgb(CByte(3), CByte(28), CByte(48))
        BtnSupplier.FlatAppearance.BorderSize = 0
        BtnSupplier.FlatStyle = FlatStyle.Flat
        BtnSupplier.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        BtnSupplier.ForeColor = Color.White
        BtnSupplier.Location = New Point(14, 222)
        BtnSupplier.Margin = New Padding(2, 2, 2, 2)
        BtnSupplier.Name = "BtnSupplier"
        BtnSupplier.Padding = New Padding(8, 0, 0, 0)
        BtnSupplier.Size = New Size(157, 32)
        BtnSupplier.TabIndex = 6
        BtnSupplier.Text = "●   Supplier"
        BtnSupplier.TextAlign = ContentAlignment.MiddleLeft
        BtnSupplier.UseVisualStyleBackColor = False
        ' 
        ' BtnPelanggan
        ' 
        BtnPelanggan.BackColor = Color.FromArgb(CByte(3), CByte(28), CByte(48))
        BtnPelanggan.FlatAppearance.BorderSize = 0
        BtnPelanggan.FlatStyle = FlatStyle.Flat
        BtnPelanggan.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        BtnPelanggan.ForeColor = Color.White
        BtnPelanggan.Location = New Point(14, 259)
        BtnPelanggan.Margin = New Padding(2, 2, 2, 2)
        BtnPelanggan.Name = "BtnPelanggan"
        BtnPelanggan.Padding = New Padding(8, 0, 0, 0)
        BtnPelanggan.Size = New Size(157, 32)
        BtnPelanggan.TabIndex = 7
        BtnPelanggan.Text = "●   Pelanggan"
        BtnPelanggan.TextAlign = ContentAlignment.MiddleLeft
        BtnPelanggan.UseVisualStyleBackColor = False
        ' 
        ' BtnPenjualan
        ' 
        BtnPenjualan.BackColor = Color.FromArgb(CByte(3), CByte(28), CByte(48))
        BtnPenjualan.FlatAppearance.BorderSize = 0
        BtnPenjualan.FlatStyle = FlatStyle.Flat
        BtnPenjualan.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        BtnPenjualan.ForeColor = Color.White
        BtnPenjualan.Location = New Point(14, 296)
        BtnPenjualan.Margin = New Padding(2, 2, 2, 2)
        BtnPenjualan.Name = "BtnPenjualan"
        BtnPenjualan.Padding = New Padding(8, 0, 0, 0)
        BtnPenjualan.Size = New Size(157, 32)
        BtnPenjualan.TabIndex = 8
        BtnPenjualan.Text = "▤   Penjualan"
        BtnPenjualan.TextAlign = ContentAlignment.MiddleLeft
        BtnPenjualan.UseVisualStyleBackColor = False
        ' 
        ' BtnPembelian
        ' 
        BtnPembelian.BackColor = Color.FromArgb(CByte(3), CByte(28), CByte(48))
        BtnPembelian.FlatAppearance.BorderSize = 0
        BtnPembelian.FlatStyle = FlatStyle.Flat
        BtnPembelian.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        BtnPembelian.ForeColor = Color.White
        BtnPembelian.Location = New Point(14, 333)
        BtnPembelian.Margin = New Padding(2, 2, 2, 2)
        BtnPembelian.Name = "BtnPembelian"
        BtnPembelian.Padding = New Padding(8, 0, 0, 0)
        BtnPembelian.Size = New Size(157, 32)
        BtnPembelian.TabIndex = 9
        BtnPembelian.Text = "▥   Pembelian"
        BtnPembelian.TextAlign = ContentAlignment.MiddleLeft
        BtnPembelian.UseVisualStyleBackColor = False
        ' 
        ' BtnStok
        ' 
        BtnStok.BackColor = Color.FromArgb(CByte(3), CByte(28), CByte(48))
        BtnStok.FlatAppearance.BorderSize = 0
        BtnStok.FlatStyle = FlatStyle.Flat
        BtnStok.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        BtnStok.ForeColor = Color.White
        BtnStok.Location = New Point(14, 370)
        BtnStok.Margin = New Padding(2, 2, 2, 2)
        BtnStok.Name = "BtnStok"
        BtnStok.Padding = New Padding(8, 0, 0, 0)
        BtnStok.Size = New Size(157, 32)
        BtnStok.TabIndex = 10
        BtnStok.Text = "▧   Stok"
        BtnStok.TextAlign = ContentAlignment.MiddleLeft
        BtnStok.UseVisualStyleBackColor = False
        ' 
        ' BtnLaporan
        ' 
        BtnLaporan.BackColor = Color.FromArgb(CByte(3), CByte(28), CByte(48))
        BtnLaporan.FlatAppearance.BorderSize = 0
        BtnLaporan.FlatStyle = FlatStyle.Flat
        BtnLaporan.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        BtnLaporan.ForeColor = Color.White
        BtnLaporan.Location = New Point(14, 406)
        BtnLaporan.Margin = New Padding(2, 2, 2, 2)
        BtnLaporan.Name = "BtnLaporan"
        BtnLaporan.Padding = New Padding(8, 0, 0, 0)
        BtnLaporan.Size = New Size(157, 32)
        BtnLaporan.TabIndex = 11
        BtnLaporan.Text = "□   Laporan"
        BtnLaporan.TextAlign = ContentAlignment.MiddleLeft
        BtnLaporan.UseVisualStyleBackColor = False
        ' 
        ' BtnUser
        ' 
        BtnUser.BackColor = Color.FromArgb(CByte(3), CByte(28), CByte(48))
        BtnUser.FlatAppearance.BorderSize = 0
        BtnUser.FlatStyle = FlatStyle.Flat
        BtnUser.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        BtnUser.ForeColor = Color.White
        BtnUser.Location = New Point(14, 443)
        BtnUser.Margin = New Padding(2, 2, 2, 2)
        BtnUser.Name = "BtnUser"
        BtnUser.Padding = New Padding(8, 0, 0, 0)
        BtnUser.Size = New Size(157, 32)
        BtnUser.TabIndex = 12
        BtnUser.Text = "◉   User"
        BtnUser.TextAlign = ContentAlignment.MiddleLeft
        BtnUser.UseVisualStyleBackColor = False
        ' 
        ' BtnLogout
        ' 
        BtnLogout.BackColor = Color.FromArgb(CByte(3), CByte(28), CByte(48))
        BtnLogout.FlatAppearance.BorderSize = 0
        BtnLogout.FlatStyle = FlatStyle.Flat
        BtnLogout.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        BtnLogout.ForeColor = Color.FromArgb(CByte(255), CByte(90), CByte(90))
        BtnLogout.Location = New Point(14, 488)
        BtnLogout.Margin = New Padding(2, 2, 2, 2)
        BtnLogout.Name = "BtnLogout"
        BtnLogout.Padding = New Padding(8, 0, 0, 0)
        BtnLogout.Size = New Size(157, 32)
        BtnLogout.TabIndex = 13
        BtnLogout.Text = "↪   Logout"
        BtnLogout.TextAlign = ContentAlignment.MiddleLeft
        BtnLogout.UseVisualStyleBackColor = False
        ' 
        ' PanelContent
        ' 
        PanelContent.BackColor = Color.FromArgb(CByte(246), CByte(248), CByte(252))
        PanelContent.Controls.Add(LabelWelcome)
        PanelContent.Controls.Add(LabelSubtitle)
        PanelContent.Controls.Add(LabelDate)
        PanelContent.Controls.Add(LabelTime)
        PanelContent.Controls.Add(PanelProduk)
        PanelContent.Controls.Add(PanelStok)
        PanelContent.Controls.Add(PanelPenjualan)
        PanelContent.Controls.Add(PanelPelanggan)
        PanelContent.Controls.Add(PanelGrafik)
        PanelContent.Controls.Add(PanelTopProduk)
        PanelContent.Controls.Add(PanelNotifikasi)
        PanelContent.Controls.Add(PanelInfo)
        PanelContent.Location = New Point(186, 22)
        PanelContent.Margin = New Padding(2, 2, 2, 2)
        PanelContent.Name = "PanelContent"
        PanelContent.Size = New Size(774, 586)
        PanelContent.TabIndex = 2
        ' 
        ' LabelWelcome
        ' 
        LabelWelcome.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        LabelWelcome.ForeColor = Color.FromArgb(CByte(25), CByte(25), CByte(25))
        LabelWelcome.Location = New Point(30, 30)
        LabelWelcome.Margin = New Padding(2, 0, 2, 0)
        LabelWelcome.Name = "LabelWelcome"
        LabelWelcome.Size = New Size(344, 34)
        LabelWelcome.TabIndex = 0
        LabelWelcome.Text = "Selamat Datang, Admin!"
        ' 
        ' LabelSubtitle
        ' 
        LabelSubtitle.Font = New Font("Segoe UI", 10F)
        LabelSubtitle.ForeColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        LabelSubtitle.Location = New Point(32, 62)
        LabelSubtitle.Margin = New Padding(2, 0, 2, 0)
        LabelSubtitle.Name = "LabelSubtitle"
        LabelSubtitle.Size = New Size(344, 22)
        LabelSubtitle.TabIndex = 1
        LabelSubtitle.Text = "Berikut ringkasan informasi toko hari ini."
        ' 
        ' LabelDate
        ' 
        LabelDate.Font = New Font("Segoe UI", 10F)
        LabelDate.ForeColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        LabelDate.Location = New Point(520, 42)
        LabelDate.Margin = New Padding(2, 0, 2, 0)
        LabelDate.Name = "LabelDate"
        LabelDate.Size = New Size(152, 20)
        LabelDate.TabIndex = 2
        LabelDate.Text = "Rabu, 22 Mei 2024"
        ' 
        ' LabelTime
        ' 
        LabelTime.Font = New Font("Segoe UI", 10F)
        LabelTime.ForeColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        LabelTime.Location = New Point(668, 42)
        LabelTime.Margin = New Padding(2, 0, 2, 0)
        LabelTime.Name = "LabelTime"
        LabelTime.Size = New Size(96, 20)
        LabelTime.TabIndex = 3
        LabelTime.Text = "10:30:45"
        ' 
        ' PanelProduk
        ' 
        PanelProduk.BackColor = Color.White
        PanelProduk.BorderStyle = BorderStyle.FixedSingle
        PanelProduk.Controls.Add(LabelProdukIcon)
        PanelProduk.Controls.Add(LabelProdukTitle)
        PanelProduk.Controls.Add(LabelProdukValue)
        PanelProduk.Controls.Add(LabelProdukInfo)
        PanelProduk.Location = New Point(30, 104)
        PanelProduk.Margin = New Padding(2, 2, 2, 2)
        PanelProduk.Name = "PanelProduk"
        PanelProduk.Size = New Size(164, 84)
        PanelProduk.TabIndex = 4
        ' 
        ' LabelProdukIcon
        ' 
        LabelProdukIcon.BackColor = Color.FromArgb(CByte(30), CByte(105), CByte(255))
        LabelProdukIcon.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        LabelProdukIcon.ForeColor = Color.White
        LabelProdukIcon.Location = New Point(13, 22)
        LabelProdukIcon.Margin = New Padding(2, 0, 2, 0)
        LabelProdukIcon.Name = "LabelProdukIcon"
        LabelProdukIcon.Size = New Size(38, 38)
        LabelProdukIcon.TabIndex = 0
        LabelProdukIcon.Text = "B"
        LabelProdukIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelProdukTitle
        ' 
        LabelProdukTitle.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        LabelProdukTitle.Location = New Point(62, 14)
        LabelProdukTitle.Margin = New Padding(2, 0, 2, 0)
        LabelProdukTitle.Name = "LabelProdukTitle"
        LabelProdukTitle.Size = New Size(100, 19)
        LabelProdukTitle.TabIndex = 1
        LabelProdukTitle.Text = "TOTAL PRODUK"
        ' 
        ' LabelProdukValue
        ' 
        LabelProdukValue.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        LabelProdukValue.Location = New Point(62, 34)
        LabelProdukValue.Margin = New Padding(2, 0, 2, 0)
        LabelProdukValue.Name = "LabelProdukValue"
        LabelProdukValue.Size = New Size(100, 26)
        LabelProdukValue.TabIndex = 2
        LabelProdukValue.Text = "156"
        ' 
        ' LabelProdukInfo
        ' 
        LabelProdukInfo.Location = New Point(62, 59)
        LabelProdukInfo.Margin = New Padding(2, 0, 2, 0)
        LabelProdukInfo.Name = "LabelProdukInfo"
        LabelProdukInfo.Size = New Size(100, 18)
        LabelProdukInfo.TabIndex = 3
        LabelProdukInfo.Text = "Produk"
        ' 
        ' PanelStok
        ' 
        PanelStok.BackColor = Color.White
        PanelStok.BorderStyle = BorderStyle.FixedSingle
        PanelStok.Controls.Add(LabelStokIcon)
        PanelStok.Controls.Add(LabelStokTitle)
        PanelStok.Controls.Add(LabelStokValue)
        PanelStok.Controls.Add(LabelStokInfo)
        PanelStok.Location = New Point(216, 104)
        PanelStok.Margin = New Padding(2, 2, 2, 2)
        PanelStok.Name = "PanelStok"
        PanelStok.Size = New Size(164, 84)
        PanelStok.TabIndex = 5
        ' 
        ' LabelStokIcon
        ' 
        LabelStokIcon.BackColor = Color.FromArgb(CByte(255), CByte(181), CByte(0))
        LabelStokIcon.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        LabelStokIcon.ForeColor = Color.White
        LabelStokIcon.Location = New Point(13, 22)
        LabelStokIcon.Margin = New Padding(2, 0, 2, 0)
        LabelStokIcon.Name = "LabelStokIcon"
        LabelStokIcon.Size = New Size(38, 38)
        LabelStokIcon.TabIndex = 0
        LabelStokIcon.Text = "!"
        LabelStokIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelStokTitle
        ' 
        LabelStokTitle.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        LabelStokTitle.Location = New Point(62, 14)
        LabelStokTitle.Margin = New Padding(2, 0, 2, 0)
        LabelStokTitle.Name = "LabelStokTitle"
        LabelStokTitle.Size = New Size(100, 19)
        LabelStokTitle.TabIndex = 1
        LabelStokTitle.Text = "STOK MENIPIS"
        ' 
        ' LabelStokValue
        ' 
        LabelStokValue.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        LabelStokValue.Location = New Point(62, 34)
        LabelStokValue.Margin = New Padding(2, 0, 2, 0)
        LabelStokValue.Name = "LabelStokValue"
        LabelStokValue.Size = New Size(100, 26)
        LabelStokValue.TabIndex = 2
        LabelStokValue.Text = "18"
        ' 
        ' LabelStokInfo
        ' 
        LabelStokInfo.Location = New Point(62, 59)
        LabelStokInfo.Margin = New Padding(2, 0, 2, 0)
        LabelStokInfo.Name = "LabelStokInfo"
        LabelStokInfo.Size = New Size(100, 18)
        LabelStokInfo.TabIndex = 3
        LabelStokInfo.Text = "Produk"
        ' 
        ' PanelPenjualan
        ' 
        PanelPenjualan.BackColor = Color.White
        PanelPenjualan.BorderStyle = BorderStyle.FixedSingle
        PanelPenjualan.Controls.Add(LabelPenjualanIcon)
        PanelPenjualan.Controls.Add(LabelPenjualanTitle)
        PanelPenjualan.Controls.Add(LabelPenjualanValue)
        PanelPenjualan.Controls.Add(LabelPenjualanInfo)
        PanelPenjualan.Location = New Point(402, 104)
        PanelPenjualan.Margin = New Padding(2, 2, 2, 2)
        PanelPenjualan.Name = "PanelPenjualan"
        PanelPenjualan.Size = New Size(164, 84)
        PanelPenjualan.TabIndex = 6
        ' 
        ' LabelPenjualanIcon
        ' 
        LabelPenjualanIcon.BackColor = Color.FromArgb(CByte(35), CByte(166), CByte(75))
        LabelPenjualanIcon.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        LabelPenjualanIcon.ForeColor = Color.White
        LabelPenjualanIcon.Location = New Point(13, 22)
        LabelPenjualanIcon.Margin = New Padding(2, 0, 2, 0)
        LabelPenjualanIcon.Name = "LabelPenjualanIcon"
        LabelPenjualanIcon.Size = New Size(38, 38)
        LabelPenjualanIcon.TabIndex = 0
        LabelPenjualanIcon.Text = "$"
        LabelPenjualanIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelPenjualanTitle
        ' 
        LabelPenjualanTitle.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        LabelPenjualanTitle.Location = New Point(62, 14)
        LabelPenjualanTitle.Margin = New Padding(2, 0, 2, 0)
        LabelPenjualanTitle.Name = "LabelPenjualanTitle"
        LabelPenjualanTitle.Size = New Size(100, 19)
        LabelPenjualanTitle.TabIndex = 1
        LabelPenjualanTitle.Text = "PENJUALAN HARI INI"
        ' 
        ' LabelPenjualanValue
        ' 
        LabelPenjualanValue.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        LabelPenjualanValue.Location = New Point(62, 35)
        LabelPenjualanValue.Margin = New Padding(2, 0, 2, 0)
        LabelPenjualanValue.Name = "LabelPenjualanValue"
        LabelPenjualanValue.Size = New Size(100, 24)
        LabelPenjualanValue.TabIndex = 2
        LabelPenjualanValue.Text = "Rp 5.250.000"
        ' 
        ' LabelPenjualanInfo
        ' 
        LabelPenjualanInfo.Location = New Point(62, 59)
        LabelPenjualanInfo.Margin = New Padding(2, 0, 2, 0)
        LabelPenjualanInfo.Name = "LabelPenjualanInfo"
        LabelPenjualanInfo.Size = New Size(100, 18)
        LabelPenjualanInfo.TabIndex = 3
        LabelPenjualanInfo.Text = "Total Penjualan"
        ' 
        ' PanelPelanggan
        ' 
        PanelPelanggan.BackColor = Color.White
        PanelPelanggan.BorderStyle = BorderStyle.FixedSingle
        PanelPelanggan.Controls.Add(LabelPelangganIcon)
        PanelPelanggan.Controls.Add(LabelPelangganTitle)
        PanelPelanggan.Controls.Add(LabelPelangganValue)
        PanelPelanggan.Controls.Add(LabelPelangganInfo)
        PanelPelanggan.Location = New Point(587, 104)
        PanelPelanggan.Margin = New Padding(2, 2, 2, 2)
        PanelPelanggan.Name = "PanelPelanggan"
        PanelPelanggan.Size = New Size(164, 84)
        PanelPelanggan.TabIndex = 7
        ' 
        ' LabelPelangganIcon
        ' 
        LabelPelangganIcon.BackColor = Color.FromArgb(CByte(145), CByte(85), CByte(230))
        LabelPelangganIcon.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        LabelPelangganIcon.ForeColor = Color.White
        LabelPelangganIcon.Location = New Point(13, 22)
        LabelPelangganIcon.Margin = New Padding(2, 0, 2, 0)
        LabelPelangganIcon.Name = "LabelPelangganIcon"
        LabelPelangganIcon.Size = New Size(38, 38)
        LabelPelangganIcon.TabIndex = 0
        LabelPelangganIcon.Text = "P"
        LabelPelangganIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelPelangganTitle
        ' 
        LabelPelangganTitle.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        LabelPelangganTitle.Location = New Point(62, 14)
        LabelPelangganTitle.Margin = New Padding(2, 0, 2, 0)
        LabelPelangganTitle.Name = "LabelPelangganTitle"
        LabelPelangganTitle.Size = New Size(100, 19)
        LabelPelangganTitle.TabIndex = 1
        LabelPelangganTitle.Text = "TOTAL PELANGGAN"
        ' 
        ' LabelPelangganValue
        ' 
        LabelPelangganValue.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        LabelPelangganValue.Location = New Point(62, 34)
        LabelPelangganValue.Margin = New Padding(2, 0, 2, 0)
        LabelPelangganValue.Name = "LabelPelangganValue"
        LabelPelangganValue.Size = New Size(100, 26)
        LabelPelangganValue.TabIndex = 2
        LabelPelangganValue.Text = "125"
        ' 
        ' LabelPelangganInfo
        ' 
        LabelPelangganInfo.Location = New Point(62, 59)
        LabelPelangganInfo.Margin = New Padding(2, 0, 2, 0)
        LabelPelangganInfo.Name = "LabelPelangganInfo"
        LabelPelangganInfo.Size = New Size(100, 18)
        LabelPelangganInfo.TabIndex = 3
        LabelPelangganInfo.Text = "Pelanggan"
        ' 
        ' PanelGrafik
        ' 
        PanelGrafik.BackColor = Color.White
        PanelGrafik.BorderStyle = BorderStyle.FixedSingle
        PanelGrafik.Controls.Add(LabelGrafikTitle)
        PanelGrafik.Controls.Add(LabelGrafik1)
        PanelGrafik.Controls.Add(LabelGrafik2)
        PanelGrafik.Controls.Add(LabelGrafik3)
        PanelGrafik.Controls.Add(LabelGrafik4)
        PanelGrafik.Controls.Add(LabelGrafik5)
        PanelGrafik.Controls.Add(LabelGrafikTanggal)
        PanelGrafik.Location = New Point(30, 208)
        PanelGrafik.Margin = New Padding(2, 2, 2, 2)
        PanelGrafik.Name = "PanelGrafik"
        PanelGrafik.Size = New Size(364, 196)
        PanelGrafik.TabIndex = 8
        ' 
        ' LabelGrafikTitle
        ' 
        LabelGrafikTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelGrafikTitle.Location = New Point(14, 14)
        LabelGrafikTitle.Margin = New Padding(2, 0, 2, 0)
        LabelGrafikTitle.Name = "LabelGrafikTitle"
        LabelGrafikTitle.Size = New Size(240, 20)
        LabelGrafikTitle.TabIndex = 0
        LabelGrafikTitle.Text = "Grafik Penjualan 7 Hari Terakhir"
        ' 
        ' LabelGrafik1
        ' 
        LabelGrafik1.Font = New Font("Consolas", 10F, FontStyle.Bold)
        LabelGrafik1.ForeColor = Color.FromArgb(CByte(0), CByte(102), CByte(255))
        LabelGrafik1.Location = New Point(20, 48)
        LabelGrafik1.Margin = New Padding(2, 0, 2, 0)
        LabelGrafik1.Name = "LabelGrafik1"
        LabelGrafik1.Size = New Size(312, 18)
        LabelGrafik1.TabIndex = 1
        LabelGrafik1.Text = "8.000.000 |                         *"
        ' 
        ' LabelGrafik2
        ' 
        LabelGrafik2.Font = New Font("Consolas", 10F, FontStyle.Bold)
        LabelGrafik2.ForeColor = Color.FromArgb(CByte(0), CByte(102), CByte(255))
        LabelGrafik2.Location = New Point(20, 68)
        LabelGrafik2.Margin = New Padding(2, 0, 2, 0)
        LabelGrafik2.Name = "LabelGrafik2"
        LabelGrafik2.Size = New Size(312, 18)
        LabelGrafik2.TabIndex = 2
        LabelGrafik2.Text = "6.000.000 |                 *      /"
        ' 
        ' LabelGrafik3
        ' 
        LabelGrafik3.Font = New Font("Consolas", 10F, FontStyle.Bold)
        LabelGrafik3.ForeColor = Color.FromArgb(CByte(0), CByte(102), CByte(255))
        LabelGrafik3.Location = New Point(20, 88)
        LabelGrafik3.Margin = New Padding(2, 0, 2, 0)
        LabelGrafik3.Name = "LabelGrafik3"
        LabelGrafik3.Size = New Size(312, 18)
        LabelGrafik3.TabIndex = 3
        LabelGrafik3.Text = "4.000.000 |      *----*    / \   *"
        ' 
        ' LabelGrafik4
        ' 
        LabelGrafik4.Font = New Font("Consolas", 10F, FontStyle.Bold)
        LabelGrafik4.ForeColor = Color.FromArgb(CByte(0), CByte(102), CByte(255))
        LabelGrafik4.Location = New Point(20, 108)
        LabelGrafik4.Margin = New Padding(2, 0, 2, 0)
        LabelGrafik4.Name = "LabelGrafik4"
        LabelGrafik4.Size = New Size(312, 18)
        LabelGrafik4.TabIndex = 4
        LabelGrafik4.Text = "2.000.000 | *---/      \--*"
        ' 
        ' LabelGrafik5
        ' 
        LabelGrafik5.Font = New Font("Consolas", 10F, FontStyle.Bold)
        LabelGrafik5.ForeColor = Color.FromArgb(CByte(0), CByte(102), CByte(255))
        LabelGrafik5.Location = New Point(20, 128)
        LabelGrafik5.Margin = New Padding(2, 0, 2, 0)
        LabelGrafik5.Name = "LabelGrafik5"
        LabelGrafik5.Size = New Size(312, 18)
        LabelGrafik5.TabIndex = 5
        LabelGrafik5.Text = "        0 +------------------------"
        ' 
        ' LabelGrafikTanggal
        ' 
        LabelGrafikTanggal.Font = New Font("Segoe UI", 8F)
        LabelGrafikTanggal.Location = New Point(28, 152)
        LabelGrafikTanggal.Margin = New Padding(2, 0, 2, 0)
        LabelGrafikTanggal.Name = "LabelGrafikTanggal"
        LabelGrafikTanggal.Size = New Size(320, 20)
        LabelGrafikTanggal.TabIndex = 6
        LabelGrafikTanggal.Text = "16/05     17/05     18/05     19/05     20/05     21/05     22/05"
        ' 
        ' PanelTopProduk
        ' 
        PanelTopProduk.BackColor = Color.White
        PanelTopProduk.BorderStyle = BorderStyle.FixedSingle
        PanelTopProduk.Controls.Add(LabelTopProdukTitle)
        PanelTopProduk.Controls.Add(TableTopProduk)
        PanelTopProduk.Location = New Point(412, 208)
        PanelTopProduk.Margin = New Padding(2, 2, 2, 2)
        PanelTopProduk.Name = "PanelTopProduk"
        PanelTopProduk.Size = New Size(336, 196)
        PanelTopProduk.TabIndex = 9
        ' 
        ' LabelTopProdukTitle
        ' 
        LabelTopProdukTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelTopProdukTitle.Location = New Point(14, 14)
        LabelTopProdukTitle.Margin = New Padding(2, 0, 2, 0)
        LabelTopProdukTitle.Name = "LabelTopProdukTitle"
        LabelTopProdukTitle.Size = New Size(200, 20)
        LabelTopProdukTitle.TabIndex = 0
        LabelTopProdukTitle.Text = "Top 5 Produk Terlaris"
        ' 
        ' TableTopProduk
        ' 
        TableTopProduk.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        TableTopProduk.ColumnCount = 3
        TableTopProduk.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 40F))
        TableTopProduk.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableTopProduk.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 65F))
        TableTopProduk.Location = New Point(14, 46)
        TableTopProduk.Margin = New Padding(2, 2, 2, 2)
        TableTopProduk.Name = "TableTopProduk"
        TableTopProduk.RowCount = 6
        TableTopProduk.RowStyles.Add(New RowStyle(SizeType.Absolute, 21F))
        TableTopProduk.RowStyles.Add(New RowStyle(SizeType.Absolute, 21F))
        TableTopProduk.RowStyles.Add(New RowStyle(SizeType.Absolute, 21F))
        TableTopProduk.RowStyles.Add(New RowStyle(SizeType.Absolute, 21F))
        TableTopProduk.RowStyles.Add(New RowStyle(SizeType.Absolute, 21F))
        TableTopProduk.RowStyles.Add(New RowStyle(SizeType.Absolute, 21F))
        TableTopProduk.Size = New Size(304, 132)
        TableTopProduk.TabIndex = 0
        ' 
        ' PanelNotifikasi
        ' 
        PanelNotifikasi.BackColor = Color.White
        PanelNotifikasi.BorderStyle = BorderStyle.FixedSingle
        PanelNotifikasi.Controls.Add(LabelNotifikasiTitle)
        PanelNotifikasi.Controls.Add(LabelNotif1)
        PanelNotifikasi.Controls.Add(LabelNotif2)
        PanelNotifikasi.Controls.Add(LabelNotif3)
        PanelNotifikasi.Location = New Point(30, 420)
        PanelNotifikasi.Margin = New Padding(2, 2, 2, 2)
        PanelNotifikasi.Name = "PanelNotifikasi"
        PanelNotifikasi.Size = New Size(364, 128)
        PanelNotifikasi.TabIndex = 10
        ' 
        ' LabelNotifikasiTitle
        ' 
        LabelNotifikasiTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelNotifikasiTitle.Location = New Point(14, 13)
        LabelNotifikasiTitle.Margin = New Padding(2, 0, 2, 0)
        LabelNotifikasiTitle.Name = "LabelNotifikasiTitle"
        LabelNotifikasiTitle.Size = New Size(160, 20)
        LabelNotifikasiTitle.TabIndex = 0
        LabelNotifikasiTitle.Text = "Notifikasi"
        ' 
        ' LabelNotif1
        ' 
        LabelNotif1.Font = New Font("Segoe UI", 10F)
        LabelNotif1.ForeColor = Color.Red
        LabelNotif1.Location = New Point(18, 44)
        LabelNotif1.Margin = New Padding(2, 0, 2, 0)
        LabelNotif1.Name = "LabelNotif1"
        LabelNotif1.Size = New Size(312, 20)
        LabelNotif1.TabIndex = 1
        LabelNotif1.Text = "- 18 produk dengan stok menipis"
        ' 
        ' LabelNotif2
        ' 
        LabelNotif2.Font = New Font("Segoe UI", 10F)
        LabelNotif2.Location = New Point(18, 68)
        LabelNotif2.Margin = New Padding(2, 0, 2, 0)
        LabelNotif2.Name = "LabelNotif2"
        LabelNotif2.Size = New Size(312, 20)
        LabelNotif2.TabIndex = 2
        LabelNotif2.Text = "- 2 pesanan pembelian belum diterima"
        ' 
        ' LabelNotif3
        ' 
        LabelNotif3.Font = New Font("Segoe UI", 10F)
        LabelNotif3.Location = New Point(18, 92)
        LabelNotif3.Margin = New Padding(2, 0, 2, 0)
        LabelNotif3.Name = "LabelNotif3"
        LabelNotif3.Size = New Size(328, 20)
        LabelNotif3.TabIndex = 3
        LabelNotif3.Text = "- Backup data terakhir: 22/05/2024 08:00"
        ' 
        ' PanelInfo
        ' 
        PanelInfo.BackColor = Color.White
        PanelInfo.BorderStyle = BorderStyle.FixedSingle
        PanelInfo.Controls.Add(LabelInfoTitle)
        PanelInfo.Controls.Add(LabelInfoUser)
        PanelInfo.Controls.Add(LabelInfoLevel)
        PanelInfo.Controls.Add(LabelInfoVersi)
        PanelInfo.Location = New Point(412, 420)
        PanelInfo.Margin = New Padding(2, 2, 2, 2)
        PanelInfo.Name = "PanelInfo"
        PanelInfo.Size = New Size(336, 128)
        PanelInfo.TabIndex = 11
        ' 
        ' LabelInfoTitle
        ' 
        LabelInfoTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelInfoTitle.ForeColor = Color.FromArgb(CByte(20), CByte(50), CByte(110))
        LabelInfoTitle.Location = New Point(14, 13)
        LabelInfoTitle.Margin = New Padding(2, 0, 2, 0)
        LabelInfoTitle.Name = "LabelInfoTitle"
        LabelInfoTitle.Size = New Size(200, 20)
        LabelInfoTitle.TabIndex = 0
        LabelInfoTitle.Text = "Informasi Sistem"
        ' 
        ' LabelInfoUser
        ' 
        LabelInfoUser.Font = New Font("Segoe UI", 10F)
        LabelInfoUser.Location = New Point(18, 44)
        LabelInfoUser.Margin = New Padding(2, 0, 2, 0)
        LabelInfoUser.Name = "LabelInfoUser"
        LabelInfoUser.Size = New Size(280, 20)
        LabelInfoUser.TabIndex = 1
        LabelInfoUser.Text = "User Aktif              :   admin"
        ' 
        ' LabelInfoLevel
        ' 
        LabelInfoLevel.Font = New Font("Segoe UI", 10F)
        LabelInfoLevel.Location = New Point(18, 68)
        LabelInfoLevel.Margin = New Padding(2, 0, 2, 0)
        LabelInfoLevel.Name = "LabelInfoLevel"
        LabelInfoLevel.Size = New Size(280, 20)
        LabelInfoLevel.TabIndex = 2
        LabelInfoLevel.Text = "Level                   :   Administrator"
        ' 
        ' LabelInfoVersi
        ' 
        LabelInfoVersi.Font = New Font("Segoe UI", 10F)
        LabelInfoVersi.Location = New Point(18, 92)
        LabelInfoVersi.Margin = New Padding(2, 0, 2, 0)
        LabelInfoVersi.Name = "LabelInfoVersi"
        LabelInfoVersi.Size = New Size(280, 20)
        LabelInfoVersi.TabIndex = 3
        LabelInfoVersi.Text = "Versi Aplikasi          :   1.0.0.0"
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(246), CByte(248), CByte(252))
        ClientSize = New Size(960, 608)
        Controls.Add(PanelContent)
        Controls.Add(PanelSidebar)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(2, 2, 2, 2)
        Name = "FormDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistem Manajemen Toko Pakaian Pria"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        PanelSidebar.ResumeLayout(False)
        PanelContent.ResumeLayout(False)
        PanelProduk.ResumeLayout(False)
        PanelStok.ResumeLayout(False)
        PanelPenjualan.ResumeLayout(False)
        PanelPelanggan.ResumeLayout(False)
        PanelGrafik.ResumeLayout(False)
        PanelTopProduk.ResumeLayout(False)
        PanelNotifikasi.ResumeLayout(False)
        PanelInfo.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

End Class