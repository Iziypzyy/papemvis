<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputPelanggan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblKode = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTelp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKota = New System.Windows.Forms.TextBox()
        Me.btnSimpanInput = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        ' lblKode
        '
        Me.lblKode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKode.Location = New System.Drawing.Point(24, 18)
        Me.lblKode.Name = "lblKode"
        Me.lblKode.Size = New System.Drawing.Size(260, 26)
        Me.lblKode.TabIndex = 0
        Me.lblKode.Text = "PLG001"
        Me.lblKode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        ' Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama Pelanggan"
        '
        ' txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(24, 68)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(260, 23)
        Me.txtNama.TabIndex = 2
        '
        ' Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "No. Telepon"
        '
        ' txtTelp
        '
        Me.txtTelp.Location = New System.Drawing.Point(24, 118)
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(260, 23)
        Me.txtTelp.TabIndex = 4
        '
        ' Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Kota"
        '
        ' txtKota
        '
        Me.txtKota.Location = New System.Drawing.Point(24, 168)
        Me.txtKota.Name = "txtKota"
        Me.txtKota.Size = New System.Drawing.Size(260, 23)
        Me.txtKota.TabIndex = 6
        '
        ' btnSimpanInput
        '
        Me.btnSimpanInput.Location = New System.Drawing.Point(104, 206)
        Me.btnSimpanInput.Name = "btnSimpanInput"
        Me.btnSimpanInput.Size = New System.Drawing.Size(94, 29)
        Me.btnSimpanInput.TabIndex = 7
        Me.btnSimpanInput.Text = "Simpan"
        Me.btnSimpanInput.UseVisualStyleBackColor = True
        '
        ' FormInputPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 252)
        Me.Controls.Add(Me.btnSimpanInput)
        Me.Controls.Add(Me.txtKota)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTelp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblKode)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "FormInputPelanggan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Input Pelanggan"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblKode As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKota As TextBox
    Friend WithEvents btnSimpanInput As Button
End Class
