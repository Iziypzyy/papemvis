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
        CType(DgvDataBarang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnTambah
        ' 
        BtnTambah.BackColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
        BtnTambah.FlatAppearance.BorderSize = 0
        BtnTambah.FlatStyle = FlatStyle.Flat
        BtnTambah.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnTambah.ForeColor = Color.White
        BtnTambah.Location = New Point(23, 27)
        BtnTambah.Margin = New Padding(3, 4, 3, 4)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(103, 47)
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
        BtnUbah.Location = New Point(138, 27)
        BtnUbah.Margin = New Padding(3, 4, 3, 4)
        BtnUbah.Name = "BtnUbah"
        BtnUbah.Size = New Size(103, 47)
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
        BtnHapusItem.Location = New Point(253, 27)
        BtnHapusItem.Margin = New Padding(3, 4, 3, 4)
        BtnHapusItem.Name = "BtnHapusItem"
        BtnHapusItem.Size = New Size(103, 47)
        BtnHapusItem.TabIndex = 3
        BtnHapusItem.Text = "Hapus"
        BtnHapusItem.UseVisualStyleBackColor = False
        ' 
        ' TxtFilter
        ' 
        TxtFilter.BorderStyle = BorderStyle.FixedSingle
        TxtFilter.Font = New Font("Segoe UI", 10F)
        TxtFilter.Location = New Point(23, 93)
        TxtFilter.Margin = New Padding(3, 4, 3, 4)
        TxtFilter.Name = "TxtFilter"
        TxtFilter.Size = New Size(285, 30)
        TxtFilter.TabIndex = 5
        ' 
        ' TxtCari
        ' 
        TxtCari.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TxtCari.BorderStyle = BorderStyle.FixedSingle
        TxtCari.Font = New Font("Segoe UI", 10F)
        TxtCari.ForeColor = Color.Gray
        TxtCari.Location = New Point(718, 93)
        TxtCari.Margin = New Padding(3, 4, 3, 4)
        TxtCari.Name = "TxtCari"
        TxtCari.PlaceholderText = "Cari Barang..."
        TxtCari.Size = New Size(274, 30)
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
        DgvDataBarang.Location = New Point(23, 147)
        DgvDataBarang.Margin = New Padding(3, 4, 3, 4)
        DgvDataBarang.Name = "DgvDataBarang"
        DgvDataBarang.ReadOnly = True
        DgvDataBarang.RowHeadersVisible = False
        DgvDataBarang.RowHeadersWidth = 51
        DgvDataBarang.RowTemplate.Height = 25
        DgvDataBarang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvDataBarang.Size = New Size(970, 380)
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
        LblTotalData.Location = New Point(25, 582)
        LblTotalData.Name = "LblTotalData"
        LblTotalData.Size = New Size(102, 20)
        LblTotalData.TabIndex = 8
        LblTotalData.Text = "Total Data : 6"
        ' 
        ' FormDataBarang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1015, 644)
        Controls.Add(LblTotalData)
        Controls.Add(DgvDataBarang)
        Controls.Add(TxtCari)
        Controls.Add(TxtFilter)
        Controls.Add(BtnHapusItem)
        Controls.Add(BtnUbah)
        Controls.Add(BtnTambah)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormDataBarang"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Data Barang"
        CType(DgvDataBarang, ComponentModel.ISupportInitialize).EndInit()
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
End Class