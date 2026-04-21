<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        pnlHeader = New Panel()
        lblJudul = New Label()
        lblSubJudul = New Label()
        pnlForm = New Panel()
        lblIDInstruktur = New Label()
        txtIDInstruktur = New TextBox()
        lblMember = New Label()
        cmbMember = New ComboBox()
        lblNamaInstruktur = New Label()
        txtNamaInstruktur = New TextBox()
        lblSpesialisasi = New Label()
        cmbSpesialisasi = New ComboBox()
        lblSearch = New Label()
        txtSearch = New TextBox()
        lblNoHP = New Label()
        txtNoHPInstruktur = New TextBox()
        lblJadwal = New Label()
        cmbJadwal = New ComboBox()
        lblCatatan = New Label()
        txtCatatan = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvInstruktur = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        pnlHeader.SuspendLayout()
        pnlForm.SuspendLayout()
        CType(dgvInstruktur, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        pnlHeader.Controls.Add(lblJudul)
        pnlHeader.Controls.Add(lblSubJudul)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1125, 100)
        pnlHeader.TabIndex = 0
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblJudul.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        lblJudul.Location = New Point(25, 15)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(313, 48)
        lblJudul.TabIndex = 0
        lblJudul.Text = "🏋 IRONFIT GYM"
        ' 
        ' lblSubJudul
        ' 
        lblSubJudul.AutoSize = True
        lblSubJudul.Font = New Font("Segoe UI", 9F)
        lblSubJudul.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(180))
        lblSubJudul.Location = New Point(28, 62)
        lblSubJudul.Name = "lblSubJudul"
        lblSubJudul.Size = New Size(366, 25)
        lblSubJudul.TabIndex = 1
        lblSubJudul.Text = "Manajemen Data Instruktur / Personal Trainer"
        ' 
        ' pnlForm
        ' 
        pnlForm.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        pnlForm.Controls.Add(lblIDInstruktur)
        pnlForm.Controls.Add(txtIDInstruktur)
        pnlForm.Controls.Add(lblMember)
        pnlForm.Controls.Add(cmbMember)
        pnlForm.Controls.Add(lblNamaInstruktur)
        pnlForm.Controls.Add(txtNamaInstruktur)
        pnlForm.Controls.Add(lblSpesialisasi)
        pnlForm.Controls.Add(cmbSpesialisasi)
        pnlForm.Controls.Add(lblSearch)
        pnlForm.Controls.Add(txtSearch)
        pnlForm.Controls.Add(lblNoHP)
        pnlForm.Controls.Add(txtNoHPInstruktur)
        pnlForm.Controls.Add(lblJadwal)
        pnlForm.Controls.Add(cmbJadwal)
        pnlForm.Controls.Add(lblCatatan)
        pnlForm.Controls.Add(txtCatatan)
        pnlForm.Controls.Add(btnSimpan)
        pnlForm.Controls.Add(btnUbah)
        pnlForm.Controls.Add(btnHapus)
        pnlForm.Controls.Add(btnBatal)
        pnlForm.Location = New Point(0, 100)
        pnlForm.Name = "pnlForm"
        pnlForm.Padding = New Padding(20, 18, 20, 18)
        pnlForm.Size = New Size(1125, 300)
        pnlForm.TabIndex = 1
        ' 
        ' lblIDInstruktur
        ' 
        lblIDInstruktur.AutoSize = True
        lblIDInstruktur.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblIDInstruktur.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        lblIDInstruktur.Location = New Point(28, 21)
        lblIDInstruktur.Name = "lblIDInstruktur"
        lblIDInstruktur.Size = New Size(121, 25)
        lblIDInstruktur.TabIndex = 0
        lblIDInstruktur.Text = "ID Instruktur"
        ' 
        ' txtIDInstruktur
        ' 
        txtIDInstruktur.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(55))
        txtIDInstruktur.BorderStyle = BorderStyle.FixedSingle
        txtIDInstruktur.Font = New Font("Segoe UI", 9F)
        txtIDInstruktur.ForeColor = Color.White
        txtIDInstruktur.Location = New Point(25, 46)
        txtIDInstruktur.Name = "txtIDInstruktur"
        txtIDInstruktur.PlaceholderText = "cth: INS001"
        txtIDInstruktur.Size = New Size(200, 31)
        txtIDInstruktur.TabIndex = 0
        ' 
        ' lblMember
        ' 
        lblMember.AutoSize = True
        lblMember.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblMember.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        lblMember.Location = New Point(253, 21)
        lblMember.Name = "lblMember"
        lblMember.Size = New Size(218, 25)
        lblMember.TabIndex = 1
        lblMember.Text = "Member yang Ditangani"
        ' 
        ' cmbMember
        ' 
        cmbMember.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(55))
        cmbMember.DropDownStyle = ComboBoxStyle.DropDownList
        cmbMember.FlatStyle = FlatStyle.Flat
        cmbMember.Font = New Font("Segoe UI", 9F)
        cmbMember.ForeColor = Color.White
        cmbMember.Location = New Point(250, 46)
        cmbMember.Name = "cmbMember"
        cmbMember.Size = New Size(260, 33)
        cmbMember.TabIndex = 1
        ' 
        ' lblNamaInstruktur
        ' 
        lblNamaInstruktur.AutoSize = True
        lblNamaInstruktur.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblNamaInstruktur.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        lblNamaInstruktur.Location = New Point(530, 21)
        lblNamaInstruktur.Name = "lblNamaInstruktur"
        lblNamaInstruktur.Size = New Size(152, 25)
        lblNamaInstruktur.TabIndex = 2
        lblNamaInstruktur.Text = "Nama Instruktur"
        ' 
        ' txtNamaInstruktur
        ' 
        txtNamaInstruktur.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(55))
        txtNamaInstruktur.BorderStyle = BorderStyle.FixedSingle
        txtNamaInstruktur.Font = New Font("Segoe UI", 9F)
        txtNamaInstruktur.ForeColor = Color.White
        txtNamaInstruktur.Location = New Point(529, 46)
        txtNamaInstruktur.Name = "txtNamaInstruktur"
        txtNamaInstruktur.PlaceholderText = "Nama lengkap PT"
        txtNamaInstruktur.Size = New Size(273, 31)
        txtNamaInstruktur.TabIndex = 2
        ' 
        ' lblSpesialisasi
        ' 
        lblSpesialisasi.AutoSize = True
        lblSpesialisasi.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblSpesialisasi.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        lblSpesialisasi.Location = New Point(828, 21)
        lblSpesialisasi.Name = "lblSpesialisasi"
        lblSpesialisasi.Size = New Size(107, 25)
        lblSpesialisasi.TabIndex = 3
        lblSpesialisasi.Text = "Spesialisasi"
        ' 
        ' cmbSpesialisasi
        ' 
        cmbSpesialisasi.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(55))
        cmbSpesialisasi.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSpesialisasi.FlatStyle = FlatStyle.Flat
        cmbSpesialisasi.Font = New Font("Segoe UI", 9F)
        cmbSpesialisasi.ForeColor = Color.White
        cmbSpesialisasi.Items.AddRange(New Object() {"Strength Training", "Cardio & Endurance", "Body Building", "Weight Loss", "Yoga & Flexibility", "CrossFit", "Zumba & Aerobik"})
        cmbSpesialisasi.Location = New Point(828, 46)
        cmbSpesialisasi.Name = "cmbSpesialisasi"
        cmbSpesialisasi.Size = New Size(277, 33)
        cmbSpesialisasi.TabIndex = 3
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblSearch.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        lblSearch.Location = New Point(529, 109)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(90, 25)
        lblSearch.TabIndex = 4
        lblSearch.Text = "Cari Data"
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(55))
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 9F)
        txtSearch.ForeColor = Color.White
        txtSearch.Location = New Point(529, 134)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Cari nama / jadwal..."
        txtSearch.Size = New Size(186, 31)
        txtSearch.TabIndex = 4
        ' 
        ' lblNoHP
        ' 
        lblNoHP.AutoSize = True
        lblNoHP.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblNoHP.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        lblNoHP.Location = New Point(25, 109)
        lblNoHP.Name = "lblNoHP"
        lblNoHP.Size = New Size(162, 25)
        lblNoHP.TabIndex = 5
        lblNoHP.Text = "No. HP Instruktur"
        ' 
        ' txtNoHPInstruktur
        ' 
        txtNoHPInstruktur.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(55))
        txtNoHPInstruktur.BorderStyle = BorderStyle.FixedSingle
        txtNoHPInstruktur.Font = New Font("Segoe UI", 9F)
        txtNoHPInstruktur.ForeColor = Color.White
        txtNoHPInstruktur.Location = New Point(25, 134)
        txtNoHPInstruktur.Name = "txtNoHPInstruktur"
        txtNoHPInstruktur.PlaceholderText = "08xxxxxxxxxx"
        txtNoHPInstruktur.Size = New Size(200, 31)
        txtNoHPInstruktur.TabIndex = 5
        ' 
        ' lblJadwal
        ' 
        lblJadwal.AutoSize = True
        lblJadwal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblJadwal.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        lblJadwal.Location = New Point(253, 109)
        lblJadwal.Name = "lblJadwal"
        lblJadwal.Size = New Size(138, 25)
        lblJadwal.TabIndex = 6
        lblJadwal.Text = "Jadwal Latihan"
        ' 
        ' cmbJadwal
        ' 
        cmbJadwal.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(55))
        cmbJadwal.DropDownStyle = ComboBoxStyle.DropDownList
        cmbJadwal.FlatStyle = FlatStyle.Flat
        cmbJadwal.Font = New Font("Segoe UI", 9F)
        cmbJadwal.ForeColor = Color.White
        cmbJadwal.Items.AddRange(New Object() {"Senin & Rabu", "Selasa & Kamis", "Rabu & Jumat", "Senin, Rabu & Jumat", "Selasa, Kamis & Sabtu", "Setiap Hari (Weekday)", "Weekend (Sabtu & Minggu)"})
        cmbJadwal.Location = New Point(250, 134)
        cmbJadwal.Name = "cmbJadwal"
        cmbJadwal.Size = New Size(260, 33)
        cmbJadwal.TabIndex = 6
        ' 
        ' lblCatatan
        ' 
        lblCatatan.AutoSize = True
        lblCatatan.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCatatan.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        lblCatatan.Location = New Point(735, 109)
        lblCatatan.Name = "lblCatatan"
        lblCatatan.Size = New Size(172, 25)
        lblCatatan.TabIndex = 7
        lblCatatan.Text = "Catatan (Opsional)"
        ' 
        ' txtCatatan
        ' 
        txtCatatan.BackColor = Color.FromArgb(CByte(55), CByte(55), CByte(55))
        txtCatatan.BorderStyle = BorderStyle.FixedSingle
        txtCatatan.Font = New Font("Segoe UI", 9F)
        txtCatatan.ForeColor = Color.White
        txtCatatan.Location = New Point(735, 134)
        txtCatatan.Name = "txtCatatan"
        txtCatatan.PlaceholderText = "Catatan tambahan..."
        txtCatatan.Size = New Size(370, 31)
        txtCatatan.TabIndex = 7
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(0), CByte(160), CByte(80))
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(25, 215)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(110, 38)
        btnSimpan.TabIndex = 8
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        btnUbah.FlatAppearance.BorderSize = 0
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(150, 215)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(100, 38)
        btnUbah.TabIndex = 9
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(200), CByte(40), CByte(40))
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(265, 215)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(100, 38)
        btnHapus.TabIndex = 10
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(380, 215)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(80, 38)
        btnBatal.TabIndex = 11
        btnBatal.Text = "✕ Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' dgvInstruktur
        ' 
        dgvInstruktur.AllowUserToAddRows = False
        dgvInstruktur.AllowUserToDeleteRows = False
        dgvInstruktur.BackgroundColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        dgvInstruktur.BorderStyle = BorderStyle.None
        dgvInstruktur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInstruktur.GridColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        dgvInstruktur.Location = New Point(0, 405)
        dgvInstruktur.Name = "dgvInstruktur"
        dgvInstruktur.ReadOnly = True
        dgvInstruktur.RowHeadersVisible = False
        dgvInstruktur.RowHeadersWidth = 62
        dgvInstruktur.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvInstruktur.Size = New Size(1125, 370)
        dgvInstruktur.TabIndex = 2
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        ClientSize = New Size(1125, 790)
        Controls.Add(dgvInstruktur)
        Controls.Add(pnlForm)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlForm.ResumeLayout(False)
        pnlForm.PerformLayout()
        CType(dgvInstruktur, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    ' ---- Declarations ----
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblSubJudul As Label
    Friend WithEvents pnlForm As Panel
    Friend WithEvents lblIDInstruktur As Label
    Friend WithEvents txtIDInstruktur As TextBox
    Friend WithEvents lblMember As Label
    Friend WithEvents cmbMember As ComboBox
    Friend WithEvents lblNamaInstruktur As Label
    Friend WithEvents txtNamaInstruktur As TextBox
    Friend WithEvents lblSpesialisasi As Label
    Friend WithEvents cmbSpesialisasi As ComboBox
    Friend WithEvents lblNoHP As Label
    Friend WithEvents txtNoHPInstruktur As TextBox
    Friend WithEvents lblJadwal As Label
    Friend WithEvents cmbJadwal As ComboBox
    Friend WithEvents lblCatatan As Label
    Friend WithEvents txtCatatan As TextBox
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvInstruktur As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class