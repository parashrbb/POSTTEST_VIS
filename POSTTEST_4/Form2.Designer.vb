<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        PictureBox1 = New PictureBox()
        lblNama = New Label()
        lblID = New Label()
        lblDivisi = New Label()
        lblHP = New Label()
        lblRole = New Label()
        lblAktivitas = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(53, 133)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(190, 229)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.Font = New Font("Poppins", 9F)
        lblNama.ForeColor = Color.White
        lblNama.Location = New Point(303, 160)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(67, 31)
        lblNama.TabIndex = 1
        lblNama.Text = "Label1"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.BackColor = Color.Transparent
        lblID.Font = New Font("Poppins", 9F)
        lblID.ForeColor = Color.White
        lblID.Location = New Point(355, 61)
        lblID.Name = "lblID"
        lblID.Size = New Size(67, 31)
        lblID.TabIndex = 2
        lblID.Text = "Label1"
        ' 
        ' lblDivisi
        ' 
        lblDivisi.AutoSize = True
        lblDivisi.BackColor = Color.Transparent
        lblDivisi.Font = New Font("Poppins", 9F)
        lblDivisi.ForeColor = Color.White
        lblDivisi.Location = New Point(303, 202)
        lblDivisi.Name = "lblDivisi"
        lblDivisi.Size = New Size(71, 31)
        lblDivisi.TabIndex = 3
        lblDivisi.Text = "Label2"
        ' 
        ' lblHP
        ' 
        lblHP.AutoSize = True
        lblHP.BackColor = Color.Transparent
        lblHP.Font = New Font("Poppins", 9F)
        lblHP.ForeColor = Color.White
        lblHP.Location = New Point(303, 242)
        lblHP.Name = "lblHP"
        lblHP.Size = New Size(72, 31)
        lblHP.TabIndex = 4
        lblHP.Text = "Label3"
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.BackColor = Color.Transparent
        lblRole.Font = New Font("Poppins", 9F)
        lblRole.ForeColor = Color.White
        lblRole.Location = New Point(303, 281)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(72, 31)
        lblRole.TabIndex = 5
        lblRole.Text = "Label4"
        ' 
        ' lblAktivitas
        ' 
        lblAktivitas.AutoSize = True
        lblAktivitas.BackColor = Color.Transparent
        lblAktivitas.Font = New Font("Poppins", 9F)
        lblAktivitas.ForeColor = Color.White
        lblAktivitas.Location = New Point(303, 319)
        lblAktivitas.Name = "lblAktivitas"
        lblAktivitas.Size = New Size(72, 31)
        lblAktivitas.TabIndex = 6
        lblAktivitas.Text = "Label4"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(711, 407)
        Controls.Add(lblAktivitas)
        Controls.Add(lblRole)
        Controls.Add(lblHP)
        Controls.Add(lblDivisi)
        Controls.Add(lblID)
        Controls.Add(lblNama)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        ForeColor = SystemColors.ControlDarkDark
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblDivisi As Label
    Friend WithEvents lblHP As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents lblAktivitas As Label
End Class
