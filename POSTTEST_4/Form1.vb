Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtxtNoHP.Mask = "+62 000-0000-0000"
    End Sub

    ' VALIDASI INPUT
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' BROWSE FOTO
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    ' ================= BUTTON SIMPAN =================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If Not DataLengkap(Me) Then
            MessageBox.Show("Inputan tidak boleh kosong!")
            Exit Sub
        End If

        Dim role As String = GetRole(Me)
        Dim aktivitas As String = GetAktivitas(Me)

        If MessageBox.Show("Simpan data?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            Dim save As New SaveFileDialog
            save.Filter = "Text File|*.txt"

            If save.ShowDialog = DialogResult.OK Then
                Dim data As String =
                    "Nama: " & txtNama.Text & vbCrLf &
                    "ID: " & txtID.Text & vbCrLf &
                    "Divisi: " & cbDivisi.Text & vbCrLf &
                    "Tanggal Lahir: " & dtpTglLahir.Text & vbCrLf &
                    "No HP: " & mtxtNoHP.Text & vbCrLf &
                    "Email: " & txtEmail.Text & vbCrLf &
                    "Alamat: " & txtAlamat.Text & vbCrLf &
                    "Role: " & role & vbCrLf &
                    "Skills: " & aktivitas

                File.WriteAllText(save.FileName, data)
                MessageBox.Show("Data berhasil disimpan!")
            End If

        End If

    End Sub

    ' ================= BUTTON CETAK =================
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If Not DataLengkap(Me) Then
            MessageBox.Show("Data belum lengkap, tidak bisa mencetak!")
            Exit Sub
        End If

        If MessageBox.Show("Cetak kartu?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            KirimKeForm2(GetRole(Me), GetAktivitas(Me))
        End If

    End Sub

    ' KIRIM DATA KE FORM2
    Sub KirimKeForm2(role As String, aktivitas As String)
        Form2.lblNama.Text = txtNama.Text
        Form2.lblID.Text = txtID.Text
        Form2.lblDivisi.Text = cbDivisi.Text
        Form2.lblHP.Text = mtxtNoHP.Text
        Form2.lblRole.Text = role
        Form2.lblAktivitas.Text = aktivitas
        Form2.PictureBox1.Image = PictureBox1.Image
        Form2.Show()
    End Sub

    ' ================= MENU =================

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        If Not DataLengkap(Me) Then
            MessageBox.Show("Data belum lengkap, tidak bisa menampilkan kartu!")
            Exit Sub
        End If

        KirimKeForm2(GetRole(Me), GetAktivitas(Me))
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        btnSimpan.PerformClick()
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        Dim open As New OpenFileDialog
        open.Filter = "Text File|*.txt"

        If open.ShowDialog = DialogResult.OK Then
            MessageBox.Show(IO.File.ReadAllText(open.FileName))
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Yakin keluar?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class