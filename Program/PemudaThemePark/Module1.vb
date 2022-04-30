Imports System.Data.SqlClient
Module Module1

    Public conn As SqlConnection
    Public cmd As SqlCommand
    Public query As String
    Public DA As SqlDataAdapter
    Public DS As DataSet


    Public PlanID As Integer
    Public GajiID As Integer
    Public GameShiftID As Integer
    Public MemberName As String
    Public AttendanceID As Integer

    Sub koneksi()

        conn = New SqlConnection
        conn.ConnectionString = "server=DESKTOP-ESOSL5M;database=PemudaThemePark;integrated security=true"
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                ' MsgBox("koneksi berhasil")
            End If
        Catch ex As Exception
            MsgBox("koneksi gagal")
        End Try

    End Sub

End Module
