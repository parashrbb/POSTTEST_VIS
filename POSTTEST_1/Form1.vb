Public Class Form1
    Dim totalSemester As Integer = 0
    Dim totalIP As Double = 0
    Dim IPK As Double = 0
    Dim IPS As Double = 0
    Private Sub predikatIPK()
        If IPK >= 3.01 Then
            lblPredik.Text = "Sangat Memuaskan"
        ElseIf IPK >= 2.76 Then
            lblPredik.Text = "Memuaskan"
        ElseIf IPK >= 2.0 Then
            lblPredik.Text = "Cukup"
        Else
            lblPredik.Text = "-"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalSemester = 0
        totalIP = 0
        txtSmt.Clear()
        txtIPK.Clear()
        lblPredik.Text = "-"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Double.TryParse(txtSmt.Text, IPS) Then
            ' angka berhasil dibaca '
        Else
            MessageBox.Show("Masukkan angka yang valid.")
            Exit Sub
        End If
        totalSemester += 1
        totalIP += IPS
        IPK = totalIP / totalSemester
        txtIPK.Text = IPK.ToString("N2")
        predikatIPK()
        txtSmt.Clear()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtIPK.TextChanged
    End Sub

    Private Sub txtSmt_TextChanged(sender As Object, e As EventArgs) Handles txtSmt.TextChanged
    End Sub
End Class
