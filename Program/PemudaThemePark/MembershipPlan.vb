Imports System.Data.SqlClient
Public Class MembershipPlan
    Private Sub MembershipPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampil()

    End Sub
    Sub tampil()

        query = "select Periode, Harga from MembershipPlan"
        DA = New SqlDataAdapter(query, conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)

    End Sub

    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click

        query = "select top(1) PlanID from MembershipPlan order by PlanID desc"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)

        Dim PlanID As Integer
        PlanID = table.Rows(0)(0).ToString
        PlanID = PlanID + 1

        cmd = New SqlCommand
        query = "insert into MembershipPlan(PlanID,Periode,Harga)values('" & PlanID & "', '" & Periode.Text & "', '" & Harga.Text & "')"
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.ExecuteNonQuery()

        MsgBox("Berhasil Insert")
        tampil()

        Periode.Text = ""
        Harga.Text = ""

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        Periode.Text = DataGridView1.Item(0, i).Value
        Harga.Text = DataGridView1.Item(1, i).Value

    End Sub

    Private Sub Updet_Click(sender As Object, e As EventArgs) Handles Updet.Click

        query = "select PlanID from MembershipPlan where Periode='" & Periode.Text & "' and Harga='" & Harga.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)

        PlanID = table.Rows(0)(0).ToString

        Save.Enabled = True
        Cancel.Enabled = True


    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click

        cmd = New SqlCommand
        query = "update MembershipPlan set Periode='" & Periode.Text & "' , Harga='" & Harga.Text & "' where PlanID ='" & PlanID & "'"
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.ExecuteNonQuery()

        MsgBox("Berhasil Update")
        tampil()

        Periode.Text = ""
        Harga.Text = ""

        Save.Enabled = False
        Cancel.Enabled = False

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click

        Save.Enabled = False
        Cancel.Enabled = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        query = "select PlanID from MembershipPlan where Periode='" & Periode.Text & "'and Harga='" & Harga.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        Dim ID As Integer
        DA.Fill(table)
        ID = table.Rows(0)(0).ToString



        cmd = New SqlCommand
        query = "delete from MembershipPlan where PlanID='" & ID & "'"
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.ExecuteNonQuery()

        MsgBox("Berhasil Delete")
        tampil()
        Periode.Text = ""
        Harga.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MenuUtama.Enabled = True
        Me.Close()

    End Sub
End Class