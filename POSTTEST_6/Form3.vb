Public Class Form3

    ' -------------------------------------------------------
    '  HELPER
    ' -------------------------------------------------------

    Private Sub StyleDGV()
        With dgvInstruktur
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

    Private Sub MuatDataMember()
        Dim dt As DataTable = GetAllMemberCombo()
        cmbMember.DataSource = dt
        cmbMember.DisplayMember = "labelMember"
        cmbMember.ValueMember = "idMember"
        cmbMember.SelectedIndex = -1
    End Sub

    Private Sub TampilData()
        dgvInstruktur.DataSource = GetAllInstruktur()
    End Sub

    Private Sub KosongkanForm()
        txtIDInstruktur.Clear()
        cmbMember.SelectedIndex = -1
        txtNamaInstruktur.Clear()
        cmbSpesialisasi.SelectedIndex = -1
        txtNoHPInstruktur.Clear()
        cmbJadwal.SelectedIndex = -1
        txtCatatan.Clear()
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtIDInstruktur.Focus()
    End Sub

    ' -------------------------------------------------------
    '  EVENTS
    ' -------------------------------------------------------

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StyleDGV()
        MuatDataMember()
        TampilData()
        KosongkanForm()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        If Not ValidasiFormInstruktur(ErrorProvider1, txtIDInstruktur, cmbMember,
                                      txtNamaInstruktur, cmbSpesialisasi,
                                      txtNoHPInstruktur, cmbJadwal) Then Exit Sub

        Dim idI As String = txtIDInstruktur.Text.Trim()

        If IDInstrukturSudahAda(idI) Then
            MessageBox.Show("ID Instruktur sudah terdaftar!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIDInstruktur.Focus()
            Exit Sub
        End If

        Dim idM As String = cmbMember.SelectedValue.ToString()
        Dim nama As String = txtNamaInstruktur.Text.Trim()
        Dim spesial As String = cmbSpesialisasi.SelectedItem.ToString()
        Dim noHP As String = txtNoHPInstruktur.Text.Trim()
        Dim jadwal As String = cmbJadwal.SelectedItem.ToString()
        Dim catatan As String = txtCatatan.Text.Trim()

        If SimpanInstruktur(idI, idM, nama, spesial, noHP, jadwal, catatan) Then
            MessageBox.Show("Data instruktur berhasil disimpan!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            KosongkanForm()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()

        If Not ValidasiFormInstruktur(ErrorProvider1, txtIDInstruktur, cmbMember,
                                      txtNamaInstruktur, cmbSpesialisasi,
                                      txtNoHPInstruktur, cmbJadwal) Then Exit Sub

        Dim idI As String = txtIDInstruktur.Text.Trim()
        Dim idM As String = cmbMember.SelectedValue.ToString()
        Dim nama As String = txtNamaInstruktur.Text.Trim()
        Dim spesial As String = cmbSpesialisasi.SelectedItem.ToString()
        Dim noHP As String = txtNoHPInstruktur.Text.Trim()
        Dim jadwal As String = cmbJadwal.SelectedItem.ToString()
        Dim catatan As String = txtCatatan.Text.Trim()

        If UbahInstruktur(idI, idM, nama, spesial, noHP, jadwal, catatan) Then
            MessageBox.Show("Data instruktur berhasil diubah!", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            KosongkanForm()
        Else
            MessageBox.Show("Data tidak ditemukan.", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If Not ValidasiTextBox(ErrorProvider1, txtIDInstruktur, "Pilih data yang akan dihapus") Then Exit Sub

        Dim hasil As DialogResult = MessageBox.Show(
            "Yakin ingin menghapus data instruktur ini?", "Konfirmasi Hapus",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            If HapusInstruktur(txtIDInstruktur.Text.Trim()) Then
                MessageBox.Show("Data instruktur berhasil dihapus!", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            dgvInstruktur.DataSource = SearchInstruktur(txtSearch.Text.Trim())
        End If
    End Sub

    Private Sub dgvInstruktur_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInstruktur.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim row As DataGridViewRow = dgvInstruktur.Rows(e.RowIndex)

        txtIDInstruktur.Text = row.Cells("ID Instruktur").Value?.ToString()
        txtNamaInstruktur.Text = row.Cells("Nama Instruktur").Value?.ToString()
        txtNoHPInstruktur.Text = row.Cells("No. HP").Value?.ToString()
        txtCatatan.Text = row.Cells("Catatan").Value?.ToString()

        Dim spesVal As String = row.Cells("Spesialisasi").Value?.ToString()
        Dim idxSpes As Integer = cmbSpesialisasi.FindStringExact(spesVal)
        If idxSpes >= 0 Then cmbSpesialisasi.SelectedIndex = idxSpes

        Dim jadwalVal As String = row.Cells("Jadwal").Value?.ToString()
        Dim idxJadwal As Integer = cmbJadwal.FindStringExact(jadwalVal)
        If idxJadwal >= 0 Then cmbJadwal.SelectedIndex = idxJadwal

        Dim namaMember As String = row.Cells("Nama Member").Value?.ToString()
        Dim dt As DataTable = TryCast(cmbMember.DataSource, DataTable)
        If dt IsNot Nothing Then
            For i As Integer = 0 To dt.Rows.Count - 1
                If dt.Rows(i)("labelMember").ToString().Contains(namaMember) Then
                    cmbMember.SelectedIndex = i
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub txtIDInstruktur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDInstruktur.KeyPress
        If IsEnterKey(e) Then
            e.Handled = True
            txtNamaInstruktur.Focus()
        End If
    End Sub

    Private Sub txtNoHPInstruktur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoHPInstruktur.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub txtNamaInstruktur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaInstruktur.KeyPress
        HanyaHuruf(e)
    End Sub
End Class