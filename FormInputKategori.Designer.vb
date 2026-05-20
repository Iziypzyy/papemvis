<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputKategori
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtKodeKategori = New TextBox()
        txtNamaKategori = New TextBox()
        txtKeterangan = New TextBox()
        btnSimpan = New Button()
        btnBatal = New Button()
        SuspendLayout()
        ' 
        ' txtKodeKategori
        ' 
        txtKodeKategori.Location = New Point(12, 14)
        txtKodeKategori.Name = "txtKodeKategori"
        txtKodeKategori.PlaceholderText = "Kode Kategori"
        txtKodeKategori.Size = New Size(125, 27)
        txtKodeKategori.TabIndex = 0
        ' 
        ' txtNamaKategori
        ' 
        txtNamaKategori.Location = New Point(143, 14)
        txtNamaKategori.Name = "txtNamaKategori"
        txtNamaKategori.PlaceholderText = "Nama Kategori"
        txtNamaKategori.Size = New Size(299, 27)
        txtNamaKategori.TabIndex = 1
        ' 
        ' txtKeterangan
        ' 
        txtKeterangan.Location = New Point(12, 61)
        txtKeterangan.Multiline = True
        txtKeterangan.Name = "txtKeterangan"
        txtKeterangan.PlaceholderText = "Keterangan...."
        txtKeterangan.Size = New Size(430, 196)
        txtKeterangan.TabIndex = 2
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(348, 280)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 3
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(239, 280)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(94, 29)
        btnBatal.TabIndex = 4
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' FormInputKategori
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(454, 321)
        Controls.Add(btnBatal)
        Controls.Add(btnSimpan)
        Controls.Add(txtKeterangan)
        Controls.Add(txtNamaKategori)
        Controls.Add(txtKodeKategori)
        Name = "FormInputKategori"
        StartPosition = FormStartPosition.CenterParent
        Text = "FormInputKategori"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtKodeKategori As TextBox
    Friend WithEvents txtNamaKategori As TextBox
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
End Class
