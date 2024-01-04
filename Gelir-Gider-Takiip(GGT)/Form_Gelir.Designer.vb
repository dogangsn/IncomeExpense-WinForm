<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Gelir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Gelir))
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblGelirinBasligi = New MetroFramework.Controls.MetroLabel()
        Me.lblGelirTipi = New MetroFramework.Controls.MetroLabel()
        Me.lblMiktar = New MetroFramework.Controls.MetroLabel()
        Me.lblTarih = New MetroFramework.Controls.MetroLabel()
        Me.lblAciklama = New MetroFramework.Controls.MetroLabel()
        Me.txtGelirBasligi = New MetroFramework.Controls.MetroTextBox()
        Me.txtMiktar = New MetroFramework.Controls.MetroTextBox()
        Me.txtAciklama = New MetroFramework.Controls.MetroTextBox()
        Me.dtTarih = New MetroFramework.Controls.MetroDateTime()
        Me.cbbGelirTipi = New MetroFramework.Controls.MetroComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCikanMiktar = New MetroFramework.Controls.MetroLabel()
        Me.btnSil = New MetroFramework.Controls.MetroTile()
        Me.btnGuncelle = New MetroFramework.Controls.MetroTile()
        Me.btnKaydet = New MetroFramework.Controls.MetroTile()
        Me.btnYeni = New MetroFramework.Controls.MetroTile()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblIslemiAktiEt = New MetroFramework.Controls.MetroLabel()
        Me.btnYazdir = New MetroFramework.Controls.MetroTile()
        Me.toggleAktif = New MetroFramework.Controls.MetroToggle()
        Me.btnExceleAktar = New MetroFramework.Controls.MetroTile()
        Me.btnClosed = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.calcHesapMakinesi = New DevExpress.XtraEditors.CalcEdit()
        Me.lblHesapMakinesi = New MetroFramework.Controls.MetroLabel()
        Me.dtwKayitlar = New MetroFramework.Controls.MetroGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtKayitId = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.calcHesapMakinesi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtwKayitlar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 2)
        Me.Label1.TabIndex = 1
        '
        'lblGelirinBasligi
        '
        Me.lblGelirinBasligi.AutoSize = True
        Me.lblGelirinBasligi.Location = New System.Drawing.Point(15, 26)
        Me.lblGelirinBasligi.Name = "lblGelirinBasligi"
        Me.lblGelirinBasligi.Size = New System.Drawing.Size(97, 19)
        Me.lblGelirinBasligi.TabIndex = 2
        Me.lblGelirinBasligi.Text = "Gelilrin Başlığı :"
        '
        'lblGelirTipi
        '
        Me.lblGelirTipi.AutoSize = True
        Me.lblGelirTipi.Location = New System.Drawing.Point(15, 65)
        Me.lblGelirTipi.Name = "lblGelirTipi"
        Me.lblGelirTipi.Size = New System.Drawing.Size(68, 19)
        Me.lblGelirTipi.TabIndex = 2
        Me.lblGelirTipi.Text = "Gelir Tipi :"
        '
        'lblMiktar
        '
        Me.lblMiktar.AutoSize = True
        Me.lblMiktar.Location = New System.Drawing.Point(15, 104)
        Me.lblMiktar.Name = "lblMiktar"
        Me.lblMiktar.Size = New System.Drawing.Size(57, 19)
        Me.lblMiktar.TabIndex = 2
        Me.lblMiktar.Text = "Miktar : "
        '
        'lblTarih
        '
        Me.lblTarih.AutoSize = True
        Me.lblTarih.Location = New System.Drawing.Point(355, 30)
        Me.lblTarih.Name = "lblTarih"
        Me.lblTarih.Size = New System.Drawing.Size(47, 19)
        Me.lblTarih.TabIndex = 2
        Me.lblTarih.Text = "Tarih : "
        '
        'lblAciklama
        '
        Me.lblAciklama.AutoSize = True
        Me.lblAciklama.Location = New System.Drawing.Point(355, 64)
        Me.lblAciklama.Name = "lblAciklama"
        Me.lblAciklama.Size = New System.Drawing.Size(69, 19)
        Me.lblAciklama.TabIndex = 2
        Me.lblAciklama.Text = "Açıklama :"
        '
        'txtGelirBasligi
        '
        '
        '
        '
        Me.txtGelirBasligi.CustomButton.Image = Nothing
        Me.txtGelirBasligi.CustomButton.Location = New System.Drawing.Point(153, 1)
        Me.txtGelirBasligi.CustomButton.Name = ""
        Me.txtGelirBasligi.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtGelirBasligi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtGelirBasligi.CustomButton.TabIndex = 1
        Me.txtGelirBasligi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGelirBasligi.CustomButton.UseSelectable = True
        Me.txtGelirBasligi.CustomButton.Visible = False
        Me.txtGelirBasligi.Lines = New String(-1) {}
        Me.txtGelirBasligi.Location = New System.Drawing.Point(155, 26)
        Me.txtGelirBasligi.MaxLength = 32767
        Me.txtGelirBasligi.Name = "txtGelirBasligi"
        Me.txtGelirBasligi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGelirBasligi.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtGelirBasligi.SelectedText = ""
        Me.txtGelirBasligi.SelectionLength = 0
        Me.txtGelirBasligi.SelectionStart = 0
        Me.txtGelirBasligi.ShortcutsEnabled = True
        Me.txtGelirBasligi.Size = New System.Drawing.Size(181, 29)
        Me.txtGelirBasligi.TabIndex = 0
        Me.txtGelirBasligi.UseSelectable = True
        Me.txtGelirBasligi.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtGelirBasligi.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMiktar
        '
        '
        '
        '
        Me.txtMiktar.CustomButton.Image = Nothing
        Me.txtMiktar.CustomButton.Location = New System.Drawing.Point(153, 1)
        Me.txtMiktar.CustomButton.Name = ""
        Me.txtMiktar.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtMiktar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMiktar.CustomButton.TabIndex = 1
        Me.txtMiktar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMiktar.CustomButton.UseSelectable = True
        Me.txtMiktar.CustomButton.Visible = False
        Me.txtMiktar.Lines = New String(-1) {}
        Me.txtMiktar.Location = New System.Drawing.Point(155, 104)
        Me.txtMiktar.MaxLength = 9
        Me.txtMiktar.Name = "txtMiktar"
        Me.txtMiktar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMiktar.PromptText = "0.00 ₺"
        Me.txtMiktar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMiktar.SelectedText = ""
        Me.txtMiktar.SelectionLength = 0
        Me.txtMiktar.SelectionStart = 0
        Me.txtMiktar.ShortcutsEnabled = True
        Me.txtMiktar.Size = New System.Drawing.Size(181, 29)
        Me.txtMiktar.TabIndex = 2
        Me.txtMiktar.UseSelectable = True
        Me.txtMiktar.WaterMark = "0.00 ₺"
        Me.txtMiktar.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMiktar.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtAciklama
        '
        '
        '
        '
        Me.txtAciklama.CustomButton.Image = Nothing
        Me.txtAciklama.CustomButton.Location = New System.Drawing.Point(177, 1)
        Me.txtAciklama.CustomButton.Name = ""
        Me.txtAciklama.CustomButton.Size = New System.Drawing.Size(75, 75)
        Me.txtAciklama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAciklama.CustomButton.TabIndex = 1
        Me.txtAciklama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAciklama.CustomButton.UseSelectable = True
        Me.txtAciklama.CustomButton.Visible = False
        Me.txtAciklama.Lines = New String(-1) {}
        Me.txtAciklama.Location = New System.Drawing.Point(424, 64)
        Me.txtAciklama.MaxLength = 32767
        Me.txtAciklama.Multiline = True
        Me.txtAciklama.Name = "txtAciklama"
        Me.txtAciklama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAciklama.SelectedText = ""
        Me.txtAciklama.SelectionLength = 0
        Me.txtAciklama.SelectionStart = 0
        Me.txtAciklama.ShortcutsEnabled = True
        Me.txtAciklama.Size = New System.Drawing.Size(253, 77)
        Me.txtAciklama.TabIndex = 4
        Me.txtAciklama.UseSelectable = True
        Me.txtAciklama.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAciklama.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dtTarih
        '
        Me.dtTarih.Location = New System.Drawing.Point(424, 20)
        Me.dtTarih.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtTarih.Name = "dtTarih"
        Me.dtTarih.Size = New System.Drawing.Size(200, 29)
        Me.dtTarih.TabIndex = 3
        '
        'cbbGelirTipi
        '
        Me.cbbGelirTipi.FormattingEnabled = True
        Me.cbbGelirTipi.ItemHeight = 23
        Me.cbbGelirTipi.Items.AddRange(New Object() {"Nakit", "Kredi Kartı", "Elden", "Çek", "Diğer"})
        Me.cbbGelirTipi.Location = New System.Drawing.Point(155, 65)
        Me.cbbGelirTipi.Name = "cbbGelirTipi"
        Me.cbbGelirTipi.Size = New System.Drawing.Size(121, 29)
        Me.cbbGelirTipi.TabIndex = 1
        Me.cbbGelirTipi.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCikanMiktar)
        Me.GroupBox1.Controls.Add(Me.btnSil)
        Me.GroupBox1.Controls.Add(Me.cbbGelirTipi)
        Me.GroupBox1.Controls.Add(Me.btnGuncelle)
        Me.GroupBox1.Controls.Add(Me.dtTarih)
        Me.GroupBox1.Controls.Add(Me.txtAciklama)
        Me.GroupBox1.Controls.Add(Me.btnKaydet)
        Me.GroupBox1.Controls.Add(Me.txtMiktar)
        Me.GroupBox1.Controls.Add(Me.btnYeni)
        Me.GroupBox1.Controls.Add(Me.txtGelirBasligi)
        Me.GroupBox1.Controls.Add(Me.lblMiktar)
        Me.GroupBox1.Controls.Add(Me.lblAciklama)
        Me.GroupBox1.Controls.Add(Me.lblTarih)
        Me.GroupBox1.Controls.Add(Me.lblGelirTipi)
        Me.GroupBox1.Controls.Add(Me.lblGelirinBasligi)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(704, 253)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'lblCikanMiktar
        '
        Me.lblCikanMiktar.AutoSize = True
        Me.lblCikanMiktar.Location = New System.Drawing.Point(157, 136)
        Me.lblCikanMiktar.Name = "lblCikanMiktar"
        Me.lblCikanMiktar.Size = New System.Drawing.Size(44, 19)
        Me.lblCikanMiktar.TabIndex = 14
        Me.lblCikanMiktar.Text = "0.00 ₺"
        Me.lblCikanMiktar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSil
        '
        Me.btnSil.ActiveControl = Nothing
        Me.btnSil.Enabled = False
        Me.btnSil.Location = New System.Drawing.Point(435, 165)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(87, 75)
        Me.btnSil.TabIndex = 8
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
        Me.btnGuncelle.Location = New System.Drawing.Point(342, 165)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(87, 75)
        Me.btnGuncelle.TabIndex = 7
        Me.btnGuncelle.Text = "Guncelle"
        Me.btnGuncelle.TileImage = CType(resources.GetObject("btnGuncelle.TileImage"), System.Drawing.Image)
        Me.btnGuncelle.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnGuncelle.UseSelectable = True
        Me.btnGuncelle.UseTileImage = True
        '
        'btnKaydet
        '
        Me.btnKaydet.ActiveControl = Nothing
        Me.btnKaydet.Location = New System.Drawing.Point(249, 165)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(87, 75)
        Me.btnKaydet.TabIndex = 6
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.TileImage = CType(resources.GetObject("btnKaydet.TileImage"), System.Drawing.Image)
        Me.btnKaydet.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnKaydet.UseSelectable = True
        Me.btnKaydet.UseTileImage = True
        '
        'btnYeni
        '
        Me.btnYeni.ActiveControl = Nothing
        Me.btnYeni.Location = New System.Drawing.Point(156, 165)
        Me.btnYeni.Name = "btnYeni"
        Me.btnYeni.Size = New System.Drawing.Size(87, 75)
        Me.btnYeni.TabIndex = 5
        Me.btnYeni.Text = "Yeni"
        Me.btnYeni.TileImage = CType(resources.GetObject("btnYeni.TileImage"), System.Drawing.Image)
        Me.btnYeni.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnYeni.UseSelectable = True
        Me.btnYeni.UseTileImage = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblIslemiAktiEt)
        Me.GroupBox2.Controls.Add(Me.btnYazdir)
        Me.GroupBox2.Controls.Add(Me.toggleAktif)
        Me.GroupBox2.Controls.Add(Me.btnExceleAktar)
        Me.GroupBox2.Location = New System.Drawing.Point(739, 190)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(263, 133)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'lblIslemiAktiEt
        '
        Me.lblIslemiAktiEt.AutoSize = True
        Me.lblIslemiAktiEt.Location = New System.Drawing.Point(21, 15)
        Me.lblIslemiAktiEt.Name = "lblIslemiAktiEt"
        Me.lblIslemiAktiEt.Size = New System.Drawing.Size(115, 19)
        Me.lblIslemiAktiEt.TabIndex = 11
        Me.lblIslemiAktiEt.Text = "İşlemleri Aktif Yap:"
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
        'btnClosed
        '
        WindowsUIButtonImageOptions1.Image = CType(resources.GetObject("WindowsUIButtonImageOptions1.Image"), System.Drawing.Image)
        Me.btnClosed.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Kapat", True, WindowsUIButtonImageOptions1)})
        Me.btnClosed.Location = New System.Drawing.Point(1044, 6)
        Me.btnClosed.Name = "btnClosed"
        Me.btnClosed.Size = New System.Drawing.Size(60, 61)
        Me.btnClosed.TabIndex = 14
        Me.btnClosed.Text = "WindowsUIButtonPanel1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.calcHesapMakinesi)
        Me.GroupBox3.Controls.Add(Me.lblHesapMakinesi)
        Me.GroupBox3.Location = New System.Drawing.Point(739, 97)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(263, 87)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        '
        'calcHesapMakinesi
        '
        Me.calcHesapMakinesi.Location = New System.Drawing.Point(157, 35)
        Me.calcHesapMakinesi.Name = "calcHesapMakinesi"
        Me.calcHesapMakinesi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.calcHesapMakinesi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.calcHesapMakinesi.Size = New System.Drawing.Size(76, 20)
        Me.calcHesapMakinesi.TabIndex = 7
        '
        'lblHesapMakinesi
        '
        Me.lblHesapMakinesi.AutoSize = True
        Me.lblHesapMakinesi.Location = New System.Drawing.Point(16, 36)
        Me.lblHesapMakinesi.Name = "lblHesapMakinesi"
        Me.lblHesapMakinesi.Size = New System.Drawing.Size(137, 19)
        Me.lblHesapMakinesi.TabIndex = 3
        Me.lblHesapMakinesi.Text = "Basit Hesap Makinesi :"
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
        Me.dtwKayitlar.ColumnHeadersHeight = 35
        Me.dtwKayitlar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column7, Me.Column5})
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
        Me.dtwKayitlar.Location = New System.Drawing.Point(20, 330)
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
        Me.dtwKayitlar.Size = New System.Drawing.Size(1065, 350)
        Me.dtwKayitlar.TabIndex = 18
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
        Me.Column2.HeaderText = "Gelir Tipi"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.FillWeight = 3.412547!
        Me.Column3.HeaderText = "Miktar"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.FillWeight = 3.415158!
        Me.Column4.HeaderText = "Tarihi"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 120
        '
        'Column6
        '
        Me.Column6.FillWeight = 3.414881!
        Me.Column6.HeaderText = "Kaydedilen Tarih"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 130
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.FillWeight = 679.5114!
        Me.Column7.HeaderText = "Açıklama"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "id"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
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
        Me.txtKayitId.Location = New System.Drawing.Point(1008, 288)
        Me.txtKayitId.MaxLength = 32767
        Me.txtKayitId.Name = "txtKayitId"
        Me.txtKayitId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKayitId.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtKayitId.SelectedText = ""
        Me.txtKayitId.SelectionLength = 0
        Me.txtKayitId.SelectionStart = 0
        Me.txtKayitId.ShortcutsEnabled = True
        Me.txtKayitId.Size = New System.Drawing.Size(75, 23)
        Me.txtKayitId.TabIndex = 19
        Me.txtKayitId.UseSelectable = True
        Me.txtKayitId.Visible = False
        Me.txtKayitId.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtKayitId.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Form_Gelir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtKayitId)
        Me.Controls.Add(Me.dtwKayitlar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnClosed)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "Form_Gelir"
        Me.Resizable = False
        Me.Text = "GELİRLERİM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.calcHesapMakinesi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtwKayitlar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents SpreadsheetFormulaBarControl1 As DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl
    Friend WithEvents Label1 As Label
    Friend WithEvents lblGelirinBasligi As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblGelirTipi As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblMiktar As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTarih As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblAciklama As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtGelirBasligi As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMiktar As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAciklama As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dtTarih As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cbbGelirTipi As MetroFramework.Controls.MetroComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSil As MetroFramework.Controls.MetroTile
    Friend WithEvents btnGuncelle As MetroFramework.Controls.MetroTile
    Friend WithEvents btnKaydet As MetroFramework.Controls.MetroTile
    Friend WithEvents btnYeni As MetroFramework.Controls.MetroTile
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblIslemiAktiEt As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnYazdir As MetroFramework.Controls.MetroTile
    Friend WithEvents toggleAktif As MetroFramework.Controls.MetroToggle
    Friend WithEvents btnExceleAktar As MetroFramework.Controls.MetroTile
    Friend WithEvents btnClosed As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents calcHesapMakinesi As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents lblHesapMakinesi As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtwKayitlar As MetroFramework.Controls.MetroGrid
    Friend WithEvents lblCikanMiktar As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtKayitId As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
