<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBonus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBonus))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lvbonusharian = New System.Windows.Forms.ListView()
        Me.id_bonus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.id_karyawan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.id_penjualan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dataTotalBonus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tanggalBonus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbkary = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DtTglAwal = New System.Windows.Forms.DateTimePicker()
        Me.DtTglAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnhitungbonus = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnhitbonusbersih = New System.Windows.Forms.Button()
        Me.txtBonusBersih = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRekapIklan = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnhitungiklan = New System.Windows.Forms.Button()
        Me.txtTotalBonus = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lvrekapbonus = New System.Windows.Forms.ListView()
        Me.id_rekapbonus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.id_kary = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.beginDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.endDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RekapBonus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RekapIklan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BonusBersih = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(168, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1042, 37)
        Me.Panel3.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bonus"
        '
        'lvbonusharian
        '
        Me.lvbonusharian.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lvbonusharian.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id_bonus, Me.id_karyawan, Me.id_penjualan, Me.dataTotalBonus, Me.tanggalBonus})
        Me.lvbonusharian.GridLines = True
        Me.lvbonusharian.HideSelection = False
        Me.lvbonusharian.Location = New System.Drawing.Point(207, 87)
        Me.lvbonusharian.Name = "lvbonusharian"
        Me.lvbonusharian.Size = New System.Drawing.Size(490, 127)
        Me.lvbonusharian.TabIndex = 55
        Me.lvbonusharian.UseCompatibleStateImageBehavior = False
        Me.lvbonusharian.View = System.Windows.Forms.View.Details
        '
        'id_bonus
        '
        Me.id_bonus.Text = "ID bonus"
        Me.id_bonus.Width = 93
        '
        'id_karyawan
        '
        Me.id_karyawan.Text = "ID Karyawan"
        Me.id_karyawan.Width = 110
        '
        'id_penjualan
        '
        Me.id_penjualan.Text = "id penjualan"
        Me.id_penjualan.Width = 109
        '
        'dataTotalBonus
        '
        Me.dataTotalBonus.Text = "Total Bonus"
        Me.dataTotalBonus.Width = 95
        '
        'tanggalBonus
        '
        Me.tanggalBonus.Text = "tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(204, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 17)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Data Bonus Harian"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(204, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 17)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Rekap Bonus Bulanan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(204, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(500, 15)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Note : Wajib dilakukan setiap akhir bulan untuk menghitung bonus real digital mar" &
    "keting"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(204, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(368, 15)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Rekapitulasi Bonus = Total Bonus Bulanan - Biaya Iklan Bulanan"
        '
        'cmbkary
        '
        Me.cmbkary.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.cmbkary.FormattingEnabled = True
        Me.cmbkary.Items.AddRange(New Object() {"Colus", "Colis"})
        Me.cmbkary.Location = New System.Drawing.Point(313, 306)
        Me.cmbkary.Name = "cmbkary"
        Me.cmbkary.Size = New System.Drawing.Size(121, 23)
        Me.cmbkary.TabIndex = 61
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(206, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 16)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Pilih Karyawan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(208, 337)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 16)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Pilih Rentang Tanggal"
        '
        'DtTglAwal
        '
        Me.DtTglAwal.Location = New System.Drawing.Point(210, 362)
        Me.DtTglAwal.Name = "DtTglAwal"
        Me.DtTglAwal.Size = New System.Drawing.Size(200, 20)
        Me.DtTglAwal.TabIndex = 63
        '
        'DtTglAkhir
        '
        Me.DtTglAkhir.Location = New System.Drawing.Point(466, 362)
        Me.DtTglAkhir.Name = "DtTglAkhir"
        Me.DtTglAkhir.Size = New System.Drawing.Size(200, 20)
        Me.DtTglAkhir.TabIndex = 64
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(422, 365)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 16)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "s.d"
        '
        'btnhitungbonus
        '
        Me.btnhitungbonus.BackColor = System.Drawing.Color.Red
        Me.btnhitungbonus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhitungbonus.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnhitungbonus.ForeColor = System.Drawing.Color.White
        Me.btnhitungbonus.Location = New System.Drawing.Point(211, 388)
        Me.btnhitungbonus.Name = "btnhitungbonus"
        Me.btnhitungbonus.Size = New System.Drawing.Size(108, 30)
        Me.btnhitungbonus.TabIndex = 66
        Me.btnhitungbonus.Text = "Hitung Bonus"
        Me.btnhitungbonus.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnhitbonusbersih)
        Me.GroupBox1.Controls.Add(Me.txtBonusBersih)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtRekapIklan)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btnhitungiklan)
        Me.GroupBox1.Controls.Add(Me.txtTotalBonus)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(731, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 143)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Penyesuaian Bonus"
        '
        'btnhitbonusbersih
        '
        Me.btnhitbonusbersih.BackColor = System.Drawing.Color.Red
        Me.btnhitbonusbersih.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhitbonusbersih.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnhitbonusbersih.ForeColor = System.Drawing.Color.White
        Me.btnhitbonusbersih.Location = New System.Drawing.Point(300, 88)
        Me.btnhitbonusbersih.Name = "btnhitbonusbersih"
        Me.btnhitbonusbersih.Size = New System.Drawing.Size(128, 26)
        Me.btnhitbonusbersih.TabIndex = 72
        Me.btnhitbonusbersih.Text = "Hitung Bonus Bersih"
        Me.btnhitbonusbersih.UseVisualStyleBackColor = False
        '
        'txtBonusBersih
        '
        Me.txtBonusBersih.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtBonusBersih.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.txtBonusBersih.Location = New System.Drawing.Point(109, 91)
        Me.txtBonusBersih.MaxLength = 255
        Me.txtBonusBersih.Name = "txtBonusBersih"
        Me.txtBonusBersih.ReadOnly = True
        Me.txtBonusBersih.Size = New System.Drawing.Size(185, 23)
        Me.txtBonusBersih.TabIndex = 71
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(15, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 16)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "Bonus Bersih"
        '
        'txtRekapIklan
        '
        Me.txtRekapIklan.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtRekapIklan.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.txtRekapIklan.Location = New System.Drawing.Point(109, 58)
        Me.txtRekapIklan.MaxLength = 255
        Me.txtRekapIklan.Name = "txtRekapIklan"
        Me.txtRekapIklan.ReadOnly = True
        Me.txtRekapIklan.Size = New System.Drawing.Size(185, 23)
        Me.txtRekapIklan.TabIndex = 69
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(15, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 16)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "Biaya Iklan"
        '
        'btnhitungiklan
        '
        Me.btnhitungiklan.BackColor = System.Drawing.Color.Red
        Me.btnhitungiklan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhitungiklan.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnhitungiklan.ForeColor = System.Drawing.Color.White
        Me.btnhitungiklan.Location = New System.Drawing.Point(300, 54)
        Me.btnhitungiklan.Name = "btnhitungiklan"
        Me.btnhitungiklan.Size = New System.Drawing.Size(128, 26)
        Me.btnhitungiklan.TabIndex = 67
        Me.btnhitungiklan.Text = "Hitung Biaya Iklan"
        Me.btnhitungiklan.UseVisualStyleBackColor = False
        '
        'txtTotalBonus
        '
        Me.txtTotalBonus.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtTotalBonus.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.txtTotalBonus.Location = New System.Drawing.Point(109, 28)
        Me.txtTotalBonus.MaxLength = 255
        Me.txtTotalBonus.Name = "txtTotalBonus"
        Me.txtTotalBonus.ReadOnly = True
        Me.txtTotalBonus.Size = New System.Drawing.Size(185, 23)
        Me.txtTotalBonus.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(15, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 16)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Total Bonus"
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.Red
        Me.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsimpan.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnsimpan.ForeColor = System.Drawing.Color.White
        Me.btnsimpan.Location = New System.Drawing.Point(731, 217)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(128, 26)
        Me.btnsimpan.TabIndex = 73
        Me.btnsimpan.Text = "Simpan Data Bonus"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(728, 259)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 17)
        Me.Label13.TabIndex = 75
        Me.Label13.Text = "Rekapitulasi Bonus"
        '
        'lvrekapbonus
        '
        Me.lvrekapbonus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lvrekapbonus.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id_rekapbonus, Me.id_kary, Me.beginDate, Me.endDate, Me.RekapBonus, Me.RekapIklan, Me.BonusBersih, Me.Status})
        Me.lvrekapbonus.GridLines = True
        Me.lvrekapbonus.HideSelection = False
        Me.lvrekapbonus.Location = New System.Drawing.Point(731, 291)
        Me.lvrekapbonus.Name = "lvrekapbonus"
        Me.lvrekapbonus.Size = New System.Drawing.Size(479, 127)
        Me.lvrekapbonus.TabIndex = 74
        Me.lvrekapbonus.UseCompatibleStateImageBehavior = False
        Me.lvrekapbonus.View = System.Windows.Forms.View.Details
        '
        'id_rekapbonus
        '
        Me.id_rekapbonus.Text = "id"
        Me.id_rekapbonus.Width = 93
        '
        'id_kary
        '
        Me.id_kary.Text = "ID Karyawan"
        Me.id_kary.Width = 110
        '
        'beginDate
        '
        Me.beginDate.Text = "Tanggal Awal"
        Me.beginDate.Width = 109
        '
        'endDate
        '
        Me.endDate.Text = "Tanggal Akhir"
        Me.endDate.Width = 95
        '
        'RekapBonus
        '
        Me.RekapBonus.Text = "Total Bonus"
        '
        'RekapIklan
        '
        Me.RekapIklan.Text = "Total Biaya Iklan"
        '
        'BonusBersih
        '
        Me.BonusBersih.Text = "Bonus Bersih"
        '
        'Status
        '
        Me.Status.Text = "Status"
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
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(167, 480)
        Me.Panel1.TabIndex = 76
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
        'FormBonus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1211, 459)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lvrekapbonus)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnhitungbonus)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DtTglAkhir)
        Me.Controls.Add(Me.DtTglAwal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbkary)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lvbonusharian)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FormBonus"
        Me.Text = "FormBonus"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lvbonusharian As ListView
    Friend WithEvents id_bonus As ColumnHeader
    Friend WithEvents id_karyawan As ColumnHeader
    Friend WithEvents id_penjualan As ColumnHeader
    Friend WithEvents dataTotalBonus As ColumnHeader
    Friend WithEvents tanggalBonus As ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbkary As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DtTglAwal As DateTimePicker
    Friend WithEvents DtTglAkhir As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents btnhitungbonus As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnhitbonusbersih As Button
    Friend WithEvents txtBonusBersih As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtRekapIklan As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnhitungiklan As Button
    Friend WithEvents txtTotalBonus As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnsimpan As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents lvrekapbonus As ListView
    Friend WithEvents id_rekapbonus As ColumnHeader
    Friend WithEvents id_kary As ColumnHeader
    Friend WithEvents beginDate As ColumnHeader
    Friend WithEvents endDate As ColumnHeader
    Friend WithEvents RekapBonus As ColumnHeader
    Friend WithEvents RekapIklan As ColumnHeader
    Friend WithEvents BonusBersih As ColumnHeader
    Friend WithEvents Status As ColumnHeader
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
