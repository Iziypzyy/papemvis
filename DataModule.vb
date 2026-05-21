Imports MySql.Data.MySqlClient
Imports System.Data

' Modul utilitas untuk eksekusi query (SELECT / INSERT / UPDATE / DELETE)
' Semua pesan dan komentar menggunakan Bahasa Indonesia.

Module DataModule

    ' Execute SELECT -> mengembalikan DataTable
    Public Function ExecSelect(query As String, Optional params As Dictionary(Of String, Object) = Nothing) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = ConnectionModule.OpenConnection()
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
        Catch ex As Exception
            ' Tangani kesalahan secara umum di sini, lempar ulang dengan pesan Indonesia
            Throw New ApplicationException("Gagal mengeksekusi query SELECT." & Environment.NewLine & ex.Message, ex)
        End Try
        Return dt
    End Function

    ' Execute non-query (INSERT / UPDATE / DELETE)
    Public Sub ExecNonQuery(query As String, Optional params As Dictionary(Of String, Object) = Nothing)
        Try
            Using conn As MySqlConnection = ConnectionModule.OpenConnection()
                Using cmd As New MySqlCommand(query, conn)
                    If params IsNot Nothing Then
                        For Each p In params
                            cmd.Parameters.AddWithValue(p.Key, p.Value)
                        Next
                    End If
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As MySqlException
            ' Jika terjadi error spesifik MySQL, beri informasi singkat dalam Bahasa Indonesia
            Throw New ApplicationException("Gagal menjalankan perintah database." & Environment.NewLine & "Pesan: " & ex.Message, ex)
        Catch ex As Exception
            Throw New ApplicationException("Terjadi kesalahan saat menjalankan perintah database." & Environment.NewLine & ex.Message, ex)
        End Try
    End Sub

    ' Execute scalar (mengembalikan satu nilai)
    Public Function ExecScalar(query As String, Optional params As Dictionary(Of String, Object) = Nothing) As Object
        Try
            Using conn As MySqlConnection = ConnectionModule.OpenConnection()
                Using cmd As New MySqlCommand(query, conn)
                    If params IsNot Nothing Then
                        For Each p In params
                            cmd.Parameters.AddWithValue(p.Key, p.Value)
                        Next
                    End If
                    Return cmd.ExecuteScalar()
                End Using
            End Using
        Catch ex As Exception
            Throw New ApplicationException("Gagal mengambil nilai dari database." & Environment.NewLine & ex.Message, ex)
        End Try
    End Function

End Module
