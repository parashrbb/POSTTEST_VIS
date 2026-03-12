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
        GroupBox1 = New GroupBox()
        btnTambah = New Button()
        Label2 = New Label()
        Label1 = New Label()
        txtGenre = New TextBox()
        txtJudulTambah = New TextBox()
        GroupBox2 = New GroupBox()
        btnHapus = New Button()
        Label3 = New Label()
        txtJudulHapus = New TextBox()
        lstBuku = New ListBox()
        Label4 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Linen
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtGenre)
        GroupBox1.Controls.Add(txtJudulTambah)
        GroupBox1.Location = New Point(78, 115)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(338, 241)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.DarkSalmon
        btnTambah.ForeColor = SystemColors.ButtonHighlight
        btnTambah.Location = New Point(224, 187)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(97, 34)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 25)
        Label2.TabIndex = 3
        Label2.Text = "Genre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 25)
        Label1.TabIndex = 2
        Label1.Text = "Judul Buku"
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(154, 109)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(150, 31)
        txtGenre.TabIndex = 1
        ' 
        ' txtJudulTambah
        ' 
        txtJudulTambah.Location = New Point(154, 48)
        txtJudulTambah.Name = "txtJudulTambah"
        txtJudulTambah.Size = New Size(150, 31)
        txtJudulTambah.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Linen
        GroupBox2.Controls.Add(btnHapus)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(txtJudulHapus)
        GroupBox2.Location = New Point(440, 115)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(330, 241)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.YellowGreen
        btnHapus.ForeColor = SystemColors.ButtonHighlight
        btnHapus.Location = New Point(219, 187)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(97, 34)
        btnHapus.TabIndex = 6
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 51)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 25)
        Label3.TabIndex = 4
        Label3.Text = "Judul Buku"
        ' 
        ' txtJudulHapus
        ' 
        txtJudulHapus.Location = New Point(154, 48)
        txtJudulHapus.Name = "txtJudulHapus"
        txtJudulHapus.Size = New Size(150, 31)
        txtJudulHapus.TabIndex = 2
        ' 
        ' lstBuku
        ' 
        lstBuku.BackColor = SystemColors.Menu
        lstBuku.BorderStyle = BorderStyle.FixedSingle
        lstBuku.FormattingEnabled = True
        lstBuku.Location = New Point(256, 395)
        lstBuku.Name = "lstBuku"
        lstBuku.Size = New Size(324, 177)
        lstBuku.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Clarendon BT", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(138, 48)
        Label4.Name = "Label4"
        Label4.Size = New Size(618, 34)
        Label4.TabIndex = 3
        Label4.Text = "SISTEM DAFTAR BUKU PERPUSTAKAAN"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(848, 613)
        Controls.Add(Label4)
        Controls.Add(lstBuku)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Posttest 2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtJudulTambah As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtJudulHapus As TextBox
    Friend WithEvents lstBuku As ListBox
    Friend WithEvents Label4 As Label

End Class
