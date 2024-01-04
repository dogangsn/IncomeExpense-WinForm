<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kayit_Ol
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kayit_Ol))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnKaydet = New MetroFramework.Controls.MetroTile()
        Me.txtKullaniciAdi = New MetroFramework.Controls.MetroTextBox()
        Me.txtAdSoyad = New MetroFramework.Controls.MetroTextBox()
        Me.txtMail = New MetroFramework.Controls.MetroTextBox()
        Me.txtParola = New MetroFramework.Controls.MetroTextBox()
        Me.txtParolaDogrulama = New MetroFramework.Controls.MetroTextBox()
        Me.lblKullaniciAdi = New MetroFramework.Controls.MetroLabel()
        Me.lblAdSoyad = New MetroFramework.Controls.MetroLabel()
        Me.lblMail = New MetroFramework.Controls.MetroLabel()
        Me.lblParola = New MetroFramework.Controls.MetroLabel()
        Me.lblParolamaDogrulama = New MetroFramework.Controls.MetroLabel()
        Me.btnVazgec = New MetroFramework.Controls.MetroTile()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblRandomSayi = New MetroFramework.Controls.MetroLabel()
        Me.lblDogrulamaKodu = New MetroFramework.Controls.MetroLabel()
        Me.txtDogrulamaKodu = New MetroFramework.Controls.MetroTextBox()
        Me.chbSozlesmeOnayi = New MetroFramework.Controls.MetroCheckBox()
        Me.btnYenile = New MetroFramework.Controls.MetroTile()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 2)
        Me.Label1.TabIndex = 15
        '
        'btnKaydet
        '
        Me.btnKaydet.ActiveControl = Nothing
        Me.btnKaydet.Location = New System.Drawing.Point(239, 492)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(127, 67)
        Me.btnKaydet.TabIndex = 16
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.TileImage = CType(resources.GetObject("btnKaydet.TileImage"), System.Drawing.Image)
        Me.btnKaydet.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnKaydet.UseSelectable = True
        Me.btnKaydet.UseTileImage = True
        '
        'txtKullaniciAdi
        '
        '
        '
        '
        Me.txtKullaniciAdi.CustomButton.Image = Nothing
        Me.txtKullaniciAdi.CustomButton.Location = New System.Drawing.Point(122, 1)
        Me.txtKullaniciAdi.CustomButton.Name = ""
        Me.txtKullaniciAdi.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtKullaniciAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtKullaniciAdi.CustomButton.TabIndex = 1
        Me.txtKullaniciAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtKullaniciAdi.CustomButton.UseSelectable = True
        Me.txtKullaniciAdi.CustomButton.Visible = False
        Me.txtKullaniciAdi.Lines = New String(-1) {}
        Me.txtKullaniciAdi.Location = New System.Drawing.Point(172, 114)
        Me.txtKullaniciAdi.MaxLength = 32767
        Me.txtKullaniciAdi.Name = "txtKullaniciAdi"
        Me.txtKullaniciAdi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKullaniciAdi.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtKullaniciAdi.SelectedText = ""
        Me.txtKullaniciAdi.SelectionLength = 0
        Me.txtKullaniciAdi.SelectionStart = 0
        Me.txtKullaniciAdi.ShortcutsEnabled = True
        Me.txtKullaniciAdi.Size = New System.Drawing.Size(144, 23)
        Me.txtKullaniciAdi.TabIndex = 17
        Me.txtKullaniciAdi.UseSelectable = True
        Me.txtKullaniciAdi.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtKullaniciAdi.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtAdSoyad
        '
        '
        '
        '
        Me.txtAdSoyad.CustomButton.Image = Nothing
        Me.txtAdSoyad.CustomButton.Location = New System.Drawing.Point(122, 1)
        Me.txtAdSoyad.CustomButton.Name = ""
        Me.txtAdSoyad.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtAdSoyad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAdSoyad.CustomButton.TabIndex = 1
        Me.txtAdSoyad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAdSoyad.CustomButton.UseSelectable = True
        Me.txtAdSoyad.CustomButton.Visible = False
        Me.txtAdSoyad.Lines = New String(-1) {}
        Me.txtAdSoyad.Location = New System.Drawing.Point(172, 157)
        Me.txtAdSoyad.MaxLength = 32767
        Me.txtAdSoyad.Name = "txtAdSoyad"
        Me.txtAdSoyad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdSoyad.PromptText = "Orn;Ali KESER"
        Me.txtAdSoyad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAdSoyad.SelectedText = ""
        Me.txtAdSoyad.SelectionLength = 0
        Me.txtAdSoyad.SelectionStart = 0
        Me.txtAdSoyad.ShortcutsEnabled = True
        Me.txtAdSoyad.Size = New System.Drawing.Size(144, 23)
        Me.txtAdSoyad.TabIndex = 18
        Me.txtAdSoyad.UseSelectable = True
        Me.txtAdSoyad.WaterMark = "Orn;Ali KESER"
        Me.txtAdSoyad.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAdSoyad.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMail
        '
        '
        '
        '
        Me.txtMail.CustomButton.Image = Nothing
        Me.txtMail.CustomButton.Location = New System.Drawing.Point(122, 1)
        Me.txtMail.CustomButton.Name = ""
        Me.txtMail.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMail.CustomButton.TabIndex = 1
        Me.txtMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMail.CustomButton.UseSelectable = True
        Me.txtMail.CustomButton.Visible = False
        Me.txtMail.Lines = New String(-1) {}
        Me.txtMail.Location = New System.Drawing.Point(172, 200)
        Me.txtMail.MaxLength = 32767
        Me.txtMail.Name = "txtMail"
        Me.txtMail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMail.PromptText = "mail@mailsunucusu.com"
        Me.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMail.SelectedText = ""
        Me.txtMail.SelectionLength = 0
        Me.txtMail.SelectionStart = 0
        Me.txtMail.ShortcutsEnabled = True
        Me.txtMail.Size = New System.Drawing.Size(144, 23)
        Me.txtMail.TabIndex = 19
        Me.txtMail.UseSelectable = True
        Me.txtMail.WaterMark = "mail@mailsunucusu.com"
        Me.txtMail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtParola
        '
        '
        '
        '
        Me.txtParola.CustomButton.Image = Nothing
        Me.txtParola.CustomButton.Location = New System.Drawing.Point(122, 1)
        Me.txtParola.CustomButton.Name = ""
        Me.txtParola.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtParola.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtParola.CustomButton.TabIndex = 1
        Me.txtParola.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtParola.CustomButton.UseSelectable = True
        Me.txtParola.CustomButton.Visible = False
        Me.txtParola.Lines = New String(-1) {}
        Me.txtParola.Location = New System.Drawing.Point(172, 243)
        Me.txtParola.MaxLength = 32767
        Me.txtParola.Name = "txtParola"
        Me.txtParola.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtParola.PromptText = "************"
        Me.txtParola.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtParola.SelectedText = ""
        Me.txtParola.SelectionLength = 0
        Me.txtParola.SelectionStart = 0
        Me.txtParola.ShortcutsEnabled = True
        Me.txtParola.Size = New System.Drawing.Size(144, 23)
        Me.txtParola.TabIndex = 20
        Me.txtParola.UseSelectable = True
        Me.txtParola.WaterMark = "************"
        Me.txtParola.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtParola.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtParolaDogrulama
        '
        '
        '
        '
        Me.txtParolaDogrulama.CustomButton.Image = Nothing
        Me.txtParolaDogrulama.CustomButton.Location = New System.Drawing.Point(122, 1)
        Me.txtParolaDogrulama.CustomButton.Name = ""
        Me.txtParolaDogrulama.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtParolaDogrulama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtParolaDogrulama.CustomButton.TabIndex = 1
        Me.txtParolaDogrulama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtParolaDogrulama.CustomButton.UseSelectable = True
        Me.txtParolaDogrulama.CustomButton.Visible = False
        Me.txtParolaDogrulama.Lines = New String(-1) {}
        Me.txtParolaDogrulama.Location = New System.Drawing.Point(172, 286)
        Me.txtParolaDogrulama.MaxLength = 32767
        Me.txtParolaDogrulama.Name = "txtParolaDogrulama"
        Me.txtParolaDogrulama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtParolaDogrulama.PromptText = "************"
        Me.txtParolaDogrulama.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtParolaDogrulama.SelectedText = ""
        Me.txtParolaDogrulama.SelectionLength = 0
        Me.txtParolaDogrulama.SelectionStart = 0
        Me.txtParolaDogrulama.ShortcutsEnabled = True
        Me.txtParolaDogrulama.Size = New System.Drawing.Size(144, 23)
        Me.txtParolaDogrulama.TabIndex = 21
        Me.txtParolaDogrulama.UseSelectable = True
        Me.txtParolaDogrulama.WaterMark = "************"
        Me.txtParolaDogrulama.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtParolaDogrulama.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblKullaniciAdi
        '
        Me.lblKullaniciAdi.AutoSize = True
        Me.lblKullaniciAdi.Location = New System.Drawing.Point(58, 114)
        Me.lblKullaniciAdi.Name = "lblKullaniciAdi"
        Me.lblKullaniciAdi.Size = New System.Drawing.Size(86, 19)
        Me.lblKullaniciAdi.TabIndex = 22
        Me.lblKullaniciAdi.Text = "Kullanıcı Adı :"
        '
        'lblAdSoyad
        '
        Me.lblAdSoyad.AutoSize = True
        Me.lblAdSoyad.Location = New System.Drawing.Point(58, 158)
        Me.lblAdSoyad.Name = "lblAdSoyad"
        Me.lblAdSoyad.Size = New System.Drawing.Size(73, 19)
        Me.lblAdSoyad.TabIndex = 22
        Me.lblAdSoyad.Text = "Ad Soyad :"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(58, 202)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(77, 19)
        Me.lblMail.TabIndex = 22
        Me.lblMail.Text = "E-Mailiniz : "
        '
        'lblParola
        '
        Me.lblParola.AutoSize = True
        Me.lblParola.Location = New System.Drawing.Point(58, 246)
        Me.lblParola.Name = "lblParola"
        Me.lblParola.Size = New System.Drawing.Size(53, 19)
        Me.lblParola.TabIndex = 22
        Me.lblParola.Text = "Parola :"
        '
        'lblParolamaDogrulama
        '
        Me.lblParolamaDogrulama.AutoSize = True
        Me.lblParolamaDogrulama.Location = New System.Drawing.Point(58, 290)
        Me.lblParolamaDogrulama.Name = "lblParolamaDogrulama"
        Me.lblParolamaDogrulama.Size = New System.Drawing.Size(104, 19)
        Me.lblParolamaDogrulama.TabIndex = 22
        Me.lblParolamaDogrulama.Text = "Parola Doğrula :"
        '
        'btnVazgec
        '
        Me.btnVazgec.ActiveControl = Nothing
        Me.btnVazgec.Location = New System.Drawing.Point(106, 492)
        Me.btnVazgec.Name = "btnVazgec"
        Me.btnVazgec.Size = New System.Drawing.Size(127, 67)
        Me.btnVazgec.TabIndex = 16
        Me.btnVazgec.Text = "Vazgeç"
        Me.btnVazgec.TileImage = CType(resources.GetObject("btnVazgec.TileImage"), System.Drawing.Image)
        Me.btnVazgec.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVazgec.UseSelectable = True
        Me.btnVazgec.UseTileImage = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblRandomSayi)
        Me.GroupBox1.Location = New System.Drawing.Point(106, 328)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 68)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'lblRandomSayi
        '
        Me.lblRandomSayi.AutoSize = True
        Me.lblRandomSayi.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblRandomSayi.Location = New System.Drawing.Point(45, 24)
        Me.lblRandomSayi.Name = "lblRandomSayi"
        Me.lblRandomSayi.Size = New System.Drawing.Size(74, 25)
        Me.lblRandomSayi.TabIndex = 0
        Me.lblRandomSayi.Text = "6c87x7Y"
        '
        'lblDogrulamaKodu
        '
        Me.lblDogrulamaKodu.AutoSize = True
        Me.lblDogrulamaKodu.Location = New System.Drawing.Point(58, 409)
        Me.lblDogrulamaKodu.Name = "lblDogrulamaKodu"
        Me.lblDogrulamaKodu.Size = New System.Drawing.Size(115, 19)
        Me.lblDogrulamaKodu.TabIndex = 24
        Me.lblDogrulamaKodu.Text = "Doğrulama kodu :"
        '
        'txtDogrulamaKodu
        '
        '
        '
        '
        Me.txtDogrulamaKodu.CustomButton.Image = Nothing
        Me.txtDogrulamaKodu.CustomButton.Location = New System.Drawing.Point(75, 1)
        Me.txtDogrulamaKodu.CustomButton.Name = ""
        Me.txtDogrulamaKodu.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDogrulamaKodu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDogrulamaKodu.CustomButton.TabIndex = 1
        Me.txtDogrulamaKodu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDogrulamaKodu.CustomButton.UseSelectable = True
        Me.txtDogrulamaKodu.CustomButton.Visible = False
        Me.txtDogrulamaKodu.Lines = New String(-1) {}
        Me.txtDogrulamaKodu.Location = New System.Drawing.Point(172, 409)
        Me.txtDogrulamaKodu.MaxLength = 32767
        Me.txtDogrulamaKodu.Name = "txtDogrulamaKodu"
        Me.txtDogrulamaKodu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDogrulamaKodu.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDogrulamaKodu.SelectedText = ""
        Me.txtDogrulamaKodu.SelectionLength = 0
        Me.txtDogrulamaKodu.SelectionStart = 0
        Me.txtDogrulamaKodu.ShortcutsEnabled = True
        Me.txtDogrulamaKodu.Size = New System.Drawing.Size(97, 23)
        Me.txtDogrulamaKodu.TabIndex = 25
        Me.txtDogrulamaKodu.UseSelectable = True
        Me.txtDogrulamaKodu.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDogrulamaKodu.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'chbSozlesmeOnayi
        '
        Me.chbSozlesmeOnayi.AutoSize = True
        Me.chbSozlesmeOnayi.Location = New System.Drawing.Point(44, 452)
        Me.chbSozlesmeOnayi.Name = "chbSozlesmeOnayi"
        Me.chbSozlesmeOnayi.Size = New System.Drawing.Size(280, 15)
        Me.chbSozlesmeOnayi.TabIndex = 26
        Me.chbSozlesmeOnayi.Text = "Kullanım sözleşmesini okudum. Kabul ediyorum."
        Me.chbSozlesmeOnayi.UseSelectable = True
        '
        'btnYenile
        '
        Me.btnYenile.ActiveControl = Nothing
        Me.btnYenile.Location = New System.Drawing.Point(286, 335)
        Me.btnYenile.Name = "btnYenile"
        Me.btnYenile.Size = New System.Drawing.Size(38, 42)
        Me.btnYenile.Style = MetroFramework.MetroColorStyle.White
        Me.btnYenile.TabIndex = 27
        Me.btnYenile.TileImage = CType(resources.GetObject("btnYenile.TileImage"), System.Drawing.Image)
        Me.btnYenile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnYenile.UseCustomBackColor = True
        Me.btnYenile.UseSelectable = True
        Me.btnYenile.UseTileImage = True
        '
        'Kayit_Ol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 593)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnYenile)
        Me.Controls.Add(Me.chbSozlesmeOnayi)
        Me.Controls.Add(Me.txtDogrulamaKodu)
        Me.Controls.Add(Me.lblDogrulamaKodu)
        Me.Controls.Add(Me.lblParolamaDogrulama)
        Me.Controls.Add(Me.lblParola)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblAdSoyad)
        Me.Controls.Add(Me.lblKullaniciAdi)
        Me.Controls.Add(Me.txtParolaDogrulama)
        Me.Controls.Add(Me.txtParola)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.txtAdSoyad)
        Me.Controls.Add(Me.txtKullaniciAdi)
        Me.Controls.Add(Me.btnVazgec)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "Kayit_Ol"
        Me.Resizable = False
        Me.Text = "KAYIT OL "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnKaydet As MetroFramework.Controls.MetroTile
    Friend WithEvents txtKullaniciAdi As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAdSoyad As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtParola As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtParolaDogrulama As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblKullaniciAdi As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblAdSoyad As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblMail As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblParola As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblParolamaDogrulama As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnVazgec As MetroFramework.Controls.MetroTile
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblRandomSayi As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDogrulamaKodu As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDogrulamaKodu As MetroFramework.Controls.MetroTextBox
    Friend WithEvents chbSozlesmeOnayi As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents btnYenile As MetroFramework.Controls.MetroTile
End Class
