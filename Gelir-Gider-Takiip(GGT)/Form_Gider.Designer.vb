<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Gider
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Gider))
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOdemeBasligi = New MetroFramework.Controls.MetroLabel()
        Me.lblOdemeSekli = New MetroFramework.Controls.MetroLabel()
        Me.lblOdemeMiktari = New MetroFramework.Controls.MetroLabel()
        Me.lblOdemeTarihi = New MetroFramework.Controls.MetroLabel()
        Me.lblOdenenYer = New MetroFramework.Controls.MetroLabel()
        Me.lblAciklama = New MetroFramework.Controls.MetroLabel()
        Me.lblHesapMakinesi = New MetroFramework.Controls.MetroLabel()
        Me.txtOdemeBasligi = New MetroFramework.Controls.MetroTextBox()
        Me.txtOdemeMiktari = New MetroFramework.Controls.MetroTextBox()
        Me.txtOdenenYer = New MetroFramework.Controls.MetroTextBox()
        Me.txtAciklama = New MetroFramework.Controls.MetroTextBox()
        Me.dtOdemeTarih = New MetroFramework.Controls.MetroDateTime()
        Me.cbbOdemeSekli = New MetroFramework.Controls.MetroComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCikanMiktar = New MetroFramework.Controls.MetroLabel()
        Me.btnSil = New MetroFramework.Controls.MetroTile()
        Me.btnGuncelle = New MetroFramework.Controls.MetroTile()
        Me.btnKaydet = New MetroFramework.Controls.MetroTile()
        Me.btnYeni = New MetroFramework.Controls.MetroTile()
        Me.calcHesapMakinesi = New DevExpress.XtraEditors.CalcEdit()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblAktifEt = New MetroFramework.Controls.MetroLabel()
        Me.btnYazdir = New MetroFramework.Controls.MetroTile()
        Me.toggleAktif = New MetroFramework.Controls.MetroToggle()
        Me.btnExceleAktar = New MetroFramework.Controls.MetroTile()
        Me.btnClosed = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.dtwKayitlar = New MetroFramework.Controls.MetroGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtKayitId = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.calcHesapMakinesi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtwKayitlar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 2)
        Me.Label1.TabIndex = 1
        '
        'lblOdemeBasligi
        '
        Me.lblOdemeBasligi.AutoSize = True
        Me.lblOdemeBasligi.Location = New System.Drawing.Point(7, 27)
        Me.lblOdemeBasligi.Name = "lblOdemeBasligi"
        Me.lblOdemeBasligi.Size = New System.Drawing.Size(102, 19)
        Me.lblOdemeBasligi.TabIndex = 2
        Me.lblOdemeBasligi.Text = "Ödeme Başlığı :"
        '
        'lblOdemeSekli
        '
        Me.lblOdemeSekli.AutoSize = True
        Me.lblOdemeSekli.Location = New System.Drawing.Point(7, 69)
        Me.lblOdemeSekli.Name = "lblOdemeSekli"
        Me.lblOdemeSekli.Size = New System.Drawing.Size(84, 19)
        Me.lblOdemeSekli.TabIndex = 2
        Me.lblOdemeSekli.Text = "Ödeme Şekli"
        '
        'lblOdemeMiktari
        '
        Me.lblOdemeMiktari.AutoSize = True
        Me.lblOdemeMiktari.Location = New System.Drawing.Point(7, 112)
        Me.lblOdemeMiktari.Name = "lblOdemeMiktari"
        Me.lblOdemeMiktari.Size = New System.Drawing.Size(105, 19)
        Me.lblOdemeMiktari.TabIndex = 2
        Me.lblOdemeMiktari.Text = "Ödeme Miktarı :"
        '
        'lblOdemeTarihi
        '
        Me.lblOdemeTarihi.AutoSize = True
        Me.lblOdemeTarihi.Location = New System.Drawing.Point(331, 27)
        Me.lblOdemeTarihi.Name = "lblOdemeTarihi"
        Me.lblOdemeTarihi.Size = New System.Drawing.Size(95, 19)
        Me.lblOdemeTarihi.TabIndex = 2
        Me.lblOdemeTarihi.Text = "Ödeme Tarihi :"
        '
        'lblOdenenYer
        '
        Me.lblOdenenYer.AutoSize = True
        Me.lblOdenenYer.Location = New System.Drawing.Point(331, 64)
        Me.lblOdenenYer.Name = "lblOdenenYer"
        Me.lblOdenenYer.Size = New System.Drawing.Size(85, 19)
        Me.lblOdenenYer.TabIndex = 2
        Me.lblOdenenYer.Text = "Ödenen Yer :"
        '
        'lblAciklama
        '
        Me.lblAciklama.AutoSize = True
        Me.lblAciklama.Location = New System.Drawing.Point(331, 101)
        Me.lblAciklama.Name = "lblAciklama"
        Me.lblAciklama.Size = New System.Drawing.Size(69, 19)
        Me.lblAciklama.TabIndex = 3
        Me.lblAciklama.Text = "Açıklama :"
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
        'txtOdemeBasligi
        '
        '
        '
        '
        Me.txtOdemeBasligi.CustomButton.Image = Nothing
        Me.txtOdemeBasligi.CustomButton.Location = New System.Drawing.Point(130, 1)
        Me.txtOdemeBasligi.CustomButton.Name = ""
        Me.txtOdemeBasligi.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtOdemeBasligi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtOdemeBasligi.CustomButton.TabIndex = 1
        Me.txtOdemeBasligi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtOdemeBasligi.CustomButton.UseSelectable = True
        Me.txtOdemeBasligi.CustomButton.Visible = False
        Me.txtOdemeBasligi.Lines = New String(-1) {}
        Me.txtOdemeBasligi.Location = New System.Drawing.Point(148, 21)
        Me.txtOdemeBasligi.MaxLength = 32767
        Me.txtOdemeBasligi.Name = "txtOdemeBasligi"
        Me.txtOdemeBasligi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOdemeBasligi.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtOdemeBasligi.SelectedText = ""
        Me.txtOdemeBasligi.SelectionLength = 0
        Me.txtOdemeBasligi.SelectionStart = 0
        Me.txtOdemeBasligi.ShortcutsEnabled = True
        Me.txtOdemeBasligi.Size = New System.Drawing.Size(158, 29)
        Me.txtOdemeBasligi.TabIndex = 3
        Me.txtOdemeBasligi.UseSelectable = True
        Me.txtOdemeBasligi.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtOdemeBasligi.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtOdemeMiktari
        '
        '
        '
        '
        Me.txtOdemeMiktari.CustomButton.Image = Nothing
        Me.txtOdemeMiktari.CustomButton.Location = New System.Drawing.Point(130, 1)
        Me.txtOdemeMiktari.CustomButton.Name = ""
        Me.txtOdemeMiktari.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtOdemeMiktari.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtOdemeMiktari.CustomButton.TabIndex = 1
        Me.txtOdemeMiktari.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtOdemeMiktari.CustomButton.UseSelectable = True
        Me.txtOdemeMiktari.CustomButton.Visible = False
        Me.txtOdemeMiktari.Lines = New String(-1) {}
        Me.txtOdemeMiktari.Location = New System.Drawing.Point(148, 107)
        Me.txtOdemeMiktari.MaxLength = 9
        Me.txtOdemeMiktari.Name = "txtOdemeMiktari"
        Me.txtOdemeMiktari.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOdemeMiktari.PromptText = "0.00 ₺"
        Me.txtOdemeMiktari.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtOdemeMiktari.SelectedText = ""
        Me.txtOdemeMiktari.SelectionLength = 0
        Me.txtOdemeMiktari.SelectionStart = 0
        Me.txtOdemeMiktari.ShortcutsEnabled = True
        Me.txtOdemeMiktari.Size = New System.Drawing.Size(158, 29)
        Me.txtOdemeMiktari.TabIndex = 5
        Me.txtOdemeMiktari.UseSelectable = True
        Me.txtOdemeMiktari.WaterMark = "0.00 ₺"
        Me.txtOdemeMiktari.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtOdemeMiktari.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtOdenenYer
        '
        '
        '
        '
        Me.txtOdenenYer.CustomButton.Image = Nothing
        Me.txtOdenenYer.CustomButton.Location = New System.Drawing.Point(121, 1)
        Me.txtOdenenYer.CustomButton.Name = ""
        Me.txtOdenenYer.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtOdenenYer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtOdenenYer.CustomButton.TabIndex = 1
        Me.txtOdenenYer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtOdenenYer.CustomButton.UseSelectable = True
        Me.txtOdenenYer.CustomButton.Visible = False
        Me.txtOdenenYer.Lines = New String(-1) {}
        Me.txtOdenenYer.Location = New System.Drawing.Point(427, 59)
        Me.txtOdenenYer.MaxLength = 32767
        Me.txtOdenenYer.Name = "txtOdenenYer"
        Me.txtOdenenYer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOdenenYer.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtOdenenYer.SelectedText = ""
        Me.txtOdenenYer.SelectionLength = 0
        Me.txtOdenenYer.SelectionStart = 0
        Me.txtOdenenYer.ShortcutsEnabled = True
        Me.txtOdenenYer.Size = New System.Drawing.Size(149, 29)
        Me.txtOdenenYer.TabIndex = 7
        Me.txtOdenenYer.UseSelectable = True
        Me.txtOdenenYer.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtOdenenYer.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtAciklama
        '
        '
        '
        '
        Me.txtAciklama.CustomButton.Image = Nothing
        Me.txtAciklama.CustomButton.Location = New System.Drawing.Point(219, 2)
        Me.txtAciklama.CustomButton.Name = ""
        Me.txtAciklama.CustomButton.Size = New System.Drawing.Size(55, 55)
        Me.txtAciklama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAciklama.CustomButton.TabIndex = 1
        Me.txtAciklama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAciklama.CustomButton.UseSelectable = True
        Me.txtAciklama.CustomButton.Visible = False
        Me.txtAciklama.Lines = New String(-1) {}
        Me.txtAciklama.Location = New System.Drawing.Point(427, 96)
        Me.txtAciklama.MaxLength = 32767
        Me.txtAciklama.Multiline = True
        Me.txtAciklama.Name = "txtAciklama"
        Me.txtAciklama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAciklama.SelectedText = ""
        Me.txtAciklama.SelectionLength = 0
        Me.txtAciklama.SelectionStart = 0
        Me.txtAciklama.ShortcutsEnabled = True
        Me.txtAciklama.Size = New System.Drawing.Size(277, 60)
        Me.txtAciklama.TabIndex = 8
        Me.txtAciklama.UseSelectable = True
        Me.txtAciklama.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAciklama.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dtOdemeTarih
        '
        Me.dtOdemeTarih.Location = New System.Drawing.Point(427, 21)
        Me.dtOdemeTarih.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtOdemeTarih.Name = "dtOdemeTarih"
        Me.dtOdemeTarih.Size = New System.Drawing.Size(200, 29)
        Me.dtOdemeTarih.TabIndex = 6
        '
        'cbbOdemeSekli
        '
        Me.cbbOdemeSekli.ItemHeight = 23
        Me.cbbOdemeSekli.Items.AddRange(New Object() {"Nakit", "Kredi Kartı", "Elden", "Çek", "Diğer"})
        Me.cbbOdemeSekli.Location = New System.Drawing.Point(148, 64)
        Me.cbbOdemeSekli.Name = "cbbOdemeSekli"
        Me.cbbOdemeSekli.Size = New System.Drawing.Size(121, 29)
        Me.cbbOdemeSekli.TabIndex = 4
        Me.cbbOdemeSekli.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCikanMiktar)
        Me.GroupBox1.Controls.Add(Me.btnSil)
        Me.GroupBox1.Controls.Add(Me.btnGuncelle)
        Me.GroupBox1.Controls.Add(Me.cbbOdemeSekli)
        Me.GroupBox1.Controls.Add(Me.btnKaydet)
        Me.GroupBox1.Controls.Add(Me.dtOdemeTarih)
        Me.GroupBox1.Controls.Add(Me.btnYeni)
        Me.GroupBox1.Controls.Add(Me.txtAciklama)
        Me.GroupBox1.Controls.Add(Me.txtOdenenYer)
        Me.GroupBox1.Controls.Add(Me.txtOdemeMiktari)
        Me.GroupBox1.Controls.Add(Me.txtOdemeBasligi)
        Me.GroupBox1.Controls.Add(Me.lblAciklama)
        Me.GroupBox1.Controls.Add(Me.lblOdenenYer)
        Me.GroupBox1.Controls.Add(Me.lblOdemeTarihi)
        Me.GroupBox1.Controls.Add(Me.lblOdemeMiktari)
        Me.GroupBox1.Controls.Add(Me.lblOdemeSekli)
        Me.GroupBox1.Controls.Add(Me.lblOdemeBasligi)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(723, 268)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'lblCikanMiktar
        '
        Me.lblCikanMiktar.AutoSize = True
        Me.lblCikanMiktar.Location = New System.Drawing.Point(148, 139)
        Me.lblCikanMiktar.Name = "lblCikanMiktar"
        Me.lblCikanMiktar.Size = New System.Drawing.Size(44, 19)
        Me.lblCikanMiktar.TabIndex = 13
        Me.lblCikanMiktar.Text = "0.00 ₺"
        Me.lblCikanMiktar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSil
        '
        Me.btnSil.ActiveControl = Nothing
        Me.btnSil.Location = New System.Drawing.Point(427, 177)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(87, 75)
        Me.btnSil.TabIndex = 12
        Me.btnSil.Text = "Sil"
        Me.btnSil.TileImage = CType(resources.GetObject("btnSil.TileImage"), System.Drawing.Image)
        Me.btnSil.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnSil.UseSelectable = True
        Me.btnSil.UseTileImage = True
        '
        'btnGuncelle
        '
        Me.btnGuncelle.ActiveControl = Nothing
        Me.btnGuncelle.Location = New System.Drawing.Point(334, 177)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(87, 75)
        Me.btnGuncelle.TabIndex = 11
        Me.btnGuncelle.Text = "Guncelle"
        Me.btnGuncelle.TileImage = CType(resources.GetObject("btnGuncelle.TileImage"), System.Drawing.Image)
        Me.btnGuncelle.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnGuncelle.UseSelectable = True
        Me.btnGuncelle.UseTileImage = True
        '
        'btnKaydet
        '
        Me.btnKaydet.ActiveControl = Nothing
        Me.btnKaydet.Location = New System.Drawing.Point(241, 177)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(87, 75)
        Me.btnKaydet.TabIndex = 10
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.TileImage = CType(resources.GetObject("btnKaydet.TileImage"), System.Drawing.Image)
        Me.btnKaydet.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnKaydet.UseSelectable = True
        Me.btnKaydet.UseTileImage = True
        '
        'btnYeni
        '
        Me.btnYeni.ActiveControl = Nothing
        Me.btnYeni.Location = New System.Drawing.Point(148, 177)
        Me.btnYeni.Name = "btnYeni"
        Me.btnYeni.Size = New System.Drawing.Size(87, 75)
        Me.btnYeni.TabIndex = 9
        Me.btnYeni.Text = "Yeni"
        Me.btnYeni.TileImage = CType(resources.GetObject("btnYeni.TileImage"), System.Drawing.Image)
        Me.btnYeni.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnYeni.UseSelectable = True
        Me.btnYeni.UseTileImage = True
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblAktifEt)
        Me.GroupBox2.Controls.Add(Me.btnYazdir)
        Me.GroupBox2.Controls.Add(Me.toggleAktif)
        Me.GroupBox2.Controls.Add(Me.btnExceleAktar)
        Me.GroupBox2.Location = New System.Drawing.Point(764, 202)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(263, 133)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'lblAktifEt
        '
        Me.lblAktifEt.AutoSize = True
        Me.lblAktifEt.Location = New System.Drawing.Point(21, 15)
        Me.lblAktifEt.Name = "lblAktifEt"
        Me.lblAktifEt.Size = New System.Drawing.Size(115, 19)
        Me.lblAktifEt.TabIndex = 11
        Me.lblAktifEt.Text = "İşlemleri Aktif Yap:"
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
        Me.toggleAktif.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.btnClosed.Location = New System.Drawing.Point(1045, 6)
        Me.btnClosed.Name = "btnClosed"
        Me.btnClosed.Size = New System.Drawing.Size(55, 62)
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
        Me.dtwKayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtwKayitlar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
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
        Me.dtwKayitlar.Location = New System.Drawing.Point(20, 344)
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
        Me.dtwKayitlar.Size = New System.Drawing.Size(1065, 336)
        Me.dtwKayitlar.TabIndex = 15
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
        Me.Column2.HeaderText = "Ödeme Şekli"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.FillWeight = 3.412547!
        Me.Column3.HeaderText = "Ödeme Miktari"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.FillWeight = 3.415158!
        Me.Column4.HeaderText = "Ödeme Tarihi"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 120
        '
        'Column5
        '
        Me.Column5.FillWeight = 3.41574!
        Me.Column5.HeaderText = "Ödenen Yer"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 120
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
        'Column8
        '
        Me.Column8.HeaderText = "id"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.calcHesapMakinesi)
        Me.GroupBox3.Controls.Add(Me.lblHesapMakinesi)
        Me.GroupBox3.Location = New System.Drawing.Point(764, 109)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(263, 87)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
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
        Me.txtKayitId.Location = New System.Drawing.Point(764, 80)
        Me.txtKayitId.MaxLength = 32767
        Me.txtKayitId.Name = "txtKayitId"
        Me.txtKayitId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKayitId.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtKayitId.SelectedText = ""
        Me.txtKayitId.SelectionLength = 0
        Me.txtKayitId.SelectionStart = 0
        Me.txtKayitId.ShortcutsEnabled = True
        Me.txtKayitId.Size = New System.Drawing.Size(75, 23)
        Me.txtKayitId.TabIndex = 17
        Me.txtKayitId.UseSelectable = True
        Me.txtKayitId.Visible = False
        Me.txtKayitId.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtKayitId.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Form_Gider
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtKayitId)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dtwKayitlar)
        Me.Controls.Add(Me.btnClosed)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "Form_Gider"
        Me.Text = "GİDERLERİM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.calcHesapMakinesi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtwKayitlar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblOdemeBasligi As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblOdemeSekli As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblOdemeMiktari As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblOdemeTarihi As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblOdenenYer As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblAciklama As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblHesapMakinesi As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtOdemeBasligi As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtOdemeMiktari As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtOdenenYer As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAciklama As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dtOdemeTarih As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cbbOdemeSekli As MetroFramework.Controls.MetroComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents calcHesapMakinesi As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents btnSil As MetroFramework.Controls.MetroTile
    Friend WithEvents btnGuncelle As MetroFramework.Controls.MetroTile
    Friend WithEvents btnKaydet As MetroFramework.Controls.MetroTile
    Friend WithEvents btnYeni As MetroFramework.Controls.MetroTile
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblAktifEt As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnYazdir As MetroFramework.Controls.MetroTile
    Friend WithEvents toggleAktif As MetroFramework.Controls.MetroToggle
    Friend WithEvents btnExceleAktar As MetroFramework.Controls.MetroTile
    Friend WithEvents btnClosed As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtwKayitlar As MetroFramework.Controls.MetroGrid
    Friend WithEvents lblCikanMiktar As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtKayitId As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
