Imports System.Data.SqlClient
Public Class JoinMember
    Private Sub JoinMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        ComboBoxPeriode()
        RubahHarga()


    End Sub
    Sub ComboBoxPeriode()

        query = "select Periode from MembershipPlan"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)

        Periode.DataSource = table
        Periode.DisplayMember = "Periode"

        Periode.Text = ""

    End Sub
    Sub RubahHarga()

        query = "select * from MembershipPlan where Periode='" & Periode.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim t As New DataTable
        DA.Fill(t)

        If t.Rows.Count > 0 Then
            Harga.Text = t.Rows(0)(2).ToString()
        End If

    End Sub
    Sub InsertMember()

        Dim IDMember As Integer
        query = "select * from Member"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)

        If table.Rows.Count = 0 Then
            IDMember = 1
        Else

            query = "select top(1) MemberID from Member order by MemberID desc"
            DA = New SqlDataAdapter(query, conn)
            Dim t As New DataTable
            DA.Fill(t)
            Dim ID As Integer
            ID = t.Rows(0)(0).ToString()
            IDMember = ID + 1

        End If

        cmd = New SqlCommand
        query = "insert into Member(MemberID,NamaMember,Alamat,Umur)values('" & IDMember & "','" & Nama.Text & "','" & Alamat.Text & "','" & Umur.Text & "')"
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.ExecuteNonQuery()

    End Sub
    Sub Join()

        Dim IDjoin As Integer
        query = "select * from JoinMember"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)

        If table.Rows.Count = 0 Then
            IDjoin = 1
        Else

            query = "select top(1) JoinID from JoinMember order by JoinID desc"
            DA = New SqlDataAdapter(query, conn)
            Dim t As New DataTable
            DA.Fill(t)
            Dim ID As Integer
            ID = t.Rows(0)(0).ToString()
            IDjoin = ID + 1

        End If

        query = "select * from MembershipPlan where Periode= '" & Periode.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim tbl As New DataTable
        DA.Fill(tbl)
        Dim PlanID As Integer
        PlanID = tbl.Rows(0)(0).ToString()

        query = "select top(1) MemberID from Member order by MemberID desc"
        DA = New SqlDataAdapter(query, conn)
        Dim tabel As New DataTable
        DA.Fill(tabel)
        Dim member As Integer
        member = tabel.Rows(0)(0).ToString()

        cmd = New SqlCommand
        query = "insert into JoinMember(JoinID,PlanID,MemberID,TglGabung)values('" & IDjoin & "','" & PlanID & "','" & member & "',getdate())"
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.ExecuteNonQuery()

        query = "select * from Joinmember where JoinID='" & IDjoin & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim a As New DataTable
        DA.Fill(a)
        Dim tgljoin As Date
        tgljoin = a.Rows(0)(3).ToString()


        query = "select Joinmember.JoinID, JoinMember.PlanID, MembershipPlan.Periode from JoinMember
                join MembershipPlan on Joinmember.PlanID=MembershipPlan.PlanID where JoinID='" & IDjoin & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim bulan As Integer
        Dim b As New DataTable
        DA.Fill(b)
        bulan = b.Rows(0)(2).ToString()

        Dim tglberhenti As Date
        tglberhenti = tgljoin.AddMonths(bulan)

        cmd = New SqlCommand
        query = "update JoinMember set TglBerhenti='" & tglberhenti & "' where JoinID='" & IDjoin & "'"
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.ExecuteNonQuery()


    End Sub

    Private Sub Periode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Periode.SelectedIndexChanged

        RubahHarga()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        InsertMember()

        Join()

        MsgBox("Berhasil Join")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        MenuUtama.Enabled = True
        Me.Close()



    End Sub
End Class