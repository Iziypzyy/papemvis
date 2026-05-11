<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblNoTransaksi = New System.Windows.Forms.Label()
        Me.TxtNoTransaksi = New System.Windows.Forms.TextBox()
        Me.LblKasir = New System.Windows.Forms.Label()
        Me.TxtKasir = New System.Windows.Forms.TextBox()
        Me.LblTanggal = New System.Windows.Forms.Label()
        Me.DtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.LblNamaPelanggan = New System.Windows.Forms.Label()
        Me.CboPelanggan = New System.Windows.Forms.ComboBox()
        Me.BtnCariPelanggan = New System.Windows.Forms.Button()
        Me.LblKodeBarang = New System.Windows.Forms.Label()
        Me.CboBarang = New System.Windows.Forms.ComboBox()
        Me.BtnCariBarang = New System.Windows.Forms.Button()
        Me.LblQty = New System.Windows.Forms.Label()
        Me.NudQty = New System.Windows.Forms.NumericUpDown()
        Me.LblHarga = New System.Windows.Forms.Label()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.LblSubTotalItem = New System.Windows.Forms.Label()
        Me.TxtSubTotalItem = New System.Windows.Forms.TextBox()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.BtnPlus = New System.Windows.Forms.Button()
        Me.DgvKeranjang = New System.Windows.Forms.DataGridView()
        Me.ColNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColKodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlSummary = New System.Windows.Forms.Panel()
        Me.LblTotalItem = New System.Windows.Forms.Label()
        Me.LblTotalItemVal = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.LblTotalVal = New System.Windows.Forms.Label()
        Me.LblDiskon = New System.Windows.Forms.Label()
        Me.TxtDiskon = New System.Windows.Forms.TextBox()
        Me.LblGrandTotal = New System.Windows.Forms.Label()
        Me.LblGrandTotalVal = New System.Windows.Forms.Label()
        Me.BtnProses = New System.Windows.Forms.Button()
        Me.BtnCetak = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        CType(Me.NudQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvKeranjang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlSummary.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblNoTransaksi
        '
        Me.LblNoTransaksi.AutoSize = True
        Me.LblNoTransaksi.Location = New System.Drawing.Point(20, 22)
        Me.LblNoTransaksi.Name = "LblNoTransaksi"
        Me.LblNoTransaksi.Size = New System.Drawing.Size(76, 15)
        Me.LblNoTransaksi.TabIndex = 0
        Me.LblNoTransaksi.Text = "No Transaksi"
        '
        'TxtNoTransaksi
        '
        Me.TxtNoTransaksi.Location = New System.Drawing.Point(140, 19)
        Me.TxtNoTransaksi.Name = "TxtNoTransaksi"
        Me.TxtNoTransaksi.ReadOnly = True
        Me.TxtNoTransaksi.Size = New System.Drawing.Size(180, 23)
        Me.TxtNoTransaksi.TabIndex = 1
        Me.TxtNoTransaksi.Text = "TRS2405220001"
        '
        'LblKasir
        '
        Me.LblKasir.AutoSize = True
        Me.LblKasir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblKasir.Location = New System.Drawing.Point(540, 22)
        Me.LblKasir.Name = "LblKasir"
        Me.LblKasir.Size = New System.Drawing.Size(35, 15)
        Me.LblKasir.TabIndex = 2
        Me.LblKasir.Text = "Kasir"
        '
        'TxtKasir
        '
        Me.TxtKasir.Location = New System.Drawing.Point(590, 19)
        Me.TxtKasir.Name = "TxtKasir"
        Me.TxtKasir.ReadOnly = True
        Me.TxtKasir.Size = New System.Drawing.Size(180, 23)
        Me.TxtKasir.TabIndex = 3
        Me.TxtKasir.Text = "admin"
        '
        'LblTanggal
        '
        Me.LblTanggal.AutoSize = True
        Me.LblTanggal.Location = New System.Drawing.Point(20, 56)
        Me.LblTanggal.Name = "LblTanggal"
        Me.LblTanggal.Size = New System.Drawing.Size(48, 15)
        Me.LblTanggal.TabIndex = 4
        Me.LblTanggal.Text = "Tanggal"
        '
        'DtpTanggal
        '
        Me.DtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpTanggal.Location = New System.Drawing.Point(140, 53)
        Me.DtpTanggal.Name = "DtpTanggal"
        Me.DtpTanggal.Size = New System.Drawing.Size(130, 23)
        Me.DtpTanggal.TabIndex = 5
        '
        'LblNamaPelanggan
        '
        Me.LblNamaPelanggan.AutoSize = True
        Me.LblNamaPelanggan.Location = New System.Drawing.Point(20, 90)
        Me.LblNamaPelanggan.Name = "LblNamaPelanggan"
        Me.LblNamaPelanggan.Size = New System.Drawing.Size(98, 15)
        Me.LblNamaPelanggan.TabIndex = 6
        Me.LblNamaPelanggan.Text = "Nama Pelanggan"
        '
        'CboPelanggan
        '
        Me.CboPelanggan.FormattingEnabled = True
        Me.CboPelanggan.Location = New System.Drawing.Point(140, 87)
        Me.CboPelanggan.Name = "CboPelanggan"
        Me.CboPelanggan.Size = New System.Drawing.Size(220, 23)
        Me.CboPelanggan.TabIndex = 7
        Me.CboPelanggan.Text = "PLG001 - Andi Setiawan"
        '
        'BtnCariPelanggan
        '
        Me.BtnCariPelanggan.Location = New System.Drawing.Point(366, 86)
        Me.BtnCariPelanggan.Name = "BtnCariPelanggan"
        Me.BtnCariPelanggan.Size = New System.Drawing.Size(35, 25)
        Me.BtnCariPelanggan.TabIndex = 8
        Me.BtnCariPelanggan.Text = "..."
        Me.BtnCariPelanggan.UseVisualStyleBackColor = True
        '
        'LblKodeBarang
        '
        Me.LblKodeBarang.AutoSize = True
        Me.LblKodeBarang.Location = New System.Drawing.Point(20, 130)
        Me.LblKodeBarang.Name = "LblKodeBarang"
        Me.LblKodeBarang.Size = New System.Drawing.Size(74, 15)
        Me.LblKodeBarang.TabIndex = 9
        Me.LblKodeBarang.Text = "Kode Barang"
        '
        'CboBarang
        '
        Me.CboBarang.FormattingEnabled = True
        Me.CboBarang.Location = New System.Drawing.Point(20, 150)
        Me.CboBarang.Name = "CboBarang"
        Me.CboBarang.Size = New System.Drawing.Size(200, 23)
        Me.CboBarang.TabIndex = 10
        Me.CboBarang.Text = "BRG001 - Kemeja Formal"
        '
        'BtnCariBarang
        '
        Me.BtnCariBarang.Location = New System.Drawing.Point(226, 149)
        Me.BtnCariBarang.Name = "BtnCariBarang"
        Me.BtnCariBarang.Size = New System.Drawing.Size(35, 25)
        Me.BtnCariBarang.TabIndex = 11
        Me.BtnCariBarang.Text = "..."
        Me.BtnCariBarang.UseVisualStyleBackColor = True
        '
        'LblQty
        '
        Me.LblQty.AutoSize = True
        Me.LblQty.Location = New System.Drawing.Point(275, 130)
        Me.LblQty.Name = "LblQty"
        Me.LblQty.Size = New System.Drawing.Size(26, 15)
        Me.LblQty.TabIndex = 12
        Me.LblQty.Text = "Qty"
        '
        'NudQty
        '
        Me.NudQty.Location = New System.Drawing.Point(275, 150)
        Me.NudQty.Name = "NudQty"
        Me.NudQty.Size = New System.Drawing.Size(50, 23)
        Me.NudQty.TabIndex = 13
        Me.NudQty.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'LblHarga
        '
        Me.LblHarga.AutoSize = True
        Me.LblHarga.Location = New System.Drawing.Point(340, 130)
        Me.LblHarga.Name = "LblHarga"
        Me.LblHarga.Size = New System.Drawing.Size(39, 15)
        Me.LblHarga.TabIndex = 14
        Me.LblHarga.Text = "Harga"
        '
        'TxtHarga
        '
        Me.TxtHarga.Location = New System.Drawing.Point(340, 150)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.ReadOnly = True
        Me.TxtHarga.Size = New System.Drawing.Size(100, 23)
        Me.TxtHarga.TabIndex = 15
        Me.TxtHarga.Text = "150.000"
        Me.TxtHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblSubTotalItem
        '
        Me.LblSubTotalItem.AutoSize = True
        Me.LblSubTotalItem.Location = New System.Drawing.Point(455, 130)
        Me.LblSubTotalItem.Name = "LblSubTotalItem"
        Me.LblSubTotalItem.Size = New System.Drawing.Size(55, 15)
        Me.LblSubTotalItem.TabIndex = 16
        Me.LblSubTotalItem.Text = "Sub Total"
        '
        'TxtSubTotalItem
        '
        Me.TxtSubTotalItem.Location = New System.Drawing.Point(455, 150)
        Me.TxtSubTotalItem.Name = "TxtSubTotalItem"
        Me.TxtSubTotalItem.ReadOnly = True
        Me.TxtSubTotalItem.Size = New System.Drawing.Size(100, 23)
        Me.TxtSubTotalItem.TabIndex = 17
        Me.TxtSubTotalItem.Text = "300.000"
        Me.TxtSubTotalItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnMin
        '
        Me.BtnMin.Location = New System.Drawing.Point(565, 149)
        Me.BtnMin.Name = "BtnMin"
        Me.BtnMin.Size = New System.Drawing.Size(30, 25)
        Me.BtnMin.TabIndex = 18
        Me.BtnMin.Text = "-"
        Me.BtnMin.UseVisualStyleBackColor = True
        '
        'BtnPlus
        '
        Me.BtnPlus.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnPlus.FlatAppearance.BorderSize = 0
        Me.BtnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPlus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnPlus.ForeColor = System.Drawing.Color.White
        Me.BtnPlus.Location = New System.Drawing.Point(600, 149)
        Me.BtnPlus.Name = "BtnPlus"
        Me.BtnPlus.Size = New System.Drawing.Size(35, 25)
        Me.BtnPlus.TabIndex = 19
        Me.BtnPlus.Text = "+"
        Me.BtnPlus.UseVisualStyleBackColor = False
        '
        'DgvKeranjang
        '
        Me.DgvKeranjang.AllowUserToAddRows = False
        Me.DgvKeranjang.AllowUserToDeleteRows = False
        Me.DgvKeranjang.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvKeranjang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvKeranjang.ColumnHeadersHeight = 30
        Me.DgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvKeranjang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColNo, Me.ColKodeBarang, Me.ColNamaBarang, Me.ColQty, Me.ColHarga, Me.ColSubTotal})
        Me.DgvKeranjang.EnableHeadersVisualStyles = False
        Me.DgvKeranjang.Location = New System.Drawing.Point(20, 190)
        Me.DgvKeranjang.Name = "DgvKeranjang"
        Me.DgvKeranjang.ReadOnly = True
        Me.DgvKeranjang.RowHeadersVisible = False
        Me.DgvKeranjang.RowTemplate.Height = 25
        Me.DgvKeranjang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvKeranjang.Size = New System.Drawing.Size(500, 180)
        Me.DgvKeranjang.TabIndex = 20
        '
        'ColNo
        '
        Me.ColNo.HeaderText = "No"
        Me.ColNo.Name = "ColNo"
        Me.ColNo.ReadOnly = True
        Me.ColNo.Width = 40
        '
        'ColKodeBarang
        '
        Me.ColKodeBarang.HeaderText = "Kode Barang"
        Me.ColKodeBarang.Name = "ColKodeBarang"
        Me.ColKodeBarang.ReadOnly = True
        Me.ColKodeBarang.Width = 90
        '
        'ColNamaBarang
        '
        Me.ColNamaBarang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColNamaBarang.HeaderText = "Nama Barang"
        Me.ColNamaBarang.Name = "ColNamaBarang"
        Me.ColNamaBarang.ReadOnly = True
        '
        'ColQty
        '
        Me.ColQty.HeaderText = "Qty"
        Me.ColQty.Name = "ColQty"
        Me.ColQty.ReadOnly = True
        Me.ColQty.Width = 40
        '
        'ColHarga
        '
        Me.ColHarga.HeaderText = "Harga"
        Me.ColHarga.Name = "ColHarga"
        Me.ColHarga.ReadOnly = True
        Me.ColHarga.Width = 80
        '
        'ColSubTotal
        '
        Me.ColSubTotal.HeaderText = "Sub Total"
        Me.ColSubTotal.Name = "ColSubTotal"
        Me.ColSubTotal.ReadOnly = True
        Me.ColSubTotal.Width = 80
        '
        'PnlSummary
        '
        Me.PnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlSummary.Controls.Add(Me.LblTotalItem)
        Me.PnlSummary.Controls.Add(Me.LblTotalItemVal)
        Me.PnlSummary.Controls.Add(Me.LblTotal)
        Me.PnlSummary.Controls.Add(Me.LblTotalVal)
        Me.PnlSummary.Controls.Add(Me.LblDiskon)
        Me.PnlSummary.Controls.Add(Me.TxtDiskon)
        Me.PnlSummary.Controls.Add(Me.LblGrandTotal)
        Me.PnlSummary.Controls.Add(Me.LblGrandTotalVal)
        Me.PnlSummary.Location = New System.Drawing.Point(535, 190)
        Me.PnlSummary.Name = "PnlSummary"
        Me.PnlSummary.Size = New System.Drawing.Size(235, 180)
        Me.PnlSummary.TabIndex = 21
        '
        'LblTotalItem
        '
        Me.LblTotalItem.AutoSize = True
        Me.LblTotalItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTotalItem.Location = New System.Drawing.Point(15, 20)
        Me.LblTotalItem.Name = "LblTotalItem"
        Me.LblTotalItem.Size = New System.Drawing.Size(63, 15)
        Me.LblTotalItem.TabIndex = 0
        Me.LblTotalItem.Text = "Total Item"
        '
        'LblTotalItemVal
        '
        Me.LblTotalItemVal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTotalItemVal.Location = New System.Drawing.Point(115, 20)
        Me.LblTotalItemVal.Name = "LblTotalItemVal"
        Me.LblTotalItemVal.Size = New System.Drawing.Size(100, 15)
        Me.LblTotalItemVal.TabIndex = 1
        Me.LblTotalItemVal.Text = "4"
        Me.LblTotalItemVal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTotal.Location = New System.Drawing.Point(15, 60)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(34, 15)
        Me.LblTotal.TabIndex = 2
        Me.LblTotal.Text = "Total"
        '
        'LblTotalVal
        '
        Me.LblTotalVal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTotalVal.Location = New System.Drawing.Point(115, 60)
        Me.LblTotalVal.Name = "LblTotalVal"
        Me.LblTotalVal.Size = New System.Drawing.Size(100, 15)
        Me.LblTotalVal.TabIndex = 3
        Me.LblTotalVal.Text = "600.000"
        Me.LblTotalVal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblDiskon
        '
        Me.LblDiskon.AutoSize = True
        Me.LblDiskon.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblDiskon.Location = New System.Drawing.Point(15, 100)
        Me.LblDiskon.Name = "LblDiskon"
        Me.LblDiskon.Size = New System.Drawing.Size(45, 15)
        Me.LblDiskon.TabIndex = 4
        Me.LblDiskon.Text = "Diskon"
        '
        'TxtDiskon
        '
        Me.TxtDiskon.Location = New System.Drawing.Point(115, 97)
        Me.TxtDiskon.Name = "TxtDiskon"
        Me.TxtDiskon.Size = New System.Drawing.Size(100, 23)
        Me.TxtDiskon.TabIndex = 5
        Me.TxtDiskon.Text = "0"
        Me.TxtDiskon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblGrandTotal
        '
        Me.LblGrandTotal.AutoSize = True
        Me.LblGrandTotal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblGrandTotal.Location = New System.Drawing.Point(15, 140)
        Me.LblGrandTotal.Name = "LblGrandTotal"
        Me.LblGrandTotal.Size = New System.Drawing.Size(73, 15)
        Me.LblGrandTotal.TabIndex = 6
        Me.LblGrandTotal.Text = "Grand Total"
        '
        'LblGrandTotalVal
        '
        Me.LblGrandTotalVal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblGrandTotalVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.LblGrandTotalVal.Location = New System.Drawing.Point(115, 137)
        Me.LblGrandTotalVal.Name = "LblGrandTotalVal"
        Me.LblGrandTotalVal.Size = New System.Drawing.Size(100, 20)
        Me.LblGrandTotalVal.TabIndex = 7
        Me.LblGrandTotalVal.Text = "600.000"
        Me.LblGrandTotalVal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BtnProses
        '
        Me.BtnProses.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnProses.FlatAppearance.BorderSize = 0
        Me.BtnProses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProses.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnProses.ForeColor = System.Drawing.Color.White
        Me.BtnProses.Location = New System.Drawing.Point(180, 400)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(120, 40)
        Me.BtnProses.TabIndex = 22
        Me.BtnProses.Text = "Proses"
        Me.BtnProses.UseVisualStyleBackColor = False
        '
        'BtnCetak
        '
        Me.BtnCetak.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnCetak.FlatAppearance.BorderSize = 0
        Me.BtnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCetak.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnCetak.ForeColor = System.Drawing.Color.White
        Me.BtnCetak.Location = New System.Drawing.Point(320, 400)
        Me.BtnCetak.Name = "BtnCetak"
        Me.BtnCetak.Size = New System.Drawing.Size(120, 40)
        Me.BtnCetak.TabIndex = 23
        Me.BtnCetak.Text = "Cetak Struk"
        Me.BtnCetak.UseVisualStyleBackColor = False
        '
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnBatal.FlatAppearance.BorderSize = 0
        Me.BtnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBatal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnBatal.ForeColor = System.Drawing.Color.White
        Me.BtnBatal.Location = New System.Drawing.Point(460, 400)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(120, 40)
        Me.BtnBatal.TabIndex = 24
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(790, 460)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnCetak)
        Me.Controls.Add(Me.BtnProses)
        Me.Controls.Add(Me.PnlSummary)
        Me.Controls.Add(Me.DgvKeranjang)
        Me.Controls.Add(Me.BtnPlus)
        Me.Controls.Add(Me.BtnMin)
        Me.Controls.Add(Me.TxtSubTotalItem)
        Me.Controls.Add(Me.LblSubTotalItem)
        Me.Controls.Add(Me.TxtHarga)
        Me.Controls.Add(Me.LblHarga)
        Me.Controls.Add(Me.NudQty)
        Me.Controls.Add(Me.LblQty)
        Me.Controls.Add(Me.BtnCariBarang)
        Me.Controls.Add(Me.CboBarang)
        Me.Controls.Add(Me.LblKodeBarang)
        Me.Controls.Add(Me.BtnCariPelanggan)
        Me.Controls.Add(Me.CboPelanggan)
        Me.Controls.Add(Me.LblNamaPelanggan)
        Me.Controls.Add(Me.DtpTanggal)
        Me.Controls.Add(Me.LblTanggal)
        Me.Controls.Add(Me.TxtKasir)
        Me.Controls.Add(Me.LblKasir)
        Me.Controls.Add(Me.TxtNoTransaksi)
        Me.Controls.Add(Me.LblNoTransaksi)
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi Penjualan"
        CType(Me.NudQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvKeranjang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlSummary.ResumeLayout(False)
        Me.PnlSummary.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNoTransaksi As System.Windows.Forms.Label
    Friend WithEvents TxtNoTransaksi As System.Windows.Forms.TextBox
    Friend WithEvents LblKasir As System.Windows.Forms.Label
    Friend WithEvents TxtKasir As System.Windows.Forms.TextBox
    Friend WithEvents LblTanggal As System.Windows.Forms.Label
    Friend WithEvents DtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblNamaPelanggan As System.Windows.Forms.Label
    Friend WithEvents CboPelanggan As System.Windows.Forms.ComboBox
    Friend WithEvents BtnCariPelanggan As System.Windows.Forms.Button
    Friend WithEvents LblKodeBarang As System.Windows.Forms.Label
    Friend WithEvents CboBarang As System.Windows.Forms.ComboBox
    Friend WithEvents BtnCariBarang As System.Windows.Forms.Button
    Friend WithEvents LblQty As System.Windows.Forms.Label
    Friend WithEvents NudQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents LblHarga As System.Windows.Forms.Label
    Friend WithEvents TxtHarga As System.Windows.Forms.TextBox
    Friend WithEvents LblSubTotalItem As System.Windows.Forms.Label
    Friend WithEvents TxtSubTotalItem As System.Windows.Forms.TextBox
    Friend WithEvents BtnMin As System.Windows.Forms.Button
    Friend WithEvents BtnPlus As System.Windows.Forms.Button
    Friend WithEvents DgvKeranjang As System.Windows.Forms.DataGridView
    Friend WithEvents ColNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColKodeBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColNamaBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColHarga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColSubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PnlSummary As System.Windows.Forms.Panel
    Friend WithEvents LblTotalItem As System.Windows.Forms.Label
    Friend WithEvents LblTotalItemVal As System.Windows.Forms.Label
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents LblTotalVal As System.Windows.Forms.Label
    Friend WithEvents LblDiskon As System.Windows.Forms.Label
    Friend WithEvents TxtDiskon As System.Windows.Forms.TextBox
    Friend WithEvents LblGrandTotal As System.Windows.Forms.Label
    Friend WithEvents LblGrandTotalVal As System.Windows.Forms.Label
    Friend WithEvents BtnProses As System.Windows.Forms.Button
    Friend WithEvents BtnCetak As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
End Class