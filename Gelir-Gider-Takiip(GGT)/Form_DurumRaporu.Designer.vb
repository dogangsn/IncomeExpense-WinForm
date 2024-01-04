<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_DurumRaporu
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
        Dim SimpleDiagram3D1 As DevExpress.XtraCharts.SimpleDiagram3D = New DevExpress.XtraCharts.SimpleDiagram3D()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim Pie3DSeriesLabel1 As DevExpress.XtraCharts.Pie3DSeriesLabel = New DevExpress.XtraCharts.Pie3DSeriesLabel()
        Dim SeriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("TL", New Object() {CType(50.0R, Object)}, 0)
        Dim SeriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("GBP", New Object() {CType(30.0R, Object)}, 2)
        Dim SeriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("USB", New Object() {CType(10.0R, Object)}, 4)
        Dim SeriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("EUR", New Object() {CType(50.0R, Object)}, 5)
        Dim SeriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("GAD", New Object() {CType(30.0R, Object)}, 6)
        Dim Pie3DSeriesView1 As DevExpress.XtraCharts.Pie3DSeriesView = New DevExpress.XtraCharts.Pie3DSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim ToolTipFreePosition1 As DevExpress.XtraCharts.ToolTipFreePosition = New DevExpress.XtraCharts.ToolTipFreePosition()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SplineSeriesView1 As DevExpress.XtraCharts.SplineSeriesView = New DevExpress.XtraCharts.SplineSeriesView()
        Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim SideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
        Dim ChartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_DurumRaporu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.ChartControl2 = New DevExpress.XtraCharts.ChartControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.label6 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblBankaHesapları = New System.Windows.Forms.Label()
        Me.lblKalanTaksit = New System.Windows.Forms.Label()
        Me.lblGuncelBakiye = New System.Windows.Forms.Label()
        Me.lblBorc = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gridBankalar = New MetroFramework.Controls.MetroGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBankaEkle = New MetroFramework.Controls.MetroTile()
        Me.btnClosed = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SimpleDiagram3D1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Pie3DSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Pie3DSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SplineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gridBankalar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        'ChartControl1
        '
        Me.ChartControl1.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
        Me.ChartControl1.AppearanceNameSerializable = "Gray"
        Me.ChartControl1.BorderOptions.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.ChartControl1.DataBindings = Nothing
        SimpleDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1"
        Me.ChartControl1.Diagram = SimpleDiagram3D1
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Location = New System.Drawing.Point(2, 8)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.PaletteName = "Concourse"
        Pie3DSeriesLabel1.TextPattern = "{A}"
        Series1.Label = Pie3DSeriesLabel1
        Series1.Name = "Series 1"
        Series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {SeriesPoint1, SeriesPoint2, SeriesPoint3, SeriesPoint4, SeriesPoint5})
        Series1.View = Pie3DSeriesView1
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.ChartControl1.Size = New System.Drawing.Size(413, 231)
        Me.ChartControl1.TabIndex = 3
        ChartTitle1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Underline)
        ChartTitle1.Text = "Nakit"
        Me.ChartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        ToolTipFreePosition1.DockCorner = DevExpress.XtraCharts.ToolTipDockCorner.TopRight
        Me.ChartControl1.ToolTipOptions.ToolTipPosition = ToolTipFreePosition1
        '
        'ChartControl2
        '
        Me.ChartControl2.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartControl2.DataBindings = Nothing
        XyDiagram1.AxisX.Title.Text = ""
        XyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.VisualRange.Auto = False
        XyDiagram1.AxisY.VisualRange.MaxValueSerializable = "8.6"
        XyDiagram1.AxisY.VisualRange.MinValueSerializable = "0"
        XyDiagram1.PaneDistance = 5
        Me.ChartControl2.Diagram = XyDiagram1
        Me.ChartControl2.Legend.Name = "Default Legend"
        Me.ChartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
        Me.ChartControl2.Location = New System.Drawing.Point(447, 8)
        Me.ChartControl2.Name = "ChartControl2"
        Series2.Name = "Series 1"
        Series2.View = SplineSeriesView1
        Series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
        Series3.Name = "Series 2"
        SideBySideBarSeriesView1.Transparency = CType(135, Byte)
        Series3.View = SideBySideBarSeriesView1
        Me.ChartControl2.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series2, Series3}
        Me.ChartControl2.Size = New System.Drawing.Size(537, 214)
        Me.ChartControl2.TabIndex = 4
        ChartTitle2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Underline)
        ChartTitle2.Text = "Aylık Taksit Dengesi"
        Me.ChartControl2.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle2})
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(203, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(172, 88)
        Me.Panel1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(114, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 38)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Güncel " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bakiye"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(385, 95)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(172, 88)
        Me.Panel2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(114, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Borçlar"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(567, 95)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(172, 88)
        Me.Panel3.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.Location = New System.Drawing.Point(66, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Banka Hesapları"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Cyan
        Me.Panel4.Controls.Add(Me.label6)
        Me.Panel4.Location = New System.Drawing.Point(749, 95)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(172, 88)
        Me.Panel4.TabIndex = 5
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.label6.Location = New System.Drawing.Point(60, 9)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(109, 19)
        Me.label6.TabIndex = 0
        Me.label6.Text = "Kalan Taksitlerim"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblBankaHesapları)
        Me.Panel5.Controls.Add(Me.lblKalanTaksit)
        Me.Panel5.Controls.Add(Me.lblGuncelBakiye)
        Me.Panel5.Controls.Add(Me.lblBorc)
        Me.Panel5.Location = New System.Drawing.Point(162, 145)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(792, 35)
        Me.Panel5.TabIndex = 6
        '
        'lblBankaHesapları
        '
        Me.lblBankaHesapları.AutoSize = True
        Me.lblBankaHesapları.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblBankaHesapları.Location = New System.Drawing.Point(408, 3)
        Me.lblBankaHesapları.Name = "lblBankaHesapları"
        Me.lblBankaHesapları.Size = New System.Drawing.Size(24, 30)
        Me.lblBankaHesapları.TabIndex = 0
        Me.lblBankaHesapları.Text = "0"
        '
        'lblKalanTaksit
        '
        Me.lblKalanTaksit.AutoSize = True
        Me.lblKalanTaksit.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKalanTaksit.Location = New System.Drawing.Point(590, 3)
        Me.lblKalanTaksit.Name = "lblKalanTaksit"
        Me.lblKalanTaksit.Size = New System.Drawing.Size(24, 30)
        Me.lblKalanTaksit.TabIndex = 0
        Me.lblKalanTaksit.Text = "0"
        '
        'lblGuncelBakiye
        '
        Me.lblGuncelBakiye.AutoSize = True
        Me.lblGuncelBakiye.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblGuncelBakiye.Location = New System.Drawing.Point(44, 2)
        Me.lblGuncelBakiye.Name = "lblGuncelBakiye"
        Me.lblGuncelBakiye.Size = New System.Drawing.Size(68, 30)
        Me.lblGuncelBakiye.TabIndex = 0
        Me.lblGuncelBakiye.Text = "0,00 ₺"
        '
        'lblBorc
        '
        Me.lblBorc.AutoSize = True
        Me.lblBorc.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblBorc.Location = New System.Drawing.Point(226, 3)
        Me.lblBorc.Name = "lblBorc"
        Me.lblBorc.Size = New System.Drawing.Size(68, 30)
        Me.lblBorc.TabIndex = 0
        Me.lblBorc.Text = "0,00 ₺"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChartControl2)
        Me.GroupBox1.Controls.Add(Me.ChartControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 199)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1019, 246)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'gridBankalar
        '
        Me.gridBankalar.AllowUserToAddRows = False
        Me.gridBankalar.AllowUserToDeleteRows = False
        Me.gridBankalar.AllowUserToResizeRows = False
        Me.gridBankalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridBankalar.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridBankalar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gridBankalar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.gridBankalar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridBankalar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridBankalar.ColumnHeadersHeight = 40
        Me.gridBankalar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7, Me.Column6})
        Me.gridBankalar.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridBankalar.DefaultCellStyle = DataGridViewCellStyle2
        Me.gridBankalar.EnableHeadersVisualStyles = False
        Me.gridBankalar.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.gridBankalar.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gridBankalar.Location = New System.Drawing.Point(25, 63)
        Me.gridBankalar.Name = "gridBankalar"
        Me.gridBankalar.ReadOnly = True
        Me.gridBankalar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridBankalar.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.gridBankalar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.gridBankalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridBankalar.Size = New System.Drawing.Size(981, 129)
        Me.gridBankalar.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBankaEkle)
        Me.GroupBox2.Controls.Add(Me.gridBankalar)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(56, 444)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1019, 224)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bankalar"
        '
        'btnBankaEkle
        '
        Me.btnBankaEkle.ActiveControl = Nothing
        Me.btnBankaEkle.Location = New System.Drawing.Point(905, 25)
        Me.btnBankaEkle.Name = "btnBankaEkle"
        Me.btnBankaEkle.Size = New System.Drawing.Size(101, 32)
        Me.btnBankaEkle.TabIndex = 16
        Me.btnBankaEkle.Text = "Banka Ekle"
        Me.btnBankaEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnBankaEkle.TileTextFontSize = MetroFramework.MetroTileTextSize.Small
        Me.btnBankaEkle.UseSelectable = True
        '
        'btnClosed
        '
        WindowsUIButtonImageOptions1.Image = CType(resources.GetObject("WindowsUIButtonImageOptions1.Image"), System.Drawing.Image)
        Me.btnClosed.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Kapat", True, WindowsUIButtonImageOptions1)})
        Me.btnClosed.Location = New System.Drawing.Point(1050, 6)
        Me.btnClosed.Name = "btnClosed"
        Me.btnClosed.Size = New System.Drawing.Size(55, 62)
        Me.btnClosed.TabIndex = 15
        Me.btnClosed.Text = "WindowsUIButtonPanel1"
        '
        'Column1
        '
        Me.Column1.FillWeight = 89.54314!
        Me.Column1.HeaderText = "Bankalar"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 89.54314!
        Me.Column2.HeaderText = "Döviz Cinsi"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 89.54314!
        Me.Column3.HeaderText = "Döviz Cinsi Bakiye"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.FillWeight = 89.54314!
        Me.Column4.HeaderText = "Güncel TL Bakiye"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.FillWeight = 89.54314!
        Me.Column5.HeaderText = "Yüzde(%)"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "id"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Column6
        '
        Me.Column6.FillWeight = 152.2843!
        Me.Column6.HeaderText = ""
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.Text = "Kaldır"
        Me.Column6.UseColumnTextForButtonValue = True
        '
        'Form_DurumRaporu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClosed)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "Form_DurumRaporu"
        Me.Resizable = False
        Me.Text = "DURUM RAPORU"
        CType(SimpleDiagram3D1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Pie3DSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Pie3DSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SplineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(SideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.gridBankalar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents ChartControl2 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents label6 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblBankaHesapları As Label
    Friend WithEvents lblKalanTaksit As Label
    Friend WithEvents lblGuncelBakiye As Label
    Friend WithEvents lblBorc As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gridBankalar As MetroFramework.Controls.MetroGrid
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnClosed As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents btnBankaEkle As MetroFramework.Controls.MetroTile
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewButtonColumn
End Class
