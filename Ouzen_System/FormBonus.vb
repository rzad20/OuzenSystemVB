Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FormBonus
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

    Private Sub btnlaporan_Click(sender As Object, e As EventArgs) Handles btnlaporan.Click
        FormLaporan.Show()
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
    Private totalrekapBonus As Decimal = 0.0
    Sub getKaryawan()
        cmbkary.Items.Clear()
        query = "SELECT id_karyawan, nama_karyawan From pegawai where posisi=@posisi"
        sqlcmd = New SqlCommand(query, sqlconn)
        sqlcmd.Parameters.AddWithValue("@posisi", "Digital Marketing")
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
    Private Sub viewHarian()
        strsql = "SELECT * from bonus"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlda.SelectCommand = sqlcmd
        sqldr = sqlcmd.ExecuteReader()
        lvbonusharian.Items.Clear()
        While (sqldr.Read())
            With lvbonusharian.Items.Add(sqldr("id_bonus"))
                .subitems.add(sqldr("id_karyawan"))
                .subitems.add(sqldr("id_penjualan"))
                .subitems.add(sqldr("total_bonus"))
                .subitems.add(sqldr("tanggal"))
            End With
        End While
        sqldr.Close()
    End Sub
    Private Sub viewRekap()
        strsql = "SELECT * from rekapBonus"
        sqlcmd.CommandText = strsql
        sqlcmd.Connection = sqlconn
        sqlda.SelectCommand = sqlcmd
        sqldr = sqlcmd.ExecuteReader()
        lvrekapbonus.Items.Clear()
        While (sqldr.Read())
            With lvrekapbonus.Items.Add(sqldr("id_rekapbonus"))
                .subitems.add(sqldr("id_karyawan"))
                .subitems.add(sqldr("tanggal_awal"))
                .subitems.add(sqldr("tanggal_akhir"))
                .subitems.add(sqldr("rekap_bonus"))
                .subitems.add(sqldr("rekap_biayaiklan"))
                .subitems.add(sqldr("rekap_bonusbersih"))
            End With
        End While
        sqldr.Close()
    End Sub
    Private Sub FormBonus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module1.connect()
        Call viewHarian()
        Call viewRekap()
        Call getKaryawan()
    End Sub

    Private Sub btnhitungbonus_Click(sender As Object, e As EventArgs) Handles btnhitungbonus.Click
        If cmbkary.SelectedItem IsNot Nothing Then
            Dim selectedKaryawan As ComboBoxItem = DirectCast(cmbkary.SelectedItem, ComboBoxItem)
            selectedKaryawanId = selectedKaryawan.Id
            Dim tanggalAwal As DateTime = DateTime.Parse(DtTglAwal.Value.ToString("yyyy-MM-dd"))
            Dim tanggalAkhir As DateTime = DateTime.Parse(DtTglAkhir.Value.ToString("yyyy-MM-dd"))

            ' Hitung rekapitulasi bonus berdasarkan id_karyawan dan rentang tanggal
            query = "SELECT id_karyawan, SUM(total_bonus) As rekap_bonus FROM bonus WHERE id_karyawan = @idKaryawan AND tanggal >= @tanggalAwal AND tanggal <= @tanggalAkhir GROUP BY id_karyawan"
            sqlcmd = New SqlCommand(query, sqlconn)
            sqlcmd.Parameters.AddWithValue("@idKaryawan", selectedKaryawanId)
            sqlcmd.Parameters.AddWithValue("@tanggalAwal", tanggalAwal)
            sqlcmd.Parameters.AddWithValue("@tanggalAkhir", tanggalAkhir)

            sqldr = sqlcmd.ExecuteReader()

            If sqldr.Read() Then
                If Not sqldr.IsDBNull(sqldr.GetOrdinal("rekap_bonus")) Then
                    totalrekapBonus = Convert.ToDouble(sqldr("rekap_bonus"))
                    txtTotalBonus.Text = totalrekapBonus.ToString()
                Else
                    totalrekapBonus = 0.0
                    txtTotalBonus.Text = "0.0"
                End If
            Else
                totalrekapBonus = 0.0
                txtTotalBonus.Text = "0.0"
            End If

            sqldr.Close()
        End If
    End Sub

    Private Sub btnhitungiklan_Click(sender As Object, e As EventArgs) Handles btnhitungiklan.Click
        If cmbkary.SelectedItem IsNot Nothing Then
            Dim selectedKaryawan As ComboBoxItem = DirectCast(cmbkary.SelectedItem, ComboBoxItem)
            selectedKaryawanId = selectedKaryawan.Id

            ' Mencari id_iklan yang sesuai dengan id_karyawan dari item cmbKary yang terpilih dalam tabel data_iklan
            query = "SELECT id_iklan FROM data_iklan WHERE id_karyawan = @idKaryawan"
            sqlcmd = New SqlCommand(query, sqlconn)
            sqlcmd.Parameters.AddWithValue("@idKaryawan", selectedKaryawanId)
            Dim idIklan As String = sqlcmd.ExecuteScalar()?.ToString()

            ' Menghitung budget iklan berdasarkan id_iklan dari data_Iklan dalam rentang tanggal awal dan tanggal akhir dari dtTglAwal dan dtTanggalAkhir
            query = "SELECT SUM(biaya) AS total_biaya FROM budget_iklan WHERE id_iklan = @idIklan AND tanggal >= @tanggalAwal AND tanggal <= @tanggalAkhir"
            sqlcmd = New SqlCommand(query, sqlconn)
            sqlcmd.Parameters.AddWithValue("@idIklan", idIklan)
            sqlcmd.Parameters.AddWithValue("@tanggalAwal", DtTglAwal.Value)
            sqlcmd.Parameters.AddWithValue("@tanggalAkhir", DtTglAkhir.Value)
            Dim totalBiaya As Decimal = Convert.ToDecimal(sqlcmd.ExecuteScalar())

            ' Mengisi txtTotalBiaya dengan total biaya iklan
            txtRekapIklan.Text = totalBiaya.ToString()
        End If
    End Sub

    Private Sub btnhitbonusbersih_Click(sender As Object, e As EventArgs) Handles btnhitbonusbersih.Click
        If Not String.IsNullOrEmpty(txtTotalBonus.Text) AndAlso Not String.IsNullOrEmpty(txtRekapIklan.Text) Then
            Dim totalBiaya As Decimal = Decimal.Parse(txtTotalBonus.Text)
            Dim rekapIklan As Decimal = Decimal.Parse(txtRekapIklan.Text)
            Dim bonusBersih As Decimal = totalBiaya - rekapIklan
            txtBonusBersih.Text = bonusBersih.ToString()
        End If
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If cmbkary.SelectedItem IsNot Nothing Then
            If String.IsNullOrEmpty(txtRekapIklan.Text) OrElse String.IsNullOrEmpty(txtTotalBonus.Text) Then
                MessageBox.Show("Harap memproses nilai Rekap Iklan dan Total Bonus terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                ' Lanjutkan dengan menyimpan data
                Dim selectedKaryawan As ComboBoxItem = DirectCast(cmbkary.SelectedItem, ComboBoxItem)
                selectedKaryawanId = selectedKaryawan.Id
                Dim tanggalAwal As DateTime = DateTime.Parse(DtTglAwal.Value.ToString("yyyy-MM-dd"))
                Dim tanggalAkhir As DateTime = DateTime.Parse(DtTglAkhir.Value.ToString("yyyy-MM-dd"))
                Dim rekapBonus As Decimal = Decimal.Parse(txtTotalBonus.Text)
                Dim rekapBiayaIklan As Decimal = Decimal.Parse(txtRekapIklan.Text)
                Dim rekapBonusBersih As Decimal = Decimal.Parse(txtBonusBersih.Text)
                Dim statusBonus As String = "Belum Dibayar"

                ' Menentukan ID Rekap Bonus berdasarkan data yang ada dalam tabel
                Dim idRekapBonus As String = ""
                query = "SELECT TOP 1 id_rekapbonus FROM rekapBonus ORDER BY id_rekapbonus DESC"
                sqlcmd = New SqlCommand(query, sqlconn)
                sqldr = sqlcmd.ExecuteReader()
                If sqldr.Read() Then
                    Dim lastIdRekapBonus As String = sqldr.GetString(0)
                    Dim lastNumber As Integer = Integer.Parse(lastIdRekapBonus.Substring(3))
                    idRekapBonus = "rkp" + (lastNumber + 1).ToString("D2")
                Else
                    idRekapBonus = "rkp01"
                End If
                sqldr.Close()

                ' Simpan data bonus ke dalam tabel rekapBonus
                query = "INSERT INTO rekapBonus (id_rekapbonus, id_karyawan, tanggal_awal, tanggal_akhir, rekap_bonus, rekap_biayaiklan, rekap_bonusbersih) VALUES (@idRekapBonus, @idKaryawan, @tanggalAwal, @tanggalAkhir, @rekapBonus, @rekapBiayaIklan, @rekapBonusBersih)"
                sqlcmd = New SqlCommand(query, sqlconn)
                sqlcmd.Parameters.AddWithValue("@idRekapBonus", idRekapBonus)
                sqlcmd.Parameters.AddWithValue("@idKaryawan", selectedKaryawanId)
                sqlcmd.Parameters.AddWithValue("@tanggalAwal", tanggalAwal)
                sqlcmd.Parameters.AddWithValue("@tanggalAkhir", tanggalAkhir)
                sqlcmd.Parameters.AddWithValue("@rekapBonus", rekapBonus)
                sqlcmd.Parameters.AddWithValue("@rekapBiayaIklan", rekapBiayaIklan)
                sqlcmd.Parameters.AddWithValue("@rekapBonusBersih", rekapBonusBersih)
                sqlcmd.ExecuteNonQuery()

                MessageBox.Show("Data rekap bonus berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class