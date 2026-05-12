<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransaksiPenjualan
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        LblNoTransaksi = New Label()
        TxtNoTransaksi = New TextBox()
        LblKasir = New Label()
        TxtKasir = New TextBox()
        LblTanggal = New Label()
        DtpTanggal = New DateTimePicker()
        LblNamaPelanggan = New Label()
        CboPelanggan = New ComboBox()
        BtnCariPelanggan = New Button()
        LblKodeBarang = New Label()
        CboBarang = New ComboBox()
        BtnCariBarang = New Button()
        LblQty = New Label()
        NudQty = New NumericUpDown()
        LblHarga = New Label()
        TxtHarga = New TextBox()
        LblSubTotalItem = New Label()
        TxtSubTotalItem = New TextBox()
        BtnMin = New Button()
        BtnPlus = New Button()
        DgvKeranjang = New DataGridView()
        ColNo = New DataGridViewTextBoxColumn()
        ColKodeBarang = New DataGridViewTextBoxColumn()
        ColNamaBarang = New DataGridViewTextBoxColumn()
        ColQty = New DataGridViewTextBoxColumn()
        ColHarga = New DataGridViewTextBoxColumn()
        ColSubTotal = New DataGridViewTextBoxColumn()
        PnlSummary = New Panel()
        LblTotalItem = New Label()
        LblTotalItemVal = New Label()
        LblTotal = New Label()
        LblTotalVal = New Label()
        LblDiskon = New Label()
        TxtDiskon = New TextBox()
        LblGrandTotal = New Label()
        LblGrandTotalVal = New Label()
        BtnProses = New Button()
        BtnCetak = New Button()
        BtnBatal = New Button()
        CType(NudQty, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgvKeranjang, ComponentModel.ISupportInitialize).BeginInit()
        PnlSummary.SuspendLayout()
        SuspendLayout()
        ' 
        ' LblNoTransaksi
        ' 
        LblNoTransaksi.AutoSize = True
        LblNoTransaksi.Location = New Point(23, 29)
        LblNoTransaksi.Name = "LblNoTransaksi"
        LblNoTransaksi.Size = New Size(92, 20)
        LblNoTransaksi.TabIndex = 0
        LblNoTransaksi.Text = "No Transaksi"
        ' 
        ' TxtNoTransaksi
        ' 
        TxtNoTransaksi.Location = New Point(160, 25)
        TxtNoTransaksi.Margin = New Padding(3, 4, 3, 4)
        TxtNoTransaksi.Name = "TxtNoTransaksi"
        TxtNoTransaksi.ReadOnly = True
        TxtNoTransaksi.Size = New Size(205, 27)
        TxtNoTransaksi.TabIndex = 1
        TxtNoTransaksi.Text = "TRS2405220001"
        ' 
        ' LblKasir
        ' 
        LblKasir.AutoSize = True
        LblKasir.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblKasir.Location = New Point(617, 29)
        LblKasir.Name = "LblKasir"
        LblKasir.Size = New Size(44, 20)
        LblKasir.TabIndex = 2
        LblKasir.Text = "Kasir"
        ' 
        ' TxtKasir
        ' 
        TxtKasir.Location = New Point(674, 25)
        TxtKasir.Margin = New Padding(3, 4, 3, 4)
        TxtKasir.Name = "TxtKasir"
        TxtKasir.ReadOnly = True
        TxtKasir.Size = New Size(205, 27)
        TxtKasir.TabIndex = 3
        TxtKasir.Text = "admin"
        ' 
        ' LblTanggal
        ' 
        LblTanggal.AutoSize = True
        LblTanggal.Location = New Point(23, 75)
        LblTanggal.Name = "LblTanggal"
        LblTanggal.Size = New Size(61, 20)
        LblTanggal.TabIndex = 4
        LblTanggal.Text = "Tanggal"
        ' 
        ' DtpTanggal
        ' 
        DtpTanggal.Format = DateTimePickerFormat.Short
        DtpTanggal.Location = New Point(160, 71)
        DtpTanggal.Margin = New Padding(3, 4, 3, 4)
        DtpTanggal.Name = "DtpTanggal"
        DtpTanggal.Size = New Size(148, 27)
        DtpTanggal.TabIndex = 5
        ' 
        ' LblNamaPelanggan
        ' 
        LblNamaPelanggan.AutoSize = True
        LblNamaPelanggan.Location = New Point(23, 120)
        LblNamaPelanggan.Name = "LblNamaPelanggan"
        LblNamaPelanggan.Size = New Size(122, 20)
        LblNamaPelanggan.TabIndex = 6
        LblNamaPelanggan.Text = "Nama Pelanggan"
        ' 
        ' CboPelanggan
        ' 
        CboPelanggan.FormattingEnabled = True
        CboPelanggan.Location = New Point(160, 116)
        CboPelanggan.Margin = New Padding(3, 4, 3, 4)
        CboPelanggan.Name = "CboPelanggan"
        CboPelanggan.Size = New Size(251, 28)
        CboPelanggan.TabIndex = 7
        CboPelanggan.Text = "PLG001 - Andi Setiawan"
        ' 
        ' BtnCariPelanggan
        ' 
        BtnCariPelanggan.Location = New Point(418, 115)
        BtnCariPelanggan.Margin = New Padding(3, 4, 3, 4)
        BtnCariPelanggan.Name = "BtnCariPelanggan"
        BtnCariPelanggan.Size = New Size(40, 33)
        BtnCariPelanggan.TabIndex = 8
        BtnCariPelanggan.Text = "..."
        BtnCariPelanggan.UseVisualStyleBackColor = True
        ' 
        ' LblKodeBarang
        ' 
        LblKodeBarang.AutoSize = True
        LblKodeBarang.Location = New Point(23, 173)
        LblKodeBarang.Name = "LblKodeBarang"
        LblKodeBarang.Size = New Size(95, 20)
        LblKodeBarang.TabIndex = 9
        LblKodeBarang.Text = "Kode Barang"
        ' 
        ' CboBarang
        ' 
        CboBarang.FormattingEnabled = True
        CboBarang.Location = New Point(23, 200)
        CboBarang.Margin = New Padding(3, 4, 3, 4)
        CboBarang.Name = "CboBarang"
        CboBarang.Size = New Size(228, 28)
        CboBarang.TabIndex = 10
        CboBarang.Text = "BRG001 - Kemeja Formal"
        ' 
        ' BtnCariBarang
        ' 
        BtnCariBarang.Location = New Point(258, 199)
        BtnCariBarang.Margin = New Padding(3, 4, 3, 4)
        BtnCariBarang.Name = "BtnCariBarang"
        BtnCariBarang.Size = New Size(40, 33)
        BtnCariBarang.TabIndex = 11
        BtnCariBarang.Text = "..."
        BtnCariBarang.UseVisualStyleBackColor = True
        ' 
        ' LblQty
        ' 
        LblQty.AutoSize = True
        LblQty.Location = New Point(314, 173)
        LblQty.Name = "LblQty"
        LblQty.Size = New Size(32, 20)
        LblQty.TabIndex = 12
        LblQty.Text = "Qty"
        ' 
        ' NudQty
        ' 
        NudQty.Location = New Point(314, 200)
        NudQty.Margin = New Padding(3, 4, 3, 4)
        NudQty.Name = "NudQty"
        NudQty.Size = New Size(57, 27)
        NudQty.TabIndex = 13
        NudQty.Value = New Decimal(New Integer() {2, 0, 0, 0})
        ' 
        ' LblHarga
        ' 
        LblHarga.AutoSize = True
        LblHarga.Location = New Point(389, 173)
        LblHarga.Name = "LblHarga"
        LblHarga.Size = New Size(50, 20)
        LblHarga.TabIndex = 14
        LblHarga.Text = "Harga"
        ' 
        ' TxtHarga
        ' 
        TxtHarga.Location = New Point(389, 200)
        TxtHarga.Margin = New Padding(3, 4, 3, 4)
        TxtHarga.Name = "TxtHarga"
        TxtHarga.ReadOnly = True
        TxtHarga.Size = New Size(114, 27)
        TxtHarga.TabIndex = 15
        TxtHarga.Text = "150.000"
        TxtHarga.TextAlign = HorizontalAlignment.Right
        ' 
        ' LblSubTotalItem
        ' 
        LblSubTotalItem.AutoSize = True
        LblSubTotalItem.Location = New Point(520, 173)
        LblSubTotalItem.Name = "LblSubTotalItem"
        LblSubTotalItem.Size = New Size(71, 20)
        LblSubTotalItem.TabIndex = 16
        LblSubTotalItem.Text = "Sub Total"
        ' 
        ' TxtSubTotalItem
        ' 
        TxtSubTotalItem.Location = New Point(520, 200)
        TxtSubTotalItem.Margin = New Padding(3, 4, 3, 4)
        TxtSubTotalItem.Name = "TxtSubTotalItem"
        TxtSubTotalItem.ReadOnly = True
        TxtSubTotalItem.Size = New Size(114, 27)
        TxtSubTotalItem.TabIndex = 17
        TxtSubTotalItem.Text = "300.000"
        TxtSubTotalItem.TextAlign = HorizontalAlignment.Right
        ' 
        ' BtnMin
        ' 
        BtnMin.Location = New Point(646, 199)
        BtnMin.Margin = New Padding(3, 4, 3, 4)
        BtnMin.Name = "BtnMin"
        BtnMin.Size = New Size(34, 33)
        BtnMin.TabIndex = 18
        BtnMin.Text = "-"
        BtnMin.UseVisualStyleBackColor = True
        ' 
        ' BtnPlus
        ' 
        BtnPlus.BackColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
        BtnPlus.FlatAppearance.BorderSize = 0
        BtnPlus.FlatStyle = FlatStyle.Flat
        BtnPlus.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnPlus.ForeColor = Color.White
        BtnPlus.Location = New Point(686, 199)
        BtnPlus.Margin = New Padding(3, 4, 3, 4)
        BtnPlus.Name = "BtnPlus"
        BtnPlus.Size = New Size(40, 33)
        BtnPlus.TabIndex = 19
        BtnPlus.Text = "+"
        BtnPlus.UseVisualStyleBackColor = False
        ' 
        ' DgvKeranjang
        ' 
        DgvKeranjang.AllowUserToAddRows = False
        DgvKeranjang.AllowUserToDeleteRows = False
        DgvKeranjang.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DgvKeranjang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DgvKeranjang.ColumnHeadersHeight = 30
        DgvKeranjang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgvKeranjang.Columns.AddRange(New DataGridViewColumn() {ColNo, ColKodeBarang, ColNamaBarang, ColQty, ColHarga, ColSubTotal})
        DgvKeranjang.EnableHeadersVisualStyles = False
        DgvKeranjang.Location = New Point(23, 253)
        DgvKeranjang.Margin = New Padding(3, 4, 3, 4)
        DgvKeranjang.Name = "DgvKeranjang"
        DgvKeranjang.ReadOnly = True
        DgvKeranjang.RowHeadersVisible = False
        DgvKeranjang.RowHeadersWidth = 51
        DgvKeranjang.RowTemplate.Height = 25
        DgvKeranjang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvKeranjang.Size = New Size(571, 240)
        DgvKeranjang.TabIndex = 20
        ' 
        ' ColNo
        ' 
        ColNo.HeaderText = "No"
        ColNo.MinimumWidth = 6
        ColNo.Name = "ColNo"
        ColNo.ReadOnly = True
        ColNo.Width = 40
        ' 
        ' ColKodeBarang
        ' 
        ColKodeBarang.HeaderText = "Kode Barang"
        ColKodeBarang.MinimumWidth = 6
        ColKodeBarang.Name = "ColKodeBarang"
        ColKodeBarang.ReadOnly = True
        ColKodeBarang.Width = 90
        ' 
        ' ColNamaBarang
        ' 
        ColNamaBarang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ColNamaBarang.HeaderText = "Nama Barang"
        ColNamaBarang.MinimumWidth = 6
        ColNamaBarang.Name = "ColNamaBarang"
        ColNamaBarang.ReadOnly = True
        ' 
        ' ColQty
        ' 
        ColQty.HeaderText = "Qty"
        ColQty.MinimumWidth = 6
        ColQty.Name = "ColQty"
        ColQty.ReadOnly = True
        ColQty.Width = 40
        ' 
        ' ColHarga
        ' 
        ColHarga.HeaderText = "Harga"
        ColHarga.MinimumWidth = 6
        ColHarga.Name = "ColHarga"
        ColHarga.ReadOnly = True
        ColHarga.Width = 80
        ' 
        ' ColSubTotal
        ' 
        ColSubTotal.HeaderText = "Sub Total"
        ColSubTotal.MinimumWidth = 6
        ColSubTotal.Name = "ColSubTotal"
        ColSubTotal.ReadOnly = True
        ColSubTotal.Width = 80
        ' 
        ' PnlSummary
        ' 
        PnlSummary.BorderStyle = BorderStyle.FixedSingle
        PnlSummary.Controls.Add(LblTotalItem)
        PnlSummary.Controls.Add(LblTotalItemVal)
        PnlSummary.Controls.Add(LblTotal)
        PnlSummary.Controls.Add(LblTotalVal)
        PnlSummary.Controls.Add(LblDiskon)
        PnlSummary.Controls.Add(TxtDiskon)
        PnlSummary.Controls.Add(LblGrandTotal)
        PnlSummary.Controls.Add(LblGrandTotalVal)
        PnlSummary.Location = New Point(611, 253)
        PnlSummary.Margin = New Padding(3, 4, 3, 4)
        PnlSummary.Name = "PnlSummary"
        PnlSummary.Size = New Size(268, 239)
        PnlSummary.TabIndex = 21
        ' 
        ' LblTotalItem
        ' 
        LblTotalItem.AutoSize = True
        LblTotalItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblTotalItem.Location = New Point(17, 27)
        LblTotalItem.Name = "LblTotalItem"
        LblTotalItem.Size = New Size(81, 20)
        LblTotalItem.TabIndex = 0
        LblTotalItem.Text = "Total Item"
        ' 
        ' LblTotalItemVal
        ' 
        LblTotalItemVal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblTotalItemVal.Location = New Point(131, 27)
        LblTotalItemVal.Name = "LblTotalItemVal"
        LblTotalItemVal.Size = New Size(114, 20)
        LblTotalItemVal.TabIndex = 1
        LblTotalItemVal.Text = "4"
        LblTotalItemVal.TextAlign = ContentAlignment.TopRight
        ' 
        ' LblTotal
        ' 
        LblTotal.AutoSize = True
        LblTotal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblTotal.Location = New Point(17, 80)
        LblTotal.Name = "LblTotal"
        LblTotal.Size = New Size(44, 20)
        LblTotal.TabIndex = 2
        LblTotal.Text = "Total"
        ' 
        ' LblTotalVal
        ' 
        LblTotalVal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblTotalVal.Location = New Point(131, 80)
        LblTotalVal.Name = "LblTotalVal"
        LblTotalVal.Size = New Size(114, 20)
        LblTotalVal.TabIndex = 3
        LblTotalVal.Text = "600.000"
        LblTotalVal.TextAlign = ContentAlignment.TopRight
        ' 
        ' LblDiskon
        ' 
        LblDiskon.AutoSize = True
        LblDiskon.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblDiskon.Location = New Point(17, 133)
        LblDiskon.Name = "LblDiskon"
        LblDiskon.Size = New Size(57, 20)
        LblDiskon.TabIndex = 4
        LblDiskon.Text = "Diskon"
        ' 
        ' TxtDiskon
        ' 
        TxtDiskon.Location = New Point(131, 129)
        TxtDiskon.Margin = New Padding(3, 4, 3, 4)
        TxtDiskon.Name = "TxtDiskon"
        TxtDiskon.Size = New Size(114, 27)
        TxtDiskon.TabIndex = 5
        TxtDiskon.Text = "0"
        TxtDiskon.TextAlign = HorizontalAlignment.Right
        ' 
        ' LblGrandTotal
        ' 
        LblGrandTotal.AutoSize = True
        LblGrandTotal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblGrandTotal.Location = New Point(17, 187)
        LblGrandTotal.Name = "LblGrandTotal"
        LblGrandTotal.Size = New Size(91, 20)
        LblGrandTotal.TabIndex = 6
        LblGrandTotal.Text = "Grand Total"
        ' 
        ' LblGrandTotalVal
        ' 
        LblGrandTotalVal.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        LblGrandTotalVal.ForeColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        LblGrandTotalVal.Location = New Point(131, 183)
        LblGrandTotalVal.Name = "LblGrandTotalVal"
        LblGrandTotalVal.Size = New Size(114, 27)
        LblGrandTotalVal.TabIndex = 7
        LblGrandTotalVal.Text = "600.000"
        LblGrandTotalVal.TextAlign = ContentAlignment.TopRight
        ' 
        ' BtnProses
        ' 
        BtnProses.BackColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
        BtnProses.FlatAppearance.BorderSize = 0
        BtnProses.FlatStyle = FlatStyle.Flat
        BtnProses.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnProses.ForeColor = Color.White
        BtnProses.Location = New Point(206, 533)
        BtnProses.Margin = New Padding(3, 4, 3, 4)
        BtnProses.Name = "BtnProses"
        BtnProses.Size = New Size(137, 53)
        BtnProses.TabIndex = 22
        BtnProses.Text = "Proses"
        BtnProses.UseVisualStyleBackColor = False
        ' 
        ' BtnCetak
        ' 
        BtnCetak.BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        BtnCetak.FlatAppearance.BorderSize = 0
        BtnCetak.FlatStyle = FlatStyle.Flat
        BtnCetak.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnCetak.ForeColor = Color.White
        BtnCetak.Location = New Point(366, 533)
        BtnCetak.Margin = New Padding(3, 4, 3, 4)
        BtnCetak.Name = "BtnCetak"
        BtnCetak.Size = New Size(137, 53)
        BtnCetak.TabIndex = 23
        BtnCetak.Text = "Cetak Struk"
        BtnCetak.UseVisualStyleBackColor = False
        ' 
        ' BtnBatal
        ' 
        BtnBatal.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        BtnBatal.FlatAppearance.BorderSize = 0
        BtnBatal.FlatStyle = FlatStyle.Flat
        BtnBatal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnBatal.ForeColor = Color.White
        BtnBatal.Location = New Point(526, 533)
        BtnBatal.Margin = New Padding(3, 4, 3, 4)
        BtnBatal.Name = "BtnBatal"
        BtnBatal.Size = New Size(137, 53)
        BtnBatal.TabIndex = 24
        BtnBatal.Text = "Batal"
        BtnBatal.UseVisualStyleBackColor = False
        ' 
        ' FormTransaksiPenjualan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(903, 613)
        Controls.Add(BtnBatal)
        Controls.Add(BtnCetak)
        Controls.Add(BtnProses)
        Controls.Add(PnlSummary)
        Controls.Add(DgvKeranjang)
        Controls.Add(BtnPlus)
        Controls.Add(BtnMin)
        Controls.Add(TxtSubTotalItem)
        Controls.Add(LblSubTotalItem)
        Controls.Add(TxtHarga)
        Controls.Add(LblHarga)
        Controls.Add(NudQty)
        Controls.Add(LblQty)
        Controls.Add(BtnCariBarang)
        Controls.Add(CboBarang)
        Controls.Add(LblKodeBarang)
        Controls.Add(BtnCariPelanggan)
        Controls.Add(CboPelanggan)
        Controls.Add(LblNamaPelanggan)
        Controls.Add(DtpTanggal)
        Controls.Add(LblTanggal)
        Controls.Add(TxtKasir)
        Controls.Add(LblKasir)
        Controls.Add(TxtNoTransaksi)
        Controls.Add(LblNoTransaksi)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormTransaksiPenjualan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Transaksi Penjualan"
        CType(NudQty, ComponentModel.ISupportInitialize).EndInit()
        CType(DgvKeranjang, ComponentModel.ISupportInitialize).EndInit()
        PnlSummary.ResumeLayout(False)
        PnlSummary.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

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