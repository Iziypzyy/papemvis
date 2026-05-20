
Imports MySqlConnector
Module KoneksiDB

    ' === KONFIGURASI — sesuaikan di sini ===
    Private Const SERVER As String = "localhost"
    Private Const DATABASE As String = "db_toko"
    Private Const USER As String = "root"
    Private Const PASSWORD As String = ""          ' kosong = default XAMPP
    ' ========================================

    Private ReadOnly ConnString As String =
        $"Server={SERVER};Database={DATABASE};Uid={USER};Pwd={PASSWORD};CharSet=utf8mb4;"

    ''' <summary>
    ''' Mengembalikan objek MySqlConnection yang sudah terbuka.
    ''' Selalu tutup koneksi setelah selesai (pakai Using atau .Close()).
    ''' </summary>
    Public Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(ConnString)
        conn.Open()
        Return conn
    End Function

End Module