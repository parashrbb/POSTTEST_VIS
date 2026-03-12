<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtSmt = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnTambah = New Button()
        btnReset = New Button()
        txtIPK = New TextBox()
        lblPredik = New Label()
        SuspendLayout()
        ' 
        ' txtSmt
        ' 
        txtSmt.BackColor = Color.White
        txtSmt.Location = New Point(386, 116)
        txtSmt.Name = "txtSmt"
        txtSmt.Size = New Size(171, 31)
        txtSmt.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calisto MT", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(261, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 21)
        Label1.TabIndex = 1
        Label1.Text = "IP Semester"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calisto MT", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(261, 226)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 21)
        Label2.TabIndex = 2
        Label2.Text = "IP Kumulatif"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(386, 167)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(86, 34)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(478, 167)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(79, 34)
        btnReset.TabIndex = 6
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' txtIPK
        ' 
        txtIPK.BackColor = SystemColors.Control
        txtIPK.Location = New Point(386, 220)
        txtIPK.Name = "txtIPK"
        txtIPK.ReadOnly = True
        txtIPK.Size = New Size(171, 31)
        txtIPK.TabIndex = 7
        ' 
        ' lblPredik
        ' 
        lblPredik.AutoSize = True
        lblPredik.Font = New Font("Calisto MT", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPredik.Location = New Point(386, 280)
        lblPredik.Name = "lblPredik"
        lblPredik.Size = New Size(15, 21)
        lblPredik.TabIndex = 8
        lblPredik.Text = "-"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(lblPredik)
        Controls.Add(txtIPK)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtSmt)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSmt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents lblPredik As Label

End Class
