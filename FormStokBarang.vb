Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Class FormStokBarang

    Private Sub FormStokBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataDB()
    End Sub

    Public Sub LoadDataDB()
        dgvStok.Rows.Clear()
        Try
            Using conn As MySqlConnection = KoneksiDB.GetConnection()
                ' Gunakan VIEW v_stok_barang yang sudah ada di database
                Dim query As String = "SELECT kode_barang, nama_barang, stok, stok_minimum, satuan, status_stok FROM v_stok_barang"
                Using cmd As New MySqlCommand(query, conn)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        Do While dr.Read()
                            dgvStok.Rows.Add(
                                dr("kode_barang").ToString(),
                                dr("nama_barang").ToString(),
                                dr("stok").ToString(),
                                dr("stok_minimum").ToString(),
                                dr("satuan").ToString(),
                                ""  ' kolom status dikosongkan dulu, diisi UpdateStatusStok()
                            )
                        Loop
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data stok!" & vbNewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        UpdateStatusStok()
        lblTotalData.Text = "Total Data : " & dgvStok.Rows.Count
    End Sub

    ' Logika untuk menentukan status "Aman" atau "Menipis"
    Private Sub UpdateStatusStok()
        For Each row As DataGridViewRow In dgvStok.Rows
            If Not row.IsNewRow Then
                Dim stok As Integer = Val(row.Cells("colStok").Value)
                Dim stokMin As Integer = Val(row.Cells("colStokMin").Value)

                If stok <= stokMin Then
                    row.Cells("colStatus").Value = "MENIPIS"
                    row.Cells("colStatus").Style.ForeColor = Color.Red
                    row.DefaultCellStyle.BackColor = Color.MistyRose
                Else
                    row.Cells("colStatus").Value = "AMAN"
                    row.Cells("colStatus").Style.ForeColor = Color.Green
                    row.DefaultCellStyle.BackColor = Color.White
                End If
            End If
        Next
    End Sub

    ' Fitur pencarian barang secara real-time
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Dim kataKunci As String = txtCari.Text.ToLower()
        If kataKunci = "cari barang..." Then Exit Sub

        For Each row As DataGridViewRow In dgvStok.Rows
            If Not row.IsNewRow Then
                Dim namaBarang As String = row.Cells("colNama").Value.ToString().ToLower()
                Dim kodeBarang As String = row.Cells("colKode").Value.ToString().ToLower()
                If namaBarang.Contains(kataKunci) Or kodeBarang.Contains(kataKunci) Then
                    row.Visible = True
                Else
                    dgvStok.CurrentCell = Nothing
                    row.Visible = False
                End If
            End If
        Next
    End Sub

End Class