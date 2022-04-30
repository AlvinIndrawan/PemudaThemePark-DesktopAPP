Imports System.Data.SqlClient
Public Class TicketPurchase
    Private Sub TicketPurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampiltgl()
        tampilnama()


    End Sub
    Sub tampiltgl()

        Dim today As Date
        today = Now.Date
        Tanggal.Text = today

    End Sub
    Sub tampilnama()

        query = "select * from Pegawai where Username='" & Login.Username.Text & "' and Pasword='" & Login.Pasword.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim tbl As New DataTable
        DA.Fill(tbl)
        Dim n As String
        n = tbl.Rows(0)(1).ToString

        Nama.Text = n

    End Sub

    Private Sub cektotal_Click(sender As Object, e As EventArgs) Handles cektotal.Click

        If CheckBox2.Checked = False And CheckBox1.Checked = True Then

            total.Text = 0

        ElseIf CheckBox2.Checked = True And CheckBox1.Checked = True Then

            Dim PriceA As Integer
            Dim QtyA As Integer
            Dim PriceC As Integer
            Dim QtyC As Integer

            Dim TotalAdult As Integer
            Dim TotalChildren As Integer
            Dim t As Integer

            PriceA = PriceAdult.Text
            QtyA = QtyAdult.Text
            PriceC = PriceChildren.Text
            QtyC = QtyChildren.Text

            TotalAdult = PriceA * QtyA
            TotalChildren = PriceC * QtyC

            t = TotalAdult + TotalChildren

            total.Text = t

        ElseIf CheckBox2.Checked = True And CheckBox1.Checked = False Then

            Dim PriceA As Integer
            Dim QtyA As Integer
            Dim PriceC As Integer
            Dim QtyC As Integer

            Dim TotalAdult As Integer
            Dim TotalChildren As Integer
            Dim t As Integer

            PriceA = PriceAdult.Text
            QtyA = QtyAdult.Text
            PriceC = PriceChildren.Text
            QtyC = QtyChildren.Text

            TotalAdult = PriceA * QtyA
            TotalChildren = PriceC * QtyC

            t = TotalAdult + TotalChildren

            total.Text = t

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        MenuUtama.Enabled = True
        Me.Close()


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
        End If



    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        If CheckBox2.Checked = True Then
            GroupBox2.Enabled = True
        Else
            GroupBox2.Enabled = False
        End If

    End Sub

    Private Sub cari_Click(sender As Object, e As EventArgs) Handles cari.Click

        query = "select Member.NamaMember, Member.Umur, MembershipPlan.Periode, JoinMember.TglGabung, JoinMember.TglBerhenti from JoinMember
                join Member on Member.MemberID=JoinMember.MemberID
                join MembershipPlan on MembershipPlan.PlanID=JoinMember.PlanID
                where Member.NamaMember like '%" & NamaMember.Text & "%'"
        DA = New SqlDataAdapter(query, conn)
        DS = New DataSet
        Dim table As New DataTable
        DA.Fill(table)

        If table.Rows.Count = 0 Then

            MsgBox("Nama member tidak ditemukan")
        Else

            DA.Fill(DS)
            DataGridView1.DataSource = DS.Tables(0)

        End If


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        MemberName = DataGridView1.Item(0, i).Value

        Dim umur As Integer
        umur = DataGridView1.Item(1, i).Value

        If umur >= 17 Then

            kategorimember.Text = "Adult"

        Else

            kategorimember.Text = "Children"

        End If



        Dim tglberhenti As Date
        tglberhenti = DataGridView1.Item(4, i).Value
        Dim selisih As Integer
        Dim tglskrg As Date
        tglskrg = Now.Date

        selisih = DateDiff(DateInterval.Day, tglberhenti, tglskrg)

        If selisih < 0 Then

            status.Text = "Aktif"

        Else

            status.Text = "Kadaluarsa"

        End If


    End Sub

    Private Sub Hari_TextChanged(sender As Object, e As EventArgs) Handles Hari.TextChanged

        query = "select * from Ticket where Hari='" & Hari.Text & "' and Kategori='Adult'"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)
        PriceAdult.Text = table.Rows(0)(3).ToString

        query = "select * from Ticket where Hari='" & Hari.Text & "' and Kategori='Children'"
        DA = New SqlDataAdapter(query, conn)
        Dim tbl As New DataTable
        DA.Fill(tbl)
        PriceChildren.Text = tbl.Rows(0)(3).ToString

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        '      query = "select * from TicketPurchase"
        '     DA = New SqlDataAdapter(query, conn)
        '    Dim tbl As New DataTable
        '   DA.Fill(tbl)
        '  Dim ID As Integer

        'If tbl.Rows.Count = 0 Then

        'ID = 1

        '  Else

        'query = "select top(1) PurchaseID from TicketPurchase order by PurchaseID desc"
        'DA = New SqlDataAdapter(query, conn)
        ' Dim tabell As New DataTable
        ' DA.Fill(tabell)
        '  ID = tabell.Rows(0)(0).ToString
        '  ID = ID + 1

        '   End If


        '     query = "select * from Pegawai where NamaPegawai='" & Nama.Text & "'"
        '     DA = New SqlDataAdapter(query, conn)
        '     Dim table As New DataTable
        '     DA.Fill(table)
        '     Dim IDpegawai As Integer
        '     IDpegawai = table.Rows(0)(0).ToString


        '     If CheckBox1.Checked = True And CheckBox2.Checked = True Then

        '     query = "select * from Member where NamaMember='" & MemberName & "'"
        '    DA = New SqlDataAdapter(query, conn)
        '    Dim tbel As New DataTable
        '   DA.Fill(tbel)
        '  Dim IDmember As Integer
        '  IDmember = tbel.Rows(0)(0).ToString


        '   Dim QtyA As Integer
        '   Dim QtyChild As Integer

        '   QtyA = QtyAdult.Text
        '   QtyChild = QtyChildren.Text

        '  If kategorimember.Text = "Adult" Then

        ' QtyA = QtyA + 1

        'Else

        ' QtyChild = QtyChild + 1

        ' End If

        ' Dim PriceA As Integer
        ' Dim PriceC As Integer
        ' PriceA = QtyAdult.Text * PriceAdult.Text
        ' PriceC = QtyChildren.Text * PriceChildren.Text

        ' cmd = New SqlCommand
        'query = "insert into TicketPurchase(PurchaseID,MemberID,PegawaiID,Tanggal,QtyAdult,QtyChildren,PriceAdult,PriceChildren,total)
        '  values('" & ID & "','" & IDmember & "','" & IDpegawai & "','" & Tanggal.Text & "','" & QtyA & "','" & QtyChild & "','" & PriceA & "','" & PriceC & "','" & total.Text & "')"
        ' cmd.Connection = conn
        ' cmd.CommandText = query
        ' cmd.ExecuteNonQuery()

        '  ElseIf CheckBox1.Checked = False And CheckBox2.Checked = True Then

        '   Dim PriceA As Integer
        ' Dim PriceC As Integer
        ' PriceA = QtyAdult.Text * PriceAdult.Text
        'PriceC = QtyChildren.Text * PriceChildren.Text

        'cmd = New SqlCommand
        'query = "insert into TicketPurchase(PurchaseID,PegawaiID,Tanggal,QtyAdult,QtyChildren,PriceAdult,PriceChildren,total)
        'values('" & ID & "','" & IDpegawai & "','" & Tanggal.Text & "','" & QtyAdult.Text & "','" & QtyChildren.Text & "','" & PriceA & "','" & PriceC & "','" & total.Text & "')"
        'cmd.Connection = conn
        'cmd.CommandText = query
        'cmd.ExecuteNonQuery()

        ' ElseIf CheckBox1.Checked = True And CheckBox2.Checked = False Then

        'query = "select * from Member where NamaMember='" & MemberName & "'"
        'DA = New SqlDataAdapter(query, conn)
        'Dim tabl As New DataTable
        'DA.Fill(tabl)
        '  Dim IDmember As Integer
        '    IDmember = tabl.Rows(0)(0).ToString


        '   Dim QuantityAdult As Integer
        '   Dim QuantityChild As Integer

        '  If kategorimember.Text = "Adult" Then

        '  QuantityAdult = 1
        '  QuantityChild = 0

        '   Else

        '   QuantityAdult = 0
        '  QuantityChild = 1

        ' End If

        'cmd = New SqlCommand
        'query = "insert into TicketPurchase(PurchaseID,MemberID,PegawaiID,Tanggal,QtyAdult,QtyChildren,PriceAdult,PriceChildren,total)values('" & ID & "','" & IDmember & "','" & IDpegawai & "','" & Tanggal.Text & "','" & QuantityAdult & "','" & QuantityChild & "','" & 0 & "','" & 0 & "','" & total.Text & "')"
        'cmd.Connection = conn
        'cmd.CommandText = query
        'cmd.ExecuteNonQuery()

        '  End If

        '  MsgBox("Berhasil")

        KonfirmasiTiket.Show()
        Me.Enabled = False


    End Sub

End Class