<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputPelanggan
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
        txtKode = New TextBox()
        txtNama = New TextBox()
        txtNoTelp = New TextBox()
        txtKota = New TextBox()
        btnBatal = New Button()
        btnSimpan = New Button()
        SuspendLayout()
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(12, 12)
        txtKode.Name = "txtKode"
        txtKode.PlaceholderText = "Kode"
        txtKode.Size = New Size(125, 27)
        txtKode.TabIndex = 0
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(143, 12)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama"
        txtNama.Size = New Size(311, 27)
        txtNama.TabIndex = 1
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.Location = New Point(143, 56)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.PlaceholderText = "No. Telepon"
        txtNoTelp.Size = New Size(311, 27)
        txtNoTelp.TabIndex = 2
        ' 
        ' txtKota
        ' 
        txtKota.Location = New Point(143, 102)
        txtKota.Name = "txtKota"
        txtKota.PlaceholderText = "Kota"
        txtKota.Size = New Size(311, 27)
        txtKota.TabIndex = 3
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(252, 167)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(94, 29)
        btnBatal.TabIndex = 4
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(360, 167)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 5
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' FormInputPelanggan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(466, 212)
        Controls.Add(btnSimpan)
        Controls.Add(btnBatal)
        Controls.Add(txtKota)
        Controls.Add(txtNoTelp)
        Controls.Add(txtNama)
        Controls.Add(txtKode)
        Name = "FormInputPelanggan"
        StartPosition = FormStartPosition.CenterParent
        Text = "FormInputPelanggan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents txtKota As TextBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
End Class
