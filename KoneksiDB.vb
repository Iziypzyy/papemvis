Imports MySql.Data.MySqlClient

Module KoneksiDB

    ' =========================
    ' KONFIGURASI DATABASE
    ' =========================
    Private Const SERVER As String = "localhost"
    Private Const DATABASE As String = "db_toko"
    Private Const USER As String = "root"
    Private Const PASSWORD As String = ""

    Private ReadOnly ConnString As String =
        $"Server={SERVER};Database={DATABASE};Uid={USER};Pwd={PASSWORD};CharSet=utf8mb4;"

    ' =========================
    ' MEMBUKA KONEKSI DATABASE
    ' =========================
    Public Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(ConnString)
        conn.Open()
        Return conn
    End Function

    ' =========================
    ' EXECUTE SCALAR (Mengambil 1 Nilai, misal: Hitung Jumlah Data)
    ' =========================
    Public Function ExecScalar(query As String, Optional params As Dictionary(Of String, Object) = Nothing) As Object
        Using conn As MySqlConnection = GetConnection()
            Using cmd As New MySqlCommand(query, conn)
                If params IsNot Nothing Then
                    For Each p In params
                        cmd.Parameters.AddWithValue(p.Key, p.Value)
                    Next
                End If
                Return cmd.ExecuteScalar()
            End Using
        End Using
    End Function

    ' =========================
    ' EXECUTE INSERT / UPDATE / DELETE (Ubah data di Database)
    ' =========================
    Public Sub ExecNonQuery(query As String, Optional params As Dictionary(Of String, Object) = Nothing)
        Using conn As MySqlConnection = GetConnection()
            Using cmd As New MySqlCommand(query, conn)
                If params IsNot Nothing Then
                    For Each p In params
                        cmd.Parameters.AddWithValue(p.Key, p.Value)
                    Next
                End If
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' =========================
    ' EXECUTE SELECT (Mengambil Banyak Data / Tabel)
    ' =========================
    Public Function ExecSelect(query As String, Optional params As Dictionary(Of String, Object) = Nothing) As DataTable
        Dim dt As New DataTable()
        Using conn As MySqlConnection = GetConnection()
            Using cmd As New MySqlCommand(query, conn)
                If params IsNot Nothing Then
                    For Each p In params
                        cmd.Parameters.AddWithValue(p.Key, p.Value)
                    Next
                End If
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

End Module