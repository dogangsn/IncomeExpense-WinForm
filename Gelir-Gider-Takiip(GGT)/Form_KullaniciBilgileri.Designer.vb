<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_KullaniciBilgileri
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
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_KullaniciBilgileri))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClosed = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.lblMail = New MetroFramework.Controls.MetroLabel()
        Me.lblAdSoyad = New MetroFramework.Controls.MetroLabel()
        Me.lblKullaniciAdi = New MetroFramework.Controls.MetroLabel()
        Me.txtMail = New MetroFramework.Controls.MetroTextBox()
        Me.txtAdSoyad = New MetroFramework.Controls.MetroTextBox()
        Me.txtKullaniciAdi = New MetroFramework.Controls.MetroTextBox()
        Me.pcResim = New System.Windows.Forms.PictureBox()
        Me.btnResimSec = New MetroFramework.Controls.MetroTile()
        Me.btnGuncelle = New MetroFramework.Controls.MetroTile()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pcResim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 2)
        Me.Label1.TabIndex = 2
        '
        'btnClosed
        '
        WindowsUIButtonImageOptions1.Image = CType(resources.GetObject("WindowsUIButtonImageOptions1.Image"), System.Drawing.Image)
        WindowsUIButtonImageOptions1.Location = DevExpress.XtraBars.Docking2010.ImageLocation.AboveText
        Me.btnClosed.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Kapat", True, WindowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, -1)})
        Me.btnClosed.Location = New System.Drawing.Point(579, 6)
        Me.btnClosed.Name = "btnClosed"
        Me.btnClosed.Size = New System.Drawing.Size(84, 61)
        Me.btnClosed.TabIndex = 3
        Me.btnClosed.Text = "WindowsUIButtonPanel1"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Location = New System.Drawing.Point(189, 204)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(77, 19)
        Me.lblMail.TabIndex = 26
        Me.lblMail.Text = "E-Mailiniz : "
        '
        'lblAdSoyad
        '
        Me.lblAdSoyad.AutoSize = True
        Me.lblAdSoyad.Location = New System.Drawing.Point(189, 169)
        Me.lblAdSoyad.Name = "lblAdSoyad"
        Me.lblAdSoyad.Size = New System.Drawing.Size(73, 19)
        Me.lblAdSoyad.TabIndex = 27
        Me.lblAdSoyad.Text = "Ad Soyad :"
        '
        'lblKullaniciAdi
        '
        Me.lblKullaniciAdi.AutoSize = True
        Me.lblKullaniciAdi.Enabled = False
        Me.lblKullaniciAdi.Location = New System.Drawing.Point(189, 128)
        Me.lblKullaniciAdi.Name = "lblKullaniciAdi"
        Me.lblKullaniciAdi.Size = New System.Drawing.Size(86, 19)
        Me.lblKullaniciAdi.TabIndex = 28
        Me.lblKullaniciAdi.Text = "Kullanıcı Adı :"
        '
        'txtMail
        '
        '
        '
        '
        Me.txtMail.CustomButton.Image = Nothing
        Me.txtMail.CustomButton.Location = New System.Drawing.Point(172, 1)
        Me.txtMail.CustomButton.Name = ""
        Me.txtMail.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMail.CustomButton.TabIndex = 1
        Me.txtMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMail.CustomButton.UseSelectable = True
        Me.txtMail.CustomButton.Visible = False
        Me.txtMail.Lines = New String(-1) {}
        Me.txtMail.Location = New System.Drawing.Point(284, 194)
        Me.txtMail.MaxLength = 32767
        Me.txtMail.Name = "txtMail"
        Me.txtMail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMail.PromptText = "mailadresi@mailsunucunuz.com"
        Me.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMail.SelectedText = ""
        Me.txtMail.SelectionLength = 0
        Me.txtMail.SelectionStart = 0
        Me.txtMail.ShortcutsEnabled = True
        Me.txtMail.Size = New System.Drawing.Size(200, 29)
        Me.txtMail.TabIndex = 25
        Me.txtMail.UseSelectable = True
        Me.txtMail.WaterMark = "mailadresi@mailsunucunuz.com"
        Me.txtMail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtAdSoyad
        '
        '
        '
        '
        Me.txtAdSoyad.CustomButton.Image = Nothing
        Me.txtAdSoyad.CustomButton.Location = New System.Drawing.Point(116, 1)
        Me.txtAdSoyad.CustomButton.Name = ""
        Me.txtAdSoyad.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtAdSoyad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAdSoyad.CustomButton.TabIndex = 1
        Me.txtAdSoyad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAdSoyad.CustomButton.UseSelectable = True
        Me.txtAdSoyad.CustomButton.Visible = False
        Me.txtAdSoyad.Lines = New String(-1) {}
        Me.txtAdSoyad.Location = New System.Drawing.Point(284, 159)
        Me.txtAdSoyad.MaxLength = 32767
        Me.txtAdSoyad.Name = "txtAdSoyad"
        Me.txtAdSoyad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdSoyad.PromptText = "Örn; Ali KESER"
        Me.txtAdSoyad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAdSoyad.SelectedText = ""
        Me.txtAdSoyad.SelectionLength = 0
        Me.txtAdSoyad.SelectionStart = 0
        Me.txtAdSoyad.ShortcutsEnabled = True
        Me.txtAdSoyad.Size = New System.Drawing.Size(144, 29)
        Me.txtAdSoyad.TabIndex = 24
        Me.txtAdSoyad.UseSelectable = True
        Me.txtAdSoyad.WaterMark = "Örn; Ali KESER"
        Me.txtAdSoyad.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAdSoyad.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtKullaniciAdi
        '
        '
        '
        '
        Me.txtKullaniciAdi.CustomButton.Image = Nothing
        Me.txtKullaniciAdi.CustomButton.Location = New System.Drawing.Point(116, 1)
        Me.txtKullaniciAdi.CustomButton.Name = ""
        Me.txtKullaniciAdi.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtKullaniciAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtKullaniciAdi.CustomButton.TabIndex = 1
        Me.txtKullaniciAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtKullaniciAdi.CustomButton.UseSelectable = True
        Me.txtKullaniciAdi.CustomButton.Visible = False
        Me.txtKullaniciAdi.Enabled = False
        Me.txtKullaniciAdi.Lines = New String(-1) {}
        Me.txtKullaniciAdi.Location = New System.Drawing.Point(281, 124)
        Me.txtKullaniciAdi.MaxLength = 32767
        Me.txtKullaniciAdi.Name = "txtKullaniciAdi"
        Me.txtKullaniciAdi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKullaniciAdi.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtKullaniciAdi.SelectedText = ""
        Me.txtKullaniciAdi.SelectionLength = 0
        Me.txtKullaniciAdi.SelectionStart = 0
        Me.txtKullaniciAdi.ShortcutsEnabled = True
        Me.txtKullaniciAdi.Size = New System.Drawing.Size(144, 29)
        Me.txtKullaniciAdi.TabIndex = 23
        Me.txtKullaniciAdi.UseSelectable = True
        Me.txtKullaniciAdi.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtKullaniciAdi.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'pcResim
        '
        Me.pcResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcResim.Image = CType(resources.GetObject("pcResim.Image"), System.Drawing.Image)
        Me.pcResim.Location = New System.Drawing.Point(32, 92)
        Me.pcResim.Name = "pcResim"
        Me.pcResim.Size = New System.Drawing.Size(139, 185)
        Me.pcResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcResim.TabIndex = 29
        Me.pcResim.TabStop = False
        '
        'btnResimSec
        '
        Me.btnResimSec.ActiveControl = Nothing
        Me.btnResimSec.Location = New System.Drawing.Point(50, 283)
        Me.btnResimSec.Name = "btnResimSec"
        Me.btnResimSec.Size = New System.Drawing.Size(103, 40)
        Me.btnResimSec.TabIndex = 30
        Me.btnResimSec.Text = "Resim Seç"
        Me.btnResimSec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnResimSec.UseSelectable = True
        '
        'btnGuncelle
        '
        Me.btnGuncelle.ActiveControl = Nothing
        Me.btnGuncelle.Location = New System.Drawing.Point(501, 266)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(129, 57)
        Me.btnGuncelle.TabIndex = 31
        Me.btnGuncelle.Text = "Güncelle"
        Me.btnGuncelle.TileImage = CType(resources.GetObject("btnGuncelle.TileImage"), System.Drawing.Image)
        Me.btnGuncelle.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnGuncelle.UseSelectable = True
        Me.btnGuncelle.UseTileImage = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form_KullaniciBilgileri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 340)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnGuncelle)
        Me.Controls.Add(Me.btnResimSec)
        Me.Controls.Add(Me.pcResim)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblAdSoyad)
        Me.Controls.Add(Me.lblKullaniciAdi)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.txtAdSoyad)
        Me.Controls.Add(Me.txtKullaniciAdi)
        Me.Controls.Add(Me.btnClosed)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "Form_KullaniciBilgileri"
        Me.Resizable = False
        Me.Text = "KULLANICI BİLGİLERİ"
        CType(Me.pcResim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnClosed As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents lblMail As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblAdSoyad As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblKullaniciAdi As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAdSoyad As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtKullaniciAdi As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pcResim As PictureBox
    Friend WithEvents btnResimSec As MetroFramework.Controls.MetroTile
    Friend WithEvents btnGuncelle As MetroFramework.Controls.MetroTile
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
