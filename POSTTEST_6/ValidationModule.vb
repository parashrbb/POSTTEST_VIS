Module ValidationModule

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Not (Char.IsLetter(e.KeyChar) OrElse
                Char.IsWhiteSpace(e.KeyChar) OrElse
                Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cmb As ComboBox, pesan As String) As Boolean
        If cmb.SelectedIndex = -1 Then
            ep.SetError(cmb, pesan)
            Return False
        Else
            ep.SetError(cmb, "")
            Return True
        End If
    End Function

    Public Function ValidasiFormMember(ep As ErrorProvider, txtID As TextBox, txtNama As TextBox, cmbPaket As ComboBox, txtNoHP As TextBox, cmbStatus As ComboBox) As Boolean
        Dim v1 As Boolean = ValidasiTextBox(ep, txtID, "ID Member tidak boleh kosong")
        Dim v2 As Boolean = ValidasiTextBox(ep, txtNama, "Nama tidak boleh kosong")
        Dim v3 As Boolean = ValidasiComboBox(ep, cmbPaket, "Pilih paket member")
        Dim v4 As Boolean = ValidasiTextBox(ep, txtNoHP, "No. HP tidak boleh kosong")
        Dim v5 As Boolean = ValidasiComboBox(ep, cmbStatus, "Pilih status member")
        Return v1 And v2 And v3 And v4 And v5
    End Function

    Public Function ValidasiFormInstruktur(ep As ErrorProvider,
                                           txtID As TextBox,
                                           cmbMember As ComboBox,
                                           txtNama As TextBox,
                                           cmbSpesial As ComboBox,
                                           txtNoHP As TextBox,
                                           cmbJadwal As ComboBox) As Boolean
        Dim v1 As Boolean = ValidasiTextBox(ep, txtID, "ID Instruktur tidak boleh kosong")
        Dim v2 As Boolean = ValidasiComboBox(ep, cmbMember, "Pilih Member yang ditangani")
        Dim v3 As Boolean = ValidasiTextBox(ep, txtNama, "Nama Instruktur tidak boleh kosong")
        Dim v4 As Boolean = ValidasiComboBox(ep, cmbSpesial, "Pilih Spesialisasi")
        Dim v5 As Boolean = ValidasiTextBox(ep, txtNoHP, "No. HP Instruktur tidak boleh kosong")
        Dim v6 As Boolean = ValidasiComboBox(ep, cmbJadwal, "Pilih Jadwal Latihan")
        Return v1 And v2 And v3 And v4 And v5 And v6
    End Function

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function

    Public Sub SetWarnaStatus(lbl As Label, status As String)
        Select Case status
            Case "Aktif"
                lbl.ForeColor = Color.FromArgb(0, 200, 100)
            Case "Tidak Aktif"
                lbl.ForeColor = Color.FromArgb(220, 60, 60)
            Case Else
                lbl.ForeColor = Color.FromArgb(255, 200, 0)
        End Select
    End Sub

End Module