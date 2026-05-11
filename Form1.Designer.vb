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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengaturanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BantuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()

        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KategoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanStokToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CetakStrukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfilTokoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangAplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanduanPenggunaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()

        Me.PanelSidebar = New System.Windows.Forms.Panel()
        Me.LabelLogoIcon = New System.Windows.Forms.Label()
        Me.LabelBrand = New System.Windows.Forms.Label()
        Me.LabelBrandSub = New System.Windows.Forms.Label()
        Me.BtnDashboard = New System.Windows.Forms.Button()
        Me.BtnDataBarang = New System.Windows.Forms.Button()
        Me.BtnKategori = New System.Windows.Forms.Button()
        Me.BtnSupplier = New System.Windows.Forms.Button()
        Me.BtnPelanggan = New System.Windows.Forms.Button()
        Me.BtnPenjualan = New System.Windows.Forms.Button()
        Me.BtnPembelian = New System.Windows.Forms.Button()
        Me.BtnStok = New System.Windows.Forms.Button()
        Me.BtnLaporan = New System.Windows.Forms.Button()
        Me.BtnUser = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()

        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.LabelWelcome = New System.Windows.Forms.Label()
        Me.LabelSubtitle = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelTime = New System.Windows.Forms.Label()

        Me.PanelProduk = New System.Windows.Forms.Panel()
        Me.PanelStok = New System.Windows.Forms.Panel()
        Me.PanelPenjualan = New System.Windows.Forms.Panel()
        Me.PanelPelanggan = New System.Windows.Forms.Panel()

        Me.LabelProdukIcon = New System.Windows.Forms.Label()
        Me.LabelProdukTitle = New System.Windows.Forms.Label()
        Me.LabelProdukValue = New System.Windows.Forms.Label()
        Me.LabelProdukInfo = New System.Windows.Forms.Label()

        Me.LabelStokIcon = New System.Windows.Forms.Label()
        Me.LabelStokTitle = New System.Windows.Forms.Label()
        Me.LabelStokValue = New System.Windows.Forms.Label()
        Me.LabelStokInfo = New System.Windows.Forms.Label()

        Me.LabelPenjualanIcon = New System.Windows.Forms.Label()
        Me.LabelPenjualanTitle = New System.Windows.Forms.Label()
        Me.LabelPenjualanValue = New System.Windows.Forms.Label()
        Me.LabelPenjualanInfo = New System.Windows.Forms.Label()

        Me.LabelPelangganIcon = New System.Windows.Forms.Label()
        Me.LabelPelangganTitle = New System.Windows.Forms.Label()
        Me.LabelPelangganValue = New System.Windows.Forms.Label()
        Me.LabelPelangganInfo = New System.Windows.Forms.Label()

        Me.PanelGrafik = New System.Windows.Forms.Panel()
        Me.LabelGrafikTitle = New System.Windows.Forms.Label()
        Me.LabelGrafik1 = New System.Windows.Forms.Label()
        Me.LabelGrafik2 = New System.Windows.Forms.Label()
        Me.LabelGrafik3 = New System.Windows.Forms.Label()
        Me.LabelGrafik4 = New System.Windows.Forms.Label()
        Me.LabelGrafik5 = New System.Windows.Forms.Label()
        Me.LabelGrafikTanggal = New System.Windows.Forms.Label()

        Me.PanelTopProduk = New System.Windows.Forms.Panel()
        Me.LabelTopProdukTitle = New System.Windows.Forms.Label()
        Me.TableTopProduk = New System.Windows.Forms.TableLayoutPanel()

        Me.PanelNotifikasi = New System.Windows.Forms.Panel()
        Me.LabelNotifikasiTitle = New System.Windows.Forms.Label()
        Me.LabelNotif1 = New System.Windows.Forms.Label()
        Me.LabelNotif2 = New System.Windows.Forms.Label()
        Me.LabelNotif3 = New System.Windows.Forms.Label()

        Me.PanelInfo = New System.Windows.Forms.Panel()
        Me.LabelInfoTitle = New System.Windows.Forms.Label()
        Me.LabelInfoUser = New System.Windows.Forms.Label()
        Me.LabelInfoLevel = New System.Windows.Forms.Label()
        Me.LabelInfoVersi = New System.Windows.Forms.Label()

        Me.MenuStrip1.SuspendLayout()
        Me.PanelSidebar.SuspendLayout()
        Me.PanelContent.SuspendLayout()
        Me.PanelProduk.SuspendLayout()
        Me.PanelStok.SuspendLayout()
        Me.PanelPenjualan.SuspendLayout()
        Me.PanelPelanggan.SuspendLayout()
        Me.PanelGrafik.SuspendLayout()
        Me.PanelTopProduk.SuspendLayout()
        Me.PanelNotifikasi.SuspendLayout()
        Me.PanelInfo.SuspendLayout()
        Me.SuspendLayout()

        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0F, 25.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(246, 248, 252)
        Me.ClientSize = New System.Drawing.Size(1200, 760)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Manajemen Toko Pakaian Pria"

        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterDataToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.PengaturanToolStripMenuItem, Me.BantuanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1200, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"

        Me.FileToolStripMenuItem.Text = "File"
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.LoginToolStripMenuItem.Text = "Login"
        Me.LogoutToolStripMenuItem.Text = "Logout"
        Me.KeluarToolStripMenuItem.Text = "Keluar"

        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBarangToolStripMenuItem, Me.KategoriToolStripMenuItem, Me.SupplierToolStripMenuItem, Me.PelangganToolStripMenuItem, Me.UserAdminToolStripMenuItem})
        Me.DataBarangToolStripMenuItem.Text = "Data Barang"
        Me.KategoriToolStripMenuItem.Text = "Kategori"
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        Me.PelangganToolStripMenuItem.Text = "Pelanggan"
        Me.UserAdminToolStripMenuItem.Text = "User / Admin"

        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem, Me.PembelianToolStripMenuItem})
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        Me.PembelianToolStripMenuItem.Text = "Pembelian / Stok Masuk"

        Me.LaporanToolStripMenuItem.Text = "Laporan"
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanPenjualanToolStripMenuItem, Me.LaporanStokToolStripMenuItem, Me.LaporanPembelianToolStripMenuItem, Me.CetakStrukToolStripMenuItem})
        Me.LaporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan"
        Me.LaporanStokToolStripMenuItem.Text = "Laporan Stok Barang"
        Me.LaporanPembelianToolStripMenuItem.Text = "Laporan Pembelian"
        Me.CetakStrukToolStripMenuItem.Text = "Cetak Struk"

        Me.PengaturanToolStripMenuItem.Text = "Pengaturan"
        Me.PengaturanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfilTokoToolStripMenuItem, Me.BackupDatabaseToolStripMenuItem, Me.RestoreDatabaseToolStripMenuItem})
        Me.ProfilTokoToolStripMenuItem.Text = "Profil Toko"
        Me.BackupDatabaseToolStripMenuItem.Text = "Backup Database"
        Me.RestoreDatabaseToolStripMenuItem.Text = "Restore Database"

        Me.BantuanToolStripMenuItem.Text = "Bantuan"
        Me.BantuanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TentangAplikasiToolStripMenuItem, Me.PanduanPenggunaanToolStripMenuItem})
        Me.TentangAplikasiToolStripMenuItem.Text = "Tentang Aplikasi"
        Me.PanduanPenggunaanToolStripMenuItem.Text = "Panduan Penggunaan"

        '
        'PanelSidebar
        '
        Me.PanelSidebar.BackColor = System.Drawing.Color.FromArgb(3, 28, 48)
        Me.PanelSidebar.Controls.Add(Me.LabelLogoIcon)
        Me.PanelSidebar.Controls.Add(Me.LabelBrand)
        Me.PanelSidebar.Controls.Add(Me.LabelBrandSub)
        Me.PanelSidebar.Controls.Add(Me.BtnDashboard)
        Me.PanelSidebar.Controls.Add(Me.BtnDataBarang)
        Me.PanelSidebar.Controls.Add(Me.BtnKategori)
        Me.PanelSidebar.Controls.Add(Me.BtnSupplier)
        Me.PanelSidebar.Controls.Add(Me.BtnPelanggan)
        Me.PanelSidebar.Controls.Add(Me.BtnPenjualan)
        Me.PanelSidebar.Controls.Add(Me.BtnPembelian)
        Me.PanelSidebar.Controls.Add(Me.BtnStok)
        Me.PanelSidebar.Controls.Add(Me.BtnLaporan)
        Me.PanelSidebar.Controls.Add(Me.BtnUser)
        Me.PanelSidebar.Controls.Add(Me.BtnLogout)
        Me.PanelSidebar.Location = New System.Drawing.Point(0, 28)
        Me.PanelSidebar.Name = "PanelSidebar"
        Me.PanelSidebar.Size = New System.Drawing.Size(232, 732)
        Me.PanelSidebar.TabIndex = 1

        Me.LabelLogoIcon.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold)
        Me.LabelLogoIcon.ForeColor = System.Drawing.Color.FromArgb(218, 173, 36)
        Me.LabelLogoIcon.Location = New System.Drawing.Point(0, 20)
        Me.LabelLogoIcon.Name = "LabelLogoIcon"
        Me.LabelLogoIcon.Size = New System.Drawing.Size(232, 40)
        Me.LabelLogoIcon.Text = "▰"
        Me.LabelLogoIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        Me.LabelBrand.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LabelBrand.ForeColor = System.Drawing.Color.FromArgb(218, 173, 36)
        Me.LabelBrand.Location = New System.Drawing.Point(0, 60)
        Me.LabelBrand.Name = "LabelBrand"
        Me.LabelBrand.Size = New System.Drawing.Size(232, 35)
        Me.LabelBrand.Text = "GENTLEMEN"
        Me.LabelBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        Me.LabelBrandSub.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.LabelBrandSub.ForeColor = System.Drawing.Color.White
        Me.LabelBrandSub.Location = New System.Drawing.Point(0, 92)
        Me.LabelBrandSub.Name = "LabelBrandSub"
        Me.LabelBrandSub.Size = New System.Drawing.Size(232, 26)
        Me.LabelBrandSub.Text = "MEN'S WEAR"
        Me.LabelBrandSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        '
        'Sidebar Buttons
        '
        Me.BtnDashboard.BackColor = System.Drawing.Color.FromArgb(0, 102, 204)
        Me.BtnDashboard.FlatAppearance.BorderSize = 0
        Me.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDashboard.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnDashboard.ForeColor = System.Drawing.Color.White
        Me.BtnDashboard.Location = New System.Drawing.Point(18, 140)
        Me.BtnDashboard.Name = "BtnDashboard"
        Me.BtnDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnDashboard.Size = New System.Drawing.Size(196, 40)
        Me.BtnDashboard.Text = "⌂   Dashboard"
        Me.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDashboard.UseVisualStyleBackColor = False

        Me.BtnDataBarang.BackColor = System.Drawing.Color.FromArgb(3, 28, 48)
        Me.BtnDataBarang.FlatAppearance.BorderSize = 0
        Me.BtnDataBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDataBarang.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnDataBarang.ForeColor = System.Drawing.Color.White
        Me.BtnDataBarang.Location = New System.Drawing.Point(18, 186)
        Me.BtnDataBarang.Name = "BtnDataBarang"
        Me.BtnDataBarang.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnDataBarang.Size = New System.Drawing.Size(196, 40)
        Me.BtnDataBarang.Text = "▦   Data Barang"
        Me.BtnDataBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDataBarang.UseVisualStyleBackColor = False

        Me.BtnKategori.BackColor = System.Drawing.Color.FromArgb(3, 28, 48)
        Me.BtnKategori.FlatAppearance.BorderSize = 0
        Me.BtnKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKategori.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnKategori.ForeColor = System.Drawing.Color.White
        Me.BtnKategori.Location = New System.Drawing.Point(18, 232)
        Me.BtnKategori.Name = "BtnKategori"
        Me.BtnKategori.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnKategori.Size = New System.Drawing.Size(196, 40)
        Me.BtnKategori.Text = "▣   Kategori"
        Me.BtnKategori.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKategori.UseVisualStyleBackColor = False

        Me.BtnSupplier.BackColor = System.Drawing.Color.FromArgb(3, 28, 48)
        Me.BtnSupplier.FlatAppearance.BorderSize = 0
        Me.BtnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSupplier.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSupplier.ForeColor = System.Drawing.Color.White
        Me.BtnSupplier.Location = New System.Drawing.Point(18, 278)
        Me.BtnSupplier.Name = "BtnSupplier"
        Me.BtnSupplier.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnSupplier.Size = New System.Drawing.Size(196, 40)
        Me.BtnSupplier.Text = "●   Supplier"
        Me.BtnSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSupplier.UseVisualStyleBackColor = False

        Me.BtnPelanggan.BackColor = System.Drawing.Color.FromArgb(3, 28, 48)
        Me.BtnPelanggan.FlatAppearance.BorderSize = 0
        Me.BtnPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPelanggan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPelanggan.ForeColor = System.Drawing.Color.White
        Me.BtnPelanggan.Location = New System.Drawing.Point(18, 324)
        Me.BtnPelanggan.Name = "BtnPelanggan"
        Me.BtnPelanggan.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnPelanggan.Size = New System.Drawing.Size(196, 40)
        Me.BtnPelanggan.Text = "●   Pelanggan"
        Me.BtnPelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPelanggan.UseVisualStyleBackColor = False

        Me.BtnPenjualan.BackColor = System.Drawing.Color.FromArgb(3, 28, 48)
        Me.BtnPenjualan.FlatAppearance.BorderSize = 0
        Me.BtnPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPenjualan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPenjualan.ForeColor = System.Drawing.Color.White
        Me.BtnPenjualan.Location = New System.Drawing.Point(18, 370)
        Me.BtnPenjualan.Name = "BtnPenjualan"
        Me.BtnPenjualan.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnPenjualan.Size = New System.Drawing.Size(196, 40)
        Me.BtnPenjualan.Text = "▤   Penjualan"
        Me.BtnPenjualan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPenjualan.UseVisualStyleBackColor = False

        Me.BtnPembelian.BackColor = System.Drawing.Color.FromArgb(3, 28, 48)
        Me.BtnPembelian.FlatAppearance.BorderSize = 0
        Me.BtnPembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPembelian.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPembelian.ForeColor = System.Drawing.Color.White
        Me.BtnPembelian.Location = New System.Drawing.Point(18, 416)
        Me.BtnPembelian.Name = "BtnPembelian"
        Me.BtnPembelian.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnPembelian.Size = New System.Drawing.Size(196, 40)
        Me.BtnPembelian.Text = "▥   Pembelian"
        Me.BtnPembelian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPembelian.UseVisualStyleBackColor = False

        Me.BtnStok.BackColor = System.Drawing.Color.FromArgb(3, 28, 48)
        Me.BtnStok.FlatAppearance.BorderSize = 0
        Me.BtnStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStok.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnStok.ForeColor = System.Drawing.Color.White
        Me.BtnStok.Location = New System.Drawing.Point(18, 462)
        Me.BtnStok.Name = "BtnStok"
        Me.BtnStok.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnStok.Size = New System.Drawing.Size(196, 40)
        Me.BtnStok.Text = "▧   Stok"
        Me.BtnStok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnStok.UseVisualStyleBackColor = False

        Me.BtnLaporan.BackColor = System.Drawing.Color.FromArgb(3, 28, 48)
        Me.BtnLaporan.FlatAppearance.BorderSize = 0
        Me.BtnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLaporan.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLaporan.ForeColor = System.Drawing.Color.White
        Me.BtnLaporan.Location = New System.Drawing.Point(18, 508)
        Me.BtnLaporan.Name = "BtnLaporan"
        Me.BtnLaporan.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnLaporan.Size = New System.Drawing.Size(196, 40)
        Me.BtnLaporan.Text = "□   Laporan"
        Me.BtnLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLaporan.UseVisualStyleBackColor = False

        Me.BtnUser.BackColor = System.Drawing.Color.FromArgb(3, 28, 48)
        Me.BtnUser.FlatAppearance.BorderSize = 0
        Me.BtnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUser.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnUser.ForeColor = System.Drawing.Color.White
        Me.BtnUser.Location = New System.Drawing.Point(18, 554)
        Me.BtnUser.Name = "BtnUser"
        Me.BtnUser.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnUser.Size = New System.Drawing.Size(196, 40)
        Me.BtnUser.Text = "◉   User"
        Me.BtnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUser.UseVisualStyleBackColor = False

        Me.BtnLogout.BackColor = System.Drawing.Color.FromArgb(3, 28, 48)
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLogout.ForeColor = System.Drawing.Color.FromArgb(255, 90, 90)
        Me.BtnLogout.Location = New System.Drawing.Point(18, 610)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnLogout.Size = New System.Drawing.Size(196, 40)
        Me.BtnLogout.Text = "↪   Logout"
        Me.BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogout.UseVisualStyleBackColor = False

        '
        'PanelContent
        '
        Me.PanelContent.BackColor = System.Drawing.Color.FromArgb(246, 248, 252)
        Me.PanelContent.Controls.Add(Me.LabelWelcome)
        Me.PanelContent.Controls.Add(Me.LabelSubtitle)
        Me.PanelContent.Controls.Add(Me.LabelDate)
        Me.PanelContent.Controls.Add(Me.LabelTime)
        Me.PanelContent.Controls.Add(Me.PanelProduk)
        Me.PanelContent.Controls.Add(Me.PanelStok)
        Me.PanelContent.Controls.Add(Me.PanelPenjualan)
        Me.PanelContent.Controls.Add(Me.PanelPelanggan)
        Me.PanelContent.Controls.Add(Me.PanelGrafik)
        Me.PanelContent.Controls.Add(Me.PanelTopProduk)
        Me.PanelContent.Controls.Add(Me.PanelNotifikasi)
        Me.PanelContent.Controls.Add(Me.PanelInfo)
        Me.PanelContent.Location = New System.Drawing.Point(232, 28)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(968, 732)
        Me.PanelContent.TabIndex = 2

        Me.LabelWelcome.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelWelcome.ForeColor = System.Drawing.Color.FromArgb(25, 25, 25)
        Me.LabelWelcome.Location = New System.Drawing.Point(38, 38)
        Me.LabelWelcome.Name = "LabelWelcome"
        Me.LabelWelcome.Size = New System.Drawing.Size(430, 42)
        Me.LabelWelcome.Text = "Selamat Datang, Admin!"

        Me.LabelSubtitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelSubtitle.ForeColor = System.Drawing.Color.FromArgb(45, 45, 45)
        Me.LabelSubtitle.Location = New System.Drawing.Point(40, 78)
        Me.LabelSubtitle.Name = "LabelSubtitle"
        Me.LabelSubtitle.Size = New System.Drawing.Size(430, 28)
        Me.LabelSubtitle.Text = "Berikut ringkasan informasi toko hari ini."

        Me.LabelDate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelDate.ForeColor = System.Drawing.Color.FromArgb(35, 35, 35)
        Me.LabelDate.Location = New System.Drawing.Point(650, 52)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(190, 25)
        Me.LabelDate.Text = "Rabu, 22 Mei 2024"

        Me.LabelTime.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelTime.ForeColor = System.Drawing.Color.FromArgb(35, 35, 35)
        Me.LabelTime.Location = New System.Drawing.Point(835, 52)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(120, 25)
        Me.LabelTime.Text = "10:30:45"

        '
        'Cards
        '
        Me.PanelProduk.BackColor = System.Drawing.Color.White
        Me.PanelProduk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelProduk.Controls.Add(Me.LabelProdukIcon)
        Me.PanelProduk.Controls.Add(Me.LabelProdukTitle)
        Me.PanelProduk.Controls.Add(Me.LabelProdukValue)
        Me.PanelProduk.Controls.Add(Me.LabelProdukInfo)
        Me.PanelProduk.Location = New System.Drawing.Point(38, 130)
        Me.PanelProduk.Name = "PanelProduk"
        Me.PanelProduk.Size = New System.Drawing.Size(205, 105)

        Me.LabelProdukIcon.BackColor = System.Drawing.Color.FromArgb(30, 105, 255)
        Me.LabelProdukIcon.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelProdukIcon.ForeColor = System.Drawing.Color.White
        Me.LabelProdukIcon.Location = New System.Drawing.Point(16, 28)
        Me.LabelProdukIcon.Size = New System.Drawing.Size(48, 48)
        Me.LabelProdukIcon.Text = "B"
        Me.LabelProdukIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelProdukTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.LabelProdukTitle.Location = New System.Drawing.Point(78, 18)
        Me.LabelProdukTitle.Size = New System.Drawing.Size(125, 24)
        Me.LabelProdukTitle.Text = "TOTAL PRODUK"
        Me.LabelProdukValue.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelProdukValue.Location = New System.Drawing.Point(78, 42)
        Me.LabelProdukValue.Size = New System.Drawing.Size(125, 32)
        Me.LabelProdukValue.Text = "156"
        Me.LabelProdukInfo.Location = New System.Drawing.Point(78, 74)
        Me.LabelProdukInfo.Size = New System.Drawing.Size(125, 22)
        Me.LabelProdukInfo.Text = "Produk"

        Me.PanelStok.BackColor = System.Drawing.Color.White
        Me.PanelStok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelStok.Controls.Add(Me.LabelStokIcon)
        Me.PanelStok.Controls.Add(Me.LabelStokTitle)
        Me.PanelStok.Controls.Add(Me.LabelStokValue)
        Me.PanelStok.Controls.Add(Me.LabelStokInfo)
        Me.PanelStok.Location = New System.Drawing.Point(270, 130)
        Me.PanelStok.Name = "PanelStok"
        Me.PanelStok.Size = New System.Drawing.Size(205, 105)

        Me.LabelStokIcon.BackColor = System.Drawing.Color.FromArgb(255, 181, 0)
        Me.LabelStokIcon.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelStokIcon.ForeColor = System.Drawing.Color.White
        Me.LabelStokIcon.Location = New System.Drawing.Point(16, 28)
        Me.LabelStokIcon.Size = New System.Drawing.Size(48, 48)
        Me.LabelStokIcon.Text = "!"
        Me.LabelStokIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelStokTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.LabelStokTitle.Location = New System.Drawing.Point(78, 18)
        Me.LabelStokTitle.Size = New System.Drawing.Size(125, 24)
        Me.LabelStokTitle.Text = "STOK MENIPIS"
        Me.LabelStokValue.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelStokValue.Location = New System.Drawing.Point(78, 42)
        Me.LabelStokValue.Size = New System.Drawing.Size(125, 32)
        Me.LabelStokValue.Text = "18"
        Me.LabelStokInfo.Location = New System.Drawing.Point(78, 74)
        Me.LabelStokInfo.Size = New System.Drawing.Size(125, 22)
        Me.LabelStokInfo.Text = "Produk"

        Me.PanelPenjualan.BackColor = System.Drawing.Color.White
        Me.PanelPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelPenjualan.Controls.Add(Me.LabelPenjualanIcon)
        Me.PanelPenjualan.Controls.Add(Me.LabelPenjualanTitle)
        Me.PanelPenjualan.Controls.Add(Me.LabelPenjualanValue)
        Me.PanelPenjualan.Controls.Add(Me.LabelPenjualanInfo)
        Me.PanelPenjualan.Location = New System.Drawing.Point(502, 130)
        Me.PanelPenjualan.Name = "PanelPenjualan"
        Me.PanelPenjualan.Size = New System.Drawing.Size(205, 105)

        Me.LabelPenjualanIcon.BackColor = System.Drawing.Color.FromArgb(35, 166, 75)
        Me.LabelPenjualanIcon.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelPenjualanIcon.ForeColor = System.Drawing.Color.White
        Me.LabelPenjualanIcon.Location = New System.Drawing.Point(16, 28)
        Me.LabelPenjualanIcon.Size = New System.Drawing.Size(48, 48)
        Me.LabelPenjualanIcon.Text = "$"
        Me.LabelPenjualanIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelPenjualanTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.LabelPenjualanTitle.Location = New System.Drawing.Point(78, 18)
        Me.LabelPenjualanTitle.Size = New System.Drawing.Size(125, 24)
        Me.LabelPenjualanTitle.Text = "PENJUALAN HARI INI"
        Me.LabelPenjualanValue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelPenjualanValue.Location = New System.Drawing.Point(78, 44)
        Me.LabelPenjualanValue.Size = New System.Drawing.Size(125, 30)
        Me.LabelPenjualanValue.Text = "Rp 5.250.000"
        Me.LabelPenjualanInfo.Location = New System.Drawing.Point(78, 74)
        Me.LabelPenjualanInfo.Size = New System.Drawing.Size(125, 22)
        Me.LabelPenjualanInfo.Text = "Total Penjualan"

        Me.PanelPelanggan.BackColor = System.Drawing.Color.White
        Me.PanelPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelPelanggan.Controls.Add(Me.LabelPelangganIcon)
        Me.PanelPelanggan.Controls.Add(Me.LabelPelangganTitle)
        Me.PanelPelanggan.Controls.Add(Me.LabelPelangganValue)
        Me.PanelPelanggan.Controls.Add(Me.LabelPelangganInfo)
        Me.PanelPelanggan.Location = New System.Drawing.Point(734, 130)
        Me.PanelPelanggan.Name = "PanelPelanggan"
        Me.PanelPelanggan.Size = New System.Drawing.Size(205, 105)

        Me.LabelPelangganIcon.BackColor = System.Drawing.Color.FromArgb(145, 85, 230)
        Me.LabelPelangganIcon.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelPelangganIcon.ForeColor = System.Drawing.Color.White
        Me.LabelPelangganIcon.Location = New System.Drawing.Point(16, 28)
        Me.LabelPelangganIcon.Size = New System.Drawing.Size(48, 48)
        Me.LabelPelangganIcon.Text = "P"
        Me.LabelPelangganIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelPelangganTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.LabelPelangganTitle.Location = New System.Drawing.Point(78, 18)
        Me.LabelPelangganTitle.Size = New System.Drawing.Size(125, 24)
        Me.LabelPelangganTitle.Text = "TOTAL PELANGGAN"
        Me.LabelPelangganValue.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelPelangganValue.Location = New System.Drawing.Point(78, 42)
        Me.LabelPelangganValue.Size = New System.Drawing.Size(125, 32)
        Me.LabelPelangganValue.Text = "125"
        Me.LabelPelangganInfo.Location = New System.Drawing.Point(78, 74)
        Me.LabelPelangganInfo.Size = New System.Drawing.Size(125, 22)
        Me.LabelPelangganInfo.Text = "Pelanggan"

        '
        'PanelGrafik
        '
        Me.PanelGrafik.BackColor = System.Drawing.Color.White
        Me.PanelGrafik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelGrafik.Controls.Add(Me.LabelGrafikTitle)
        Me.PanelGrafik.Controls.Add(Me.LabelGrafik1)
        Me.PanelGrafik.Controls.Add(Me.LabelGrafik2)
        Me.PanelGrafik.Controls.Add(Me.LabelGrafik3)
        Me.PanelGrafik.Controls.Add(Me.LabelGrafik4)
        Me.PanelGrafik.Controls.Add(Me.LabelGrafik5)
        Me.PanelGrafik.Controls.Add(Me.LabelGrafikTanggal)
        Me.PanelGrafik.Location = New System.Drawing.Point(38, 260)
        Me.PanelGrafik.Name = "PanelGrafik"
        Me.PanelGrafik.Size = New System.Drawing.Size(455, 245)

        Me.LabelGrafikTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelGrafikTitle.Location = New System.Drawing.Point(18, 18)
        Me.LabelGrafikTitle.Size = New System.Drawing.Size(300, 25)
        Me.LabelGrafikTitle.Text = "Grafik Penjualan 7 Hari Terakhir"

        Me.LabelGrafik1.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelGrafik1.ForeColor = System.Drawing.Color.FromArgb(0, 102, 255)
        Me.LabelGrafik1.Location = New System.Drawing.Point(25, 60)
        Me.LabelGrafik1.Size = New System.Drawing.Size(390, 22)
        Me.LabelGrafik1.Text = "8.000.000 |                         *"

        Me.LabelGrafik2.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelGrafik2.ForeColor = System.Drawing.Color.FromArgb(0, 102, 255)
        Me.LabelGrafik2.Location = New System.Drawing.Point(25, 85)
        Me.LabelGrafik2.Size = New System.Drawing.Size(390, 22)
        Me.LabelGrafik2.Text = "6.000.000 |                 *      /"

        Me.LabelGrafik3.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelGrafik3.ForeColor = System.Drawing.Color.FromArgb(0, 102, 255)
        Me.LabelGrafik3.Location = New System.Drawing.Point(25, 110)
        Me.LabelGrafik3.Size = New System.Drawing.Size(390, 22)
        Me.LabelGrafik3.Text = "4.000.000 |      *----*    / \   *"

        Me.LabelGrafik4.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelGrafik4.ForeColor = System.Drawing.Color.FromArgb(0, 102, 255)
        Me.LabelGrafik4.Location = New System.Drawing.Point(25, 135)
        Me.LabelGrafik4.Size = New System.Drawing.Size(390, 22)
        Me.LabelGrafik4.Text = "2.000.000 | *---/      \--*"

        Me.LabelGrafik5.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelGrafik5.ForeColor = System.Drawing.Color.FromArgb(0, 102, 255)
        Me.LabelGrafik5.Location = New System.Drawing.Point(25, 160)
        Me.LabelGrafik5.Size = New System.Drawing.Size(390, 22)
        Me.LabelGrafik5.Text = "        0 +------------------------"

        Me.LabelGrafikTanggal.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.LabelGrafikTanggal.Location = New System.Drawing.Point(35, 190)
        Me.LabelGrafikTanggal.Size = New System.Drawing.Size(400, 25)
        Me.LabelGrafikTanggal.Text = "16/05     17/05     18/05     19/05     20/05     21/05     22/05"

        '
        'PanelTopProduk
        '
        Me.PanelTopProduk.BackColor = System.Drawing.Color.White
        Me.PanelTopProduk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTopProduk.Controls.Add(Me.LabelTopProdukTitle)
        Me.PanelTopProduk.Controls.Add(Me.TableTopProduk)
        Me.PanelTopProduk.Location = New System.Drawing.Point(515, 260)
        Me.PanelTopProduk.Name = "PanelTopProduk"
        Me.PanelTopProduk.Size = New System.Drawing.Size(420, 245)

        Me.LabelTopProdukTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTopProdukTitle.Location = New System.Drawing.Point(18, 18)
        Me.LabelTopProdukTitle.Size = New System.Drawing.Size(250, 25)
        Me.LabelTopProdukTitle.Text = "Top 5 Produk Terlaris"

        Me.TableTopProduk.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single
        Me.TableTopProduk.ColumnCount = 3
        Me.TableTopProduk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableTopProduk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableTopProduk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableTopProduk.Location = New System.Drawing.Point(18, 58)
        Me.TableTopProduk.Name = "TableTopProduk"
        Me.TableTopProduk.RowCount = 6
        Me.TableTopProduk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableTopProduk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableTopProduk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableTopProduk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableTopProduk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableTopProduk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableTopProduk.Size = New System.Drawing.Size(380, 165)
        Me.TableTopProduk.TabIndex = 0

        Me.TableTopProduk.Controls.Add(New System.Windows.Forms.Label() With {.Text = "No", .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter, .Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)}, 0, 0)
        Me.TableTopProduk.Controls.Add(New System.Windows.Forms.Label() With {.Text = "Nama Barang", .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleLeft, .Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)}, 1, 0)
        Me.TableTopProduk.Controls.Add(New System.Windows.Forms.Label() With {.Text = "Terjual", .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter, .Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)}, 2, 0)

        Me.TableTopProduk.Controls.Add(New System.Windows.Forms.Label() With {.Text = "1", .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter}, 0, 1)
        Me.TableTopProduk.Controls.Add(New System.Windows.Forms.Label() With {.Text = "Kemeja Formal", .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleLeft}, 1, 1)
        Me.TableTopProduk.Controls.Add(New System.Windows.Forms.Label() With {.Text = "45", .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter}, 2, 1)

        Me.TableTopProduk.Controls.Add(New System.Windows.Forms.Label() With {.Text = "2", .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter}, 0, 2)
        Me.TableTopProduk.Controls.Add(New System.Windows.Forms.Label() With {.Text = "Kaos Polos Pria", .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleLeft}, 1, 2)
        Me.TableTopProduk.Controls.Add(New System.Windows.Forms.Label() With {.Text = "40", .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter}, 2, 2)

        Me.TableTopProduk.Controls.Add(New System.Windows.Forms.Label() With {.Text = "3", .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter}, 0, 3)
        Me.TableTopProduk.Controls.Add(New System.Windows.Forms.Label() With {.Text = "Celana Chino", .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleLeft}, 1, 3)
        Me.TableTopProduk.Controls.Add(New System.Windows.Forms.Label() With {.Text = "32", .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter}, 2, 3)

        Me.TableTopProduk.Controls.Add(New System.Windows.Forms.Label() With {.Text = "4", .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter}, 0, 4)
        Me.TableTopProduk.Controls.Add(New System.Windows.Forms.Label() With {.Text = "Polo Shirt", .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleLeft}, 1, 4)
        Me.TableTopProduk.Controls.Add(New System.Windows.Forms.Label() With {.Text = "28", .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter}, 2, 4)

        Me.TableTopProduk.Controls.Add(New System.Windows.Forms.Label() With {.Text = "5", .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter}, 0, 5)
        Me.TableTopProduk.Controls.Add(New System.Windows.Forms.Label() With {.Text = "Jaket Bomber", .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleLeft}, 1, 5)
        Me.TableTopProduk.Controls.Add(New System.Windows.Forms.Label() With {.Text = "22", .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter}, 2, 5)

        '
        'PanelNotifikasi
        '
        Me.PanelNotifikasi.BackColor = System.Drawing.Color.White
        Me.PanelNotifikasi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelNotifikasi.Controls.Add(Me.LabelNotifikasiTitle)
        Me.PanelNotifikasi.Controls.Add(Me.LabelNotif1)
        Me.PanelNotifikasi.Controls.Add(Me.LabelNotif2)
        Me.PanelNotifikasi.Controls.Add(Me.LabelNotif3)
        Me.PanelNotifikasi.Location = New System.Drawing.Point(38, 525)
        Me.PanelNotifikasi.Name = "PanelNotifikasi"
        Me.PanelNotifikasi.Size = New System.Drawing.Size(455, 160)

        Me.LabelNotifikasiTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelNotifikasiTitle.Location = New System.Drawing.Point(18, 16)
        Me.LabelNotifikasiTitle.Size = New System.Drawing.Size(200, 25)
        Me.LabelNotifikasiTitle.Text = "Notifikasi"

        Me.LabelNotif1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelNotif1.ForeColor = System.Drawing.Color.Red
        Me.LabelNotif1.Location = New System.Drawing.Point(22, 55)
        Me.LabelNotif1.Size = New System.Drawing.Size(390, 25)
        Me.LabelNotif1.Text = "- 18 produk dengan stok menipis"

        Me.LabelNotif2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelNotif2.Location = New System.Drawing.Point(22, 85)
        Me.LabelNotif2.Size = New System.Drawing.Size(390, 25)
        Me.LabelNotif2.Text = "- 2 pesanan pembelian belum diterima"

        Me.LabelNotif3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelNotif3.Location = New System.Drawing.Point(22, 115)
        Me.LabelNotif3.Size = New System.Drawing.Size(410, 25)
        Me.LabelNotif3.Text = "- Backup data terakhir: 22/05/2024 08:00"

        '
        'PanelInfo
        '
        Me.PanelInfo.BackColor = System.Drawing.Color.White
        Me.PanelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelInfo.Controls.Add(Me.LabelInfoTitle)
        Me.PanelInfo.Controls.Add(Me.LabelInfoUser)
        Me.PanelInfo.Controls.Add(Me.LabelInfoLevel)
        Me.PanelInfo.Controls.Add(Me.LabelInfoVersi)
        Me.PanelInfo.Location = New System.Drawing.Point(515, 525)
        Me.PanelInfo.Name = "PanelInfo"
        Me.PanelInfo.Size = New System.Drawing.Size(420, 160)

        Me.LabelInfoTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelInfoTitle.ForeColor = System.Drawing.Color.FromArgb(20, 50, 110)
        Me.LabelInfoTitle.Location = New System.Drawing.Point(18, 16)
        Me.LabelInfoTitle.Size = New System.Drawing.Size(250, 25)
        Me.LabelInfoTitle.Text = "Informasi Sistem"

        Me.LabelInfoUser.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelInfoUser.Location = New System.Drawing.Point(22, 55)
        Me.LabelInfoUser.Size = New System.Drawing.Size(350, 25)
        Me.LabelInfoUser.Text = "User Aktif              :   admin"

        Me.LabelInfoLevel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelInfoLevel.Location = New System.Drawing.Point(22, 85)
        Me.LabelInfoLevel.Size = New System.Drawing.Size(350, 25)
        Me.LabelInfoLevel.Text = "Level                   :   Administrator"

        Me.LabelInfoVersi.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelInfoVersi.Location = New System.Drawing.Point(22, 115)
        Me.LabelInfoVersi.Size = New System.Drawing.Size(350, 25)
        Me.LabelInfoVersi.Text = "Versi Aplikasi          :   1.0.0.0"

        '
        'Controls
        '
        Me.Controls.Add(Me.PanelContent)
        Me.Controls.Add(Me.PanelSidebar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1

        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelSidebar.ResumeLayout(False)
        Me.PanelContent.ResumeLayout(False)
        Me.PanelProduk.ResumeLayout(False)
        Me.PanelStok.ResumeLayout(False)
        Me.PanelPenjualan.ResumeLayout(False)
        Me.PanelPelanggan.ResumeLayout(False)
        Me.PanelGrafik.ResumeLayout(False)
        Me.PanelTopProduk.ResumeLayout(False)
        Me.PanelNotifikasi.ResumeLayout(False)
        Me.PanelInfo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

End Class