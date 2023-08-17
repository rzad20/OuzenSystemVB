Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Formlogin
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Module1.connect()
        If txtuser.Text = "" Then
            MsgBox("Isi Username Dulu")
        ElseIf txtpassword.Text = "" Then
            MsgBox("Isi password Dulu")
        ElseIf txtuser.Text = "" And txtpassword.Text = "" Then
            MsgBox("Isi Username dan Password Dulu")
        Else
            Dim sql, user, pass As String
            user = txtuser.Text
            pass = txtpassword.Text
            sql = "SELECT * FROM pegawai where username='" + user + "' and password='" + pass + "'"
            sqlcmd = New SqlCommand(sql, sqlconn)
            sqldr = sqlcmd.ExecuteReader()
            If sqldr.HasRows = True Then
                MsgBox("Login Berhasil, Selamat Datang")
                FormDashboardAdmin.Show()
            End If
        End If
    End Sub

    Private Sub Formlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtpassword.UseSystemPasswordChar = False
        Else
            txtpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        End
    End Sub
End Class