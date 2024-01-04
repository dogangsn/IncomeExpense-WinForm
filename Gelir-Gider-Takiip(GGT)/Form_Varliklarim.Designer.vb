<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Varliklarim
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Varliklarim))
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBaslik = New MetroFramework.Controls.MetroLabel()
        Me.lblDeger = New MetroFramework.Controls.MetroLabel()
        Me.lblVarlikTipi = New MetroFramework.Controls.MetroLabel()
        Me.lblTarih = New MetroFramework.Controls.MetroLabel()
        Me.lblAciklama = New MetroFramework.Controls.MetroLabel()
        Me.txtBaslik = New MetroFramework.Controls.MetroTextBox()
        Me.cbbVarlikTipi = New MetroFramework.Controls.MetroComboBox()
        Me.dtTarih = New MetroFramework.Controls.MetroDateTime()
        Me.txtDeger = New MetroFramework.Controls.MetroTextBox()
        Me.txtAciklama = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCikanMiktar = New MetroFramework.Controls.MetroLabel()
        Me.btnSil = New MetroFramework.Controls.MetroTile()
        Me.btnGuncelle = New MetroFramework.Controls.MetroTile()
        Me.btnKaydet = New MetroFramework.Controls.MetroTile()
        Me.btnYeni = New MetroFramework.Controls.MetroTile()
        Me.btnExceleAktar = New MetroFramework.Controls.MetroTile()
        Me.btnYazdir = New MetroFramework.Controls.MetroTile()
        Me.toggleAktif = New MetroFramework.Controls.MetroToggle()
        Me.lblIslemiAktifEt = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnClosed = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.dtwKayitlar = New MetroFramework.Controls.MetroGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtKayitId = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtwKayitlar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 2)
        Me.Label1.TabIndex = 0
        '
        'lblBaslik
        '
        Me.lblBaslik.AutoSize = True
        Me.lblBaslik.Location = New System.Drawing.Point(12, 26)
        Me.lblBaslik.Name = "lblBaslik"
        Me.lblBaslik.Size = New System.Drawing.Size(52, 19)
        Me.lblBaslik.TabIndex = 1
        Me.lblBaslik.Text = "Başlık : "
        '
        'lblDeger
        '
        Me.lblDeger.AutoSize = True
        Me.lblDeger.Location = New System.Drawing.Point(12, 100)
        Me.lblDeger.Name = "lblDeger"
        Me.lblDeger.Size = New System.Drawing.Size(59, 19)
        Me.lblDeger.TabIndex = 2
        Me.lblDeger.Text = "Değeri : "
        '
        'lblVarlikTipi
        '
        Me.lblVarlikTipi.AutoSize = True
        Me.lblVarlikTipi.Location = New System.Drawing.Point(12, 64)
        Me.lblVarlikTipi.Name = "lblVarlikTipi"
        Me.lblVarlikTipi.Size = New System.Drawing.Size(68, 19)
        Me.lblVarlikTipi.TabIndex = 2
        Me.lblVarlikTipi.Text = "Varlıl Tipi :"
        '
        'lblTarih
        '
        Me.lblTarih.AutoSize = True
        Me.lblTarih.Location = New System.Drawing.Point(302, 26)
        Me.lblTarih.Name = "lblTarih"
        Me.lblTarih.Size = New System.Drawing.Size(39, 19)
        Me.lblTarih.TabIndex = 2
        Me.lblTarih.Text = "Tarih:"
        '
        'lblAciklama
        '
        Me.lblAciklama.AutoSize = True
        Me.lblAciklama.Location = New System.Drawing.Point(302, 63)
        Me.lblAciklama.Name = "lblAciklama"
        Me.lblAciklama.Size = New System.Drawing.Size(73, 19)
        Me.lblAciklama.TabIndex = 2
        Me.lblAciklama.Text = "Açıklama : "
        '
        'txtBaslik
        '
        '
        '
        '
        Me.txtBaslik.CustomButton.Image = Nothing
        Me.txtBaslik.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.txtBaslik.CustomButton.Name = ""
        Me.txtBaslik.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtBaslik.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBaslik.CustomButton.TabIndex = 1
        Me.txtBaslik.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBaslik.CustomButton.UseSelectable = True
        Me.txtBaslik.CustomButton.Visible = False
        Me.txtBaslik.Lines = New String(-1) {}
        Me.txtBaslik.Location = New System.Drawing.Point(85, 22)
        Me.txtBaslik.MaxLength = 32767
        Me.txtBaslik.Name = "txtBaslik"
        Me.txtBaslik.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBaslik.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBaslik.SelectedText = ""
        Me.txtBaslik.SelectionLength = 0
        Me.txtBaslik.SelectionStart = 0
        Me.txtBaslik.ShortcutsEnabled = True
        Me.txtBaslik.Size = New System.Drawing.Size(180, 29)
        Me.txtBaslik.TabIndex = 3
        Me.txtBaslik.UseSelectable = True
        Me.txtBaslik.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBaslik.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'cbbVarlikTipi
        '
        Me.cbbVarlikTipi.FormattingEnabled = True
        Me.cbbVarlikTipi.ItemHeight = 23
        Me.cbbVarlikTipi.Items.AddRange(New Object() {"Döviz", "Altın", "Mevduat", "Emlak", "Araç", "Taşınmaz", "Diğer"})
        Me.cbbVarlikTipi.Location = New System.Drawing.Point(86, 61)
        Me.cbbVarlikTipi.Name = "cbbVarlikTipi"
        Me.cbbVarlikTipi.Size = New System.Drawing.Size(157, 29)
        Me.cbbVarlikTipi.TabIndex = 4
        Me.cbbVarlikTipi.UseSelectable = True
        '
        'dtTarih
        '
        Me.dtTarih.Location = New System.Drawing.Point(381, 22)
        Me.dtTarih.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtTarih.Name = "dtTarih"
        Me.dtTarih.Size = New System.Drawing.Size(200, 29)
        Me.dtTarih.TabIndex = 5
        '
        'txtDeger
        '
        '
        '
        '
        Me.txtDeger.CustomButton.Image = Nothing
        Me.txtDeger.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.txtDeger.CustomButton.Name = ""
        Me.txtDeger.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtDeger.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDeger.CustomButton.TabIndex = 1
        Me.txtDeger.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDeger.CustomButton.UseSelectable = True
        Me.txtDeger.CustomButton.Visible = False
        Me.txtDeger.Lines = New String(-1) {}
        Me.txtDeger.Location = New System.Drawing.Point(85, 100)
        Me.txtDeger.MaxLength = 9
        Me.txtDeger.Name = "txtDeger"
        Me.txtDeger.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDeger.PromptText = "0.00 ₺"
        Me.txtDeger.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDeger.SelectedText = ""
        Me.txtDeger.SelectionLength = 0
        Me.txtDeger.SelectionStart = 0
        Me.txtDeger.ShortcutsEnabled = True
        Me.txtDeger.Size = New System.Drawing.Size(180, 29)
        Me.txtDeger.TabIndex = 6
        Me.txtDeger.UseSelectable = True
        Me.txtDeger.WaterMark = "0.00 ₺"
        Me.txtDeger.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDeger.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtAciklama
        '
        '
        '
        '
        Me.txtAciklama.CustomButton.Image = Nothing
        Me.txtAciklama.CustomButton.Location = New System.Drawing.Point(190, 2)
        Me.txtAciklama.CustomButton.Name = ""
        Me.txtAciklama.CustomButton.Size = New System.Drawing.Size(73, 73)
        Me.txtAciklama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAciklama.CustomButton.TabIndex = 1
        Me.txtAciklama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAciklama.CustomButton.UseSelectable = True
        Me.txtAciklama.CustomButton.Visible = False
        Me.txtAciklama.Lines = New String(-1) {}
        Me.txtAciklama.Location = New System.Drawing.Point(381, 60)
        Me.txtAciklama.MaxLength = 32767
        Me.txtAciklama.Multiline = True
        Me.txtAciklama.Name = "txtAciklama"
        Me.txtAciklama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAciklama.SelectedText = ""
        Me.txtAciklama.SelectionLength = 0
        Me.txtAciklama.SelectionStart = 0
        Me.txtAciklama.ShortcutsEnabled = True
        Me.txtAciklama.Size = New System.Drawing.Size(266, 78)
        Me.txtAciklama.TabIndex = 7
        Me.txtAciklama.UseSelectable = True
        Me.txtAciklama.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAciklama.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCikanMiktar)
        Me.GroupBox1.Controls.Add(Me.txtAciklama)
        Me.GroupBox1.Controls.Add(Me.btnSil)
        Me.GroupBox1.Controls.Add(Me.txtDeger)
        Me.GroupBox1.Controls.Add(Me.btnGuncelle)
        Me.GroupBox1.Controls.Add(Me.dtTarih)
        Me.GroupBox1.Controls.Add(Me.btnKaydet)
        Me.GroupBox1.Controls.Add(Me.cbbVarlikTipi)
        Me.GroupBox1.Controls.Add(Me.btnYeni)
        Me.GroupBox1.Controls.Add(Me.txtBaslik)
        Me.GroupBox1.Controls.Add(Me.lblAciklama)
        Me.GroupBox1.Controls.Add(Me.lblTarih)
        Me.GroupBox1.Controls.Add(Me.lblVarlikTipi)
        Me.GroupBox1.Controls.Add(Me.lblDeger)
        Me.GroupBox1.Controls.Add(Me.lblBaslik)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(674, 252)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'lblCikanMiktar
        '
        Me.lblCikanMiktar.AutoSize = True
        Me.lblCikanMiktar.Location = New System.Drawing.Point(86, 132)
        Me.lblCikanMiktar.Name = "lblCikanMiktar"
        Me.lblCikanMiktar.Size = New System.Drawing.Size(44, 19)
        Me.lblCikanMiktar.TabIndex = 15
        Me.lblCikanMiktar.Text = "0.00 ₺"
        Me.lblCikanMiktar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSil
        '
        Me.btnSil.ActiveControl = Nothing
        Me.btnSil.Enabled = False
        Me.btnSil.Location = New System.Drawing.Point(364, 162)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(87, 75)
        Me.btnSil.TabIndex = 9
        Me.btnSil.Text = "Sil"
        Me.btnSil.TileImage = CType(resources.GetObject("btnSil.TileImage"), System.Drawing.Image)
        Me.btnSil.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnSil.UseSelectable = True
        Me.btnSil.UseTileImage = True
        '
        'btnGuncelle
        '
        Me.btnGuncelle.ActiveControl = Nothing
        Me.btnGuncelle.Enabled = False
        Me.btnGuncelle.Location = New System.Drawing.Point(271, 162)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(87, 75)
        Me.btnGuncelle.TabIndex = 9
        Me.btnGuncelle.Text = "Guncelle"
        Me.btnGuncelle.TileImage = CType(resources.GetObject("btnGuncelle.TileImage"), System.Drawing.Image)
        Me.btnGuncelle.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnGuncelle.UseSelectable = True
        Me.btnGuncelle.UseTileImage = True
        '
        'btnKaydet
        '
        Me.btnKaydet.ActiveControl = Nothing
        Me.btnKaydet.Location = New System.Drawing.Point(178, 162)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(87, 75)
        Me.btnKaydet.TabIndex = 9
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.TileImage = CType(resources.GetObject("btnKaydet.TileImage"), System.Drawing.Image)
        Me.btnKaydet.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnKaydet.UseSelectable = True
        Me.btnKaydet.UseTileImage = True
        '
        'btnYeni
        '
        Me.btnYeni.ActiveControl = Nothing
        Me.btnYeni.Location = New System.Drawing.Point(85, 162)
        Me.btnYeni.Name = "btnYeni"
        Me.btnYeni.Size = New System.Drawing.Size(87, 75)
        Me.btnYeni.TabIndex = 9
        Me.btnYeni.Text = "Yeni"
        Me.btnYeni.TileImage = CType(resources.GetObject("btnYeni.TileImage"), System.Drawing.Image)
        Me.btnYeni.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnYeni.UseSelectable = True
        Me.btnYeni.UseTileImage = True
        '
        'btnExceleAktar
        '
        Me.btnExceleAktar.ActiveControl = Nothing
        Me.btnExceleAktar.Enabled = False
        Me.btnExceleAktar.Location = New System.Drawing.Point(25, 51)
        Me.btnExceleAktar.Name = "btnExceleAktar"
        Me.btnExceleAktar.Size = New System.Drawing.Size(104, 70)
        Me.btnExceleAktar.TabIndex = 9
        Me.btnExceleAktar.Text = "Excele Aktar"
        Me.btnExceleAktar.TileImage = CType(resources.GetObject("btnExceleAktar.TileImage"), System.Drawing.Image)
        Me.btnExceleAktar.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnExceleAktar.UseSelectable = True
        Me.btnExceleAktar.UseTileImage = True
        '
        'btnYazdir
        '
        Me.btnYazdir.ActiveControl = Nothing
        Me.btnYazdir.Enabled = False
        Me.btnYazdir.Location = New System.Drawing.Point(135, 51)
        Me.btnYazdir.Name = "btnYazdir"
        Me.btnYazdir.Size = New System.Drawing.Size(98, 70)
        Me.btnYazdir.TabIndex = 9
        Me.btnYazdir.Text = "Yazdır"
        Me.btnYazdir.TileImage = CType(resources.GetObject("btnYazdir.TileImage"), System.Drawing.Image)
        Me.btnYazdir.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnYazdir.UseSelectable = True
        Me.btnYazdir.UseTileImage = True
        '
        'toggleAktif
        '
        Me.toggleAktif.AutoSize = True
        Me.toggleAktif.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.toggleAktif.Location = New System.Drawing.Point(139, 17)
        Me.toggleAktif.Name = "toggleAktif"
        Me.toggleAktif.Size = New System.Drawing.Size(80, 17)
        Me.toggleAktif.TabIndex = 10
        Me.toggleAktif.Text = "Off"
        Me.toggleAktif.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.toggleAktif.UseSelectable = True
        '
        'lblIslemiAktifEt
        '
        Me.lblIslemiAktifEt.AutoSize = True
        Me.lblIslemiAktifEt.Location = New System.Drawing.Point(21, 15)
        Me.lblIslemiAktifEt.Name = "lblIslemiAktifEt"
        Me.lblIslemiAktifEt.Size = New System.Drawing.Size(115, 19)
        Me.lblIslemiAktifEt.TabIndex = 11
        Me.lblIslemiAktifEt.Text = "İşlemleri Aktif Yap:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblIslemiAktifEt)
        Me.GroupBox2.Controls.Add(Me.btnYazdir)
        Me.GroupBox2.Controls.Add(Me.toggleAktif)
        Me.GroupBox2.Controls.Add(Me.btnExceleAktar)
        Me.GroupBox2.Location = New System.Drawing.Point(717, 190)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(263, 133)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'btnClosed
        '
        WindowsUIButtonImageOptions1.Image = CType(resources.GetObject("WindowsUIButtonImageOptions1.Image"), System.Drawing.Image)
        Me.btnClosed.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Kapat", True, WindowsUIButtonImageOptions1)})
        Me.btnClosed.Location = New System.Drawing.Point(1033, 6)
        Me.btnClosed.Name = "btnClosed"
        Me.btnClosed.Size = New System.Drawing.Size(78, 61)
        Me.btnClosed.TabIndex = 14
        Me.btnClosed.Text = "WindowsUIButtonPanel1"
        '
        'dtwKayitlar
        '
        Me.dtwKayitlar.AllowUserToAddRows = False
        Me.dtwKayitlar.AllowUserToDeleteRows = False
        Me.dtwKayitlar.AllowUserToResizeRows = False
        Me.dtwKayitlar.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtwKayitlar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtwKayitlar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dtwKayitlar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtwKayitlar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtwKayitlar.ColumnHeadersHeight = 40
        Me.dtwKayitlar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dtwKayitlar.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtwKayitlar.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtwKayitlar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtwKayitlar.EnableHeadersVisualStyles = False
        Me.dtwKayitlar.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dtwKayitlar.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtwKayitlar.Location = New System.Drawing.Point(20, 329)
        Me.dtwKayitlar.Name = "dtwKayitlar"
        Me.dtwKayitlar.ReadOnly = True
        Me.dtwKayitlar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtwKayitlar.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtwKayitlar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtwKayitlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtwKayitlar.Size = New System.Drawing.Size(1065, 351)
        Me.dtwKayitlar.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.FillWeight = 3.417969!
        Me.Column1.HeaderText = "Başlık"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 3.412249!
        Me.Column2.HeaderText = "Varlık Tipi"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.FillWeight = 3.412547!
        Me.Column3.HeaderText = "Değeri"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.FillWeight = 3.415158!
        Me.Column4.HeaderText = "Tarih"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 120
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.FillWeight = 3.41574!
        Me.Column5.HeaderText = "Açıklama"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "id"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'txtKayitId
        '
        '
        '
        '
        Me.txtKayitId.CustomButton.Image = Nothing
        Me.txtKayitId.CustomButton.Location = New System.Drawing.Point(53, 1)
        Me.txtKayitId.CustomButton.Name = ""
        Me.txtKayitId.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtKayitId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtKayitId.CustomButton.TabIndex = 1
        Me.txtKayitId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtKayitId.CustomButton.UseSelectable = True
        Me.txtKayitId.CustomButton.Visible = False
        Me.txtKayitId.Lines = New String(-1) {}
        Me.txtKayitId.Location = New System.Drawing.Point(986, 288)
        Me.txtKayitId.MaxLength = 32767
        Me.txtKayitId.Name = "txtKayitId"
        Me.txtKayitId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKayitId.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtKayitId.SelectedText = ""
        Me.txtKayitId.SelectionLength = 0
        Me.txtKayitId.SelectionStart = 0
        Me.txtKayitId.ShortcutsEnabled = True
        Me.txtKayitId.Size = New System.Drawing.Size(75, 23)
        Me.txtKayitId.TabIndex = 20
        Me.txtKayitId.UseSelectable = True
        Me.txtKayitId.Visible = False
        Me.txtKayitId.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtKayitId.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Form_Varliklarim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtKayitId)
        Me.Controls.Add(Me.dtwKayitlar)
        Me.Controls.Add(Me.btnClosed)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "Form_Varliklarim"
        Me.Text = "VARLIKLARIM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtwKayitlar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblBaslik As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDeger As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblVarlikTipi As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTarih As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblAciklama As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtBaslik As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbbVarlikTipi As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dtTarih As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtDeger As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAciklama As MetroFramework.Controls.MetroTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnYeni As MetroFramework.Controls.MetroTile
    Friend WithEvents btnSil As MetroFramework.Controls.MetroTile
    Friend WithEvents btnGuncelle As MetroFramework.Controls.MetroTile
    Friend WithEvents btnKaydet As MetroFramework.Controls.MetroTile
    Friend WithEvents btnExceleAktar As MetroFramework.Controls.MetroTile
    Friend WithEvents btnYazdir As MetroFramework.Controls.MetroTile
    Friend WithEvents toggleAktif As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblIslemiAktifEt As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnClosed As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents dtwKayitlar As MetroFramework.Controls.MetroGrid
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents lblCikanMiktar As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtKayitId As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
