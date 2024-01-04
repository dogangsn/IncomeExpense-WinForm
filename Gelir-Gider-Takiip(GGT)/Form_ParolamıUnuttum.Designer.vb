<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ParolamıUnuttum
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ParolamıUnuttum))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAdSoyad = New MetroFramework.Controls.MetroLabel()
        Me.lblEmail = New MetroFramework.Controls.MetroLabel()
        Me.txtAdi = New MetroFramework.Controls.MetroTextBox()
        Me.txtEmail = New MetroFramework.Controls.MetroTextBox()
        Me.btnSifirla = New MetroFramework.Controls.MetroTile()
        Me.btnVazgec = New MetroFramework.Controls.MetroTile()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 2)
        Me.Label1.TabIndex = 16
        '
        'lblAdSoyad
        '
        Me.lblAdSoyad.AutoSize = True
        Me.lblAdSoyad.Location = New System.Drawing.Point(50, 95)
        Me.lblAdSoyad.Name = "lblAdSoyad"
        Me.lblAdSoyad.Size = New System.Drawing.Size(111, 19)
        Me.lblAdSoyad.TabIndex = 17
        Me.lblAdSoyad.Text = "Adınız Soyadınız :"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(50, 128)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(112, 19)
        Me.lblEmail.TabIndex = 18
        Me.lblEmail.Text = "E-Mail Adresniz : "
        '
        'txtAdi
        '
        '
        '
        '
        Me.txtAdi.CustomButton.Image = Nothing
        Me.txtAdi.CustomButton.Location = New System.Drawing.Point(120, 1)
        Me.txtAdi.CustomButton.Name = ""
        Me.txtAdi.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAdi.CustomButton.TabIndex = 1
        Me.txtAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAdi.CustomButton.UseSelectable = True
        Me.txtAdi.CustomButton.Visible = False
        Me.txtAdi.Lines = New String(-1) {}
        Me.txtAdi.Location = New System.Drawing.Point(167, 95)
        Me.txtAdi.MaxLength = 32767
        Me.txtAdi.Name = "txtAdi"
        Me.txtAdi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdi.PromptText = "örn; Ali KESER"
        Me.txtAdi.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAdi.SelectedText = ""
        Me.txtAdi.SelectionLength = 0
        Me.txtAdi.SelectionStart = 0
        Me.txtAdi.ShortcutsEnabled = True
        Me.txtAdi.Size = New System.Drawing.Size(142, 23)
        Me.txtAdi.TabIndex = 19
        Me.txtAdi.UseSelectable = True
        Me.txtAdi.WaterMark = "örn; Ali KESER"
        Me.txtAdi.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAdi.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtEmail
        '
        '
        '
        '
        Me.txtEmail.CustomButton.Image = Nothing
        Me.txtEmail.CustomButton.Location = New System.Drawing.Point(183, 1)
        Me.txtEmail.CustomButton.Name = ""
        Me.txtEmail.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEmail.CustomButton.TabIndex = 1
        Me.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEmail.CustomButton.UseSelectable = True
        Me.txtEmail.CustomButton.Visible = False
        Me.txtEmail.Lines = New String(-1) {}
        Me.txtEmail.Location = New System.Drawing.Point(167, 128)
        Me.txtEmail.MaxLength = 32767
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PromptText = "mail@mailsunusu.com"
        Me.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.SelectionLength = 0
        Me.txtEmail.SelectionStart = 0
        Me.txtEmail.ShortcutsEnabled = True
        Me.txtEmail.Size = New System.Drawing.Size(205, 23)
        Me.txtEmail.TabIndex = 20
        Me.txtEmail.UseSelectable = True
        Me.txtEmail.WaterMark = "mail@mailsunusu.com"
        Me.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnSifirla
        '
        Me.btnSifirla.ActiveControl = Nothing
        Me.btnSifirla.Location = New System.Drawing.Point(315, 174)
        Me.btnSifirla.Name = "btnSifirla"
        Me.btnSifirla.Size = New System.Drawing.Size(153, 54)
        Me.btnSifirla.TabIndex = 21
        Me.btnSifirla.Text = "Parola Sıfırla"
        Me.btnSifirla.TileImage = CType(resources.GetObject("btnSifirla.TileImage"), System.Drawing.Image)
        Me.btnSifirla.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSifirla.UseSelectable = True
        Me.btnSifirla.UseTileImage = True
        '
        'btnVazgec
        '
        Me.btnVazgec.ActiveControl = Nothing
        Me.btnVazgec.Location = New System.Drawing.Point(195, 174)
        Me.btnVazgec.Name = "btnVazgec"
        Me.btnVazgec.Size = New System.Drawing.Size(114, 54)
        Me.btnVazgec.TabIndex = 22
        Me.btnVazgec.Text = "Vazgeç"
        Me.btnVazgec.TileImage = CType(resources.GetObject("btnVazgec.TileImage"), System.Drawing.Image)
        Me.btnVazgec.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVazgec.UseSelectable = True
        Me.btnVazgec.UseTileImage = True
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'Form_ParolamıUnuttum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 251)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnVazgec)
        Me.Controls.Add(Me.btnSifirla)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtAdi)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblAdSoyad)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "Form_ParolamıUnuttum"
        Me.Resizable = False
        Me.Text = "PAROLAMI UNNUTTUM"
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblAdSoyad As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblEmail As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtAdi As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSifirla As MetroFramework.Controls.MetroTile
    Friend WithEvents btnVazgec As MetroFramework.Controls.MetroTile
    Private WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
End Class
