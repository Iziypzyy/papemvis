<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.TxtFilter = New System.Windows.Forms.TextBox()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.DgvDataBarang = New System.Windows.Forms.DataGridView()
        Me.ColKodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNamaBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColKategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUkuran = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColWarna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColStok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblTotalData = New System.Windows.Forms.Label()
        Me.PanelDetail = New System.Windows.Forms.Panel()
        Me.PictureBoxBarang = New System.Windows.Forms.PictureBox()
        Me.LblTtlKode = New System.Windows.Forms.Label()
        Me.LblTtlNama = New System.Windows.Forms.Label()
        Me.LblTtlKategori = New System.Windows.Forms.Label()
        Me.LblTtlHarga = New System.Windows.Forms.Label()
        Me.LblTtlStok = New System.Windows.Forms.Label()
        Me.LblValKode = New System.Windows.Forms.Label()
        Me.LblValNama = New System.Windows.Forms.Label()
        Me.LblValKategori = New System.Windows.Forms.Label()
        Me.LblValHarga = New System.Windows.Forms.Label()
        Me.LblValStok = New System.Windows.Forms.Label()
        CType(Me.DgvDataBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDetail.SuspendLayout()
        CType(Me.PictureBoxBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnTambah.FlatAppearance.BorderSize = 0
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambah.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambah.ForeColor = System.Drawing.Color.White
        Me.BtnTambah.Location = New System.Drawing.Point(20, 20)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(90, 35)
        Me.BtnTambah.TabIndex = 0
        Me.BtnTambah.Text = "+ Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.BtnSimpan.FlatAppearance.BorderSize = 0
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSimpan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSimpan.ForeColor = System.Drawing.Color.White
        Me.BtnSimpan.Location = New System.Drawing.Point(120, 20)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(90, 35)
        Me.BtnSimpan.TabIndex = 1
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = False
        '
        'BtnUbah
        '
        Me.BtnUbah.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.BtnUbah.FlatAppearance.BorderSize = 0
        Me.BtnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUbah.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnUbah.ForeColor = System.Drawing.Color.Black
        Me.BtnUbah.Location = New System.Drawing.Point(220, 20)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(90, 35)
        Me.BtnUbah.TabIndex = 2
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnHapus.FlatAppearance.BorderSize = 0
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapus.ForeColor = System.Drawing.Color.White
        Me.BtnHapus.Location = New System.Drawing.Point(320, 20)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(90, 35)
        Me.BtnHapus.TabIndex = 3
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'BtnCari
        '
        Me.BtnCari.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtnCari.FlatAppearance.BorderSize = 0
        Me.BtnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCari.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnCari.ForeColor = System.Drawing.Color.Black
        Me.BtnCari.Location = New System.Drawing.Point(420, 20)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(80, 35)
        Me.BtnCari.TabIndex = 4
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.UseVisualStyleBackColor = False
        '
        'TxtFilter
        '
        Me.TxtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtFilter.Location = New System.Drawing.Point(20, 70)
        Me.TxtFilter.Name = "TxtFilter"
        Me.TxtFilter.Size = New System.Drawing.Size(250, 25)
        Me.TxtFilter.TabIndex = 5
        '
        'TxtCari
        '
        Me.TxtCari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCari.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtCari.ForeColor = System.Drawing.Color.Gray
        Me.TxtCari.Location = New System.Drawing.Point(540, 70)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(240, 25)
        Me.TxtCari.TabIndex = 6
        Me.TxtCari.Text = "Cari barang..."
        '
        'DgvDataBarang
        '
        Me.DgvDataBarang.AllowUserToAddRows = False
        Me.DgvDataBarang.AllowUserToDeleteRows = False
        Me.DgvDataBarang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvDataBarang.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDataBarang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvDataBarang.ColumnHeadersHeight = 30
        Me.DgvDataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvDataBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColKodeBarang, Me.ColNamaBarang, Me.ColKategori, Me.ColUkuran, Me.ColWarna, Me.ColHarga, Me.ColStok})
        Me.DgvDataBarang.EnableHeadersVisualStyles = False
        Me.DgvDataBarang.Location = New System.Drawing.Point(20, 110)
        Me.DgvDataBarang.Name = "DgvDataBarang"
        Me.DgvDataBarang.ReadOnly = True
        Me.DgvDataBarang.RowHeadersVisible = False
        Me.DgvDataBarang.RowTemplate.Height = 25
        Me.DgvDataBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDataBarang.Size = New System.Drawing.Size(760, 220)
        Me.DgvDataBarang.TabIndex = 7
        '
        'ColKodeBarang
        '
        Me.ColKodeBarang.HeaderText = "Kode Barang"
        Me.ColKodeBarang.Name = "ColKodeBarang"
        Me.ColKodeBarang.ReadOnly = True
        Me.ColKodeBarang.Width = 110
        '
        'ColNamaBarang
        '
        Me.ColNamaBarang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ColNamaBarang.HeaderText = "Nama Barang"
        Me.ColNamaBarang.Name = "ColNamaBarang"
        Me.ColNamaBarang.ReadOnly = True
        '
        'ColKategori
        '
        Me.ColKategori.HeaderText = "Kategori"
        Me.ColKategori.Name = "ColKategori"
        Me.ColKategori.ReadOnly = True
        Me.ColKategori.Width = 120
        '
        'ColUkuran
        '
        Me.ColUkuran.HeaderText = "Ukuran"
        Me.ColUkuran.Name = "ColUkuran"
        Me.ColUkuran.ReadOnly = True
        Me.ColUkuran.Width = 70
        '
        'ColWarna
        '
        Me.ColWarna.HeaderText = "Warna"
        Me.ColWarna.Name = "ColWarna"
        Me.ColWarna.ReadOnly = True
        Me.ColWarna.Width = 80
        '
        'ColHarga
        '
        Me.ColHarga.HeaderText = "Harga"
        Me.ColHarga.Name = "ColHarga"
        Me.ColHarga.ReadOnly = True
        Me.ColHarga.Width = 100
        '
        'ColStok
        '
        Me.ColStok.HeaderText = "Stok"
        Me.ColStok.Name = "ColStok"
        Me.ColStok.ReadOnly = True
        Me.ColStok.Width = 60
        '
        'LblTotalData
        '
        Me.LblTotalData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblTotalData.AutoSize = True
        Me.LblTotalData.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTotalData.Location = New System.Drawing.Point(20, 520)
        Me.LblTotalData.Name = "LblTotalData"
        Me.LblTotalData.Size = New System.Drawing.Size(81, 15)
        Me.LblTotalData.TabIndex = 8
        Me.LblTotalData.Text = "Total Data : 6"
        '
        'PanelDetail
        '
        Me.PanelDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDetail.Controls.Add(Me.LblValStok)
        Me.PanelDetail.Controls.Add(Me.LblValHarga)
        Me.PanelDetail.Controls.Add(Me.LblValKategori)
        Me.PanelDetail.Controls.Add(Me.LblValNama)
        Me.PanelDetail.Controls.Add(Me.LblValKode)
        Me.PanelDetail.Controls.Add(Me.LblTtlStok)
        Me.PanelDetail.Controls.Add(Me.LblTtlHarga)
        Me.PanelDetail.Controls.Add(Me.LblTtlKategori)
        Me.PanelDetail.Controls.Add(Me.LblTtlNama)
        Me.PanelDetail.Controls.Add(Me.LblTtlKode)
        Me.PanelDetail.Controls.Add(Me.PictureBoxBarang)
        Me.PanelDetail.Location = New System.Drawing.Point(380, 345)
        Me.PanelDetail.Name = "PanelDetail"
        Me.PanelDetail.Size = New System.Drawing.Size(400, 190)
        Me.PanelDetail.TabIndex = 9
        '
        'PictureBoxBarang
        '
        Me.PictureBoxBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxBarang.Location = New System.Drawing.Point(15, 15)
        Me.PictureBoxBarang.Name = "PictureBoxBarang"
        Me.PictureBoxBarang.Size = New System.Drawing.Size(120, 155)
        Me.PictureBoxBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxBarang.TabIndex = 0
        Me.PictureBoxBarang.TabStop = False
        '
        'LblTtlKode
        '
        Me.LblTtlKode.AutoSize = True
        Me.LblTtlKode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTtlKode.Location = New System.Drawing.Point(150, 20)
        Me.LblTtlKode.Name = "LblTtlKode"
        Me.LblTtlKode.Size = New System.Drawing.Size(77, 15)
        Me.LblTtlKode.TabIndex = 1
        Me.LblTtlKode.Text = "Kode Barang"
        '
        'LblTtlNama
        '
        Me.LblTtlNama.AutoSize = True
        Me.LblTtlNama.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTtlNama.Location = New System.Drawing.Point(150, 50)
        Me.LblTtlNama.Name = "LblTtlNama"
        Me.LblTtlNama.Size = New System.Drawing.Size(81, 15)
        Me.LblTtlNama.TabIndex = 2
        Me.LblTtlNama.Text = "Nama Barang"
        '
        'LblTtlKategori
        '
        Me.LblTtlKategori.AutoSize = True
        Me.LblTtlKategori.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTtlKategori.Location = New System.Drawing.Point(150, 80)
        Me.LblTtlKategori.Name = "LblTtlKategori"
        Me.LblTtlKategori.Size = New System.Drawing.Size(53, 15)
        Me.LblTtlKategori.TabIndex = 3
        Me.LblTtlKategori.Text = "Kategori"
        '
        'LblTtlHarga
        '
        Me.LblTtlHarga.AutoSize = True
        Me.LblTtlHarga.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTtlHarga.Location = New System.Drawing.Point(150, 110)
        Me.LblTtlHarga.Name = "LblTtlHarga"
        Me.LblTtlHarga.Size = New System.Drawing.Size(40, 15)
        Me.LblTtlHarga.TabIndex = 4
        Me.LblTtlHarga.Text = "Harga"
        '
        'LblTtlStok
        '
        Me.LblTtlStok.AutoSize = True
        Me.LblTtlStok.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTtlStok.Location = New System.Drawing.Point(150, 140)
        Me.LblTtlStok.Name = "LblTtlStok"
        Me.LblTtlStok.Size = New System.Drawing.Size(32, 15)
        Me.LblTtlStok.TabIndex = 5
        Me.LblTtlStok.Text = "Stok"
        '
        'LblValKode
        '
        Me.LblValKode.AutoSize = True
        Me.LblValKode.Location = New System.Drawing.Point(260, 20)
        Me.LblValKode.Name = "LblValKode"
        Me.LblValKode.Size = New System.Drawing.Size(52, 15)
        Me.LblValKode.TabIndex = 6
        Me.LblValKode.Text = "BRG001"
        '
        'LblValNama
        '
        Me.LblValNama.AutoSize = True
        Me.LblValNama.Location = New System.Drawing.Point(260, 50)
        Me.LblValNama.Name = "LblValNama"
        Me.LblValNama.Size = New System.Drawing.Size(89, 15)
        Me.LblValNama.TabIndex = 7
        Me.LblValNama.Text = "Kemeja Formal"
        '
        'LblValKategori
        '
        Me.LblValKategori.AutoSize = True
        Me.LblValKategori.Location = New System.Drawing.Point(260, 80)
        Me.LblValKategori.Name = "LblValKategori"
        Me.LblValKategori.Size = New System.Drawing.Size(46, 15)
        Me.LblValKategori.TabIndex = 8
        Me.LblValKategori.Text = "Kemeja"
        '
        'LblValHarga
        '
        Me.LblValHarga.AutoSize = True
        Me.LblValHarga.Location = New System.Drawing.Point(260, 110)
        Me.LblValHarga.Name = "LblValHarga"
        Me.LblValHarga.Size = New System.Drawing.Size(49, 15)
        Me.LblValHarga.TabIndex = 9
        Me.LblValHarga.Text = "150.000"
        '
        'LblValStok
        '
        Me.LblValStok.AutoSize = True
        Me.LblValStok.Location = New System.Drawing.Point(260, 140)
        Me.LblValStok.Name = "LblValStok"
        Me.LblValStok.Size = New System.Drawing.Size(19, 15)
        Me.LblValStok.TabIndex = 10
        Me.LblValStok.Text = "25"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 550)
        Me.Controls.Add(Me.PanelDetail)
        Me.Controls.Add(Me.LblTotalData)
        Me.Controls.Add(Me.DgvDataBarang)
        Me.Controls.Add(Me.TxtCari)
        Me.Controls.Add(Me.TxtFilter)
        Me.Controls.Add(Me.BtnCari)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnTambah)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Barang"
        CType(Me.DgvDataBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDetail.ResumeLayout(False)
        Me.PanelDetail.PerformLayout()
        CType(Me.PictureBoxBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents TxtFilter As System.Windows.Forms.TextBox
    Friend WithEvents TxtCari As System.Windows.Forms.TextBox
    Friend WithEvents DgvDataBarang As System.Windows.Forms.DataGridView
    Friend WithEvents ColKodeBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColNamaBarang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColKategori As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColUkuran As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColWarna As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColHarga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColStok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LblTotalData As System.Windows.Forms.Label
    Friend WithEvents PanelDetail As System.Windows.Forms.Panel
    Friend WithEvents PictureBoxBarang As System.Windows.Forms.PictureBox
    Friend WithEvents LblTtlStok As System.Windows.Forms.Label
    Friend WithEvents LblTtlHarga As System.Windows.Forms.Label
    Friend WithEvents LblTtlKategori As System.Windows.Forms.Label
    Friend WithEvents LblTtlNama As System.Windows.Forms.Label
    Friend WithEvents LblTtlKode As System.Windows.Forms.Label
    Friend WithEvents LblValStok As System.Windows.Forms.Label
    Friend WithEvents LblValHarga As System.Windows.Forms.Label
    Friend WithEvents LblValKategori As System.Windows.Forms.Label
    Friend WithEvents LblValNama As System.Windows.Forms.Label
    Friend WithEvents LblValKode As System.Windows.Forms.Label
End Class