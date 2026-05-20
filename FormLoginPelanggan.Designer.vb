<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLoginPelanggan
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
        LblTokoPakaianPria = New Label()
        LblSistemManajemen = New Label()
        LblMensWear = New Label()
        LblGentlemen = New Label()
        PictureBoxLogo = New PictureBox()
        LblBrandSub = New Label()
        LblTitle = New Label()
        LblSubtitle = New Label()
        LblEmail = New Label()
        TxtEmail = New TextBox()
        LblPassword = New Label()
        TxtPassword = New TextBox()
        BtnLogin = New Button()
        LlblDaftar = New LinkLabel()
        LlblAdminArea = New LinkLabel()
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
        PnlSide.Size = New Size(320, 600)
        PnlSide.TabIndex = 0
        ' 
        ' LblTokoPakaianPria
        ' 
        LblTokoPakaianPria.AutoSize = True
        LblTokoPakaianPria.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblTokoPakaianPria.ForeColor = Color.White
        LblTokoPakaianPria.Location = New Point(79, 384)
        LblTokoPakaianPria.Name = "LblTokoPakaianPria"
        LblTokoPakaianPria.Size = New Size(163, 25)
        LblTokoPakaianPria.TabIndex = 7
        LblTokoPakaianPria.Text = "Toko Pakaian Pria"
        LblTokoPakaianPria.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblSistemManajemen
        ' 
        LblSistemManajemen.AutoSize = True
        LblSistemManajemen.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblSistemManajemen.ForeColor = Color.White
        LblSistemManajemen.Location = New Point(89, 360)
        LblSistemManajemen.Name = "LblSistemManajemen"
        LblSistemManajemen.Size = New Size(142, 20)
        LblSistemManajemen.TabIndex = 6
        LblSistemManajemen.Text = "Sistem Manajemen"
        LblSistemManajemen.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblMensWear
        ' 
        LblMensWear.AutoSize = True
        LblMensWear.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblMensWear.ForeColor = Color.White
        LblMensWear.Location = New Point(109, 285)
        LblMensWear.Name = "LblMensWear"
        LblMensWear.Size = New Size(103, 20)
        LblMensWear.TabIndex = 5
        LblMensWear.Text = "MEN'S WEAR"
        LblMensWear.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblGentlemen
        ' 
        LblGentlemen.AutoSize = True
        LblGentlemen.Font = New Font("Georgia", 14.25F, FontStyle.Bold)
        LblGentlemen.ForeColor = Color.Goldenrod
        LblGentlemen.Location = New Point(70, 250)
        LblGentlemen.Name = "LblGentlemen"
        LblGentlemen.Size = New Size(180, 29)
        LblGentlemen.TabIndex = 4
        LblGentlemen.Text = "GENTLEMEN"
        LblGentlemen.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBoxLogo
        ' 
        PictureBoxLogo.BackColor = Color.Transparent
        PictureBoxLogo.BackgroundImageLayout = ImageLayout.Stretch
        PictureBoxLogo.Image = My.Resources.Resources.Fashion_man_logo
        PictureBoxLogo.Location = New Point(71, 36)
        PictureBoxLogo.Margin = New Padding(3, 4, 3, 4)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(180, 180)
        PictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxLogo.TabIndex = 3
        PictureBoxLogo.TabStop = False
        ' 
        ' LblBrandSub
        ' 
        LblBrandSub.Font = New Font("Segoe UI", 10F)
        LblBrandSub.ForeColor = Color.White
        LblBrandSub.Location = New Point(29, 490)
        LblBrandSub.Name = "LblBrandSub"
        LblBrandSub.Size = New Size(263, 60)
        LblBrandSub.TabIndex = 1
        LblBrandSub.Text = "Solusi belanja mudah dan terpercaya untuk Anda."
        LblBrandSub.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblTitle
        ' 
        LblTitle.AutoSize = True
        LblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        LblTitle.Location = New Point(393, 67)
        LblTitle.Name = "LblTitle"
        LblTitle.Size = New Size(334, 41)
        LblTitle.TabIndex = 1
        LblTitle.Text = "Halo, Selamat Datang!"
        ' 
        ' LblSubtitle
        ' 
        LblSubtitle.AutoSize = True
        LblSubtitle.ForeColor = Color.Gray
        LblSubtitle.Location = New Point(427, 113)
        LblSubtitle.Name = "LblSubtitle"
        LblSubtitle.Size = New Size(262, 20)
        LblSubtitle.TabIndex = 2
        LblSubtitle.Text = "Masuk ke akun pelanggan Anda di sini"
        ' 
        ' LblEmail
        ' 
        LblEmail.AutoSize = True
        LblEmail.Font = New Font("Segoe UI", 9F)
        LblEmail.ForeColor = Color.DimGray
        LblEmail.Location = New Point(371, 187)
        LblEmail.Name = "LblEmail"
        LblEmail.Size = New Size(46, 20)
        LblEmail.TabIndex = 3
        LblEmail.Text = "Email"
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Font = New Font("Segoe UI", 11F)
        TxtEmail.Location = New Point(371, 213)
        TxtEmail.Margin = New Padding(3, 4, 3, 4)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(388, 32)
        TxtEmail.TabIndex = 4
        ' 
        ' LblPassword
        ' 
        LblPassword.AutoSize = True
        LblPassword.Font = New Font("Segoe UI", 9F)
        LblPassword.ForeColor = Color.DimGray
        LblPassword.Location = New Point(371, 280)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(70, 20)
        LblPassword.TabIndex = 5
        LblPassword.Text = "Password"
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Font = New Font("Segoe UI", 11F)
        TxtPassword.Location = New Point(371, 307)
        TxtPassword.Margin = New Padding(3, 4, 3, 4)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.Size = New Size(388, 32)
        TxtPassword.TabIndex = 6
        TxtPassword.UseSystemPasswordChar = True
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        BtnLogin.FlatAppearance.BorderSize = 0
        BtnLogin.FlatStyle = FlatStyle.Flat
        BtnLogin.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        BtnLogin.ForeColor = Color.White
        BtnLogin.Location = New Point(371, 387)
        BtnLogin.Margin = New Padding(3, 4, 3, 4)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(389, 53)
        BtnLogin.TabIndex = 7
        BtnLogin.Text = "LOGIN"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' LlblDaftar
        ' 
        LlblDaftar.AutoSize = True
        LlblDaftar.LinkColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        LlblDaftar.Location = New Point(451, 460)
        LlblDaftar.Name = "LlblDaftar"
        LlblDaftar.Size = New Size(248, 20)
        LlblDaftar.TabIndex = 8
        LlblDaftar.TabStop = True
        LlblDaftar.Text = "Belum punya akun? Daftar Sekarang"
        ' 
        ' LlblAdminArea
        ' 
        LlblAdminArea.AutoSize = True
        LlblAdminArea.LinkColor = Color.Gray
        LlblAdminArea.Location = New Point(509, 547)
        LlblAdminArea.Name = "LlblAdminArea"
        LlblAdminArea.Size = New Size(155, 20)
        LlblAdminArea.TabIndex = 9
        LlblAdminArea.TabStop = True
        LlblAdminArea.Text = "Masuk sebagai Admin"
        ' 
        ' FormLoginPelanggan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(811, 600)
        Controls.Add(LlblAdminArea)
        Controls.Add(LlblDaftar)
        Controls.Add(BtnLogin)
        Controls.Add(TxtPassword)
        Controls.Add(LblPassword)
        Controls.Add(TxtEmail)
        Controls.Add(LblEmail)
        Controls.Add(LblSubtitle)
        Controls.Add(LblTitle)
        Controls.Add(PnlSide)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "FormLoginPelanggan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login Pelanggan"
        PnlSide.ResumeLayout(False)
        PnlSide.PerformLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents PnlSide As System.Windows.Forms.Panel
    Friend WithEvents LblBrandSub As System.Windows.Forms.Label
    Friend WithEvents LblTitle As System.Windows.Forms.Label
    Friend WithEvents LblSubtitle As System.Windows.Forms.Label
    Friend WithEvents LblEmail As System.Windows.Forms.Label
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents LblPassword As System.Windows.Forms.Label
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents LlblDaftar As System.Windows.Forms.LinkLabel
    Friend WithEvents LlblAdminArea As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents LblGentlemen As Label
    Friend WithEvents LblMensWear As Label
    Friend WithEvents LblSistemManajemen As Label
    Friend WithEvents LblTokoPakaianPria As Label
End Class