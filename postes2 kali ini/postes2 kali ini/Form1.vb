Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim index As Integer
    Dim bebas(2, 100) As String
    Private Sub cls()
        txt_nama.Clear()
        txt_genre.Clear()
    End Sub

    Private Function cekdatakosong()
        If txt_nama.Text = "" Then
            MessageBox.Show("kotak kosong, wajib diisi", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_nama.Focus()
        ElseIf txt_genre.Text = "" Then
            MessageBox.Show("kotak kosong, wajib diisi", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_genre.Focus()
        Else
            Return True
        End If

        Return False
    End Function

    Private Sub nambah_data()
        listperpus.Items.Clear()
        For i As Integer = 0 To index - 1
            Dim item As New ListViewItem((i + 1).ToString())
            item.SubItems.Add(bebas(1, i))
            item.SubItems.Add(bebas(2, i))
            listperpus.Items.Add(item)
        Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "SISTEM MANAGEMEN PERPUSTAKAAN"
        listperpus.View = View.Details
        listperpus.Columns.Add("no", 50, HorizontalAlignment.Center)
        listperpus.Columns.Add("nama", 200, HorizontalAlignment.Center)
        listperpus.Columns.Add("genre", 200, HorizontalAlignment.Center)
        txt_nama.Focus()
    End Sub

    Private Sub mylistview_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listperpus.SelectedIndexChanged
        If listperpus.SelectedItems.Count > 0 Then
            txt_nama.Text = listperpus.SelectedItems(0).SubItems(1).Text
            txt_genre.Text = listperpus.SelectedItems(0).SubItems(2).Text
        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If cekdatakosong() = True Then
            If index < 100 Then
                Dim nama As String = txt_nama.Text
                Dim genre As String = txt_genre.Text

                bebas(1, index) = nama
                bebas(2, index) = genre

                index += 1

                nambah_data()

                cls()
            Else
                MessageBox.Show("perpus kelebihan", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If listperpus.SelectedItems.Count > 0 Then
            Dim ok As String
            ok = MessageBox.Show("yakin mau dihapus ?", "info", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ok = MsgBoxResult.Yes Then
                Dim selectedindex As Integer = listperpus.SelectedIndices(0)
                For i As Integer = selectedindex To index - 2
                    bebas(1, i) = bebas(1, i + 1)
                    bebas(2, i) = bebas(2, i + 1)
                Next
                index -= 1
                nambah_data()
                MessageBox.Show("buku berhasil dihapus", "info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("pilih buku yg mau dihapus", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If listperpus.SelectedItems.Count > 0 Then
            If cekdatakosong() = True Then
                Dim selectedindex As Integer = listperpus.SelectedIndices(0)
                Dim namabaru As String = txt_nama.Text
                Dim genrebaru As String = txt_genre.Text

                bebas(1, selectedindex) = namabaru
                bebas(2, selectedindex) = genrebaru

                nambah_data()

                cls()
                MessageBox.Show("data berhasil diganti", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("pilih buku yang mau di ganti", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
