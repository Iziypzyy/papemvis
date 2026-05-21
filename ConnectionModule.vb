Imports System.Configuration
Imports MySql.Data.MySqlClient

' Modul untuk mengatur koneksi ke database MySQL.
' Semua teks/komentar ditulis dalam Bahasa Indonesia agar konsisten.

Module ConnectionModule

    ' Connection string default (jika tidak ada di App.config)
    Private ReadOnly DefaultConnString As String = "Server=localhost;Database=db_toko;Uid=root;Pwd=;CharSet=utf8mb4;"

    ' Mengambil connection string dari App.config (jika tersedia)
    Public Function GetConnectionString() As String
        Try
            Dim cs As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("db_toko")
            If cs IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(cs.ConnectionString) Then
                Return cs.ConnectionString
            End If
        Catch ex As Exception
            ' Jika gagal membaca konfigurasi, fallback ke default.
            ' Jangan tampilkan pesan otomatis di sini agar modul ini tetap dapat dipakai dalam unit test.
        End Try

        Return DefaultConnString
    End Function

    ' Membuka koneksi dan mengembalikan objek MySqlConnection yang sudah terbuka.
    ' Panggil .Close() / .Dispose() setelah selesai menggunakan koneksi.
    Public Function OpenConnection() As MySqlConnection
        Dim conn As New MySqlConnection(GetConnectionString())
        Try
            conn.Open()
            Return conn
        Catch ex As Exception
            ' Beri pesan kesalahan dalam Bahasa Indonesia sebelum melempar exception
            Throw New ApplicationException("Gagal membuka koneksi ke database. Periksa pengaturan koneksi dan layanan MySQL." & Environment.NewLine & ex.Message, ex)
        End Try
    End Function

End Module
