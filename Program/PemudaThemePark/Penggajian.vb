Imports System.Data.SqlClient
Public Class Penggajian
    Private Sub Report_Pembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        koneksi()
        tampilnama()


    End Sub
    Sub tampil()

        query = "select * from Pegawai where NamaPegawai='" & Nama.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)
        If table.Rows.Count <> 0 Then


            Dim IDpegawai As Integer
            IDpegawai = table.Rows(0)(0).ToString

            query = "select * from Bulanan where PegawaiID='" & IDpegawai & "' and Bulan='" & Bulan.Text & "'"
            DA = New SqlDataAdapter(query, conn)
            Dim t As New DataTable
            DA.Fill(t)

            If t.Rows.Count <> 0 Then

                Dim IDBulan As Integer
                IDBulan = t.Rows(0)(0).ToString

                absent.Text = t.Rows(0)(3).ToString
                Overtime.Text = t.Rows(0)(4).ToString
                late.Text = t.Rows(0)(5).ToString
                JumlahKerja.Text = t.Rows(0)(6).ToString

                query = "select * from Pembayaran where BulananID='" & IDBulan & "'"
                DA = New SqlDataAdapter(query, conn)
                Dim tab As New DataTable
                DA.Fill(tab)

                dailysalary.Text = tab.Rows(0)(1).ToString
                OTsalary.Text = tab.Rows(0)(2).ToString
                Latecharge.Text = tab.Rows(0)(4).ToString
                Bonus.Text = tab.Rows(0)(3).ToString
                total.Text = tab.Rows(0)(5).ToString

            Else

                absent.Text = ""
                Overtime.Text = ""
                late.Text = ""
                JumlahKerja.Text = ""
                dailysalary.Text = ""
                OTsalary.Text = ""
                Latecharge.Text = ""
                Bonus.Text = ""
                total.Text = ""

            End If
        End If


    End Sub
    Sub tampilnama()

        query = "select * from Pegawai where JabatanID='" & 2 & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)

        Nama.DataSource = table
        Nama.DisplayMember = "NamaPegawai"

    End Sub
    Sub JumlahAbsent()

        Dim jlhabsent As Integer

        Dim a As String
        a = "Absent"

        query = "select * from Pegawai where NamaPegawai='" & Nama.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim t As New DataTable
        DA.Fill(t)
        Dim namapegawai As String
        namapegawai = t.Rows(0)(0).ToString


        If Bulan.Text = "Januari" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & a & "' and Tanggal>='2019-01-01' and Tanggal<='2019-01-31'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhabsent = table.Rows.Count

        ElseIf Bulan.Text = "Febuari" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & a & "' and Tanggal>='2019-02-01' and Tanggal<='2019-02-28'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhabsent = table.Rows.Count

        ElseIf Bulan.Text = "Maret" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & a & "' and Tanggal>='2019-03-01' and Tanggal<='2019-03-31'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhabsent = table.Rows.Count

        ElseIf Bulan.Text = "April" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & a & "' and Tanggal>='2019-04-01' and Tanggal<='2019-04-30'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhabsent = table.Rows.Count

        ElseIf Bulan.Text = "Mei" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & a & "' and Tanggal>='2019-05-01' and Tanggal<='2019-05-31'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhabsent = table.Rows.Count

        ElseIf Bulan.Text = "Juni" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & a & "' and Tanggal>='2019-06-01' and Tanggal<='2019-06-30'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhabsent = table.Rows.Count

        ElseIf Bulan.Text = "Juli" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & a & "' and Tanggal>='2019-07-01' and Tanggal<='2019-07-31'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhabsent = table.Rows.Count

        ElseIf Bulan.Text = "Agustus" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & a & "' and Tanggal>='2019-08-01' and Tanggal<='2019-08-31'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhabsent = table.Rows.Count

        ElseIf Bulan.Text = "September" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & a & "' and Tanggal>='2019-09-01' and Tanggal<='2019-09-30'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhabsent = table.Rows.Count

        ElseIf Bulan.Text = "Oktober" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & a & "' and Tanggal>='2019-10-01' and Tanggal<='2019-10-31'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhabsent = table.Rows.Count

        ElseIf Bulan.Text = "November" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & a & "' and Tanggal>='2019-11-01' and Tanggal<='2019-11-30'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhabsent = table.Rows.Count

        ElseIf Bulan.Text = "Desember" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & a & "' and Tanggal>='2019-12-01' and Tanggal<='2019-12-31'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhabsent = table.Rows.Count

        End If

        absent.Text = jlhabsent

    End Sub
    Sub jumlahOvertime()

        Dim jlhOT As Integer

        Dim kategori As String
        kategori = "Overtime"

        query = "select * from Pegawai where NamaPegawai='" & Nama.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim t As New DataTable
        DA.Fill(t)
        Dim namapegawai As String
        namapegawai = t.Rows(0)(0).ToString


        If Bulan.Text = "Januari" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-01-01' and Tanggal<='2019-01-31'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhOT = table.Rows.Count

        ElseIf Bulan.Text = "Febuari" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-02-01' and Tanggal<='2019-02-28'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhOT = table.Rows.Count

        ElseIf Bulan.Text = "Maret" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-03-01' and Tanggal<='2019-03-31'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhOT = table.Rows.Count

        ElseIf Bulan.Text = "April" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-04-01' and Tanggal<='2019-04-30'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhOT = table.Rows.Count

        ElseIf Bulan.Text = "Mei" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-05-01' and Tanggal<='2019-05-31'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhOT = table.Rows.Count

        ElseIf Bulan.Text = "Juni" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-06-01' and Tanggal<='2019-06-30'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhOT = table.Rows.Count

        ElseIf Bulan.Text = "Juli" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-07-01' and Tanggal<='2019-07-31'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhOT = table.Rows.Count

        ElseIf Bulan.Text = "Agustus" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-08-01' and Tanggal<='2019-08-31'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhOT = table.Rows.Count

        ElseIf Bulan.Text = "September" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-09-01' and Tanggal<='2019-09-30'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhOT = table.Rows.Count

        ElseIf Bulan.Text = "Oktober" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-10-01' and Tanggal<='2019-10-31'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhOT = table.Rows.Count

        ElseIf Bulan.Text = "November" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-11-01' and Tanggal<='2019-11-30'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhOT = table.Rows.Count

        ElseIf Bulan.Text = "Desember" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-12-01' and Tanggal<='2019-12-31'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhOT = table.Rows.Count

        End If

        Overtime.Text = jlhOT

    End Sub
    Sub jumlahlate()

        Dim jlhLate As Integer

        Dim kategori As String
        kategori = "Late"

        query = "select * from Pegawai where NamaPegawai='" & Nama.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim t As New DataTable
        DA.Fill(t)
        Dim namapegawai As String
        namapegawai = t.Rows(0)(0).ToString


        If Bulan.Text = "Januari" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-01-01' and Tanggal<='2019-01-31'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhLate = table.Rows.Count

        ElseIf Bulan.Text = "Febuari" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-02-01' and Tanggal<='2019-02-28'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhLate = table.Rows.Count

        ElseIf Bulan.Text = "Maret" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-03-01' and Tanggal<='2019-03-31'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhLate = table.Rows.Count

        ElseIf Bulan.Text = "April" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-04-01' and Tanggal<='2019-04-30'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhLate = table.Rows.Count

        ElseIf Bulan.Text = "Mei" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-05-01' and Tanggal<='2019-05-31'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhLate = table.Rows.Count

        ElseIf Bulan.Text = "Juni" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-06-01' and Tanggal<='2019-06-30'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhLate = table.Rows.Count

        ElseIf Bulan.Text = "Juli" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-07-01' and Tanggal<='2019-07-31'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhLate = table.Rows.Count

        ElseIf Bulan.Text = "Agustus" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-08-01' and Tanggal<='2019-08-31'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhLate = table.Rows.Count

        ElseIf Bulan.Text = "September" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-09-01' and Tanggal<='2019-09-30'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhLate = table.Rows.Count

        ElseIf Bulan.Text = "Oktober" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-10-01' and Tanggal<='2019-10-31'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhLate = table.Rows.Count

        ElseIf Bulan.Text = "November" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-11-01' and Tanggal<='2019-11-30'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhLate = table.Rows.Count

        ElseIf Bulan.Text = "Desember" Then

            query = "select * from Attendance where PegawaiID='" & namapegawai & "' and Kehadiran='" & kategori & "' and Tanggal>='2019-12-01' and Tanggal<='2019-12-31'"
            DA = New SqlDataAdapter(query, conn)
            Dim table As New DataTable
            DA.Fill(table)
            jlhLate = table.Rows.Count

        End If

        late.Text = jlhLate

    End Sub
    Sub HitungDailySalary()

        Dim rate As Integer
        Dim tipe As String
        tipe = "Daily Salary"

        query = "select * from Gaji where TipeGaji='" & tipe & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)
        rate = table.Rows(0)(2).ToString

        Dim jlhkerja As Integer
        jlhkerja = JumlahKerja.Text - absent.Text

        Dim salary As Integer
        salary = jlhkerja * rate
        dailysalary.Text = salary

    End Sub
    Sub HitungOTSalary()

        Dim rate As Integer
        Dim tipe As String
        tipe = "Overtime Salary"

        query = "select * from Gaji where TipeGaji='" & tipe & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)
        rate = table.Rows(0)(2).ToString

        Dim salary As Integer
        salary = Overtime.Text * rate
        OTsalary.Text = salary


    End Sub
    Sub HitungMonthlyBonus()

        Dim rate As Integer
        Dim tipe As String
        tipe = "Monthly Bonus"

        query = "select * from Gaji where TipeGaji='" & tipe & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)
        rate = table.Rows(0)(2).ToString

        If absent.Text = 0 And late.Text = 0 Then

            Bonus.Text = rate

        End If

    End Sub
    Sub HitungLate()

        Dim rate As Integer
        Dim tipe As String
        tipe = "Late charge"

        query = "select * from Gaji where TipeGaji='" & tipe & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)
        rate = table.Rows(0)(2).ToString

        Dim charge As Integer
        charge = late.Text * rate
        Latecharge.Text = charge

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MenuUtama.Enabled = True
        Me.Close()


    End Sub

    Private Sub Bulan_TextChanged(sender As Object, e As EventArgs) Handles Bulan.TextChanged
        tampil()



    End Sub

    Private Sub Nama_TextChanged(sender As Object, e As EventArgs) Handles Nama.TextChanged
        tampil()

    End Sub

    Private Sub Cek_Click(sender As Object, e As EventArgs) Handles Cek.Click
        JumlahAbsent()
        jumlahOvertime()
        jumlahlate()
        HitungDailySalary()
        HitungOTSalary()
        HitungLate()


    End Sub

    Private Sub Hitung_Click(sender As Object, e As EventArgs) Handles Hitung.Click

        Dim hitung As Integer
        Dim daily As Integer = dailysalary.Text
        Dim OT As Integer = OTsalary.Text
        Dim Late As Integer = Latecharge.Text
        Dim B As Integer = Bonus.Text

        hitung = daily + OT - Late + B

        total.Text = hitung

    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click

        query = "select * from Pegawai where NamaPegawai='" & Nama.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)
        Dim IDpegawai As Integer
        IDpegawai = table.Rows(0)(0).ToString

        query = "select * from Bulanan"
        DA = New SqlDataAdapter(query, conn)
        Dim t As New DataTable
        DA.Fill(t)
        Dim IDBulanan As Integer

        If t.Rows.Count = 0 Then

            IDBulanan = 1

        Else

            query = "select top(1) BulananID from Bulanan order by BulananID desc"
            DA = New SqlDataAdapter(query, conn)
            Dim tbl As New DataTable
            DA.Fill(tbl)
            IDBulanan = tbl.Rows(0)(0).ToString
            IDBulanan = IDBulanan + 1

        End If


        cmd = New SqlCommand
        query = "insert into Bulanan(BulananID,PegawaiID,Bulan,JumlahAbsent,JumlahOvertime,JumlahLate,JumlahKerja)values('" & IDBulanan & "','" & IDpegawai & "','" & Bulan.Text & "','" & absent.Text & "','" & Overtime.Text & "','" & late.Text & "','" & JumlahKerja.Text & "')"
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.ExecuteNonQuery()


        query = "select * from Pembayaran"
        DA = New SqlDataAdapter(query, conn)
        Dim tab As New DataTable
        DA.Fill(tab)
        Dim IDPembayaran As Integer

        If tab.Rows.Count = 0 Then

            IDPembayaran = 1

        Else

            query = "select top(1) PembayaranID from Pembayaran order by PembayaranID desc"
            DA = New SqlDataAdapter(query, conn)
            Dim tabel As New DataTable
            DA.Fill(tabel)
            IDPembayaran = tabel.Rows(0)(0).ToString
            IDPembayaran = IDPembayaran + 1

        End If


        cmd = New SqlCommand
        query = "insert into Pembayaran(PembayaranID,BulananID,TotalDailySalary,TotalOvertimeSalary,MonthlyBonus,TotalLateCharge,TotalSalary)values
                ('" & IDPembayaran & "','" & IDBulanan & "','" & dailysalary.Text & "','" & OTsalary.Text & "','" & Bonus.Text & "','" & Latecharge.Text & "','" & total.Text & "')"
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.ExecuteNonQuery()

        MsgBox("Berhasil Save")



    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click

        query = "select * from Pegawai where NamaPegawai='" & Nama.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)
        If table.Rows.Count <> 0 Then


            Dim IDpegawai As Integer
            IDpegawai = table.Rows(0)(0).ToString

            query = "select * from Bulanan where PegawaiID='" & IDpegawai & "' and Bulan='" & Bulan.Text & "'"
            DA = New SqlDataAdapter(query, conn)
            Dim t As New DataTable
            DA.Fill(t)

            If t.Rows.Count <> 0 Then

                Dim IDBulan As Integer
                IDBulan = t.Rows(0)(0).ToString

                query = "select * from Pembayaran where BulananID='" & IDBulan & "'"
                DA = New SqlDataAdapter(query, conn)
                Dim tab As New DataTable
                DA.Fill(tab)
                Dim ID As Integer
                ID = tab.Rows(0)(0).ToString


                cmd = New SqlCommand
                query = "delete from Bulanan where BulananID='" & IDBulan & "'"
                cmd.Connection = conn
                cmd.CommandText = query
                cmd.ExecuteNonQuery()


                cmd = New SqlCommand
                query = "delete from Pembayaran where PembayaranID='" & ID & "'"
                cmd.Connection = conn
                cmd.CommandText = query
                cmd.ExecuteNonQuery()


                MsgBox("Berhasil Delete")

                absent.Text = ""
                Overtime.Text = ""
                late.Text = ""
                JumlahKerja.Text = ""
                dailysalary.Text = ""
                OTsalary.Text = ""
                Latecharge.Text = ""
                Bonus.Text = ""
                total.Text = ""

            End If
        End If


    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click

        query = "select * from Pegawai where NamaPegawai='" & Nama.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)
        If table.Rows.Count <> 0 Then

            Dim IDpegawai As Integer
            IDpegawai = table.Rows(0)(0).ToString

            query = "select * from Bulanan where PegawaiID='" & IDpegawai & "' and Bulan='" & Bulan.Text & "'"
            DA = New SqlDataAdapter(query, conn)
            Dim t As New DataTable
            DA.Fill(t)

            If t.Rows.Count <> 0 Then

                Dim IDBulan As Integer
                IDBulan = t.Rows(0)(0).ToString

                query = "select * from Pembayaran where BulananID='" & IDBulan & "'"
                DA = New SqlDataAdapter(query, conn)
                Dim tab As New DataTable
                DA.Fill(tab)
                Dim ID As Integer
                ID = tab.Rows(0)(0).ToString


                cmd = New SqlCommand
                query = "update Bulanan set JumlahKerja='" & JumlahKerja.Text & "' where BulananID='" & IDBulan & "'"
                cmd.Connection = conn
                cmd.CommandText = query
                cmd.ExecuteNonQuery()


                cmd = New SqlCommand
                query = "update Pembayaran set TotalDailySalary='" & dailysalary.Text & "', MonthlyBonus='" & Bonus.Text & "',TotalSalary='" & total.Text & "' where PembayaranID='" & ID & "'"
                cmd.Connection = conn
                cmd.CommandText = query
                cmd.ExecuteNonQuery()

                MsgBox("Berhasil Edit")
                tampil()


            End If
        End If


    End Sub
End Class