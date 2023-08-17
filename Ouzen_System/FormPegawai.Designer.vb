<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPegawai
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPegawai))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnohp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbposisi = New System.Windows.Forms.ComboBox()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.lvpegawai = New System.Windows.Forms.ListView()
        Me.id_karyawan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nama_karyawan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.alamat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.no_telepon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.posisi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
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
        Me.Panel3.Location = New System.Drawing.Point(160, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1058, 37)
        Me.Panel3.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Data Pegawai"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(193, 66)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(80, 19)
        Me.lblid.TabIndex = 3
        Me.lblid.Text = "ID Pegawai"
        '
        'txtid
        '
        Me.txtid.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(282, 61)
        Me.txtid.MaxLength = 25
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(150, 26)
        Me.txtid.TabIndex = 4
        '
        'txtnama
        '
        Me.txtnama.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtnama.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(283, 102)
        Me.txtnama.MaxLength = 255
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(330, 26)
        Me.txtnama.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(193, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nama"
        '
        'txtalamat
        '
        Me.txtalamat.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtalamat.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalamat.Location = New System.Drawing.Point(282, 144)
        Me.txtalamat.MaxLength = 3500
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(330, 109)
        Me.txtalamat.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(193, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Alamat"
        '
        'txtnohp
        '
        Me.txtnohp.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtnohp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnohp.Location = New System.Drawing.Point(282, 267)
        Me.txtnohp.MaxLength = 255
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(330, 26)
        Me.txtnohp.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(193, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "No Hp"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(193, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Posisi"
        '
        'cmbposisi
        '
        Me.cmbposisi.FormattingEnabled = True
        Me.cmbposisi.Items.AddRange(New Object() {"Customer Service", "Admin", "Digital Marketing"})
        Me.cmbposisi.Location = New System.Drawing.Point(283, 311)
        Me.cmbposisi.Name = "cmbposisi"
        Me.cmbposisi.Size = New System.Drawing.Size(150, 21)
        Me.cmbposisi.TabIndex = 12
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.Color.Red
        Me.btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntambah.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btntambah.ForeColor = System.Drawing.Color.White
        Me.btntambah.Location = New System.Drawing.Point(282, 411)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(90, 31)
        Me.btntambah.TabIndex = 15
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.Red
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnedit.ForeColor = System.Drawing.Color.White
        Me.btnedit.Location = New System.Drawing.Point(378, 411)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(90, 31)
        Me.btnedit.TabIndex = 16
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.Red
        Me.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhapus.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnhapus.ForeColor = System.Drawing.Color.White
        Me.btnhapus.Location = New System.Drawing.Point(474, 411)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(90, 31)
        Me.btnhapus.TabIndex = 18
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnbatal
        '
        Me.btnbatal.BackColor = System.Drawing.Color.Red
        Me.btnbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbatal.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnbatal.ForeColor = System.Drawing.Color.White
        Me.btnbatal.Location = New System.Drawing.Point(570, 411)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(90, 31)
        Me.btnbatal.TabIndex = 19
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = False
        '
        'lvpegawai
        '
        Me.lvpegawai.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lvpegawai.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id_karyawan, Me.nama_karyawan, Me.alamat, Me.no_telepon, Me.posisi})
        Me.lvpegawai.GridLines = True
        Me.lvpegawai.HideSelection = False
        Me.lvpegawai.Location = New System.Drawing.Point(716, 61)
        Me.lvpegawai.Name = "lvpegawai"
        Me.lvpegawai.Size = New System.Drawing.Size(490, 368)
        Me.lvpegawai.TabIndex = 20
        Me.lvpegawai.UseCompatibleStateImageBehavior = False
        Me.lvpegawai.View = System.Windows.Forms.View.Details
        '
        'id_karyawan
        '
        Me.id_karyawan.Text = "ID Karyawan"
        Me.id_karyawan.Width = 93
        '
        'nama_karyawan
        '
        Me.nama_karyawan.Text = "Nama Karyawan"
        Me.nama_karyawan.Width = 110
        '
        'alamat
        '
        Me.alamat.Text = "Alamat"
        Me.alamat.Width = 109
        '
        'no_telepon
        '
        Me.no_telepon.Text = "No Telepon"
        Me.no_telepon.Width = 95
        '
        'posisi
        '
        Me.posisi.Text = "Posisi"
        Me.posisi.Width = 81
        '
        'txtusername
        '
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtusername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(534, 306)
        Me.txtusername.MaxLength = 25
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(150, 26)
        Me.txtusername.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(447, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 19)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Username"
        '
        'txtpassword
        '
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtpassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(534, 349)
        Me.txtpassword.MaxLength = 25
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(150, 26)
        Me.txtpassword.TabIndex = 25
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(450, 354)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 19)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Password"
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
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
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
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(454, 380)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(130, 23)
        Me.CheckBox1.TabIndex = 58
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FormPegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1218, 450)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvpegawai)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.cmbposisi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnohp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FormPegawai"
        Me.Text = "FormPegawai"
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
    Friend WithEvents lblid As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnohp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbposisi As ComboBox
    Friend WithEvents btntambah As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnbatal As Button
    Friend WithEvents lvpegawai As ListView
    Friend WithEvents id_karyawan As ColumnHeader
    Friend WithEvents nama_karyawan As ColumnHeader
    Friend WithEvents alamat As ColumnHeader
    Friend WithEvents no_telepon As ColumnHeader
    Friend WithEvents posisi As ColumnHeader
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label8 As Label
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
    Friend WithEvents CheckBox1 As CheckBox
End Class
