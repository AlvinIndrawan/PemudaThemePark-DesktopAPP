Imports System.Data.SqlClient
Public Class ManagePegawai
    Private Sub ManagePegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampil()
        ComboBoxJabatan()

    End Sub
    Sub tampil()

        query = "select Pegawai.NamaPegawai,Pegawai.Username,Pegawai.Pasword,Pegawai.Alamat,Pegawai.No_HP,Pegawai.Gender,Jabatan.jabatan from Pegawai
                join Jabatan on Pegawai.JabatanID=Jabatan.JabatanID"
        DA = New SqlDataAdapter(query, conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)

    End Sub
    Sub ComboBoxJabatan()

        query = "select jabatan from jabatan"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)

        Jabatan.DataSource = table
        Jabatan.DisplayMember = "jabatan"
        Jabatan.Text = ""

    End Sub

    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click

        query = "select top(1) PegawaiID from Pegawai order by PegawaiID desc"
        DA = New SqlDataAdapter(query, conn)
        Dim table As New DataTable
        DA.Fill(table)
        Dim PegawaiID As Integer
        PegawaiID = table.Rows(0)(0).ToString()
        PegawaiID = PegawaiID + 1

        query = "select JabatanID from jabatan where jabatan = '" & Jabatan.Text & "'"
        DA = New SqlDataAdapter(query, conn)
        Dim t As New DataTable
        DA.Fill(t)
        Dim IDjabatan As Integer
        IDjabatan = t.Rows(0)(0).ToString()

        cmd = New SqlCommand
        query = "insert into Pegawai(PegawaiID,NamaPegawai,Username,Pasword,Alamat,No_HP,Gender,JabatanID)values
                ('" & PegawaiID & "','" & Nama.Text & "','" & Username.Text & "','" & Pasword.Text & "','" & Alamat.Text & "','" & noHP.Text & "','" & Gender.Text & "','" & IDjabatan & "')"
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.ExecuteNonQuery()

        MsgBox("Berhasil Insert")
        tampil()

        Nama.Text = ""
        Username.Text = ""
        Pasword.Text = ""
        Alamat.Text = ""
        noHP.Text = ""
        Gender.Text = ""
        Jabatan.Text = ""


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        Nama.Text = DataGridView1.Item(0, i).Value
        Username.Text = DataGridView1.Item(1, i).Value
        Pasword.Text = DataGridView1.Item(2, i).Value
        Alamat.Text = DataGridView1.Item(3, i).Value
        noHP.Text = DataGridView1.Item(4, i).Value
        Gender.Text = DataGridView1.Item(5, i).Value
        Jabatan.Text = DataGridView1.Item(6, i).Value

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click

        cmd = New SqlCommand
        query = "delete from Pegawai where NamaPegawai='" & Nama.Text & "'and Username='" & Username.Text & "'and Pasword='" & Pasword.Text & "'"
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.ExecuteNonQuery()

        MsgBox("Berhsail Delete")

        Nama.Text = ""
        Username.Text = ""
        Pasword.Text = ""
        Alamat.Text = ""
        noHP.Text = ""
        Gender.Text = ""
        Jabatan.Text = ""

        tampil()

        Nama.Text = ""
        Username.Text = ""
        Pasword.Text = ""
        Alamat.Text = ""
        noHP.Text = ""
        Gender.Text = ""
        Jabatan.Text = ""

    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Updet.Click

        cmd = New SqlCommand
        query = "update Pegawai set NamaPegawai='" & Nama.Text & "', Username='" & Username.Text & "',Alamat='" & Alamat.Text & "',No_HP='" & noHP.Text & "' where NamaPegawai='" & Nama.Text & "'and Username='" & Username.Text & "'and Pasword='" & Pasword.Text & "'"
        cmd.Connection = conn
        cmd.CommandText = query
        cmd.ExecuteNonQuery()

        MsgBox("Berhasil Update")
        tampil()

        Nama.Text = ""
        Username.Text = ""
        Pasword.Text = ""
        Alamat.Text = ""
        noHP.Text = ""
        Gender.Text = ""
        Jabatan.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MenuUtama.Enabled = True
        Me.Close()

    End Sub
End Class