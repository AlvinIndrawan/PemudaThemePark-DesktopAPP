Imports System.Data.SqlClient
Public Class Lihat_jadwal
    Private Sub Lihat_jadwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampil()

    End Sub
    Sub tampil()

        Dim awal As Date
        Dim akhir As Date

        If Bulan.Text = "Januari" Then

            awal = "2019-01-01"
            akhir = "2019-01-31"

        ElseIf Bulan.Text = "Febuari" Then

            awal = "2019-02-01"
            akhir = "2019-02-28"

        ElseIf Bulan.Text = "Maret" Then

            awal = "2019-03-01"
            akhir = "2019-03-31"

        ElseIf Bulan.Text = "April" Then

            awal = "2019-04-01"
            akhir = "2019-04-30"

        ElseIf Bulan.Text = "Mei" Then

            awal = "2019-05-01"
            akhir = "2019-05-31"

        ElseIf Bulan.Text = "Juni" Then

            awal = "2019-06-01"
            akhir = "2019-06-30"

        ElseIf Bulan.Text = "Juli" Then

            awal = "2019-07-01"
            akhir = "2019-07-31"

        ElseIf Bulan.Text = "Agustus" Then

            awal = "2019-08-01"
            akhir = "2019-08-31"

        ElseIf Bulan.Text = "September" Then

            awal = "2019-09-01"
            akhir = "2019-09-30"

        ElseIf Bulan.Text = "Oktober" Then

            awal = "2019-10-01"
            akhir = "2019-10-31"

        ElseIf Bulan.Text = "November" Then

            awal = "2019-11-01"
            akhir = "2019-11-30"

        ElseIf Bulan.Text = "Desember" Then

            awal = "2019-12-01"
            akhir = "2019-12-31"

        End If

        query = "select GameShift.Tanggal, Jadwal.shiftt, Pegawai.NamaPegawai,Games.NamaGame from GameShift
                join Jadwal on Jadwal.JadwalID=GameShift.JadwalID
                join Pegawai on Pegawai.PegawaiID=GameShift.PegawaiID
                join Games on Games.GamesID=GameShift.GamesID
                where GameShift.Tanggal>='" & awal & "' and GameShift.Tanggal<='" & akhir & "'"
        DA = New SqlDataAdapter(query, conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MenuUtama.Enabled = True
        Me.Close()


    End Sub

    Private Sub Bulan_TextChanged(sender As Object, e As EventArgs) Handles Bulan.TextChanged

        tampil()


    End Sub
End Class