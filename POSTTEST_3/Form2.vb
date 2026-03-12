Public Class Form2
    Private Sub FormHasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblNama.Text = Nama
        lblUmur.Text = Umur
        lblNomor.Text = Telepon
        lblAlamat.Text = Alamat
        lblJK.Text = JK
        lblHobi.Text = Hobi
        lblTanggalLahir.Text = Tglahir.ToShortDateString()

        pictureBoxFoto.ImageLocation = Foto

    End Sub
End Class