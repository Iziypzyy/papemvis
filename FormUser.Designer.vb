<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUser
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
    ' Tombol Aksi
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnResetPassword As System.Windows.Forms.Button

    ' Input Form
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox

    Friend WithEvents lblNamaLengkap As System.Windows.Forms.Label
    Friend WithEvents txtNamaLengkap As System.Windows.Forms.TextBox

    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents cmbLevel As System.Windows.Forms.ComboBox

    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox

    ' Foto Profil
    Friend WithEvents picAvatar As System.Windows.Forms.PictureBox

    ' Data Grid
    Friend WithEvents dgvUsers As System.Windows.Forms.DataGridView
    Friend WithEvents colUsername As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNamaLengkap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLevel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTerakhirLogin As System.Windows.Forms.DataGridViewTextBoxColumn

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnTambah = New Button()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnResetPassword = New Button()
        lblUsername = New Label()
        txtUsername = New TextBox()
        lblNamaLengkap = New Label()
        txtNamaLengkap = New TextBox()
        lblLevel = New Label()
        cmbLevel = New ComboBox()
        lblStatus = New Label()
        cmbStatus = New ComboBox()
        picAvatar = New PictureBox()
        dgvUsers = New DataGridView()
        colUsername = New DataGridViewTextBoxColumn()
        colNamaLengkap = New DataGridViewTextBoxColumn()
        colLevel = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colTerakhirLogin = New DataGridViewTextBoxColumn()
        CType(picAvatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvUsers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
        btnTambah.FlatAppearance.BorderSize = 0
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(23, 27)
        btnTambah.Margin = New Padding(3, 4, 3, 4)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(109, 47)
        btnTambah.TabIndex = 14
        btnTambah.Text = "+ Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(143, 27)
        btnSimpan.Margin = New Padding(3, 4, 3, 4)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(109, 47)
        btnSimpan.TabIndex = 13
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        btnUbah.FlatAppearance.BorderSize = 0
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUbah.ForeColor = Color.Black
        btnUbah.Location = New Point(263, 27)
        btnUbah.Margin = New Padding(3, 4, 3, 4)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(109, 47)
        btnUbah.TabIndex = 12
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(383, 27)
        btnHapus.Margin = New Padding(3, 4, 3, 4)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(109, 47)
        btnHapus.TabIndex = 11
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnResetPassword
        ' 
        btnResetPassword.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnResetPassword.FlatAppearance.BorderSize = 0
        btnResetPassword.FlatStyle = FlatStyle.Flat
        btnResetPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnResetPassword.ForeColor = Color.Black
        btnResetPassword.Location = New Point(503, 27)
        btnResetPassword.Margin = New Padding(3, 4, 3, 4)
        btnResetPassword.Name = "btnResetPassword"
        btnResetPassword.Size = New Size(149, 47)
        btnResetPassword.TabIndex = 10
        btnResetPassword.Text = "🔒 Reset Password"
        btnResetPassword.UseVisualStyleBackColor = False
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(23, 113)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(75, 20)
        lblUsername.TabIndex = 9
        lblUsername.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(143, 109)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "masukkan username"
        txtUsername.Size = New Size(285, 27)
        txtUsername.TabIndex = 8
        ' 
        ' lblNamaLengkap
        ' 
        lblNamaLengkap.AutoSize = True
        lblNamaLengkap.Location = New Point(23, 160)
        lblNamaLengkap.Name = "lblNamaLengkap"
        lblNamaLengkap.Size = New Size(109, 20)
        lblNamaLengkap.TabIndex = 7
        lblNamaLengkap.Text = "Nama Lengkap"
        ' 
        ' txtNamaLengkap
        ' 
        txtNamaLengkap.Location = New Point(143, 156)
        txtNamaLengkap.Margin = New Padding(3, 4, 3, 4)
        txtNamaLengkap.Name = "txtNamaLengkap"
        txtNamaLengkap.PlaceholderText = "masukkan nama lengkap"
        txtNamaLengkap.Size = New Size(285, 27)
        txtNamaLengkap.TabIndex = 6
        ' 
        ' lblLevel
        ' 
        lblLevel.AutoSize = True
        lblLevel.Location = New Point(23, 207)
        lblLevel.Name = "lblLevel"
        lblLevel.Size = New Size(43, 20)
        lblLevel.TabIndex = 5
        lblLevel.Text = "Level"
        ' 
        ' cmbLevel
        ' 
        cmbLevel.DropDownStyle = ComboBoxStyle.DropDownList
        cmbLevel.FormattingEnabled = True
        cmbLevel.Items.AddRange(New Object() {"Administrator", "Kasir", "Gudang", "Manager"})
        cmbLevel.Location = New Point(143, 203)
        cmbLevel.Margin = New Padding(3, 4, 3, 4)
        cmbLevel.Name = "cmbLevel"
        cmbLevel.Size = New Size(285, 28)
        cmbLevel.TabIndex = 4
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(23, 253)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(49, 20)
        lblStatus.TabIndex = 3
        lblStatus.Text = "Status"
        ' 
        ' cmbStatus
        ' 
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Aktif", "Non-Aktif"})
        cmbStatus.Location = New Point(143, 249)
        cmbStatus.Margin = New Padding(3, 4, 3, 4)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(285, 28)
        cmbStatus.TabIndex = 2
        ' 
        ' picAvatar
        ' 
        picAvatar.BackColor = Color.FromArgb(CByte(240), CByte(240), CByte(245))
        picAvatar.BorderStyle = BorderStyle.FixedSingle
        picAvatar.Location = New Point(594, 100)
        picAvatar.Margin = New Padding(3, 4, 3, 4)
        picAvatar.Name = "picAvatar"
        picAvatar.Size = New Size(160, 186)
        picAvatar.SizeMode = PictureBoxSizeMode.Zoom
        picAvatar.TabIndex = 1
        picAvatar.TabStop = False
        ' 
        ' dgvUsers
        ' 
        dgvUsers.AllowUserToAddRows = False
        dgvUsers.AllowUserToDeleteRows = False
        dgvUsers.BackgroundColor = Color.White
        dgvUsers.ColumnHeadersHeight = 35
        dgvUsers.Columns.AddRange(New DataGridViewColumn() {colUsername, colNamaLengkap, colLevel, colStatus, colTerakhirLogin})
        dgvUsers.Location = New Point(23, 333)
        dgvUsers.Margin = New Padding(3, 4, 3, 4)
        dgvUsers.Name = "dgvUsers"
        dgvUsers.ReadOnly = True
        dgvUsers.RowHeadersVisible = False
        dgvUsers.RowHeadersWidth = 51
        dgvUsers.RowTemplate.Height = 30
        dgvUsers.Size = New Size(777, 333)
        dgvUsers.TabIndex = 0
        ' 
        ' colUsername
        ' 
        colUsername.HeaderText = "Username"
        colUsername.MinimumWidth = 6
        colUsername.Name = "colUsername"
        colUsername.ReadOnly = True
        colUsername.Width = 110
        ' 
        ' colNamaLengkap
        ' 
        colNamaLengkap.HeaderText = "Nama Lengkap"
        colNamaLengkap.MinimumWidth = 6
        colNamaLengkap.Name = "colNamaLengkap"
        colNamaLengkap.ReadOnly = True
        colNamaLengkap.Width = 170
        ' 
        ' colLevel
        ' 
        colLevel.HeaderText = "Level"
        colLevel.MinimumWidth = 6
        colLevel.Name = "colLevel"
        colLevel.ReadOnly = True
        colLevel.Width = 120
        ' 
        ' colStatus
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        colStatus.DefaultCellStyle = DataGridViewCellStyle3
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 6
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        colStatus.Width = 125
        ' 
        ' colTerakhirLogin
        ' 
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        colTerakhirLogin.DefaultCellStyle = DataGridViewCellStyle4
        colTerakhirLogin.HeaderText = "Terakhir Login"
        colTerakhirLogin.MinimumWidth = 6
        colTerakhirLogin.Name = "colTerakhirLogin"
        colTerakhirLogin.ReadOnly = True
        colTerakhirLogin.Width = 160
        ' 
        ' FormUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(823, 693)
        Controls.Add(dgvUsers)
        Controls.Add(picAvatar)
        Controls.Add(cmbStatus)
        Controls.Add(lblStatus)
        Controls.Add(cmbLevel)
        Controls.Add(lblLevel)
        Controls.Add(txtNamaLengkap)
        Controls.Add(lblNamaLengkap)
        Controls.Add(txtUsername)
        Controls.Add(lblUsername)
        Controls.Add(btnResetPassword)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(btnTambah)
        Font = New Font("Segoe UI", 9F)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormUser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User / Admin Management"
        CType(picAvatar, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvUsers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
End Class