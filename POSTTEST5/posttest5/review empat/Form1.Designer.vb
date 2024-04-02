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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtkodejenis = New System.Windows.Forms.TextBox()
        Me.txtjenis = New System.Windows.Forms.TextBox()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis"
        '
        'txtkodejenis
        '
        Me.txtkodejenis.Location = New System.Drawing.Point(144, 110)
        Me.txtkodejenis.Name = "txtkodejenis"
        Me.txtkodejenis.Size = New System.Drawing.Size(313, 20)
        Me.txtkodejenis.TabIndex = 2
        '
        'txtjenis
        '
        Me.txtjenis.Location = New System.Drawing.Point(144, 175)
        Me.txtjenis.Name = "txtjenis"
        Me.txtjenis.Size = New System.Drawing.Size(313, 20)
        Me.txtjenis.TabIndex = 3
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnsimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnsimpan.Location = New System.Drawing.Point(144, 222)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 5
        Me.btnsimpan.Text = "simpan"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(520, 141)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(387, 287)
        Me.DataGridView1.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(129, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(735, 33)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "APLIKASI PENDATAAN TOKO DAGING CV.MULYA"
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnhapus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnhapus.Location = New System.Drawing.Point(420, 355)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnhapus.TabIndex = 11
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnubah
        '
        Me.btnubah.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnubah.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnubah.Location = New System.Drawing.Point(420, 326)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(75, 23)
        Me.btnubah.TabIndex = 12
        Me.btnubah.Text = "Edit"
        Me.btnubah.UseVisualStyleBackColor = False
        '
        'btnbatal
        '
        Me.btnbatal.BackColor = System.Drawing.SystemColors.Desktop
        Me.btnbatal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnbatal.Location = New System.Drawing.Point(420, 384)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(75, 23)
        Me.btnbatal.TabIndex = 13
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(520, 110)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(387, 20)
        Me.txtSearch.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(934, 430)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.txtjenis)
        Me.Controls.Add(Me.txtkodejenis)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtkodejenis As TextBox
    Friend WithEvents txtjenis As TextBox
    Friend WithEvents btnsimpan As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnubah As Button
    Friend WithEvents btnbatal As Button
    Friend WithEvents txtSearch As TextBox
End Class
