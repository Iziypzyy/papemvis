Imports System.Text.RegularExpressions

' Modul kecil untuk validasi input form.
' Semua teks pesan ditulis dalam Bahasa Indonesia.

Module ValidationModule

    ' Pastikan nilai tidak kosong; bila kosong tampilkan pesan dan kembalikan False.
    Public Function Require(value As String, fieldName As String) As Boolean
        If String.IsNullOrWhiteSpace(value) Then
            MessageBox.Show(fieldName & " wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    ' Cek apakah string merupakan integer
    Public Function IsInteger(value As String) As Boolean
        Dim n As Integer
        Return Integer.TryParse(value, n)
    End Function

    ' Cek apakah string merupakan decimal / angka desimal
    Public Function IsDecimal(value As String) As Boolean
        Dim d As Decimal
        Return Decimal.TryParse(value, d)
    End Function

    ' Validasi email sederhana
    Public Function IsEmail(value As String) As Boolean
        If String.IsNullOrWhiteSpace(value) Then Return False
        Dim pattern = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Return Regex.IsMatch(value, pattern, RegexOptions.IgnoreCase)
    End Function

End Module