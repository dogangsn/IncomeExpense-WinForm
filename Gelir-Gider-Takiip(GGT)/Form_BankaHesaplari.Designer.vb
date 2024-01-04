<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_BankaHesaplari
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_BankaHesaplari))
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkGizleGoster = New MetroFramework.Controls.MetroCheckBox()
        Me.txtKartCCV = New MetroFramework.Controls.MetroTextBox()
        Me.txtKartSifre = New MetroFramework.Controls.MetroTextBox()
        Me.lblAciklama = New MetroFramework.Controls.MetroLabel()
        Me.txtAciklama = New MetroFramework.Controls.MetroTextBox()
        Me.txtKartNo = New MetroFramework.Controls.MetroTextBox()
        Me.txtMusteriNo = New MetroFramework.Controls.MetroTextBox()
        Me.dtGecerlilikTarihi = New MetroFramework.Controls.MetroDateTime()
        Me.dtAcilisTarihi = New MetroFramework.Controls.MetroDateTime()
        Me.lblKartCCV = New MetroFramework.Controls.MetroLabel()
        Me.btnSil = New MetroFramework.Controls.MetroTile()
        Me.lblGecerlilikTarihi = New MetroFramework.Controls.MetroLabel()
        Me.lblKartNo = New MetroFramework.Controls.MetroLabel()
        Me.txtHesapNo = New MetroFramework.Controls.MetroTextBox()
        Me.btnGuncelle = New MetroFramework.Controls.MetroTile()
        Me.cbbHesapTipi = New MetroFramework.Controls.MetroComboBox()
        Me.lblAcilisTarihi = New MetroFramework.Controls.MetroLabel()
        Me.lblMusteriNo = New MetroFramework.Controls.MetroLabel()
        Me.lblKartSifre = New MetroFramework.Controls.MetroLabel()
        Me.btnKaydet = New MetroFramework.Controls.MetroTile()
        Me.txtIBAN = New MetroFramework.Controls.MetroTextBox()
        Me.btnYeni = New MetroFramework.Controls.MetroTile()
        Me.txtBanka = New MetroFramework.Controls.MetroTextBox()
        Me.lblHesapTipi = New MetroFramework.Controls.MetroLabel()
        Me.lblIBAN = New MetroFramework.Controls.MetroLabel()
        Me.lblHesapNo = New MetroFramework.Controls.MetroLabel()
        Me.lblBanka = New MetroFramework.Controls.MetroLabel()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtKayitId = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtwKayitlar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkGizleGoster)
        Me.GroupBox1.Controls.Add(Me.txtKartCCV)
        Me.GroupBox1.Controls.Add(Me.txtKartSifre)
        Me.GroupBox1.Controls.Add(Me.lblAciklama)
        Me.GroupBox1.Controls.Add(Me.txtAciklama)
        Me.GroupBox1.Controls.Add(Me.txtKartNo)
        Me.GroupBox1.Controls.Add(Me.txtMusteriNo)
        Me.GroupBox1.Controls.Add(Me.dtGecerlilikTarihi)
        Me.GroupBox1.Controls.Add(Me.dtAcilisTarihi)
        Me.GroupBox1.Controls.Add(Me.lblKartCCV)
        Me.GroupBox1.Controls.Add(Me.btnSil)
        Me.GroupBox1.Controls.Add(Me.lblGecerlilikTarihi)
        Me.GroupBox1.Controls.Add(Me.lblKartNo)
        Me.GroupBox1.Controls.Add(Me.txtHesapNo)
        Me.GroupBox1.Controls.Add(Me.btnGuncelle)
        Me.GroupBox1.Controls.Add(Me.cbbHesapTipi)
        Me.GroupBox1.Controls.Add(Me.lblAcilisTarihi)
        Me.GroupBox1.Controls.Add(Me.lblMusteriNo)
        Me.GroupBox1.Controls.Add(Me.lblKartSifre)
        Me.GroupBox1.Controls.Add(Me.btnKaydet)
        Me.GroupBox1.Controls.Add(Me.txtIBAN)
        Me.GroupBox1.Controls.Add(Me.btnYeni)
        Me.GroupBox1.Controls.Add(Me.txtBanka)
        Me.GroupBox1.Controls.Add(Me.lblHesapTipi)
        Me.GroupBox1.Controls.Add(Me.lblIBAN)
        Me.GroupBox1.Controls.Add(Me.lblHesapNo)
        Me.GroupBox1.Controls.Add(Me.lblBanka)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(22, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(970, 288)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'chkGizleGoster
        '
        Me.chkGizleGoster.AutoSize = True
        Me.chkGizleGoster.Location = New System.Drawing.Point(560, 105)
        Me.chkGizleGoster.Name = "chkGizleGoster"
        Me.chkGizleGoster.Size = New System.Drawing.Size(57, 15)
        Me.chkGizleGoster.TabIndex = 18
        Me.chkGizleGoster.Text = "Göster"
        Me.chkGizleGoster.UseSelectable = True
        '
        'txtKartCCV
        '
        '
        '
        '
        Me.txtKartCCV.CustomButton.Image = Nothing
        Me.txtKartCCV.CustomButton.Location = New System.Drawing.Point(50, 1)
        Me.txtKartCCV.CustomButton.Name = ""
        Me.txtKartCCV.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtKartCCV.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtKartCCV.CustomButton.TabIndex = 1
        Me.txtKartCCV.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtKartCCV.CustomButton.UseSelectable = True
        Me.txtKartCCV.CustomButton.Visible = False
        Me.txtKartCCV.Lines = New String(-1) {}
        Me.txtKartCCV.Location = New System.Drawing.Point(477, 134)
        Me.txtKartCCV.MaxLength = 3
        Me.txtKartCCV.Name = "txtKartCCV"
        Me.txtKartCCV.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKartCCV.PromptText = "CVC ; 111"
        Me.txtKartCCV.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtKartCCV.SelectedText = ""
        Me.txtKartCCV.SelectionLength = 0
        Me.txtKartCCV.SelectionStart = 0
        Me.txtKartCCV.ShortcutsEnabled = True
        Me.txtKartCCV.Size = New System.Drawing.Size(78, 29)
        Me.txtKartCCV.TabIndex = 14
        Me.txtKartCCV.UseSelectable = True
        Me.txtKartCCV.WaterMark = "CVC ; 111"
        Me.txtKartCCV.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtKartCCV.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtKartSifre
        '
        '
        '
        '
        Me.txtKartSifre.CustomButton.Image = Nothing
        Me.txtKartSifre.CustomButton.Location = New System.Drawing.Point(50, 1)
        Me.txtKartSifre.CustomButton.Name = ""
        Me.txtKartSifre.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtKartSifre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtKartSifre.CustomButton.TabIndex = 1
        Me.txtKartSifre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtKartSifre.CustomButton.UseSelectable = True
        Me.txtKartSifre.CustomButton.Visible = False
        Me.txtKartSifre.Lines = New String(-1) {}
        Me.txtKartSifre.Location = New System.Drawing.Point(476, 97)
        Me.txtKartSifre.MaxLength = 4
        Me.txtKartSifre.Name = "txtKartSifre"
        Me.txtKartSifre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtKartSifre.PromptText = "****"
        Me.txtKartSifre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtKartSifre.SelectedText = ""
        Me.txtKartSifre.SelectionLength = 0
        Me.txtKartSifre.SelectionStart = 0
        Me.txtKartSifre.ShortcutsEnabled = True
        Me.txtKartSifre.Size = New System.Drawing.Size(78, 29)
        Me.txtKartSifre.TabIndex = 14
        Me.txtKartSifre.UseSelectable = True
        Me.txtKartSifre.WaterMark = "****"
        Me.txtKartSifre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtKartSifre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblAciklama
        '
        Me.lblAciklama.AutoSize = True
        Me.lblAciklama.Location = New System.Drawing.Point(643, 92)
        Me.lblAciklama.Name = "lblAciklama"
        Me.lblAciklama.Size = New System.Drawing.Size(69, 19)
        Me.lblAciklama.TabIndex = 2
        Me.lblAciklama.Text = "Açıklama :"
        '
        'txtAciklama
        '
        '
        '
        '
        Me.txtAciklama.CustomButton.Image = Nothing
        Me.txtAciklama.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.txtAciklama.CustomButton.Name = ""
        Me.txtAciklama.CustomButton.Size = New System.Drawing.Size(83, 83)
        Me.txtAciklama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAciklama.CustomButton.TabIndex = 1
        Me.txtAciklama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAciklama.CustomButton.UseSelectable = True
        Me.txtAciklama.CustomButton.Visible = False
        Me.txtAciklama.Lines = New String(-1) {}
        Me.txtAciklama.Location = New System.Drawing.Point(712, 92)
        Me.txtAciklama.MaxLength = 32767
        Me.txtAciklama.Multiline = True
        Me.txtAciklama.Name = "txtAciklama"
        Me.txtAciklama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAciklama.SelectedText = ""
        Me.txtAciklama.SelectionLength = 0
        Me.txtAciklama.SelectionStart = 0
        Me.txtAciklama.ShortcutsEnabled = True
        Me.txtAciklama.Size = New System.Drawing.Size(236, 85)
        Me.txtAciklama.TabIndex = 3
        Me.txtAciklama.UseSelectable = True
        Me.txtAciklama.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAciklama.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtKartNo
        '
        '
        '
        '
        Me.txtKartNo.CustomButton.Image = Nothing
        Me.txtKartNo.CustomButton.Location = New System.Drawing.Point(123, 1)
        Me.txtKartNo.CustomButton.Name = ""
        Me.txtKartNo.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtKartNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtKartNo.CustomButton.TabIndex = 1
        Me.txtKartNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtKartNo.CustomButton.UseSelectable = True
        Me.txtKartNo.CustomButton.Visible = False
        Me.txtKartNo.Lines = New String(-1) {}
        Me.txtKartNo.Location = New System.Drawing.Point(476, 62)
        Me.txtKartNo.MaxLength = 32767
        Me.txtKartNo.Name = "txtKartNo"
        Me.txtKartNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKartNo.PromptText = "111-2222-3333-4444"
        Me.txtKartNo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtKartNo.SelectedText = ""
        Me.txtKartNo.SelectionLength = 0
        Me.txtKartNo.SelectionStart = 0
        Me.txtKartNo.ShortcutsEnabled = True
        Me.txtKartNo.Size = New System.Drawing.Size(151, 29)
        Me.txtKartNo.TabIndex = 14
        Me.txtKartNo.UseSelectable = True
        Me.txtKartNo.WaterMark = "111-2222-3333-4444"
        Me.txtKartNo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtKartNo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMusteriNo
        '
        '
        '
        '
        Me.txtMusteriNo.CustomButton.Image = Nothing
        Me.txtMusteriNo.CustomButton.Location = New System.Drawing.Point(123, 1)
        Me.txtMusteriNo.CustomButton.Name = ""
        Me.txtMusteriNo.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtMusteriNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMusteriNo.CustomButton.TabIndex = 1
        Me.txtMusteriNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMusteriNo.CustomButton.UseSelectable = True
        Me.txtMusteriNo.CustomButton.Visible = False
        Me.txtMusteriNo.Lines = New String(-1) {}
        Me.txtMusteriNo.Location = New System.Drawing.Point(476, 27)
        Me.txtMusteriNo.MaxLength = 32767
        Me.txtMusteriNo.Name = "txtMusteriNo"
        Me.txtMusteriNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMusteriNo.PromptText = "Örn; 025458954"
        Me.txtMusteriNo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMusteriNo.SelectedText = ""
        Me.txtMusteriNo.SelectionLength = 0
        Me.txtMusteriNo.SelectionStart = 0
        Me.txtMusteriNo.ShortcutsEnabled = True
        Me.txtMusteriNo.Size = New System.Drawing.Size(151, 29)
        Me.txtMusteriNo.TabIndex = 14
        Me.txtMusteriNo.UseSelectable = True
        Me.txtMusteriNo.WaterMark = "Örn; 025458954"
        Me.txtMusteriNo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMusteriNo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dtGecerlilikTarihi
        '
        Me.dtGecerlilikTarihi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtGecerlilikTarihi.Location = New System.Drawing.Point(743, 56)
        Me.dtGecerlilikTarihi.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtGecerlilikTarihi.Name = "dtGecerlilikTarihi"
        Me.dtGecerlilikTarihi.Size = New System.Drawing.Size(205, 29)
        Me.dtGecerlilikTarihi.TabIndex = 4
        '
        'dtAcilisTarihi
        '
        Me.dtAcilisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtAcilisTarihi.Location = New System.Drawing.Point(743, 21)
        Me.dtAcilisTarihi.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtAcilisTarihi.Name = "dtAcilisTarihi"
        Me.dtAcilisTarihi.Size = New System.Drawing.Size(205, 29)
        Me.dtAcilisTarihi.TabIndex = 4
        '
        'lblKartCCV
        '
        Me.lblKartCCV.AutoSize = True
        Me.lblKartCCV.Location = New System.Drawing.Point(374, 143)
        Me.lblKartCCV.Name = "lblKartCCV"
        Me.lblKartCCV.Size = New System.Drawing.Size(69, 19)
        Me.lblKartCCV.TabIndex = 17
        Me.lblKartCCV.Text = "Kart CCV :"
        '
        'btnSil
        '
        Me.btnSil.ActiveControl = Nothing
        Me.btnSil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSil.Enabled = False
        Me.btnSil.Location = New System.Drawing.Point(434, 198)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(87, 75)
        Me.btnSil.TabIndex = 10
        Me.btnSil.Text = "Sil"
        Me.btnSil.TileImage = CType(resources.GetObject("btnSil.TileImage"), System.Drawing.Image)
        Me.btnSil.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnSil.UseSelectable = True
        Me.btnSil.UseTileImage = True
        '
        'lblGecerlilikTarihi
        '
        Me.lblGecerlilikTarihi.AutoSize = True
        Me.lblGecerlilikTarihi.Location = New System.Drawing.Point(643, 59)
        Me.lblGecerlilikTarihi.Name = "lblGecerlilikTarihi"
        Me.lblGecerlilikTarihi.Size = New System.Drawing.Size(102, 19)
        Me.lblGecerlilikTarihi.TabIndex = 16
        Me.lblGecerlilikTarihi.Text = "Geçerlilik Tarihi :"
        '
        'lblKartNo
        '
        Me.lblKartNo.AutoSize = True
        Me.lblKartNo.Location = New System.Drawing.Point(373, 66)
        Me.lblKartNo.Name = "lblKartNo"
        Me.lblKartNo.Size = New System.Drawing.Size(62, 19)
        Me.lblKartNo.TabIndex = 16
        Me.lblKartNo.Text = "Kart No :"
        '
        'txtHesapNo
        '
        '
        '
        '
        Me.txtHesapNo.CustomButton.Image = Nothing
        Me.txtHesapNo.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.txtHesapNo.CustomButton.Name = ""
        Me.txtHesapNo.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtHesapNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtHesapNo.CustomButton.TabIndex = 1
        Me.txtHesapNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtHesapNo.CustomButton.UseSelectable = True
        Me.txtHesapNo.CustomButton.Visible = False
        Me.txtHesapNo.Lines = New String(-1) {}
        Me.txtHesapNo.Location = New System.Drawing.Point(155, 66)
        Me.txtHesapNo.MaxLength = 32767
        Me.txtHesapNo.Name = "txtHesapNo"
        Me.txtHesapNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHesapNo.PromptText = "Örn; 0349-98765432-5009"
        Me.txtHesapNo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtHesapNo.SelectedText = ""
        Me.txtHesapNo.SelectionLength = 0
        Me.txtHesapNo.SelectionStart = 0
        Me.txtHesapNo.ShortcutsEnabled = True
        Me.txtHesapNo.Size = New System.Drawing.Size(180, 29)
        Me.txtHesapNo.TabIndex = 15
        Me.txtHesapNo.UseSelectable = True
        Me.txtHesapNo.WaterMark = "Örn; 0349-98765432-5009"
        Me.txtHesapNo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtHesapNo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnGuncelle
        '
        Me.btnGuncelle.ActiveControl = Nothing
        Me.btnGuncelle.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.btnGuncelle.Location = New System.Drawing.Point(341, 198)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(87, 75)
        Me.btnGuncelle.TabIndex = 11
        Me.btnGuncelle.Text = "Guncelle"
        Me.btnGuncelle.TileImage = CType(resources.GetObject("btnGuncelle.TileImage"), System.Drawing.Image)
        Me.btnGuncelle.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnGuncelle.UseSelectable = True
        Me.btnGuncelle.UseTileImage = True
        Me.btnGuncelle.UseWaitCursor = True
        '
        'cbbHesapTipi
        '
        Me.cbbHesapTipi.FormattingEnabled = True
        Me.cbbHesapTipi.ItemHeight = 23
        Me.cbbHesapTipi.Items.AddRange(New Object() {"Normal", "Vadeli", "Birikim", "Kredi", "Diğer"})
        Me.cbbHesapTipi.Location = New System.Drawing.Point(155, 143)
        Me.cbbHesapTipi.Name = "cbbHesapTipi"
        Me.cbbHesapTipi.Size = New System.Drawing.Size(121, 29)
        Me.cbbHesapTipi.TabIndex = 5
        Me.cbbHesapTipi.UseSelectable = True
        '
        'lblAcilisTarihi
        '
        Me.lblAcilisTarihi.AutoSize = True
        Me.lblAcilisTarihi.Location = New System.Drawing.Point(643, 31)
        Me.lblAcilisTarihi.Name = "lblAcilisTarihi"
        Me.lblAcilisTarihi.Size = New System.Drawing.Size(79, 19)
        Me.lblAcilisTarihi.TabIndex = 2
        Me.lblAcilisTarihi.Text = "Açılış Tarihi :"
        '
        'lblMusteriNo
        '
        Me.lblMusteriNo.AutoSize = True
        Me.lblMusteriNo.Location = New System.Drawing.Point(373, 27)
        Me.lblMusteriNo.Name = "lblMusteriNo"
        Me.lblMusteriNo.Size = New System.Drawing.Size(97, 19)
        Me.lblMusteriNo.TabIndex = 2
        Me.lblMusteriNo.Text = "Müşteri Kodu : "
        '
        'lblKartSifre
        '
        Me.lblKartSifre.AutoSize = True
        Me.lblKartSifre.Location = New System.Drawing.Point(373, 105)
        Me.lblKartSifre.Name = "lblKartSifre"
        Me.lblKartSifre.Size = New System.Drawing.Size(70, 19)
        Me.lblKartSifre.TabIndex = 2
        Me.lblKartSifre.Text = "Kart Şifre :"
        '
        'btnKaydet
        '
        Me.btnKaydet.ActiveControl = Nothing
        Me.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKaydet.Location = New System.Drawing.Point(248, 198)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(87, 75)
        Me.btnKaydet.TabIndex = 12
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.TileImage = CType(resources.GetObject("btnKaydet.TileImage"), System.Drawing.Image)
        Me.btnKaydet.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnKaydet.UseSelectable = True
        Me.btnKaydet.UseTileImage = True
        '
        'txtIBAN
        '
        '
        '
        '
        Me.txtIBAN.CustomButton.Image = Nothing
        Me.txtIBAN.CustomButton.Location = New System.Drawing.Point(173, 1)
        Me.txtIBAN.CustomButton.Name = ""
        Me.txtIBAN.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtIBAN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtIBAN.CustomButton.TabIndex = 1
        Me.txtIBAN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtIBAN.CustomButton.UseSelectable = True
        Me.txtIBAN.CustomButton.Visible = False
        Me.txtIBAN.Lines = New String(-1) {}
        Me.txtIBAN.Location = New System.Drawing.Point(155, 105)
        Me.txtIBAN.MaxLength = 32767
        Me.txtIBAN.Name = "txtIBAN"
        Me.txtIBAN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIBAN.PromptText = "TR-1- 2222-3333-4444-4444-4444-44"
        Me.txtIBAN.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIBAN.SelectedText = ""
        Me.txtIBAN.SelectionLength = 0
        Me.txtIBAN.SelectionStart = 0
        Me.txtIBAN.ShortcutsEnabled = True
        Me.txtIBAN.Size = New System.Drawing.Size(201, 29)
        Me.txtIBAN.TabIndex = 3
        Me.txtIBAN.UseSelectable = True
        Me.txtIBAN.WaterMark = "TR-1- 2222-3333-4444-4444-4444-44"
        Me.txtIBAN.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtIBAN.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnYeni
        '
        Me.btnYeni.ActiveControl = Nothing
        Me.btnYeni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYeni.Location = New System.Drawing.Point(155, 198)
        Me.btnYeni.Name = "btnYeni"
        Me.btnYeni.Size = New System.Drawing.Size(87, 75)
        Me.btnYeni.TabIndex = 13
        Me.btnYeni.Text = "Yeni"
        Me.btnYeni.TileImage = CType(resources.GetObject("btnYeni.TileImage"), System.Drawing.Image)
        Me.btnYeni.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnYeni.UseSelectable = True
        Me.btnYeni.UseTileImage = True
        '
        'txtBanka
        '
        '
        '
        '
        Me.txtBanka.CustomButton.Image = Nothing
        Me.txtBanka.CustomButton.Location = New System.Drawing.Point(153, 1)
        Me.txtBanka.CustomButton.Name = ""
        Me.txtBanka.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtBanka.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBanka.CustomButton.TabIndex = 1
        Me.txtBanka.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBanka.CustomButton.UseSelectable = True
        Me.txtBanka.CustomButton.Visible = False
        Me.txtBanka.Lines = New String(-1) {}
        Me.txtBanka.Location = New System.Drawing.Point(155, 26)
        Me.txtBanka.MaxLength = 32767
        Me.txtBanka.Name = "txtBanka"
        Me.txtBanka.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBanka.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBanka.SelectedText = ""
        Me.txtBanka.SelectionLength = 0
        Me.txtBanka.SelectionStart = 0
        Me.txtBanka.ShortcutsEnabled = True
        Me.txtBanka.Size = New System.Drawing.Size(181, 29)
        Me.txtBanka.TabIndex = 3
        Me.txtBanka.UseSelectable = True
        Me.txtBanka.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBanka.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblHesapTipi
        '
        Me.lblHesapTipi.AutoSize = True
        Me.lblHesapTipi.Location = New System.Drawing.Point(15, 148)
        Me.lblHesapTipi.Name = "lblHesapTipi"
        Me.lblHesapTipi.Size = New System.Drawing.Size(81, 19)
        Me.lblHesapTipi.TabIndex = 2
        Me.lblHesapTipi.Text = "Hesap Tipi : "
        '
        'lblIBAN
        '
        Me.lblIBAN.AutoSize = True
        Me.lblIBAN.Location = New System.Drawing.Point(15, 105)
        Me.lblIBAN.Name = "lblIBAN"
        Me.lblIBAN.Size = New System.Drawing.Size(46, 19)
        Me.lblIBAN.TabIndex = 2
        Me.lblIBAN.Text = "IBAN :"
        '
        'lblHesapNo
        '
        Me.lblHesapNo.AutoSize = True
        Me.lblHesapNo.Location = New System.Drawing.Point(15, 65)
        Me.lblHesapNo.Name = "lblHesapNo"
        Me.lblHesapNo.Size = New System.Drawing.Size(78, 19)
        Me.lblHesapNo.TabIndex = 2
        Me.lblHesapNo.Text = "Hesap No : "
        '
        'lblBanka
        '
        Me.lblBanka.AutoSize = True
        Me.lblBanka.Location = New System.Drawing.Point(15, 27)
        Me.lblBanka.Name = "lblBanka"
        Me.lblBanka.Size = New System.Drawing.Size(51, 19)
        Me.lblBanka.TabIndex = 2
        Me.lblBanka.Text = "Banka :"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 2)
        Me.Label1.TabIndex = 10
        '
        'btnClosed
        '
        WindowsUIButtonImageOptions1.Image = CType(resources.GetObject("WindowsUIButtonImageOptions1.Image"), System.Drawing.Image)
        Me.btnClosed.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Kapat", True, WindowsUIButtonImageOptions1)})
        Me.btnClosed.Location = New System.Drawing.Point(1048, 6)
        Me.btnClosed.Name = "btnClosed"
        Me.btnClosed.Size = New System.Drawing.Size(57, 61)
        Me.btnClosed.TabIndex = 13
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
        Me.dtwKayitlar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
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
        Me.dtwKayitlar.Location = New System.Drawing.Point(20, 365)
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
        Me.dtwKayitlar.Size = New System.Drawing.Size(1065, 315)
        Me.dtwKayitlar.TabIndex = 16
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
        Me.Column2.HeaderText = "Hesap No"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.FillWeight = 3.412547!
        Me.Column3.HeaderText = "IBAN"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.FillWeight = 3.415158!
        Me.Column4.HeaderText = "Hesap Tipi"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 120
        '
        'Column5
        '
        Me.Column5.FillWeight = 3.41574!
        Me.Column5.HeaderText = "Müşteri No"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 120
        '
        'Column6
        '
        Me.Column6.FillWeight = 3.414881!
        Me.Column6.HeaderText = "Kart No"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 130
        '
        'Column7
        '
        Me.Column7.HeaderText = "Kart .şifre"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Kart CCV"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Açılış Tarihi"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Geçerlilik Tarihi"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "Açıklama"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "id"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Visible = False
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
        Me.txtKayitId.Location = New System.Drawing.Point(998, 336)
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
        'Form_BankaHesaplari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtKayitId)
        Me.Controls.Add(Me.dtwKayitlar)
        Me.Controls.Add(Me.btnClosed)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "Form_BankaHesaplari"
        Me.Resizable = False
        Me.Text = "BANKA HESAPLARIM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtwKayitlar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtKartCCV As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtKartSifre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblAciklama As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtAciklama As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtKartNo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMusteriNo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dtGecerlilikTarihi As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtAcilisTarihi As MetroFramework.Controls.MetroDateTime
    Friend WithEvents lblKartCCV As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnSil As MetroFramework.Controls.MetroTile
    Friend WithEvents lblGecerlilikTarihi As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblKartNo As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtHesapNo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnGuncelle As MetroFramework.Controls.MetroTile
    Friend WithEvents cbbHesapTipi As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lblAcilisTarihi As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblMusteriNo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblKartSifre As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnKaydet As MetroFramework.Controls.MetroTile
    Friend WithEvents txtIBAN As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnYeni As MetroFramework.Controls.MetroTile
    Friend WithEvents txtBanka As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblHesapTipi As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblIBAN As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblHesapNo As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblBanka As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClosed As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents chkGizleGoster As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents dtwKayitlar As MetroFramework.Controls.MetroGrid
    Friend WithEvents txtKayitId As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
End Class
