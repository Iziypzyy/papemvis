Public Class FormDashboard

    Private WithEvents waktuTimer As New Timer()

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' FORMAT TANGGAL DAN JAM
        LabelDate.Text = Format(Date.Now, "dddd, dd MMMM yyyy")
        LabelTime.Text = Format(Date.Now, "HH:mm:ss")

        waktuTimer.Interval = 1000
        waktuTimer.Start()

        ' LOAD DATA DASHBOARD
        LoadDashboard()

        ' LOAD TABEL TOP PRODUK
        LoadTopProduk()

    End Sub

    Private Sub waktuTimer_Tick(sender As Object, e As EventArgs) Handles waktuTimer.Tick
        LabelTime.Text = Format(Date.Now, "HH:mm:ss")
    End Sub

    Private Sub LoadDashboard()

        ' DATA DUMMY
        ' Nanti tinggal ganti pakai database

        LabelProdukValue.Text = "156"
        LabelStokValue.Text = "18"
        LabelPenjualanValue.Text = "Rp 5.250.000"
        LabelPelangganValue.Text = "125"

        LabelNotif1.Text = "- 18 produk dengan stok menipis"
        LabelNotif2.Text = "- 2 pesanan pembelian belum diterima"
        LabelNotif3.Text = "- Backup data terakhir : " & Format(Date.Now, "dd/MM/yyyy HH:mm")

        LabelInfoUser.Text = "User Aktif              :   admin"
        LabelInfoLevel.Text = "Level                   :   Administrator"
        LabelInfoVersi.Text = "Versi Aplikasi          :   1.0.0.0"

    End Sub

    Private Sub LoadTopProduk()

        TableTopProduk.Controls.Clear()

        ' HEADER
        TableTopProduk.Controls.Add(BuatLabelTable("No", True), 0, 0)
        TableTopProduk.Controls.Add(BuatLabelTable("Nama Produk", True), 1, 0)
        TableTopProduk.Controls.Add(BuatLabelTable("Terjual", True), 2, 0)

        ' DATA
        TableTopProduk.Controls.Add(BuatLabelTable("1"), 0, 1)
        TableTopProduk.Controls.Add(BuatLabelTable("Kaos Polos"), 1, 1)
        TableTopProduk.Controls.Add(BuatLabelTable("120"), 2, 1)

        TableTopProduk.Controls.Add(BuatLabelTable("2"), 0, 2)
        TableTopProduk.Controls.Add(BuatLabelTable("Kemeja Flannel"), 1, 2)
        TableTopProduk.Controls.Add(BuatLabelTable("98"), 2, 2)

        TableTopProduk.Controls.Add(BuatLabelTable("3"), 0, 3)
        TableTopProduk.Controls.Add(BuatLabelTable("Celana Chino"), 1, 3)
        TableTopProduk.Controls.Add(BuatLabelTable("85"), 2, 3)

        TableTopProduk.Controls.Add(BuatLabelTable("4"), 0, 4)
        TableTopProduk.Controls.Add(BuatLabelTable("Jaket Hoodie"), 1, 4)
        TableTopProduk.Controls.Add(BuatLabelTable("76"), 2, 4)

        TableTopProduk.Controls.Add(BuatLabelTable("5"), 0, 5)
        TableTopProduk.Controls.Add(BuatLabelTable("Polo Shirt"), 1, 5)
        TableTopProduk.Controls.Add(BuatLabelTable("70"), 2, 5)

    End Sub

    Private Function BuatLabelTable(teks As String,
                                    Optional header As Boolean = False) As Label

        Dim lbl As New Label

        lbl.Text = teks
        lbl.Dock = DockStyle.Fill
        lbl.TextAlign = ContentAlignment.MiddleCenter
        lbl.Margin = New Padding(0)

        If header = True Then
            lbl.Font = New Font("Segoe UI", 9, FontStyle.Bold)
            lbl.BackColor = Color.FromArgb(230, 230, 230)
        Else
            lbl.Font = New Font("Segoe UI", 9, FontStyle.Regular)
            lbl.BackColor = Color.White
        End If

        Return lbl

    End Function

    ' =========================
    ' BUTTON SIDEBAR
    ' =========================

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        MessageBox.Show("Dashboard")
    End Sub

    Private Sub BtnDataBarang_Click(sender As Object, e As EventArgs) Handles BtnDataBarang.Click
        FormDataBarang.Show()
    End Sub

    Private Sub BtnKategori_Click(sender As Object, e As EventArgs) Handles BtnKategori.Click
        FormKategori.Show()
    End Sub

    Private Sub BtnSupplier_Click(sender As Object, e As EventArgs) Handles BtnSupplier.Click
        FormSupplier.Show()
    End Sub

    Private Sub BtnPelanggan_Click(sender As Object, e As EventArgs) Handles BtnPelanggan.Click
        FormPelanggan.Show()
    End Sub

    Private Sub BtnPenjualan_Click(sender As Object, e As EventArgs) Handles BtnPenjualan.Click
        FormTransaksiPenjualan.Show()
    End Sub

    Private Sub BtnPembelian_Click(sender As Object, e As EventArgs) Handles BtnPembelian.Click
        Form8.Show()
    End Sub

    Private Sub BtnStok_Click(sender As Object, e As EventArgs) Handles BtnStok.Click
        FormStokBarang.Show()
    End Sub

    Private Sub BtnLaporan_Click(sender As Object, e As EventArgs) Handles BtnLaporan.Click
        FormLaporan.Show()
    End Sub

    Private Sub BtnUser_Click(sender As Object, e As EventArgs) Handles BtnUser.Click
        FormUser.Show()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click

        Dim hasil As DialogResult

        hasil = MessageBox.Show(
            "Yakin ingin logout?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then

            Me.Hide()
            FormLoginPelanggan.Show()

        End If

    End Sub

    ' =========================
    ' MENU STRIP
    ' =========================

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        BtnLogout.PerformClick()
    End Sub

    Private Sub LabelGrafik2_Click(sender As Object, e As EventArgs) Handles LabelGrafik2.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub PanelContent_Paint(sender As Object, e As PaintEventArgs) Handles PanelContent.Paint

    End Sub
End Class