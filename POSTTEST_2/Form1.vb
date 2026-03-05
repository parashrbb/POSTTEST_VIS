Public Class Form1
    Public judulBuku As String
    Public genreBuku As String
    Public index As Integer

    Private Function cekKosong(teks As String) As Boolean
        If teks = "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub tampilkanDaftarBuku()
        lstBuku.Items.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            lstBuku.Items.Add((i + 1).ToString() & ". " & daftarBuku(i, 0) & " - " & daftarBuku(i, 1))
        Next
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        judulBuku = txtJudulTambah.Text
        genreBuku = txtGenre.Text

        If cekKosong(judulBuku) Or cekKosong(genreBuku) Then
            MessageBox.Show("Judul dan Genre harus diisi.")
            Exit Sub
        End If

        Module1.tambahBuku(judulBuku, genreBuku)
        tampilkanDaftarBuku()

        txtJudulTambah.Clear()
        txtGenre.Clear()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judulHapus As String = txtJudulHapus.Text
        Dim index As Integer = -1

        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0).ToLower = judulHapus.ToLower Then
                index = i
                Exit For
            End If
        Next

        If index <> -1 Then
            Module1.hapusBuku(index)
            tampilkanDaftarBuku()
        Else
            MessageBox.Show("Buku tidak ditemukan.")
        End If

    End Sub
End Class
