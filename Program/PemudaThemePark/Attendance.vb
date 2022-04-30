Imports System.Data.SqlClient
Public Class Attendance
    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampil()


    End Sub
    Sub tampil()

        query = "select Attendance.Tanggal,Jadwal.Shiftt,Pegawai.NamaPegawai, Attendance.Kehadiran from Attendance
                join Jadwal on Jadwal.JadwalID=Attendance.JadwalID
                join Pegawai on Pegawai.PegawaiID=Attendance.PegawaiID
                where Attendance.Tanggal='" & DateTimePicker1.Value & "'"
        DA = New SqlDataAdapter(query, conn)
        DS = New DataSet
        DA.Fill(DS)

        DataGridView1.DataSource = DS.Tables(0)

    End Sub
    Sub tampilnama()

        query = "select Pegawai.NamaPegawai, GameShift.Tanggal, Jadwal.Shiftt from GameShift
                join Pegawai on Pegawai.PegawaiID=GameShift.PegawaiID
                join Jadwal on Jadwal.JadwalID=GameShift.JadwalID
                where Gameshift.Tanggal='" & DateTimePicker1.Value & "' and Jadwal.shiftt='" & shift.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)

        nama.DataSource = table
        nama.DisplayMember = "NamaPegawai"

        If table.Rows.Count = 0 Then

            nama.Text = ""

        End If

    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click

        query = "select * from Attendance"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)
        Dim ID As Integer


        If table.Rows.Count = 0 Then

            ID = 1

        Else

            query = "select top(1) AttendanceID from Attendance order by AttendanceID desc"
            DA = New SqlDataAdapter(query, conn)
            Dim t As New DataTable
            DA.Fill(t)

            ID = t.Rows(0)(0).ToString

            ID = ID + 1

        End If


        query = "select * from Pegawai where NamaPegawai='" & nama.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim tabel As New DataTable
        DA.Fill(tabel)
        Dim IDpegawai As Integer
        IDpegawai = tabel.Rows(0)(0).ToString



        query = "select * from Jadwal where Shiftt='" & shift.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim tbl As New DataTable
        DA.Fill(tbl)
        Dim IDJadwal As Integer
        IDJadwal = tbl.Rows(0)(0).ToString


        If ontime.Checked = True Then

            cmd = New SqlCommand
            query = "insert into Attendance(AttendanceID,PegawaiID,JadwalID,Tanggal,Kehadiran)values('" & ID & "','" & IDpegawai & "','" & IDJadwal & "','" & DateTimePicker1.Value & "','" & ontime.Text & "')"
            cmd.Connection = conn
            cmd.CommandText = query
            cmd.ExecuteNonQuery()

            If overtime.Checked Then

                ID = ID + 1

                cmd = New SqlCommand
                query = "insert into Attendance(AttendanceID,PegawaiID,JadwalID,Tanggal,Kehadiran)values('" & ID & "','" & IDpegawai & "','" & IDJadwal & "','" & DateTimePicker1.Value & "','" & overtime.Text & "')"
                cmd.Connection = conn
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

            End If

        ElseIf late.Checked = True Then

            cmd = New SqlCommand
            query = "insert into Attendance(AttendanceID,PegawaiID,JadwalID,Tanggal,Kehadiran)values('" & ID & "','" & IDpegawai & "','" & IDJadwal & "','" & DateTimePicker1.Value & "','" & late.Text & "')"
            cmd.Connection = conn
            cmd.CommandText = query
            cmd.ExecuteNonQuery()

            If overtime.Checked Then

                ID = ID + 1

                cmd = New SqlCommand
                query = "insert into Attendance(AttendanceID,PegawaiID,JadwalID,Tanggal,Kehadiran)values('" & ID & "','" & IDpegawai & "','" & IDJadwal & "','" & DateTimePicker1.Value & "','" & overtime.Text & "')"
                cmd.Connection = conn
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

            End If

        ElseIf absent.Checked = True Then

            cmd = New SqlCommand
            query = "insert into Attendance(AttendanceID,PegawaiID,JadwalID,Tanggal,Kehadiran)values('" & ID & "','" & IDpegawai & "','" & IDJadwal & "','" & DateTimePicker1.Value & "','" & absent.Text & "')"
            cmd.Connection = conn
            cmd.CommandText = query
            cmd.ExecuteNonQuery()

        ElseIf overtime.Checked = True Then

            cmd = New SqlCommand
            query = "insert into Attendance(AttendanceID,PegawaiID,JadwalID,Tanggal,Kehadiran)values('" & ID & "','" & IDpegawai & "','" & IDJadwal & "','" & DateTimePicker1.Value & "','" & overtime.Text & "')"
            cmd.Connection = conn
            cmd.CommandText = query
            cmd.ExecuteNonQuery()

        End If

        MsgBox("Berhasil")
        tampil()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MenuUtama.Enabled = True
        Me.Close()

    End Sub

    Private Sub Hari_TextChanged(sender As Object, e As EventArgs)
        tampilnama()

    End Sub

    Private Sub shift_TextChanged(sender As Object, e As EventArgs) Handles shift.TextChanged
        tampilnama()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

        tampil()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        shift.Text = DataGridView1.Item(1, i).Value
        nama.Text = DataGridView1.Item(2, i).Value

        Dim kehadiran As String

        kehadiran = DataGridView1.Item(3, i).Value

        If kehadiran = "On-Time" Then

            ontime.Checked = True
            late.Checked = False
            absent.Checked = False
            overtime.Checked = False

        ElseIf kehadiran = "Late" Then

            ontime.Checked = False
            late.Checked = True
            absent.Checked = False
            overtime.Checked = False

        ElseIf kehadiran = "Absent" Then

            ontime.Checked = False
            late.Checked = False
            absent.Checked = True
            overtime.Checked = False

        ElseIf kehadiran = "Overtime" Then

            ontime.Checked = False
            late.Checked = False
            absent.Checked = False
            overtime.Checked = True

        End If

        query = "select * from Jadwal where Shiftt='" & shift.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)
        Dim IDjadwal As Integer
        IDjadwal = table.Rows(0)(0).ToString

        query = "select * from Pegawai where NamaPegawai='" & nama.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim tabel As New DataTable
        DA.Fill(tabel)
        Dim IDPegawai As Integer
        IDPegawai = tabel.Rows(0)(0).ToString

        query = "select * from Attendance where PegawaiID='" & IDPegawai & "' and JadwalID='" & IDjadwal & "' and Tanggal='" & DateTimePicker1.Value & "' and Kehadiran='" & kehadiran & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim tbl As New DataTable
        DA.Fill(tbl)
        AttendanceID = tbl.Rows(0)(0).ToString


    End Sub

    Private Sub updet_Click(sender As Object, e As EventArgs) Handles updet.Click

        query = "select * from Jadwal where Shiftt='" & shift.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)
        Dim IDjadwal As Integer
        IDjadwal = table.Rows(0)(0).ToString

        query = "select * from Pegawai where NamaPegawai='" & nama.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim tabel As New DataTable
        DA.Fill(tabel)
        Dim IDPegawai As Integer
        IDPegawai = tabel.Rows(0)(0).ToString

        Dim kehadiran As String
        kehadiran = "a"

        If ontime.Checked = True Then

            kehadiran = "On-Time"

        ElseIf late.Checked = True Then

            kehadiran = "Late"

        ElseIf absent.Checked = True Then

            kehadiran = "Absent"

        ElseIf overtime.Checked = True Then

            kehadiran = "Overtime"

        End If

        cmd = New SqlCommand
        query = "update Attendance set PegawaiID='" & IDPegawai & "', JadwalID='" & IDjadwal & "', Kehadiran='" & kehadiran & "' where AttendanceID='" & AttendanceID & "'"
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.ExecuteNonQuery()

        MsgBox("Berhasil Update")
        tampil()


    End Sub
End Class