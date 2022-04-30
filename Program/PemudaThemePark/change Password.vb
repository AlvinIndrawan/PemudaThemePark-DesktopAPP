Imports System.Data.SqlClient
Public Class change_Password
    Private Sub change_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click

        If OldPassword.Text = "" Then
            MsgBox("Masukkan Old Password", MsgBoxStyle.Critical)
        ElseIf NewPasword.Text = "" Then
            MsgBox("Masukkan New Password", MsgBoxStyle.Critical)
        ElseIf ConfirmPassword.Text = "" Then
            MsgBox("Masukkan Confirm Password", MsgBoxStyle.Critical)
        Else

            If OldPassword.Text <> Login.Pasword.Text Then
                MsgBox("Old Password salah", MsgBoxStyle.Critical)
            ElseIf NewPasword.Text = OldPassword.Text Then
                MsgBox("New Password tidak boleh sama", MsgBoxStyle.Critical)
            ElseIf ConfirmPassword.Text <> NewPasword.Text Then
                MsgBox("Confirm Password salah", MsgBoxStyle.Critical)
            Else

                cmd = New SqlCommand
                cmd.Connection = conn
                query = "update Pegawai set Pasword='" & ConfirmPassword.Text & "' where Username='" & Login.Username.Text & "'and Pasword='" & OldPassword.Text & "'"
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
                MsgBox("Password berhasil diganti")

            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MenuUtama.Enabled = True
        Me.Close()

    End Sub
End Class