Imports System.Data.SqlClient
Public Class PegawaiNavigation
    Private Sub PegawaiNavigation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

        query = "select * from Pegawai where Username='" & Login.Username.Text & "'and Pasword='" & Login.Pasword.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)
        Nama.Text = table.Rows(0)(1).ToString()

    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click

        Login.Username.Text = ""
        Login.Pasword.Text = ""

        Login.Show()
        Me.Hide()
    End Sub

    Private Sub ChangePassword_Click(sender As Object, e As EventArgs) Handles ChangePassword.Click

        change_Password.Show()
        Me.Hide()

    End Sub

    Private Sub JoinMember_Click(sender As Object, e As EventArgs) Handles JoinMemberr.Click
        JoinMember.Show()
        Me.Hide()

    End Sub

    Private Sub TicketPurchase_Click(sender As Object, e As EventArgs) Handles pesantiket.Click

        TicketPurchase.Show()
        Me.Hide()


    End Sub

    Private Sub Jadwal_Click(sender As Object, e As EventArgs) Handles Jadwal.Click

        Lihat_jadwal.Show()
        Me.Hide()


    End Sub
End Class