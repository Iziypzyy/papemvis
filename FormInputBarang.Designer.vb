<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputBarang
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
        cbKategori = New ComboBox()
        txtNama = New TextBox()
        txtStok = New TextBox()
        txtKode = New TextBox()
        txtUkuran = New TextBox()
        txtWarna = New TextBox()
        txtHarga = New TextBox()
        btnSimpan = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' cbKategori
        ' 
        cbKategori.DropDownStyle = ComboBoxStyle.DropDownList
        cbKategori.FormattingEnabled = True
        cbKategori.Items.AddRange(New Object() {"Atasan", "Bawahan", "Aksesoris", "Alas Kaki"})
        cbKategori.Location = New Point(133, 99)
        cbKategori.Name = "cbKategori"
        cbKategori.Size = New Size(154, 28)
        cbKategori.TabIndex = 0
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(12, 66)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama Barang"
        txtNama.Size = New Size(275, 27)
        txtNama.TabIndex = 1
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(162, 166)
        txtStok.Name = "txtStok"
        txtStok.PlaceholderText = "Stok"
        txtStok.Size = New Size(125, 27)
        txtStok.TabIndex = 2
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(12, 33)
        txtKode.Name = "txtKode"
        txtKode.PlaceholderText = "Kode Barang"
        txtKode.Size = New Size(275, 27)
        txtKode.TabIndex = 3
        ' 
        ' txtUkuran
        ' 
        txtUkuran.Location = New Point(12, 133)
        txtUkuran.Name = "txtUkuran"
        txtUkuran.PlaceholderText = "Ukuran"
        txtUkuran.Size = New Size(125, 27)
        txtUkuran.TabIndex = 4
        ' 
        ' txtWarna
        ' 
        txtWarna.Location = New Point(162, 133)
        txtWarna.Name = "txtWarna"
        txtWarna.PlaceholderText = "Warna"
        txtWarna.Size = New Size(125, 27)
        txtWarna.TabIndex = 5
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(12, 166)
        txtHarga.Name = "txtHarga"
        txtHarga.PlaceholderText = "Harga"
        txtHarga.Size = New Size(125, 27)
        txtHarga.TabIndex = 6
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(102, 236)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 7
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 20)
        Label1.TabIndex = 8
        Label1.Text = "Kategori"
        ' 
        ' FormInputBarang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(309, 295)
        Controls.Add(Label1)
        Controls.Add(btnSimpan)
        Controls.Add(txtHarga)
        Controls.Add(txtWarna)
        Controls.Add(txtUkuran)
        Controls.Add(txtKode)
        Controls.Add(txtStok)
        Controls.Add(txtNama)
        Controls.Add(cbKategori)
        Name = "FormInputBarang"
        StartPosition = FormStartPosition.CenterParent
        Text = "FormInputBarang"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbKategori As ComboBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtUkuran As TextBox
    Friend WithEvents txtWarna As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label1 As Label
End Class
