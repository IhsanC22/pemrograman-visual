Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub txt_nama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nama.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[a-z, A-Z]" _
        OrElse keyascii = Keys.Back _
        OrElse keyascii = Keys.Space _
        OrElse keyascii = Keys.Return _
        OrElse keyascii = Keys.Delete) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub


    Private Sub txt_nim_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim keyascii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyascii = Keys.Back) Then
            keyascii = 0
        Else
            e.Handled = CBool(keyascii)
        End If
    End Sub


    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Dim nama, gender, alamat, hobi As String
        Dim umur, nopon As Integer
        Dim tgllahir As Date

        nama = txt_nama.Text
        umur = txtumur.Text
        alamat = txtalamat.Text
        nopon = txtnopon.Text

        If rbpria.Checked = True Then
            gender = rbpria.Text
        Else
            gender = rbperempuan.Text
        End If

        tgllahir = dtplahir.Text

        hobi = ""
        txt_hasil.Text = ""

        If boxrenang.Checked = True Then
            hobi = hobi & boxrenang.Text & vbCrLf
        End If

        If boxbalapan.Checked = True Then
            hobi = hobi & boxbalapan.Text & vbCrLf
        End If

        If boxtidur.Checked = True Then
            hobi = hobi & boxtidur.Text & vbCrLf
        End If

        If boxparkur.Checked = True Then
            hobi = hobi & boxparkur.Text & vbCrLf
        End If

        If boxoff.Checked = True Then
            hobi = hobi & boxoff.Text & vbCrLf
        End If

        If boxmania.Checked = True Then
            hobi = hobi & boxmania.Text & vbCrLf
        End If

        If boxgadang.Checked = True Then
            hobi = hobi & boxgadang.Text & vbCrLf
        End If

        If boxmusik.Checked = True Then
            hobi = hobi & boxmusik.Text & vbCrLf
        End If

        If boxgambar.Checked = True Then
            hobi = hobi & boxgambar.Text & vbCrLf
        End If

        If boxterbang.Checked = True Then
            hobi = hobi & boxterbang.Text & vbCrLf
        End If

        txt_hasil.Text = "Nama : " & nama & vbCrLf &
                         "Umur : " & umur & vbCrLf &
                         "Alamat : " & alamat & vbCrLf &
                         "No Hp : " & nopon & vbCrLf &
                         "Gender : " & gender & vbCrLf &
                         "Tgl Lahir : " & tgllahir & vbCrLf &
                         "hobi : " & vbCrLf & hobi

    End Sub

    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        Bukafile.Filter = "*.jpg|*.png"
        Bukafile.ShowDialog()
        PictureBox1.ImageLocation = Bukafile.FileName
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtalamat.TextChanged

    End Sub
End Class
