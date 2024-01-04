<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_GelirGiderListe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_GelirGiderListe))
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExcelAktar = New MetroFramework.Controls.MetroTile()
        Me.btnRapor = New MetroFramework.Controls.MetroTile()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClosed = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.dtwKayitlar = New MetroFramework.Controls.MetroGrid()
        Me.lblTotalGider = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotalGelirim = New System.Windows.Forms.TextBox()
        Me.txtTotalGider = New System.Windows.Forms.TextBox()
        Me.lblTotalGelir = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.calcHesapMakinesi = New DevExpress.XtraEditors.CalcEdit()
        Me.lblHesapMakinesi = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chbTumKayitlar = New MetroFramework.Controls.MetroCheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.dtSonTarih = New MetroFramework.Controls.MetroDateTime()
        Me.blFiltrele = New MetroFramework.Controls.MetroLabel()
        Me.dtIlkTarih = New MetroFramework.Controls.MetroDateTime()
        Me.Report1 = New FastReport.Report()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New FastReport.DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtwKayitlar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.calcHesapMakinesi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Report1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnExcelAktar
        '
        Me.btnExcelAktar.ActiveControl = Nothing
        Me.btnExcelAktar.Location = New System.Drawing.Point(28, 14)
        Me.btnExcelAktar.Name = "btnExcelAktar"
        Me.btnExcelAktar.Size = New System.Drawing.Size(93, 75)
        Me.btnExcelAktar.TabIndex = 2
        Me.btnExcelAktar.Text = "Excele Aktar"
        Me.btnExcelAktar.TileImage = CType(resources.GetObject("btnExcelAktar.TileImage"), System.Drawing.Image)
        Me.btnExcelAktar.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnExcelAktar.UseSelectable = True
        Me.btnExcelAktar.UseTileImage = True
        '
        'btnRapor
        '
        Me.btnRapor.ActiveControl = Nothing
        Me.btnRapor.Location = New System.Drawing.Point(127, 14)
        Me.btnRapor.Name = "btnRapor"
        Me.btnRapor.Size = New System.Drawing.Size(87, 75)
        Me.btnRapor.TabIndex = 2
        Me.btnRapor.Text = "Rapor Al"
        Me.btnRapor.TileImage = CType(resources.GetObject("btnRapor.TileImage"), System.Drawing.Image)
        Me.btnRapor.TileImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnRapor.UseSelectable = True
        Me.btnRapor.UseTileImage = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRapor)
        Me.GroupBox1.Controls.Add(Me.btnExcelAktar)
        Me.GroupBox1.Location = New System.Drawing.Point(837, 577)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 117)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'btnClosed
        '
        WindowsUIButtonImageOptions1.Image = CType(resources.GetObject("WindowsUIButtonImageOptions1.Image"), System.Drawing.Image)
        Me.btnClosed.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Kapat", True, WindowsUIButtonImageOptions1)})
        Me.btnClosed.Location = New System.Drawing.Point(1045, 6)
        Me.btnClosed.Name = "btnClosed"
        Me.btnClosed.Size = New System.Drawing.Size(62, 61)
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
        Me.dtwKayitlar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1, Me.Column3, Me.Column4, Me.Column6, Me.Column7, Me.Column5})
        Me.dtwKayitlar.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtwKayitlar.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtwKayitlar.EnableHeadersVisualStyles = False
        Me.dtwKayitlar.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dtwKayitlar.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtwKayitlar.Location = New System.Drawing.Point(23, 73)
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
        Me.dtwKayitlar.Size = New System.Drawing.Size(1065, 498)
        Me.dtwKayitlar.TabIndex = 19
        '
        'lblTotalGider
        '
        Me.lblTotalGider.AutoSize = True
        Me.lblTotalGider.Location = New System.Drawing.Point(6, 24)
        Me.lblTotalGider.Name = "lblTotalGider"
        Me.lblTotalGider.Size = New System.Drawing.Size(109, 19)
        Me.lblTotalGider.TabIndex = 20
        Me.lblTotalGider.Text = "Total Giderlerim :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTotalGelirim)
        Me.GroupBox2.Controls.Add(Me.txtTotalGider)
        Me.GroupBox2.Controls.Add(Me.lblTotalGelir)
        Me.GroupBox2.Controls.Add(Me.lblTotalGider)
        Me.GroupBox2.Location = New System.Drawing.Point(577, 578)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(243, 116)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'txtTotalGelirim
        '
        Me.txtTotalGelirim.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTotalGelirim.Enabled = False
        Me.txtTotalGelirim.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTotalGelirim.ForeColor = System.Drawing.SystemColors.Info
        Me.txtTotalGelirim.Location = New System.Drawing.Point(121, 53)
        Me.txtTotalGelirim.Multiline = True
        Me.txtTotalGelirim.Name = "txtTotalGelirim"
        Me.txtTotalGelirim.ReadOnly = True
        Me.txtTotalGelirim.Size = New System.Drawing.Size(107, 23)
        Me.txtTotalGelirim.TabIndex = 21
        '
        'txtTotalGider
        '
        Me.txtTotalGider.BackColor = System.Drawing.Color.IndianRed
        Me.txtTotalGider.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtTotalGider.ForeColor = System.Drawing.Color.White
        Me.txtTotalGider.Location = New System.Drawing.Point(121, 24)
        Me.txtTotalGider.Multiline = True
        Me.txtTotalGider.Name = "txtTotalGider"
        Me.txtTotalGider.ReadOnly = True
        Me.txtTotalGider.Size = New System.Drawing.Size(107, 23)
        Me.txtTotalGider.TabIndex = 21
        '
        'lblTotalGelir
        '
        Me.lblTotalGelir.AutoSize = True
        Me.lblTotalGelir.Location = New System.Drawing.Point(6, 53)
        Me.lblTotalGelir.Name = "lblTotalGelir"
        Me.lblTotalGelir.Size = New System.Drawing.Size(104, 19)
        Me.lblTotalGelir.TabIndex = 20
        Me.lblTotalGelir.Text = "Total Gelirlerim :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.calcHesapMakinesi)
        Me.GroupBox3.Controls.Add(Me.lblHesapMakinesi)
        Me.GroupBox3.Location = New System.Drawing.Point(299, 578)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(261, 116)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        '
        'calcHesapMakinesi
        '
        Me.calcHesapMakinesi.Location = New System.Drawing.Point(157, 43)
        Me.calcHesapMakinesi.Name = "calcHesapMakinesi"
        Me.calcHesapMakinesi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.calcHesapMakinesi.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.calcHesapMakinesi.Size = New System.Drawing.Size(76, 20)
        Me.calcHesapMakinesi.TabIndex = 7
        '
        'lblHesapMakinesi
        '
        Me.lblHesapMakinesi.AutoSize = True
        Me.lblHesapMakinesi.Location = New System.Drawing.Point(16, 44)
        Me.lblHesapMakinesi.Name = "lblHesapMakinesi"
        Me.lblHesapMakinesi.Size = New System.Drawing.Size(137, 19)
        Me.lblHesapMakinesi.TabIndex = 3
        Me.lblHesapMakinesi.Text = "Basit Hesap Makinesi :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.chbTumKayitlar)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.MetroLabel4)
        Me.GroupBox4.Controls.Add(Me.dtSonTarih)
        Me.GroupBox4.Controls.Add(Me.blFiltrele)
        Me.GroupBox4.Controls.Add(Me.dtIlkTarih)
        Me.GroupBox4.Location = New System.Drawing.Point(32, 577)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(251, 117)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        '
        'chbTumKayitlar
        '
        Me.chbTumKayitlar.AutoSize = True
        Me.chbTumKayitlar.Checked = True
        Me.chbTumKayitlar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbTumKayitlar.Location = New System.Drawing.Point(61, 96)
        Me.chbTumKayitlar.Name = "chbTumKayitlar"
        Me.chbTumKayitlar.Size = New System.Drawing.Size(130, 15)
        Me.chbTumKayitlar.TabIndex = 27
        Me.chbTumKayitlar.Text = "Tüm Kayırları Göster"
        Me.chbTumKayitlar.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "*Belirli Tarihler Arasında filtreleme Yapar..."
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(117, 48)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(15, 19)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "-"
        '
        'dtSonTarih
        '
        Me.dtSonTarih.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtSonTarih.Location = New System.Drawing.Point(137, 44)
        Me.dtSonTarih.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtSonTarih.Name = "dtSonTarih"
        Me.dtSonTarih.Size = New System.Drawing.Size(106, 29)
        Me.dtSonTarih.TabIndex = 2
        Me.dtSonTarih.Value = New Date(2018, 4, 5, 0, 0, 0, 0)
        '
        'blFiltrele
        '
        Me.blFiltrele.AutoSize = True
        Me.blFiltrele.Location = New System.Drawing.Point(6, 16)
        Me.blFiltrele.Name = "blFiltrele"
        Me.blFiltrele.Size = New System.Drawing.Size(55, 19)
        Me.blFiltrele.TabIndex = 1
        Me.blFiltrele.Text = "Filtrele :"
        '
        'dtIlkTarih
        '
        Me.dtIlkTarih.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtIlkTarih.Location = New System.Drawing.Point(6, 44)
        Me.dtIlkTarih.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtIlkTarih.Name = "dtIlkTarih"
        Me.dtIlkTarih.Size = New System.Drawing.Size(106, 29)
        Me.dtIlkTarih.TabIndex = 0
        Me.dtIlkTarih.Value = New Date(2018, 4, 5, 0, 0, 0, 0)
        '
        'Report1
        '
        Me.Report1.NeedRefresh = False
        Me.Report1.ReportResourceString = resources.GetString("Report1.ReportResourceString")
        '
        'Column2
        '
        Me.Column2.FillWeight = 3.412249!
        Me.Column2.HeaderText = "islem"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'Column1
        '
        Me.Column1.FillWeight = 3.417969!
        Me.Column1.HeaderText = "Başlık"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 3.412547!
        Me.Column3.HeaderText = "Miktar"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        '
        '
        '
        Me.Column4.BackgroundStyle.Class = "DataGridViewDateTimeBorder"
        Me.Column4.BackgroundStyle.CornerType = FastReport.DevComponents.DotNetBar.eCornerType.Square
        Me.Column4.FillWeight = 3.415158!
        Me.Column4.HeaderText = "Tarih"
        Me.Column4.InputHorizontalAlignment = FastReport.DevComponents.Editors.eHorizontalAlignment.Left
        '
        '
        '
        Me.Column4.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.Column4.MonthCalendar.BackgroundStyle.CornerType = FastReport.DevComponents.DotNetBar.eCornerType.Square
        Me.Column4.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        '
        '
        '
        Me.Column4.MonthCalendar.CommandsBackgroundStyle.CornerType = FastReport.DevComponents.DotNetBar.eCornerType.Square
        Me.Column4.MonthCalendar.DisplayMonth = New Date(2018, 4, 1, 0, 0, 0, 0)
        Me.Column4.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.Column4.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.Column4.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.Column4.MonthCalendar.NavigationBackgroundStyle.CornerType = FastReport.DevComponents.DotNetBar.eCornerType.Square
        Me.Column4.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.Width = 120
        '
        'Column6
        '
        Me.Column6.FillWeight = 3.414881!
        Me.Column6.HeaderText = "Alınan/Ödenen"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 130
        '
        'Column7
        '
        Me.Column7.FillWeight = 679.5114!
        Me.Column7.HeaderText = "Ödeme Şekli"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 150
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column5.HeaderText = "Açıklama"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Form_GelirGiderListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 706)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dtwKayitlar)
        Me.Controls.Add(Me.btnClosed)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "Form_GelirGiderListe"
        Me.Resizable = False
        Me.Text = "GELİR-GİDER LİSTE"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dtwKayitlar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.calcHesapMakinesi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Report1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnExcelAktar As MetroFramework.Controls.MetroTile
    Friend WithEvents btnRapor As MetroFramework.Controls.MetroTile
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnClosed As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents dtwKayitlar As MetroFramework.Controls.MetroGrid
    Friend WithEvents lblTotalGider As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblTotalGelir As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents calcHesapMakinesi As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents lblHesapMakinesi As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtSonTarih As MetroFramework.Controls.MetroDateTime
    Friend WithEvents blFiltrele As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtIlkTarih As MetroFramework.Controls.MetroDateTime
    Friend WithEvents chbTumKayitlar As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Report1 As FastReport.Report
    Public WithEvents txtTotalGelirim As TextBox
    Public WithEvents txtTotalGider As TextBox
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As FastReport.DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
