<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Rehberim
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Rehberim))
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MtxtEvTel = New System.Windows.Forms.MaskedTextBox()
        Me.MtxtCepTel2 = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtCepTel = New System.Windows.Forms.MaskedTextBox()
        Me.txtRumuz = New MetroFramework.Controls.MetroTextBox()
        Me.txtMail2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtMail = New MetroFramework.Controls.MetroTextBox()
        Me.dtKayitTarihi = New MetroFramework.Controls.MetroDateTime()
        Me.lblRumuz = New MetroFramework.Controls.MetroLabel()
        Me.btnSil = New MetroFramework.Controls.MetroTile()
        Me.lblMail = New MetroFramework.Controls.MetroLabel()
        Me.txtAdSoyad = New MetroFramework.Controls.MetroTextBox()
        Me.btnGuncelle = New MetroFramework.Controls.MetroTile()
        Me.lblKayitTarihi = New MetroFramework.Controls.MetroLabel()
        Me.lblEvTel = New MetroFramework.Controls.MetroLabel()
        Me.lblMail2 = New MetroFramework.Controls.MetroLabel()
        Me.btnKaydet = New MetroFramework.Controls.MetroTile()
        Me.btnYeni = New MetroFramework.Controls.MetroTile()
        Me.txtBaslik = New MetroFramework.Controls.MetroTextBox()
        Me.lblCepTel2 = New MetroFramework.Controls.MetroLabel()
        Me.lblCeptel = New MetroFramework.Controls.MetroLabel()
        Me.lblAdSoyad = New MetroFramework.Controls.MetroLabel()
        Me.lblBaslik = New MetroFramework.Controls.MetroLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblIslemiAktif = New MetroFramework.Controls.MetroLabel()
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
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtKayitId = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtwKayitlar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MtxtEvTel)
        Me.GroupBox1.Controls.Add(Me.MtxtCepTel2)
        Me.GroupBox1.Controls.Add(Me.mtxtCepTel)
        Me.GroupBox1.Controls.Add(Me.txtRumuz)
        Me.GroupBox1.Controls.Add(Me.txtMail2)
        Me.GroupBox1.Controls.Add(Me.txtMail)
        Me.GroupBox1.Controls.Add(Me.dtKayitTarihi)
        Me.GroupBox1.Controls.Add(Me.lblRumuz)
        Me.GroupBox1.Controls.Add(Me.btnSil)
        Me.GroupBox1.Controls.Add(Me.lblMail)
        Me.GroupBox1.Controls.Add(Me.txtAdSoyad)
        Me.GroupBox1.Controls.Add(Me.btnGuncelle)
        Me.GroupBox1.Controls.Add(Me.lblKayitTarihi)
        Me.GroupBox1.Controls.Add(Me.lblEvTel)
        Me.GroupBox1.Controls.Add(Me.lblMail2)
        Me.GroupBox1.Controls.Add(Me.btnKaydet)
        Me.GroupBox1.Controls.Add(Me.btnYeni)
        Me.GroupBox1.Controls.Add(Me.txtBaslik)
        Me.GroupBox1.Controls.Add(Me.lblCepTel2)
        Me.GroupBox1.Controls.Add(Me.lblCeptel)
        Me.GroupBox1.Controls.Add(Me.lblAdSoyad)
        Me.GroupBox1.Controls.Add(Me.lblBaslik)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(841, 271)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'MtxtEvTel
        '
        Me.MtxtEvTel.BeepOnError = True
        Me.MtxtEvTel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MtxtEvTel.Location = New System.Drawing.Point(370, 26)
        Me.MtxtEvTel.Mask = "(999) 000-0000"
        Me.MtxtEvTel.Name = "MtxtEvTel"
        Me.MtxtEvTel.Size = New System.Drawing.Size(137, 29)
        Me.MtxtEvTel.TabIndex = 19
        '
        'MtxtCepTel2
        '
        Me.MtxtCepTel2.BeepOnError = True
        Me.MtxtCepTel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MtxtCepTel2.Location = New System.Drawing.Point(91, 133)
        Me.MtxtCepTel2.Mask = "(999) 000-0000"
        Me.MtxtCepTel2.Name = "MtxtCepTel2"
        Me.MtxtCepTel2.Size = New System.Drawing.Size(144, 29)
        Me.MtxtCepTel2.TabIndex = 19
        '
        'mtxtCepTel
        '
        Me.mtxtCepTel.BeepOnError = True
        Me.mtxtCepTel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.mtxtCepTel.Location = New System.Drawing.Point(91, 96)
        Me.mtxtCepTel.Mask = "(999) 000-0000"
        Me.mtxtCepTel.Name = "mtxtCepTel"
        Me.mtxtCepTel.Size = New System.Drawing.Size(144, 29)
        Me.mtxtCepTel.TabIndex = 19
        '
        'txtRumuz
        '
        '
        '
        '
        Me.txtRumuz.CustomButton.Image = Nothing
        Me.txtRumuz.CustomButton.Location = New System.Drawing.Point(109, 1)
        Me.txtRumuz.CustomButton.Name = ""
        Me.txtRumuz.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtRumuz.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtRumuz.CustomButton.TabIndex = 1
        Me.txtRumuz.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtRumuz.CustomButton.UseSelectable = True
        Me.txtRumuz.CustomButton.Visible = False
        Me.txtRumuz.Lines = New String(-1) {}
        Me.txtRumuz.Location = New System.Drawing.Point(370, 137)
        Me.txtRumuz.MaxLength = 32767
        Me.txtRumuz.Name = "txtRumuz"
        Me.txtRumuz.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRumuz.PromptText = "Takma Ad"
        Me.txtRumuz.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRumuz.SelectedText = ""
        Me.txtRumuz.SelectionLength = 0
        Me.txtRumuz.SelectionStart = 0
        Me.txtRumuz.ShortcutsEnabled = True
        Me.txtRumuz.Size = New System.Drawing.Size(137, 29)
        Me.txtRumuz.TabIndex = 18
        Me.txtRumuz.UseSelectable = True
        Me.txtRumuz.WaterMark = "Takma Ad"
        Me.txtRumuz.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtRumuz.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMail2
        '
        '
        '
        '
        Me.txtMail2.CustomButton.Image = Nothing
        Me.txtMail2.CustomButton.Location = New System.Drawing.Point(138, 1)
        Me.txtMail2.CustomButton.Name = ""
        Me.txtMail2.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtMail2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMail2.CustomButton.TabIndex = 1
        Me.txtMail2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMail2.CustomButton.UseSelectable = True
        Me.txtMail2.CustomButton.Visible = False
        Me.txtMail2.Lines = New String(-1) {}
        Me.txtMail2.Location = New System.Drawing.Point(370, 98)
        Me.txtMail2.MaxLength = 32767
        Me.txtMail2.Name = "txtMail2"
        Me.txtMail2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMail2.PromptText = "mailiniz@MailSunucusu.com"
        Me.txtMail2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMail2.SelectedText = ""
        Me.txtMail2.SelectionLength = 0
        Me.txtMail2.SelectionStart = 0
        Me.txtMail2.ShortcutsEnabled = True
        Me.txtMail2.Size = New System.Drawing.Size(166, 29)
        Me.txtMail2.TabIndex = 14
        Me.txtMail2.UseSelectable = True
        Me.txtMail2.WaterMark = "mailiniz@MailSunucusu.com"
        Me.txtMail2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMail2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMail
        '
        '
        '
        '
        Me.txtMail.CustomButton.Image = Nothing
        Me.txtMail.CustomButton.Location = New System.Drawing.Point(138, 1)
        Me.txtMail.CustomButton.Name = ""
        Me.txtMail.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMail.CustomButton.TabIndex = 1
        Me.txtMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMail.CustomButton.UseSelectable = True
        Me.txtMail.CustomButton.Visible = False
        Me.txtMail.Lines = New String(-1) {}
        Me.txtMail.Location = New System.Drawing.Point(370, 61)
        Me.txtMail.MaxLength = 32767
        Me.txtMail.Name = "txtMail"
        Me.txtMail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMail.PromptText = "mailiniz@MailSunucusu.com"
        Me.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMail.SelectedText = ""
        Me.txtMail.SelectionLength = 0
        Me.txtMail.SelectionStart = 0
        Me.txtMail.ShortcutsEnabled = True
        Me.txtMail.Size = New System.Drawing.Size(166, 29)
        Me.txtMail.TabIndex = 14
        Me.txtMail.UseSelectable = True
        Me.txtMail.WaterMark = "mailiniz@MailSunucusu.com"
        Me.txtMail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dtKayitTarihi
        '
        Me.dtKayitTarihi.Location = New System.Drawing.Point(637, 27)
        Me.dtKayitTarihi.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtKayitTarihi.Name = "dtKayitTarihi"
        Me.dtKayitTarihi.Size = New System.Drawing.Size(182, 29)
        Me.dtKayitTarihi.TabIndex = 4
        '
        'lblRumuz
        '
        Me.lblRumuz.AutoSize = True
        Me.lblRumuz.Location = New System.Drawing.Point(308, 139)
        Me.lblRumuz.Name = "lblRumuz"
        Me.lblRumuz.Size = New System.Drawing.Size(56, 19)
        Me.lblRumuz.TabIndex = 17
        Me.lblRumuz.Text = "Rumuz :"
        '
        'btnSil
        '
        Me.btnSil.ActiveControl = Nothing
        Me.btnSil.Enabled = False
        Me.btnSil.Location = New System.Drawing.Point(370, 183)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(87, 75)
        Me.btnSil.TabIndex = 10
        Me.btnSil.Text = "Sil"
        Me.btnSil.TileImage = CType(resources.GetObject("btnSil.TileImage"), System.Drawing.Image)
        Me.btnSil.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnSil.UseSelectable = True
        Me.btnSil.UseTileImage = True
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(308, 65)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(41, 19)
        Me.lblMail.TabIndex = 16
        Me.lblMail.Text = "Mail :"
        '
        'txtAdSoyad
        '
        '
        '
        '
        Me.txtAdSoyad.CustomButton.Image = Nothing
        Me.txtAdSoyad.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.txtAdSoyad.CustomButton.Name = ""
        Me.txtAdSoyad.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtAdSoyad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAdSoyad.CustomButton.TabIndex = 1
        Me.txtAdSoyad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAdSoyad.CustomButton.UseSelectable = True
        Me.txtAdSoyad.CustomButton.Visible = False
        Me.txtAdSoyad.Lines = New String(-1) {}
        Me.txtAdSoyad.Location = New System.Drawing.Point(91, 61)
        Me.txtAdSoyad.MaxLength = 32767
        Me.txtAdSoyad.Name = "txtAdSoyad"
        Me.txtAdSoyad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdSoyad.PromptText = "Örn; Ali KESER"
        Me.txtAdSoyad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAdSoyad.SelectedText = ""
        Me.txtAdSoyad.SelectionLength = 0
        Me.txtAdSoyad.SelectionStart = 0
        Me.txtAdSoyad.ShortcutsEnabled = True
        Me.txtAdSoyad.Size = New System.Drawing.Size(180, 29)
        Me.txtAdSoyad.TabIndex = 15
        Me.txtAdSoyad.UseSelectable = True
        Me.txtAdSoyad.WaterMark = "Örn; Ali KESER"
        Me.txtAdSoyad.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAdSoyad.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnGuncelle
        '
        Me.btnGuncelle.ActiveControl = Nothing
        Me.btnGuncelle.Enabled = False
        Me.btnGuncelle.Location = New System.Drawing.Point(277, 183)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(87, 75)
        Me.btnGuncelle.TabIndex = 11
        Me.btnGuncelle.Text = "Guncelle"
        Me.btnGuncelle.TileImage = CType(resources.GetObject("btnGuncelle.TileImage"), System.Drawing.Image)
        Me.btnGuncelle.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnGuncelle.UseSelectable = True
        Me.btnGuncelle.UseTileImage = True
        '
        'lblKayitTarihi
        '
        Me.lblKayitTarihi.AutoSize = True
        Me.lblKayitTarihi.Location = New System.Drawing.Point(554, 31)
        Me.lblKayitTarihi.Name = "lblKayitTarihi"
        Me.lblKayitTarihi.Size = New System.Drawing.Size(77, 19)
        Me.lblKayitTarihi.TabIndex = 2
        Me.lblKayitTarihi.Text = "Kayıt Tarihi :"
        '
        'lblEvTel
        '
        Me.lblEvTel.AutoSize = True
        Me.lblEvTel.Location = New System.Drawing.Point(308, 27)
        Me.lblEvTel.Name = "lblEvTel"
        Me.lblEvTel.Size = New System.Drawing.Size(48, 19)
        Me.lblEvTel.TabIndex = 2
        Me.lblEvTel.Text = "Ev Tel :"
        '
        'lblMail2
        '
        Me.lblMail2.AutoSize = True
        Me.lblMail2.Location = New System.Drawing.Point(308, 102)
        Me.lblMail2.Name = "lblMail2"
        Me.lblMail2.Size = New System.Drawing.Size(52, 19)
        Me.lblMail2.TabIndex = 2
        Me.lblMail2.Text = "Mail 2 :"
        '
        'btnKaydet
        '
        Me.btnKaydet.ActiveControl = Nothing
        Me.btnKaydet.Location = New System.Drawing.Point(184, 183)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(87, 75)
        Me.btnKaydet.TabIndex = 12
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.TileImage = CType(resources.GetObject("btnKaydet.TileImage"), System.Drawing.Image)
        Me.btnKaydet.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnKaydet.UseSelectable = True
        Me.btnKaydet.UseTileImage = True
        '
        'btnYeni
        '
        Me.btnYeni.ActiveControl = Nothing
        Me.btnYeni.Location = New System.Drawing.Point(91, 183)
        Me.btnYeni.Name = "btnYeni"
        Me.btnYeni.Size = New System.Drawing.Size(87, 75)
        Me.btnYeni.TabIndex = 13
        Me.btnYeni.Text = "Yeni"
        Me.btnYeni.TileImage = CType(resources.GetObject("btnYeni.TileImage"), System.Drawing.Image)
        Me.btnYeni.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnYeni.UseSelectable = True
        Me.btnYeni.UseTileImage = True
        '
        'txtBaslik
        '
        '
        '
        '
        Me.txtBaslik.CustomButton.Image = Nothing
        Me.txtBaslik.CustomButton.Location = New System.Drawing.Point(153, 1)
        Me.txtBaslik.CustomButton.Name = ""
        Me.txtBaslik.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtBaslik.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBaslik.CustomButton.TabIndex = 1
        Me.txtBaslik.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBaslik.CustomButton.UseSelectable = True
        Me.txtBaslik.CustomButton.Visible = False
        Me.txtBaslik.Lines = New String(-1) {}
        Me.txtBaslik.Location = New System.Drawing.Point(91, 26)
        Me.txtBaslik.MaxLength = 32767
        Me.txtBaslik.Name = "txtBaslik"
        Me.txtBaslik.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBaslik.PromptText = "Örn; Ev,Cep, İş"
        Me.txtBaslik.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBaslik.SelectedText = ""
        Me.txtBaslik.SelectionLength = 0
        Me.txtBaslik.SelectionStart = 0
        Me.txtBaslik.ShortcutsEnabled = True
        Me.txtBaslik.Size = New System.Drawing.Size(181, 29)
        Me.txtBaslik.TabIndex = 3
        Me.txtBaslik.UseSelectable = True
        Me.txtBaslik.WaterMark = "Örn; Ev,Cep, İş"
        Me.txtBaslik.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBaslik.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblCepTel2
        '
        Me.lblCepTel2.AutoSize = True
        Me.lblCepTel2.Location = New System.Drawing.Point(15, 133)
        Me.lblCepTel2.Name = "lblCepTel2"
        Me.lblCepTel2.Size = New System.Drawing.Size(70, 19)
        Me.lblCepTel2.TabIndex = 2
        Me.lblCepTel2.Text = "Cep Tel 2 :"
        '
        'lblCeptel
        '
        Me.lblCeptel.AutoSize = True
        Me.lblCeptel.Location = New System.Drawing.Point(15, 94)
        Me.lblCeptel.Name = "lblCeptel"
        Me.lblCeptel.Size = New System.Drawing.Size(59, 19)
        Me.lblCeptel.TabIndex = 2
        Me.lblCeptel.Text = "Cep Tel :"
        '
        'lblAdSoyad
        '
        Me.lblAdSoyad.AutoSize = True
        Me.lblAdSoyad.Location = New System.Drawing.Point(15, 65)
        Me.lblAdSoyad.Name = "lblAdSoyad"
        Me.lblAdSoyad.Size = New System.Drawing.Size(73, 19)
        Me.lblAdSoyad.TabIndex = 2
        Me.lblAdSoyad.Text = "Ad Soyad :"
        '
        'lblBaslik
        '
        Me.lblBaslik.AutoSize = True
        Me.lblBaslik.Location = New System.Drawing.Point(15, 31)
        Me.lblBaslik.Name = "lblBaslik"
        Me.lblBaslik.Size = New System.Drawing.Size(48, 19)
        Me.lblBaslik.TabIndex = 2
        Me.lblBaslik.Text = "Başlık :"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 2)
        Me.Label1.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblIslemiAktif)
        Me.GroupBox2.Controls.Add(Me.btnYazdir)
        Me.GroupBox2.Controls.Add(Me.toggleAktif)
        Me.GroupBox2.Controls.Add(Me.btnExceleAktar)
        Me.GroupBox2.Location = New System.Drawing.Point(871, 209)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(263, 133)
        Me.GroupBox2.TabIndex = 17
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
        Me.btnClosed.Location = New System.Drawing.Point(1087, 6)
        Me.btnClosed.Name = "btnClosed"
        Me.btnClosed.Size = New System.Drawing.Size(62, 61)
        Me.btnClosed.TabIndex = 18
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
        Me.dtwKayitlar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
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
        Me.dtwKayitlar.Location = New System.Drawing.Point(20, 348)
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
        Me.dtwKayitlar.Size = New System.Drawing.Size(1114, 332)
        Me.dtwKayitlar.TabIndex = 19
        '
        'Column1
        '
        Me.Column1.FillWeight = 3.417969!
        Me.Column1.HeaderText = "Banka"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 3.412249!
        Me.Column2.HeaderText = "Ad Soyad"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.FillWeight = 3.412547!
        Me.Column3.HeaderText = "Cep Tel"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.FillWeight = 3.415158!
        Me.Column4.HeaderText = "Cep Tel 2"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 120
        '
        'Column5
        '
        Me.Column5.FillWeight = 3.41574!
        Me.Column5.HeaderText = "Ev Tel"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 120
        '
        'Column6
        '
        Me.Column6.FillWeight = 3.414881!
        Me.Column6.HeaderText = "Mail"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 130
        '
        'Column7
        '
        Me.Column7.HeaderText = "Mail 2"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Rumuz"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column9.HeaderText = "Kayıt Tarihi"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "id"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Visible = False
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
        Me.txtKayitId.Location = New System.Drawing.Point(871, 180)
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
        'Form_Rehberim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 700)
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
        Me.Name = "Form_Rehberim"
        Me.Resizable = False
        Me.Text = "REHBERİM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtwKayitlar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtRumuz As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMail2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dtKayitTarihi As MetroFramework.Controls.MetroDateTime
    Friend WithEvents lblRumuz As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnSil As MetroFramework.Controls.MetroTile
    Friend WithEvents lblMail As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtAdSoyad As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnGuncelle As MetroFramework.Controls.MetroTile
    Friend WithEvents lblKayitTarihi As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblEvTel As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblMail2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnKaydet As MetroFramework.Controls.MetroTile
    Friend WithEvents btnYeni As MetroFramework.Controls.MetroTile
    Friend WithEvents txtBaslik As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCepTel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCeptel As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblAdSoyad As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblBaslik As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblIslemiAktif As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnYazdir As MetroFramework.Controls.MetroTile
    Friend WithEvents toggleAktif As MetroFramework.Controls.MetroToggle
    Friend WithEvents btnExceleAktar As MetroFramework.Controls.MetroTile
    Friend WithEvents btnClosed As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents dtwKayitlar As MetroFramework.Controls.MetroGrid
    Friend WithEvents MtxtEvTel As MaskedTextBox
    Friend WithEvents MtxtCepTel2 As MaskedTextBox
    Friend WithEvents mtxtCepTel As MaskedTextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents txtKayitId As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
End Class
