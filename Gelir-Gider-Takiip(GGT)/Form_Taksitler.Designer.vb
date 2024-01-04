<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Taksitler
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Taksitler))
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCikanMiktar = New MetroFramework.Controls.MetroLabel()
        Me.cbbTaksitPeriyodu = New MetroFramework.Controls.MetroComboBox()
        Me.lblGun = New MetroFramework.Controls.MetroLabel()
        Me.txtTaksitSayisi = New MetroFramework.Controls.MetroTextBox()
        Me.btnSil = New MetroFramework.Controls.MetroTile()
        Me.cbbOdemeTipi = New MetroFramework.Controls.MetroComboBox()
        Me.btnGuncelle = New MetroFramework.Controls.MetroTile()
        Me.dtIlkOdemeTarihi = New MetroFramework.Controls.MetroDateTime()
        Me.txtAciklama = New MetroFramework.Controls.MetroTextBox()
        Me.btnKaydet = New MetroFramework.Controls.MetroTile()
        Me.txtOdemeMiktari = New MetroFramework.Controls.MetroTextBox()
        Me.btnYeni = New MetroFramework.Controls.MetroTile()
        Me.txtOdemeBasligi = New MetroFramework.Controls.MetroTextBox()
        Me.lblTaksitPeriyodu = New MetroFramework.Controls.MetroLabel()
        Me.lblTaksitSayisi = New MetroFramework.Controls.MetroLabel()
        Me.lblOdemeMiktari = New MetroFramework.Controls.MetroLabel()
        Me.lblAciklama = New MetroFramework.Controls.MetroLabel()
        Me.lblIlkOdemeTarihi = New MetroFramework.Controls.MetroLabel()
        Me.lblOdemeTipi = New MetroFramework.Controls.MetroLabel()
        Me.lblOdemeBasligi = New MetroFramework.Controls.MetroLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblIslemiAktif = New MetroFramework.Controls.MetroLabel()
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
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtKayitId = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.calcHesapMakinesi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtwKayitlar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCikanMiktar)
        Me.GroupBox1.Controls.Add(Me.cbbTaksitPeriyodu)
        Me.GroupBox1.Controls.Add(Me.lblGun)
        Me.GroupBox1.Controls.Add(Me.txtTaksitSayisi)
        Me.GroupBox1.Controls.Add(Me.btnSil)
        Me.GroupBox1.Controls.Add(Me.cbbOdemeTipi)
        Me.GroupBox1.Controls.Add(Me.btnGuncelle)
        Me.GroupBox1.Controls.Add(Me.dtIlkOdemeTarihi)
        Me.GroupBox1.Controls.Add(Me.txtAciklama)
        Me.GroupBox1.Controls.Add(Me.btnKaydet)
        Me.GroupBox1.Controls.Add(Me.txtOdemeMiktari)
        Me.GroupBox1.Controls.Add(Me.btnYeni)
        Me.GroupBox1.Controls.Add(Me.txtOdemeBasligi)
        Me.GroupBox1.Controls.Add(Me.lblTaksitPeriyodu)
        Me.GroupBox1.Controls.Add(Me.lblTaksitSayisi)
        Me.GroupBox1.Controls.Add(Me.lblOdemeMiktari)
        Me.GroupBox1.Controls.Add(Me.lblAciklama)
        Me.GroupBox1.Controls.Add(Me.lblIlkOdemeTarihi)
        Me.GroupBox1.Controls.Add(Me.lblOdemeTipi)
        Me.GroupBox1.Controls.Add(Me.lblOdemeBasligi)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(766, 278)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'lblCikanMiktar
        '
        Me.lblCikanMiktar.AutoSize = True
        Me.lblCikanMiktar.Location = New System.Drawing.Point(282, 113)
        Me.lblCikanMiktar.Name = "lblCikanMiktar"
        Me.lblCikanMiktar.Size = New System.Drawing.Size(44, 19)
        Me.lblCikanMiktar.TabIndex = 18
        Me.lblCikanMiktar.Text = "0.00 ₺"
        Me.lblCikanMiktar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbbTaksitPeriyodu
        '
        Me.cbbTaksitPeriyodu.FormattingEnabled = True
        Me.cbbTaksitPeriyodu.ItemHeight = 23
        Me.cbbTaksitPeriyodu.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cbbTaksitPeriyodu.Location = New System.Drawing.Point(290, 142)
        Me.cbbTaksitPeriyodu.Name = "cbbTaksitPeriyodu"
        Me.cbbTaksitPeriyodu.Size = New System.Drawing.Size(74, 29)
        Me.cbbTaksitPeriyodu.TabIndex = 17
        Me.cbbTaksitPeriyodu.UseSelectable = True
        '
        'lblGun
        '
        Me.lblGun.AutoSize = True
        Me.lblGun.Location = New System.Drawing.Point(370, 147)
        Me.lblGun.Name = "lblGun"
        Me.lblGun.Size = New System.Drawing.Size(32, 19)
        Me.lblGun.TabIndex = 16
        Me.lblGun.Text = "Gün"
        '
        'txtTaksitSayisi
        '
        '
        '
        '
        Me.txtTaksitSayisi.CustomButton.Image = Nothing
        Me.txtTaksitSayisi.CustomButton.Location = New System.Drawing.Point(13, 1)
        Me.txtTaksitSayisi.CustomButton.Name = ""
        Me.txtTaksitSayisi.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtTaksitSayisi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTaksitSayisi.CustomButton.TabIndex = 1
        Me.txtTaksitSayisi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTaksitSayisi.CustomButton.UseSelectable = True
        Me.txtTaksitSayisi.CustomButton.Visible = False
        Me.txtTaksitSayisi.Lines = New String(-1) {}
        Me.txtTaksitSayisi.Location = New System.Drawing.Point(155, 142)
        Me.txtTaksitSayisi.MaxLength = 4
        Me.txtTaksitSayisi.Name = "txtTaksitSayisi"
        Me.txtTaksitSayisi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTaksitSayisi.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTaksitSayisi.SelectedText = ""
        Me.txtTaksitSayisi.SelectionLength = 0
        Me.txtTaksitSayisi.SelectionStart = 0
        Me.txtTaksitSayisi.ShortcutsEnabled = True
        Me.txtTaksitSayisi.Size = New System.Drawing.Size(41, 29)
        Me.txtTaksitSayisi.TabIndex = 14
        Me.txtTaksitSayisi.UseSelectable = True
        Me.txtTaksitSayisi.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTaksitSayisi.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnSil
        '
        Me.btnSil.ActiveControl = Nothing
        Me.btnSil.Enabled = False
        Me.btnSil.Location = New System.Drawing.Point(434, 191)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(87, 75)
        Me.btnSil.TabIndex = 10
        Me.btnSil.Text = "Sil"
        Me.btnSil.TileImage = CType(resources.GetObject("btnSil.TileImage"), System.Drawing.Image)
        Me.btnSil.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnSil.UseSelectable = True
        Me.btnSil.UseTileImage = True
        '
        'cbbOdemeTipi
        '
        Me.cbbOdemeTipi.FormattingEnabled = True
        Me.cbbOdemeTipi.ItemHeight = 23
        Me.cbbOdemeTipi.Items.AddRange(New Object() {"Nakit", "Kredi Kartı", "Elden", "Çek", "Diğer"})
        Me.cbbOdemeTipi.Location = New System.Drawing.Point(155, 64)
        Me.cbbOdemeTipi.Name = "cbbOdemeTipi"
        Me.cbbOdemeTipi.Size = New System.Drawing.Size(121, 29)
        Me.cbbOdemeTipi.TabIndex = 5
        Me.cbbOdemeTipi.UseSelectable = True
        '
        'btnGuncelle
        '
        Me.btnGuncelle.ActiveControl = Nothing
        Me.btnGuncelle.Enabled = False
        Me.btnGuncelle.Location = New System.Drawing.Point(341, 191)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(87, 75)
        Me.btnGuncelle.TabIndex = 11
        Me.btnGuncelle.Text = "Guncelle"
        Me.btnGuncelle.TileImage = CType(resources.GetObject("btnGuncelle.TileImage"), System.Drawing.Image)
        Me.btnGuncelle.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnGuncelle.UseSelectable = True
        Me.btnGuncelle.UseTileImage = True
        '
        'dtIlkOdemeTarihi
        '
        Me.dtIlkOdemeTarihi.Location = New System.Drawing.Point(479, 20)
        Me.dtIlkOdemeTarihi.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtIlkOdemeTarihi.Name = "dtIlkOdemeTarihi"
        Me.dtIlkOdemeTarihi.Size = New System.Drawing.Size(205, 29)
        Me.dtIlkOdemeTarihi.TabIndex = 4
        '
        'txtAciklama
        '
        '
        '
        '
        Me.txtAciklama.CustomButton.Image = Nothing
        Me.txtAciklama.CustomButton.Location = New System.Drawing.Point(182, 1)
        Me.txtAciklama.CustomButton.Name = ""
        Me.txtAciklama.CustomButton.Size = New System.Drawing.Size(75, 75)
        Me.txtAciklama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAciklama.CustomButton.TabIndex = 1
        Me.txtAciklama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAciklama.CustomButton.UseSelectable = True
        Me.txtAciklama.CustomButton.Visible = False
        Me.txtAciklama.Lines = New String(-1) {}
        Me.txtAciklama.Location = New System.Drawing.Point(479, 64)
        Me.txtAciklama.MaxLength = 32767
        Me.txtAciklama.Multiline = True
        Me.txtAciklama.Name = "txtAciklama"
        Me.txtAciklama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAciklama.SelectedText = ""
        Me.txtAciklama.SelectionLength = 0
        Me.txtAciklama.SelectionStart = 0
        Me.txtAciklama.ShortcutsEnabled = True
        Me.txtAciklama.Size = New System.Drawing.Size(258, 77)
        Me.txtAciklama.TabIndex = 3
        Me.txtAciklama.UseSelectable = True
        Me.txtAciklama.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAciklama.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnKaydet
        '
        Me.btnKaydet.ActiveControl = Nothing
        Me.btnKaydet.Location = New System.Drawing.Point(248, 191)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(87, 75)
        Me.btnKaydet.TabIndex = 12
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.TileImage = CType(resources.GetObject("btnKaydet.TileImage"), System.Drawing.Image)
        Me.btnKaydet.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnKaydet.UseSelectable = True
        Me.btnKaydet.UseTileImage = True
        '
        'txtOdemeMiktari
        '
        '
        '
        '
        Me.txtOdemeMiktari.CustomButton.Image = Nothing
        Me.txtOdemeMiktari.CustomButton.Location = New System.Drawing.Point(93, 1)
        Me.txtOdemeMiktari.CustomButton.Name = ""
        Me.txtOdemeMiktari.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtOdemeMiktari.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtOdemeMiktari.CustomButton.TabIndex = 1
        Me.txtOdemeMiktari.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtOdemeMiktari.CustomButton.UseSelectable = True
        Me.txtOdemeMiktari.CustomButton.Visible = False
        Me.txtOdemeMiktari.Lines = New String(-1) {}
        Me.txtOdemeMiktari.Location = New System.Drawing.Point(155, 103)
        Me.txtOdemeMiktari.MaxLength = 9
        Me.txtOdemeMiktari.Name = "txtOdemeMiktari"
        Me.txtOdemeMiktari.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOdemeMiktari.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtOdemeMiktari.SelectedText = ""
        Me.txtOdemeMiktari.SelectionLength = 0
        Me.txtOdemeMiktari.SelectionStart = 0
        Me.txtOdemeMiktari.ShortcutsEnabled = True
        Me.txtOdemeMiktari.Size = New System.Drawing.Size(121, 29)
        Me.txtOdemeMiktari.TabIndex = 3
        Me.txtOdemeMiktari.UseSelectable = True
        Me.txtOdemeMiktari.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtOdemeMiktari.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnYeni
        '
        Me.btnYeni.ActiveControl = Nothing
        Me.btnYeni.Location = New System.Drawing.Point(155, 191)
        Me.btnYeni.Name = "btnYeni"
        Me.btnYeni.Size = New System.Drawing.Size(87, 75)
        Me.btnYeni.TabIndex = 13
        Me.btnYeni.Text = "Yeni"
        Me.btnYeni.TileImage = CType(resources.GetObject("btnYeni.TileImage"), System.Drawing.Image)
        Me.btnYeni.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnYeni.UseSelectable = True
        Me.btnYeni.UseTileImage = True
        '
        'txtOdemeBasligi
        '
        '
        '
        '
        Me.txtOdemeBasligi.CustomButton.Image = Nothing
        Me.txtOdemeBasligi.CustomButton.Location = New System.Drawing.Point(153, 1)
        Me.txtOdemeBasligi.CustomButton.Name = ""
        Me.txtOdemeBasligi.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtOdemeBasligi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtOdemeBasligi.CustomButton.TabIndex = 1
        Me.txtOdemeBasligi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtOdemeBasligi.CustomButton.UseSelectable = True
        Me.txtOdemeBasligi.CustomButton.Visible = False
        Me.txtOdemeBasligi.Lines = New String(-1) {}
        Me.txtOdemeBasligi.Location = New System.Drawing.Point(155, 26)
        Me.txtOdemeBasligi.MaxLength = 32767
        Me.txtOdemeBasligi.Name = "txtOdemeBasligi"
        Me.txtOdemeBasligi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOdemeBasligi.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtOdemeBasligi.SelectedText = ""
        Me.txtOdemeBasligi.SelectionLength = 0
        Me.txtOdemeBasligi.SelectionStart = 0
        Me.txtOdemeBasligi.ShortcutsEnabled = True
        Me.txtOdemeBasligi.Size = New System.Drawing.Size(181, 29)
        Me.txtOdemeBasligi.TabIndex = 3
        Me.txtOdemeBasligi.UseSelectable = True
        Me.txtOdemeBasligi.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtOdemeBasligi.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblTaksitPeriyodu
        '
        Me.lblTaksitPeriyodu.AutoSize = True
        Me.lblTaksitPeriyodu.Location = New System.Drawing.Point(195, 146)
        Me.lblTaksitPeriyodu.Name = "lblTaksitPeriyodu"
        Me.lblTaksitPeriyodu.Size = New System.Drawing.Size(101, 19)
        Me.lblTaksitPeriyodu.TabIndex = 2
        Me.lblTaksitPeriyodu.Text = "Taksit Periyodu: "
        '
        'lblTaksitSayisi
        '
        Me.lblTaksitSayisi.AutoSize = True
        Me.lblTaksitSayisi.Location = New System.Drawing.Point(15, 145)
        Me.lblTaksitSayisi.Name = "lblTaksitSayisi"
        Me.lblTaksitSayisi.Size = New System.Drawing.Size(81, 19)
        Me.lblTaksitSayisi.TabIndex = 2
        Me.lblTaksitSayisi.Text = "Taksit Sayısı: "
        '
        'lblOdemeMiktari
        '
        Me.lblOdemeMiktari.AutoSize = True
        Me.lblOdemeMiktari.Location = New System.Drawing.Point(15, 103)
        Me.lblOdemeMiktari.Name = "lblOdemeMiktari"
        Me.lblOdemeMiktari.Size = New System.Drawing.Size(109, 19)
        Me.lblOdemeMiktari.TabIndex = 2
        Me.lblOdemeMiktari.Text = "Ödeme Miktarı : "
        '
        'lblAciklama
        '
        Me.lblAciklama.AutoSize = True
        Me.lblAciklama.Location = New System.Drawing.Point(410, 64)
        Me.lblAciklama.Name = "lblAciklama"
        Me.lblAciklama.Size = New System.Drawing.Size(69, 19)
        Me.lblAciklama.TabIndex = 2
        Me.lblAciklama.Text = "Açıklama :"
        '
        'lblIlkOdemeTarihi
        '
        Me.lblIlkOdemeTarihi.AutoSize = True
        Me.lblIlkOdemeTarihi.Location = New System.Drawing.Point(368, 26)
        Me.lblIlkOdemeTarihi.Name = "lblIlkOdemeTarihi"
        Me.lblIlkOdemeTarihi.Size = New System.Drawing.Size(111, 19)
        Me.lblIlkOdemeTarihi.TabIndex = 2
        Me.lblIlkOdemeTarihi.Text = "İlk Ödeme Tarihi :"
        '
        'lblOdemeTipi
        '
        Me.lblOdemeTipi.AutoSize = True
        Me.lblOdemeTipi.Location = New System.Drawing.Point(15, 64)
        Me.lblOdemeTipi.Name = "lblOdemeTipi"
        Me.lblOdemeTipi.Size = New System.Drawing.Size(86, 19)
        Me.lblOdemeTipi.TabIndex = 2
        Me.lblOdemeTipi.Text = "Ödeme Tipi :"
        '
        'lblOdemeBasligi
        '
        Me.lblOdemeBasligi.AutoSize = True
        Me.lblOdemeBasligi.Location = New System.Drawing.Point(15, 26)
        Me.lblOdemeBasligi.Name = "lblOdemeBasligi"
        Me.lblOdemeBasligi.Size = New System.Drawing.Size(102, 19)
        Me.lblOdemeBasligi.TabIndex = 2
        Me.lblOdemeBasligi.Text = "Ödeme Başlığı :"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 2)
        Me.Label1.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblIslemiAktif)
        Me.GroupBox2.Controls.Add(Me.btnYazdir)
        Me.GroupBox2.Controls.Add(Me.toggleAktif)
        Me.GroupBox2.Controls.Add(Me.btnExceleAktar)
        Me.GroupBox2.Location = New System.Drawing.Point(794, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(263, 133)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'lblIslemiAktif
        '
        Me.lblIslemiAktif.AutoSize = True
        Me.lblIslemiAktif.Location = New System.Drawing.Point(21, 15)
        Me.lblIslemiAktif.Name = "lblIslemiAktif"
        Me.lblIslemiAktif.Size = New System.Drawing.Size(115, 19)
        Me.lblIslemiAktif.TabIndex = 11
        Me.lblIslemiAktif.Text = "İşlemleri Aktif Yap:"
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
        Me.btnClosed.Location = New System.Drawing.Point(1026, 6)
        Me.btnClosed.Name = "btnClosed"
        Me.btnClosed.Size = New System.Drawing.Size(86, 61)
        Me.btnClosed.TabIndex = 14
        Me.btnClosed.Text = "WindowsUIButtonPanel1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.calcHesapMakinesi)
        Me.GroupBox3.Controls.Add(Me.lblHesapMakinesi)
        Me.GroupBox3.Location = New System.Drawing.Point(794, 125)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(263, 87)
        Me.GroupBox3.TabIndex = 18
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
        Me.dtwKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtwKayitlar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column8, Me.Column4, Me.Column7, Me.Column6})
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
        Me.dtwKayitlar.Location = New System.Drawing.Point(20, 355)
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
        Me.dtwKayitlar.Size = New System.Drawing.Size(1065, 325)
        Me.dtwKayitlar.TabIndex = 19
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
        Me.Column2.HeaderText = "Ödeme Tipi"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.FillWeight = 3.412547!
        Me.Column3.HeaderText = "Ödeme Miktarı"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Taksit Sayısı"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Taksit Periyodu"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.FillWeight = 3.415158!
        Me.Column4.HeaderText = "İlk Ödeme Tarihi"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 120
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.FillWeight = 679.5114!
        Me.Column7.HeaderText = "Açıklama"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
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
        Me.txtKayitId.Location = New System.Drawing.Point(794, 91)
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
        'Form_Taksitler
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
        Me.Name = "Form_Taksitler"
        Me.Resizable = False
        Me.Text = "TAKSİTLERİM"
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

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSil As MetroFramework.Controls.MetroTile
    Friend WithEvents cbbOdemeTipi As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnGuncelle As MetroFramework.Controls.MetroTile
    Friend WithEvents dtIlkOdemeTarihi As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtAciklama As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnKaydet As MetroFramework.Controls.MetroTile
    Friend WithEvents txtOdemeMiktari As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnYeni As MetroFramework.Controls.MetroTile
    Friend WithEvents txtOdemeBasligi As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblOdemeMiktari As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblAciklama As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblIlkOdemeTarihi As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblOdemeTipi As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblOdemeBasligi As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblGun As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTaksitSayisi As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblTaksitPeriyodu As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTaksitSayisi As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblIslemiAktif As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnYazdir As MetroFramework.Controls.MetroTile
    Friend WithEvents toggleAktif As MetroFramework.Controls.MetroToggle
    Friend WithEvents btnExceleAktar As MetroFramework.Controls.MetroTile
    Friend WithEvents btnClosed As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents calcHesapMakinesi As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents lblHesapMakinesi As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtwKayitlar As MetroFramework.Controls.MetroGrid
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents cbbTaksitPeriyodu As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtKayitId As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCikanMiktar As MetroFramework.Controls.MetroLabel
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
