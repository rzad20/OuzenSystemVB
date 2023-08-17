Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FormPenjualan
    Private Sub btnproduct_Click(sender As Object, e As EventArgs) Handles btnproduct.Click
        FormProduk.Show()
        Me.Close()
    End Sub

    Private Sub btnpegawai_Click(sender As Object, e As EventArgs) Handles btnpegawai.Click
        FormPegawai.Show()
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
    Dim query As String
    Private Class ComboBoxItem
        Public Property Id As String
        Public Property Nama As String
        Public Overrides Function ToString() As String
            Return Nama
        End Function

    End Class
    Private selectedKaryawanId As String = ""
    Private selectedKaryawanNama As String = ""
    Private selectedIklanId As String = ""
    Private selectedProdukId As String = ""

    Sub view()
        Module1.connect()
        strsql = "SELECT * from penjualan"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlda.SelectCommand = sqlcmd
        sqldr = sqlcmd.ExecuteReader()
        lvpenjualan.Items.Clear()
        While (sqldr.Read())
            With lvpenjualan.Items.Add(sqldr("id_penjualan"))
                .subitems.add(sqldr("id_karyawan"))
                .subitems.add(sqldr("id_produk"))
                .subitems.add(sqldr("id_iklan"))
                .subitems.add(sqldr("qty"))
                .subitems.add(sqldr("harga_promo"))
                .subitems.add(sqldr("diskon"))
                .subitems.add(sqldr("platform"))
                .subitems.add(sqldr("total"))
                .subitems.add(sqldr("biaya_admin"))
                .subitems.add(sqldr("grandtotal"))
                .subitems.add(sqldr("tanggal"))
                .subitems.add(sqldr("brand"))
            End With
        End While
        sqldr.Close()
    End Sub
    Sub KodeOtomatis()
        Module1.connect()
        sqlcmd = New SqlCommand("select * from penjualan order by id_penjualan desc", sqlconn)
        sqldr = sqlcmd.ExecuteReader
        sqldr.Read()

        If Not sqldr.HasRows Then
            txtIDJb.Text = "JB01"
        Else
            txtid.Text = Val(Microsoft.VisualBasic.Mid(sqldr.Item("id_penjualan").ToString, 3, 2)) + 1
            If Len(txtid.Text) = 1 Then
                txtid.Text = "SL0" & txtid.Text & ""

            ElseIf Len(txtid.Text) = 2 Then
                txtid.Text = "SL" & txtid.Text & ""
            End If
        End If
        sqldr.Close()
    End Sub

    Sub bersih()
        txtid.Text = ""
        txtkaryawan.Text = ""
        cmbiklan.SelectedIndex = -1
        cmbbrand.SelectedIndex = -1
        cmbproduk.SelectedIndex = -1
        txtqty.Text = ""
        txtharga.Text = ""
        cmbplatform.SelectedIndex = -1
        txtgrandtotal.Text = ""
        txtdiskon.Text = ""
        txtbiayaadmin.Text = ""
        txtgrandtotal.Text = ""
        txthargapromo.Text = ""
        Call KodeOtomatis()

    End Sub
    Sub getProduk()
        cmbproduk.Items.Clear()
        If cmbbrand.SelectedItem IsNot Nothing Then
            Dim brand As String = cmbbrand.SelectedItem.ToString()
            query = "SELECT id_produk, nama_produk FROM produk WHERE brand = @brand"
            sqlcmd = New SqlCommand(query, sqlconn)
            sqlcmd.Parameters.AddWithValue("@brand", brand)
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
        End If
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

    Sub getHargaProduk()
        If cmbproduk.SelectedItem IsNot Nothing Then
            Dim selectedProduk As ComboBoxItem = DirectCast(cmbproduk.SelectedItem, ComboBoxItem)
            selectedProdukId = selectedProduk.Id
            query = "SELECT harga_produk FROM produk where id_produk = @id_produk"
            sqlcmd = New SqlCommand(query, sqlconn)
            sqlcmd.Parameters.AddWithValue("@id_produk", selectedProdukId)
            Dim harga As Object = sqlcmd.ExecuteScalar()
            If harga IsNot Nothing AndAlso IsNumeric(harga) Then
                Dim hargaProduk As Int64 = Convert.ToInt64(harga)
                txtharga.Text = hargaProduk.ToString()
            Else
                txtharga.Text = ""
            End If
        Else
            txtharga.Text = ""
        End If
    End Sub
    Sub HitungDiskon()
        If Not String.IsNullOrEmpty(txthargapromo.Text) AndAlso Not String.IsNullOrEmpty(txtqty.Text) AndAlso IsNumeric(txtharga.Text) AndAlso IsNumeric(txtqty.Text) _
          AndAlso IsNumeric(txthargapromo.Text) Then
            Dim harga As Int64 = Convert.ToInt64(txtharga.Text)
            Dim qty As Int64 = Convert.ToInt64(txtqty.Text)
            Dim hargaPromo As Int64 = Convert.ToInt64(txthargapromo.Text)
            Dim diskon As Int64 = (harga - hargaPromo) * qty
            txtdiskon.Text = diskon.ToString()
        Else
            txtdiskon.Text = ""
        End If
    End Sub
    Sub HitungTotal()
        If Not String.IsNullOrEmpty(txtqty.Text) AndAlso Not String.IsNullOrEmpty(txthargapromo.Text) AndAlso IsNumeric(txtqty.Text) AndAlso IsNumeric(txthargapromo.Text) Then
            Dim hargaPromo As Int64 = Convert.ToInt64(txthargapromo.Text)
            Dim qty As Int64 = Convert.ToInt64(txtqty.Text)
            Dim total As Int64 = hargaPromo * qty
            txttotal.Text = total.ToString()
        Else
            txtdiskon.Text = ""
        End If
    End Sub
    Sub HitungBiayaAdmin()
        If Not String.IsNullOrEmpty(txttotal.Text) AndAlso IsNumeric(txttotal.Text) AndAlso cmbplatform.SelectedItem IsNot Nothing Then
            Dim total As Int64 = Convert.ToInt64(txttotal.Text)
            Dim admin_shopee As Double = 0.11
            Dim admin_toped As Double = 0.065
            Dim admin_lazada As Double = 0.083
            Dim biaya_admin As Double

            Select Case cmbplatform.SelectedItem.ToString()
                Case "Shopee"
                    biaya_admin = total * admin_shopee
                Case "Tokopedia"
                    biaya_admin = total * admin_toped
                Case "Lazada"
                    biaya_admin = total * admin_lazada
                Case Else
                    ' Platform tidak valid, beri nilai 0 ke grandTotal
                    biaya_admin = 0
            End Select

            txtbiayaadmin.Text = biaya_admin.ToString()
            Call HitungGrandTotal()
        Else
            txtbiayaadmin.Text = ""
            txtgrandtotal.Text = ""
        End If
    End Sub

    Sub HitungGrandTotal()
        If IsNumeric(txttotal.Text) AndAlso IsNumeric(txtbiayaadmin.Text) Then
            Dim total As Double = CDbl(txttotal.Text)
            Dim biayaAdmin As Double = CDbl(txtbiayaadmin.Text)
            Dim grandTotal As Double = total - biayaAdmin
            txtgrandtotal.Text = grandTotal.ToString()
        Else
            txtgrandtotal.Text = ""
        End If
    End Sub

    Private Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.connect()
        Call KodeOtomatis()
        Call view()

        Call GetIklan()
    End Sub

    Private Sub cmbbrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbrand.SelectedIndexChanged
        Call getProduk()
    End Sub

    Private Sub cmbproduk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbproduk.SelectedIndexChanged
        Call getHargaProduk()
    End Sub


    Private Sub txtqty_TextChanged(sender As Object, e As EventArgs) Handles txtqty.TextChanged
        Call HitungDiskon()
        Call HitungTotal()
        Call HitungBiayaAdmin()
    End Sub

    Private Sub cmbplatform_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbplatform.SelectedIndexChanged
        Call HitungBiayaAdmin()
    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged
        Call HitungGrandTotal()
    End Sub

    Private Sub txtbiayaadmin_TextChanged(sender As Object, e As EventArgs) Handles txtbiayaadmin.TextChanged
        Call HitungGrandTotal()
    End Sub

    Private Sub cmbiklan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbiklan.SelectedIndexChanged
        If cmbiklan.SelectedItem IsNot Nothing Then
            Dim selectedIklan As ComboBoxItem = DirectCast(cmbiklan.SelectedItem, ComboBoxItem)
            selectedIklanId = selectedIklan.Id

            ' Ambil id_karyawan dari data_iklan
            query = "SELECT id_karyawan FROM data_iklan WHERE id_iklan = @id_iklan"
            sqlcmd = New SqlCommand(query, sqlconn)
            sqlcmd.Parameters.AddWithValue("@id_iklan", selectedIklanId)
            Dim idKaryawan As Object = sqlcmd.ExecuteScalar()

            ' Jika id_karyawan ditemukan, gunakan sebagai nilai @id_karyawan
            If idKaryawan IsNot Nothing Then
                selectedKaryawanId = idKaryawan.ToString()

                ' Ambil nama_karyawan dari tabel pegawai
                query = "SELECT nama_karyawan FROM pegawai WHERE id_karyawan = @id_karyawan"
                sqlcmd = New SqlCommand(query, sqlconn)
                sqlcmd.Parameters.AddWithValue("@id_karyawan", selectedKaryawanId)
                Dim namaKaryawan As Object = sqlcmd.ExecuteScalar()

                If namaKaryawan IsNot Nothing Then
                    selectedKaryawanNama = namaKaryawan.ToString()
                    txtkaryawan.Text = selectedKaryawanNama
                Else
                    selectedKaryawanNama = ""
                    txtkaryawan.Text = ""
                End If
            Else
                selectedKaryawanId = ""
                selectedKaryawanNama = ""
            End If
        Else
            selectedKaryawanId = ""
            selectedKaryawanNama = ""
        End If
    End Sub


    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Call bersih()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Module1.connect()

        ' Mendapatkan nilai id_penjualan yang baru
        Dim newIdPenjualan As String = ""
        sqlcmd = New SqlCommand("SELECT MAX(id_penjualan) FROM penjualan", sqlconn)
        Dim maxId As Object = sqlcmd.ExecuteScalar()
        If maxId IsNot Nothing AndAlso Not String.IsNullOrEmpty(maxId.ToString()) Then
            Dim currentId As Integer = Integer.Parse(maxId.ToString().Substring(2))
            newIdPenjualan = "SL" & (currentId + 1).ToString("00")
        Else
            newIdPenjualan = "SL01"
        End If

        ' Mendapatkan nilai brand dari ComboBox cmbbrand
        Dim selectedBrand As String = cmbbrand.SelectedItem.ToString()

        ' Insert data baru ke tabel penjualan
        query = "INSERT INTO penjualan (id_penjualan, id_karyawan, id_produk, id_iklan, qty, harga_promo, diskon, platform, total, biaya_admin, grandtotal, tanggal, brand) VALUES (@id_penjualan, @id_karyawan, @id_produk, @id_iklan, @qty, @harga_promo, @diskon, @platform, @total, @biaya_admin, @grandtotal, @tanggal, @brand)"
        sqlcmd = New SqlCommand(query, sqlconn)
        sqlcmd.Parameters.AddWithValue("@id_penjualan", newIdPenjualan)
        sqlcmd.Parameters.AddWithValue("@id_karyawan", selectedKaryawanId)
        sqlcmd.Parameters.AddWithValue("@id_produk", selectedProdukId)
        sqlcmd.Parameters.AddWithValue("@id_iklan", selectedIklanId)
        sqlcmd.Parameters.AddWithValue("@qty", Integer.Parse(txtqty.Text))
        sqlcmd.Parameters.AddWithValue("@harga_promo", Double.Parse(txthargapromo.Text))
        sqlcmd.Parameters.AddWithValue("@diskon", Double.Parse(txtdiskon.Text))
        sqlcmd.Parameters.AddWithValue("@platform", cmbplatform.SelectedItem.ToString())
        sqlcmd.Parameters.AddWithValue("@total", Double.Parse(txttotal.Text))
        sqlcmd.Parameters.AddWithValue("@biaya_admin", Double.Parse(txtbiayaadmin.Text))
        sqlcmd.Parameters.AddWithValue("@grandtotal", Double.Parse(txtgrandtotal.Text))
        sqlcmd.Parameters.AddWithValue("@tanggal", Dttanggal.Value)
        sqlcmd.Parameters.AddWithValue("@brand", selectedBrand)
        sqlcmd.ExecuteNonQuery()

        ' Insert data baru ke tabel bonus
        Dim newIdBonus As String = ""
        sqlcmd = New SqlCommand("SELECT MAX(id_bonus) FROM bonus", sqlconn)
        maxId = sqlcmd.ExecuteScalar()
        If maxId IsNot Nothing AndAlso Not String.IsNullOrEmpty(maxId.ToString()) Then
            Dim currentId As Integer = Integer.Parse(maxId.ToString().Substring(1))
            newIdBonus = "B" & (currentId + 1).ToString("00")
        Else
            newIdBonus = "B01"
        End If

        ' Mendapatkan nilai total_bonus
        query = "SELECT hpp_produk FROM produk WHERE id_produk = @id_produk"
        sqlcmd = New SqlCommand(query, sqlconn)
        sqlcmd.Parameters.AddWithValue("@id_produk", selectedProdukId)
        Dim hppProduk As Object = sqlcmd.ExecuteScalar()
        Dim totalBonus As Double = (((Double.Parse(txthargapromo.Text) - Double.Parse(hppProduk.ToString())) * Double.Parse(txtqty.Text)) - Double.Parse(txtbiayaadmin.Text)) * 0.03

        ' Insert data baru ke tabel bonus
        query = "INSERT INTO bonus (id_bonus, id_karyawan, id_penjualan, total_bonus, tanggal) VALUES (@id_bonus, @id_karyawan, @id_penjualan, @total_bonus, @tanggal)"
        sqlcmd = New SqlCommand(query, sqlconn)
        sqlcmd.Parameters.AddWithValue("@id_bonus", newIdBonus)
        sqlcmd.Parameters.AddWithValue("@id_karyawan", selectedKaryawanId)
        sqlcmd.Parameters.AddWithValue("@id_penjualan", newIdPenjualan)
        sqlcmd.Parameters.AddWithValue("@total_bonus", totalBonus)
        sqlcmd.Parameters.AddWithValue("@tanggal", Dttanggal.Value)
        sqlcmd.ExecuteNonQuery()

        ' Kurangi stok produk
        query = "UPDATE produk SET stok = stok - @qty WHERE id_produk = @id_produk"
        sqlcmd = New SqlCommand(query, sqlconn)
        sqlcmd.Parameters.AddWithValue("@qty", Integer.Parse(txtqty.Text))
        sqlcmd.Parameters.AddWithValue("@id_produk", selectedProdukId)
        sqlcmd.ExecuteNonQuery()

        MsgBox("Data penjualan berhasil ditambahkan!")
        Call bersih()
        Call KodeOtomatis()
        Call view()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If String.IsNullOrEmpty(txtid.Text) Then
            MsgBox("Pilih data penjualan yang ingin diedit.")
            Return
        End If

        Module1.connect()

        ' Update data penjualan
        query = "UPDATE penjualan SET id_karyawan = @id_karyawan, id_produk = @id_produk, id_iklan = @id_iklan, qty = @qty, harga_promo = @harga_promo, diskon = @diskon, platform = @platform, total = @total, biaya_admin = @biaya_admin, grandtotal = @grandtotal, tanggal = @tanggal, brand = @brand WHERE id_penjualan = @id_penjualan"
        sqlcmd = New SqlCommand(query, sqlconn)
        sqlcmd.Parameters.AddWithValue("@id_karyawan", selectedKaryawanId)
        sqlcmd.Parameters.AddWithValue("@id_produk", selectedProdukId)
        sqlcmd.Parameters.AddWithValue("@id_iklan", selectedIklanId)
        sqlcmd.Parameters.AddWithValue("@qty", Integer.Parse(txtqty.Text))
        sqlcmd.Parameters.AddWithValue("@harga_promo", Double.Parse(txthargapromo.Text))
        sqlcmd.Parameters.AddWithValue("@diskon", Double.Parse(txtdiskon.Text))
        sqlcmd.Parameters.AddWithValue("@platform", cmbplatform.SelectedItem.ToString())
        sqlcmd.Parameters.AddWithValue("@total", Double.Parse(txttotal.Text))
        sqlcmd.Parameters.AddWithValue("@biaya_admin", Double.Parse(txtbiayaadmin.Text))
        sqlcmd.Parameters.AddWithValue("@grandtotal", Double.Parse(txtgrandtotal.Text))
        sqlcmd.Parameters.AddWithValue("@tanggal", Dttanggal.Value)
        sqlcmd.Parameters.AddWithValue("@brand", cmbbrand.SelectedItem.ToString())
        sqlcmd.Parameters.AddWithValue("@id_penjualan", txtid.Text)
        sqlcmd.ExecuteNonQuery()

        ' Update data bonus
        Dim totalBonus As Double = CalculateBonus()
        query = "UPDATE bonus SET total_bonus = @total_bonus WHERE id_penjualan = @id_penjualan"
        sqlcmd = New SqlCommand(query, sqlconn)
        sqlcmd.Parameters.AddWithValue("@total_bonus", totalBonus)
        sqlcmd.Parameters.AddWithValue("@id_penjualan", txtid.Text)
        sqlcmd.ExecuteNonQuery()

        query = "UPDATE produk SET stok = stok + @qty_diff WHERE id_produk = @id_produk"
        sqlcmd = New SqlCommand(query, sqlconn)
        Dim currentQty As Integer = GetCurrentQty(txtid.Text)
        Dim qtyDiff As Integer = Integer.Parse(txtqty.Text) - currentQty
        sqlcmd.Parameters.AddWithValue("@qty_diff", qtyDiff)
        sqlcmd.Parameters.AddWithValue("@id_produk", selectedProdukId)
        sqlcmd.ExecuteNonQuery()


        MsgBox("Data penjualan berhasil diupdate!")
        Call bersih()
        Call view()
        Call KodeOtomatis()
    End Sub

    Private Function CalculateBonus() As Double
        Dim totalBonus As Double = 0.0

        If IsNumeric(txthargapromo.Text) AndAlso IsNumeric(txtqty.Text) AndAlso IsNumeric(txtbiayaadmin.Text) Then
            Dim hargaPromo As Double = Double.Parse(txthargapromo.Text)
            Dim qty As Integer = Integer.Parse(txtqty.Text)
            Dim biayaAdmin As Double = Double.Parse(txtbiayaadmin.Text)
            Dim hppProduk As Double = GetHPPProduk()

            totalBonus = (((hargaPromo - hppProduk) * qty) - biayaAdmin) * 0.03
        End If

        Return totalBonus
    End Function

    Private Function GetHPPProduk() As Double
        Dim hppProduk As Double = 0.0

        If selectedProdukId <> "" Then
            query = "SELECT hpp_produk FROM produk WHERE id_produk = @id_produk"
            sqlcmd = New SqlCommand(query, sqlconn)
            sqlcmd.Parameters.AddWithValue("@id_produk", selectedProdukId)
            Dim hpp As Object = sqlcmd.ExecuteScalar()
            If hpp IsNot Nothing AndAlso IsNumeric(hpp) Then
                hppProduk = CDbl(hpp)
            End If
        End If

        Return hppProduk
    End Function



    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If String.IsNullOrEmpty(txtid.Text) Then
            MsgBox("Pilih data penjualan yang ingin dihapus.")
            Return
        End If

        Dim confirm As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data penjualan ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            Module1.connect()

            ' Hapus data bonus terkait
            query = "DELETE FROM bonus WHERE id_penjualan = @id_penjualan"
            sqlcmd = New SqlCommand(query, sqlconn)
            sqlcmd.Parameters.AddWithValue("@id_penjualan", txtid.Text)
            sqlcmd.ExecuteNonQuery()

            ' Hapus data penjualan
            query = "DELETE FROM penjualan WHERE id_penjualan = @id_penjualan"
            sqlcmd = New SqlCommand(query, sqlconn)
            sqlcmd.Parameters.AddWithValue("@id_penjualan", txtid.Text)
            sqlcmd.ExecuteNonQuery()

            ' Perbarui stok produk
            query = "UPDATE produk SET stok = stok + @qty WHERE id_produk = @id_produk"
            sqlcmd = New SqlCommand(query, sqlconn)
            sqlcmd.Parameters.AddWithValue("@qty", Integer.Parse(txtqty.Text))
            sqlcmd.Parameters.AddWithValue("@id_produk", selectedProdukId)
            sqlcmd.ExecuteNonQuery()

            MsgBox("Data penjualan berhasil dihapus!")
            Call bersih()
            Call KodeOtomatis()
            Call view()
        End If
    End Sub

    Private Function GetCurrentQty(idPenjualan As String) As Integer
        Dim qty As Integer = 0
        query = "SELECT qty FROM penjualan WHERE id_penjualan = @id_penjualan"
        sqlcmd = New SqlCommand(query, sqlconn)
        sqlcmd.Parameters.AddWithValue("@id_penjualan", idPenjualan)
        Dim qtyObj As Object = sqlcmd.ExecuteScalar()
        If qtyObj IsNot Nothing AndAlso IsNumeric(qtyObj) Then
            qty = Integer.Parse(qtyObj)
        End If
        Return qty
    End Function


    Private Sub lvpenjualan_DoubleClick(sender As Object, e As EventArgs) Handles lvpenjualan.DoubleClick
        With lvpenjualan.SelectedItems(0)
            txtid.Text = .SubItems(0).Text

            ' Ambil nama karyawan dari tabel pegawai
            Dim idKaryawan As String = .SubItems(1).Text
            query = "SELECT nama_karyawan FROM pegawai WHERE id_karyawan = @id_karyawan"
            sqlcmd = New SqlCommand(query, sqlconn)
            sqlcmd.Parameters.AddWithValue("@id_karyawan", idKaryawan)
            Dim namaKaryawan As Object = sqlcmd.ExecuteScalar()

            If namaKaryawan IsNot Nothing Then
                txtkaryawan.Text = namaKaryawan.ToString()
            Else
                txtkaryawan.Text = ""
            End If

            ' Pilih item cmbiklan berdasarkan id_iklan
            Dim idIklan As String = .SubItems(3).Text
            For Each item As ComboBoxItem In cmbiklan.Items
                If item.Id = idIklan Then
                    cmbiklan.SelectedItem = item
                    Exit For
                End If
            Next

            ' Pilih item cmbbrand berdasarkan nama brand
            Dim brand As String = .SubItems(12).Text
            cmbbrand.SelectedItem = brand

            ' Pilih item cmbproduk berdasarkan id_produk
            Dim idProduk As String = .SubItems(2).Text
            For Each item As ComboBoxItem In cmbproduk.Items
                If item.Id = idProduk Then
                    cmbproduk.SelectedItem = item
                    Exit For
                End If
            Next

            ' Isi nilai pada textbox dan combobox lainnya
            txtqty.Text = .SubItems(4).Text
            txthargapromo.Text = .SubItems(5).Text
            txtdiskon.Text = .SubItems(6).Text
            cmbplatform.SelectedItem = .SubItems(7).Text
            txttotal.Text = .SubItems(8).Text
            txtbiayaadmin.Text = .SubItems(9).Text
            txtgrandtotal.Text = .SubItems(10).Text
            Dttanggal.Value = DateTime.Parse(.SubItems(11).Text)
        End With
        sqldr.Close()
    End Sub
End Class