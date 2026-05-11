<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormStokBarang
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
    Friend WithEvents txtCari As System.Windows.Forms.TextBox

    Friend WithEvents dgvStok As System.Windows.Forms.DataGridView
    Friend WithEvents colKode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStokMin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSatuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn

    ' Bagian Footer / Keterangan Bawah
    Friend WithEvents lblTotalData As System.Windows.Forms.Label

    Friend WithEvents pnlWarnaAman As System.Windows.Forms.Panel
    Friend WithEvents lblKetAman As System.Windows.Forms.Label

    Friend WithEvents pnlWarnaMenipis As System.Windows.Forms.Panel
    Friend WithEvents lblKetMenipis As System.Windows.Forms.Label

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        txtCari = New TextBox()
        dgvStok = New DataGridView()
        colKode = New DataGridViewTextBoxColumn()
        colNama = New DataGridViewTextBoxColumn()
        colStok = New DataGridViewTextBoxColumn()
        colStokMin = New DataGridViewTextBoxColumn()
        colSatuan = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        lblTotalData = New Label()
        pnlWarnaAman = New Panel()
        lblKetAman = New Label()
        pnlWarnaMenipis = New Panel()
        lblKetMenipis = New Label()
        CType(dgvStok, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtCari
        ' 
        txtCari.Font = New Font("Segoe UI", 9.5F)
        txtCari.ForeColor = Color.Gray
        txtCari.Location = New Point(29, 33)
        txtCari.Margin = New Padding(3, 4, 3, 4)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(285, 29)
        txtCari.TabIndex = 6
        txtCari.Text = "Cari barang..."
        ' 
        ' dgvStok
        ' 
        dgvStok.AllowUserToAddRows = False
        dgvStok.AllowUserToDeleteRows = False
        dgvStok.BackgroundColor = Color.White
        dgvStok.ColumnHeadersHeight = 35
        dgvStok.Columns.AddRange(New DataGridViewColumn() {colKode, colNama, colStok, colStokMin, colSatuan, colStatus})
        dgvStok.Location = New Point(29, 87)
        dgvStok.Margin = New Padding(3, 4, 3, 4)
        dgvStok.Name = "dgvStok"
        dgvStok.ReadOnly = True
        dgvStok.RowHeadersVisible = False
        dgvStok.RowHeadersWidth = 51
        dgvStok.RowTemplate.Height = 30
        dgvStok.Size = New Size(743, 560)
        dgvStok.TabIndex = 5
        ' 
        ' colKode
        ' 
        colKode.HeaderText = "Kode Barang"
        colKode.MinimumWidth = 6
        colKode.Name = "colKode"
        colKode.ReadOnly = True
        colKode.Width = 125
        ' 
        ' colNama
        ' 
        colNama.HeaderText = "Nama Barang"
        colNama.MinimumWidth = 6
        colNama.Name = "colNama"
        colNama.ReadOnly = True
        colNama.Width = 200
        ' 
        ' colStok
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        colStok.DefaultCellStyle = DataGridViewCellStyle1
        colStok.HeaderText = "Stok"
        colStok.MinimumWidth = 6
        colStok.Name = "colStok"
        colStok.ReadOnly = True
        colStok.Width = 60
        ' 
        ' colStokMin
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        colStokMin.DefaultCellStyle = DataGridViewCellStyle2
        colStokMin.HeaderText = "Stok Min"
        colStokMin.MinimumWidth = 6
        colStokMin.Name = "colStokMin"
        colStokMin.ReadOnly = True
        colStokMin.Width = 80
        ' 
        ' colSatuan
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        colSatuan.DefaultCellStyle = DataGridViewCellStyle3
        colSatuan.HeaderText = "Satuan"
        colSatuan.MinimumWidth = 6
        colSatuan.Name = "colSatuan"
        colSatuan.ReadOnly = True
        colSatuan.Width = 70
        ' 
        ' colStatus
        ' 
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        colStatus.DefaultCellStyle = DataGridViewCellStyle4
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 6
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        colStatus.Width = 90
        ' 
        ' lblTotalData
        ' 
        lblTotalData.AutoSize = True
        lblTotalData.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblTotalData.Location = New Point(29, 680)
        lblTotalData.Name = "lblTotalData"
        lblTotalData.Size = New Size(102, 20)
        lblTotalData.TabIndex = 4
        lblTotalData.Text = "Total Data : 7"
        ' 
        ' pnlWarnaAman
        ' 
        pnlWarnaAman.BackColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
        pnlWarnaAman.Location = New Point(560, 680)
        pnlWarnaAman.Margin = New Padding(3, 4, 3, 4)
        pnlWarnaAman.Name = "pnlWarnaAman"
        pnlWarnaAman.Size = New Size(17, 20)
        pnlWarnaAman.TabIndex = 3
        ' 
        ' lblKetAman
        ' 
        lblKetAman.AutoSize = True
        lblKetAman.Location = New Point(583, 680)
        lblKetAman.Name = "lblKetAman"
        lblKetAman.Size = New Size(48, 20)
        lblKetAman.TabIndex = 2
        lblKetAman.Text = "Aman"
        ' 
        ' pnlWarnaMenipis
        ' 
        pnlWarnaMenipis.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        pnlWarnaMenipis.Location = New Point(663, 680)
        pnlWarnaMenipis.Margin = New Padding(3, 4, 3, 4)
        pnlWarnaMenipis.Name = "pnlWarnaMenipis"
        pnlWarnaMenipis.Size = New Size(17, 20)
        pnlWarnaMenipis.TabIndex = 1
        ' 
        ' lblKetMenipis
        ' 
        lblKetMenipis.AutoSize = True
        lblKetMenipis.Location = New Point(686, 680)
        lblKetMenipis.Name = "lblKetMenipis"
        lblKetMenipis.Size = New Size(61, 20)
        lblKetMenipis.TabIndex = 0
        lblKetMenipis.Text = "Menipis"
        ' 
        ' FormStokBarang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(800, 747)
        Controls.Add(lblKetMenipis)
        Controls.Add(pnlWarnaMenipis)
        Controls.Add(lblKetAman)
        Controls.Add(pnlWarnaAman)
        Controls.Add(lblTotalData)
        Controls.Add(dgvStok)
        Controls.Add(txtCari)
        Font = New Font("Segoe UI", 9F)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormStokBarang"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Stok Barang"
        CType(dgvStok, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
End Class