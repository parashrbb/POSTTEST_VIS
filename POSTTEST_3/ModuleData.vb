Module ModuleData

    Public Nama As String
    Public Umur As String
    Public Telepon As String
    Public Alamat As String
    Public JK As String
    Public Hobi As String
    Public Foto As String
    Public Tglahir As Date

    Public Function GetSelectedRadioButton(grupRadio() As RadioButton) As String
        For Each rb As RadioButton In grupRadio
            If rb.Checked Then
                Return rb.Text
            End If
        Next
        Return ""
    End Function

    Public Function GetSelectedCheckBox(grupCheck() As CheckBox) As String
        Dim selectedItems As New List(Of String)

        For Each cb As CheckBox In grupCheck
            If cb.Checked Then
                selectedItems.Add(cb.Text)
            End If
        Next

        Return String.Join(", ", selectedItems)
    End Function

    Public Function ValidasiInput(nama As String, umur As String, telp As String, alamat As String, gender As String, hobby As String) As Boolean
        If nama = "" Or umur = "" Or telp = "" Or alamat = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Return False
        End If

        If gender = "" Then
            MessageBox.Show("Pilih jenis kelamin")
            Return False
        End If

        If hobby = "" Then
            MessageBox.Show("Pilih minimal satu hobby")
            Return False
        End If

        Return True

    End Function

End Module
