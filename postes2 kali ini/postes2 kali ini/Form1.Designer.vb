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
        listperpus = New ListView()
        btnadd = New Button()
        btnupdate = New Button()
        btndelete = New Button()
        txt_nama = New TextBox()
        txt_genre = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' listperpus
        ' 
        listperpus.FullRowSelect = True
        listperpus.GridLines = True
        listperpus.Location = New Point(340, 55)
        listperpus.Name = "listperpus"
        listperpus.Size = New Size(439, 303)
        listperpus.TabIndex = 0
        listperpus.UseCompatibleStateImageBehavior = False
        ' 
        ' btnadd
        ' 
        btnadd.BackColor = Color.Orange
        btnadd.Font = New Font("High Tower Text", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnadd.Location = New Point(29, 282)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(153, 76)
        btnadd.TabIndex = 1
        btnadd.Text = "TAMBAH"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' btnupdate
        ' 
        btnupdate.BackColor = Color.Orange
        btnupdate.Font = New Font("High Tower Text", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnupdate.Location = New Point(457, 382)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(91, 23)
        btnupdate.TabIndex = 2
        btnupdate.Text = "PERBARUI"
        btnupdate.UseVisualStyleBackColor = False
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.Orange
        btndelete.Font = New Font("High Tower Text", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btndelete.Location = New Point(607, 382)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(75, 23)
        btndelete.TabIndex = 3
        btndelete.Text = "HAPUS"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' txt_nama
        ' 
        txt_nama.BackColor = Color.White
        txt_nama.Location = New Point(29, 97)
        txt_nama.Name = "txt_nama"
        txt_nama.Size = New Size(216, 23)
        txt_nama.TabIndex = 4
        ' 
        ' txt_genre
        ' 
        txt_genre.Location = New Point(29, 210)
        txt_genre.Name = "txt_genre"
        txt_genre.Size = New Size(216, 23)
        txt_genre.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("High Tower Text", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(29, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 22)
        Label1.TabIndex = 6
        Label1.Text = "NAMA BUKU"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("High Tower Text", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Gold
        Label2.Location = New Point(29, 173)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 22)
        Label2.TabIndex = 7
        Label2.Text = "GENRE"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.IndianRed
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txt_genre)
        Controls.Add(txt_nama)
        Controls.Add(btndelete)
        Controls.Add(btnupdate)
        Controls.Add(btnadd)
        Controls.Add(listperpus)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents listperpus As ListView
    Friend WithEvents btnadd As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents txt_genre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
