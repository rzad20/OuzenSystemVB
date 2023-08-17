Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FormProduk

    Private Sub btnpegawai_Click(sender As Object, e As EventArgs) Handles btnpegawai.Click
        FormPegawai.Show()
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

    Sub KodeOtomatis()
        Module1.connect()
        sqlcmd = New SqlCommand("select * from produk order by id_produk desc", sqlconn)
        sqldr = sqlcmd.ExecuteReader
        sqldr.Read()

        If Not sqldr.HasRows Then
            txtid.Text = "I01"
        Else
            txtid.Text = Val(Microsoft.VisualBasic.Mid(sqldr.Item("id_produk").ToString, 2, 2)) + 1
            If Len(txtid.Text) = 1 Then
                txtid.Text = "I0" & txtid.Text & ""
            ElseIf Len(txtid.Text) = 2 Then
                txtid.Text = "I" & txtid.Text & ""
            End If
        End If
        sqldr.Close()
    End Sub
    Sub view()
        Module1.connect()
        strsql = "SELECT * from produk"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlda.SelectCommand = sqlcmd
        sqldr = sqlcmd.ExecuteReader()
        lvproduk.Items.Clear()
        While (sqldr.Read())
            With lvproduk.Items.Add(sqldr("id_produk"))
                .subitems.add(sqldr("brand"))
                .subitems.add(sqldr("nama_produk"))
                .subitems.add(sqldr("harga_produk"))
                .subitems.add(sqldr("hpp_produk"))
                .subitems.add(sqldr("berat_kg"))
                .subitems.add(sqldr("stok"))
            End With
        End While
        sqldr.Close()
    End Sub
    Sub bersih()
        txtid.Text = ""
        txtnama.Text = ""
        txtharga.Text = ""
        txthpp.Text = ""
        txtberat.Text = ""
        txtstok.Text = ""
        txtdeskripsi.Text = ""
        txtid.Focus()
        Call KodeOtomatis()

    End Sub
    Private Sub FormProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.connect()
        Call view()
        Call KodeOtomatis()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If (txtid.Text = "") Or (txtnama.Text = "") Or (txtharga.Text = "") Or (txthpp.Text = "") Or (txtberat.Text = "") Or (txtstok.Text = "") Or (txtdeskripsi.Text = "") Then
            MsgBox("Lengkapi Data")
            Exit Sub
        End If
        Module1.connect()
        strsql = "insert into produk (id_produk, brand, nama_produk, harga_produk,hpp_produk, berat_kg, stok, deskripsi) values ('" _
        & txtid.Text & "','" & cmbbrand.SelectedItem & "','" & txtnama.Text & "'," & txtharga.Text & "," & txthpp.Text & "," & txtberat.Text & "," & txtstok.Text & ",'" & txtdeskripsi.Text & "')"
        Dim sqlcmd As New SqlClient.SqlCommand
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        On Error GoTo satu
        sqlcmd.ExecuteNonQuery()
        MsgBox("Produk berhasil ditambah")
        Call view()
        Call bersih()
        Exit Sub
satu:
        MsgBox("Maaf, Data yang anda tambahkan sama !!!")

    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Module1.connect()
        Dim pesan As String
        pesan = MsgBox("Apakah anda yakin update data ini?", MsgBoxStyle.YesNo)
        If pesan = vbYes Then
            strsql = "update produk set nama_produk ='" & txtnama.Text & "'," _
              & "brand ='" & cmbbrand.SelectedItem & "'," _
              & "harga_produk =" & txtharga.Text & "," _
              & "hpp_produk=" & txthpp.Text & "," _
              & "berat_kg=" & txtberat.Text & "," _
              & "stok=" & txtstok.Text & "," _
              & "deskripsi='" & txtdeskripsi.Text & "' where id_produk = '" & txtid.Text & "'"
            Dim sqlcmd As New SqlClient.SqlCommand
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlconn

            sqlcmd.ExecuteNonQuery()
            MsgBox("Data berhasil diupdate")
            view()
            Call bersih()
            Exit Sub
        Else
            Call view()
            Call bersih()
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Module1.connect()
        Dim pesan As String
        pesan = MsgBox("Apakah anda yakin hapus data ini?", MsgBoxStyle.YesNo)
        If pesan = vbYes Then
            Module1.connect()
            strsql = "delete from produk where id_produk = '" & txtid.Text & "'"
            Dim sqlcmd As New SqlClient.SqlCommand
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlconn
            sqlcmd.ExecuteNonQuery()
            MsgBox("Produk Berhasil Dihapus")
            Call view()
            Call bersih()
        Else
            view()
            Call bersih()
        End If
    End Sub
    Private Sub lvproduk_DoubleClick(sender As Object, e As EventArgs) Handles lvproduk.DoubleClick
        With lvproduk.SelectedItems(0)
            txtid.Text = .SubItems(0).Text
            cmbbrand.SelectedItem = .SubItems(1).Text
            txtharga.Text = .SubItems(3).Text
            txthpp.Text = .SubItems(4).Text
            Module1.connect()
            sqlcmd = New SqlCommand("select nama_produk,berat_kg,stok,deskripsi from produk where id_produk='" & .SubItems(0).Text & "'", sqlconn)
            sqldr = sqlcmd.ExecuteReader
            While (sqldr.Read())
                txtnama.Text = sqldr("nama_produk")
                txtberat.Text = sqldr("berat_kg")
                txtstok.Text = sqldr("stok")
                txtdeskripsi.Text = sqldr("deskripsi")
            End While
        End With
        sqldr.Close()
    End Sub

End Class