Imports System.Data.SqlClient
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Username.Text = "" Then
            MsgBox("Masukkan Username", MsgBoxStyle.Critical)
        ElseIf Pasword.Text = "" Then
            MsgBox("Masukkan Password", MsgBoxStyle.Critical)

        Else

            query = "select * from Pegawai where Username='" & Username.Text & "'and Pasword='" & Pasword.Text & "'"
            DA = New SqlDataAdapter(query, conn)
            DS = New DataSet
            DA.Fill(DS)
            Dim a As Integer
            a = DS.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Username atau Password salah", MsgBoxStyle.Critical)
            Else

                query = "select * from Pegawai where Username='" & Username.Text & "'and Pasword='" & Pasword.Text & "'"
                DA = New SqlDataAdapter(query, conn)
                Dim table As New DataTable
                DA.Fill(table)

                If table.Rows(0)(7) = 1 Then

                    MsgBox("Berhasil Login Sebagai Admin")
                    MenuUtama.Show()

                    Me.Hide()

                    MenuUtama.JoinMemberToolStripMenuItem.Enabled = False
                    MenuUtama.TicketPurchaseToolStripMenuItem.Enabled = False

                ElseIf table.Rows(0)(7) = 2 Then

                    MsgBox("Berhasil Login Sebagai Pegawai")
                    MenuUtama.Show()

                    Me.Hide()

                    MenuUtama.ManageGajiToolStripMenuItem.Enabled = False
                    MenuUtama.ManagePegawaiToolStripMenuItem.Enabled = False
                    MenuUtama.PenggajianToolStripMenuItem.Enabled = False
                    MenuUtama.ReportGajiToolStripMenuItem.Enabled = False
                    MenuUtama.BuatJadwalToolStripMenuItem.Enabled = False
                    MenuUtama.KehadiranToolStripMenuItem.Enabled = False
                    MenuUtama.MembershipPlanToolStripMenuItem.Enabled = False
                    MenuUtama.ManageTicketToolStripMenuItem.Enabled = False
                    MenuUtama.ManageGamesToolStripMenuItem.Enabled = False


                End If

            End If
        End If

    End Sub
End Class
