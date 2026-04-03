Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Developer ID Card"

        If lblNama.Text = "" Then lblNama.Text = "-"
        If lblID.Text = "" Then lblID.Text = "-"
        If lblDivisi.Text = "" Then lblDivisi.Text = "-"
        If lblHP.Text = "" Then lblHP.Text = "-"
        If lblRole.Text = "" Then lblRole.Text = "-"
        If lblAktivitas.Text = "" Then lblAktivitas.Text = "-"
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Tutup kartu?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

End Class