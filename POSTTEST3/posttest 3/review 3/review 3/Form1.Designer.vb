<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbperempuan = New System.Windows.Forms.RadioButton()
        Me.rbpria = New System.Windows.Forms.RadioButton()
        Me.dtplahir = New System.Windows.Forms.DateTimePicker()
        Me.boxrenang = New System.Windows.Forms.CheckBox()
        Me.boxbalapan = New System.Windows.Forms.CheckBox()
        Me.boxtidur = New System.Windows.Forms.CheckBox()
        Me.txt_hasil = New System.Windows.Forms.TextBox()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnbrowse = New System.Windows.Forms.Button()
        Me.Bukafile = New System.Windows.Forms.OpenFileDialog()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtumur = New System.Windows.Forms.TextBox()
        Me.txtnopon = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.boxparkur = New System.Windows.Forms.CheckBox()
        Me.boxoff = New System.Windows.Forms.CheckBox()
        Me.boxmania = New System.Windows.Forms.CheckBox()
        Me.boxgadang = New System.Windows.Forms.CheckBox()
        Me.boxmusik = New System.Windows.Forms.CheckBox()
        Me.boxgambar = New System.Windows.Forms.CheckBox()
        Me.boxterbang = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MASUKAN DATA PRIBADI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tgl lahir"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 397)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Hobi"
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(125, 106)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(100, 20)
        Me.txt_nama.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbperempuan)
        Me.GroupBox1.Controls.Add(Me.rbpria)
        Me.GroupBox1.Location = New System.Drawing.Point(125, 286)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 42)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pilihan"
        '
        'rbperempuan
        '
        Me.rbperempuan.AutoSize = True
        Me.rbperempuan.Location = New System.Drawing.Point(98, 20)
        Me.rbperempuan.Name = "rbperempuan"
        Me.rbperempuan.Size = New System.Drawing.Size(79, 17)
        Me.rbperempuan.TabIndex = 1
        Me.rbperempuan.TabStop = True
        Me.rbperempuan.Text = "Perempuan"
        Me.rbperempuan.UseVisualStyleBackColor = True
        '
        'rbpria
        '
        Me.rbpria.AutoSize = True
        Me.rbpria.Location = New System.Drawing.Point(7, 20)
        Me.rbpria.Name = "rbpria"
        Me.rbpria.Size = New System.Drawing.Size(68, 17)
        Me.rbpria.TabIndex = 0
        Me.rbpria.TabStop = True
        Me.rbpria.Text = "Laki Laki"
        Me.rbpria.UseVisualStyleBackColor = True
        '
        'dtplahir
        '
        Me.dtplahir.Location = New System.Drawing.Point(125, 335)
        Me.dtplahir.Name = "dtplahir"
        Me.dtplahir.Size = New System.Drawing.Size(200, 20)
        Me.dtplahir.TabIndex = 10
        '
        'boxrenang
        '
        Me.boxrenang.AutoSize = True
        Me.boxrenang.Location = New System.Drawing.Point(125, 397)
        Me.boxrenang.Name = "boxrenang"
        Me.boxrenang.Size = New System.Drawing.Size(72, 17)
        Me.boxrenang.TabIndex = 12
        Me.boxrenang.Text = "Berenang"
        Me.boxrenang.UseVisualStyleBackColor = True
        '
        'boxbalapan
        '
        Me.boxbalapan.AutoSize = True
        Me.boxbalapan.Location = New System.Drawing.Point(125, 421)
        Me.boxbalapan.Name = "boxbalapan"
        Me.boxbalapan.Size = New System.Drawing.Size(64, 17)
        Me.boxbalapan.TabIndex = 13
        Me.boxbalapan.Text = "balapan"
        Me.boxbalapan.UseVisualStyleBackColor = True
        '
        'boxtidur
        '
        Me.boxtidur.AutoSize = True
        Me.boxtidur.Location = New System.Drawing.Point(223, 392)
        Me.boxtidur.Name = "boxtidur"
        Me.boxtidur.Size = New System.Drawing.Size(46, 17)
        Me.boxtidur.TabIndex = 14
        Me.boxtidur.Text = "tidur"
        Me.boxtidur.UseVisualStyleBackColor = True
        '
        'txt_hasil
        '
        Me.txt_hasil.Location = New System.Drawing.Point(623, 99)
        Me.txt_hasil.Multiline = True
        Me.txt_hasil.Name = "txt_hasil"
        Me.txt_hasil.Size = New System.Drawing.Size(290, 414)
        Me.txt_hasil.TabIndex = 15
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(623, 540)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(75, 23)
        Me.btntambah.TabIndex = 16
        Me.btntambah.Text = "tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(448, 101)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(122, 174)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'btnbrowse
        '
        Me.btnbrowse.Location = New System.Drawing.Point(472, 286)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnbrowse.TabIndex = 18
        Me.btnbrowse.Text = "Browse"
        Me.btnbrowse.UseVisualStyleBackColor = True
        '
        'Bukafile
        '
        Me.Bukafile.FileName = "Bukafile"
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(125, 188)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(100, 20)
        Me.txtalamat.TabIndex = 19
        '
        'txtumur
        '
        Me.txtumur.Location = New System.Drawing.Point(125, 147)
        Me.txtumur.Name = "txtumur"
        Me.txtumur.Size = New System.Drawing.Size(100, 20)
        Me.txtumur.TabIndex = 20
        '
        'txtnopon
        '
        Me.txtnopon.Location = New System.Drawing.Point(125, 235)
        Me.txtnopon.Name = "txtnopon"
        Me.txtnopon.Size = New System.Drawing.Size(100, 20)
        Me.txtnopon.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(41, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Umur"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(41, 195)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Alamat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(41, 242)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Nomor telpon"
        '
        'boxparkur
        '
        Me.boxparkur.AutoSize = True
        Me.boxparkur.Location = New System.Drawing.Point(223, 421)
        Me.boxparkur.Name = "boxparkur"
        Me.boxparkur.Size = New System.Drawing.Size(63, 17)
        Me.boxparkur.TabIndex = 25
        Me.boxparkur.Text = "Parkour"
        Me.boxparkur.UseVisualStyleBackColor = True
        '
        'boxoff
        '
        Me.boxoff.AutoSize = True
        Me.boxoff.Location = New System.Drawing.Point(125, 444)
        Me.boxoff.Name = "boxoff"
        Me.boxoff.Size = New System.Drawing.Size(64, 17)
        Me.boxoff.TabIndex = 26
        Me.boxoff.Text = "Off road"
        Me.boxoff.UseVisualStyleBackColor = True
        '
        'boxmania
        '
        Me.boxmania.AutoSize = True
        Me.boxmania.Location = New System.Drawing.Point(223, 444)
        Me.boxmania.Name = "boxmania"
        Me.boxmania.Size = New System.Drawing.Size(67, 17)
        Me.boxmania.TabIndex = 27
        Me.boxmania.Text = "Mancing"
        Me.boxmania.UseVisualStyleBackColor = True
        '
        'boxgadang
        '
        Me.boxgadang.AutoSize = True
        Me.boxgadang.Location = New System.Drawing.Point(125, 467)
        Me.boxgadang.Name = "boxgadang"
        Me.boxgadang.Size = New System.Drawing.Size(75, 17)
        Me.boxgadang.TabIndex = 28
        Me.boxgadang.Text = "Begadang"
        Me.boxgadang.UseVisualStyleBackColor = True
        '
        'boxmusik
        '
        Me.boxmusik.AutoSize = True
        Me.boxmusik.Location = New System.Drawing.Point(223, 467)
        Me.boxmusik.Name = "boxmusik"
        Me.boxmusik.Size = New System.Drawing.Size(54, 17)
        Me.boxmusik.TabIndex = 29
        Me.boxmusik.Text = "Musik"
        Me.boxmusik.UseVisualStyleBackColor = True
        '
        'boxgambar
        '
        Me.boxgambar.AutoSize = True
        Me.boxgambar.Location = New System.Drawing.Point(125, 490)
        Me.boxgambar.Name = "boxgambar"
        Me.boxgambar.Size = New System.Drawing.Size(63, 17)
        Me.boxgambar.TabIndex = 30
        Me.boxgambar.Text = "Gambar"
        Me.boxgambar.UseVisualStyleBackColor = True
        '
        'boxterbang
        '
        Me.boxterbang.AutoSize = True
        Me.boxterbang.Location = New System.Drawing.Point(223, 490)
        Me.boxterbang.Name = "boxterbang"
        Me.boxterbang.Size = New System.Drawing.Size(66, 17)
        Me.boxterbang.TabIndex = 31
        Me.boxterbang.Text = "Terbang"
        Me.boxterbang.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(475, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 34)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "FOTO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(736, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 34)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "HASIL"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(946, 642)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.boxterbang)
        Me.Controls.Add(Me.boxgambar)
        Me.Controls.Add(Me.boxmusik)
        Me.Controls.Add(Me.boxgadang)
        Me.Controls.Add(Me.boxmania)
        Me.Controls.Add(Me.boxoff)
        Me.Controls.Add(Me.boxparkur)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtnopon)
        Me.Controls.Add(Me.txtumur)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.btnbrowse)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.txt_hasil)
        Me.Controls.Add(Me.boxtidur)
        Me.Controls.Add(Me.boxbalapan)
        Me.Controls.Add(Me.boxrenang)
        Me.Controls.Add(Me.dtplahir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "POSTTEST 3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_nama As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbperempuan As System.Windows.Forms.RadioButton
    Friend WithEvents rbpria As System.Windows.Forms.RadioButton
    Friend WithEvents dtplahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents boxrenang As System.Windows.Forms.CheckBox
    Friend WithEvents boxbalapan As System.Windows.Forms.CheckBox
    Friend WithEvents boxtidur As System.Windows.Forms.CheckBox
    Friend WithEvents txt_hasil As System.Windows.Forms.TextBox
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnbrowse As System.Windows.Forms.Button
    Friend WithEvents Bukafile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents txtumur As TextBox
    Friend WithEvents txtnopon As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents boxparkur As CheckBox
    Friend WithEvents boxoff As CheckBox
    Friend WithEvents boxmania As CheckBox
    Friend WithEvents boxgadang As CheckBox
    Friend WithEvents boxmusik As CheckBox
    Friend WithEvents boxgambar As CheckBox
    Friend WithEvents boxterbang As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
End Class
