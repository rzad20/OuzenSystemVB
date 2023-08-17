<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBiayaIklan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBiayaIklan))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbiklan = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Dttanggal = New System.Windows.Forms.DateTimePicker()
        Me.txtbudget = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lvbiayaiklan = New System.Windows.Forms.ListView()
        Me.id_budget = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tanggal_budget = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.iklan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Budget = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.lblid = New System.Windows.Forms.Label()
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
        Me.Panel3.Size = New System.Drawing.Size(1042, 37)
        Me.Panel3.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Biaya Iklan"
        '
        'cmbiklan
        '
        Me.cmbiklan.FormattingEnabled = True
        Me.cmbiklan.Location = New System.Drawing.Point(330, 113)
        Me.cmbiklan.Name = "cmbiklan"
        Me.cmbiklan.Size = New System.Drawing.Size(323, 21)
        Me.cmbiklan.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(214, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 19)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Pilih Iklan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(214, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 19)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Tanggal"
        '
        'Dttanggal
        '
        Me.Dttanggal.CustomFormat = ""
        Me.Dttanggal.Location = New System.Drawing.Point(330, 152)
        Me.Dttanggal.Name = "Dttanggal"
        Me.Dttanggal.Size = New System.Drawing.Size(200, 20)
        Me.Dttanggal.TabIndex = 46
        '
        'txtbudget
        '
        Me.txtbudget.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtbudget.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbudget.Location = New System.Drawing.Point(330, 188)
        Me.txtbudget.MaxLength = 255
        Me.txtbudget.Name = "txtbudget"
        Me.txtbudget.Size = New System.Drawing.Size(152, 26)
        Me.txtbudget.TabIndex = 51
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(216, 190)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 19)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Budget"
        '
        'btnbatal
        '
        Me.btnbatal.BackColor = System.Drawing.Color.Red
        Me.btnbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbatal.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnbatal.ForeColor = System.Drawing.Color.White
        Me.btnbatal.Location = New System.Drawing.Point(494, 238)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(90, 31)
        Me.btnbatal.TabIndex = 55
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.Red
        Me.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhapus.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnhapus.ForeColor = System.Drawing.Color.White
        Me.btnhapus.Location = New System.Drawing.Point(398, 238)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(90, 31)
        Me.btnhapus.TabIndex = 54
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.Red
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnedit.ForeColor = System.Drawing.Color.White
        Me.btnedit.Location = New System.Drawing.Point(302, 238)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(90, 31)
        Me.btnedit.TabIndex = 53
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.Color.Red
        Me.btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntambah.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btntambah.ForeColor = System.Drawing.Color.White
        Me.btntambah.Location = New System.Drawing.Point(206, 238)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(90, 31)
        Me.btntambah.TabIndex = 52
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(207, 398)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(248, 31)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "Buat Data Iklan"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(206, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Input Budget"
        '
        'lvbiayaiklan
        '
        Me.lvbiayaiklan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lvbiayaiklan.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id_budget, Me.tanggal_budget, Me.iklan, Me.Budget})
        Me.lvbiayaiklan.GridLines = True
        Me.lvbiayaiklan.HideSelection = False
        Me.lvbiayaiklan.Location = New System.Drawing.Point(683, 61)
        Me.lvbiayaiklan.Name = "lvbiayaiklan"
        Me.lvbiayaiklan.Size = New System.Drawing.Size(490, 368)
        Me.lvbiayaiklan.TabIndex = 57
        Me.lvbiayaiklan.UseCompatibleStateImageBehavior = False
        Me.lvbiayaiklan.View = System.Windows.Forms.View.Details
        '
        'id_budget
        '
        Me.id_budget.Text = "ID"
        Me.id_budget.Width = 93
        '
        'tanggal_budget
        '
        Me.tanggal_budget.Text = "Tanggal"
        Me.tanggal_budget.Width = 110
        '
        'iklan
        '
        Me.iklan.Text = "Iklan"
        Me.iklan.Width = 109
        '
        'Budget
        '
        Me.Budget.Text = "Budget"
        Me.Budget.Width = 95
        '
        'txtid
        '
        Me.txtid.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(330, 73)
        Me.txtid.MaxLength = 25
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(150, 26)
        Me.txtid.TabIndex = 59
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(216, 76)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(59, 19)
        Me.lblid.TabIndex = 58
        Me.lblid.Text = "ID Iklan"
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
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(167, 480)
        Me.Panel1.TabIndex = 60
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
        'FormBiayaIklan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.lvbiayaiklan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.txtbudget)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Dttanggal)
        Me.Controls.Add(Me.cmbiklan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FormBiayaIklan"
        Me.Text = "FormBiayaIklan"
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
    Friend WithEvents cmbiklan As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Dttanggal As DateTimePicker
    Friend WithEvents txtbudget As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnbatal As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btntambah As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lvbiayaiklan As ListView
    Friend WithEvents id_budget As ColumnHeader
    Friend WithEvents tanggal_budget As ColumnHeader
    Friend WithEvents iklan As ColumnHeader
    Friend WithEvents Budget As ColumnHeader
    Friend WithEvents txtid As TextBox
    Friend WithEvents lblid As Label
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
