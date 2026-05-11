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

    ' Area Faux Chart (Grafik Buatan)
    Friend WithEvents pnlChartBox As System.Windows.Forms.Panel
    Friend WithEvents lblChartTitle As System.Windows.Forms.Label
    ' Label Sumbu Y
    Friend WithEvents lblY8 As System.Windows.Forms.Label
    Friend WithEvents lblY6 As System.Windows.Forms.Label
    Friend WithEvents lblY4 As System.Windows.Forms.Label
    Friend WithEvents lblY2 As System.Windows.Forms.Label
    Friend WithEvents lblY0 As System.Windows.Forms.Label
    ' Label Sumbu X
    Friend WithEvents lblX1 As System.Windows.Forms.Label
    Friend WithEvents lblX2 As System.Windows.Forms.Label
    Friend WithEvents lblX3 As System.Windows.Forms.Label
    Friend WithEvents lblX4 As System.Windows.Forms.Label
    Friend WithEvents lblX5 As System.Windows.Forms.Label
    Friend WithEvents lblX6 As System.Windows.Forms.Label
    ' Bar Grafik
    Friend WithEvents pnlBar1 As System.Windows.Forms.Panel
    Friend WithEvents pnlBar2 As System.Windows.Forms.Panel
    Friend WithEvents pnlBar3 As System.Windows.Forms.Panel
    Friend WithEvents pnlBar4 As System.Windows.Forms.Panel
    Friend WithEvents pnlBar5 As System.Windows.Forms.Panel
    Friend WithEvents pnlBar6 As System.Windows.Forms.Panel

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
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        pnlChartBox = New Panel()
        pnlBar6 = New Panel()
        pnlBar5 = New Panel()
        pnlBar4 = New Panel()
        pnlBar3 = New Panel()
        pnlBar2 = New Panel()
        pnlBar1 = New Panel()
        lblX6 = New Label()
        lblX5 = New Label()
        lblX4 = New Label()
        lblX3 = New Label()
        lblX2 = New Label()
        lblX1 = New Label()
        lblY0 = New Label()
        lblY2 = New Label()
        lblY4 = New Label()
        lblY6 = New Label()
        lblY8 = New Label()
        lblChartTitle = New Label()
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
        pnlChartBox.SuspendLayout()
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
        tabPenjualan.Controls.Add(pnlChartBox)
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
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        colTanggal.DefaultCellStyle = DataGridViewCellStyle5
        colTanggal.HeaderText = "Tanggal"
        colTanggal.MinimumWidth = 6
        colTanggal.Name = "colTanggal"
        colTanggal.Width = 140
        ' 
        ' colTotalTransaksi
        ' 
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        colTotalTransaksi.DefaultCellStyle = DataGridViewCellStyle6
        colTotalTransaksi.HeaderText = "Total Transaksi"
        colTotalTransaksi.MinimumWidth = 6
        colTotalTransaksi.Name = "colTotalTransaksi"
        colTotalTransaksi.Width = 150
        ' 
        ' colTotalPenjualan
        ' 
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        colTotalPenjualan.DefaultCellStyle = DataGridViewCellStyle7
        colTotalPenjualan.HeaderText = "Total Penjualan"
        colTotalPenjualan.MinimumWidth = 6
        colTotalPenjualan.Name = "colTotalPenjualan"
        colTotalPenjualan.Width = 180
        ' 
        ' colLabaKotor
        ' 
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        colLabaKotor.DefaultCellStyle = DataGridViewCellStyle8
        colLabaKotor.HeaderText = "Laba Kotor"
        colLabaKotor.MinimumWidth = 6
        colLabaKotor.Name = "colLabaKotor"
        colLabaKotor.Width = 175
        ' 
        ' pnlChartBox
        ' 
        pnlChartBox.BorderStyle = BorderStyle.FixedSingle
        pnlChartBox.Controls.Add(pnlBar6)
        pnlChartBox.Controls.Add(pnlBar5)
        pnlChartBox.Controls.Add(pnlBar4)
        pnlChartBox.Controls.Add(pnlBar3)
        pnlChartBox.Controls.Add(pnlBar2)
        pnlChartBox.Controls.Add(pnlBar1)
        pnlChartBox.Controls.Add(lblX6)
        pnlChartBox.Controls.Add(lblX5)
        pnlChartBox.Controls.Add(lblX4)
        pnlChartBox.Controls.Add(lblX3)
        pnlChartBox.Controls.Add(lblX2)
        pnlChartBox.Controls.Add(lblX1)
        pnlChartBox.Controls.Add(lblY0)
        pnlChartBox.Controls.Add(lblY2)
        pnlChartBox.Controls.Add(lblY4)
        pnlChartBox.Controls.Add(lblY6)
        pnlChartBox.Controls.Add(lblY8)
        pnlChartBox.Controls.Add(lblChartTitle)
        pnlChartBox.Location = New Point(303, 20)
        pnlChartBox.Margin = New Padding(3, 4, 3, 4)
        pnlChartBox.Name = "pnlChartBox"
        pnlChartBox.Size = New Size(457, 226)
        pnlChartBox.TabIndex = 2
        ' 
        ' pnlBar6
        ' 
        pnlBar6.BackColor = Color.FromArgb(CByte(30), CByte(90), CByte(170))
        pnlBar6.Location = New Point(343, 53)
        pnlBar6.Margin = New Padding(3, 4, 3, 4)
        pnlBar6.Name = "pnlBar6"
        pnlBar6.Size = New Size(29, 127)
        pnlBar6.TabIndex = 0
        ' 
        ' pnlBar5
        ' 
        pnlBar5.BackColor = Color.FromArgb(CByte(30), CByte(90), CByte(170))
        pnlBar5.Location = New Point(286, 87)
        pnlBar5.Margin = New Padding(3, 4, 3, 4)
        pnlBar5.Name = "pnlBar5"
        pnlBar5.Size = New Size(29, 93)
        pnlBar5.TabIndex = 1
        ' 
        ' pnlBar4
        ' 
        pnlBar4.BackColor = Color.FromArgb(CByte(30), CByte(90), CByte(170))
        pnlBar4.Location = New Point(229, 113)
        pnlBar4.Margin = New Padding(3, 4, 3, 4)
        pnlBar4.Name = "pnlBar4"
        pnlBar4.Size = New Size(29, 67)
        pnlBar4.TabIndex = 2
        ' 
        ' pnlBar3
        ' 
        pnlBar3.BackColor = Color.FromArgb(CByte(30), CByte(90), CByte(170))
        pnlBar3.Location = New Point(171, 107)
        pnlBar3.Margin = New Padding(3, 4, 3, 4)
        pnlBar3.Name = "pnlBar3"
        pnlBar3.Size = New Size(29, 73)
        pnlBar3.TabIndex = 3
        ' 
        ' pnlBar2
        ' 
        pnlBar2.BackColor = Color.FromArgb(CByte(30), CByte(90), CByte(170))
        pnlBar2.Location = New Point(114, 140)
        pnlBar2.Margin = New Padding(3, 4, 3, 4)
        pnlBar2.Name = "pnlBar2"
        pnlBar2.Size = New Size(29, 40)
        pnlBar2.TabIndex = 4
        ' 
        ' pnlBar1
        ' 
        pnlBar1.BackColor = Color.FromArgb(CByte(30), CByte(90), CByte(170))
        pnlBar1.Location = New Point(57, 127)
        pnlBar1.Margin = New Padding(3, 4, 3, 4)
        pnlBar1.Name = "pnlBar1"
        pnlBar1.Size = New Size(29, 53)
        pnlBar1.TabIndex = 5
        ' 
        ' lblX6
        ' 
        lblX6.AutoSize = True
        lblX6.Font = New Font("Segoe UI", 8F)
        lblX6.Location = New Point(337, 187)
        lblX6.Name = "lblX6"
        lblX6.Size = New Size(46, 19)
        lblX6.TabIndex = 6
        lblX6.Text = "22/05"
        ' 
        ' lblX5
        ' 
        lblX5.AutoSize = True
        lblX5.Font = New Font("Segoe UI", 8F)
        lblX5.Location = New Point(280, 187)
        lblX5.Name = "lblX5"
        lblX5.Size = New Size(46, 19)
        lblX5.TabIndex = 7
        lblX5.Text = "21/05"
        ' 
        ' lblX4
        ' 
        lblX4.AutoSize = True
        lblX4.Font = New Font("Segoe UI", 8F)
        lblX4.Location = New Point(223, 187)
        lblX4.Name = "lblX4"
        lblX4.Size = New Size(46, 19)
        lblX4.TabIndex = 8
        lblX4.Text = "20/05"
        ' 
        ' lblX3
        ' 
        lblX3.AutoSize = True
        lblX3.Font = New Font("Segoe UI", 8F)
        lblX3.Location = New Point(166, 187)
        lblX3.Name = "lblX3"
        lblX3.Size = New Size(46, 19)
        lblX3.TabIndex = 9
        lblX3.Text = "18/05"
        ' 
        ' lblX2
        ' 
        lblX2.AutoSize = True
        lblX2.Font = New Font("Segoe UI", 8F)
        lblX2.Location = New Point(109, 187)
        lblX2.Name = "lblX2"
        lblX2.Size = New Size(46, 19)
        lblX2.TabIndex = 10
        lblX2.Text = "17/05"
        ' 
        ' lblX1
        ' 
        lblX1.AutoSize = True
        lblX1.Font = New Font("Segoe UI", 8F)
        lblX1.Location = New Point(51, 187)
        lblX1.Name = "lblX1"
        lblX1.Size = New Size(46, 19)
        lblX1.TabIndex = 11
        lblX1.Text = "16/05"
        ' 
        ' lblY0
        ' 
        lblY0.AutoSize = True
        lblY0.Font = New Font("Segoe UI", 8F)
        lblY0.Location = New Point(23, 180)
        lblY0.Name = "lblY0"
        lblY0.Size = New Size(17, 19)
        lblY0.TabIndex = 12
        lblY0.Text = "0"
        ' 
        ' lblY2
        ' 
        lblY2.AutoSize = True
        lblY2.Font = New Font("Segoe UI", 8F)
        lblY2.Location = New Point(11, 147)
        lblY2.Name = "lblY2"
        lblY2.Size = New Size(29, 19)
        lblY2.TabIndex = 13
        lblY2.Text = "2 jt"
        ' 
        ' lblY4
        ' 
        lblY4.AutoSize = True
        lblY4.Font = New Font("Segoe UI", 8F)
        lblY4.Location = New Point(11, 113)
        lblY4.Name = "lblY4"
        lblY4.Size = New Size(29, 19)
        lblY4.TabIndex = 14
        lblY4.Text = "4 jt"
        ' 
        ' lblY6
        ' 
        lblY6.AutoSize = True
        lblY6.Font = New Font("Segoe UI", 8F)
        lblY6.Location = New Point(11, 80)
        lblY6.Name = "lblY6"
        lblY6.Size = New Size(29, 19)
        lblY6.TabIndex = 15
        lblY6.Text = "6 jt"
        ' 
        ' lblY8
        ' 
        lblY8.AutoSize = True
        lblY8.Font = New Font("Segoe UI", 8F)
        lblY8.Location = New Point(11, 47)
        lblY8.Name = "lblY8"
        lblY8.Size = New Size(29, 19)
        lblY8.TabIndex = 16
        lblY8.Text = "8 jt"
        ' 
        ' lblChartTitle
        ' 
        lblChartTitle.AutoSize = True
        lblChartTitle.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblChartTitle.Location = New Point(11, 13)
        lblChartTitle.Name = "lblChartTitle"
        lblChartTitle.Size = New Size(137, 20)
        lblChartTitle.TabIndex = 17
        lblChartTitle.Text = "Penjualan per Hari"
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        btnTampilkan.FlatAppearance.BorderColor = Color.Silver
        btnTampilkan.FlatStyle = FlatStyle.Flat
        btnTampilkan.Location = New Point(166, 160)
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
        dtpSampai.Size = New Size(148, 27)
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
        dtpDari.Size = New Size(148, 27)
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
        pnlChartBox.ResumeLayout(False)
        pnlChartBox.PerformLayout()
        ResumeLayout(False)

    End Sub
End Class