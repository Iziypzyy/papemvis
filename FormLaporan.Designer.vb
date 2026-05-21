<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLaporan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    '--- DEKLARASI KONTROL ---
    Friend WithEvents tabControlLaporan As System.Windows.Forms.TabControl
    Friend WithEvents tabPenjualan As System.Windows.Forms.TabPage
    Friend WithEvents tabStok As System.Windows.Forms.TabPage
    Friend WithEvents tabPembelian As System.Windows.Forms.TabPage

    ' Area Filter
    Friend WithEvents lblFilter As System.Windows.Forms.Label
    Friend WithEvents lblGarisFilter As System.Windows.Forms.Label
    Friend WithEvents lblDariTanggal As System.Windows.Forms.Label
    Friend WithEvents dtpDari As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSampaiTanggal As System.Windows.Forms.Label
    Friend WithEvents dtpSampai As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnTampilkan As System.Windows.Forms.Button

    ' Area Data Grid
    Friend WithEvents dgvLaporan As System.Windows.Forms.DataGridView
    Friend WithEvents colTanggal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotalTransaksi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotalPenjualan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLabaKotor As System.Windows.Forms.DataGridViewTextBoxColumn

    ' Area Summary Bawah
    Friend WithEvents pnlTotal As System.Windows.Forms.Panel
    Friend WithEvents lblTeksTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotalTransaksi As System.Windows.Forms.Label
    Friend WithEvents lblTotalPenjualan As System.Windows.Forms.Label
    Friend WithEvents lblTotalLaba As System.Windows.Forms.Label

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        tabControlLaporan = New TabControl()
        tabPenjualan = New TabPage()
        pnlTotal = New Panel()
        lblTeksTotal = New Label()
        lblTotalTransaksi = New Label()
        lblTotalPenjualan = New Label()
        lblTotalLaba = New Label()
        dgvLaporan = New DataGridView()
        colTanggal = New DataGridViewTextBoxColumn()
        colTotalTransaksi = New DataGridViewTextBoxColumn()
        colTotalPenjualan = New DataGridViewTextBoxColumn()
        colLabaKotor = New DataGridViewTextBoxColumn()
        btnTampilkan = New Button()
        dtpSampai = New DateTimePicker()
        lblSampaiTanggal = New Label()
        dtpDari = New DateTimePicker()
        lblDariTanggal = New Label()
        lblGarisFilter = New Label()
        lblFilter = New Label()
        tabStok = New TabPage()
        tabPembelian = New TabPage()
        tabControlLaporan.SuspendLayout()
        tabPenjualan.SuspendLayout()
        pnlTotal.SuspendLayout()
        CType(dgvLaporan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tabControlLaporan
        ' 
        tabControlLaporan.Controls.Add(tabPenjualan)
        tabControlLaporan.Controls.Add(tabStok)
        tabControlLaporan.Controls.Add(tabPembelian)
        tabControlLaporan.Location = New Point(17, 20)
        tabControlLaporan.Margin = New Padding(3, 4, 3, 4)
        tabControlLaporan.Name = "tabControlLaporan"
        tabControlLaporan.SelectedIndex = 0
        tabControlLaporan.Size = New Size(789, 693)
        tabControlLaporan.TabIndex = 0
        ' 
        ' tabPenjualan
        ' 
        tabPenjualan.BackColor = Color.White
        tabPenjualan.Controls.Add(pnlTotal)
        tabPenjualan.Controls.Add(dgvLaporan)
        tabPenjualan.Controls.Add(btnTampilkan)
        tabPenjualan.Controls.Add(dtpSampai)
        tabPenjualan.Controls.Add(lblSampaiTanggal)
        tabPenjualan.Controls.Add(dtpDari)
        tabPenjualan.Controls.Add(lblDariTanggal)
        tabPenjualan.Controls.Add(lblGarisFilter)
        tabPenjualan.Controls.Add(lblFilter)
        tabPenjualan.Location = New Point(4, 29)
        tabPenjualan.Margin = New Padding(3, 4, 3, 4)
        tabPenjualan.Name = "tabPenjualan"
        tabPenjualan.Padding = New Padding(3, 4, 3, 4)
        tabPenjualan.Size = New Size(781, 660)
        tabPenjualan.TabIndex = 0
        tabPenjualan.Text = "Laporan Penjualan"
        ' 
        ' pnlTotal
        ' 
        pnlTotal.BackColor = Color.White
        pnlTotal.BorderStyle = BorderStyle.FixedSingle
        pnlTotal.Controls.Add(lblTeksTotal)
        pnlTotal.Controls.Add(lblTotalTransaksi)
        pnlTotal.Controls.Add(lblTotalPenjualan)
        pnlTotal.Controls.Add(lblTotalLaba)
        pnlTotal.Location = New Point(17, 572)
        pnlTotal.Margin = New Padding(3, 4, 3, 4)
        pnlTotal.Name = "pnlTotal"
        pnlTotal.Size = New Size(743, 59)
        pnlTotal.TabIndex = 0
        ' 
        ' lblTeksTotal
        ' 
        lblTeksTotal.AutoSize = True
        lblTeksTotal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTeksTotal.Location = New Point(17, 17)
        lblTeksTotal.Name = "lblTeksTotal"
        lblTeksTotal.Size = New Size(44, 20)
        lblTeksTotal.TabIndex = 0
        lblTeksTotal.Text = "Total"
        ' 
        ' lblTotalTransaksi
        ' 
        lblTotalTransaksi.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTotalTransaksi.Location = New Point(160, 17)
        lblTotalTransaksi.Name = "lblTotalTransaksi"
        lblTotalTransaksi.Size = New Size(171, 27)
        lblTotalTransaksi.TabIndex = 1
        lblTotalTransaksi.Text = "30"
        lblTotalTransaksi.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTotalPenjualan
        ' 
        lblTotalPenjualan.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTotalPenjualan.Location = New Point(331, 17)
        lblTotalPenjualan.Name = "lblTotalPenjualan"
        lblTotalPenjualan.Size = New Size(206, 27)
        lblTotalPenjualan.TabIndex = 2
        lblTotalPenjualan.Text = "13.000.000"
        lblTotalPenjualan.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTotalLaba
        ' 
        lblTotalLaba.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTotalLaba.Location = New Point(537, 17)
        lblTotalLaba.Name = "lblTotalLaba"
        lblTotalLaba.Size = New Size(200, 27)
        lblTotalLaba.TabIndex = 3
        lblTotalLaba.Text = "5.280.000"
        lblTotalLaba.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dgvLaporan
        ' 
        dgvLaporan.AllowUserToAddRows = False
        dgvLaporan.BackgroundColor = Color.White
        dgvLaporan.ColumnHeadersHeight = 35
        dgvLaporan.Columns.AddRange(New DataGridViewColumn() {colTanggal, colTotalTransaksi, colTotalPenjualan, colLabaKotor})
        dgvLaporan.Location = New Point(17, 267)
        dgvLaporan.Margin = New Padding(3, 4, 3, 4)
        dgvLaporan.Name = "dgvLaporan"
        dgvLaporan.RowHeadersVisible = False
        dgvLaporan.RowHeadersWidth = 51
        dgvLaporan.Size = New Size(743, 307)
        dgvLaporan.TabIndex = 1
        ' 
        ' colTanggal
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        colTanggal.DefaultCellStyle = DataGridViewCellStyle1
        colTanggal.HeaderText = "Tanggal"
        colTanggal.MinimumWidth = 6
        colTanggal.Name = "colTanggal"
        colTanggal.Width = 140
        ' 
        ' colTotalTransaksi
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        colTotalTransaksi.DefaultCellStyle = DataGridViewCellStyle2
        colTotalTransaksi.HeaderText = "Total Transaksi"
        colTotalTransaksi.MinimumWidth = 6
        colTotalTransaksi.Name = "colTotalTransaksi"
        colTotalTransaksi.Width = 150
        ' 
        ' colTotalPenjualan
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        colTotalPenjualan.DefaultCellStyle = DataGridViewCellStyle3
        colTotalPenjualan.HeaderText = "Total Penjualan"
        colTotalPenjualan.MinimumWidth = 6
        colTotalPenjualan.Name = "colTotalPenjualan"
        colTotalPenjualan.Width = 180
        ' 
        ' colLabaKotor
        ' 
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        colLabaKotor.DefaultCellStyle = DataGridViewCellStyle4
        colLabaKotor.HeaderText = "Laba Kotor"
        colLabaKotor.MinimumWidth = 6
        colLabaKotor.Name = "colLabaKotor"
        colLabaKotor.Width = 175
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        btnTampilkan.FlatAppearance.BorderColor = Color.Silver
        btnTampilkan.FlatStyle = FlatStyle.Flat
        btnTampilkan.Location = New Point(252, 161)
        btnTampilkan.Margin = New Padding(3, 4, 3, 4)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(114, 40)
        btnTampilkan.TabIndex = 3
        btnTampilkan.Text = "🔍 Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = False
        ' 
        ' dtpSampai
        ' 
        dtpSampai.Format = DateTimePickerFormat.Short
        dtpSampai.Location = New Point(131, 109)
        dtpSampai.Margin = New Padding(3, 4, 3, 4)
        dtpSampai.Name = "dtpSampai"
        dtpSampai.Size = New Size(235, 27)
        dtpSampai.TabIndex = 4
        ' 
        ' lblSampaiTanggal
        ' 
        lblSampaiTanggal.AutoSize = True
        lblSampaiTanggal.Location = New Point(17, 113)
        lblSampaiTanggal.Name = "lblSampaiTanggal"
        lblSampaiTanggal.Size = New Size(115, 20)
        lblSampaiTanggal.TabIndex = 5
        lblSampaiTanggal.Text = "Sampai Tanggal"
        ' 
        ' dtpDari
        ' 
        dtpDari.Format = DateTimePickerFormat.Short
        dtpDari.Location = New Point(131, 63)
        dtpDari.Margin = New Padding(3, 4, 3, 4)
        dtpDari.Name = "dtpDari"
        dtpDari.Size = New Size(235, 27)
        dtpDari.TabIndex = 6
        ' 
        ' lblDariTanggal
        ' 
        lblDariTanggal.AutoSize = True
        lblDariTanggal.Location = New Point(17, 67)
        lblDariTanggal.Name = "lblDariTanggal"
        lblDariTanggal.Size = New Size(93, 20)
        lblDariTanggal.TabIndex = 7
        lblDariTanggal.Text = "Dari Tanggal"
        ' 
        ' lblGarisFilter
        ' 
        lblGarisFilter.BackColor = Color.LightGray
        lblGarisFilter.Location = New Point(17, 47)
        lblGarisFilter.Name = "lblGarisFilter"
        lblGarisFilter.Size = New Size(263, 1)
        lblGarisFilter.TabIndex = 8
        ' 
        ' lblFilter
        ' 
        lblFilter.AutoSize = True
        lblFilter.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblFilter.Location = New Point(17, 20)
        lblFilter.Name = "lblFilter"
        lblFilter.Size = New Size(45, 20)
        lblFilter.TabIndex = 9
        lblFilter.Text = "Filter"
        ' 
        ' tabStok
        ' 
        tabStok.BackColor = Color.White
        tabStok.Location = New Point(4, 29)
        tabStok.Margin = New Padding(3, 4, 3, 4)
        tabStok.Name = "tabStok"
        tabStok.Size = New Size(781, 660)
        tabStok.TabIndex = 1
        tabStok.Text = "Laporan Stok"
        ' 
        ' tabPembelian
        ' 
        tabPembelian.BackColor = Color.White
        tabPembelian.Location = New Point(4, 29)
        tabPembelian.Margin = New Padding(3, 4, 3, 4)
        tabPembelian.Name = "tabPembelian"
        tabPembelian.Size = New Size(781, 660)
        tabPembelian.TabIndex = 2
        tabPembelian.Text = "Laporan Pembelian"
        ' 
        ' FormLaporan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(250))
        ClientSize = New Size(823, 733)
        Controls.Add(tabControlLaporan)
        Font = New Font("Segoe UI", 9F)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormLaporan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Laporan"
        tabControlLaporan.ResumeLayout(False)
        tabPenjualan.ResumeLayout(False)
        tabPenjualan.PerformLayout()
        pnlTotal.ResumeLayout(False)
        pnlTotal.PerformLayout()
        CType(dgvLaporan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub
End Class