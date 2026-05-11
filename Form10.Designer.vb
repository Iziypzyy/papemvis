<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form10
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()

        Me.tabControlLaporan = New System.Windows.Forms.TabControl()
        Me.tabPenjualan = New System.Windows.Forms.TabPage()
        Me.tabStok = New System.Windows.Forms.TabPage()
        Me.tabPembelian = New System.Windows.Forms.TabPage()

        Me.lblFilter = New System.Windows.Forms.Label()
        Me.lblGarisFilter = New System.Windows.Forms.Label()
        Me.lblDariTanggal = New System.Windows.Forms.Label()
        Me.dtpDari = New System.Windows.Forms.DateTimePicker()
        Me.lblSampaiTanggal = New System.Windows.Forms.Label()
        Me.dtpSampai = New System.Windows.Forms.DateTimePicker()
        Me.btnTampilkan = New System.Windows.Forms.Button()

        Me.pnlChartBox = New System.Windows.Forms.Panel()
        Me.lblChartTitle = New System.Windows.Forms.Label()
        Me.lblY8 = New System.Windows.Forms.Label()
        Me.lblY6 = New System.Windows.Forms.Label()
        Me.lblY4 = New System.Windows.Forms.Label()
        Me.lblY2 = New System.Windows.Forms.Label()
        Me.lblY0 = New System.Windows.Forms.Label()
        Me.lblX1 = New System.Windows.Forms.Label()
        Me.lblX2 = New System.Windows.Forms.Label()
        Me.lblX3 = New System.Windows.Forms.Label()
        Me.lblX4 = New System.Windows.Forms.Label()
        Me.lblX5 = New System.Windows.Forms.Label()
        Me.lblX6 = New System.Windows.Forms.Label()
        Me.pnlBar1 = New System.Windows.Forms.Panel()
        Me.pnlBar2 = New System.Windows.Forms.Panel()
        Me.pnlBar3 = New System.Windows.Forms.Panel()
        Me.pnlBar4 = New System.Windows.Forms.Panel()
        Me.pnlBar5 = New System.Windows.Forms.Panel()
        Me.pnlBar6 = New System.Windows.Forms.Panel()

        Me.dgvLaporan = New System.Windows.Forms.DataGridView()
        Me.colTanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalTransaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalPenjualan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLabaKotor = New System.Windows.Forms.DataGridViewTextBoxColumn()

        Me.pnlTotal = New System.Windows.Forms.Panel()
        Me.lblTeksTotal = New System.Windows.Forms.Label()
        Me.lblTotalTransaksi = New System.Windows.Forms.Label()
        Me.lblTotalPenjualan = New System.Windows.Forms.Label()
        Me.lblTotalLaba = New System.Windows.Forms.Label()

        Me.tabControlLaporan.SuspendLayout()
        Me.tabPenjualan.SuspendLayout()
        Me.pnlChartBox.SuspendLayout()
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTotal.SuspendLayout()
        Me.SuspendLayout()

        ' 
        ' tabControlLaporan
        ' 
        Me.tabControlLaporan.Controls.Add(Me.tabPenjualan)
        Me.tabControlLaporan.Controls.Add(Me.tabStok)
        Me.tabControlLaporan.Controls.Add(Me.tabPembelian)
        Me.tabControlLaporan.Location = New System.Drawing.Point(15, 15)
        Me.tabControlLaporan.Name = "tabControlLaporan"
        Me.tabControlLaporan.SelectedIndex = 0
        Me.tabControlLaporan.Size = New System.Drawing.Size(690, 520)

        ' 
        ' tabPenjualan
        ' 
        Me.tabPenjualan.BackColor = System.Drawing.Color.White
        Me.tabPenjualan.Controls.Add(Me.pnlTotal)
        Me.tabPenjualan.Controls.Add(Me.dgvLaporan)
        Me.tabPenjualan.Controls.Add(Me.pnlChartBox)
        Me.tabPenjualan.Controls.Add(Me.btnTampilkan)
        Me.tabPenjualan.Controls.Add(Me.dtpSampai)
        Me.tabPenjualan.Controls.Add(Me.lblSampaiTanggal)
        Me.tabPenjualan.Controls.Add(Me.dtpDari)
        Me.tabPenjualan.Controls.Add(Me.lblDariTanggal)
        Me.tabPenjualan.Controls.Add(Me.lblGarisFilter)
        Me.tabPenjualan.Controls.Add(Me.lblFilter)
        Me.tabPenjualan.Location = New System.Drawing.Point(4, 24)
        Me.tabPenjualan.Name = "tabPenjualan"
        Me.tabPenjualan.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPenjualan.Size = New System.Drawing.Size(682, 492)
        Me.tabPenjualan.Text = "Laporan Penjualan"

        ' tabStok & tabPembelian
        Me.tabStok.Text = "Laporan Stok"
        Me.tabStok.BackColor = System.Drawing.Color.White
        Me.tabPembelian.Text = "Laporan Pembelian"
        Me.tabPembelian.BackColor = System.Drawing.Color.White

        ' 
        ' FILTER AREA
        ' 
        Me.lblFilter.AutoSize = True
        Me.lblFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFilter.Location = New System.Drawing.Point(15, 15)
        Me.lblFilter.Text = "Filter"

        Me.lblGarisFilter.BackColor = System.Drawing.Color.LightGray
        Me.lblGarisFilter.Location = New System.Drawing.Point(15, 35)
        Me.lblGarisFilter.Size = New System.Drawing.Size(230, 1)

        Me.lblDariTanggal.AutoSize = True
        Me.lblDariTanggal.Location = New System.Drawing.Point(15, 50)
        Me.lblDariTanggal.Text = "Dari Tanggal"

        Me.dtpDari.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpDari.Location = New System.Drawing.Point(115, 47)
        Me.dtpDari.Size = New System.Drawing.Size(130, 23)

        Me.lblSampaiTanggal.AutoSize = True
        Me.lblSampaiTanggal.Location = New System.Drawing.Point(15, 85)
        Me.lblSampaiTanggal.Text = "Sampai Tanggal"

        Me.dtpSampai.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpSampai.Location = New System.Drawing.Point(115, 82)
        Me.dtpSampai.Size = New System.Drawing.Size(130, 23)

        Me.btnTampilkan.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.btnTampilkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTampilkan.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnTampilkan.Location = New System.Drawing.Point(145, 120)
        Me.btnTampilkan.Size = New System.Drawing.Size(100, 30)
        Me.btnTampilkan.Text = "🔍 Tampilkan"
        Me.btnTampilkan.UseVisualStyleBackColor = False

        ' 
        ' CHART AREA (FAUX CHART)
        ' 
        Me.pnlChartBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlChartBox.Controls.Add(Me.pnlBar6)
        Me.pnlChartBox.Controls.Add(Me.pnlBar5)
        Me.pnlChartBox.Controls.Add(Me.pnlBar4)
        Me.pnlChartBox.Controls.Add(Me.pnlBar3)
        Me.pnlChartBox.Controls.Add(Me.pnlBar2)
        Me.pnlChartBox.Controls.Add(Me.pnlBar1)
        Me.pnlChartBox.Controls.Add(Me.lblX6)
        Me.pnlChartBox.Controls.Add(Me.lblX5)
        Me.pnlChartBox.Controls.Add(Me.lblX4)
        Me.pnlChartBox.Controls.Add(Me.lblX3)
        Me.pnlChartBox.Controls.Add(Me.lblX2)
        Me.pnlChartBox.Controls.Add(Me.lblX1)
        Me.pnlChartBox.Controls.Add(Me.lblY0)
        Me.pnlChartBox.Controls.Add(Me.lblY2)
        Me.pnlChartBox.Controls.Add(Me.lblY4)
        Me.pnlChartBox.Controls.Add(Me.lblY6)
        Me.pnlChartBox.Controls.Add(Me.lblY8)
        Me.pnlChartBox.Controls.Add(Me.lblChartTitle)
        Me.pnlChartBox.Location = New System.Drawing.Point(265, 15)
        Me.pnlChartBox.Size = New System.Drawing.Size(400, 170)

        Me.lblChartTitle.AutoSize = True
        Me.lblChartTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblChartTitle.Location = New System.Drawing.Point(10, 10)
        Me.lblChartTitle.Text = "Penjualan per Hari"

        ' Sumbu Y Labels
        Dim yFont As Font = New Font("Segoe UI", 8.0!)
        Me.lblY8.Font = yFont : Me.lblY8.Text = "8 jt" : Me.lblY8.Location = New Point(10, 35) : Me.lblY8.AutoSize = True
        Me.lblY6.Font = yFont : Me.lblY6.Text = "6 jt" : Me.lblY6.Location = New Point(10, 60) : Me.lblY6.AutoSize = True
        Me.lblY4.Font = yFont : Me.lblY4.Text = "4 jt" : Me.lblY4.Location = New Point(10, 85) : Me.lblY4.AutoSize = True
        Me.lblY2.Font = yFont : Me.lblY2.Text = "2 jt" : Me.lblY2.Location = New Point(10, 110) : Me.lblY2.AutoSize = True
        Me.lblY0.Font = yFont : Me.lblY0.Text = "0" : Me.lblY0.Location = New Point(20, 135) : Me.lblY0.AutoSize = True

        ' Sumbu X Labels
        Me.lblX1.Font = yFont : Me.lblX1.Text = "16/05" : Me.lblX1.Location = New Point(45, 140) : Me.lblX1.AutoSize = True
        Me.lblX2.Font = yFont : Me.lblX2.Text = "17/05" : Me.lblX2.Location = New Point(95, 140) : Me.lblX2.AutoSize = True
        Me.lblX3.Font = yFont : Me.lblX3.Text = "18/05" : Me.lblX3.Location = New Point(145, 140) : Me.lblX3.AutoSize = True
        Me.lblX4.Font = yFont : Me.lblX4.Text = "20/05" : Me.lblX4.Location = New Point(195, 140) : Me.lblX4.AutoSize = True
        Me.lblX5.Font = yFont : Me.lblX5.Text = "21/05" : Me.lblX5.Location = New Point(245, 140) : Me.lblX5.AutoSize = True
        Me.lblX6.Font = yFont : Me.lblX6.Text = "22/05" : Me.lblX6.Location = New Point(295, 140) : Me.lblX6.AutoSize = True

        ' Bars (Balok Grafik Warna Biru)
        Dim barColor As Color = Color.FromArgb(30, 90, 170)
        Me.pnlBar1.BackColor = barColor : Me.pnlBar1.Location = New Point(50, 95) : Me.pnlBar1.Size = New Size(25, 40)
        Me.pnlBar2.BackColor = barColor : Me.pnlBar2.Location = New Point(100, 105) : Me.pnlBar2.Size = New Size(25, 30)
        Me.pnlBar3.BackColor = barColor : Me.pnlBar3.Location = New Point(150, 80) : Me.pnlBar3.Size = New Size(25, 55)
        Me.pnlBar4.BackColor = barColor : Me.pnlBar4.Location = New Point(200, 85) : Me.pnlBar4.Size = New Size(25, 50)
        Me.pnlBar5.BackColor = barColor : Me.pnlBar5.Location = New Point(250, 65) : Me.pnlBar5.Size = New Size(25, 70)
        Me.pnlBar6.BackColor = barColor : Me.pnlBar6.Location = New Point(300, 40) : Me.pnlBar6.Size = New Size(25, 95)

        ' 
        ' DATAGRIDVIEW
        ' 
        Me.dgvLaporan.AllowUserToAddRows = False
        Me.dgvLaporan.BackgroundColor = System.Drawing.Color.White
        Me.dgvLaporan.ColumnHeadersHeight = 35
        Me.dgvLaporan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTanggal, Me.colTotalTransaksi, Me.colTotalPenjualan, Me.colLabaKotor})
        Me.dgvLaporan.Location = New System.Drawing.Point(15, 200)
        Me.dgvLaporan.Name = "dgvLaporan"
        Me.dgvLaporan.RowHeadersVisible = False
        Me.dgvLaporan.Size = New System.Drawing.Size(650, 230)

        Me.colTanggal.HeaderText = "Tanggal"
        Me.colTanggal.Width = 140
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colTanggal.DefaultCellStyle = DataGridViewCellStyle1

        Me.colTotalTransaksi.HeaderText = "Total Transaksi"
        Me.colTotalTransaksi.Width = 150
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colTotalTransaksi.DefaultCellStyle = DataGridViewCellStyle2

        Me.colTotalPenjualan.HeaderText = "Total Penjualan"
        Me.colTotalPenjualan.Width = 180
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colTotalPenjualan.DefaultCellStyle = DataGridViewCellStyle3

        Me.colLabaKotor.HeaderText = "Laba Kotor"
        Me.colLabaKotor.Width = 175
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colLabaKotor.DefaultCellStyle = DataGridViewCellStyle4

        ' 
        ' SUMMARY PANEL (Total Bawah)
        ' 
        Me.pnlTotal.BackColor = System.Drawing.Color.White
        Me.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTotal.Controls.Add(Me.lblTeksTotal)
        Me.pnlTotal.Controls.Add(Me.lblTotalTransaksi)
        Me.pnlTotal.Controls.Add(Me.lblTotalPenjualan)
        Me.pnlTotal.Controls.Add(Me.lblTotalLaba)
        Me.pnlTotal.Location = New System.Drawing.Point(15, 429)
        Me.pnlTotal.Size = New System.Drawing.Size(650, 45)

        Dim boldFont As Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)

        Me.lblTeksTotal.AutoSize = True
        Me.lblTeksTotal.Font = boldFont
        Me.lblTeksTotal.Location = New System.Drawing.Point(15, 13)
        Me.lblTeksTotal.Text = "Total"

        Me.lblTotalTransaksi.Font = boldFont
        Me.lblTotalTransaksi.Location = New System.Drawing.Point(140, 13)
        Me.lblTotalTransaksi.Size = New System.Drawing.Size(150, 20)
        Me.lblTotalTransaksi.Text = "30"
        Me.lblTotalTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        Me.lblTotalPenjualan.Font = boldFont
        Me.lblTotalPenjualan.Location = New System.Drawing.Point(290, 13)
        Me.lblTotalPenjualan.Size = New System.Drawing.Size(180, 20)
        Me.lblTotalPenjualan.Text = "13.000.000"
        Me.lblTotalPenjualan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        Me.lblTotalLaba.Font = boldFont
        Me.lblTotalLaba.Location = New System.Drawing.Point(470, 13)
        Me.lblTotalLaba.Size = New System.Drawing.Size(175, 20)
        Me.lblTotalLaba.Text = "5.280.000"
        Me.lblTotalLaba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

        ' 
        ' Form10
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(245, 245, 250)
        Me.ClientSize = New System.Drawing.Size(720, 550)
        Me.Controls.Add(Me.tabControlLaporan)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular)
        Me.Name = "Form10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "10. Laporan (Reports)"

        Me.tabControlLaporan.ResumeLayout(False)
        Me.tabPenjualan.ResumeLayout(False)
        Me.tabPenjualan.PerformLayout()
        Me.pnlChartBox.ResumeLayout(False)
        Me.pnlChartBox.PerformLayout()
        CType(Me.dgvLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTotal.ResumeLayout(False)
        Me.pnlTotal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
End Class