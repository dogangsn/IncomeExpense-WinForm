<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_BankaEkle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_BankaEkle))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClosed = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.cbbBankalar = New MetroFramework.Controls.MetroComboBox()
        Me.cbbDovizCinsi = New MetroFramework.Controls.MetroComboBox()
        Me.txtDovizBakiye = New MetroFramework.Controls.MetroTextBox()
        Me.txtTlBakiye = New MetroFramework.Controls.MetroTextBox()
        Me.txtYuzde = New MetroFramework.Controls.MetroTextBox()
        Me.btnGuncelle = New MetroFramework.Controls.MetroTile()
        Me.btnKaydet = New MetroFramework.Controls.MetroTile()
        Me.lblId = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 2)
        Me.Label1.TabIndex = 2
        '
        'btnClosed
        '
        WindowsUIButtonImageOptions1.Image = CType(resources.GetObject("WindowsUIButtonImageOptions1.Image"), System.Drawing.Image)
        Me.btnClosed.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Kapat", True, WindowsUIButtonImageOptions1)})
        Me.btnClosed.Location = New System.Drawing.Point(296, 8)
        Me.btnClosed.Name = "btnClosed"
        Me.btnClosed.Size = New System.Drawing.Size(60, 61)
        Me.btnClosed.TabIndex = 15
        Me.btnClosed.Text = "WindowsUIButtonPanel1"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(10, 117)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel1.TabIndex = 16
        Me.MetroLabel1.Text = "Bankalar :"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(10, 159)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel2.TabIndex = 16
        Me.MetroLabel2.Text = "Döviz Cinsi :"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(10, 203)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(120, 19)
        Me.MetroLabel3.TabIndex = 16
        Me.MetroLabel3.Text = "Döviz Cinsi Bakiye :"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(10, 245)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(113, 19)
        Me.MetroLabel4.TabIndex = 16
        Me.MetroLabel4.Text = "Güncel TL Bakiye :"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(10, 294)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel5.TabIndex = 16
        Me.MetroLabel5.Text = "Yüzde(%) :"
        '
        'cbbBankalar
        '
        Me.cbbBankalar.FormattingEnabled = True
        Me.cbbBankalar.ItemHeight = 23
        Me.cbbBankalar.Location = New System.Drawing.Point(137, 115)
        Me.cbbBankalar.Name = "cbbBankalar"
        Me.cbbBankalar.Size = New System.Drawing.Size(156, 29)
        Me.cbbBankalar.TabIndex = 17
        Me.cbbBankalar.UseSelectable = True
        '
        'cbbDovizCinsi
        '
        Me.cbbDovizCinsi.FormattingEnabled = True
        Me.cbbDovizCinsi.ItemHeight = 23
        Me.cbbDovizCinsi.Items.AddRange(New Object() {"USD", "TRY", "EUR", "GBP", "CAD", "AUD", "DKK", "NOK", "JPY"})
        Me.cbbDovizCinsi.Location = New System.Drawing.Point(137, 159)
        Me.cbbDovizCinsi.Name = "cbbDovizCinsi"
        Me.cbbDovizCinsi.Size = New System.Drawing.Size(156, 29)
        Me.cbbDovizCinsi.TabIndex = 17
        Me.cbbDovizCinsi.UseSelectable = True
        '
        'txtDovizBakiye
        '
        '
        '
        '
        Me.txtDovizBakiye.CustomButton.Image = Nothing
        Me.txtDovizBakiye.CustomButton.Location = New System.Drawing.Point(128, 1)
        Me.txtDovizBakiye.CustomButton.Name = ""
        Me.txtDovizBakiye.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtDovizBakiye.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDovizBakiye.CustomButton.TabIndex = 1
        Me.txtDovizBakiye.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDovizBakiye.CustomButton.UseSelectable = True
        Me.txtDovizBakiye.CustomButton.Visible = False
        Me.txtDovizBakiye.Lines = New String(-1) {}
        Me.txtDovizBakiye.Location = New System.Drawing.Point(137, 203)
        Me.txtDovizBakiye.MaxLength = 32767
        Me.txtDovizBakiye.Name = "txtDovizBakiye"
        Me.txtDovizBakiye.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDovizBakiye.PromptText = "0.00 ₺"
        Me.txtDovizBakiye.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDovizBakiye.SelectedText = ""
        Me.txtDovizBakiye.SelectionLength = 0
        Me.txtDovizBakiye.SelectionStart = 0
        Me.txtDovizBakiye.ShortcutsEnabled = True
        Me.txtDovizBakiye.Size = New System.Drawing.Size(156, 29)
        Me.txtDovizBakiye.TabIndex = 18
        Me.txtDovizBakiye.UseSelectable = True
        Me.txtDovizBakiye.WaterMark = "0.00 ₺"
        Me.txtDovizBakiye.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDovizBakiye.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTlBakiye
        '
        '
        '
        '
        Me.txtTlBakiye.CustomButton.Image = Nothing
        Me.txtTlBakiye.CustomButton.Location = New System.Drawing.Point(128, 1)
        Me.txtTlBakiye.CustomButton.Name = ""
        Me.txtTlBakiye.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtTlBakiye.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTlBakiye.CustomButton.TabIndex = 1
        Me.txtTlBakiye.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTlBakiye.CustomButton.UseSelectable = True
        Me.txtTlBakiye.CustomButton.Visible = False
        Me.txtTlBakiye.Lines = New String(-1) {}
        Me.txtTlBakiye.Location = New System.Drawing.Point(137, 245)
        Me.txtTlBakiye.MaxLength = 32767
        Me.txtTlBakiye.Name = "txtTlBakiye"
        Me.txtTlBakiye.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTlBakiye.PromptText = "0.00 ₺"
        Me.txtTlBakiye.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTlBakiye.SelectedText = ""
        Me.txtTlBakiye.SelectionLength = 0
        Me.txtTlBakiye.SelectionStart = 0
        Me.txtTlBakiye.ShortcutsEnabled = True
        Me.txtTlBakiye.Size = New System.Drawing.Size(156, 29)
        Me.txtTlBakiye.TabIndex = 18
        Me.txtTlBakiye.UseSelectable = True
        Me.txtTlBakiye.WaterMark = "0.00 ₺"
        Me.txtTlBakiye.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTlBakiye.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtYuzde
        '
        '
        '
        '
        Me.txtYuzde.CustomButton.Image = Nothing
        Me.txtYuzde.CustomButton.Location = New System.Drawing.Point(68, 1)
        Me.txtYuzde.CustomButton.Name = ""
        Me.txtYuzde.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtYuzde.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtYuzde.CustomButton.TabIndex = 1
        Me.txtYuzde.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtYuzde.CustomButton.UseSelectable = True
        Me.txtYuzde.CustomButton.Visible = False
        Me.txtYuzde.Lines = New String(-1) {}
        Me.txtYuzde.Location = New System.Drawing.Point(137, 288)
        Me.txtYuzde.MaxLength = 32767
        Me.txtYuzde.Name = "txtYuzde"
        Me.txtYuzde.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtYuzde.PromptText = "%"
        Me.txtYuzde.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtYuzde.SelectedText = ""
        Me.txtYuzde.SelectionLength = 0
        Me.txtYuzde.SelectionStart = 0
        Me.txtYuzde.ShortcutsEnabled = True
        Me.txtYuzde.Size = New System.Drawing.Size(96, 29)
        Me.txtYuzde.TabIndex = 18
        Me.txtYuzde.UseSelectable = True
        Me.txtYuzde.WaterMark = "%"
        Me.txtYuzde.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtYuzde.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnGuncelle
        '
        Me.btnGuncelle.ActiveControl = Nothing
        Me.btnGuncelle.Location = New System.Drawing.Point(181, 375)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(112, 72)
        Me.btnGuncelle.TabIndex = 19
        Me.btnGuncelle.Text = "Güncelle"
        Me.btnGuncelle.UseSelectable = True
        Me.btnGuncelle.Visible = False
        '
        'btnKaydet
        '
        Me.btnKaydet.ActiveControl = Nothing
        Me.btnKaydet.Location = New System.Drawing.Point(63, 375)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(112, 72)
        Me.btnKaydet.TabIndex = 19
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.UseSelectable = True
        Me.btnKaydet.Visible = False
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(134, 89)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(0, 13)
        Me.lblId.TabIndex = 20
        Me.lblId.Visible = False
        '
        'Form_BankaEkle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 505)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.btnGuncelle)
        Me.Controls.Add(Me.txtYuzde)
        Me.Controls.Add(Me.txtTlBakiye)
        Me.Controls.Add(Me.txtDovizBakiye)
        Me.Controls.Add(Me.cbbDovizCinsi)
        Me.Controls.Add(Me.cbbBankalar)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnClosed)
        Me.Controls.Add(Me.Label1)
        Me.Movable = False
        Me.Name = "Form_BankaEkle"
        Me.Resizable = False
        Me.Text = "BANKA EKLE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnClosed As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Public WithEvents cbbBankalar As MetroFramework.Controls.MetroComboBox
    Public WithEvents btnGuncelle As MetroFramework.Controls.MetroTile
    Public WithEvents btnKaydet As MetroFramework.Controls.MetroTile
    Public WithEvents cbbDovizCinsi As MetroFramework.Controls.MetroComboBox
    Public WithEvents txtDovizBakiye As MetroFramework.Controls.MetroTextBox
    Public WithEvents txtTlBakiye As MetroFramework.Controls.MetroTextBox
    Public WithEvents txtYuzde As MetroFramework.Controls.MetroTextBox
    Public WithEvents lblId As Label
End Class
