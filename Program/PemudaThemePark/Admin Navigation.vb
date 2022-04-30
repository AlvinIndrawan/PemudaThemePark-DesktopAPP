Public Class Admin_Navigation
    Private Sub Admin_Navigation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

    End Sub

    Private Sub ChangePassword_Click(sender As Object, e As EventArgs) Handles ChangePassword.Click

        change_Password.Show()
        Me.Hide()


    End Sub

    Private Sub Games_Click(sender As Object, e As EventArgs) Handles Games.Click

        ManageGames.Show()
        Me.Hide()

    End Sub

    Private Sub Pegawai_Click(sender As Object, e As EventArgs) Handles Pegawai.Click

        ManagePegawai.Show()
        Me.Hide()

    End Sub

    Private Sub Membership_Click(sender As Object, e As EventArgs) Handles Membership.Click

        MembershipPlan.Show()
        Me.Hide()

    End Sub

    Private Sub Gaji_Click(sender As Object, e As EventArgs) Handles BtnGaji.Click

        ManageGaji.Show()
        Me.Hide()

    End Sub

    Private Sub Jadwal_Click(sender As Object, e As EventArgs) Handles BtnJadwal.Click

        Jadwal.Show()
        Me.Hide()


    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Login.Show()
        Me.Hide()

        Login.Username.Text = ""
        Login.Pasword.Text = ""

    End Sub

    Private Sub tiket_Click(sender As Object, e As EventArgs) Handles tiket.Click

        Ticket.Show()
        Me.Hide()


    End Sub

    Private Sub Attendancee_Click(sender As Object, e As EventArgs) Handles Attendancee.Click

        Attendance.Show()
        Me.Hide()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Penggajian.Show()
        Me.Hide()


    End Sub
End Class