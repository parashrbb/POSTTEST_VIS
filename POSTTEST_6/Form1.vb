Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        StyleDGV()
        KosongkanForm()
    End Sub

    Private Sub StyleDGV()
        With dgvMember
            .DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45)
            .DefaultCellStyle.ForeColor = Color.White
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 200, 0)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 20, 20)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 200, 0)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
            .EnableHeadersVisualStyles = False
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(55, 55, 55)
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With
    End Sub

    Private Sub TampilData()
        dgvMember.DataSource = GetAllMember()
    End Sub

    Private Sub KosongkanForm()
        txtIDMember.Clear()
        txtNama.Clear()
        cmbPaket.SelectedIndex = -1
        txtNoHP.Clear()
        dtpTanggalDaftar.Value = DateTime.Today
        cmbStatus.SelectedIndex = -1
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtIDMember.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not ValidasiFormMember(ErrorProvider1, txtIDMember, txtNama, cmbPaket, txtNoHP, cmbStatus) Then Exit Sub

        If IDSudahAda(txtIDMember.Text.Trim()) Then
            MessageBox.Show("ID Member sudah terdaftar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIDMember.Focus()
            Exit Sub
        End If

        If SimpanMember(txtIDMember.Text.Trim(), txtNama.Text.Trim(), cmbPaket.SelectedItem.ToString(), txtNoHP.Text.Trim(), dtpTanggalDaftar.Value.ToString("yyyy-MM-dd"), cmbStatus.SelectedItem.ToString()) Then
            MessageBox.Show("Data member berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            KosongkanForm()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()
        If Not ValidasiFormMember(ErrorProvider1, txtIDMember, txtNama, cmbPaket, txtNoHP, cmbStatus) Then Exit Sub

        If UbahMember(txtIDMember.Text.Trim(), txtNama.Text.Trim(), cmbPaket.SelectedItem.ToString(), txtNoHP.Text.Trim(), dtpTanggalDaftar.Value.ToString("yyyy-MM-dd"), cmbStatus.SelectedItem.ToString()) Then
            MessageBox.Show("Data berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            KosongkanForm()
        Else
            MessageBox.Show("Data tidak ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If Not ValidasiTextBox(ErrorProvider1, txtIDMember, "Pilih data yang akan dihapus") Then Exit Sub

        Dim hasil As DialogResult = MessageBox.Show(
            "Yakin ingin menghapus member ini?" & vbNewLine &
            "Data instruktur yang terhubung tidak dapat dihapus (RESTRICT).",
            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            If HapusMember(txtIDMember.Text.Trim()) Then
                MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                KosongkanForm()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        KosongkanForm()
        TampilData()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvMember.DataSource = SearchMember(txtSearch.Text.Trim())
        End If
    End Sub

    Private Sub dgvMember_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMember.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim row As DataGridViewRow = dgvMember.Rows(e.RowIndex)

        txtIDMember.Text = row.Cells("ID Member").Value?.ToString()
        txtNama.Text = row.Cells("Nama").Value?.ToString()
        txtNoHP.Text = row.Cells("No. HP").Value?.ToString()
        cmbPaket.SelectedItem = row.Cells("Paket").Value?.ToString()
        cmbStatus.SelectedItem = row.Cells("Status").Value?.ToString()

        Dim tgl As DateTime
        If DateTime.TryParseExact(row.Cells("Tgl. Daftar").Value?.ToString(), "dd/MM/yyyy",
            System.Globalization.CultureInfo.InvariantCulture,
            System.Globalization.DateTimeStyles.None, tgl) Then
            dtpTanggalDaftar.Value = tgl
        End If
    End Sub

    Private Sub btnDetail_Click(sender As Object, e As EventArgs) Handles btnDetail.Click, mnuDetailMember.Click
        If txtIDMember.Text.Trim() = "" Then
            MessageBox.Show("Pilih member terlebih dahulu!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim statusVal As String = If(cmbStatus.SelectedItem IsNot Nothing, cmbStatus.SelectedItem.ToString(), "-")
        Dim f2 As New Form2()
        f2.lblIDMember.Text = txtIDMember.Text.Trim()
        f2.lblNama.Text = txtNama.Text.Trim()
        f2.lblPaket.Text = If(cmbPaket.SelectedItem IsNot Nothing, cmbPaket.SelectedItem.ToString(), "-")
        f2.lblHP.Text = txtNoHP.Text.Trim()
        f2.lblTanggal.Text = dtpTanggalDaftar.Value.ToString("dd/MM/yyyy")
        f2.lblStatus.Text = statusVal
        SetWarnaStatus(f2.lblStatus, statusVal)
        f2.ShowDialog()
    End Sub

    Private Sub mnuInstruktur_Click(sender As Object, e As EventArgs) Handles mnuInstruktur.Click
        Dim f3 As New Form3()
        f3.ShowDialog()
    End Sub

    Private Sub mnuInputData_Click(sender As Object, e As EventArgs) Handles mnuInputData.Click
        KosongkanForm()
    End Sub

    Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles mnuKeluar.Click
        Dim hasil As DialogResult = MessageBox.Show("Yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub txtNoHP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoHP.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtIDMember_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDMember.KeyPress
        If IsEnterKey(e) Then
            e.Handled = True
            txtNama.Focus()
        End If
    End Sub

End Class