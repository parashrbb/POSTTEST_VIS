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
        pictureBoxFoto = New PictureBox()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        lblAlamat = New Label()
        lblHobi = New Label()
        lblNomor = New Label()
        lblJK = New Label()
        lblTanggalLahir = New Label()
        lblUmur = New Label()
        lblNama = New Label()
        CType(pictureBoxFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pictureBoxFoto
        ' 
        pictureBoxFoto.Location = New Point(71, 131)
        pictureBoxFoto.Name = "pictureBoxFoto"
        pictureBoxFoto.Size = New Size(224, 281)
        pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBoxFoto.TabIndex = 1
        pictureBoxFoto.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Type-Simple", 10F)
        Label5.Location = New Point(348, 309)
        Label5.Name = "Label5"
        Label5.Size = New Size(143, 21)
        Label5.TabIndex = 11
        Label5.Text = "No Telepon"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Type-Simple", 10F)
        Label4.Location = New Point(349, 264)
        Label4.Name = "Label4"
        Label4.Size = New Size(179, 21)
        Label4.TabIndex = 10
        Label4.Text = "Jenis Kelamin"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Type-Simple", 10F)
        Label2.Location = New Point(349, 215)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 21)
        Label2.TabIndex = 8
        Label2.Text = "Umur"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Type-Simple", 10F)
        Label1.Location = New Point(349, 165)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 21)
        Label1.TabIndex = 7
        Label1.Text = "Nama"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Type-Simple", 10F)
        Label6.Location = New Point(349, 351)
        Label6.Name = "Label6"
        Label6.Size = New Size(95, 21)
        Label6.TabIndex = 13
        Label6.Text = "Alamat"
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Type-Simple", 7.999999F)
        Label7.Location = New Point(349, 469)
        Label7.Name = "Label7"
        Label7.Size = New Size(52, 17)
        Label7.TabIndex = 12
        Label7.Text = "Hobi"
        Label7.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = Color.Transparent
        lblAlamat.Font = New Font("Type-Simple", 10F)
        lblAlamat.Location = New Point(548, 351)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(52, 21)
        lblAlamat.TabIndex = 20
        lblAlamat.Text = "......."
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.BackColor = Color.Transparent
        lblHobi.Font = New Font("Type-Simple", 7.999999F)
        lblHobi.Location = New Point(564, 469)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(43, 17)
        lblHobi.TabIndex = 19
        lblHobi.Text = "......."
        ' 
        ' lblNomor
        ' 
        lblNomor.AutoSize = True
        lblNomor.BackColor = Color.Transparent
        lblNomor.Font = New Font("Type-Simple", 10F)
        lblNomor.Location = New Point(548, 309)
        lblNomor.Name = "lblNomor"
        lblNomor.Size = New Size(52, 21)
        lblNomor.TabIndex = 18
        lblNomor.Text = "......."
        ' 
        ' lblJK
        ' 
        lblJK.AutoSize = True
        lblJK.BackColor = Color.Transparent
        lblJK.Font = New Font("Type-Simple", 10F)
        lblJK.Location = New Point(548, 264)
        lblJK.Name = "lblJK"
        lblJK.Size = New Size(52, 21)
        lblJK.TabIndex = 17
        lblJK.Text = "......."
        ' 
        ' lblTanggalLahir
        ' 
        lblTanggalLahir.AutoSize = True
        lblTanggalLahir.BackColor = Color.Transparent
        lblTanggalLahir.Font = New Font("Type-Simple", 7.999999F)
        lblTanggalLahir.Location = New Point(128, 519)
        lblTanggalLahir.Name = "lblTanggalLahir"
        lblTanggalLahir.Size = New Size(43, 17)
        lblTanggalLahir.TabIndex = 16
        lblTanggalLahir.Text = "......."
        lblTanggalLahir.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.BackColor = Color.Transparent
        lblUmur.Font = New Font("Type-Simple", 10F)
        lblUmur.Location = New Point(548, 215)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(52, 21)
        lblUmur.TabIndex = 15
        lblUmur.Text = "......."
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.Font = New Font("Type-Simple", 10F)
        lblNama.Location = New Point(548, 165)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(52, 21)
        lblNama.TabIndex = 14
        lblNama.Text = "......."
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(927, 567)
        Controls.Add(lblAlamat)
        Controls.Add(lblHobi)
        Controls.Add(lblNomor)
        Controls.Add(lblJK)
        Controls.Add(lblTanggalLahir)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(pictureBoxFoto)
        DoubleBuffered = True
        Name = "Form2"
        Text = "Form2"
        CType(pictureBoxFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pictureBoxFoto As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblHobi As Label
    Friend WithEvents lblNomor As Label
    Friend WithEvents lblJK As Label
    Friend WithEvents lblTanggalLahir As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblNama As Label
End Class
