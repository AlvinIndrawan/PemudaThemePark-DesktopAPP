Imports System.Data.SqlClient
Imports System.IO
Public Class ManageGames
    Private Sub ManageGames_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampil()

    End Sub
    Sub tampil()

        query = "select NamaGame, TglBangun, Umur, Kapasitas, Durasi,Photo from Games"
        DA = New SqlDataAdapter(query, conn)
        DS = New DataSet
        DA.Fill(DS)

        DataGridView1.DataSource = DS.Tables(0)

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        Nama.Text = DataGridView1.Item(0, i).Value
        DateTimePicker1.Text = DataGridView1.Item(1, i).Value
        Umur.Text = DataGridView1.Item(2, i).Value
        Kapasitas.Text = DataGridView1.Item(3, i).Value
        Durasi.Text = DataGridView1.Item(4, i).Value
        Photo.Text = DataGridView1.Item(5, i).Value

        Dim opf As New OpenFileDialog

        opf.FileName = Photo.Text
        PictureBox1.Image = Image.FromFile(opf.FileName)

    End Sub

    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click

        query = "select top(1) GamesID from Games order by GamesID desc"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)
        Dim IDgame As Integer
        IDgame = table.Rows(0)(0).ToString()
        IDgame = IDgame + 1

        cmd = New SqlCommand
        query = "insert into Games(GamesID,NamaGame,TglBangun,Umur,Kapasitas,Durasi,Photo)values('" & IDgame & "','" & Nama.Text & "','" & DateTimePicker1.Value & "','" & Umur.Text & "','" & Kapasitas.Text & "','" & Durasi.Text & "','" & Photo.Text & "')"
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.ExecuteNonQuery()

        MsgBox("Berhasil Insert")
        tampil()

        Nama.Text = ""
        DateTimePicker1.Text = ""
        Umur.Text = ""
        Kapasitas.Text = ""
        Durasi.Text = ""


    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click

        cmd = New SqlCommand
        query = "delete from Games where NamaGame='" & Nama.Text & "'"
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.ExecuteNonQuery()

        MsgBox("Berhasil Delete")
        tampil()

        Nama.Text = ""
        DateTimePicker1.Text = ""
        Umur.Text = ""
        Kapasitas.Text = ""
        Durasi.Text = ""

    End Sub

    Private Sub Updet_Click(sender As Object, e As EventArgs) Handles Updet.Click

        cmd = New SqlCommand
        query = "update Games set NamaGame='" & Nama.Text & "',TglBangun='" & DateTimePicker1.Value & "',Umur='" & Umur.Text & "',Kapasitas='" & Kapasitas.Text & "',Durasi='" & Durasi.Text & "',Photo='" & Photo.Text & "' where NamaGame='" & Nama.Text & "'"
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.ExecuteNonQuery()

        MsgBox("Berhasil Update")
        tampil()

        Nama.Text = ""
        DateTimePicker1.Text = ""
        Umur.Text = ""
        Kapasitas.Text = ""
        Durasi.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MenuUtama.Enabled = True
        Me.Close()

    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click

        Dim opf As New OpenFileDialog
        opf.Filter = "choose image(*.JPG;*.PNG)|*.jpg;*.png"

        If opf.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If

        Photo.Text = opf.FileName
        Dim ms As New MemoryStream
        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)

    End Sub
End Class