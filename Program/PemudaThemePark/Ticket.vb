Imports System.Data.SqlClient
Public Class Ticket
    Private Sub Ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

        tampil()

    End Sub
    Sub tampil()

        query = "select * from Ticket"
        DA = New SqlDataAdapter(query, conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        Hari.Text = DataGridView1.Item(1, i).Value
        Kategori.Text = DataGridView1.Item(2, i).Value
        Harga.Text = DataGridView1.Item(3, i).Value

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        cmd = New SqlCommand
        query = "update Ticket set Harga='" & Harga.Text & "' where hari='" & Hari.Text & "' and Kategori='" & Kategori.Text & "'"
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.ExecuteNonQuery()

        MsgBox("Selesai")
        tampil()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        MenuUtama.Enabled = True
        Me.Close()

    End Sub
End Class