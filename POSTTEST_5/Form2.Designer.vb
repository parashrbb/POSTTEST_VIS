<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        pnlHeader = New Panel()
        lblHeaderJudul = New Label()
        lblHeaderSub = New Label()
        pnlCard = New Panel()
        PictureBox1 = New PictureBox()
        lblKartuJudul = New Label()
        lblLabelID = New Label()
        lblIDMember = New Label()
        lblLabelNama = New Label()
        lblNama = New Label()
        lblLabelPaket = New Label()
        lblPaket = New Label()
        lblLabelHP = New Label()
        lblHP = New Label()
        lblLabelTanggal = New Label()
        lblTanggal = New Label()
        lblLabelStatus = New Label()
        lblStatus = New Label()
        btnTutup = New Button()
        pnlHeader.SuspendLayout()
        pnlCard.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(20), CByte(20), CByte(20))
        pnlHeader.Controls.Add(lblHeaderJudul)
        pnlHeader.Controls.Add(lblHeaderSub)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(4, 4, 4, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(875, 88)
        pnlHeader.TabIndex = 0
        ' 
        ' lblHeaderJudul
        ' 
        lblHeaderJudul.AutoSize = True
        lblHeaderJudul.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblHeaderJudul.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        lblHeaderJudul.Location = New Point(25, 12)
        lblHeaderJudul.Margin = New Padding(4, 0, 4, 0)
        lblHeaderJudul.Name = "lblHeaderJudul"
        lblHeaderJudul.Size = New Size(246, 38)
        lblHeaderJudul.TabIndex = 0
        lblHeaderJudul.Text = "💪 IRONFIT GYM"
        ' 
        ' lblHeaderSub
        ' 
        lblHeaderSub.AutoSize = True
        lblHeaderSub.Font = New Font("Segoe UI", 8F)
        lblHeaderSub.ForeColor = Color.FromArgb(CByte(160), CByte(160), CByte(160))
        lblHeaderSub.Location = New Point(28, 50)
        lblHeaderSub.Margin = New Padding(4, 0, 4, 0)
        lblHeaderSub.Name = "lblHeaderSub"
        lblHeaderSub.Size = New Size(154, 21)
        lblHeaderSub.TabIndex = 1
        lblHeaderSub.Text = "Kartu Detail Member"
        ' 
        ' pnlCard
        ' 
        pnlCard.BackColor = Color.FromArgb(CByte(45), CByte(45), CByte(45))
        pnlCard.BorderStyle = BorderStyle.FixedSingle
        pnlCard.Controls.Add(PictureBox1)
        pnlCard.Controls.Add(lblKartuJudul)
        pnlCard.Controls.Add(lblLabelID)
        pnlCard.Controls.Add(lblIDMember)
        pnlCard.Controls.Add(lblLabelNama)
        pnlCard.Controls.Add(lblNama)
        pnlCard.Controls.Add(lblLabelPaket)
        pnlCard.Controls.Add(lblPaket)
        pnlCard.Controls.Add(lblLabelHP)
        pnlCard.Controls.Add(lblHP)
        pnlCard.Controls.Add(lblLabelTanggal)
        pnlCard.Controls.Add(lblTanggal)
        pnlCard.Controls.Add(lblLabelStatus)
        pnlCard.Controls.Add(lblStatus)
        pnlCard.Location = New Point(38, 112)
        pnlCard.Margin = New Padding(4, 4, 4, 4)
        pnlCard.Name = "pnlCard"
        pnlCard.Size = New Size(800, 400)
        pnlCard.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(31, 75)
        PictureBox1.Margin = New Padding(4, 4, 4, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 250)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' lblKartuJudul
        ' 
        lblKartuJudul.AutoSize = True
        lblKartuJudul.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblKartuJudul.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        lblKartuJudul.Location = New Point(31, 25)
        lblKartuJudul.Margin = New Padding(4, 0, 4, 0)
        lblKartuJudul.Name = "lblKartuJudul"
        lblKartuJudul.Size = New Size(172, 30)
        lblKartuJudul.TabIndex = 1
        lblKartuJudul.Text = "MEMBER CARD"
        ' 
        ' lblLabelID
        ' 
        lblLabelID.AutoSize = True
        lblLabelID.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblLabelID.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(180))
        lblLabelID.Location = New Point(262, 75)
        lblLabelID.Margin = New Padding(4, 0, 4, 0)
        lblLabelID.Name = "lblLabelID"
        lblLabelID.Size = New Size(99, 21)
        lblLabelID.TabIndex = 2
        lblLabelID.Text = "ID MEMBER"
        ' 
        ' lblIDMember
        ' 
        lblIDMember.AutoSize = True
        lblIDMember.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblIDMember.ForeColor = Color.White
        lblIDMember.Location = New Point(262, 98)
        lblIDMember.Margin = New Padding(4, 0, 4, 0)
        lblIDMember.Name = "lblIDMember"
        lblIDMember.Size = New Size(24, 32)
        lblIDMember.TabIndex = 3
        lblIDMember.Text = "-"
        ' 
        ' lblLabelNama
        ' 
        lblLabelNama.AutoSize = True
        lblLabelNama.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblLabelNama.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(180))
        lblLabelNama.Location = New Point(262, 150)
        lblLabelNama.Margin = New Padding(4, 0, 4, 0)
        lblLabelNama.Name = "lblLabelNama"
        lblLabelNama.Size = New Size(60, 21)
        lblLabelNama.TabIndex = 4
        lblLabelNama.Text = "NAMA"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblNama.ForeColor = Color.White
        lblNama.Location = New Point(262, 172)
        lblNama.Margin = New Padding(4, 0, 4, 0)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(22, 30)
        lblNama.TabIndex = 5
        lblNama.Text = "-"
        ' 
        ' lblLabelPaket
        ' 
        lblLabelPaket.AutoSize = True
        lblLabelPaket.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblLabelPaket.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(180))
        lblLabelPaket.Location = New Point(262, 219)
        lblLabelPaket.Margin = New Padding(4, 0, 4, 0)
        lblLabelPaket.Name = "lblLabelPaket"
        lblLabelPaket.Size = New Size(130, 21)
        lblLabelPaket.TabIndex = 6
        lblLabelPaket.Text = "PAKET MEMBER"
        ' 
        ' lblPaket
        ' 
        lblPaket.AutoSize = True
        lblPaket.Font = New Font("Segoe UI", 10F)
        lblPaket.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(0))
        lblPaket.Location = New Point(262, 241)
        lblPaket.Margin = New Padding(4, 0, 4, 0)
        lblPaket.Name = "lblPaket"
        lblPaket.Size = New Size(20, 28)
        lblPaket.TabIndex = 7
        lblPaket.Text = "-"
        ' 
        ' lblLabelHP
        ' 
        lblLabelHP.AutoSize = True
        lblLabelHP.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblLabelHP.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(180))
        lblLabelHP.Location = New Point(262, 281)
        lblLabelHP.Margin = New Padding(4, 0, 4, 0)
        lblLabelHP.Name = "lblLabelHP"
        lblLabelHP.Size = New Size(64, 21)
        lblLabelHP.TabIndex = 8
        lblLabelHP.Text = "NO. HP"
        ' 
        ' lblHP
        ' 
        lblHP.AutoSize = True
        lblHP.Font = New Font("Segoe UI", 10F)
        lblHP.ForeColor = Color.White
        lblHP.Location = New Point(262, 304)
        lblHP.Margin = New Padding(4, 0, 4, 0)
        lblHP.Name = "lblHP"
        lblHP.Size = New Size(20, 28)
        lblHP.TabIndex = 9
        lblHP.Text = "-"
        ' 
        ' lblLabelTanggal
        ' 
        lblLabelTanggal.AutoSize = True
        lblLabelTanggal.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblLabelTanggal.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(180))
        lblLabelTanggal.Location = New Point(538, 150)
        lblLabelTanggal.Margin = New Padding(4, 0, 4, 0)
        lblLabelTanggal.Name = "lblLabelTanggal"
        lblLabelTanggal.Size = New Size(147, 21)
        lblLabelTanggal.TabIndex = 10
        lblLabelTanggal.Text = "TANGGAL DAFTAR"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Font = New Font("Segoe UI", 10F)
        lblTanggal.ForeColor = Color.White
        lblTanggal.Location = New Point(538, 172)
        lblTanggal.Margin = New Padding(4, 0, 4, 0)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(20, 28)
        lblTanggal.TabIndex = 11
        lblTanggal.Text = "-"
        ' 
        ' lblLabelStatus
        ' 
        lblLabelStatus.AutoSize = True
        lblLabelStatus.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblLabelStatus.ForeColor = Color.FromArgb(CByte(180), CByte(180), CByte(180))
        lblLabelStatus.Location = New Point(538, 219)
        lblLabelStatus.Margin = New Padding(4, 0, 4, 0)
        lblLabelStatus.Name = "lblLabelStatus"
        lblLabelStatus.Size = New Size(67, 21)
        lblLabelStatus.TabIndex = 12
        lblLabelStatus.Text = "STATUS"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblStatus.ForeColor = Color.FromArgb(CByte(0), CByte(200), CByte(100))
        lblStatus.Location = New Point(538, 241)
        lblStatus.Margin = New Padding(4, 0, 4, 0)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(24, 32)
        lblStatus.TabIndex = 13
        lblStatus.Text = "-"
        ' 
        ' btnTutup
        ' 
        btnTutup.BackColor = Color.FromArgb(CByte(200), CByte(40), CByte(40))
        btnTutup.FlatAppearance.BorderSize = 0
        btnTutup.FlatStyle = FlatStyle.Flat
        btnTutup.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnTutup.ForeColor = Color.White
        btnTutup.Location = New Point(350, 538)
        btnTutup.Margin = New Padding(4, 4, 4, 4)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(175, 44)
        btnTutup.TabIndex = 2
        btnTutup.Text = "✕  Tutup"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        ClientSize = New Size(875, 612)
        Controls.Add(btnTutup)
        Controls.Add(pnlCard)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 4, 4, 4)
        MaximizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterParent
        Text = "Form2"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlCard.ResumeLayout(False)
        pnlCard.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeaderJudul As Label
    Friend WithEvents lblHeaderSub As Label
    Friend WithEvents pnlCard As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblKartuJudul As Label
    Friend WithEvents lblLabelID As Label
    Friend WithEvents lblIDMember As Label
    Friend WithEvents lblLabelNama As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblLabelPaket As Label
    Friend WithEvents lblPaket As Label
    Friend WithEvents lblLabelHP As Label
    Friend WithEvents lblHP As Label
    Friend WithEvents lblLabelTanggal As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblLabelStatus As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnTutup As Button
End Class