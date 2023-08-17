Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FormBiayaIklan
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
    Private Class ComboBoxItem
        Public Property Id As String
        Public Property Nama As String
        Public Overrides Function ToString() As String
            Return Nama
        End Function

    End Class
    Sub view()
        strsql = "SELECT bi.*, data_iklan.nama_iklan FROM budget_iklan bi INNER JOIN data_iklan ON bi.id_iklan = data_iklan.id_iklan"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlda.SelectCommand = sqlcmd
        sqldr = sqlcmd.ExecuteReader()
        lvbiayaiklan.Items.Clear()
        While (sqldr.Read())
            With lvbiayaiklan.Items.Add(sqldr("id"))
                .subitems.add(sqldr("tanggal"))
                .subitems.add(sqldr("nama_iklan"))
                .subitems.add(sqldr("biaya"))
            End With
        End While
        sqldr.Close()
    End Sub
    Sub KodeOtomatis()
        sqlcmd = New SqlCommand("select * from budget_Iklan order by id desc", sqlconn)
        sqldr = sqlcmd.ExecuteReader
        sqldr.Read()

        If Not sqldr.HasRows Then
            txtid.Text = "IB01"
        Else
            txtid.Text = Val(Microsoft.VisualBasic.Mid(sqldr.Item("id").ToString, 3, 2)) + 1
            If Len(txtid.Text) = 1 Then
                txtid.Text = "IB0" & txtid.Text & ""
            ElseIf Len(txtid.Text) = 2 Then
                txtid.Text = "IB" & txtid.Text & ""
            End If
        End If
        sqldr.Close()
    End Sub
    Sub bersih()
        txtid.Text = ""
        cmbiklan.SelectedIndex = -1
        txtbudget.Text = ""
        Call KodeOtomatis()
    End Sub
    Sub GetIklan()
        cmbiklan.Items.Clear()
        Dim query As String = "SELECT id_iklan, nama_iklan From data_iklan"
        sqlcmd = New SqlCommand(query, sqlconn)
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read()
            Dim Id As String = sqldr.GetString(0)
            Dim Nama As String = sqldr.GetString(1)
            Dim item As New ComboBoxItem()
            item.Id = Id
            item.Nama = Nama
            cmbiklan.Items.Add(item)
        End While
        sqldr.Close()
    End Sub
    Private Sub FormBiayaIklan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.connect()
        Call view()
        Call KodeOtomatis()
        Call GetIklan()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormDataIklan.Show()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Dim iklan As ComboBoxItem = DirectCast(cmbiklan.SelectedItem, ComboBoxItem)
        Dim adsId As String = iklan.Id
        Dim tanggal As DateTime = Dttanggal.Value
        Dim formatTanggal As String = "yyyy-MM-dd"
        Dim tanggalSQL As String = tanggal.ToString(formatTanggal)
        strsql = "insert into budget_iklan (id, tanggal, id_iklan, biaya) values ('" _
        & txtid.Text & "','" & tanggalSQL & "','" & adsId & "'," & txtbudget.Text & ")"
        Dim sqlcmd As New SqlClient.SqlCommand
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        On Error GoTo satu
        sqlcmd.ExecuteNonQuery()
        MsgBox("Data Budget berhasil ditambah")
        Call view()
        Call bersih()
        Exit Sub
satu:
        MsgBox("Maaf, Data yang anda tambahkan sama !!!")
    End Sub

    Private Sub lvbiayaiklan_DoubleClick(sender As Object, e As EventArgs) Handles lvbiayaiklan.DoubleClick
        With lvbiayaiklan.SelectedItems(0)
            txtid.Text = .SubItems(0).Text
            Dttanggal.Value = .SubItems(1).Text
            Dim namaIklan As String = .SubItems(2).Text
            Dim item As ComboBoxItem = cmbiklan.Items.Cast(Of ComboBoxItem)().FirstOrDefault(Function(i) i.Nama = namaIklan)
            If item IsNot Nothing Then
                cmbiklan.SelectedItem = item
            End If
            txtbudget.Text = .SubItems(3).Text
        End With
        sqldr.Close()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Dim iklan As ComboBoxItem = DirectCast(cmbiklan.SelectedItem, ComboBoxItem)
        Dim adsId As String = iklan.Id
        Dim tanggal As DateTime = Dttanggal.Value
        Dim formatTanggal As String = "yyyy-MM-dd"
        Dim tanggalSQL As String = tanggal.ToString(formatTanggal)

        strsql = "UPDATE budget_iklan SET tanggal = '" & tanggalSQL & "', id_iklan = '" & adsId & "', biaya = " & txtbudget.Text & " WHERE id = '" & txtid.Text & "'"
        Dim sqlcmd As New SqlCommand
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn

        On Error GoTo satu
        sqlcmd.ExecuteNonQuery()
        MsgBox("Data Budget berhasil diupdate")
        Call view()
        Call bersih()
        Exit Sub

satu:
        MsgBox("Maaf, terjadi kesalahan saat mengupdate data")
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Dim selectedId As String = lvbiayaiklan.SelectedItems(0).SubItems(0).Text

        Dim confirmResult As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data dengan ID " & selectedId & "?", "Konfirmasi Hapus", MessageBoxButtons.YesNo)
        If confirmResult = DialogResult.Yes Then
            strsql = "DELETE FROM budget_iklan WHERE id = '" & selectedId & "'"
            Dim sqlcmd As New SqlCommand
            sqlcmd.CommandText = strsql
            sqlcmd.Connection = sqlconn

            On Error GoTo satu
            sqlcmd.ExecuteNonQuery()
            MsgBox("Data Budget berhasil dihapus")
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
End Class