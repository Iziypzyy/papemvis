<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        PanelLeft = New Panel()
        LblTokoPakaianPria = New Label()
        LblSistemManajemen = New Label()
        LblMensWear = New Label()
        LblGentlemen = New Label()
        PictureBoxLogo = New PictureBox()
        LabelUsername = New Label()
        TextBoxUsername = New TextBox()
        LabelPassword = New Label()
        TextBoxPassword = New TextBox()
        CheckBoxIngatSaya = New CheckBox()
        ButtonLogin = New Button()
        ButtonBatal = New Button()
        LabelLoginTitle = New Label()
        PictureBoxUserIcon = New PictureBox()
        PanelLeft.SuspendLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxUserIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelLeft
        ' 
        PanelLeft.BackColor = Color.FromArgb(CByte(10), CByte(25), CByte(47))
        PanelLeft.Controls.Add(LblTokoPakaianPria)
        PanelLeft.Controls.Add(LblSistemManajemen)
        PanelLeft.Controls.Add(LblMensWear)
        PanelLeft.Controls.Add(LblGentlemen)
        PanelLeft.Controls.Add(PictureBoxLogo)
        PanelLeft.Dock = DockStyle.Left
        PanelLeft.Location = New Point(0, 0)
        PanelLeft.Margin = New Padding(3, 4, 3, 4)
        PanelLeft.Name = "PanelLeft"
        PanelLeft.Size = New Size(286, 533)
        PanelLeft.TabIndex = 0
        ' 
        ' LblTokoPakaianPria
        ' 
        LblTokoPakaianPria.AutoSize = True
        LblTokoPakaianPria.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        LblTokoPakaianPria.ForeColor = Color.White
        LblTokoPakaianPria.Location = New Point(46, 413)
        LblTokoPakaianPria.Name = "LblTokoPakaianPria"
        LblTokoPakaianPria.Size = New Size(171, 25)
        LblTokoPakaianPria.TabIndex = 4
        LblTokoPakaianPria.Text = "Toko Pakaian Pria"
        LblTokoPakaianPria.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblSistemManajemen
        ' 
        LblSistemManajemen.AutoSize = True
        LblSistemManajemen.Font = New Font("Segoe UI", 9.75F)
        LblSistemManajemen.ForeColor = Color.White
        LblSistemManajemen.Location = New Point(51, 380)
        LblSistemManajemen.Name = "LblSistemManajemen"
        LblSistemManajemen.Size = New Size(155, 23)
        LblSistemManajemen.TabIndex = 3
        LblSistemManajemen.Text = "Sistem Manajemen"
        LblSistemManajemen.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblMensWear
        ' 
        LblMensWear.AutoSize = True
        LblMensWear.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        LblMensWear.ForeColor = Color.White
        LblMensWear.Location = New Point(86, 307)
        LblMensWear.Name = "LblMensWear"
        LblMensWear.Size = New Size(103, 20)
        LblMensWear.TabIndex = 2
        LblMensWear.Text = "MEN'S WEAR"
        LblMensWear.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblGentlemen
        ' 
        LblGentlemen.AutoSize = True
        LblGentlemen.Font = New Font("Georgia", 14.25F, FontStyle.Bold)
        LblGentlemen.ForeColor = Color.Goldenrod
        LblGentlemen.Location = New Point(46, 267)
        LblGentlemen.Name = "LblGentlemen"
        LblGentlemen.Size = New Size(180, 29)
        LblGentlemen.TabIndex = 1
        LblGentlemen.Text = "GENTLEMEN"
        LblGentlemen.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBoxLogo
        ' 
        PictureBoxLogo.Location = New Point(51, 61)
        PictureBoxLogo.Margin = New Padding(3, 4, 3, 4)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(166, 179)
        PictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxLogo.TabIndex = 0
        PictureBoxLogo.TabStop = False
        ' 
        ' LabelUsername
        ' 
        LabelUsername.AutoSize = True
        LabelUsername.Font = New Font("Segoe UI", 9F)
        LabelUsername.Location = New Point(331, 200)
        LabelUsername.Name = "LabelUsername"
        LabelUsername.Size = New Size(75, 20)
        LabelUsername.TabIndex = 1
        LabelUsername.Text = "Username"
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.BorderStyle = BorderStyle.FixedSingle
        TextBoxUsername.Font = New Font("Segoe UI", 10F)
        TextBoxUsername.Location = New Point(335, 227)
        TextBoxUsername.Margin = New Padding(3, 4, 3, 4)
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.PlaceholderText = "masukkan username"
        TextBoxUsername.Size = New Size(343, 30)
        TextBoxUsername.TabIndex = 2
        ' 
        ' LabelPassword
        ' 
        LabelPassword.AutoSize = True
        LabelPassword.Font = New Font("Segoe UI", 9F)
        LabelPassword.Location = New Point(331, 280)
        LabelPassword.Name = "LabelPassword"
        LabelPassword.Size = New Size(70, 20)
        LabelPassword.TabIndex = 3
        LabelPassword.Text = "Password"
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.BorderStyle = BorderStyle.FixedSingle
        TextBoxPassword.Font = New Font("Segoe UI", 10F)
        TextBoxPassword.Location = New Point(335, 307)
        TextBoxPassword.Margin = New Padding(3, 4, 3, 4)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.PasswordChar = "*"c
        TextBoxPassword.PlaceholderText = "masukkan password"
        TextBoxPassword.Size = New Size(343, 30)
        TextBoxPassword.TabIndex = 4
        ' 
        ' CheckBoxIngatSaya
        ' 
        CheckBoxIngatSaya.AutoSize = True
        CheckBoxIngatSaya.Font = New Font("Segoe UI", 8.25F)
        CheckBoxIngatSaya.Location = New Point(335, 353)
        CheckBoxIngatSaya.Margin = New Padding(3, 4, 3, 4)
        CheckBoxIngatSaya.Name = "CheckBoxIngatSaya"
        CheckBoxIngatSaya.Size = New Size(95, 23)
        CheckBoxIngatSaya.TabIndex = 5
        CheckBoxIngatSaya.Text = "Ingat Saya"
        CheckBoxIngatSaya.UseVisualStyleBackColor = True
        ' 
        ' ButtonLogin
        ' 
        ButtonLogin.BackColor = Color.FromArgb(CByte(10), CByte(25), CByte(47))
        ButtonLogin.Cursor = Cursors.Hand
        ButtonLogin.FlatStyle = FlatStyle.Flat
        ButtonLogin.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        ButtonLogin.ForeColor = Color.White
        ButtonLogin.Location = New Point(335, 413)
        ButtonLogin.Margin = New Padding(3, 4, 3, 4)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(160, 47)
        ButtonLogin.TabIndex = 6
        ButtonLogin.Text = "Login"
        ButtonLogin.UseVisualStyleBackColor = False
        ' 
        ' ButtonBatal
        ' 
        ButtonBatal.BackColor = Color.White
        ButtonBatal.Cursor = Cursors.Hand
        ButtonBatal.FlatStyle = FlatStyle.Flat
        ButtonBatal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        ButtonBatal.ForeColor = Color.Black
        ButtonBatal.Location = New Point(518, 413)
        ButtonBatal.Margin = New Padding(3, 4, 3, 4)
        ButtonBatal.Name = "ButtonBatal"
        ButtonBatal.Size = New Size(160, 47)
        ButtonBatal.TabIndex = 7
        ButtonBatal.Text = "Batal"
        ButtonBatal.UseVisualStyleBackColor = False
        ' 
        ' LabelLoginTitle
        ' 
        LabelLoginTitle.AutoSize = True
        LabelLoginTitle.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        LabelLoginTitle.Location = New Point(469, 107)
        LabelLoginTitle.Name = "LabelLoginTitle"
        LabelLoginTitle.Size = New Size(89, 37)
        LabelLoginTitle.TabIndex = 8
        LabelLoginTitle.Text = "Login"
        ' 
        ' PictureBoxUserIcon
        ' 
        PictureBoxUserIcon.Location = New Point(402, 94)
        PictureBoxUserIcon.Margin = New Padding(3, 4, 3, 4)
        PictureBoxUserIcon.Name = "PictureBoxUserIcon"
        PictureBoxUserIcon.Size = New Size(61, 59)
        PictureBoxUserIcon.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxUserIcon.TabIndex = 9
        PictureBoxUserIcon.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(731, 533)
        Controls.Add(PictureBoxUserIcon)
        Controls.Add(LabelLoginTitle)
        Controls.Add(ButtonBatal)
        Controls.Add(ButtonLogin)
        Controls.Add(CheckBoxIngatSaya)
        Controls.Add(TextBoxPassword)
        Controls.Add(LabelPassword)
        Controls.Add(TextBoxUsername)
        Controls.Add(LabelUsername)
        Controls.Add(PanelLeft)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login - Sistem Manajemen Toko Pakaian Pria"
        PanelLeft.ResumeLayout(False)
        PanelLeft.PerformLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxUserIcon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents PanelLeft As System.Windows.Forms.Panel
    Friend WithEvents PictureBoxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents LblGentlemen As System.Windows.Forms.Label
    Friend WithEvents LblMensWear As System.Windows.Forms.Label
    Friend WithEvents LblSistemManajemen As System.Windows.Forms.Label
    Friend WithEvents LblTokoPakaianPria As System.Windows.Forms.Label
    Friend WithEvents LabelUsername As System.Windows.Forms.Label
    Friend WithEvents TextBoxUsername As System.Windows.Forms.TextBox
    Friend WithEvents LabelPassword As System.Windows.Forms.Label
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxIngatSaya As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonLogin As System.Windows.Forms.Button
    Friend WithEvents ButtonBatal As System.Windows.Forms.Button
    Friend WithEvents LabelLoginTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBoxUserIcon As System.Windows.Forms.PictureBox
End Class