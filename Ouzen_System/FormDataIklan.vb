Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FormDataIklan
    Private Sub btnproduct_Click(sender As Object, e As EventArgs) Handles btnproduct.Click
        FormProduk.Show()
        Me.Close()
    End Sub

    Private Sub btnpegawai_Click(sender As Object, e As EventArgs) Handles btnpegawai.Click
        FormPegawai.Show()
        Me.Close()
    End Sub

    Private Sub btnpenjualan_Click(sender As Object, e As EventArgs) Handles btnpenjualan.Click
        FormPenjualan.Show()
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
    Dim query As String
    Private Class ComboBoxItem
        Public Property Id As String
        Public Property Nama As String
        Public Overrides Function ToString() As String
            Return Nama
        End Function

    End Class
    Sub view()
        strsql = "SELECT * from data_iklan"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlda.SelectCommand = sqlcmd
        sqldr = sqlcmd.ExecuteReader()
        lvdataiklan.Items.Clear()
        While (sqldr.Read())
            With lvdataiklan.Items.Add(sqldr("id_iklan"))
                .subitems.add(sqldr("nama_iklan"))
                .subitems.add(sqldr("platform"))
                .subitems.add(sqldr("id_karyawan"))
                .subitems.add(sqldr("id_product"))
            End With
        End While
        sqldr.Close()
    End Sub
    Sub KodeOtomatis()
        sqlcmd = New SqlCommand("select * from data_iklan order by id_iklan desc", sqlconn)
        sqldr = sqlcmd.ExecuteReader
        sqldr.Read()

        If Not sqldr.HasRows Then
            txtid.Text = "ID01"
        Else
            txtid.Text = Val(Microsoft.VisualBasic.Mid(sqldr.Item("id_iklan").ToString, 3, 2)) + 1
            If Len(txtid.Text) = 1 Then
                txtid.Text = "ID0" & txtid.Text & ""
            ElseIf Len(txtid.Text) = 2 Then
                txtid.Text = "ID" & txtid.Text & ""
            End If
        End If
        sqldr.Close()
    End Sub
    Sub bersih()
        txtid.Text = ""
        txtnamaiklan.Text = ""
        cmbplatform.ResetText()
        cmbkary.ResetText()
        cmbproduk.ResetText()
        Call KodeOtomatis()

    End Sub
    Sub getKaryawan()
        cmbkary.Items.Clear()
        query = "SELECT id_karyawan, nama_karyawan From pegawai"
        sqlcmd = New SqlCommand(query, sqlconn)
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read()
            Dim Id As String = sqldr.GetString(0)
            Dim Nama As String = sqldr.GetString(1)
            Dim item As New ComboBoxItem()
            item.Id = Id
            item.Nama = Nama
            cmbkary.Items.Add(item)
        End While
        sqldr.Close()
    End Sub
    Sub getProduk()
        cmbproduk.Items.Clear()
        query = "SELECT id_produk, nama_produk From produk"
        sqlcmd = New SqlCommand(query, sqlconn)
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read()
            Dim Id As String = sqldr.GetString(0)
            Dim Nama As String = sqldr.GetString(1)
            Dim item As New ComboBoxItem()
            item.Id = Id
            item.Nama = Nama
            cmbproduk.Items.Add(item)
        End While
        sqldr.Close()
    End Sub
    Private Sub FormDataIklan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.connect()
        Call view()
        Call KodeOtomatis()
        Call getKaryawan()
        Call getProduk()
    End Sub

    Private Sub cmbplatform_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbplatform.SelectedIndexChanged
        Dim text1 As String = cmbplatform.SelectedItem.ToString()
        txtnamaiklan.Text = text1 & " # "
    End Sub

    Private Sub cmbproduk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbproduk.SelectedIndexChanged
        Dim text1 As String = cmbplatform.SelectedItem.ToString()
        Dim text2 As String = cmbkary.SelectedItem.ToString()
        Dim text3 As String = cmbproduk.SelectedItem.ToString()
        txtnamaiklan.Text = text1 & " # " & text2 & " # " & text3 & " # "
    End Sub

    Private Sub cmbkary_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbkary.SelectedIndexChanged
        Dim text1 As String = cmbplatform.SelectedItem.ToString()
        Dim text2 As String = cmbkary.SelectedItem.ToString()
        txtnamaiklan.Text = text1 & " # " & text2 & " # "
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Dim cmbKaryawan As ComboBoxItem = DirectCast(cmbkary.SelectedItem, ComboBoxItem)
        Dim karyawanId As String = cmbKaryawan.Id
        Dim cmbProd As ComboBoxItem = DirectCast(cmbproduk.SelectedItem, ComboBoxItem)
        Dim ProdukId As String = cmbProd.Id
        strsql = "insert into data_iklan (id_iklan, nama_iklan, platform, id_karyawan, id_product) values ('" _
        & txtid.Text & "','" & txtnamaiklan.Text & "','" & cmbplatform.SelectedItem & "','" & karyawanId & "','" & ProdukId & "')"
        Dim sqlcmd As New SqlClient.SqlCommand
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        On Error GoTo satu
        sqlcmd.ExecuteNonQuery()
        MsgBox("Data Iklan berhasil ditambah")
        Call view()
        Call bersih()
        Exit Sub
