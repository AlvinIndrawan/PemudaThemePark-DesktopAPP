Imports System.Data.SqlClient
Public Class KonfirmasiTiket
    Private Sub KonfirmasiTiket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tanggal()
        Pegawai()
        tampilhari()
        QtyChild()
        QtyAdultt()
        totall()

        If TicketPurchase.CheckBox1.Checked = True And TicketPurchase.CheckBox2.Checked = True Then

            If TicketPurchase.kategorimember.Text = "Adult" Then

                QtyAdult.Text = QtyAdult.Text + 1

            ElseIf TicketPurchase.kategorimember.Text = "Children" Then

                QtyChildren.Text = QtyChildren.Text + 1

            End If

        ElseIf TicketPurchase.CheckBox1.Checked = True And TicketPurchase.CheckBox2.Checked = False Then

            If TicketPurchase.kategorimember.Text = "Adult" Then

                QtyAdult.Text = 1
                QtyChildren.Text = 0

            ElseIf TicketPurchase.kategorimember.Text = "Children" Then

                QtyAdult.Text = 0
                QtyChildren.Text = 1

            End If

        End If



    End Sub
    Sub tanggal()

        Dim tanggal As Date
        tanggal = Now.Date
        Tgl.Text = tanggal

    End Sub
    Sub Pegawai()

        NamaPegawai.Text = TicketPurchase.Nama.Text

    End Sub
    Sub tampilhari()

        Hari.Text = TicketPurchase.Hari.Text

    End Sub
    Sub QtyChild()

        QtyChildren.Text = TicketPurchase.QtyChildren.Text

    End Sub
    Sub QtyAdultt()

        QtyAdult.Text = TicketPurchase.QtyAdult.Text

    End Sub
    Sub totall()

        Total.Text = TicketPurchase.total.Text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TicketPurchase.Enabled = True
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        query = "select * from TicketPurchase"
        DA = New SqlDataAdapter(query, conn)
        Dim tbl As New DataTable
        DA.Fill(tbl)
        Dim ID As Integer

        If tbl.Rows.Count = 0 Then

            ID = 1

        Else

            query = "select top(1) PurchaseID from TicketPurchase order by PurchaseID desc"
            DA = New SqlDataAdapter(query, conn)
            Dim tabell As New DataTable
            DA.Fill(tabell)
            ID = tabell.Rows(0)(0).ToString
            ID = ID + 1

        End If


        query = "select * from Pegawai where NamaPegawai='" & TicketPurchase.Nama.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)
        Dim IDpegawai As Integer
        IDpegawai = table.Rows(0)(0).ToString


        If TicketPurchase.CheckBox1.Checked = True And TicketPurchase.CheckBox2.Checked = True Then

            query = "select * from Member where NamaMember='" & MemberName & "'"
            DA = New SqlDataAdapter(query, conn)
            Dim tbel As New DataTable
            DA.Fill(tbel)
            Dim IDmember As Integer
            IDmember = tbel.Rows(0)(0).ToString


            Dim PriceA As Integer
            Dim PriceC As Integer
            PriceA = TicketPurchase.QtyAdult.Text * TicketPurchase.PriceAdult.Text
            PriceC = TicketPurchase.QtyChildren.Text * TicketPurchase.PriceChildren.Text

            cmd = New SqlCommand
            query = "insert into TicketPurchase(PurchaseID,MemberID,PegawaiID,Tanggal,QtyAdult,QtyChildren,PriceAdult,PriceChildren,total)
            values('" & ID & "','" & IDmember & "','" & IDpegawai & "','" & TicketPurchase.Tanggal.Text & "','" & QtyAdult.Text & "','" & QtyChildren.Text & "','" & PriceA & "','" & PriceC & "','" & Total.Text & "')"
            cmd.Connection = conn
            cmd.CommandText = query
            cmd.ExecuteNonQuery()

        ElseIf TicketPurchase.CheckBox1.Checked = False And TicketPurchase.CheckBox2.Checked = True Then

            Dim PriceA As Integer
            Dim PriceC As Integer
            PriceA = TicketPurchase.QtyAdult.Text * TicketPurchase.PriceAdult.Text
            PriceC = TicketPurchase.QtyChildren.Text * TicketPurchase.PriceChildren.Text

            cmd = New SqlCommand
            query = "insert into TicketPurchase(PurchaseID,PegawaiID,Tanggal,QtyAdult,QtyChildren,PriceAdult,PriceChildren,total)
            values('" & ID & "','" & IDpegawai & "','" & TicketPurchase.Tanggal.Text & "','" & QtyAdult.Text & "','" & QtyChildren.Text & "','" & PriceA & "','" & PriceC & "','" & Total.Text & "')"
            cmd.Connection = conn
            cmd.CommandText = query
            cmd.ExecuteNonQuery()

        ElseIf TicketPurchase.CheckBox1.Checked = True And TicketPurchase.CheckBox2.Checked = False Then

            query = "select * from Member where NamaMember='" & MemberName & "'"
            DA = New SqlDataAdapter(query, conn)
            Dim tabl As New DataTable
            DA.Fill(tabl)
            Dim IDmember As Integer
            IDmember = tabl.Rows(0)(0).ToString


            Dim QuantityAdult As Integer
            Dim QuantityChild As Integer

            If TicketPurchase.kategorimember.Text = "Adult" Then

                QuantityAdult = 1
                QuantityChild = 0

            Else

                QuantityAdult = 0
                QuantityChild = 1

            End If

            cmd = New SqlCommand
            query = "insert into TicketPurchase(PurchaseID,MemberID,PegawaiID,Tanggal,QtyAdult,QtyChildren,PriceAdult,PriceChildren,total)values('" & ID & "','" & IDmember & "','" & IDpegawai & "','" & TicketPurchase.Tanggal.Text & "','" & QuantityAdult & "','" & QuantityChild & "','" & 0 & "','" & 0 & "','" & Total.Text & "')"
            cmd.Connection = conn
            cmd.CommandText = query
            cmd.ExecuteNonQuery()

        End If

        MsgBox("Berhasil")
        TicketPurchase.Enabled = True
        Me.Close()

    End Sub
End Class