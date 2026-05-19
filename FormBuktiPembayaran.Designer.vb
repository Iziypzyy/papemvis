<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBuktiPembayaran
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
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblNoTransaksi = New System.Windows.Forms.Label()
        Me.TxtNoTransaksi = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.LblBank = New System.Windows.Forms.Label()
        Me.CboBank = New System.Windows.Forms.ComboBox()
        Me.LblBukti = New System.Windows.Forms.Label()
        Me.PicBukti = New System.Windows.Forms.PictureBox()
        Me.BtnPilihFile = New System.Windows.Forms.Button()
        Me.BtnKonfirmasi = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PicBukti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblTitle.Location = New System.Drawing.Point(20, 20)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(273, 30)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "Upload Bukti Pembayaran"
        '
        'LblNoTransaksi
        '
        Me.LblNoTransaksi.AutoSize = True
        Me.LblNoTransaksi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblNoTransaksi.ForeColor = System.Drawing.Color.DimGray
        Me.LblNoTransaksi.Location = New System.Drawing.Point(22, 70)
        Me.LblNoTransaksi.Name = "LblNoTransaksi"
        Me.LblNoTransaksi.Size = New System.Drawing.Size(84, 17)
        Me.LblNoTransaksi.TabIndex = 1
        Me.LblNoTransaksi.Text = "No. Transaksi"
        '
        'TxtNoTransaksi
        '
        Me.TxtNoTransaksi.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtNoTransaksi.Location = New System.Drawing.Point(25, 90)
        Me.TxtNoTransaksi.Name = "TxtNoTransaksi"
        Me.TxtNoTransaksi.ReadOnly = True
        Me.TxtNoTransaksi.Size = New System.Drawing.Size(335, 27)
        Me.TxtNoTransaksi.TabIndex = 2
        Me.TxtNoTransaksi.Text = "TRS2405220001"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblTotal.ForeColor = System.Drawing.Color.DimGray
        Me.LblTotal.Location = New System.Drawing.Point(22, 130)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(89, 17)
        Me.LblTotal.TabIndex = 3
        Me.LblTotal.Text = "Total Tagihan"
        '
        'TxtTotal
        '
        Me.TxtTotal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.TxtTotal.Location = New System.Drawing.Point(25, 150)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(335, 27)
        Me.TxtTotal.TabIndex = 4
        Me.TxtTotal.Text = "Rp 600.000"
        '
        'LblBank
        '
        Me.LblBank.AutoSize = True
        Me.LblBank.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblBank.ForeColor = System.Drawing.Color.DimGray
        Me.LblBank.Location = New System.Drawing.Point(22, 190)
        Me.LblBank.Name = "LblBank"
        Me.LblBank.Size = New System.Drawing.Size(125, 17)
        Me.LblBank.TabIndex = 5
        Me.LblBank.Text = "Bank Tujuan Transfer"
        '
        'CboBank
        '
        Me.CboBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBank.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CboBank.FormattingEnabled = True
        Me.CboBank.Items.AddRange(New Object() {"BCA - 1234567890 a.n My Store", "Mandiri - 0987654321 a.n My Store", "BRI - 1122334455 a.n My Store"})
        Me.CboBank.Location = New System.Drawing.Point(25, 210)
        Me.CboBank.Name = "CboBank"
        Me.CboBank.Size = New System.Drawing.Size(335, 28)
        Me.CboBank.TabIndex = 6
        '
        'LblBukti
        '
        Me.LblBukti.AutoSize = True
        Me.LblBukti.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblBukti.ForeColor = System.Drawing.Color.DimGray
        Me.LblBukti.Location = New System.Drawing.Point(22, 260)
        Me.LblBukti.Name = "LblBukti"
        Me.LblBukti.Size = New System.Drawing.Size(126, 17)
        Me.LblBukti.TabIndex = 7
        Me.LblBukti.Text = "Foto Bukti Transfer"
        '
        'PicBukti
        '
        Me.PicBukti.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.PicBukti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBukti.Location = New System.Drawing.Point(25, 280)
        Me.PicBukti.Name = "PicBukti"
        Me.PicBukti.Size = New System.Drawing.Size(335, 200)
        Me.PicBukti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBukti.TabIndex = 8
        Me.PicBukti.TabStop = False
        '
        'BtnPilihFile
        '
        Me.BtnPilihFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.BtnPilihFile.FlatAppearance.BorderSize = 0
        Me.BtnPilihFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPilihFile.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnPilihFile.ForeColor = System.Drawing.Color.White
        Me.BtnPilihFile.Location = New System.Drawing.Point(25, 490)
        Me.BtnPilihFile.Name = "BtnPilihFile"
        Me.BtnPilihFile.Size = New System.Drawing.Size(335, 35)
        Me.BtnPilihFile.TabIndex = 9
        Me.BtnPilihFile.Text = "Pilih Gambar..."
        Me.BtnPilihFile.UseVisualStyleBackColor = False
        '
        'BtnKonfirmasi
        '
        Me.BtnKonfirmasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BtnKonfirmasi.FlatAppearance.BorderSize = 0
        Me.BtnKonfirmasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKonfirmasi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnKonfirmasi.ForeColor = System.Drawing.Color.White
        Me.BtnKonfirmasi.Location = New System.Drawing.Point(200, 545)
        Me.BtnKonfirmasi.Name = "BtnKonfirmasi"
        Me.BtnKonfirmasi.Size = New System.Drawing.Size(160, 40)
        Me.BtnKonfirmasi.TabIndex = 10
        Me.BtnKonfirmasi.Text = "Konfirmasi"
        Me.BtnKonfirmasi.UseVisualStyleBackColor = False
        '
        'BtnBatal
        '
        Me.BtnBatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BtnBatal.FlatAppearance.BorderSize = 0
        Me.BtnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBatal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnBatal.ForeColor = System.Drawing.Color.Black
        Me.BtnBatal.Location = New System.Drawing.Point(25, 545)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(160, 40)
        Me.BtnBatal.TabIndex = 11
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        Me.OpenFileDialog1.Title = "Pilih Bukti Pembayaran"
        '
        'FormBuktiPembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(385, 610)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnKonfirmasi)
        Me.Controls.Add(Me.BtnPilihFile)
        Me.Controls.Add(Me.PicBukti)
        Me.Controls.Add(Me.LblBukti)
        Me.Controls.Add(Me.CboBank)
        Me.Controls.Add(Me.LblBank)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.TxtNoTransaksi)
        Me.Controls.Add(Me.LblNoTransaksi)
        Me.Controls.Add(Me.LblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBuktiPembayaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bukti Pembayaran"
        CType(Me.PicBukti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblNoTransaksi As System.Windows.Forms.Label
    Friend WithEvents TxtNoTransaksi As System.Windows.Forms.TextBox
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents LblBank As System.Windows.Forms.Label
    Friend WithEvents CboBank As System.Windows.Forms.ComboBox
    Friend WithEvents LblBukti As System.Windows.Forms.Label
    Friend WithEvents PicBukti As System.Windows.Forms.PictureBox
    Friend WithEvents BtnPilihFile As System.Windows.Forms.Button
    Friend WithEvents BtnKonfirmasi As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class