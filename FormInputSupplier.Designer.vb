<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputSupplier
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
        txtNama = New TextBox()
        txtTelp = New TextBox()
        txtKota = New TextBox()
        btnSimpanInput = New Button()
        txtKode = New TextBox()
        SuspendLayout()
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(12, 45)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama Supplier"
        txtNama.Size = New Size(255, 27)
        txtNama.TabIndex = 1
        ' 
        ' txtTelp
        ' 
        txtTelp.Location = New Point(12, 78)
        txtTelp.Name = "txtTelp"
        txtTelp.PlaceholderText = "No. Telp"
        txtTelp.Size = New Size(255, 27)
        txtTelp.TabIndex = 2
        ' 
        ' txtKota
        ' 
        txtKota.Location = New Point(273, 78)
        txtKota.Name = "txtKota"
        txtKota.PlaceholderText = "Kota"
        txtKota.Size = New Size(166, 27)
        txtKota.TabIndex = 3
        ' 
        ' btnSimpanInput
        ' 
        btnSimpanInput.BackColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
        btnSimpanInput.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSimpanInput.ForeColor = Color.White
        btnSimpanInput.Location = New Point(454, 74)
        btnSimpanInput.Name = "btnSimpanInput"
        btnSimpanInput.Size = New Size(94, 35)
        btnSimpanInput.TabIndex = 4
        btnSimpanInput.Text = "Simpan"
        btnSimpanInput.UseVisualStyleBackColor = False
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(12, 12)
        txtKode.Name = "txtKode"
        txtKode.PlaceholderText = "Kode Supplier"
        txtKode.Size = New Size(255, 27)
        txtKode.TabIndex = 5
        ' 
        ' FormInputSupplier
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 131)
        Controls.Add(txtKode)
        Controls.Add(btnSimpanInput)
        Controls.Add(txtKota)
        Controls.Add(txtTelp)
        Controls.Add(txtNama)
        Name = "FormInputSupplier"
        StartPosition = FormStartPosition.CenterParent
        Text = "FormInputSupplier"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents txtKota As TextBox
    Friend WithEvents btnSimpanInput As Button
    Friend WithEvents txtKode As TextBox
End Class
