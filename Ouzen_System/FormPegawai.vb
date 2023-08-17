Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class FormPegawai
    Private Sub btnproduct_Click(sender As Object, e As EventArgs) Handles btnproduct.Click
        FormProduk.Show()
        Me.Close()
    End Sub

    Private Sub btnpenjualan_Click(sender As Object, e As EventArgs) Handles btnpenjualan.Click
        FormPenjualan.Show()
        Me.Close()
    End Sub

    Private Sub btniklan_Click(sender As Object, e As EventArgs) Handles btniklan.Click
        FormBiayaIklan.Show()
        Me.Close()
    End Sub

    Private Sub btnlaporan_Click(sender As Object, e As EventArgs) Handles btnlaporan.Click
        FormLaporan.Show()
        Me.Close()
    End Sub
    Private Sub btnbonus_Click(sender As Object, e As EventArgs) Handles btnbonus.Click
        FormBonus.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Formlogin.Show()
        Me.Close()
    End Sub

    Private Sub btndashboard_Click(sender As Object, e As EventArgs) Handles btndashboard.Click
        FormDashboardAdmin.Show()
        Me.Close()
    End Sub
    Sub view()
        Module1.connect()
        strsql = "SELECT * from pegawai"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlda.SelectCommand = sqlcmd
        sqldr = sqlcmd.ExecuteReader()
        lvpegawai.Items.Clear()
        While (sqldr.Read())
            With lvpegawai.Items.Add(sqldr("id_karyawan"))
                .subitems.add(sqldr("nama_karyawan"))
                .subitems.add(sqldr("alamat"))
                .subitems.add(sqldr("no_telepon"))
                .subitems.add(sqldr("posisi"))
            End With
        End While
        sqldr.Close()
    End Sub
    Sub bersih()
        txtid.Text = ""
        txtnama.Text = ""
        txtnohp.Text = ""
        txtalamat.Text = ""
        txtusername.Text = ""
        txtpassword.Text = ""
        cmbposisi.ResetText()
        txtid.Focus()
        Call KodeOtomatis()

    End Sub
    Sub KodeOtomatis()
        Module1.connect()
        sqlcmd = New SqlCommand("select * from pegawai order by id_karyawan desc", sqlconn)
        sqldr = sqlcmd.ExecuteReader
        sqldr.Read()

        If Not sqldr.HasRows Then
            txtid.Text = "P01"
        Else
            txtid.Text = Val(Microsoft.VisualBasic.Mid(sqldr.Item("id_karyawan").ToString, 2, 2)) + 1
            If Len(txtid.Text) = 1 Then
                txtid.Text = "P0" & txtid.Text & ""
            ElseIf Len(txtid.Text) = 2 Then
                txtid.Text = "P" & txtid.Text & ""
            End If
        End If
        sqldr.Close()
    End Sub
    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If (txtid.Text = "") Or (txtnama.Text = "") Or (txtalamat.Text = "") Or (txtnohp.Text = "") Or (txtusername.Text = "") Or (txtpassword.Text = "") Then
            MsgBox("Lengkapi Data")
            Exit Sub
        End If
        Module1.connect()
        strsql = "insert into pegawai (id_karyawan, nama_karyawan, alamat,no_telepon, posisi, username,password) values ('" _
        & txtid.Text & "','" & txtnama.Text & "','" & txtalamat.Text & "','" & txtnohp.Text & "','" & cmbposisi.SelectedItem & "','" & txtusername.Text & "','" & txtpassword.Text & "')"
        Dim sqlcmd As New SqlClient.SqlCommand
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        ' On Error GoTo satu
        sqlcmd.ExecuteNonQuery()
        MsgBox("Pegawai berhasil ditambah")
        view()
        Call bersih()
        Exit Sub
        'satu:
        '  MsgBox("Maaf, Data yang anda tambahkan sama !!!")

    End Sub

    Private Sub FormPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.connect()
        Call view()
        Call KodeOtomatis()
    End Sub

    Private Sub lvpegawai_DoubleClick(sender As Object, e As EventArgs) Handles lvpegawai.DoubleClick
        With lvpegawai.SelectedItems(0)
            txtid.Text = .SubItems(0).Text
            txtnama.Text = .SubItems(1).Text
            txtalamat.Text = .SubItems(2).Text
            txtnohp.Text = .SubItems(3).Text
            cmbposisi.SelectedItem = .SubItems(4).Text
            Module1.connect()
            sqlcmd = New SqlCommand("select username,password from pegawai where id_karyawan='" & .SubItems(0).Text & "'", sqlconn)
            sqldr = sqlcmd.ExecuteReader
            While (sqldr.Read())
                txtusername.Text = sqldr("username")
                txtpassword.Text = sqldr("password")
            End While
        End With
        sqldr.Close()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Module1.connect()
        Dim pesan As String
        pesan = MsgBox("Apakah anda yakin update data ini?", MsgBoxStyle.YesNo)
        If pesan = vbYes Then
            strsql = "update pegawai set nama_karyawan ='" & txtnama.Text & "'," _
              & "alamat ='" & txtalamat.Text & "'," _
              & "no_telepon='" & txtnohp.Text & "'," _
              & "posisi='" & cmbposisi.SelectedItem & "'," _
              & "username='" & txtusername.Text & "'," _
              & "password='" & txtpassword.Text & "' where id_karyawan = '" & txtid.Text & "'"
            Dim sqlcmd As New SqlClient.SqlCommand
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlconn

            sqlcmd.ExecuteNonQuery()
            MsgBox("Pegawai berhasil diupdate")
            view()
            Call bersih()
            Exit Sub
        Else
            view()
            Call bersih()
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Module1.connect()
        Dim pesan As String
        pesan = MsgBox("Apakah anda yakin hapus data ini?", MsgBoxStyle.YesNo)
        If pesan = vbYes Then
            Module1.connect()
            strsql = "delete from pegawai where id_karyawan = '" & txtid.Text & "'"
            Dim sqlcmd As New SqlClient.SqlCommand
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlconn
            sqlcmd.ExecuteNonQuery()
            MsgBox("Karyawan Berhasil Dihapus")
            view()
            Call bersih()
        Else
            view()
            Call bersih()
        End If
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Call bersih()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtpassword.UseSystemPasswordChar = False
        Else
            txtpassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class