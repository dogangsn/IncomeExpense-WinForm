<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_NotDefterim
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_NotDefterim))
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnYeni = New MetroFramework.Controls.MetroTile()
        Me.dtTarih = New MetroFramework.Controls.MetroDateTime()
        Me.txtBaslik = New MetroFramework.Controls.MetroTextBox()
        Me.lblBaslik = New MetroFramework.Controls.MetroLabel()
        Me.lblTarih = New MetroFramework.Controls.MetroLabel()
        Me.txtIcerik = New MetroFramework.Controls.MetroTextBox()
        Me.lblIcerik = New MetroFramework.Controls.MetroLabel()
        Me.chbOnemli = New MetroFramework.Controls.MetroCheckBox()
        Me.btnKaydet = New MetroFramework.Controls.MetroTile()
        Me.btnSil = New MetroFramework.Controls.MetroTile()
        Me.btnGuncelle = New MetroFramework.Controls.MetroTile()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbbKategori = New MetroFramework.Controls.MetroComboBox()
        Me.btnClosed = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.dtwKayitlar = New MetroFramework.Controls.MetroGrid()
        Me.Column4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnYazdir = New MetroFramework.Controls.MetroTile()
        Me.btnWordAktar = New MetroFramework.Controls.MetroTile()
        Me.txtKayitId = New MetroFramework.Controls.MetroTextBox()
        Me.lblFiltrele = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtwKayitlar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 2)
        Me.Label1.TabIndex = 0
        '
        'btnYeni
        '
        Me.btnYeni.ActiveControl = Nothing
        Me.btnYeni.Location = New System.Drawing.Point(79, 159)
        Me.btnYeni.Name = "btnYeni"
        Me.btnYeni.Size = New System.Drawing.Size(87, 75)
        Me.btnYeni.TabIndex = 1
        Me.btnYeni.Text = "Yeni"
        Me.btnYeni.TileImage = CType(resources.GetObject("btnYeni.TileImage"), System.Drawing.Image)
        Me.btnYeni.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnYeni.UseSelectable = True
        Me.btnYeni.UseTileImage = True
        '
        'dtTarih
        '
        Me.dtTarih.Location = New System.Drawing.Point(338, 22)
        Me.dtTarih.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtTarih.Name = "dtTarih"
        Me.dtTarih.Size = New System.Drawing.Size(200, 29)
        Me.dtTarih.TabIndex = 2
        '
        'txtBaslik
        '
        '
        '
        '
        Me.txtBaslik.CustomButton.Image = Nothing
        Me.txtBaslik.CustomButton.Location = New System.Drawing.Point(156, 1)
        Me.txtBaslik.CustomButton.Name = ""
        Me.txtBaslik.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtBaslik.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBaslik.CustomButton.TabIndex = 1
        Me.txtBaslik.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBaslik.CustomButton.UseSelectable = True
        Me.txtBaslik.CustomButton.Visible = False
        Me.txtBaslik.Lines = New String(-1) {}
        Me.txtBaslik.Location = New System.Drawing.Point(79, 26)
        Me.txtBaslik.MaxLength = 32767
        Me.txtBaslik.Name = "txtBaslik"
        Me.txtBaslik.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBaslik.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBaslik.SelectedText = ""
        Me.txtBaslik.SelectionLength = 0
        Me.txtBaslik.SelectionStart = 0
        Me.txtBaslik.ShortcutsEnabled = True
        Me.txtBaslik.Size = New System.Drawing.Size(184, 29)
        Me.txtBaslik.TabIndex = 3
        Me.txtBaslik.UseSelectable = True
        Me.txtBaslik.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBaslik.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblBaslik
        '
        Me.lblBaslik.AutoSize = True
        Me.lblBaslik.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblBaslik.Location = New System.Drawing.Point(21, 26)
        Me.lblBaslik.Name = "lblBaslik"
        Me.lblBaslik.Size = New System.Drawing.Size(54, 19)
        Me.lblBaslik.TabIndex = 4
        Me.lblBaslik.Text = "Başlık : "
        '
        'lblTarih
        '
        Me.lblTarih.AutoSize = True
        Me.lblTarih.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblTarih.Location = New System.Drawing.Point(289, 26)
        Me.lblTarih.Name = "lblTarih"
        Me.lblTarih.Size = New System.Drawing.Size(44, 19)
        Me.lblTarih.TabIndex = 5
        Me.lblTarih.Text = "Tarih :"
        '
        'txtIcerik
        '
        '
        '
        '
        Me.txtIcerik.CustomButton.Image = Nothing
        Me.txtIcerik.CustomButton.Location = New System.Drawing.Point(468, 1)
        Me.txtIcerik.CustomButton.Name = ""
        Me.txtIcerik.CustomButton.Size = New System.Drawing.Size(79, 79)
        Me.txtIcerik.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtIcerik.CustomButton.TabIndex = 1
        Me.txtIcerik.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtIcerik.CustomButton.UseSelectable = True
        Me.txtIcerik.CustomButton.Visible = False
        Me.txtIcerik.Lines = New String(-1) {}
        Me.txtIcerik.Location = New System.Drawing.Point(79, 65)
        Me.txtIcerik.MaxLength = 32767
        Me.txtIcerik.Multiline = True
        Me.txtIcerik.Name = "txtIcerik"
        Me.txtIcerik.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIcerik.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIcerik.SelectedText = ""
        Me.txtIcerik.SelectionLength = 0
        Me.txtIcerik.SelectionStart = 0
        Me.txtIcerik.ShortcutsEnabled = True
        Me.txtIcerik.Size = New System.Drawing.Size(548, 81)
        Me.txtIcerik.TabIndex = 6
        Me.txtIcerik.UseSelectable = True
        Me.txtIcerik.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtIcerik.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblIcerik
        '
        Me.lblIcerik.AutoSize = True
        Me.lblIcerik.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblIcerik.Location = New System.Drawing.Point(21, 65)
        Me.lblIcerik.Name = "lblIcerik"
        Me.lblIcerik.Size = New System.Drawing.Size(48, 19)
        Me.lblIcerik.TabIndex = 7
        Me.lblIcerik.Text = "İçerik :"
        '
        'chbOnemli
        '
        Me.chbOnemli.AutoSize = True
        Me.chbOnemli.Location = New System.Drawing.Point(554, 30)
        Me.chbOnemli.Name = "chbOnemli"
        Me.chbOnemli.Size = New System.Drawing.Size(62, 15)
        Me.chbOnemli.TabIndex = 8
        Me.chbOnemli.Text = "Önemli"
        Me.chbOnemli.UseSelectable = True
        '
        'btnKaydet
        '
        Me.btnKaydet.ActiveControl = Nothing
        Me.btnKaydet.Location = New System.Drawing.Point(172, 159)
        Me.btnKaydet.Name = "btnKaydet"
        Me.btnKaydet.Size = New System.Drawing.Size(87, 75)
        Me.btnKaydet.TabIndex = 1
        Me.btnKaydet.Text = "Kaydet"
        Me.btnKaydet.TileImage = CType(resources.GetObject("btnKaydet.TileImage"), System.Drawing.Image)
        Me.btnKaydet.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnKaydet.UseSelectable = True
        Me.btnKaydet.UseTileImage = True
        '
        'btnSil
        '
        Me.btnSil.ActiveControl = Nothing
        Me.btnSil.Enabled = False
        Me.btnSil.Location = New System.Drawing.Point(358, 159)
        Me.btnSil.Name = "btnSil"
        Me.btnSil.Size = New System.Drawing.Size(87, 75)
        Me.btnSil.TabIndex = 1
        Me.btnSil.Text = "Sil"
        Me.btnSil.TileImage = CType(resources.GetObject("btnSil.TileImage"), System.Drawing.Image)
        Me.btnSil.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnSil.UseSelectable = True
        Me.btnSil.UseTileImage = True
        '
        'btnGuncelle
        '
        Me.btnGuncelle.ActiveControl = Nothing
        Me.btnGuncelle.Enabled = False
        Me.btnGuncelle.Location = New System.Drawing.Point(265, 159)
        Me.btnGuncelle.Name = "btnGuncelle"
        Me.btnGuncelle.Size = New System.Drawing.Size(87, 75)
        Me.btnGuncelle.TabIndex = 1
        Me.btnGuncelle.Text = "Güncelle"
        Me.btnGuncelle.TileImage = CType(resources.GetObject("btnGuncelle.TileImage"), System.Drawing.Image)
        Me.btnGuncelle.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnGuncelle.UseSelectable = True
        Me.btnGuncelle.UseTileImage = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chbOnemli)
        Me.GroupBox1.Controls.Add(Me.lblIcerik)
        Me.GroupBox1.Controls.Add(Me.txtIcerik)
        Me.GroupBox1.Controls.Add(Me.lblTarih)
        Me.GroupBox1.Controls.Add(Me.lblBaslik)
        Me.GroupBox1.Controls.Add(Me.txtBaslik)
        Me.GroupBox1.Controls.Add(Me.dtTarih)
        Me.GroupBox1.Controls.Add(Me.btnGuncelle)
        Me.GroupBox1.Controls.Add(Me.btnSil)
        Me.GroupBox1.Controls.Add(Me.btnKaydet)
        Me.GroupBox1.Controls.Add(Me.btnYeni)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(643, 243)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'cbbKategori
        '
        Me.cbbKategori.FormattingEnabled = True
        Me.cbbKategori.ItemHeight = 23
        Me.cbbKategori.Items.AddRange(New Object() {"Onemli", "Tümü"})
        Me.cbbKategori.Location = New System.Drawing.Point(77, 312)
        Me.cbbKategori.Name = "cbbKategori"
        Me.cbbKategori.Size = New System.Drawing.Size(121, 29)
        Me.cbbKategori.TabIndex = 11
        Me.cbbKategori.Tag = ""
        Me.cbbKategori.UseSelectable = True
        '
        'btnClosed
        '
        WindowsUIButtonImageOptions1.Image = CType(resources.GetObject("WindowsUIButtonImageOptions1.Image"), System.Drawing.Image)
        Me.btnClosed.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Kapat", True, WindowsUIButtonImageOptions1)})
        Me.btnClosed.Location = New System.Drawing.Point(1039, 6)
        Me.btnClosed.Name = "btnClosed"
        Me.btnClosed.Size = New System.Drawing.Size(72, 61)
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
        Me.dtwKayitlar.ColumnHeadersHeight = 35
        Me.dtwKayitlar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column1, Me.Column2, Me.Column3, Me.Column5})
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
        Me.dtwKayitlar.Location = New System.Drawing.Point(20, 345)
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
        Me.dtwKayitlar.Size = New System.Drawing.Size(1065, 335)
        Me.dtwKayitlar.TabIndex = 19
        '
        'Column4
        '
        Me.Column4.HeaderText = ""
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 30
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
        Me.Column2.HeaderText = "Tarih"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.FillWeight = 3.412547!
        Me.Column3.HeaderText = "İçerik"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "id"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnYazdir)
        Me.GroupBox2.Controls.Add(Me.btnWordAktar)
        Me.GroupBox2.Location = New System.Drawing.Point(682, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(263, 107)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'btnYazdir
        '
        Me.btnYazdir.ActiveControl = Nothing
        Me.btnYazdir.Enabled = False
        Me.btnYazdir.Location = New System.Drawing.Point(139, 19)
        Me.btnYazdir.Name = "btnYazdir"
        Me.btnYazdir.Size = New System.Drawing.Size(98, 70)
        Me.btnYazdir.TabIndex = 9
        Me.btnYazdir.Text = "Yazdır"
        Me.btnYazdir.TileImage = CType(resources.GetObject("btnYazdir.TileImage"), System.Drawing.Image)
        Me.btnYazdir.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnYazdir.UseSelectable = True
        Me.btnYazdir.UseTileImage = True
        '
        'btnWordAktar
        '
        Me.btnWordAktar.ActiveControl = Nothing
        Me.btnWordAktar.Enabled = False
        Me.btnWordAktar.Location = New System.Drawing.Point(29, 19)
        Me.btnWordAktar.Name = "btnWordAktar"
        Me.btnWordAktar.Size = New System.Drawing.Size(104, 70)
        Me.btnWordAktar.TabIndex = 9
        Me.btnWordAktar.Text = "Worde Aktar"
        Me.btnWordAktar.TileImage = CType(resources.GetObject("btnWordAktar.TileImage"), System.Drawing.Image)
        Me.btnWordAktar.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnWordAktar.UseSelectable = True
        Me.btnWordAktar.UseTileImage = True
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
        Me.txtKayitId.Location = New System.Drawing.Point(951, 284)
        Me.txtKayitId.MaxLength = 32767
        Me.txtKayitId.Name = "txtKayitId"
        Me.txtKayitId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKayitId.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtKayitId.SelectedText = ""
        Me.txtKayitId.SelectionLength = 0
        Me.txtKayitId.SelectionStart = 0
        Me.txtKayitId.ShortcutsEnabled = True
        Me.txtKayitId.Size = New System.Drawing.Size(75, 23)
        Me.txtKayitId.TabIndex = 21
        Me.txtKayitId.UseSelectable = True
        Me.txtKayitId.Visible = False
        Me.txtKayitId.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtKayitId.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblFiltrele
        '
        Me.lblFiltrele.AutoSize = True
        Me.lblFiltrele.Location = New System.Drawing.Point(25, 316)
        Me.lblFiltrele.Name = "lblFiltrele"
        Me.lblFiltrele.Size = New System.Drawing.Size(51, 19)
        Me.lblFiltrele.TabIndex = 22
        Me.lblFiltrele.Text = "Filtrele:"
        '
        'Form_NotDefterim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblFiltrele)
        Me.Controls.Add(Me.txtKayitId)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dtwKayitlar)
        Me.Controls.Add(Me.btnClosed)
        Me.Controls.Add(Me.cbbKategori)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "Form_NotDefterim"
        Me.Text = "NOTLARIM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtwKayitlar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnYeni As MetroFramework.Controls.MetroTile
    Friend WithEvents dtTarih As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtBaslik As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblBaslik As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTarih As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtIcerik As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblIcerik As MetroFramework.Controls.MetroLabel
    Friend WithEvents chbOnemli As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents btnKaydet As MetroFramework.Controls.MetroTile
    Friend WithEvents btnSil As MetroFramework.Controls.MetroTile
    Friend WithEvents btnGuncelle As MetroFramework.Controls.MetroTile
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbbKategori As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnClosed As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents dtwKayitlar As MetroFramework.Controls.MetroGrid
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnYazdir As MetroFramework.Controls.MetroTile
    Friend WithEvents btnWordAktar As MetroFramework.Controls.MetroTile
    Friend WithEvents Column4 As DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents txtKayitId As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblFiltrele As MetroFramework.Controls.MetroLabel
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
