<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_Girisi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Girisi))
        Me.btnCikis = New MetroFramework.Controls.MetroTile()
        Me.txtKullaniciAdi = New MetroFramework.Controls.MetroTextBox()
        Me.txtParola = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGiris = New MetroFramework.Controls.MetroTile()
        Me.lnkParolaUnuttum = New MetroFramework.Controls.MetroLink()
        Me.lnkKayitOl = New MetroFramework.Controls.MetroLink()
        Me.toggleParolaGoster = New DevExpress.XtraEditors.ToggleSwitch()
        CType(Me.toggleParolaGoster.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCikis
        '
        Me.btnCikis.ActiveControl = Nothing
        Me.btnCikis.Location = New System.Drawing.Point(249, 204)
        Me.btnCikis.Name = "btnCikis"
        Me.btnCikis.Size = New System.Drawing.Size(121, 51)
        Me.btnCikis.TabIndex = 5
        Me.btnCikis.Text = "Çıkış"
        Me.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCikis.TileImage = CType(resources.GetObject("btnCikis.TileImage"), System.Drawing.Image)
        Me.btnCikis.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCikis.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.btnCikis.UseSelectable = True
        Me.btnCikis.UseTileImage = True
        '
        'txtKullaniciAdi
        '
        '
        '
        '
        Me.txtKullaniciAdi.CustomButton.Image = Nothing
        Me.txtKullaniciAdi.CustomButton.Location = New System.Drawing.Point(161, 1)
        Me.txtKullaniciAdi.CustomButton.Name = ""
        Me.txtKullaniciAdi.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtKullaniciAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtKullaniciAdi.CustomButton.TabIndex = 1
        Me.txtKullaniciAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtKullaniciAdi.CustomButton.UseSelectable = True
        Me.txtKullaniciAdi.CustomButton.Visible = False
        Me.txtKullaniciAdi.DisplayIcon = True
        Me.txtKullaniciAdi.Icon = CType(resources.GetObject("txtKullaniciAdi.Icon"), System.Drawing.Image)
        Me.txtKullaniciAdi.Lines = New String() {"admin"}
        Me.txtKullaniciAdi.Location = New System.Drawing.Point(121, 83)
        Me.txtKullaniciAdi.MaxLength = 32767
        Me.txtKullaniciAdi.Multiline = True
        Me.txtKullaniciAdi.Name = "txtKullaniciAdi"
        Me.txtKullaniciAdi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKullaniciAdi.PromptText = "Kullanıcı Adı"
        Me.txtKullaniciAdi.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtKullaniciAdi.SelectedText = ""
        Me.txtKullaniciAdi.SelectionLength = 0
        Me.txtKullaniciAdi.SelectionStart = 0
        Me.txtKullaniciAdi.ShortcutsEnabled = True
        Me.txtKullaniciAdi.Size = New System.Drawing.Size(183, 23)
        Me.txtKullaniciAdi.TabIndex = 6
        Me.txtKullaniciAdi.Text = "admin"
        Me.txtKullaniciAdi.UseSelectable = True
        Me.txtKullaniciAdi.WaterMark = "Kullanıcı Adı"
        Me.txtKullaniciAdi.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtKullaniciAdi.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtParola
        '
        '
        '
        '
        Me.txtParola.CustomButton.Image = Nothing
        Me.txtParola.CustomButton.Location = New System.Drawing.Point(161, 1)
        Me.txtParola.CustomButton.Name = ""
        Me.txtParola.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtParola.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtParola.CustomButton.TabIndex = 1
        Me.txtParola.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtParola.CustomButton.UseSelectable = True
        Me.txtParola.CustomButton.Visible = False
        Me.txtParola.DisplayIcon = True
        Me.txtParola.Icon = CType(resources.GetObject("txtParola.Icon"), System.Drawing.Image)
        Me.txtParola.Lines = New String() {"123"}
        Me.txtParola.Location = New System.Drawing.Point(121, 114)
        Me.txtParola.MaxLength = 32767
        Me.txtParola.Name = "txtParola"
        Me.txtParola.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtParola.PromptText = "Parola"
        Me.txtParola.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtParola.SelectedText = ""
        Me.txtParola.SelectionLength = 0
        Me.txtParola.SelectionStart = 0
        Me.txtParola.ShortcutsEnabled = True
        Me.txtParola.Size = New System.Drawing.Size(183, 23)
        Me.txtParola.TabIndex = 7
        Me.txtParola.Text = "123"
        Me.txtParola.UseSelectable = True
        Me.txtParola.WaterMark = "Parola"
        Me.txtParola.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtParola.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 2)
        Me.Label1.TabIndex = 8
        '
        'btnGiris
        '
        Me.btnGiris.ActiveControl = Nothing
        Me.btnGiris.Location = New System.Drawing.Point(376, 204)
        Me.btnGiris.Name = "btnGiris"
        Me.btnGiris.Size = New System.Drawing.Size(121, 51)
        Me.btnGiris.TabIndex = 5
        Me.btnGiris.Text = "Giriş"
        Me.btnGiris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGiris.TileImage = CType(resources.GetObject("btnGiris.TileImage"), System.Drawing.Image)
        Me.btnGiris.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGiris.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.btnGiris.UseSelectable = True
        Me.btnGiris.UseTileImage = True
        '
        'lnkParolaUnuttum
        '
        Me.lnkParolaUnuttum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkParolaUnuttum.Location = New System.Drawing.Point(179, 144)
        Me.lnkParolaUnuttum.Name = "lnkParolaUnuttum"
        Me.lnkParolaUnuttum.Size = New System.Drawing.Size(120, 23)
        Me.lnkParolaUnuttum.TabIndex = 9
        Me.lnkParolaUnuttum.Text = "Parolamı Unuttum"
        Me.lnkParolaUnuttum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lnkParolaUnuttum.UseSelectable = True
        '
        'lnkKayitOl
        '
        Me.lnkKayitOl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkKayitOl.Location = New System.Drawing.Point(179, 166)
        Me.lnkKayitOl.Name = "lnkKayitOl"
        Me.lnkKayitOl.Size = New System.Drawing.Size(120, 23)
        Me.lnkKayitOl.TabIndex = 9
        Me.lnkKayitOl.Text = "Kayıt Ol"
        Me.lnkKayitOl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lnkKayitOl.UseSelectable = True
        '
        'toggleParolaGoster
        '
        Me.toggleParolaGoster.Location = New System.Drawing.Point(310, 114)
        Me.toggleParolaGoster.Name = "toggleParolaGoster"
        Me.toggleParolaGoster.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.toggleParolaGoster.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.toggleParolaGoster.Properties.OffText = "Parola Goster"
        Me.toggleParolaGoster.Properties.OnText = "Parola Gizle"
        Me.toggleParolaGoster.Size = New System.Drawing.Size(141, 24)
        Me.toggleParolaGoster.TabIndex = 10
        '
        'Login_Girisi
        '
        Me.AcceptButton = Me.btnGiris
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 281)
        Me.ControlBox = False
        Me.Controls.Add(Me.toggleParolaGoster)
        Me.Controls.Add(Me.lnkKayitOl)
        Me.Controls.Add(Me.lnkParolaUnuttum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtParola)
        Me.Controls.Add(Me.txtKullaniciAdi)
        Me.Controls.Add(Me.btnGiris)
        Me.Controls.Add(Me.btnCikis)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "Login_Girisi"
        Me.Resizable = False
        Me.Text = "KULLANICI GİRİŞİ"
        CType(Me.toggleParolaGoster.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCikis As MetroFramework.Controls.MetroTile
    Friend WithEvents txtParola As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtKullaniciAdi As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGiris As MetroFramework.Controls.MetroTile
    Friend WithEvents lnkParolaUnuttum As MetroFramework.Controls.MetroLink
    Friend WithEvents lnkKayitOl As MetroFramework.Controls.MetroLink
    Friend WithEvents toggleParolaGoster As DevExpress.XtraEditors.ToggleSwitch
End Class
