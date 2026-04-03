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
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label12 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        cbDivisi = New ComboBox()
        RadioButton1 = New RadioButton()
        rbLaki = New RadioButton()
        dtpTglLahir = New DateTimePicker()
        txtID = New TextBox()
        txtNama = New TextBox()
        TabPage2 = New TabPage()
        Label13 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        mtxtNoHP = New MaskedTextBox()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        TabPage3 = New TabPage()
        Label14 = New Label()
        Label10 = New Label()
        btnSimpan = New Button()
        cbLearning = New CheckBox()
        cbProjectCollab = New CheckBox()
        cbHackton = New CheckBox()
        cbDatabaseMan = New CheckBox()
        cbBackendDev = New CheckBox()
        cbUIDesign = New CheckBox()
        cbDebugging = New CheckBox()
        cbCoding = New CheckBox()
        GroupBox1 = New GroupBox()
        rbProjectMan = New RadioButton()
        rbUIUX = New RadioButton()
        rbSeniorDev = New RadioButton()
        rbJuniorDev = New RadioButton()
        rbTeamLeader = New RadioButton()
        btnSearch = New Button()
        PictureBox1 = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        PictureBox2 = New PictureBox()
        Label11 = New Label()
        btnCetak = New Button()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Transparent
        MenuStrip1.Font = New Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(831, 30)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Font = New Font("Pixelify Sans", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        InputDataToolStripMenuItem.ForeColor = Color.White
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(125, 26)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Font = New Font("Pixelify Sans", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LihatKartuToolStripMenuItem.ForeColor = Color.White
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(134, 26)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Font = New Font("Pixelify Sans", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SimpanDataToolStripMenuItem.ForeColor = Color.White
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(136, 26)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Font = New Font("Pixelify Sans", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BukaDataToolStripMenuItem.ForeColor = Color.White
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(118, 26)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Font = New Font("Pixelify Sans", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KeluarToolStripMenuItem.ForeColor = Color.White
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(85, 26)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Pixeboy", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.AliceBlue
        Label1.Location = New Point(224, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(418, 25)
        Label1.TabIndex = 1
        Label1.Text = "Komunitas Programmer"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Font = New Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(43, 144)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(747, 389)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.AliceBlue
        TabPage1.Controls.Add(Label12)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(cbDivisi)
        TabPage1.Controls.Add(RadioButton1)
        TabPage1.Controls.Add(rbLaki)
        TabPage1.Controls.Add(dtpTglLahir)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Location = New Point(4, 37)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(739, 348)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Pixeboy", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.SlateGray
        Label12.Location = New Point(40, 25)
        Label12.Name = "Label12"
        Label12.Size = New Size(208, 25)
        Label12.TabIndex = 5
        Label12.Text = "DATA UTAMA"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Poppins", 8F)
        Label6.Location = New Point(384, 157)
        Label6.Name = "Label6"
        Label6.Size = New Size(121, 28)
        Label6.TabIndex = 10
        Label6.Text = "Jenis Kelamin"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Poppins", 8F)
        Label5.Location = New Point(40, 224)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 28)
        Label5.TabIndex = 9
        Label5.Text = "Divisi"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Poppins", 8F)
        Label4.Location = New Point(40, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(121, 28)
        Label4.TabIndex = 8
        Label4.Text = "Tanggal Lahir"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Poppins", 8F)
        Label3.Location = New Point(384, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 28)
        Label3.TabIndex = 7
        Label3.Text = "ID Anggota"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Poppins", 8F)
        Label2.Location = New Point(40, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 28)
        Label2.TabIndex = 6
        Label2.Text = "Nama"
        ' 
        ' cbDivisi
        ' 
        cbDivisi.Font = New Font("Poppins", 8F)
        cbDivisi.FormattingEnabled = True
        cbDivisi.Items.AddRange(New Object() {"WEB Developer", "Mobile Developer", "Backend Developer", "Frontend Developer", "UI/UX Designer", "Database Scientist", "Game Developer"})
        cbDivisi.Location = New Point(160, 221)
        cbDivisi.Name = "cbDivisi"
        cbDivisi.Size = New Size(209, 36)
        cbDivisi.TabIndex = 5
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Poppins", 8F)
        RadioButton1.Location = New Point(511, 193)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(130, 32)
        RadioButton1.TabIndex = 4
        RadioButton1.TabStop = True
        RadioButton1.Text = "Perempuan"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Font = New Font("Poppins", 8F)
        rbLaki.Location = New Point(511, 155)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(106, 32)
        rbLaki.TabIndex = 3
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' dtpTglLahir
        ' 
        dtpTglLahir.Font = New Font("Poppins", 8F)
        dtpTglLahir.Format = DateTimePickerFormat.Custom
        dtpTglLahir.Location = New Point(161, 154)
        dtpTglLahir.Name = "dtpTglLahir"
        dtpTglLahir.Size = New Size(208, 31)
        dtpTglLahir.TabIndex = 2
        ' 
        ' txtID
        ' 
        txtID.Font = New Font("Poppins", 8F)
        txtID.Location = New Point(511, 86)
        txtID.Name = "txtID"
        txtID.Size = New Size(209, 31)
        txtID.TabIndex = 1
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Poppins", 8F)
        txtNama.Location = New Point(161, 86)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(208, 31)
        txtNama.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.AliceBlue
        TabPage2.Controls.Add(Label13)
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(mtxtNoHP)
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Location = New Point(4, 37)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(739, 348)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak dan Info"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Pixeboy", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.SlateGray
        Label13.Location = New Point(40, 25)
        Label13.Name = "Label13"
        Label13.Size = New Size(299, 25)
        Label13.TabIndex = 7
        Label13.Text = "KONTAK DAN INFO"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Poppins", 8F)
        Label9.Location = New Point(46, 173)
        Label9.Name = "Label9"
        Label9.Size = New Size(71, 28)
        Label9.TabIndex = 6
        Label9.Text = "Alamat"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Poppins", 8F)
        Label8.Location = New Point(392, 105)
        Label8.Name = "Label8"
        Label8.Size = New Size(55, 28)
        Label8.TabIndex = 5
        Label8.Text = "Email"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Poppins", 8F)
        Label7.Location = New Point(46, 105)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 28)
        Label7.TabIndex = 4
        Label7.Text = "No HP"
        ' 
        ' mtxtNoHP
        ' 
        mtxtNoHP.Font = New Font("Poppins", 8F)
        mtxtNoHP.Location = New Point(159, 102)
        mtxtNoHP.Mask = "0000-0000-0000"
        mtxtNoHP.Name = "mtxtNoHP"
        mtxtNoHP.Size = New Size(186, 31)
        mtxtNoHP.TabIndex = 3
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Font = New Font("Poppins", 8F)
        txtAlamat.Location = New Point(159, 170)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(535, 31)
        txtAlamat.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Poppins", 8F)
        txtEmail.Location = New Point(508, 102)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(186, 31)
        txtEmail.TabIndex = 1
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.AliceBlue
        TabPage3.Controls.Add(btnCetak)
        TabPage3.Controls.Add(Label14)
        TabPage3.Controls.Add(Label10)
        TabPage3.Controls.Add(btnSimpan)
        TabPage3.Controls.Add(cbLearning)
        TabPage3.Controls.Add(cbProjectCollab)
        TabPage3.Controls.Add(cbHackton)
        TabPage3.Controls.Add(cbDatabaseMan)
        TabPage3.Controls.Add(cbBackendDev)
        TabPage3.Controls.Add(cbUIDesign)
        TabPage3.Controls.Add(cbDebugging)
        TabPage3.Controls.Add(cbCoding)
        TabPage3.Controls.Add(GroupBox1)
        TabPage3.Controls.Add(btnSearch)
        TabPage3.Controls.Add(PictureBox1)
        TabPage3.Location = New Point(4, 37)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(739, 348)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil dan Aktivtas"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Pixeboy", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.SlateGray
        Label14.Location = New Point(20, 15)
        Label14.Name = "Label14"
        Label14.Size = New Size(404, 25)
        Label14.TabIndex = 13
        Label14.Text = "Profil dan aktivitas"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Poppins", 8F)
        Label10.Location = New Point(417, 63)
        Label10.Name = "Label10"
        Label10.Size = New Size(81, 28)
        Label10.TabIndex = 12
        Label10.Text = "ACTIVITY"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.MidnightBlue
        btnSimpan.Font = New Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(200, 270)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(249, 34)
        btnSimpan.TabIndex = 11
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' cbLearning
        ' 
        cbLearning.AutoSize = True
        cbLearning.Font = New Font("Poppins", 8F)
        cbLearning.Location = New Point(568, 225)
        cbLearning.Name = "cbLearning"
        cbLearning.Size = New Size(107, 32)
        cbLearning.TabIndex = 10
        cbLearning.Text = "Learning"
        cbLearning.UseVisualStyleBackColor = True
        ' 
        ' cbProjectCollab
        ' 
        cbProjectCollab.AutoSize = True
        cbProjectCollab.Font = New Font("Poppins", 8F)
        cbProjectCollab.Location = New Point(568, 183)
        cbProjectCollab.Name = "cbProjectCollab"
        cbProjectCollab.Size = New Size(149, 32)
        cbProjectCollab.TabIndex = 9
        cbProjectCollab.Text = "Project Collab"
        cbProjectCollab.UseVisualStyleBackColor = True
        ' 
        ' cbHackton
        ' 
        cbHackton.AutoSize = True
        cbHackton.Font = New Font("Poppins", 8F)
        cbHackton.Location = New Point(568, 141)
        cbHackton.Name = "cbHackton"
        cbHackton.Size = New Size(115, 32)
        cbHackton.TabIndex = 8
        cbHackton.Text = "Hackaton"
        cbHackton.UseVisualStyleBackColor = True
        ' 
        ' cbDatabaseMan
        ' 
        cbDatabaseMan.AutoSize = True
        cbDatabaseMan.Font = New Font("Poppins", 8F)
        cbDatabaseMan.Location = New Point(568, 101)
        cbDatabaseMan.Name = "cbDatabaseMan"
        cbDatabaseMan.Size = New Size(156, 32)
        cbDatabaseMan.TabIndex = 7
        cbDatabaseMan.Text = "Database Man"
        cbDatabaseMan.UseVisualStyleBackColor = True
        ' 
        ' cbBackendDev
        ' 
        cbBackendDev.AutoSize = True
        cbBackendDev.Font = New Font("Poppins", 8F)
        cbBackendDev.Location = New Point(417, 225)
        cbBackendDev.Name = "cbBackendDev"
        cbBackendDev.Size = New Size(142, 32)
        cbBackendDev.TabIndex = 6
        cbBackendDev.Text = "Backend Dev"
        cbBackendDev.UseVisualStyleBackColor = True
        ' 
        ' cbUIDesign
        ' 
        cbUIDesign.AutoSize = True
        cbUIDesign.Font = New Font("Poppins", 8F)
        cbUIDesign.Location = New Point(417, 183)
        cbUIDesign.Name = "cbUIDesign"
        cbUIDesign.Size = New Size(111, 32)
        cbUIDesign.TabIndex = 5
        cbUIDesign.Text = "UI design"
        cbUIDesign.UseVisualStyleBackColor = True
        ' 
        ' cbDebugging
        ' 
        cbDebugging.AutoSize = True
        cbDebugging.Font = New Font("Poppins", 8F)
        cbDebugging.Location = New Point(417, 141)
        cbDebugging.Name = "cbDebugging"
        cbDebugging.Size = New Size(127, 32)
        cbDebugging.TabIndex = 4
        cbDebugging.Text = "Debugging"
        cbDebugging.UseVisualStyleBackColor = True
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Font = New Font("Poppins", 8F)
        cbCoding.Location = New Point(417, 101)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(96, 32)
        cbCoding.TabIndex = 3
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbProjectMan)
        GroupBox1.Controls.Add(rbUIUX)
        GroupBox1.Controls.Add(rbSeniorDev)
        GroupBox1.Controls.Add(rbJuniorDev)
        GroupBox1.Controls.Add(rbTeamLeader)
        GroupBox1.Font = New Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(200, 52)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(197, 212)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "POSITION"
        ' 
        ' rbProjectMan
        ' 
        rbProjectMan.AutoSize = True
        rbProjectMan.Location = New Point(17, 171)
        rbProjectMan.Name = "rbProjectMan"
        rbProjectMan.Size = New Size(169, 32)
        rbProjectMan.TabIndex = 4
        rbProjectMan.TabStop = True
        rbProjectMan.Text = "Project Manager"
        rbProjectMan.UseVisualStyleBackColor = True
        ' 
        ' rbUIUX
        ' 
        rbUIUX.AutoSize = True
        rbUIUX.Location = New Point(16, 136)
        rbUIUX.Name = "rbUIUX"
        rbUIUX.Size = New Size(155, 32)
        rbUIUX.TabIndex = 3
        rbUIUX.TabStop = True
        rbUIUX.Text = "UI/UX designer"
        rbUIUX.UseVisualStyleBackColor = True
        ' 
        ' rbSeniorDev
        ' 
        rbSeniorDev.AutoSize = True
        rbSeniorDev.Location = New Point(16, 101)
        rbSeniorDev.Name = "rbSeniorDev"
        rbSeniorDev.Size = New Size(120, 32)
        rbSeniorDev.TabIndex = 2
        rbSeniorDev.TabStop = True
        rbSeniorDev.Text = "Senior Dev"
        rbSeniorDev.UseVisualStyleBackColor = True
        ' 
        ' rbJuniorDev
        ' 
        rbJuniorDev.AutoSize = True
        rbJuniorDev.Location = New Point(16, 66)
        rbJuniorDev.Name = "rbJuniorDev"
        rbJuniorDev.Size = New Size(119, 32)
        rbJuniorDev.TabIndex = 1
        rbJuniorDev.TabStop = True
        rbJuniorDev.Text = "Junior Dev"
        rbJuniorDev.UseVisualStyleBackColor = True
        ' 
        ' rbTeamLeader
        ' 
        rbTeamLeader.AutoSize = True
        rbTeamLeader.Location = New Point(16, 31)
        rbTeamLeader.Name = "rbTeamLeader"
        rbTeamLeader.Size = New Size(142, 32)
        rbTeamLeader.TabIndex = 0
        rbTeamLeader.TabStop = True
        rbTeamLeader.Text = "Team Leader"
        rbTeamLeader.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.White
        btnSearch.Font = New Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = SystemColors.ActiveCaptionText
        btnSearch.Location = New Point(20, 271)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(168, 32)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Location = New Point(20, 57)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(168, 207)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(705, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(81, 95)
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Pixeboy", 22F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.AliceBlue
        Label11.Location = New Point(331, 92)
        Label11.Name = "Label11"
        Label11.Size = New Size(201, 25)
        Label11.TabIndex = 4
        Label11.Text = "Indonesia"
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.MidnightBlue
        btnCetak.Font = New Font("Poppins", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCetak.ForeColor = Color.White
        btnCetak.Location = New Point(455, 271)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(269, 34)
        btnCetak.TabIndex = 14
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(831, 559)
        Controls.Add(Label11)
        Controls.Add(PictureBox2)
        Controls.Add(TabControl1)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        DoubleBuffered = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtNama As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents cbDivisi As ComboBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents dtpTglLahir As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents mtxtNoHP As MaskedTextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents rbProjectMan As RadioButton
    Friend WithEvents rbUIUX As RadioButton
    Friend WithEvents rbSeniorDev As RadioButton
    Friend WithEvents rbJuniorDev As RadioButton
    Friend WithEvents rbTeamLeader As RadioButton
    Friend WithEvents cbBackendDev As CheckBox
    Friend WithEvents cbUIDesign As CheckBox
    Friend WithEvents cbDebugging As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbLearning As CheckBox
    Friend WithEvents cbProjectCollab As CheckBox
    Friend WithEvents cbHackton As CheckBox
    Friend WithEvents cbDatabaseMan As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnCetak As Button

End Class
