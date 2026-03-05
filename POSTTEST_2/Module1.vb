Module Module1
    Public daftarBuku(49, 1) As String
    Public jumlahBuku As Integer = 0

    Public Sub tambahBuku(judul As String, genre As String)
        If jumlahBuku < 50 Then
            daftarBuku(jumlahBuku, 0) = judul
            daftarBuku(jumlahBuku, 1) = genre
            jumlahBuku += 1
        Else
            Console.WriteLine("Daftar buku sudah penuh.")
        End If
    End Sub

    Public Sub tampilkanDaftarBuku()
        For i As Integer = 0 To jumlahBuku - 1
            Console.WriteLine((i + 1).ToString() & ". " & daftarBuku(i, 0) & " - " & daftarBuku(i, 1))
        Next
    End Sub

    Public Sub hapusBuku(index As Integer)
        If index >= 0 And index < jumlahBuku Then
            For i As Integer = index To jumlahBuku - 2
                daftarBuku(i, 0) = daftarBuku(i + 1, 0)
                daftarBuku(i, 1) = daftarBuku(i + 1, 1)
            Next
            jumlahBuku -= 1
        Else
            Console.WriteLine("Index tidak valid.")
        End If
    End Sub
End Module
