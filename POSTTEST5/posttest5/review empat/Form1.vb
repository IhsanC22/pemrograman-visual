Imports MySql.Data.MySqlClient
Public Class Form1
    Sub Kosong()
        txtjenis.Clear()
        txtkodejenis.Clear()
        txtjenis.Focus()
    End Sub
    Sub isi()
        txtjenis.Clear()
        txtjenis.Focus()
    End Sub
    Sub tampilJenis()
        DA = New MySqlDataAdapter("select * from daging", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "jenis")
        DataGridView1.DataSource = DS.Tables("jenis")
        DataGridView1.Refresh()
    End Sub
    Sub aturGrid()
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "Jenis"
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilJenis()
        Kosong()
        aturGrid()
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtjenis.Text = Nothing And txtkodejenis.Text = Nothing Then
            MsgBox("Data Belum Lengkap")
            txtkodejenis.Focus()
        Else
            CMD = New MySqlCommand("Select * from daging where id =
'" & txtkodejenis.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If Not RD.HasRows Then
                RD.Close()
                CMD = New MySqlCommand("insert into daging values
('" & txtkodejenis.Text & "', '" & txtjenis.Text &
                "')", CONN)
                CMD.ExecuteNonQuery()
                tampilJenis()
                Kosong()
                MsgBox("Simpan Data Sukses!")
                txtkodejenis.Focus()
            Else
                RD.Close()
                MsgBox("Data Tersebut Sudah Ada")
            End If
        End If
    End Sub
    Private Sub txtjenis_KeyPress(sender As Object, e As KeyPressEventArgs)
        txtjenis.MaxLength = 50
        If e.KeyChar = Chr(13) Then
            txtjenis.Text = UCase(txtjenis.Text)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)
            If row.Index < DataGridView1.RowCount - 1 And row.Index >= 0 Then
                txtkodejenis.Text = row.Cells(0).Value
                txtjenis.Text = row.Cells(1).Value
            End If
        End If
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If txtjenis.Text = Nothing Then
            MsgBox("Jenis belum diisi")
            txtkodejenis.Focus()
        Else
            Dim ubah As String = "update daging set jenis = '" &
            txtjenis.Text & "' where id = '" & txtkodejenis.Text & "'"
            CMD = New MySqlCommand(ubah, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil diubah")
            tampilJenis()
            Kosong()
        End If

    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If txtjenis.Text Is Nothing Then
            MsgBox("Jenis belum diisi")
            txtkodejenis.Focus()
        Else
            Dim hapus As String = "delete from daging where id = '" & txtkodejenis.Text & "'"
            CMD = New MySqlCommand(hapus, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus")
            tampilJenis()
            Kosong()
        End If
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Kosong()
        tampilJenis()
    End Sub

    Private Sub txtKodejenis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkodejenis.KeyPress
        txtkodejenis.MaxLength = 2
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("select * from daging", CONN)
            RD = CMD.ExecuteReader()
            RD.Read()
            If RD.HasRows Then
                txtjenis.Text = RD("jenis")
                txtjenis.Focus()
            Else
                isi()
                txtjenis.Focus()
            End If
            RD.Close()
        End If


    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text <> Nothing Then
            CMD = New MySqlCommand("select * from daging where id like '%" & txtSearch.Text & "%'", CONN)
            RD = CMD.ExecuteReader()
            If RD.HasRows Then
                DS.Clear()
                While RD.Read()
                    Dim dsNewRow As DataRow = DS.Tables("jenis").NewRow()
                    dsNewRow.Item(0) = RD("id")
                    dsNewRow.Item(1) = RD("jenis")
                    DS.Tables("jenis").Rows.Add(dsNewRow)
                End While
            Else
                MsgBox("Data tidak ditemukan")
            End If
            RD.Close()
        Else
            tampilJenis()
        End If
    End Sub
End Class