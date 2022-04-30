Imports System.Data.SqlClient
Public Class Report_Gaji
    Private Sub Report_Gaji_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampil()
        tampilrekap()
        grafik()


    End Sub
    Sub tampil()

        query = "select Pegawai.NamaPegawai,Bulanan.JumlahAbsent, Bulanan.JumlahOvertime, Bulanan.JumlahLate, Pembayaran.TotalDailysalary, Pembayaran.TotalOvertimeSalary, Pembayaran.MonthlyBonus, Pembayaran.TotalLateCharge, Pembayaran.TotalSalary from Pembayaran
                join Bulanan on Bulanan.BulananID=Pembayaran.BulananID
                join Pegawai on Pegawai.PegawaiID=Bulanan.PegawaiID
                where Bulanan.Bulan='" & Bulan.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)


    End Sub
    Sub tampilrekap()

        query = "select Bulan, Gaji from RekapGaji"
        DA = New SqlDataAdapter(query, conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView2.DataSource = DS.Tables(0)

    End Sub
    Sub grafik()

        query = "select Bulan, Gaji from RekapGaji"
        DA = New SqlDataAdapter(query, conn)
        Dim tabel As New DataTable
        DA.Fill(tabel)

        Chart1.DataSource = tabel
        'Chart1.DataSource = DataGridView2.DataSource

        Chart1.Series("Gaji").XValueMember = "Bulan"
        Chart1.Series("Gaji").YValueMembers = "Gaji"

        ' Chart1.Series("Gaji").XValueMember = DataGridView2.Columns(0).ToString

        ' Chart1.Series("Gaji").YValueMembers = DataGridView2.Columns(1).ToString

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MenuUtama.Enabled = True
        Me.Close()

    End Sub

    Private Sub Bulan_TextChanged(sender As Object, e As EventArgs) Handles Bulan.TextChanged
        tampil()

        query = "select sum(Pembayaran.TotalSalary) from Pembayaran
                join Bulanan on Bulanan.BulananID=Pembayaran.BulananID
                join Pegawai on Pegawai.PegawaiID=Bulanan.PegawaiID
                where Bulanan.Bulan='" & Bulan.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)
        total.Text = table.Rows(0)(0).ToString


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Dim ID As Integer

        If Bulan.Text = "Januari" Then

            ID = 1

        ElseIf Bulan.Text = "Febuari" Then

            ID = 2

        ElseIf Bulan.Text = "Maret" Then

            ID = 3

        ElseIf Bulan.Text = "April" Then

            ID = 4

        ElseIf Bulan.Text = "Mei" Then

            ID = 5

        ElseIf Bulan.Text = "Juni" Then

            ID = 6

        ElseIf Bulan.Text = "Juli" Then

            ID = 7

        ElseIf Bulan.Text = "Agustus" Then

            ID = 8

        ElseIf Bulan.Text = "September" Then

            ID = 9

        ElseIf Bulan.Text = "Oktober" Then

            ID = 10

        ElseIf Bulan.Text = "November" Then

            ID = 11

        ElseIf Bulan.Text = "Desember" Then

            ID = 12

        End If



        query = "select * from RekapGaji where Bulan='" & Bulan.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim tbl As New DataTable
        DA.Fill(tbl)

        If tbl.Rows.Count = 0 Then

            cmd = New SqlCommand
            query = "insert into RekapGaji(RekapID,Bulan,Gaji)values('" & ID & "','" & Bulan.Text & "','" & total.Text & "')"
            cmd.Connection = conn
            cmd.CommandText = query
            cmd.ExecuteNonQuery()

        Else

            cmd = New SqlCommand
            query = "update RekapGaji set Gaji='" & total.Text & "' where Bulan='" & Bulan.Text & "'"
            cmd.Connection = conn
            cmd.CommandText = query
            cmd.ExecuteNonQuery()

        End If


        MsgBox("Selesai")
        tampilrekap()
        grafik()


    End Sub
End Class