<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDataBarang
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        BtnTambah = New Button()
        BtnUbah = New Button()
        BtnHapusItem = New Button()
        TxtFilter = New TextBox()
        TxtCari = New TextBox()
        DgvDataBarang = New DataGridView()
        ColKodeBarang = New DataGridViewTextBoxColumn()
        ColNamaBarang = New DataGridViewTextBoxColumn()
        ColKategori = New DataGridViewTextBoxColumn()
        ColUkuran = New DataGridViewTextBoxColumn()
        ColWarna = New DataGridViewTextBoxColumn()
        ColHarga = New DataGridViewTextBoxColumn()
        ColStok = New DataGridViewTextBoxColumn()
        LblTotalData = New Label()
        PanelDetail = New Panel()
        LblValStok = New Label()
        LblValHarga = New Label()
        LblValKategori = New Label()
        LblValNama = New Label()
        LblValKode = New Label()
        LblTtlStok = New Label()
        LblTtlHarga = New Label()
        LblTtlKategori = New Label()
        LblTtlNama = New Label()
        LblTtlKode = New Label()
        PictureBoxBarang = New PictureBox()
        CType(DgvDataBarang, ComponentModel.ISupportInitialize).BeginInit()
        PanelDetail.SuspendLayout()
        CType(PictureBoxBarang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnTambah
        ' 
        BtnTambah.BackColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
        BtnTambah.FlatAppearance.BorderSize = 0
        BtnTambah.FlatStyle = FlatStyle.Flat
        BtnTambah.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnTambah.ForeColor = Color.White
        BtnTambah.Location = New Point(29, 34)
        BtnTambah.Margin = New Padding(4, 5, 4, 5)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(129, 59)
        BtnTambah.TabIndex = 0
        BtnTambah.Text = "+ Tambah"
        BtnTambah.UseVisualStyleBackColor = False
        ' 
        ' BtnUbah
        ' 
        BtnUbah.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        BtnUbah.FlatAppearance.BorderSize = 0
        BtnUbah.FlatStyle = FlatStyle.Flat
        BtnUbah.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnUbah.ForeColor = Color.Black
        BtnUbah.Location = New Point(172, 34)
        BtnUbah.Margin = New Padding(4, 5, 4, 5)
        BtnUbah.Name = "BtnUbah"
        BtnUbah.Size = New Size(129, 59)
        BtnUbah.TabIndex = 2
        BtnUbah.Text = "Ubah"
        BtnUbah.UseVisualStyleBackColor = False
        ' 
        ' BtnHapusItem
        ' 
        BtnHapusItem.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        BtnHapusItem.FlatAppearance.BorderSize = 0
        BtnHapusItem.FlatStyle = FlatStyle.Flat
        BtnHapusItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnHapusItem.ForeColor = Color.White
        BtnHapusItem.Location = New Point(316, 34)
        BtnHapusItem.Margin = New Padding(4, 5, 4, 5)
        BtnHapusItem.Name = "BtnHapusItem"
        BtnHapusItem.Size = New Size(129, 59)
        BtnHapusItem.TabIndex = 3
        BtnHapusItem.Text = "Hapus"
        BtnHapusItem.UseVisualStyleBackColor = False
        ' 
        ' TxtFilter
        ' 
        TxtFilter.BorderStyle = BorderStyle.FixedSingle
        TxtFilter.Font = New Font("Segoe UI", 10F)
        TxtFilter.Location = New Point(29, 116)
        TxtFilter.Margin = New Padding(4, 5, 4, 5)
        TxtFilter.Name = "TxtFilter"
        TxtFilter.Size = New Size(356, 34)
        TxtFilter.TabIndex = 5
        ' 
        ' TxtCari
        ' 
        TxtCari.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TxtCari.BorderStyle = BorderStyle.FixedSingle
        TxtCari.Font = New Font("Segoe UI", 10F)
        TxtCari.ForeColor = Color.Gray
        TxtCari.Location = New Point(898, 116)
        TxtCari.Margin = New Padding(4, 5, 4, 5)
        TxtCari.Name = "TxtCari"
        TxtCari.PlaceholderText = "Cari Barang..."
        TxtCari.Size = New Size(342, 34)
        TxtCari.TabIndex = 6
        ' 
        ' DgvDataBarang
        ' 
        DgvDataBarang.AllowUserToAddRows = False
        DgvDataBarang.AllowUserToDeleteRows = False
        DgvDataBarang.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DgvDataBarang.BackgroundColor = Color.White
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DgvDataBarang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DgvDataBarang.ColumnHeadersHeight = 30
        DgvDataBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgvDataBarang.Columns.AddRange(New DataGridViewColumn() {ColKodeBarang, ColNamaBarang, ColKategori, ColUkuran, ColWarna, ColHarga, ColStok})
        DgvDataBarang.EnableHeadersVisualStyles = False
        DgvDataBarang.Location = New Point(29, 184)
        DgvDataBarang.Margin = New Padding(4, 5, 4, 5)
        DgvDataBarang.Name = "DgvDataBarang"
        DgvDataBarang.ReadOnly = True
        DgvDataBarang.RowHeadersVisible = False
        DgvDataBarang.RowHeadersWidth = 51
        DgvDataBarang.RowTemplate.Height = 25
        DgvDataBarang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvDataBarang.Size = New Size(1213, 366)
        DgvDataBarang.TabIndex = 7
        ' 
        ' ColKodeBarang
        ' 
        ColKodeBarang.HeaderText = "Kode Barang"
        ColKodeBarang.MinimumWidth = 6
        ColKodeBarang.Name = "ColKodeBarang"
        ColKodeBarang.ReadOnly = True
        ColKodeBarang.Width = 110
        ' 
        ' ColNamaBarang
        ' 
        ColNamaBarang.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ColNamaBarang.HeaderText = "Nama Barang"
        ColNamaBarang.MinimumWidth = 6
        ColNamaBarang.Name = "ColNamaBarang"
        ColNamaBarang.ReadOnly = True
        ' 
        ' ColKategori
        ' 
        ColKategori.HeaderText = "Kategori"
        ColKategori.MinimumWidth = 6
        ColKategori.Name = "ColKategori"
        ColKategori.ReadOnly = True
        ColKategori.Width = 120
        ' 
        ' ColUkuran
        ' 
        ColUkuran.HeaderText = "Ukuran"
        ColUkuran.MinimumWidth = 6
        ColUkuran.Name = "ColUkuran"
        ColUkuran.ReadOnly = True
        ColUkuran.Width = 70
        ' 
        ' ColWarna
        ' 
        ColWarna.HeaderText = "Warna"
        ColWarna.MinimumWidth = 6
        ColWarna.Name = "ColWarna"
        ColWarna.ReadOnly = True
        ColWarna.Width = 80
        ' 
        ' ColHarga
        ' 
        ColHarga.HeaderText = "Harga"
        ColHarga.MinimumWidth = 6
        ColHarga.Name = "ColHarga"
        ColHarga.ReadOnly = True
        ColHarga.Width = 125
        ' 
        ' ColStok
        ' 
        ColStok.HeaderText = "Stok"
        ColStok.MinimumWidth = 6
        ColStok.Name = "ColStok"
        ColStok.ReadOnly = True
        ColStok.Width = 60
        ' 
        ' LblTotalData
        ' 
        LblTotalData.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        LblTotalData.AutoSize = True
        LblTotalData.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblTotalData.Location = New Point(29, 866)
        LblTotalData.Margin = New Padding(4, 0, 4, 0)
        LblTotalData.Name = "LblTotalData"
        LblTotalData.Size = New Size(124, 25)
        LblTotalData.TabIndex = 8
        LblTotalData.Text = "Total Data : 6"
        ' 
        ' PanelDetail
        ' 
        PanelDetail.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        PanelDetail.BorderStyle = BorderStyle.FixedSingle
        PanelDetail.Controls.Add(LblValStok)
        PanelDetail.Controls.Add(LblValHarga)
        PanelDetail.Controls.Add(LblValKategori)
        PanelDetail.Controls.Add(LblValNama)
        PanelDetail.Controls.Add(LblValKode)
        PanelDetail.Controls.Add(LblTtlStok)
        PanelDetail.Controls.Add(LblTtlHarga)
        PanelDetail.Controls.Add(LblTtlKategori)
        PanelDetail.Controls.Add(LblTtlNama)
        PanelDetail.Controls.Add(LblTtlKode)
        PanelDetail.Controls.Add(PictureBoxBarang)
        PanelDetail.Location = New Point(669, 575)
        PanelDetail.Margin = New Padding(4, 5, 4, 5)
        PanelDetail.Name = "PanelDetail"
        PanelDetail.Size = New Size(571, 316)
        PanelDetail.TabIndex = 9
        ' 
        ' LblValStok
        ' 
        LblValStok.AutoSize = True
        LblValStok.Location = New Point(371, 234)
        LblValStok.Margin = New Padding(4, 0, 4, 0)
        LblValStok.Name = "LblValStok"
        LblValStok.Size = New Size(32, 25)
        LblValStok.TabIndex = 10
        LblValStok.Text = "25"
        ' 
        ' LblValHarga
        ' 
        LblValHarga.AutoSize = True
        LblValHarga.Location = New Point(371, 184)
        LblValHarga.Margin = New Padding(4, 0, 4, 0)
        LblValHarga.Name = "LblValHarga"
        LblValHarga.Size = New Size(76, 25)
        LblValHarga.TabIndex = 9
        LblValHarga.Text = "150.000"
        ' 
        ' LblValKategori
        ' 
        LblValKategori.AutoSize = True
        LblValKategori.Location = New Point(371, 134)
        LblValKategori.Margin = New Padding(4, 0, 4, 0)
        LblValKategori.Name = "LblValKategori"
        LblValKategori.Size = New Size(69, 25)
        LblValKategori.TabIndex = 8
        LblValKategori.Text = "Kemeja"
        ' 
        ' LblValNama
        ' 
        LblValNama.AutoSize = True
        LblValNama.Location = New Point(371, 84)
        LblValNama.Margin = New Padding(4, 0, 4, 0)
        LblValNama.Name = "LblValNama"
        LblValNama.Size = New Size(129, 25)
        LblValNama.TabIndex = 7
        LblValNama.Text = "Kemeja Formal"
        ' 
        ' LblValKode
        ' 
        LblValKode.AutoSize = True
        LblValKode.Location = New Point(371, 34)
        LblValKode.Margin = New Padding(4, 0, 4, 0)
        LblValKode.Name = "LblValKode"
        LblValKode.Size = New Size(75, 25)
        LblValKode.TabIndex = 6
        LblValKode.Text = "BRG001"
        ' 
        ' LblTtlStok
        ' 
        LblTtlStok.AutoSize = True
        LblTtlStok.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblTtlStok.Location = New Point(214, 234)
        LblTtlStok.Margin = New Padding(4, 0, 4, 0)
        LblTtlStok.Name = "LblTtlStok"
        LblTtlStok.Size = New Size(50, 25)
        LblTtlStok.TabIndex = 5
        LblTtlStok.Text = "Stok"
        ' 
        ' LblTtlHarga
        ' 
        LblTtlHarga.AutoSize = True
        LblTtlHarga.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblTtlHarga.Location = New Point(214, 184)
        LblTtlHarga.Margin = New Padding(4, 0, 4, 0)
        LblTtlHarga.Name = "LblTtlHarga"
        LblTtlHarga.Size = New Size(64, 25)
        LblTtlHarga.TabIndex = 4
        LblTtlHarga.Text = "Harga"
        ' 
        ' LblTtlKategori
        ' 
        LblTtlKategori.AutoSize = True
        LblTtlKategori.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblTtlKategori.Location = New Point(214, 134)
        LblTtlKategori.Margin = New Padding(4, 0, 4, 0)
        LblTtlKategori.Name = "LblTtlKategori"
        LblTtlKategori.Size = New Size(85, 25)
        LblTtlKategori.TabIndex = 3
        LblTtlKategori.Text = "Kategori"
        ' 
        ' LblTtlNama
        ' 
        LblTtlNama.AutoSize = True
        LblTtlNama.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblTtlNama.Location = New Point(214, 84)
        LblTtlNama.Margin = New Padding(4, 0, 4, 0)
        LblTtlNama.Name = "LblTtlNama"
        LblTtlNama.Size = New Size(128, 25)
        LblTtlNama.TabIndex = 2
        LblTtlNama.Text = "Nama Barang"
        ' 
        ' LblTtlKode
        ' 
        LblTtlKode.AutoSize = True
        LblTtlKode.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblTtlKode.Location = New Point(214, 34)
        LblTtlKode.Margin = New Padding(4, 0, 4, 0)
        LblTtlKode.Name = "LblTtlKode"
        LblTtlKode.Size = New Size(122, 25)
        LblTtlKode.TabIndex = 1
        LblTtlKode.Text = "Kode Barang"
        ' 
        ' PictureBoxBarang
        ' 
        PictureBoxBarang.BorderStyle = BorderStyle.FixedSingle
        PictureBoxBarang.Location = New Point(21, 25)
        PictureBoxBarang.Margin = New Padding(4, 5, 4, 5)
        PictureBoxBarang.Name = "PictureBoxBarang"
        PictureBoxBarang.Size = New Size(171, 257)
        PictureBoxBarang.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxBarang.TabIndex = 0
        PictureBoxBarang.TabStop = False
        ' 
        ' FormDataBarang
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1269, 916)
        Controls.Add(PanelDetail)
        Controls.Add(LblTotalData)
        Controls.Add(DgvDataBarang)
        Controls.Add(TxtCari)
        Controls.Add(TxtFilter)
        Controls.Add(BtnHapusItem)
        Controls.Add(BtnUbah)
        Controls.Add(BtnTambah)
        Margin = New Padding(4, 5, 4, 5)
        Name = "FormDataBarang"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Data Barang"
        CType(DgvDataBarang, ComponentModel.ISupportInitialize).EndInit()
        PanelDetail.ResumeLayout(False)
        PanelDetail.PerformLayout()
        CType(PictureBoxBarang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnHapusItem As System.Windows.Forms.Button
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