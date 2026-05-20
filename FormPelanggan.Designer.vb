<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPelanggan
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
        BtnUbah = New Button()
        BtnHapus = New Button()
        TxtCari = New TextBox()
        DgvPelanggan = New DataGridView()
        ColKodePelanggan = New DataGridViewTextBoxColumn()
        ColNamaPelanggan = New DataGridViewTextBoxColumn()
        ColNoTelepon = New DataGridViewTextBoxColumn()
        ColKota = New DataGridViewTextBoxColumn()
        CType(DgvPelanggan, ComponentModel.ISupportInitialize).BeginInit()
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
        ' BtnUbah
        ' 
        BtnUbah.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        BtnUbah.FlatAppearance.BorderSize = 0
        BtnUbah.FlatStyle = FlatStyle.Flat
        BtnUbah.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnUbah.ForeColor = Color.Black
        BtnUbah.Location = New Point(143, 27)
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
        BtnHapus.Location = New Point(263, 27)
        BtnHapus.Margin = New Padding(3, 4, 3, 4)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(109, 47)
        BtnHapus.TabIndex = 3
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = False
        ' 
        ' TxtCari
        ' 
        TxtCari.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        TxtCari.BorderStyle = BorderStyle.FixedSingle
        TxtCari.Font = New Font("Segoe UI", 11F)
        TxtCari.ForeColor = Color.Gray
        TxtCari.Location = New Point(378, 42)
        TxtCari.Margin = New Padding(3, 4, 3, 4)
        TxtCari.Name = "TxtCari"
        TxtCari.PlaceholderText = "Cari Pelanggan...."
        TxtCari.Size = New Size(491, 32)
        TxtCari.TabIndex = 5
        ' 
        ' DgvPelanggan
        ' 
        DgvPelanggan.AllowUserToAddRows = False
        DgvPelanggan.AllowUserToDeleteRows = False
        DgvPelanggan.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DgvPelanggan.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(240))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DgvPelanggan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DgvPelanggan.ColumnHeadersHeight = 30
        DgvPelanggan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DgvPelanggan.Columns.AddRange(New DataGridViewColumn() {ColKodePelanggan, ColNamaPelanggan, ColNoTelepon, ColKota})
        DgvPelanggan.EnableHeadersVisualStyles = False
        DgvPelanggan.Location = New Point(23, 100)
        DgvPelanggan.Margin = New Padding(3, 4, 3, 4)
        DgvPelanggan.Name = "DgvPelanggan"
        DgvPelanggan.ReadOnly = True
        DgvPelanggan.RowHeadersVisible = False
        DgvPelanggan.RowHeadersWidth = 51
        DgvPelanggan.RowTemplate.Height = 25
        DgvPelanggan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DgvPelanggan.Size = New Size(846, 453)
        DgvPelanggan.TabIndex = 6
        ' 
        ' ColKodePelanggan
        ' 
        ColKodePelanggan.HeaderText = "Kode Pelanggan"
        ColKodePelanggan.MinimumWidth = 6
        ColKodePelanggan.Name = "ColKodePelanggan"
        ColKodePelanggan.ReadOnly = True
        ColKodePelanggan.Width = 130
        ' 
        ' ColNamaPelanggan
        ' 
        ColNamaPelanggan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ColNamaPelanggan.HeaderText = "Nama Pelanggan"
        ColNamaPelanggan.MinimumWidth = 6
        ColNamaPelanggan.Name = "ColNamaPelanggan"
        ColNamaPelanggan.ReadOnly = True
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
        ' FormPelanggan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(891, 587)
        Controls.Add(DgvPelanggan)
        Controls.Add(TxtCari)
        Controls.Add(BtnHapus)
        Controls.Add(BtnUbah)
        Controls.Add(BtnTambah)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormPelanggan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pelanggan"
        CType(DgvPelanggan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents TxtCari As System.Windows.Forms.TextBox
    Friend WithEvents DgvPelanggan As System.Windows.Forms.DataGridView
    Friend WithEvents ColKodePelanggan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColNamaPelanggan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColNoTelepon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColKota As System.Windows.Forms.DataGridViewTextBoxColumn
End Class