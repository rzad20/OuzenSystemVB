<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPenjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPenjualan))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.lblid = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtkaryawan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbproduk = New System.Windows.Forms.ComboBox()
        Me.cmbiklan = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txthargapromo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdiskon = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbplatform = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbiayaadmin = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.Dttanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtgrandtotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbbrand = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.lvpenjualan = New System.Windows.Forms.ListView()
        Me.id_penjualan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.id_karyawan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.id_produk = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.id_iklan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.qty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.harga_promo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.diskon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.platform = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Biaya_Admin = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grandtotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tanggal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnlaporan = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btniklan = New System.Windows.Forms.Button()
        Me.btnbonus = New System.Windows.Forms.Button()
        Me.btnpenjualan = New System.Windows.Forms.Button()
        Me.btnpegawai = New System.Windows.Forms.Button()
        Me.btnproduct = New System.Windows.Forms.Button()
        Me.btndashboard = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(167, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1123, 37)
        Me.Panel3.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Data Penjualan"
        '
        'txtid
        '
        Me.txtid.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(302, 54)
        Me.txtid.MaxLength = 25
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(150, 26)
        Me.txtid.TabIndex = 22
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(185, 57)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(87, 19)
        Me.lblid.TabIndex = 21
        Me.lblid.Text = "ID Penjualan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(500, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Karyawan"
        '
        'txtkaryawan
        '
        Me.txtkaryawan.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtkaryawan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkaryawan.Location = New System.Drawing.Point(593, 54)
        Me.txtkaryawan.MaxLength = 25
        Me.txtkaryawan.Name = "txtkaryawan"
        Me.txtkaryawan.ReadOnly = True
        Me.txtkaryawan.Size = New System.Drawing.Size(150, 26)
        Me.txtkaryawan.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(186, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 19)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Pilih Produk"
        '
        'cmbproduk
        '
        Me.cmbproduk.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbproduk.FormattingEnabled = True
        Me.cmbproduk.Location = New System.Drawing.Point(302, 130)
        Me.cmbproduk.Name = "cmbproduk"
        Me.cmbproduk.Size = New System.Drawing.Size(323, 27)
        Me.cmbproduk.TabIndex = 27
        '
        'cmbiklan
        '
        Me.cmbiklan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbiklan.FormattingEnabled = True
        Me.cmbiklan.Location = New System.Drawing.Point(302, 91)
        Me.cmbiklan.Name = "cmbiklan"
        Me.cmbiklan.Size = New System.Drawing.Size(152, 27)
        Me.cmbiklan.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(186, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 19)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Pilih Iklan"
        '
        'txtharga
        '
        Me.txtharga.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtharga.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtharga.Location = New System.Drawing.Point(302, 170)
        Me.txtharga.MaxLength = 255
        Me.txtharga.Name = "txtharga"
        Me.txtharga.ReadOnly = True
        Me.txtharga.Size = New System.Drawing.Size(152, 26)
        Me.txtharga.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(186, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 19)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Harga Satuan"
        '
        'txthargapromo
        '
        Me.txthargapromo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txthargapromo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthargapromo.Location = New System.Drawing.Point(302, 211)
        Me.txthargapromo.MaxLength = 255
        Me.txthargapromo.Name = "txthargapromo"
        Me.txthargapromo.Size = New System.Drawing.Size(152, 26)
        Me.txthargapromo.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(186, 214)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 19)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Harga Promo"
        '
        'txtdiskon
        '
        Me.txtdiskon.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtdiskon.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiskon.Location = New System.Drawing.Point(302, 293)
        Me.txtdiskon.MaxLength = 255
        Me.txtdiskon.Name = "txtdiskon"
        Me.txtdiskon.ReadOnly = True
        Me.txtdiskon.Size = New System.Drawing.Size(152, 26)
        Me.txtdiskon.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(193, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 19)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Diskon"
        '
        'cmbplatform
        '
        Me.cmbplatform.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbplatform.FormattingEnabled = True
        Me.cmbplatform.Items.AddRange(New Object() {"Shopee", "Tokopedia", "Lazada"})
        Me.cmbplatform.Location = New System.Drawing.Point(582, 211)
        Me.cmbplatform.Name = "cmbplatform"
        Me.cmbplatform.Size = New System.Drawing.Size(153, 27)
        Me.cmbplatform.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(486, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 19)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Platform"
        '
        'txtbiayaadmin
        '
        Me.txtbiayaadmin.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtbiayaadmin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbiayaadmin.Location = New System.Drawing.Point(582, 297)
        Me.txtbiayaadmin.MaxLength = 255
        Me.txtbiayaadmin.Name = "txtbiayaadmin"
        Me.txtbiayaadmin.ReadOnly = True
        Me.txtbiayaadmin.Size = New System.Drawing.Size(152, 26)
        Me.txtbiayaadmin.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(486, 300)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 19)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Biaya Admin"
        '
        'btnbatal
        '
        Me.btnbatal.BackColor = System.Drawing.Color.Red
        Me.btnbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbatal.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnbatal.ForeColor = System.Drawing.Color.White
        Me.btnbatal.Location = New System.Drawing.Point(475, 369)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(90, 31)
        Me.btnbatal.TabIndex = 43
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.Red
        Me.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhapus.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnhapus.ForeColor = System.Drawing.Color.White
        Me.btnhapus.Location = New System.Drawing.Point(379, 369)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(90, 31)
        Me.btnhapus.TabIndex = 42
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.Red
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnedit.ForeColor = System.Drawing.Color.White
        Me.btnedit.Location = New System.Drawing.Point(283, 369)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(90, 31)
        Me.btnedit.TabIndex = 41
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.Color.Red
        Me.btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntambah.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btntambah.ForeColor = System.Drawing.Color.White
        Me.btntambah.Location = New System.Drawing.Point(187, 369)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(90, 31)
        Me.btntambah.TabIndex = 40
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'Dttanggal
        '
        Me.Dttanggal.Location = New System.Drawing.Point(579, 173)
        Me.Dttanggal.Name = "Dttanggal"
        Me.Dttanggal.Size = New System.Drawing.Size(200, 20)
        Me.Dttanggal.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(479, 173)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 19)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Tanggal"
        '
        'txtgrandtotal
        '
        Me.txtgrandtotal.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtgrandtotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgrandtotal.Location = New System.Drawing.Point(582, 329)
        Me.txtgrandtotal.MaxLength = 255
        Me.txtgrandtotal.Name = "txtgrandtotal"
        Me.txtgrandtotal.ReadOnly = True
        Me.txtgrandtotal.Size = New System.Drawing.Size(152, 26)
        Me.txtgrandtotal.TabIndex = 47
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(486, 329)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 19)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Grand Total"
        '
        'txtqty
        '
        Me.txtqty.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtqty.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Location = New System.Drawing.Point(302, 249)
        Me.txtqty.MaxLength = 255
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(152, 26)
        Me.txtqty.TabIndex = 49
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(193, 257)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 19)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Qty"
        '
        'cmbbrand
        '
        Me.cmbbrand.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbrand.FormattingEnabled = True
        Me.cmbbrand.Items.AddRange(New Object() {"Colus", "Colis"})
        Me.cmbbrand.Location = New System.Drawing.Point(593, 91)
        Me.cmbbrand.Name = "cmbbrand"
        Me.cmbbrand.Size = New System.Drawing.Size(152, 27)
        Me.cmbbrand.TabIndex = 51
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(500, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 19)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "Brand"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(486, 267)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 19)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Total"
        '
        'txttotal
        '
        Me.txttotal.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txttotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(582, 264)
        Me.txttotal.MaxLength = 255
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(152, 26)
        Me.txttotal.TabIndex = 53
        '
        'lvpenjualan
        '
        Me.lvpenjualan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lvpenjualan.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id_penjualan, Me.id_karyawan, Me.id_produk, Me.id_iklan, Me.qty, Me.harga_promo, Me.diskon, Me.platform, Me.Total, Me.Biaya_Admin, Me.grandtotal, Me.tanggal, Me.brand})
        Me.lvpenjualan.GridLines = True
        Me.lvpenjualan.HideSelection = False
        Me.lvpenjualan.Location = New System.Drawing.Point(800, 97)
        Me.lvpenjualan.Name = "lvpenjualan"
        Me.lvpenjualan.Size = New System.Drawing.Size(490, 282)
        Me.lvpenjualan.TabIndex = 54
        Me.lvpenjualan.UseCompatibleStateImageBehavior = False
        Me.lvpenjualan.View = System.Windows.Forms.View.Details
        '
        'id_penjualan
        '
        Me.id_penjualan.Text = "ID Penjualan"
        Me.id_penjualan.Width = 93
        '
        'id_karyawan
        '
        Me.id_karyawan.Text = "ID Karyawan"
        Me.id_karyawan.Width = 110
        '
        'id_produk
        '
        Me.id_produk.Text = "id produk"
        Me.id_produk.Width = 109
        '
        'id_iklan
        '
        Me.id_iklan.Text = "id iklan"
        Me.id_iklan.Width = 95
        '
        'qty
        '
        Me.qty.Text = "qty"
        Me.qty.Width = 81
        '
        'harga_promo
        '
        Me.harga_promo.Text = "harga promo"
        '
        'diskon
        '
        Me.diskon.Text = "diskon"
        '
        'platform
        '
        Me.platform.Text = "Platform"
        '
        'Total
        '
        Me.Total.Text = "Total"
        '
        'Biaya_Admin
        '
        Me.Biaya_Admin.Text = "biaya admin"
        '
        'grandtotal
        '
        Me.grandtotal.Text = "Grand Total"
        '
        'tanggal
        '
        Me.tanggal.Text = "Tanggal"
        '
        'brand
        '
        Me.brand.Text = "brand"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(796, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(100, 19)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Data Penjualan"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnlaporan)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btniklan)
        Me.Panel1.Controls.Add(Me.btnbonus)
        Me.Panel1.Controls.Add(Me.btnpenjualan)
        Me.Panel1.Controls.Add(Me.btnpegawai)
        Me.Panel1.Controls.Add(Me.btnproduct)
        Me.Panel1.Controls.Add(Me.btndashboard)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(167, 480)
        Me.Panel1.TabIndex = 57
        '
        'btnlaporan
        '
        Me.btnlaporan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnlaporan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnlaporan.FlatAppearance.BorderSize = 0
        Me.btnlaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlaporan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlaporan.Image = Global.Ouzen_System.My.Resources.Resources.icons8_report_25
        Me.btnlaporan.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnlaporan.Location = New System.Drawing.Point(-1, 335)
        Me.btnlaporan.Name = "btnlaporan"
        Me.btnlaporan.Size = New System.Drawing.Size(160, 36)
        Me.btnlaporan.TabIndex = 21
        Me.btnlaporan.Text = "Laporan"
        Me.btnlaporan.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(-1, 380)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 36)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btniklan
        '
        Me.btniklan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btniklan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btniklan.FlatAppearance.BorderSize = 0
        Me.btniklan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btniklan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btniklan.Image = CType(resources.GetObject("btniklan.Image"), System.Drawing.Image)
        Me.btniklan.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btniklan.Location = New System.Drawing.Point(3, 293)
        Me.btniklan.Name = "btniklan"
        Me.btniklan.Size = New System.Drawing.Size(160, 36)
        Me.btniklan.TabIndex = 19
        Me.btniklan.Text = "Biaya Iklan"
        Me.btniklan.UseVisualStyleBackColor = False
        '
        'btnbonus
        '
        Me.btnbonus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnbonus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnbonus.FlatAppearance.BorderSize = 0
        Me.btnbonus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbonus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbonus.Image = CType(resources.GetObject("btnbonus.Image"), System.Drawing.Image)
        Me.btnbonus.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnbonus.Location = New System.Drawing.Point(3, 249)
        Me.btnbonus.Name = "btnbonus"
        Me.btnbonus.Size = New System.Drawing.Size(160, 36)
        Me.btnbonus.TabIndex = 18
        Me.btnbonus.Text = "Bonus"
        Me.btnbonus.UseVisualStyleBackColor = False
        '
        'btnpenjualan
        '
        Me.btnpenjualan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnpenjualan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnpenjualan.FlatAppearance.BorderSize = 0
        Me.btnpenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpenjualan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpenjualan.Image = CType(resources.GetObject("btnpenjualan.Image"), System.Drawing.Image)
        Me.btnpenjualan.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnpenjualan.Location = New System.Drawing.Point(2, 207)
        Me.btnpenjualan.Name = "btnpenjualan"
        Me.btnpenjualan.Size = New System.Drawing.Size(160, 36)
        Me.btnpenjualan.TabIndex = 16
        Me.btnpenjualan.Text = "Penjualan"
        Me.btnpenjualan.UseVisualStyleBackColor = False
        '
        'btnpegawai
        '
        Me.btnpegawai.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnpegawai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnpegawai.FlatAppearance.BorderSize = 0
        Me.btnpegawai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpegawai.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpegawai.Image = CType(resources.GetObject("btnpegawai.Image"), System.Drawing.Image)
        Me.btnpegawai.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnpegawai.Location = New System.Drawing.Point(2, 162)
        Me.btnpegawai.Name = "btnpegawai"
        Me.btnpegawai.Size = New System.Drawing.Size(160, 36)
        Me.btnpegawai.TabIndex = 15
        Me.btnpegawai.Text = "Pegawai"
        Me.btnpegawai.UseVisualStyleBackColor = False
        '
        'btnproduct
        '
        Me.btnproduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnproduct.FlatAppearance.BorderSize = 0
        Me.btnproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnproduct.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproduct.Image = CType(resources.GetObject("btnproduct.Image"), System.Drawing.Image)
        Me.btnproduct.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnproduct.Location = New System.Drawing.Point(2, 118)
        Me.btnproduct.Name = "btnproduct"
        Me.btnproduct.Size = New System.Drawing.Size(160, 36)
        Me.btnproduct.TabIndex = 14
        Me.btnproduct.Text = "Product"
        Me.btnproduct.UseVisualStyleBackColor = False
        '
        'btndashboard
        '
        Me.btndashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btndashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btndashboard.FlatAppearance.BorderSize = 0
        Me.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndashboard.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndashboard.Image = Global.Ouzen_System.My.Resources.Resources.icons8_home_25
        Me.btndashboard.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btndashboard.Location = New System.Drawing.Point(2, 74)
        Me.btndashboard.Name = "btndashboard"
        Me.btndashboard.Size = New System.Drawing.Size(160, 36)
        Me.btndashboard.TabIndex = 0
        Me.btndashboard.Text = "Dashboard"
        Me.btndashboard.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(166, 61)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Ouzen_System.My.Resources.Resources.ouzenmartlogo2nd_1_
        Me.PictureBox1.Location = New System.Drawing.Point(10, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lvpenjualan)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cmbbrand)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtgrandtotal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Dttanggal)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.txtbiayaadmin)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbplatform)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtdiskon)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txthargapromo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbiklan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbproduk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtkaryawan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FormPenjualan"
        Me.Text = "Form Penjualan"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents lblid As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtkaryawan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbproduk As ComboBox
    Friend WithEvents cmbiklan As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtharga As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txthargapromo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtdiskon As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbplatform As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtbiayaadmin As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnbatal As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btntambah As Button
    Friend WithEvents Dttanggal As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents txtgrandtotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtqty As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbbrand As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents lvpenjualan As ListView
    Friend WithEvents id_penjualan As ColumnHeader
    Friend WithEvents id_karyawan As ColumnHeader
    Friend WithEvents id_produk As ColumnHeader
    Friend WithEvents id_iklan As ColumnHeader
    Friend WithEvents qty As ColumnHeader
    Friend WithEvents harga_promo As ColumnHeader
    Friend WithEvents diskon As ColumnHeader
    Friend WithEvents platform As ColumnHeader
    Friend WithEvents Total As ColumnHeader
    Friend WithEvents Biaya_Admin As ColumnHeader
    Friend WithEvents grandtotal As ColumnHeader
    Friend WithEvents tanggal As ColumnHeader
    Friend WithEvents Label16 As Label
    Friend WithEvents brand As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnlaporan As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btniklan As Button
    Friend WithEvents btnbonus As Button
    Friend WithEvents btnpenjualan As Button
    Friend WithEvents btnpegawai As Button
    Friend WithEvents btnproduct As Button
    Friend WithEvents btndashboard As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
