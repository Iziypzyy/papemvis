Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class FormDashboard

    Private WithEvents waktuTimer As New Timer()

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelDate.Text = Format(Date.Now, "dddd, dd MMMM yyyy")
        LabelTime.Text = Format(Date.Now, "HH:mm:ss")

        waktuTimer.Interval = 1000
        waktuTimer.Start()

        LoadDashboard()
        LoadTopProduk()
    End Sub

    Private Sub waktuTimer_Tick(sender As Object, e As EventArgs) Handles waktuTimer.Tick
        LabelTime.Text = Format(Date.Now, "HH:mm:ss")
    End Sub

    Private Sub LoadDashboard()
        ' === KONEKSI DATABASE — ambil data dari VIEW v_dashboard ===
        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()
                Dim query As String = "SELECT * FROM v_dashboard"
                Using cmd As New MySqlCommand(query, conn)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            LabelProdukValue.Text = dr("total_produk").ToString()
                            LabelStokValue.Text = dr("produk_stok_menipis").ToString()
                            LabelPenjualanValue.Text = "Rp " & Format(Convert.ToDouble(dr("penjualan_hari_ini")), "###,###,##0")
                            LabelPelangganValue.Text = dr("total_pelanggan").ToString()

                            LabelNotif1.Text = "- " & dr("produk_stok_menipis").ToString() & " produk dengan stok menipis"
                        End If
                    End Using
                End Using
            End Using

            LabelNotif2.Text = "- 2 pesanan pembelian belum diterima"
            LabelNotif3.Text = "- Backup data terakhir : " & Format(Date.Now, "dd/MM/yyyy HH:mm")
            LabelInfoUser.Text = "User Aktif              :   admin"
            LabelInfoLevel.Text = "Level                   :   Administrator"
            LabelInfoVersi.Text = "Versi Aplikasi          :   1.0.0.0"

        Catch ex As Exception
            ' Jika DB gagal, tampilkan data default agar form tidak crash
            LabelProdukValue.Text = "-"
            LabelStokValue.Text = "-"
            LabelPenjualanValue.Text = "Rp 0"
            LabelPelangganValue.Text = "-"
        End Try
    End Sub

    Private Sub LoadTopProduk()
        TableTopProduk.Controls.Clear()

        ' HEADER
        TableTopProduk.Controls.Add(BuatLabelTable("No", True), 0, 0)
        TableTopProduk.Controls.Add(BuatLabelTable("Nama Produk", True), 1, 0)
        TableTopProduk.Controls.Add(BuatLabelTable("Terjual", True), 2, 0)

        ' === KONEKSI DATABASE — Top 5 produk terlaris ===
        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()
                Dim query As String =
                    "SELECT nama_barang, SUM(qty) AS total_terjual " &
                    "FROM detail_penjualan " &
                    "GROUP BY nama_barang " &
                    "ORDER BY total_terjual DESC " &
                    "LIMIT 5"

                Using cmd As New MySqlCommand(query, conn)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        Dim no As Integer = 1
                        Do While dr.Read()
                            TableTopProduk.Controls.Add(BuatLabelTable(no.ToString()), 0, no)
                            TableTopProduk.Controls.Add(BuatLabelTable(dr("nama_barang").ToString()), 1, no)
                            TableTopProduk.Controls.Add(BuatLabelTable(dr("total_terjual").ToString()), 2, no)
                            no += 1
                        Loop
                    End Using
                End Using
            End Using
        Catch ex As Exception
            ' Jika DB gagal, isi dengan data kosong agar tabel tidak error
            TableTopProduk.Controls.Add(BuatLabelTable("-"), 0, 1)
            TableTopProduk.Controls.Add(BuatLabelTable("Tidak ada data", 1), 1, 1)
            TableTopProduk.Controls.Add(BuatLabelTable("-"), 2, 1)
        End Try
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
        hasil = MessageBox.Show("Yakin ingin logout?", "Konfirmasi",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            Me.Hide()
            FormLoginAdmin.Show()
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