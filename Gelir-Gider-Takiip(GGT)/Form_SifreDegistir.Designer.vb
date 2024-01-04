<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_SifreDegistir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_SifreDegistir))
        Me.lblEskiParola = New MetroFramework.Controls.MetroLabel()
        Me.lblYeniParola = New MetroFramework.Controls.MetroLabel()
        Me.lblTekarYeniParola = New MetroFramework.Controls.MetroLabel()
        Me.txtEskiParola = New MetroFramework.Controls.MetroTextBox()
        Me.txtYeniParola = New MetroFramework.Controls.MetroTextBox()
        Me.txtTekrarYeniParola = New MetroFramework.Controls.MetroTextBox()
        Me.btnKaydet = New MetroFramework.Controls.MetroTile()
        Me.btnVazgec = New MetroFramework.Controls.MetroTile()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chcGizleGoster = New MetroFramework.Controls.MetroCheckBox()
        Me.SuspendLayout()
        '
        'lblEskiParola
        '
        Me.lblEskiParola.AutoSize = True
        Me.lblEskiParola.Location = New System.Drawing.Point(117, 77)
        Me.lblEskiParola.Name = "lblEskiParola"
        Me.lblEskiParola.Size = New System.Drawing.Size(78, 19)
        Me.lblEskiParola.TabIndex = 0
        Me.lblEskiParola.Text = "Eski Parola :"
        '
        'lblYeniParola
        '
        Me.lblYeniParola.AutoSize = True
        Me.lblYeniParola.Location = New System.Drawing.Point(117, 112)
        Me.lblYeniParola.Name = "lblYeniParola"
        Me.lblYeniParola.Size = New System.Drawing.Size(80, 19)
        Me.lblYeniParola.TabIndex = 0
        Me.lblYeniParola.Text = "Yeni Parola :"
        '
        'lblTekarYeniParola
        '
        Me.lblTekarYeniParola.AutoSize = True
        Me.lblTekarYeniParola.Location = New System.Drawing.Point(78, 147)
        Me.lblTekarYeniParola.Name = "lblTekarYeniParola"
        Me.lblTekarYeniParola.Size = New System.Drawing.Size(119, 19)
        Me.lblTekarYeniParola.TabIndex = 0
        Me.lblTekarYeniParola.Text = "Tekrar Yeni Parola :"
        '
        'txtEskiParola
        '
        '
        '
        '
        Me.txtEskiParola.CustomButton.Image = Nothing
        Me.txtEskiParola.CustomButton.Location = New System.Drawing.Point(132, 1)
        Me.txtEskiParola.CustomButton.Name = ""
        Me.txtEskiParola.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtEskiParola.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEskiParola.CustomButton.TabIndex = 1
        Me.txtEskiParola.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEskiParola.CustomButton.UseSelectable = True
        Me.txtEskiParola.CustomButton.Visible = False
        Me.txtEskiParola.Lines = New String(-1) {}
        Me.txtEskiParola.Location = New System.Drawing.Point(213, 77)
        Me.txtEskiParola.MaxLength = 32767
        Me.txtEskiParola.Name = "txtEskiParola"
        Me.txtEskiParola.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtEskiParola.PromptText = "********"
        Me.txtEskiParola.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEskiParola.SelectedText = ""
        Me.txtEskiParola.SelectionLength = 0
        Me.txtEskiParola.SelectionStart = 0
        Me.txtEskiParola.ShortcutsEnabled = True
        Me.txtEskiParola.Size = New System.Drawing.Size(160, 29)
        Me.txtEskiParola.TabIndex = 0
        Me.txtEskiParola.UseSelectable = True
        Me.txtEskiParola.WaterMark = "********"
        Me.txtEskiParola.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEskiParola.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtYeniParola
        '
        '
        '
        '
        Me.txtYeniParola.CustomButton.Image = Nothing
        Me.txtYeniParola.CustomButton.Location = New System.Drawing.Point(132, 1)
        Me.txtYeniParola.CustomButton.Name = ""
        Me.txtYeniParola.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtYeniParola.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtYeniParola.CustomButton.TabIndex = 1
        Me.txtYeniParola.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtYeniParola.CustomButton.UseSelectable = True
        Me.txtYeniParola.CustomButton.Visible = False
        Me.txtYeniParola.Lines = New String(-1) {}
        Me.txtYeniParola.Location = New System.Drawing.Point(213, 112)
        Me.txtYeniParola.MaxLength = 32767
        Me.txtYeniParola.Name = "txtYeniParola"
        Me.txtYeniParola.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtYeniParola.PromptText = "********"
        Me.txtYeniParola.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtYeniParola.SelectedText = ""
        Me.txtYeniParola.SelectionLength = 0
        Me.txtYeniParola.SelectionStart = 0
        Me.txtYeniParola.ShortcutsEnabled = True
        Me.txtYeniParola.Size = New System.Drawing.Size(160, 29)
        Me.txtYeniParola.TabIndex = 1
        Me.txtYeniParola.UseSelectable = True
        Me.txtYeniParola.WaterMark = "********"
        Me.txtYeniParola.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtYeniParola.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtTekrarYeniParola
        '
        '
        '
        '
        Me.txtTekrarYeniParola.CustomButton.Image = Nothing
        Me.txtTekrarYeniParola.CustomButton.Location = New System.Drawing.Point(132, 1)
        Me.txtTekrarYeniParola.CustomButton.Name = ""
        Me.txtTekrarYeniParola.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtTekrarYeniParola.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTekrarYeniParola.CustomButton.TabIndex = 1
        Me.txtTekrarYeniParola.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTekrarYeniParola.CustomButton.UseSelectable = True
        Me.txtTekrarYeniParola.CustomButton.Visible = False
        Me.txtTekrarYeniParola.Lines = New String(-1) {}
        Me.txtTekrarYeniParola.Location = New System.Drawing.Point(213, 147)
        Me.txtTekrarYeniParola.MaxLength = 32767
        Me.txtTekrarYeniParola.Name = "txtTekrarYeniParola"
        Me.txtTekrarYeniParola.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtTekrarYeniParola.PromptText = "********"
        Me.txtTekrarYeniParola.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTekrarYeniParola.SelectedText = ""
        Me.txtTekrarYeniParola.SelectionLength = 0
        Me.txtTekrarYeniParola.SelectionStart = 0
        Me.txtTekrarYeniParola.ShortcutsEnabled = True
        Me.txtTekrarYeniParola.Size = New System.Drawing.Size(160, 29)
        Me.txtTekrarYeniParola.TabIndex = 2
        Me.txtTekrarYeniParola.UseSelectable = True
        Me.txtTekrarYeniParola.WaterMark = "********"
        Me.txtTekrarYeniParola.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTekrarYeniParola.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnKaydet
        '
        Me.btnKaydet.ActiveControl = Nothing
        Me.btnKaydet.Location = New System.Drawing.Point(379, 192)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(116, 49)
        Me.btnKaydet.TabIndex = 3
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.TileImage = CType(resources.GetObject("btnKaydet.TileImage"), System.Drawing.Image)
        Me.btnKaydet.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKaydet.UseSelectable = True
        Me.btnKaydet.UseTileImage = True
        '
        'btnVazgec
        '
        Me.btnVazgec.ActiveControl = Nothing
        Me.btnVazgec.Location = New System.Drawing.Point(270, 192)
        Me.btnVazgec.Name = "btnVazgec"
        Me.btnVazgec.Size = New System.Drawing.Size(103, 49)
        Me.btnVazgec.TabIndex = 2
        Me.btnVazgec.Text = "Vazgeç"
        Me.btnVazgec.TileImage = CType(resources.GetObject("btnVazgec.TileImage"), System.Drawing.Image)
        Me.btnVazgec.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVazgec.UseSelectable = True
        Me.btnVazgec.UseTileImage = True
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(22, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 2)
        Me.Label1.TabIndex = 3
        '
        'chcGizleGoster
        '
        Me.chcGizleGoster.AutoSize = True
        Me.chcGizleGoster.Location = New System.Drawing.Point(379, 81)
        Me.chcGizleGoster.Name = "chcGizleGoster"
        Me.chcGizleGoster.Size = New System.Drawing.Size(87, 15)
        Me.chcGizleGoster.TabIndex = 4
        Me.chcGizleGoster.Text = "Gizle/Göster"
        Me.chcGizleGoster.UseSelectable = True
        '
        'Form_SifreDegistir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 264)
        Me.ControlBox = False
        Me.Controls.Add(Me.chcGizleGoster)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVazgec)
        Me.Controls.Add(Me.btnKaydet)
        Me.Controls.Add(Me.txtTekrarYeniParola)
        Me.Controls.Add(Me.txtYeniParola)
        Me.Controls.Add(Me.txtEskiParola)
        Me.Controls.Add(Me.lblTekarYeniParola)
        Me.Controls.Add(Me.lblYeniParola)
        Me.Controls.Add(Me.lblEskiParola)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "Form_SifreDegistir"
        Me.Resizable = False
        Me.Text = "PAROLA DEĞİŞTİR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEskiParola As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblYeniParola As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTekarYeniParola As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtEskiParola As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtYeniParola As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTekrarYeniParola As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnKaydet As MetroFramework.Controls.MetroTile
    Friend WithEvents btnVazgec As MetroFramework.Controls.MetroTile
    Friend WithEvents Label1 As Label
    Friend WithEvents chcGizleGoster As MetroFramework.Controls.MetroCheckBox
End Class
