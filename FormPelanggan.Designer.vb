<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPelanggan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.DgvPelanggan = New System.Windows.Forms.DataGridView()
        Me.ColKode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTelp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColKota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblTotalData = New System.Windows.Forms.Label()
        CType(Me.DgvPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnTambah
        '
        Me.BtnTambah.BackColor = System.Drawing.Color.FromArgb(40, 167, 69)
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambah.ForeColor = System.Drawing.Color.White
        Me.BtnTambah.Location = New System.Drawing.Point(16, 14)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(96, 36)
        Me.BtnTambah.TabIndex = 0
        Me.BtnTambah.Text = "+ Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.BackColor = System.Drawing.Color.FromArgb(13, 110, 253)
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSimpan.ForeColor = System.Drawing.Color.White
        Me.BtnSimpan.Location = New System.Drawing.Point(118, 14)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(96, 36)
        Me.BtnSimpan.TabIndex = 1
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = False
        Me.BtnSimpan.Visible = False
        '
        'BtnUbah
        '
        Me.BtnUbah.BackColor = System.Drawing.Color.FromArgb(255, 193, 7)
        Me.BtnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUbah.ForeColor = System.Drawing.Color.Black
        Me.BtnUbah.Location = New System.Drawing.Point(220, 14)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(96, 36)
        Me.BtnUbah.TabIndex = 2
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = False
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.FromArgb(220, 53, 69)
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.ForeColor = System.Drawing.Color.White
        Me.BtnHapus.Location = New System.Drawing.Point(322, 14)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(96, 36)
        Me.BtnHapus.TabIndex = 3
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'TxtCari
        '
        Me.TxtCari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCari.Location = New System.Drawing.Point(540, 20)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.PlaceholderText = "Cari pelanggan..."
        Me.TxtCari.Size = New System.Drawing.Size(260, 23)
        Me.TxtCari.TabIndex = 4
        '
        'DgvPelanggan
        '
        Me.DgvPelanggan.AllowUserToAddRows = False
        Me.DgvPelanggan.AllowUserToDeleteRows = False
        Me.DgvPelanggan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvPelanggan.BackgroundColor = System.Drawing.Color.White
        Me.DgvPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPelanggan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColKode, Me.ColNama, Me.ColTelp, Me.ColKota})
        Me.DgvPelanggan.Location = New System.Drawing.Point(16, 64)
        Me.DgvPelanggan.MultiSelect = False
        Me.DgvPelanggan.Name = "DgvPelanggan"
        Me.DgvPelanggan.ReadOnly = True
        Me.DgvPelanggan.RowHeadersVisible = False
        Me.DgvPelanggan.RowTemplate.Height = 25
        Me.DgvPelanggan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPelanggan.Size = New System.Drawing.Size(784, 360)
        Me.DgvPelanggan.TabIndex = 5
        '
        'ColKode
        '
        Me.ColKode.HeaderText = "Kode Pelanggan"
        Me.ColKode.Name = "ColKode"
        Me.ColKode.ReadOnly = True
        Me.ColKode.Width = 120
        '
        'ColNama
        '
        Me.ColNama.HeaderText = "Nama Pelanggan"
        Me.ColNama.Name = "ColNama"
        Me.ColNama.ReadOnly = True
        Me.ColNama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        '
        'ColTelp
        '
        Me.ColTelp.HeaderText = "No. Telepon"
        Me.ColTelp.Name = "ColTelp"
        Me.ColTelp.ReadOnly = True
        Me.ColTelp.Width = 140
        '
        'ColKota
        '
        Me.ColKota.HeaderText = "Kota / Alamat"
        Me.ColKota.Name = "ColKota"
        Me.ColKota.ReadOnly = True
        Me.ColKota.Width = 160
        '
        'LblTotalData
        '
        Me.LblTotalData.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblTotalData.AutoSize = True
        Me.LblTotalData.Location = New System.Drawing.Point(16, 432)
        Me.LblTotalData.Name = "LblTotalData"
        Me.LblTotalData.Size = New System.Drawing.Size(86, 15)
        Me.LblTotalData.TabIndex = 6
        Me.LblTotalData.Text = "Total Data : 0"
        '
        'FormPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 460)
        Me.Controls.Add(Me.LblTotalData)
        Me.Controls.Add(Me.DgvPelanggan)
        Me.Controls.Add(Me.TxtCari)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnTambah)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "FormPelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pelanggan"
        CType(Me.DgvPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents TxtCari As TextBox
    Friend WithEvents DgvPelanggan As DataGridView
    Friend WithEvents ColKode As DataGridViewTextBoxColumn
    Friend WithEvents ColNama As DataGridViewTextBoxColumn
    Friend WithEvents ColTelp As DataGridViewTextBoxColumn
    Friend WithEvents ColKota As DataGridViewTextBoxColumn
    Friend WithEvents LblTotalData As Label
End Class
