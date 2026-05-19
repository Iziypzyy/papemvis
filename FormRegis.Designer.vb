<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegis
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
        PnlSide = New Panel()
        LblMensWear = New Label()
        LblGentlemen = New Label()
        PictureBoxLogo = New PictureBox()
        LblBrandSub = New Label()
        LblTitle = New Label()
        LblNama = New Label()
        TxtNama = New TextBox()
        LblEmail = New Label()
        TxtEmail = New TextBox()
        LblNoTelepon = New Label()
        TxtNoTelepon = New TextBox()
        LblAlamat = New Label()
        TxtAlamat = New TextBox()
        LblPassword = New Label()
        TxtPassword = New TextBox()
        LblKonfirmasi = New Label()
        TxtKonfirmasi = New TextBox()
        BtnDaftar = New Button()
        LlblSudahPunyaAkun = New LinkLabel()
        LblSistemManajemen = New Label()
        LblTokoPakaianPria = New Label()
        PnlSide.SuspendLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlSide
        ' 
        PnlSide.BackColor = Color.FromArgb(CByte(10), CByte(25), CByte(47))
        PnlSide.Controls.Add(LblTokoPakaianPria)
        PnlSide.Controls.Add(LblSistemManajemen)
        PnlSide.Controls.Add(LblMensWear)
        PnlSide.Controls.Add(LblGentlemen)
        PnlSide.Controls.Add(PictureBoxLogo)
        PnlSide.Controls.Add(LblBrandSub)
        PnlSide.Dock = DockStyle.Left
        PnlSide.Location = New Point(0, 0)
        PnlSide.Margin = New Padding(3, 4, 3, 4)
        PnlSide.Name = "PnlSide"
        PnlSide.Size = New Size(320, 773)
        PnlSide.TabIndex = 0
        ' 
        ' LblMensWear
        ' 
        LblMensWear.AutoSize = True
        LblMensWear.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblMensWear.ForeColor = Color.White
        LblMensWear.Location = New Point(105, 338)
        LblMensWear.Name = "LblMensWear"
        LblMensWear.Size = New Size(103, 20)
        LblMensWear.TabIndex = 4
        LblMensWear.Text = "MEN'S WEAR"
        LblMensWear.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblGentlemen
        ' 
        LblGentlemen.AutoSize = True
        LblGentlemen.Font = New Font("Georgia", 14.25F, FontStyle.Bold)
        LblGentlemen.ForeColor = Color.Goldenrod
        LblGentlemen.Location = New Point(66, 303)
        LblGentlemen.Name = "LblGentlemen"
        LblGentlemen.Size = New Size(180, 29)
        LblGentlemen.TabIndex = 3
        LblGentlemen.Text = "GENTLEMEN"
        LblGentlemen.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBoxLogo
        ' 
        PictureBoxLogo.BackColor = Color.Transparent
        PictureBoxLogo.BackgroundImageLayout = ImageLayout.Stretch
        PictureBoxLogo.Image = My.Resources.Resources.Fashion_man_logo
        PictureBoxLogo.Location = New Point(67, 72)
        PictureBoxLogo.Margin = New Padding(3, 4, 3, 4)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(180, 180)
        PictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxLogo.TabIndex = 2
        PictureBoxLogo.TabStop = False
        ' 
        ' LblBrandSub
        ' 
        LblBrandSub.Font = New Font("Segoe UI", 10F)
        LblBrandSub.ForeColor = Color.White
        LblBrandSub.Location = New Point(27, 528)
        LblBrandSub.Name = "LblBrandSub"
        LblBrandSub.Size = New Size(263, 60)
        LblBrandSub.TabIndex = 1
        LblBrandSub.Text = "Bergabunglah dengan kami untuk kemudahan berbelanja."
        LblBrandSub.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblTitle
        ' 
        LblTitle.AutoSize = True
        LblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        LblTitle.Location = New Point(366, 40)
        LblTitle.Name = "LblTitle"
        LblTitle.Size = New Size(156, 41)
        LblTitle.TabIndex = 1
        LblTitle.Text = "Registrasi"
        ' 
        ' LblNama
        ' 
        LblNama.AutoSize = True
        LblNama.ForeColor = Color.DimGray
        LblNama.Location = New Point(371, 113)
        LblNama.Name = "LblNama"
        LblNama.Size = New Size(109, 20)
        LblNama.TabIndex = 2
        LblNama.Text = "Nama Lengkap"
        ' 
        ' TxtNama
        ' 
        TxtNama.Font = New Font("Segoe UI", 11F)
        TxtNama.Location = New Point(371, 140)
        TxtNama.Margin = New Padding(3, 4, 3, 4)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(399, 32)
        TxtNama.TabIndex = 3
        ' 
        ' LblEmail
        ' 
        LblEmail.AutoSize = True
        LblEmail.ForeColor = Color.DimGray
        LblEmail.Location = New Point(371, 193)
        LblEmail.Name = "LblEmail"
        LblEmail.Size = New Size(46, 20)
        LblEmail.TabIndex = 4
        LblEmail.Text = "Email"
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Font = New Font("Segoe UI", 11F)
        TxtEmail.Location = New Point(371, 220)
        TxtEmail.Margin = New Padding(3, 4, 3, 4)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(399, 32)
        TxtEmail.TabIndex = 5
        ' 
        ' LblNoTelepon
        ' 
        LblNoTelepon.AutoSize = True
        LblNoTelepon.ForeColor = Color.DimGray
        LblNoTelepon.Location = New Point(371, 273)
        LblNoTelepon.Name = "LblNoTelepon"
        LblNoTelepon.Size = New Size(86, 20)
        LblNoTelepon.TabIndex = 6
        LblNoTelepon.Text = "No Telepon"
        ' 
        ' TxtNoTelepon
        ' 
        TxtNoTelepon.Font = New Font("Segoe UI", 11F)
        TxtNoTelepon.Location = New Point(371, 300)
        TxtNoTelepon.Margin = New Padding(3, 4, 3, 4)
        TxtNoTelepon.Name = "TxtNoTelepon"
        TxtNoTelepon.Size = New Size(399, 32)
        TxtNoTelepon.TabIndex = 7
        ' 
        ' LblAlamat
        ' 
        LblAlamat.AutoSize = True
        LblAlamat.ForeColor = Color.DimGray
        LblAlamat.Location = New Point(371, 353)
        LblAlamat.Name = "LblAlamat"
        LblAlamat.Size = New Size(57, 20)
        LblAlamat.TabIndex = 8
        LblAlamat.Text = "Alamat"
        ' 
        ' TxtAlamat
        ' 
        TxtAlamat.Font = New Font("Segoe UI", 11F)
        TxtAlamat.Location = New Point(371, 380)
        TxtAlamat.Margin = New Padding(3, 4, 3, 4)
        TxtAlamat.Multiline = True
        TxtAlamat.Name = "TxtAlamat"
        TxtAlamat.Size = New Size(399, 65)
        TxtAlamat.TabIndex = 9
        ' 
        ' LblPassword
        ' 
        LblPassword.AutoSize = True
        LblPassword.ForeColor = Color.DimGray
        LblPassword.Location = New Point(371, 460)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(70, 20)
        LblPassword.TabIndex = 10
        LblPassword.Text = "Password"
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Font = New Font("Segoe UI", 11F)
        TxtPassword.Location = New Point(371, 487)
        TxtPassword.Margin = New Padding(3, 4, 3, 4)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.Size = New Size(399, 32)
        TxtPassword.TabIndex = 11
        TxtPassword.UseSystemPasswordChar = True
        ' 
        ' LblKonfirmasi
        ' 
        LblKonfirmasi.AutoSize = True
        LblKonfirmasi.ForeColor = Color.DimGray
        LblKonfirmasi.Location = New Point(371, 540)
        LblKonfirmasi.Name = "LblKonfirmasi"
        LblKonfirmasi.Size = New Size(145, 20)
        LblKonfirmasi.TabIndex = 12
        LblKonfirmasi.Text = "Konfirmasi Password"
        ' 
        ' TxtKonfirmasi
        ' 
        TxtKonfirmasi.Font = New Font("Segoe UI", 11F)
        TxtKonfirmasi.Location = New Point(371, 567)
        TxtKonfirmasi.Margin = New Padding(3, 4, 3, 4)
        TxtKonfirmasi.Name = "TxtKonfirmasi"
        TxtKonfirmasi.Size = New Size(399, 32)
        TxtKonfirmasi.TabIndex = 13
        TxtKonfirmasi.UseSystemPasswordChar = True
        ' 
        ' BtnDaftar
        ' 
        BtnDaftar.BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        BtnDaftar.FlatAppearance.BorderSize = 0
        BtnDaftar.FlatStyle = FlatStyle.Flat
        BtnDaftar.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        BtnDaftar.ForeColor = Color.White
        BtnDaftar.Location = New Point(371, 640)
        BtnDaftar.Margin = New Padding(3, 4, 3, 4)
        BtnDaftar.Name = "BtnDaftar"
        BtnDaftar.Size = New Size(400, 53)
        BtnDaftar.TabIndex = 14
        BtnDaftar.Text = "Daftar Sekarang"
        BtnDaftar.UseVisualStyleBackColor = False
        ' 
        ' LlblSudahPunyaAkun
        ' 
        LlblSudahPunyaAkun.AutoSize = True
        LlblSudahPunyaAkun.LinkColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        LlblSudahPunyaAkun.Location = New Point(480, 713)
        LlblSudahPunyaAkun.Name = "LlblSudahPunyaAkun"
        LlblSudahPunyaAkun.Size = New Size(182, 20)
        LlblSudahPunyaAkun.TabIndex = 15
        LlblSudahPunyaAkun.TabStop = True
        LlblSudahPunyaAkun.Text = "Sudah punya akun? Masuk"
        ' 
        ' LblSistemManajemen
        ' 
        LblSistemManajemen.AutoSize = True
        LblSistemManajemen.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblSistemManajemen.ForeColor = Color.White
        LblSistemManajemen.Location = New Point(85, 400)
        LblSistemManajemen.Name = "LblSistemManajemen"
        LblSistemManajemen.Size = New Size(142, 20)
        LblSistemManajemen.TabIndex = 5
        LblSistemManajemen.Text = "Sistem Manajemen"
        LblSistemManajemen.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblTokoPakaianPria
        ' 
        LblTokoPakaianPria.AutoSize = True
        LblTokoPakaianPria.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblTokoPakaianPria.ForeColor = Color.White
        LblTokoPakaianPria.Location = New Point(75, 426)
        LblTokoPakaianPria.Name = "LblTokoPakaianPria"
        LblTokoPakaianPria.Size = New Size(163, 25)
        LblTokoPakaianPria.TabIndex = 6
        LblTokoPakaianPria.Text = "Toko Pakaian Pria"
        LblTokoPakaianPria.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormRegis
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(823, 773)
        Controls.Add(LlblSudahPunyaAkun)
        Controls.Add(BtnDaftar)
        Controls.Add(TxtKonfirmasi)
        Controls.Add(LblKonfirmasi)
        Controls.Add(TxtPassword)
        Controls.Add(LblPassword)
        Controls.Add(TxtAlamat)
        Controls.Add(LblAlamat)
        Controls.Add(TxtNoTelepon)
        Controls.Add(LblNoTelepon)
        Controls.Add(TxtEmail)
        Controls.Add(LblEmail)
        Controls.Add(TxtNama)
        Controls.Add(LblNama)
        Controls.Add(LblTitle)
        Controls.Add(PnlSide)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "FormRegis"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registrasi Pelanggan"
        PnlSide.ResumeLayout(False)
        PnlSide.PerformLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents PnlSide As System.Windows.Forms.Panel
    Friend WithEvents LblBrandSub As System.Windows.Forms.Label
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblNama As System.Windows.Forms.Label
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents LblEmail As System.Windows.Forms.Label
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents LblNoTelepon As System.Windows.Forms.Label
    Friend WithEvents TxtNoTelepon As System.Windows.Forms.TextBox
    Friend WithEvents LblAlamat As System.Windows.Forms.Label
    Friend WithEvents TxtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents LblKonfirmasi As System.Windows.Forms.Label
    Friend WithEvents TxtKonfirmasi As System.Windows.Forms.TextBox
    Friend WithEvents BtnDaftar As System.Windows.Forms.Button
    Friend WithEvents LlblSudahPunyaAkun As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents LblGentlemen As Label
    Friend WithEvents LblMensWear As Label
    Friend WithEvents LblSistemManajemen As Label
    Friend WithEvents LblTokoPakaianPria As Label
End Class