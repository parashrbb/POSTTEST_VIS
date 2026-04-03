Module ModuleHelper

    Public Function DataLengkap(f As Form1) As Boolean
        If f.txtNama.Text = "" Or f.txtID.Text = "" Or f.cbDivisi.Text = "" Or f.txtEmail.Text = "" Or f.txtAlamat.Text = "" Then
            Return False
        End If

        If Not (f.rbLaki.Checked Or f.RadioButton1.Checked) Then
            Return False
        End If

        If Not (f.rbTeamLeader.Checked Or f.rbJuniorDev.Checked Or f.rbSeniorDev.Checked Or f.rbUIUX.Checked Or f.rbProjectMan.Checked) Then
            Return False
        End If

        If Not (f.cbCoding.Checked Or f.cbDebugging.Checked Or f.cbUIDesign.Checked Or f.cbBackendDev.Checked Or f.cbDatabaseMan.Checked Or f.cbHackton.Checked Or f.cbProjectCollab.Checked Or f.cbLearning.Checked) Then
            Return False
        End If

        Return True
    End Function

    Public Function GetRole(f As Form1) As String
        If f.rbTeamLeader.Checked Then Return "Lead Developer"
        If f.rbJuniorDev.Checked Then Return "Junior Developer"
        If f.rbSeniorDev.Checked Then Return "Senior Developer"
        If f.rbUIUX.Checked Then Return "UI/UX Designer"
        If f.rbProjectMan.Checked Then Return "Project Manager"
        Return ""
    End Function

    Public Function GetAktivitas(f As Form1) As String
        Dim hasil As String = ""

        If f.cbCoding.Checked Then hasil &= "Coding, "
        If f.cbDebugging.Checked Then hasil &= "Debugging, "
        If f.cbUIDesign.Checked Then hasil &= "UI Design, "
        If f.cbBackendDev.Checked Then hasil &= "Backend Development, "
        If f.cbDatabaseMan.Checked Then hasil &= "Database Management, "
        If f.cbHackton.Checked Then hasil &= "Hackathon, "
        If f.cbProjectCollab.Checked Then hasil &= "Project Collaboration, "
        If f.cbLearning.Checked Then hasil &= "Learning New Tech, "

        Return hasil.TrimEnd(", ")
    End Function

End Module