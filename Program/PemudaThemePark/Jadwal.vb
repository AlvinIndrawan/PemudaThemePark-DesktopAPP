Imports System.Data.SqlClient
Public Class Jadwal
    Private Sub Jadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampil()
        TampilNama()
        TampilGame()


    End Sub
    Sub tampil()

        query = "select Gameshift.Tanggal,Jadwal.shiftt, Pegawai.NamaPegawai,Games.NamaGame from GameShift
                join Jadwal on Jadwal.JadwalID=GameShift.JadwalID
                join Pegawai on Pegawai.PegawaiID=GameShift.PegawaiID
                join Games on Games.GamesID=GameShift.GamesID"
        DA = New SqlDataAdapter(query, conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)

    End Sub
    Sub TampilNama()

        query = "select * from Pegawai where JabatanID=2"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)

        Nama.DataSource = table
        Nama.DisplayMember = "NamaPegawai"

    End Sub
    Sub TampilGame()

        query = "select * from Games"
        DA = New SqlDataAdapter(query, conn)
        Dim t As New DataTable
        DA.Fill(t)

        Game.DataSource = t
        Game.DisplayMember = "NamaGame"

    End Sub

    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click

        query = "select * from Jadwal where Shiftt='" & Shift.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim t As New DataTable
        DA.Fill(t)
        Dim IDJadwal As Integer
        IDJadwal = t.Rows(0)(0).ToString

        query = "select * from Pegawai where NamaPegawai='" & Nama.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)
        Dim IdPegawai As Integer
        IdPegawai = table.Rows(0)(0).ToString

        query = "select * from Games where NamaGame='" & Game.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim tabel As New DataTable
        DA.Fill(tabel)
        Dim IDGame As Integer
        IDGame = tabel.Rows(0)(0).ToString



        query = "select * from GameShift"
        DA = New SqlDataAdapter(query, conn)
        Dim tbl As New DataTable
        DA.Fill(tbl)
        Dim IDGameShift As Integer

        If tbl.Rows.Count = 0 Then
            IDGameShift = 1
        Else

            query = "select top(1) ShiftID from GameShift order by ShiftID desc"
            DA = New SqlDataAdapter(query, conn)
            Dim ID As New DataTable
            DA.Fill(ID)
            IDGameShift = ID.Rows(0)(0).ToString
            IDGameShift = IDGameShift + 1

        End If

        cmd = New SqlCommand
        query = "insert into GameShift(ShiftID,GamesID,PegawaiID,JadwalID,Tanggal)values('" & IDGameShift & "','" & IDGame & "','" & IdPegawai & "','" & IDJadwal & "','" & DateTimePicker1.Value & "')"
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.ExecuteNonQuery()

        MsgBox("Berhasil Insert")
        tampil()

        Shift.Text = ""
        Nama.Text = ""
        Game.Text = ""

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        DateTimePicker1.Text = DataGridView1.Item(0, i).Value
        Shift.Text = DataGridView1.Item(1, i).Value
        Nama.Text = DataGridView1.Item(2, i).Value
        Game.Text = DataGridView1.Item(3, i).Value

        query = "select * from Pegawai where NamaPegawai='" & Nama.Text & "' "
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)
        Dim IDpegawai As Integer
        IDpegawai = table.Rows(0)(0).ToString

        query = "select * from Jadwal where Shiftt='" & Shift.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim t As New DataTable
        DA.Fill(t)
        Dim IDjadwal As Integer
        IDjadwal = t.Rows(0)(0).ToString

        query = "select * from Games where NamaGame='" & Game.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim tbel As New DataTable
        DA.Fill(tbel)
        Dim IDgame As Integer
        IDgame = tbel.Rows(0)(0).ToString


        query = "select * from GameShift where PegawaiID='" & IDpegawai & "' and JadwalID='" & IDjadwal & "' and GamesID='" & IDgame & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim tbl As New DataTable
        DA.Fill(tbl)
        GameShiftID = tbl.Rows(0)(0).ToString


    End Sub

    Private Sub Updet_Click(sender As Object, e As EventArgs) Handles Updet.Click

        query = "select * from Pegawai where NamaPegawai='" & Nama.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)
        Dim IDPegawai As Integer
        IDPegawai = table.Rows(0)(0).ToString

        query = "select * from Jadwal where Shiftt='" & Shift.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim t As New DataTable
        DA.Fill(t)
        Dim IDjadwal As Integer
        IDjadwal = t.Rows(0)(0).ToString

        query = "select * from Games where NamaGame='" & Game.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim tabell As New DataTable
        DA.Fill(tabell)
        Dim IDgame As Integer
        IDgame = tabell.Rows(0)(0).ToString


        cmd = New SqlCommand
        query = "update GameShift set GamesID='" & IDgame & "', PegawaiID='" & IDPegawai & "', JadwalID='" & IDjadwal & "',Tanggal='" & DateTimePicker1.Value & "' where ShiftID='" & GameShiftID & "'"
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.ExecuteNonQuery()

        MsgBox("Berhasil Update")
        tampil()

        Shift.Text = ""
        Nama.Text = ""
        Game.Text = ""


    End Sub

    Private Sub Delet_Click(sender As Object, e As EventArgs) Handles Delet.Click

        query = "select * from Pegawai where NamaPegawai='" & Nama.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)
        Dim IDpegawai As Integer
        IDpegawai = table.Rows(0)(0).ToString

        query = "select * from Jadwal where Shiftt='" & Shift.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim t As New DataTable
        DA.Fill(t)
        Dim IDjadwal As Integer
        IDjadwal = t.Rows(0)(0).ToString

        query = "select * from Games where NamaGame='" & Game.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim tabell As New DataTable
        DA.Fill(tabell)
        Dim IDgame As Integer
        IDgame = tabell.Rows(0)(0).ToString

        query = "select * from GameShift where GamesID='" & IDgame & "' and PegawaiID='" & IDpegawai & "' and JadwalID='" & IDjadwal & "' and Tanggal='" & DateTimePicker1.Value & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim tbl As New DataTable
        DA.Fill(tbl)
        Dim ID As Integer
        ID = tbl.Rows(0)(0).ToString


        cmd = New SqlCommand
        query = "delete from GameShift where ShiftID='" & ID & "'"
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.ExecuteNonQuery()

        MsgBox("Berhasil Delete")
        tampil()

        Shift.Text = ""
        Nama.Text = ""
        Game.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MenuUtama.Enabled = True
        Me.Close()


    End Sub
End Class