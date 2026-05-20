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
        LblTitle = New Label()
        LblNoTransaksi = New Label()
        TxtNoTransaksi = New TextBox()
        LblTotal = New Label()
        TxtTotal = New TextBox()
        LblBank = New Label()
        CboBank = New ComboBox()
        LblBukti = New Label()
        PicBukti = New PictureBox()
        BtnPilihFile = New Button()
        BtnKonfirmasi = New Button()
        BtnBatal = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        CType(PicBukti, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LblTitle
        ' 
        LblTitle.AutoSize = True
        LblTitle.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        LblTitle.Location = New Point(23, 27)
        LblTitle.Name = "LblTitle"
        LblTitle.Size = New Size(352, 37)
        LblTitle.TabIndex = 0
        LblTitle.Text = "Upload Bukti Pembayaran"
        ' 
        ' LblNoTransaksi
        ' 
        LblNoTransaksi.AutoSize = True
        LblNoTransaksi.Font = New Font("Segoe UI", 9.75F)
        LblNoTransaksi.ForeColor = Color.DimGray
        LblNoTransaksi.Location = New Point(25, 93)
        LblNoTransaksi.Name = "LblNoTransaksi"
        LblNoTransaksi.Size = New Size(110, 23)
        LblNoTransaksi.TabIndex = 1
        LblNoTransaksi.Text = "No. Transaksi"
        ' 
        ' TxtNoTransaksi
        ' 
        TxtNoTransaksi.Font = New Font("Segoe UI", 11F)
        TxtNoTransaksi.Location = New Point(29, 120)
        TxtNoTransaksi.Margin = New Padding(3, 4, 3, 4)
        TxtNoTransaksi.Name = "TxtNoTransaksi"
        TxtNoTransaksi.ReadOnly = True
        TxtNoTransaksi.Size = New Size(382, 32)
        TxtNoTransaksi.TabIndex = 2
        TxtNoTransaksi.Text = "TRS2405220001"
        ' 
        ' LblTotal
        ' 
        LblTotal.AutoSize = True
        LblTotal.Font = New Font("Segoe UI", 9.75F)
        LblTotal.ForeColor = Color.DimGray
        LblTotal.Location = New Point(25, 173)
        LblTotal.Name = "LblTotal"
        LblTotal.Size = New Size(110, 23)
        LblTotal.TabIndex = 3
        LblTotal.Text = "Total Tagihan"
        ' 
        ' TxtTotal
        ' 
        TxtTotal.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        TxtTotal.ForeColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        TxtTotal.Location = New Point(29, 200)
        TxtTotal.Margin = New Padding(3, 4, 3, 4)
        TxtTotal.Name = "TxtTotal"
        TxtTotal.ReadOnly = True
        TxtTotal.Size = New Size(382, 32)
        TxtTotal.TabIndex = 4
        TxtTotal.Text = "Rp 600.000"
        ' 
        ' LblBank
        ' 
        LblBank.AutoSize = True
        LblBank.Font = New Font("Segoe UI", 9.75F)
        LblBank.ForeColor = Color.DimGray
        LblBank.Location = New Point(25, 253)
        LblBank.Name = "LblBank"
        LblBank.Size = New Size(169, 23)
        LblBank.TabIndex = 5
        LblBank.Text = "Bank Tujuan Transfer"
        ' 
        ' CboBank
        ' 
        CboBank.DropDownStyle = ComboBoxStyle.DropDownList
        CboBank.Font = New Font("Segoe UI", 11F)
        CboBank.FormattingEnabled = True
        CboBank.Items.AddRange(New Object() {"BCA - 1234567890 a.n My Store", "Mandiri - 0987654321 a.n My Store", "BRI - 1122334455 a.n My Store"})
        CboBank.Location = New Point(29, 280)
        CboBank.Margin = New Padding(3, 4, 3, 4)
        CboBank.Name = "CboBank"
        CboBank.Size = New Size(382, 33)
        CboBank.TabIndex = 6
        ' 
        ' LblBukti
        ' 
        LblBukti.AutoSize = True
        LblBukti.Font = New Font("Segoe UI", 9.75F)
        LblBukti.ForeColor = Color.DimGray
        LblBukti.Location = New Point(25, 347)
        LblBukti.Name = "LblBukti"
        LblBukti.Size = New Size(152, 23)
        LblBukti.TabIndex = 7
        LblBukti.Text = "Foto Bukti Transfer"
        ' 
        ' PicBukti
        ' 
        PicBukti.BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        PicBukti.BorderStyle = BorderStyle.FixedSingle
        PicBukti.Location = New Point(29, 373)
        PicBukti.Margin = New Padding(3, 4, 3, 4)
        PicBukti.Name = "PicBukti"
        PicBukti.Size = New Size(383, 266)
        PicBukti.SizeMode = PictureBoxSizeMode.Zoom
        PicBukti.TabIndex = 8
        PicBukti.TabStop = False
        ' 
        ' BtnPilihFile
        ' 
        BtnPilihFile.BackColor = Color.FromArgb(CByte(108), CByte(117), CByte(125))
        BtnPilihFile.FlatAppearance.BorderSize = 0
        BtnPilihFile.FlatStyle = FlatStyle.Flat
        BtnPilihFile.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnPilihFile.ForeColor = Color.White
        BtnPilihFile.Location = New Point(29, 653)
        BtnPilihFile.Margin = New Padding(3, 4, 3, 4)
        BtnPilihFile.Name = "BtnPilihFile"
        BtnPilihFile.Size = New Size(383, 47)
        BtnPilihFile.TabIndex = 9
        BtnPilihFile.Text = "Pilih Gambar..."
        BtnPilihFile.UseVisualStyleBackColor = False
        ' 
        ' BtnKonfirmasi
        ' 
        BtnKonfirmasi.BackColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
        BtnKonfirmasi.FlatAppearance.BorderSize = 0
        BtnKonfirmasi.FlatStyle = FlatStyle.Flat
        BtnKonfirmasi.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        BtnKonfirmasi.ForeColor = Color.White
        BtnKonfirmasi.Location = New Point(229, 727)
        BtnKonfirmasi.Margin = New Padding(3, 4, 3, 4)
        BtnKonfirmasi.Name = "BtnKonfirmasi"
        BtnKonfirmasi.Size = New Size(183, 53)
        BtnKonfirmasi.TabIndex = 10
        BtnKonfirmasi.Text = "Konfirmasi"
        BtnKonfirmasi.UseVisualStyleBackColor = False
        ' 
        ' BtnBatal
        ' 
        BtnBatal.BackColor = Color.FromArgb(CByte(226), CByte(230), CByte(234))
        BtnBatal.FlatAppearance.BorderSize = 0
        BtnBatal.FlatStyle = FlatStyle.Flat
        BtnBatal.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        BtnBatal.ForeColor = Color.Black
        BtnBatal.Location = New Point(29, 727)
        BtnBatal.Margin = New Padding(3, 4, 3, 4)
        BtnBatal.Name = "BtnBatal"
        BtnBatal.Size = New Size(183, 53)
        BtnBatal.TabIndex = 11
        BtnBatal.Text = "Batal"
        BtnBatal.UseVisualStyleBackColor = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        OpenFileDialog1.Title = "Pilih Bukti Pembayaran"
        ' 
        ' FormBuktiPembayaran
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(440, 813)
        Controls.Add(BtnBatal)
        Controls.Add(BtnKonfirmasi)
        Controls.Add(BtnPilihFile)
        Controls.Add(PicBukti)
        Controls.Add(LblBukti)
        Controls.Add(CboBank)
        Controls.Add(LblBank)
        Controls.Add(TxtTotal)
        Controls.Add(LblTotal)
        Controls.Add(TxtNoTransaksi)
        Controls.Add(LblNoTransaksi)
        Controls.Add(LblTitle)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FormBuktiPembayaran"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bukti Pembayaran"
        CType(PicBukti, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

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