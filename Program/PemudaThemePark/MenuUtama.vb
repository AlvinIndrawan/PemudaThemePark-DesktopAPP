Imports System.Data.SqlClient
Public Class MenuUtama
    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

    End Sub

    Private Sub ManageGajiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageGajiToolStripMenuItem.Click

        ManageGaji.Show()
        Me.Enabled = False

    End Sub

    Private Sub ManagePegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagePegawaiToolStripMenuItem.Click

        ManagePegawai.Show()
        Me.Enabled = False

    End Sub

    Private Sub PenggajianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenggajianToolStripMenuItem.Click

        Penggajian.Show()
        Me.Enabled = False

    End Sub

    Private Sub ReportGajiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportGajiToolStripMenuItem.Click

        Report_Gaji.Show()
        Me.Enabled = False

    End Sub

    Private Sub BuatJadwalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuatJadwalToolStripMenuItem.Click

        Jadwal.Show()
        Me.Enabled = False

    End Sub

    Private Sub LihatJadwalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatJadwalToolStripMenuItem.Click

        Lihat_jadwal.Show()
        Me.Enabled = False

    End Sub

    Private Sub KehadiranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KehadiranToolStripMenuItem.Click

        Attendance.Show()
        Me.Enabled = False

    End Sub

    Private Sub MembershipPlanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MembershipPlanToolStripMenuItem.Click

        MembershipPlan.Show()
        Me.Enabled = False

    End Sub

    Private Sub JoinMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JoinMemberToolStripMenuItem.Click

        JoinMember.Show()
        Me.Enabled = False

    End Sub

    Private Sub ManageTicketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageTicketToolStripMenuItem.Click

        Ticket.Show()
        Me.Enabled = False

    End Sub

    Private Sub TicketPurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TicketPurchaseToolStripMenuItem.Click

        TicketPurchase.Show()
        Me.Enabled = False

    End Sub

    Private Sub ManageGamesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageGamesToolStripMenuItem.Click

        ManageGames.Show()
        Me.Enabled = False

    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem1.Click

        Login.Username.Text = ""
        Login.Pasword.Text = ""


        Me.Close()
        Login.Show()

    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click

        change_Password.Show()
        Me.Enabled = False

    End Sub

    Private Sub KepegawaianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KepegawaianToolStripMenuItem.Click

    End Sub
End Class