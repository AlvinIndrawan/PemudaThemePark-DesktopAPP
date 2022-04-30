Imports System.Data.SqlClient
Public Class ManageGaji
    Private Sub Gaji_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampil()

    End Sub
    Sub tampil()

        query = "select TipeGaji, Rate, Deskripsi from Gaji"
        DA = New SqlDataAdapter(query, conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Tipe.Text = DataGridView1.Item(0, i).Value
        Rate.Text = DataGridView1.Item(1, i).Value
        Deskripsi.Text = DataGridView1.Item(2, i).Value


        query = "select * from Gaji where TipeGaji='" & Tipe.Text & "' and Rate='" & Rate.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim t As New DataTable
        DA.Fill(t)
        GajiID = t.Rows(0)(0).ToString


    End Sub

    Private Sub insert_Click(sender As Object, e As EventArgs) Handles insert.Click

        query = "select top(1) GajiID from Gaji order by GajiID desc"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)
        Dim ID As Integer
        ID = table.Rows(0)(0).ToString
        ID = ID + 1

        cmd = New SqlCommand
        query = "insert into Gaji(GajiID,TipeGaji,Rate,Deskripsi)values('" & ID & "','" & Tipe.Text & "','" & Rate.Text & "','" & Deskripsi.Text & "')"
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.ExecuteNonQuery()

        MsgBox("Berhasil Insert")
        tampil()

        Tipe.Text = ""
        Rate.Text = ""
        Deskripsi.Text = ""


    End Sub

    Private Sub updet_Click(sender As Object, e As EventArgs) Handles updet.Click

        cmd = New SqlCommand
        query = "update Gaji set TipeGaji='" & Tipe.Text & "', Rate='" & Rate.Text & "',Deskripsi='" & Deskripsi.Text & "'where GajiID='" & GajiID & "'"
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.ExecuteNonQuery()

        MsgBox("Berhasil Update")
        tampil()
        Tipe.Text = ""
        Rate.Text = ""
        Deskripsi.Text = ""

    End Sub

    Private Sub delet_Click(sender As Object, e As EventArgs) Handles delet.Click

        cmd = New SqlCommand
        query = "delete from Gaji where TipeGaji='" & Tipe.Text & "'and Rate='" & Rate.Text & "'"
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.ExecuteNonQuery()

        MsgBox("Berhasil Delete")
        tampil()
        Tipe.Text = ""
        Rate.Text = ""
        Deskripsi.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MenuUtama.Enabled = True
        Me.Close()


    End Sub
End Class