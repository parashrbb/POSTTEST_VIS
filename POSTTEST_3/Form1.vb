Public Class Form1
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Dim open As New OpenFileDialog
        open.Filter = "Image Files|*.jpg;*.png;*.jpeg"
        If open.ShowDialog = DialogResult.OK Then
            pictureBoxFoto.ImageLocation = open.FileName
        End If
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNomor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomor.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Dim radios() As RadioButton = {rbtnLaki, rbtnBini}
        Dim hobbies() As CheckBox = {cbGaming, cbCoding, cbMembaca, cbMusik, cbOlahraga,
                                     cbTraveling, cbFotografi, cbMemasak, cbMenulis, cbGambar,
                                     cbMancing, cbMelukis, cbBerkebun, cbMenontonFilm, cbBerenang}

        Dim gender As String = GetSelectedRadioButton(radios)
        Dim hobby As String = GetSelectedCheckBox(hobbies)

        If Not ValidasiInput(txtNama.Text, txtUmur.Text, txtNomor.Text, txtAlamat.Text, gender, hobby) Then
            Exit Sub
        End If

        Nama = txtNama.Text
        Umur = txtUmur.Text
        Telepon = txtNomor.Text
        Alamat = txtAlamat.Text
        JK = gender
        Hobi = hobby
        Tglahir = dtpTanggalLahir.Value
        Foto = pictureBoxFoto.ImageLocation

        Form2.Show()
    End Sub

End Class
