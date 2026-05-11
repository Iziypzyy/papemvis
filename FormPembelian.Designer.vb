<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form8
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
    Friend WithEvents lblNoPembelian As System.Windows.Forms.Label
    Friend WithEvents txtNoPembelian As System.Windows.Forms.TextBox
    Friend WithEvents lblTanggal As System.Windows.Forms.Label
    Friend WithEvents dtpTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSupplier As System.Windows.Forms.Label
    Friend WithEvents cmbSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents btnCariSupplier As System.Windows.Forms.Button

    Friend WithEvents dgvDetailPembelian As System.Windows.Forms.DataGridView
    Friend WithEvents colKode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHarga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubTotal As System.Windows.Forms.DataGridViewTextBoxColumn

    ' Bagian Summary / Output
    Friend WithEvents pnlSummary As System.Windows.Forms.Panel
    Friend WithEvents lblTextTotalItem As System.Windows.Forms.Label
    Friend WithEvents lblOutputTotalItem As System.Windows.Forms.Label
    Friend WithEvents lblTextTotal As System.Windows.Forms.Label
    Friend WithEvents lblOutputTotal As System.Windows.Forms.Label
    Friend WithEvents lblTextOngkir As System.Windows.Forms.Label
    Friend WithEvents txtOngkir As System.Windows.Forms.TextBox
    Friend WithEvents lblTextGrandTotal As System.Windows.Forms.Label
    Friend WithEvents lblOutputGrandTotal As System.Windows.Forms.Label

    ' Tombol Aksi
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnCetak As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblNoPembelian = New Label()
        txtNoPembelian = New TextBox()
        lblTanggal = New Label()
        dtpTanggal = New DateTimePicker()
        lblSupplier = New Label()
        cmbSupplier = New ComboBox()
        btnCariSupplier = New Button()
        dgvDetailPembelian = New DataGridView()
        colKode = New DataGridViewTextBoxColumn()
        colNama = New DataGridViewTextBoxColumn()
        colQty = New DataGridViewTextBoxColumn()
        colHarga = New DataGridViewTextBoxColumn()
        colSubTotal = New DataGridViewTextBoxColumn()
        pnlSummary = New Panel()
        lblTextTotalItem = New Label()
        lblOutputTotalItem = New Label()
        lblTextTotal = New Label()
        lblOutputTotal = New Label()
        lblTextOngkir = New Label()
        txtOngkir = New TextBox()
        lblTextGrandTotal = New Label()
        lblOutputGrandTotal = New Label()
        btnSimpan = New Button()
        btnCetak = New Button()
        btnBatal = New Button()
        CType(dgvDetailPembelian, ComponentModel.ISupportInitialize).BeginInit()
        pnlSummary.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblNoPembelian
        ' 
        lblNoPembelian.AutoSize = True
        lblNoPembelian.Location = New Point(25, 27)
        lblNoPembelian.Name = "lblNoPembelian"
        lblNoPembelian.Size = New Size(102, 20)
        lblNoPembelian.TabIndex = 11
        lblNoPembelian.Text = "No Pembelian"
        ' 
        ' txtNoPembelian
        ' 
        txtNoPembelian.Location = New Point(130, 24)
        txtNoPembelian.Name = "txtNoPembelian"
        txtNoPembelian.ReadOnly = True
        txtNoPembelian.Size = New Size(180, 27)
        txtNoPembelian.TabIndex = 10
        txtNoPembelian.Text = "PB2405220001"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Location = New Point(25, 67)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(61, 20)
        lblTanggal.TabIndex = 9
        lblTanggal.Text = "Tanggal"
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Format = DateTimePickerFormat.Short
        dtpTanggal.Location = New Point(130, 64)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(140, 27)
        dtpTanggal.TabIndex = 8
        ' 
        ' lblSupplier
        ' 
        lblSupplier.AutoSize = True
        lblSupplier.Location = New Point(25, 107)
        lblSupplier.Name = "lblSupplier"
        lblSupplier.Size = New Size(64, 20)
        lblSupplier.TabIndex = 7
        lblSupplier.Text = "Supplier"
        ' 
        ' cmbSupplier
        ' 
        cmbSupplier.FormattingEnabled = True
        cmbSupplier.Location = New Point(130, 104)
        cmbSupplier.Name = "cmbSupplier"
        cmbSupplier.Size = New Size(285, 28)
        cmbSupplier.TabIndex = 6
        cmbSupplier.Text = "SUP001 - PT. Fashionindo Utama"
        ' 
        ' btnCariSupplier
        ' 
        btnCariSupplier.Location = New Point(425, 103)
        btnCariSupplier.Name = "btnCariSupplier"
        btnCariSupplier.Size = New Size(40, 29)
        btnCariSupplier.TabIndex = 5
        btnCariSupplier.Text = "..."
        btnCariSupplier.UseVisualStyleBackColor = True
        ' 
        ' dgvDetailPembelian
        ' 
        dgvDetailPembelian.AllowUserToAddRows = False
        dgvDetailPembelian.BackgroundColor = Color.White
        dgvDetailPembelian.ColumnHeadersHeight = 29
        dgvDetailPembelian.Columns.AddRange(New DataGridViewColumn() {colKode, colNama, colQty, colHarga, colSubTotal})
        dgvDetailPembelian.Location = New Point(25, 150)
        dgvDetailPembelian.Name = "dgvDetailPembelian"
        dgvDetailPembelian.RowHeadersVisible = False
        dgvDetailPembelian.RowHeadersWidth = 51
        dgvDetailPembelian.Size = New Size(690, 210)
        dgvDetailPembelian.TabIndex = 4
        ' 
        ' colKode
        ' 
        colKode.HeaderText = "Kode Barang"
        colKode.MinimumWidth = 6
        colKode.Name = "colKode"
        colKode.Width = 120
        ' 
        ' colNama
        ' 
        colNama.HeaderText = "Nama Barang"
        colNama.MinimumWidth = 6
        colNama.Name = "colNama"
        colNama.Width = 220
        ' 
        ' colQty
        ' 
        colQty.HeaderText = "Qty"
        colQty.MinimumWidth = 6
        colQty.Name = "colQty"
        colQty.Width = 80
        ' 
        ' colHarga
        ' 
        colHarga.HeaderText = "Harga Beli"
        colHarga.MinimumWidth = 6
        colHarga.Name = "colHarga"
        colHarga.Width = 130
        ' 
        ' colSubTotal
        ' 
        colSubTotal.HeaderText = "Sub Total"
        colSubTotal.MinimumWidth = 6
        colSubTotal.Name = "colSubTotal"
        colSubTotal.Width = 135
        ' 
        ' pnlSummary
        ' 
        pnlSummary.BackColor = Color.White
        pnlSummary.BorderStyle = BorderStyle.FixedSingle
        pnlSummary.Controls.Add(lblTextTotalItem)
        pnlSummary.Controls.Add(lblOutputTotalItem)
        pnlSummary.Controls.Add(lblTextTotal)
        pnlSummary.Controls.Add(lblOutputTotal)
        pnlSummary.Controls.Add(lblTextOngkir)
        pnlSummary.Controls.Add(txtOngkir)
        pnlSummary.Controls.Add(lblTextGrandTotal)
        pnlSummary.Controls.Add(lblOutputGrandTotal)
        pnlSummary.Location = New Point(450, 375)
        pnlSummary.Name = "pnlSummary"
        pnlSummary.Size = New Size(265, 140)
        pnlSummary.TabIndex = 3
        ' 
        ' lblTextTotalItem
        ' 
        lblTextTotalItem.AutoSize = True
        lblTextTotalItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTextTotalItem.Location = New Point(15, 15)
        lblTextTotalItem.Name = "lblTextTotalItem"
        lblTextTotalItem.Size = New Size(81, 20)
        lblTextTotalItem.TabIndex = 0
        lblTextTotalItem.Text = "Total Item"
        ' 
        ' lblOutputTotalItem
        ' 
        lblOutputTotalItem.Location = New Point(145, 15)
        lblOutputTotalItem.Name = "lblOutputTotalItem"
        lblOutputTotalItem.Size = New Size(100, 20)
        lblOutputTotalItem.TabIndex = 1
        lblOutputTotalItem.Text = "35"
        lblOutputTotalItem.TextAlign = ContentAlignment.TopRight
        ' 
        ' lblTextTotal
        ' 
        lblTextTotal.AutoSize = True
        lblTextTotal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTextTotal.Location = New Point(15, 45)
        lblTextTotal.Name = "lblTextTotal"
        lblTextTotal.Size = New Size(44, 20)
        lblTextTotal.TabIndex = 2
        lblTextTotal.Text = "Total"
        ' 
        ' lblOutputTotal
        ' 
        lblOutputTotal.Location = New Point(145, 45)
        lblOutputTotal.Name = "lblOutputTotal"
        lblOutputTotal.Size = New Size(100, 20)
        lblOutputTotal.TabIndex = 3
        lblOutputTotal.Text = "4.650.000"
        lblOutputTotal.TextAlign = ContentAlignment.TopRight
        ' 
        ' lblTextOngkir
        ' 
        lblTextOngkir.AutoSize = True
        lblTextOngkir.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTextOngkir.Location = New Point(15, 75)
        lblTextOngkir.Name = "lblTextOngkir"
        lblTextOngkir.Size = New Size(56, 20)
        lblTextOngkir.TabIndex = 4
        lblTextOngkir.Text = "Ongkir"
        ' 
        ' txtOngkir
        ' 
        txtOngkir.Location = New Point(145, 72)
        txtOngkir.Name = "txtOngkir"
        txtOngkir.Size = New Size(100, 27)
        txtOngkir.TabIndex = 5
        txtOngkir.Text = "0"
        txtOngkir.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblTextGrandTotal
        ' 
        lblTextGrandTotal.AutoSize = True
        lblTextGrandTotal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTextGrandTotal.ForeColor = Color.MidnightBlue
        lblTextGrandTotal.Location = New Point(15, 105)
        lblTextGrandTotal.Name = "lblTextGrandTotal"
        lblTextGrandTotal.Size = New Size(91, 20)
        lblTextGrandTotal.TabIndex = 6
        lblTextGrandTotal.Text = "Grand Total"
        ' 
        ' lblOutputGrandTotal
        ' 
        lblOutputGrandTotal.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblOutputGrandTotal.ForeColor = Color.Blue
        lblOutputGrandTotal.Location = New Point(125, 104)
        lblOutputGrandTotal.Name = "lblOutputGrandTotal"
        lblOutputGrandTotal.Size = New Size(120, 25)
        lblOutputGrandTotal.TabIndex = 7
        lblOutputGrandTotal.Text = "4.650.000"
        lblOutputGrandTotal.TextAlign = ContentAlignment.TopRight
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.MediumSeaGreen
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(265, 540)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(100, 40)
        btnSimpan.TabIndex = 2
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.LightGray
        btnCetak.FlatStyle = FlatStyle.Flat
        btnCetak.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnCetak.Location = New Point(385, 540)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(100, 40)
        btnCetak.TabIndex = 1
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.Crimson
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(505, 540)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(100, 40)
        btnBatal.TabIndex = 0
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(250))
        ClientSize = New Size(743, 610)
        Controls.Add(btnBatal)
        Controls.Add(btnCetak)
        Controls.Add(btnSimpan)
        Controls.Add(pnlSummary)
        Controls.Add(dgvDetailPembelian)
        Controls.Add(btnCariSupplier)
        Controls.Add(cmbSupplier)
        Controls.Add(lblSupplier)
        Controls.Add(dtpTanggal)
        Controls.Add(lblTanggal)
        Controls.Add(txtNoPembelian)
        Controls.Add(lblNoPembelian)
        Name = "Form8"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pembelian / Stok Masuk"
        CType(dgvDetailPembelian, ComponentModel.ISupportInitialize).EndInit()
        pnlSummary.ResumeLayout(False)
        pnlSummary.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
End Class