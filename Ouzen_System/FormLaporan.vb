Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FormLaporan
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

    Private Sub btniklan_Click(sender As Object, e As EventArgs) Handles btniklan.Click
        FormBiayaIklan.Show()
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

    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.connect()
    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfilter.SelectedIndexChanged
        ' Mengatur ComboBox Pilih berdasarkan pilihan di ComboBox Filter
        cmbpilih.Items.Clear()

        Select Case cmbfilter.SelectedItem.ToString()
            Case "All"
                cmbpilih.Enabled = False
                lblfilter.Text = "Filter"
            Case "By Produk"
                ' Mengambil data produk dari tabel produk dan menambahkannya ke ComboBox Pilih
                Dim produkList As List(Of ComboBoxItem) = GetDataProduk()
                cmbpilih.Items.AddRange(produkList.ToArray())
                cmbpilih.Enabled = True
                lblfilter.Text = "Produk"
            Case "By Karyawan"
                ' Mengambil data karyawan dari tabel pegawai dan menambahkannya ke ComboBox Pilih
                Dim karyawanList As List(Of ComboBoxItem) = GetDataKaryawan()
                cmbpilih.Items.AddRange(karyawanList.ToArray())
                cmbpilih.Enabled = True
                lblfilter.Text = "Karyawan"
            Case "By Platform"
                ' Menambahkan data platform ke ComboBox Pilih
                cmbpilih.Items.Add(New ComboBoxItem With {.Id = "1", .Nama = "Shopee"})
                cmbpilih.Items.Add(New ComboBoxItem With {.Id = "2", .Nama = "Tokopedia"})
                cmbpilih.Items.Add(New ComboBoxItem With {.Id = "3", .Nama = "Lazada"})
                cmbpilih.Enabled = True
                lblfilter.Text = "Platform"
        End Select
    End Sub

    Private Function GetDataProduk() As List(Of ComboBoxItem)
        ' Mengambil data produk dari tabel produk
        Dim produkList As New List(Of ComboBoxItem)()
        query = "SELECT id_produk, nama_produk FROM produk"
        sqlcmd = New SqlCommand(query, sqlconn)
        sqldr = sqlcmd.ExecuteReader
        While sqldr.Read()
            Dim id As String = sqldr("id_produk").ToString()
            Dim nama As String = sqldr("nama_produk").ToString()

            Dim item As New ComboBoxItem With {.Id = id, .Nama = nama}
            produkList.Add(item)
        End While

        sqldr.Close()
        Return produkList
    End Function

    Private Function GetDataKaryawan() As List(Of ComboBoxItem)
        ' Mengambil data karyawan dari tabel pegawai
        Dim karyawanList As New List(Of ComboBoxItem)()
        query = "SELECT id_karyawan, nama_karyawan FROM pegawai Where posisi = 'Digital Marketing'"
        sqlcmd = New SqlCommand(query, sqlconn)
        sqldr = sqlcmd.ExecuteReader

        While sqldr.Read()
            Dim id As String = sqldr("id_karyawan").ToString()
            Dim nama As String = sqldr("nama_karyawan").ToString()

            Dim item As New ComboBoxItem With {.Id = id, .Nama = nama}
            karyawanList.Add(item)
        End While

        sqldr.Close()

        Return karyawanList
    End Function

    Private Sub btnhitungjual_Click(sender As Object, e As EventArgs) Handles btnhitungjual.Click
        Dim filter As String = cmbfilter.SelectedItem.ToString()
        Dim pilih As ComboBoxItem = DirectCast(cmbpilih.SelectedItem, ComboBoxItem)

        Dim tglAwal As Date = DtTglAwal.Value
        Dim tglAkhir As Date = DtTglAkhir.Value

        Dim query As String = ""
        Dim cmd As New SqlCommand()

        Dim labelText As String = ""
        Dim totalJual As Decimal = 0
        Dim total As Decimal = 0
        Dim biayaAdmin As Decimal = 0

        Select Case filter
            Case "All"
                labelText = "All"
                query = "SELECT SUM(CAST(grandtotal AS decimal)) AS TotalJual, SUM(CAST(total AS decimal)) AS Total, SUM(CAST(biaya_admin AS decimal)) AS BiayaAdmin FROM penjualan WHERE tanggal >= @tglAwal AND tanggal <= @tglAkhir"
            Case "By Produk"
                If pilih IsNot Nothing Then
                    Dim idProduk As String = pilih.Id
                    labelText = pilih.Nama
                    query = "SELECT SUM(CAST(grandtotal AS decimal)) AS TotalJual, SUM(CAST(total AS decimal)) AS Total, SUM(CAST(biaya_admin AS decimal)) AS BiayaAdmin FROM penjualan WHERE id_produk = @idProduk AND tanggal >= @tglAwal AND tanggal <= @tglAkhir"
                    cmd.Parameters.AddWithValue("@idProduk", idProduk)
                Else
                    MessageBox.Show("Silakan pilih produk terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            Case "By Karyawan"
                If pilih IsNot Nothing Then
                    Dim idKaryawan As String = pilih.Id
                    labelText = pilih.Nama
                    query = "SELECT SUM(CAST(grandtotal AS decimal)) AS TotalJual, SUM(CAST(total AS decimal)) AS Total, SUM(CAST(biaya_admin AS decimal)) AS BiayaAdmin FROM penjualan WHERE id_karyawan = @idKaryawan AND tanggal >= @tglAwal AND tanggal <= @tglAkhir"
                    cmd.Parameters.AddWithValue("@idKaryawan", idKaryawan)
                Else
                    MessageBox.Show("Silakan pilih karyawan terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            Case "By Platform"
                If pilih IsNot Nothing Then
                    Dim platform As String = pilih.Nama
                    labelText = pilih.Nama
                    query = "SELECT SUM(CAST(grandtotal AS decimal)) AS TotalJual, SUM(CAST(total AS decimal)) AS Total, SUM(CAST(biaya_admin AS decimal)) AS BiayaAdmin FROM penjualan WHERE platform = @platform AND tanggal >= @tglAwal AND tanggal <= @tglAkhir"
                    cmd.Parameters.AddWithValue("@platform", platform)
                Else
                    MessageBox.Show("Silakan pilih platform terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
        End Select

        cmd.Parameters.AddWithValue("@tglAwal", tglAwal)
        cmd.Parameters.AddWithValue("@tglAkhir", tglAkhir)

        cmd.CommandText = query
        cmd.Connection = sqlconn

        Try
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                If Not reader.IsDBNull(reader.GetOrdinal("TotalJual")) Then
                    totalJual = reader.GetSqlDecimal(reader.GetOrdinal("TotalJual")).Value
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("Total")) Then
                    total = reader.GetSqlDecimal(reader.GetOrdinal("Total")).Value
                End If
                If Not reader.IsDBNull(reader.GetOrdinal("BiayaAdmin")) Then
                    biayaAdmin = reader.GetSqlDecimal(reader.GetOrdinal("BiayaAdmin")).Value
                End If
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan dalam menghitung penjualan." & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        txtlabel.Text = labelText
        txtTotalJual.Text = totalJual.ToString()
        txtgrosssales.Text = total.ToString()
        txtbiayaadmin.Text = biayaAdmin.ToString()
    End Sub


End Class
