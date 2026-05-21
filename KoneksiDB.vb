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

End Module