satu:
        MsgBox("Maaf, Data yang anda tambahkan sama !!!")

    End Sub

    Private Sub lvdataiklan_DoubleClick(sender As Object, e As EventArgs) Handles lvdataiklan.DoubleClick
        With lvdataiklan.SelectedItems(0)
            txtid.Text = .SubItems(0).Text
            txtnamaiklan.Text = .SubItems(1).Text
            cmbplatform.SelectedItem = .SubItems(2).Text
            Dim karyawanId As String = .SubItems(3).Text
            For Each item As ComboBoxItem In cmbkary.Items
                If item.Id = karyawanId Then
                    cmbkary.SelectedItem = item
                End If
            Next
            Dim produkId As String = .SubItems(4).Text
            For Each item As ComboBoxItem In cmbproduk.Items
                If item.Id = produkId Then
                    cmbproduk.SelectedItem = item
                    Exit For
                End If
            Next
        End With
        sqldr.Close()
    End Sub
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim cmbKaryawan As ComboBoxItem = DirectCast(cmbkary.SelectedItem, ComboBoxItem)
        Dim karyawanId As String = cmbKaryawan.Id
        Dim cmbProd As ComboBoxItem = DirectCast(cmbproduk.SelectedItem, ComboBoxItem)
        Dim produkId As String = cmbProd.Id

        strsql = "UPDATE data_iklan SET nama_iklan = '" & txtnamaiklan.Text & "', platform = '" & cmbplatform.SelectedItem & "', id_karyawan = '" & karyawanId & "', id_product = '" & produkId & "' WHERE id_iklan = '" & txtid.Text & "'"
        Dim sqlcmd As New SqlCommand
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn

        On Error GoTo satu
        sqlcmd.ExecuteNonQuery()
        MsgBox("Data Iklan berhasil diupdate")
        Call view()
        Call bersih()
        Exit Sub

satu:
        MsgBox("Maaf, terjadi kesalahan saat mengupdate data")
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Dim selectedId As String = lvdataiklan.SelectedItems(0).SubItems(0).Text

        ' Periksa apakah ada data terkait dalam tabel budget_iklan
        Dim queryCheck As String = "SELECT COUNT(*) FROM budget_iklan WHERE id_iklan = '" & selectedId & "'"
        Dim sqlcmdCheck As New SqlCommand(queryCheck, sqlconn)
        Dim count As Integer = CInt(sqlcmdCheck.ExecuteScalar())

        If count > 0 Then
            MsgBox("Data Iklan tidak dapat dihapus karena terdapat data terkait dalam tabel Budget Iklan.")
            Exit Sub
        End If

        Dim confirmResult As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data dengan ID " & selectedId & "?", "Konfirmasi Hapus", MessageBoxButtons.YesNo)
        If confirmResult = DialogResult.Yes Then
            strsql = "DELETE FROM data_iklan WHERE id_iklan = '" & selectedId & "'"
            Dim sqlcmd As New SqlCommand
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlconn

            On Error GoTo satu
            sqlcmd.ExecuteNonQuery()
            MsgBox("Data Iklan berhasil dihapus")
            Call view()
            Call bersih()
            Exit Sub
        End If

satu:
        MsgBox("Maaf, terjadi kesalahan saat menghapus data")
    End Sub


    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Call bersih()
    End Sub

    Private Sub btniklan_Click(sender As Object, e As EventArgs)
        FormBiayaIklan.Show()
        Me.Close()
    End Sub

End Class