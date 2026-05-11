<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        BtnTambah = New Button()
        BtnSimpan = New Button()
        BtnUbah = New Button()
        BtnHapus = New Button()
        BtnCari = New Button()
        DgvSupplier = New DataGridView()
        ColKodeSupplier = New DataGridViewTextBoxColumn()
        ColNamaSupplier = New DataGridViewTextBoxColumn()
        ColNoTelepon = New DataGridViewTextBoxColumn()
        ColKota = New DataGridViewTextBoxColumn()
        CType(DgvSupplier, ComponentModel.ISupportInitialize).BeginInit()
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
        BtnTambah.Size = New Size(109, 47)
        BtnTambah.TabIndex = 0
        BtnTambah.Text = "+ Tambah"
        BtnTambah.UseVisualStyleBackColor = False
        ' 
        ' BtnSimpan
        ' 
        BtnSimpan.BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        BtnSimpan.FlatAppearance.BorderSize = 0
        BtnSimpan.FlatStyle = FlatStyle.Flat
        BtnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnSimpan.ForeColor = Color.White
        BtnSimpan.Location = New Point(143, 27)
        BtnSimpan.Margin = New Padding(3, 4, 3, 4)
        BtnSimpan.Name = "BtnSimpan"
        BtnSimpan.Size = New Size(109, 47)
        BtnSimpan.TabIndex = 1
        BtnSimpan.Text = "Simpan"
        BtnSimpan.UseVisualStyleBackColor = False
        ' 
        ' BtnUbah
        ' 
        BtnUbah.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        BtnUbah.FlatAppearance.BorderSize = 0
        BtnUbah.FlatStyle = FlatStyle.Flat
        BtnUbah.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnUbah.ForeColor = Color.Black
        BtnUbah.Location = New Point(263, 27)
        BtnUbah.Margin = New Padding(3, 4, 3, 4)
        BtnUbah.Name = "BtnUbah"
        BtnUbah.Size = New Size(109, 47)
        BtnUbah.TabIndex = 2
        BtnUbah.Text = "Ubah"
        BtnUbah.UseVisualStyleBackColor = False
        ' 
        ' BtnHapus
        ' 
        BtnHapus.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        BtnHapus.FlatAppearance.BorderSize = 0
        BtnHapus.FlatStyle = FlatStyle.Flat
        BtnHapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnHapus.ForeColor = Color.White
        BtnHapus.Location = New Point(383, 27)
        BtnHapus.Margin = New Padding(3, 4, 3, 4)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(109, 47)
        BtnHapus.TabIndex = 3
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = False
        ' 
        ' BtnCari
        ' 
        BtnCari.BackColor = Color.FromArgb(CByte(226), CByte(230), CByte(234))
        BtnCari.FlatAppearance.BorderSize = 0
        BtnCari.FlatStyle = FlatStyle.Flat
        BtnCari.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnCari.ForeColor = Color.Black
        BtnCari.Location = New Point(503, 27)
        BtnCari.Margin = New Padding(3, 4, 3, 4)
        BtnCari.Name = "BtnCari"
        BtnCari.Size = New Size(97, 47)
        BtnCari.TabIndex = 4
        BtnCari.Text = "Cari"
        BtnCari.UseVisualStyleBackColor = False
        ' 
        ' DgvSupplier
        ' 
        DgvSupplier.AllowUserToAddRows = False
        DgvSupplier.AllowUserToDeleteRows = False
        DgvSupplier.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DgvSupplier.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DgvSupplier.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DgvSupplier.ColumnHeadersHeight = 30
        DgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgvSupplier.Columns.AddRange(New DataGridViewColumn() {ColKodeSupplier, ColNamaSupplier, ColNoTelepon, ColKota})
        DgvSupplier.EnableHeadersVisualStyles = False
        DgvSupplier.Location = New Point(23, 100)
        DgvSupplier.Margin = New Padding(3, 4, 3, 4)
        DgvSupplier.Name = "DgvSupplier"
        DgvSupplier.ReadOnly = True
        DgvSupplier.RowHeadersVisible = False
        DgvSupplier.RowHeadersWidth = 51
        DgvSupplier.RowTemplate.Height = 25
        DgvSupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvSupplier.Size = New Size(846, 453)
        DgvSupplier.TabIndex = 5
        ' 
        ' ColKodeSupplier
        ' 
        ColKodeSupplier.HeaderText = "Kode Supplier"
        ColKodeSupplier.MinimumWidth = 6
        ColKodeSupplier.Name = "ColKodeSupplier"
        ColKodeSupplier.ReadOnly = True
        ColKodeSupplier.Width = 120
        ' 
        ' ColNamaSupplier
        ' 
        ColNamaSupplier.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ColNamaSupplier.HeaderText = "Nama Supplier"
        ColNamaSupplier.MinimumWidth = 6
        ColNamaSupplier.Name = "ColNamaSupplier"
        ColNamaSupplier.ReadOnly = True
        ' 
        ' ColNoTelepon
        ' 
        ColNoTelepon.HeaderText = "No. Telepon"
        ColNoTelepon.MinimumWidth = 6
        ColNoTelepon.Name = "ColNoTelepon"
        ColNoTelepon.ReadOnly = True
        ColNoTelepon.Width = 150
        ' 
        ' ColKota
        ' 
        ColKota.HeaderText = "Kota"
        ColKota.MinimumWidth = 6
        ColKota.Name = "ColKota"
        ColKota.ReadOnly = True
        ColKota.Width = 150
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(891, 587)
        Controls.Add(DgvSupplier)
        Controls.Add(BtnCari)
        Controls.Add(BtnHapus)
        Controls.Add(BtnUbah)
        Controls.Add(BtnSimpan)
        Controls.Add(BtnTambah)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Supplier"
        CType(DgvSupplier, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents DgvSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents ColKodeSupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColNamaSupplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColNoTelepon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColKota As System.Windows.Forms.DataGridViewTextBoxColumn
End Class