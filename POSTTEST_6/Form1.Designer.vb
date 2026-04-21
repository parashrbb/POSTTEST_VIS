<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        mnuData = New ToolStripMenuItem()
        mnuInputData = New ToolStripMenuItem()
        mnuKeluar = New ToolStripMenuItem()
        mnuLaporan = New ToolStripMenuItem()
        mnuDetailMember = New ToolStripMenuItem()
        mnuManajemen = New ToolStripMenuItem()
        mnuInstruktur = New ToolStripMenuItem()
        pnlHeader = New Panel()
        lblJudul = New Label()
        lblSubJudul = New Label()
        pnlForm = New Panel()
        lblIDMember = New Label()
        txtIDMember = New TextBox()
        lblNama = New Label()
        txtNama = New TextBox()
        lblPaket = New Label()
        cmbPaket = New ComboBox()
        lblNoHP = New Label()
        txtNoHP = New TextBox()
        lblTanggalDaftar = New Label()
        dtpTanggalDaftar = New DateTimePicker()
        lblStatus = New Label()
        cmbStatus = New ComboBox()
        lblCariData = New Label()
        txtSearch = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        btnDetail = New Button()
        dgvMember = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        MenuStrip1.SuspendLayout()
        pnlHeader.SuspendLayout()
        pnlForm.SuspendLayout()
        CType(dgvMember, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        MenuStrip1.ForeColor = Color.White
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuData, mnuLaporan, mnuManajemen})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(10, 5, 0, 5)
        MenuStrip1.Size = New Size(1125, 39)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuData
        ' 
        mnuData.DropDownItems.AddRange(New ToolStripItem() {mnuInputData, mnuKeluar})
        mnuData.ForeColor = Color.White
        mnuData.Name = "mnuData"
        mnuData.Size = New Size(65, 29)
        mnuData.Text = "Data"
        ' 
        ' mnuInputData
        ' 
        mnuInputData.Name = "mnuInputData"
        mnuInputData.Size = New Size(198, 34)
        mnuInputData.Text = "Input Data"
        ' 
        ' mnuKeluar
        ' 
        mnuKeluar.Name = "mnuKeluar"
        mnuKeluar.Size = New Size(198, 34)
        mnuKeluar.Text = "Keluar"
        ' 
        ' mnuLaporan
        ' 
        mnuLaporan.DropDownItems.AddRange(New ToolStripItem() {mnuDetailMember})
        mnuLaporan.ForeColor = Color.White
        mnuLaporan.Name = "mnuLaporan"
        mnuLaporan.Size = New Size(92, 29)
        mnuLaporan.Text = "Laporan"
        ' 
        ' mnuDetailMember
        ' 
        mnuDetailMember.Name = "mnuDetailMember"
        mnuDetailMember.Size = New Size(231, 34)
        mnuDetailMember.Text = "Detail Member"
        ' 
        ' mnuManajemen
        ' 
        mnuManajemen.DropDownItems.AddRange(New ToolStripItem() {mnuInstruktur})
        mnuManajemen.ForeColor = Color.White
        mnuManajemen.Name = "mnuManajemen"
        mnuManajemen.Size = New Size(120, 29)
        mnuManajemen.Text = "Manajemen"
        ' 
        ' mnuInstruktur
        ' 
        mnuInstruktur.Name = "mnuInstruktur"
        mnuInstruktur.Size = New Size(268, 34)
        mnuInstruktur.Text = "Data Instruktur / PT"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        pnlHeader.Controls.Add(lblJudul)
        pnlHeader.Controls.Add(lblSubJudul)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 39)
        pnlHeader.Margin = New Padding(4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1125, 100)
        pnlHeader.TabIndex = 1
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblJudul.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        lblJudul.Location = New Point(25, 14)
        lblJudul.Margin = New Padding(4, 0, 4, 0)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(313, 48)
        lblJudul.TabIndex = 0
        lblJudul.Text = "💪 IRONFIT GYM"
        ' 
        ' lblSubJudul
        ' 
        lblSubJudul.AutoSize = True
        lblSubJudul.Font = New Font("Segoe UI", 9.0F)
        lblSubJudul.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(180))
        lblSubJudul.Location = New Point(28, 60)
        lblSubJudul.Margin = New Padding(4, 0, 4, 0)
        lblSubJudul.Name = "lblSubJudul"
        lblSubJudul.Size = New Size(309, 25)
        lblSubJudul.TabIndex = 1
        lblSubJudul.Text = "Sistem Manajemen Membership Gym"
        ' 
        ' pnlForm
        ' 
        pnlForm.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        pnlForm.Controls.Add(lblIDMember)
        pnlForm.Controls.Add(txtIDMember)
        pnlForm.Controls.Add(lblNama)
        pnlForm.Controls.Add(txtNama)
        pnlForm.Controls.Add(lblPaket)
        pnlForm.Controls.Add(cmbPaket)
        pnlForm.Controls.Add(lblNoHP)
        pnlForm.Controls.Add(txtNoHP)
        pnlForm.Controls.Add(lblTanggalDaftar)
        pnlForm.Controls.Add(dtpTanggalDaftar)
        pnlForm.Controls.Add(lblStatus)
        pnlForm.Controls.Add(cmbStatus)
        pnlForm.Controls.Add(lblCariData)
        pnlForm.Controls.Add(txtSearch)
        pnlForm.Controls.Add(btnSimpan)
        pnlForm.Controls.Add(btnUbah)
        pnlForm.Controls.Add(btnHapus)
        pnlForm.Controls.Add(btnBatal)
        pnlForm.Controls.Add(btnDetail)
        pnlForm.Location = New Point(0, 140)
        pnlForm.Margin = New Padding(4)
        pnlForm.Name = "pnlForm"
        pnlForm.Padding = New Padding(19)
        pnlForm.Size = New Size(1125, 275)
        pnlForm.TabIndex = 2
        ' 
        ' lblIDMember
        ' 
        lblIDMember.AutoSize = True
        lblIDMember.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblIDMember.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        lblIDMember.Location = New Point(25, 25)
        lblIDMember.Name = "lblIDMember"
        lblIDMember.Size = New Size(107, 25)
        lblIDMember.TabIndex = 0
        lblIDMember.Text = "ID Member"
        ' 
        ' txtIDMember
        ' 
        txtIDMember.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(55))
        txtIDMember.BorderStyle = BorderStyle.FixedSingle
        txtIDMember.Font = New Font("Segoe UI", 9.0F)
        txtIDMember.ForeColor = Color.White
        txtIDMember.Location = New Point(25, 50)
        txtIDMember.Name = "txtIDMember"
        txtIDMember.PlaceholderText = "cth: MBR001"
        txtIDMember.Size = New Size(162, 31)
        txtIDMember.TabIndex = 1
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblNama.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        lblNama.Location = New Point(212, 25)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(62, 25)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama"
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(55))
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.Font = New Font("Segoe UI", 9.0F)
        txtNama.ForeColor = Color.White
        txtNama.Location = New Point(212, 50)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama Lengkap"
        txtNama.Size = New Size(212, 31)
        txtNama.TabIndex = 3
        ' 
        ' lblPaket
        ' 
        lblPaket.AutoSize = True
        lblPaket.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblPaket.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        lblPaket.Location = New Point(450, 25)
        lblPaket.Name = "lblPaket"
        lblPaket.Size = New Size(136, 25)
        lblPaket.TabIndex = 4
        lblPaket.Text = "Paket Member"
        ' 
        ' cmbPaket
        ' 
        cmbPaket.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(55))
        cmbPaket.DropDownStyle = ComboBoxStyle.DropDownList
        cmbPaket.FlatStyle = FlatStyle.Flat
        cmbPaket.Font = New Font("Segoe UI", 9.0F)
        cmbPaket.ForeColor = Color.White
        cmbPaket.Items.AddRange(New Object() {"Basic - 1 Bulan", "Silver - 3 Bulan", "Gold - 6 Bulan", "Platinum - 12 Bulan"})
        cmbPaket.Location = New Point(450, 50)
        cmbPaket.Name = "cmbPaket"
        cmbPaket.Size = New Size(212, 33)
        cmbPaket.TabIndex = 5
        ' 
        ' lblNoHP
        ' 
        lblNoHP.AutoSize = True
        lblNoHP.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblNoHP.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        lblNoHP.Location = New Point(688, 25)
        lblNoHP.Name = "lblNoHP"
        lblNoHP.Size = New Size(72, 25)
        lblNoHP.TabIndex = 6
        lblNoHP.Text = "No. HP"
        ' 
        ' txtNoHP
        ' 
        txtNoHP.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(55))
        txtNoHP.BorderStyle = BorderStyle.FixedSingle
        txtNoHP.Font = New Font("Segoe UI", 9.0F)
        txtNoHP.ForeColor = Color.White
        txtNoHP.Location = New Point(688, 50)
        txtNoHP.Name = "txtNoHP"
        txtNoHP.PlaceholderText = "08xxxxxxxxxx"
        txtNoHP.Size = New Size(187, 31)
        txtNoHP.TabIndex = 7
        ' 
        ' lblTanggalDaftar
        ' 
        lblTanggalDaftar.AutoSize = True
        lblTanggalDaftar.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblTanggalDaftar.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        lblTanggalDaftar.Location = New Point(25, 112)
        lblTanggalDaftar.Name = "lblTanggalDaftar"
        lblTanggalDaftar.Size = New Size(138, 25)
        lblTanggalDaftar.TabIndex = 8
        lblTanggalDaftar.Text = "Tanggal Daftar"
        ' 
        ' dtpTanggalDaftar
        ' 
        dtpTanggalDaftar.CalendarForeColor = Color.Black
        dtpTanggalDaftar.Format = DateTimePickerFormat.Short
        dtpTanggalDaftar.Location = New Point(25, 138)
        dtpTanggalDaftar.Name = "dtpTanggalDaftar"
        dtpTanggalDaftar.Size = New Size(162, 31)
        dtpTanggalDaftar.TabIndex = 9
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblStatus.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        lblStatus.Location = New Point(212, 112)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(65, 25)
        lblStatus.TabIndex = 10
        lblStatus.Text = "Status"
        ' 
        ' cmbStatus
        ' 
        cmbStatus.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(55))
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.FlatStyle = FlatStyle.Flat
        cmbStatus.Font = New Font("Segoe UI", 9.0F)
        cmbStatus.ForeColor = Color.White
        cmbStatus.Items.AddRange(New Object() {"Aktif", "Tidak Aktif", "Pending"})
        cmbStatus.Location = New Point(212, 138)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(212, 33)
        cmbStatus.TabIndex = 11
        ' 
        ' lblCariData
        ' 
        lblCariData.AutoSize = True
        lblCariData.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblCariData.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        lblCariData.Location = New Point(450, 112)
        lblCariData.Name = "lblCariData"
        lblCariData.Size = New Size(90, 25)
        lblCariData.TabIndex = 12
        lblCariData.Text = "Cari Data"
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(55))
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 9.0F)
        txtSearch.ForeColor = Color.White
        txtSearch.Location = New Point(450, 138)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Cari ID / Nama / Paket..."
        txtSearch.Size = New Size(274, 31)
        txtSearch.TabIndex = 13
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(0), CByte(160), CByte(80))
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(25, 215)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(100, 38)
        btnSimpan.TabIndex = 14
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        btnUbah.FlatAppearance.BorderSize = 0
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(137, 215)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(88, 38)
        btnUbah.TabIndex = 15
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(200), CByte(40), CByte(40))
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(237, 215)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(88, 38)
        btnHapus.TabIndex = 16
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(491, 215)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(44, 38)
        btnBatal.TabIndex = 17
        btnBatal.Text = "✕"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnDetail
        ' 
        btnDetail.BackColor = Color.FromArgb(CByte(180), CByte(120), CByte(0))
        btnDetail.FlatAppearance.BorderSize = 0
        btnDetail.FlatStyle = FlatStyle.Flat
        btnDetail.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnDetail.ForeColor = Color.White
        btnDetail.Location = New Point(333, 215)
        btnDetail.Name = "btnDetail"
        btnDetail.Size = New Size(150, 38)
        btnDetail.TabIndex = 18
        btnDetail.Text = "Lihat Detail"
        btnDetail.UseVisualStyleBackColor = False
        ' 
        ' dgvMember
        ' 
        dgvMember.AllowUserToAddRows = False
        dgvMember.AllowUserToDeleteRows = False
        dgvMember.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        dgvMember.BorderStyle = BorderStyle.None
        dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMember.GridColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        dgvMember.Location = New Point(0, 419)
        dgvMember.Name = "dgvMember"
        dgvMember.ReadOnly = True
        dgvMember.RowHeadersVisible = False
        dgvMember.RowHeadersWidth = 62
        dgvMember.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMember.Size = New Size(1125, 369)
        dgvMember.TabIndex = 3
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        ClientSize = New Size(1125, 788)
        Controls.Add(dgvMember)
        Controls.Add(pnlForm)
        Controls.Add(pnlHeader)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlForm.ResumeLayout(False)
        pnlForm.PerformLayout()
        CType(dgvMember, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuData As ToolStripMenuItem
    Friend WithEvents mnuInputData As ToolStripMenuItem
    Friend WithEvents mnuKeluar As ToolStripMenuItem
    Friend WithEvents mnuLaporan As ToolStripMenuItem
    Friend WithEvents mnuDetailMember As ToolStripMenuItem
    Friend WithEvents mnuManajemen As ToolStripMenuItem
    Friend WithEvents mnuInstruktur As ToolStripMenuItem
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblSubJudul As Label
    Friend WithEvents pnlForm As Panel
    Friend WithEvents lblIDMember As Label
    Friend WithEvents txtIDMember As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblPaket As Label
    Friend WithEvents cmbPaket As ComboBox
    Friend WithEvents lblNoHP As Label
    Friend WithEvents txtNoHP As TextBox
    Friend WithEvents lblTanggalDaftar As Label
    Friend WithEvents dtpTanggalDaftar As DateTimePicker
    Friend WithEvents lblStatus As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents lblCariData As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnDetail As Button
    Friend WithEvents dgvMember As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class