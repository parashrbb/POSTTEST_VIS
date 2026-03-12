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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        pictureBoxFoto = New PictureBox()
        btnCari = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtNomor = New TextBox()
        txtAlamat = New TextBox()
        dtpTanggalLahir = New DateTimePicker()
        GroupBox1 = New GroupBox()
        rbtnBini = New RadioButton()
        rbtnLaki = New RadioButton()
        GroupBox2 = New GroupBox()
        cbMancing = New CheckBox()
        cbMelukis = New CheckBox()
        cbBerkebun = New CheckBox()
        cbBerenang = New CheckBox()
        cbMenontonFilm = New CheckBox()
        cbFotografi = New CheckBox()
        cbTraveling = New CheckBox()
        cbMemasak = New CheckBox()
        cbMusik = New CheckBox()
        cbCoding = New CheckBox()
        cbGaming = New CheckBox()
        cbGambar = New CheckBox()
        cbOlahraga = New CheckBox()
        cbMembaca = New CheckBox()
        cbMenulis = New CheckBox()
        btnCetak = New Button()
        CType(pictureBoxFoto, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' pictureBoxFoto
        ' 
        pictureBoxFoto.Location = New Point(93, 145)
        pictureBoxFoto.Name = "pictureBoxFoto"
        pictureBoxFoto.Size = New Size(212, 254)
        pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBoxFoto.TabIndex = 0
        pictureBoxFoto.TabStop = False
        ' 
        ' btnCari
        ' 
        btnCari.Location = New Point(93, 409)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(212, 34)
        btnCari.TabIndex = 1
        btnCari.Text = "Browse"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Type-Simple", 9F)
        Label1.Location = New Point(444, 131)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 19)
        Label1.TabIndex = 2
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Type-Simple", 9F)
        Label2.Location = New Point(738, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 19)
        Label2.TabIndex = 3
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Type-Simple", 9F)
        Label3.Location = New Point(444, 211)
        Label3.Name = "Label3"
        Label3.Size = New Size(161, 19)
        Label3.TabIndex = 4
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Type-Simple", 9F)
        Label4.Location = New Point(738, 211)
        Label4.Name = "Label4"
        Label4.Size = New Size(134, 19)
        Label4.TabIndex = 5
        Label4.Text = "No. Telepon"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Type-Simple", 9F)
        Label5.Location = New Point(444, 282)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 19)
        Label5.TabIndex = 6
        Label5.Text = "Alamat"
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.White
        txtNama.Location = New Point(444, 153)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(226, 31)
        txtNama.TabIndex = 7
        ' 
        ' txtUmur
        ' 
        txtUmur.BackColor = Color.White
        txtUmur.Location = New Point(738, 153)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(226, 31)
        txtUmur.TabIndex = 9
        ' 
        ' txtNomor
        ' 
        txtNomor.BackColor = Color.White
        txtNomor.Location = New Point(738, 233)
        txtNomor.Name = "txtNomor"
        txtNomor.Size = New Size(226, 31)
        txtNomor.TabIndex = 10
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.White
        txtAlamat.Location = New Point(444, 304)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(523, 31)
        txtAlamat.TabIndex = 11
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.CalendarMonthBackground = Color.White
        dtpTanggalLahir.Format = DateTimePickerFormat.Custom
        dtpTanggalLahir.Location = New Point(444, 233)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(226, 31)
        dtpTanggalLahir.TabIndex = 12
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Maroon
        GroupBox1.Controls.Add(rbtnBini)
        GroupBox1.Controls.Add(rbtnLaki)
        GroupBox1.Font = New Font("Consolas", 9F, FontStyle.Bold)
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(93, 468)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(212, 162)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jenis Kelamin"
        ' 
        ' rbtnBini
        ' 
        rbtnBini.AutoSize = True
        rbtnBini.Font = New Font("Consolas", 9F)
        rbtnBini.Location = New Point(14, 77)
        rbtnBini.Name = "rbtnBini"
        rbtnBini.Size = New Size(125, 26)
        rbtnBini.TabIndex = 1
        rbtnBini.TabStop = True
        rbtnBini.Text = "Perempuan"
        rbtnBini.UseVisualStyleBackColor = True
        ' 
        ' rbtnLaki
        ' 
        rbtnLaki.AutoSize = True
        rbtnLaki.Font = New Font("Consolas", 9F)
        rbtnLaki.Location = New Point(14, 42)
        rbtnLaki.Name = "rbtnLaki"
        rbtnLaki.Size = New Size(125, 26)
        rbtnLaki.TabIndex = 0
        rbtnLaki.TabStop = True
        rbtnLaki.Text = "Laki-Laki"
        rbtnLaki.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Cornsilk
        GroupBox2.Controls.Add(cbMancing)
        GroupBox2.Controls.Add(cbMelukis)
        GroupBox2.Controls.Add(cbBerkebun)
        GroupBox2.Controls.Add(cbBerenang)
        GroupBox2.Controls.Add(cbMenontonFilm)
        GroupBox2.Controls.Add(cbFotografi)
        GroupBox2.Controls.Add(cbTraveling)
        GroupBox2.Controls.Add(cbMemasak)
        GroupBox2.Controls.Add(cbMusik)
        GroupBox2.Controls.Add(cbCoding)
        GroupBox2.Controls.Add(cbGaming)
        GroupBox2.Controls.Add(cbGambar)
        GroupBox2.Controls.Add(cbOlahraga)
        GroupBox2.Controls.Add(cbMembaca)
        GroupBox2.Controls.Add(cbMenulis)
        GroupBox2.Font = New Font("Type-Simple", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.Black
        GroupBox2.Location = New Point(444, 355)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(523, 218)
        GroupBox2.TabIndex = 14
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hobi"
        ' 
        ' cbMancing
        ' 
        cbMancing.AutoSize = True
        cbMancing.Font = New Font("Consolas", 9F)
        cbMancing.Location = New Point(368, 38)
        cbMancing.Name = "cbMancing"
        cbMancing.Size = New Size(126, 26)
        cbMancing.TabIndex = 10
        cbMancing.Text = "Memancing"
        cbMancing.UseVisualStyleBackColor = True
        ' 
        ' cbMelukis
        ' 
        cbMelukis.AutoSize = True
        cbMelukis.Font = New Font("Consolas", 9F)
        cbMelukis.Location = New Point(368, 73)
        cbMelukis.Name = "cbMelukis"
        cbMelukis.Size = New Size(106, 26)
        cbMelukis.TabIndex = 11
        cbMelukis.Text = "Melukis"
        cbMelukis.UseVisualStyleBackColor = True
        ' 
        ' cbBerkebun
        ' 
        cbBerkebun.AutoSize = True
        cbBerkebun.Font = New Font("Consolas", 9F)
        cbBerkebun.Location = New Point(368, 108)
        cbBerkebun.Name = "cbBerkebun"
        cbBerkebun.Size = New Size(116, 26)
        cbBerkebun.TabIndex = 12
        cbBerkebun.Text = "Berkebun"
        cbBerkebun.UseVisualStyleBackColor = True
        ' 
        ' cbBerenang
        ' 
        cbBerenang.AutoSize = True
        cbBerenang.Font = New Font("Consolas", 9F)
        cbBerenang.Location = New Point(368, 178)
        cbBerenang.Name = "cbBerenang"
        cbBerenang.Size = New Size(116, 26)
        cbBerenang.TabIndex = 14
        cbBerenang.Text = "Berenang"
        cbBerenang.UseVisualStyleBackColor = True
        ' 
        ' cbMenontonFilm
        ' 
        cbMenontonFilm.AutoSize = True
        cbMenontonFilm.Font = New Font("Consolas", 9F)
        cbMenontonFilm.Location = New Point(368, 143)
        cbMenontonFilm.Name = "cbMenontonFilm"
        cbMenontonFilm.Size = New Size(76, 26)
        cbMenontonFilm.TabIndex = 13
        cbMenontonFilm.Text = "Film"
        cbMenontonFilm.UseVisualStyleBackColor = True
        ' 
        ' cbFotografi
        ' 
        cbFotografi.AutoSize = True
        cbFotografi.Font = New Font("Consolas", 9F)
        cbFotografi.Location = New Point(197, 38)
        cbFotografi.Name = "cbFotografi"
        cbFotografi.Size = New Size(126, 26)
        cbFotografi.TabIndex = 5
        cbFotografi.Text = "Fotografi"
        cbFotografi.UseVisualStyleBackColor = True
        ' 
        ' cbTraveling
        ' 
        cbTraveling.AutoSize = True
        cbTraveling.Font = New Font("Consolas", 9F)
        cbTraveling.Location = New Point(36, 178)
        cbTraveling.Name = "cbTraveling"
        cbTraveling.Size = New Size(126, 26)
        cbTraveling.TabIndex = 4
        cbTraveling.Text = "Traveling"
        cbTraveling.UseVisualStyleBackColor = True
        ' 
        ' cbMemasak
        ' 
        cbMemasak.AutoSize = True
        cbMemasak.Font = New Font("Consolas", 9F)
        cbMemasak.Location = New Point(197, 73)
        cbMemasak.Name = "cbMemasak"
        cbMemasak.Size = New Size(106, 26)
        cbMemasak.TabIndex = 6
        cbMemasak.Text = "Memasak"
        cbMemasak.UseVisualStyleBackColor = True
        ' 
        ' cbMusik
        ' 
        cbMusik.AutoSize = True
        cbMusik.Font = New Font("Consolas", 9F)
        cbMusik.Location = New Point(36, 143)
        cbMusik.Name = "cbMusik"
        cbMusik.Size = New Size(86, 26)
        cbMusik.TabIndex = 3
        cbMusik.Text = "Musik"
        cbMusik.UseVisualStyleBackColor = True
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Font = New Font("Consolas", 9F)
        cbCoding.Location = New Point(197, 108)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(96, 26)
        cbCoding.TabIndex = 7
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Font = New Font("Consolas", 9F)
        cbGaming.Location = New Point(36, 108)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(96, 26)
        cbGaming.TabIndex = 2
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' cbGambar
        ' 
        cbGambar.AutoSize = True
        cbGambar.Font = New Font("Consolas", 9F)
        cbGambar.Location = New Point(197, 178)
        cbGambar.Name = "cbGambar"
        cbGambar.Size = New Size(96, 26)
        cbGambar.TabIndex = 9
        cbGambar.Text = "Gambar"
        cbGambar.UseVisualStyleBackColor = True
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.Font = New Font("Consolas", 9F)
        cbOlahraga.Location = New Point(36, 73)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(116, 26)
        cbOlahraga.TabIndex = 1
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Font = New Font("Consolas", 9F)
        cbMembaca.Location = New Point(36, 40)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(106, 26)
        cbMembaca.TabIndex = 0
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' cbMenulis
        ' 
        cbMenulis.AutoSize = True
        cbMenulis.Font = New Font("Consolas", 9F)
        cbMenulis.Location = New Point(197, 143)
        cbMenulis.Name = "cbMenulis"
        cbMenulis.Size = New Size(106, 26)
        cbMenulis.TabIndex = 8
        cbMenulis.Text = "Menulis"
        cbMenulis.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.Snow
        btnCetak.Location = New Point(444, 579)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(520, 36)
        btnCetak.TabIndex = 15
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1083, 660)
        Controls.Add(btnCetak)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(dtpTanggalLahir)
        Controls.Add(txtAlamat)
        Controls.Add(txtNomor)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCari)
        Controls.Add(pictureBoxFoto)
        DoubleBuffered = True
        Name = "Form1"
        Text = "Form1"
        CType(pictureBoxFoto, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pictureBoxFoto As PictureBox
    Friend WithEvents btnCari As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNomor As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents rbtnBini As RadioButton
    Friend WithEvents rbtnLaki As RadioButton
    Friend WithEvents cbTraveling As CheckBox
    Friend WithEvents cbMusik As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbFotografi As CheckBox
    Friend WithEvents cbMemasak As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbMenulis As CheckBox
    Friend WithEvents cbGambar As CheckBox
    Friend WithEvents cbMancing As CheckBox
    Friend WithEvents cbMelukis As CheckBox
    Friend WithEvents cbBerkebun As CheckBox
    Friend WithEvents cbBerenang As CheckBox
    Friend WithEvents cbMenontonFilm As CheckBox

End Class
