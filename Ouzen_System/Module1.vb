Imports System.Data.SqlClient
Module Module1
    Public sqlconn As New SqlConnection
    Public sqlcmd As New SqlCommand
    Public sqldr As SqlDataReader
    Public strsql As String
    Public sqlda As New SqlDataAdapter


    Sub connect()
        If sqlconn.State = ConnectionState.Open Then sqlconn.Close()
        sqlconn.ConnectionString = "Data Source=DESKTOP-231P90A\ADIT;Initial Catalog=ouzen_cs;
Integrated Security=True"
        sqlconn.Open()
    End Sub
End Module
