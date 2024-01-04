<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Hatirlatma
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
        Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Hatirlatma))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.shdcAjanda = New DevExpress.XtraScheduler.SchedulerControl()
        Me.SchedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.dtnTarih = New DevExpress.XtraScheduler.DateNavigator()
        Me.btnClosed = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.SchedulerTestDataSet = New Gelir_Gider_Takiip_GGT_.SchedulerTestDataSet()
        Me.AppointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppointmentsTableAdapter = New Gelir_Gider_Takiip_GGT_.SchedulerTestDataSetTableAdapters.AppointmentsTableAdapter()
        Me.ResourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResourcesTableAdapter = New Gelir_Gider_Takiip_GGT_.SchedulerTestDataSetTableAdapters.ResourcesTableAdapter()
        CType(Me.shdcAjanda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtnTarih, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtnTarih.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerTestDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'shdcAjanda
        '
        Me.shdcAjanda.DataStorage = Me.SchedulerStorage1
        Me.shdcAjanda.Location = New System.Drawing.Point(20, 75)
        Me.shdcAjanda.Name = "shdcAjanda"
        Me.shdcAjanda.Size = New System.Drawing.Size(852, 602)
        Me.shdcAjanda.Start = New Date(2017, 10, 31, 0, 0, 0, 0)
        Me.shdcAjanda.TabIndex = 3
        Me.shdcAjanda.Text = "SchedulerControl1"
        Me.shdcAjanda.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.shdcAjanda.Views.FullWeekView.Enabled = True
        Me.shdcAjanda.Views.FullWeekView.TimeRulers.Add(TimeRuler2)
        Me.shdcAjanda.Views.WeekView.Enabled = False
        Me.shdcAjanda.Views.WorkWeekView.TimeRulers.Add(TimeRuler3)
        '
        'SchedulerStorage1
        '
        Me.SchedulerStorage1.Appointments.DataSource = Me.AppointmentsBindingSource
        Me.SchedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
        Me.SchedulerStorage1.Appointments.Mappings.Description = "Description"
        Me.SchedulerStorage1.Appointments.Mappings.End = "EndDate"
        Me.SchedulerStorage1.Appointments.Mappings.Label = "Label"
        Me.SchedulerStorage1.Appointments.Mappings.Location = "Location"
        Me.SchedulerStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
        Me.SchedulerStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
        Me.SchedulerStorage1.Appointments.Mappings.ResourceId = "ResourceID"
        Me.SchedulerStorage1.Appointments.Mappings.Start = "StartDate"
        Me.SchedulerStorage1.Appointments.Mappings.Status = "Status"
        Me.SchedulerStorage1.Appointments.Mappings.Subject = "Subject"
        Me.SchedulerStorage1.Appointments.Mappings.TimeZoneId = "TimeZoneId"
        Me.SchedulerStorage1.Appointments.Mappings.Type = "Type"
        Me.SchedulerStorage1.Resources.DataSource = Me.ResourcesBindingSource
        Me.SchedulerStorage1.Resources.Mappings.Caption = "ResourceName"
        Me.SchedulerStorage1.Resources.Mappings.Color = "Color"
        Me.SchedulerStorage1.Resources.Mappings.Id = "ResourceID"
        Me.SchedulerStorage1.Resources.Mappings.Image = "Image"
        '
        'dtnTarih
        '
        Me.dtnTarih.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.dtnTarih.CalendarAppearance.DayCellSpecial.Options.UseFont = True
        Me.dtnTarih.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtnTarih.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtnTarih.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.dtnTarih.Location = New System.Drawing.Point(878, 75)
        Me.dtnTarih.Name = "dtnTarih"
        Me.dtnTarih.SchedulerControl = Me.shdcAjanda
        Me.dtnTarih.Size = New System.Drawing.Size(213, 602)
        Me.dtnTarih.TabIndex = 4
        '
        'btnClosed
        '
        WindowsUIButtonImageOptions1.Image = CType(resources.GetObject("WindowsUIButtonImageOptions1.Image"), System.Drawing.Image)
        Me.btnClosed.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Kapat", True, WindowsUIButtonImageOptions1)})
        Me.btnClosed.Location = New System.Drawing.Point(1041, 6)
        Me.btnClosed.Name = "btnClosed"
        Me.btnClosed.Size = New System.Drawing.Size(70, 61)
        Me.btnClosed.TabIndex = 14
        Me.btnClosed.Text = "WindowsUIButtonPanel1"
        '
        'SchedulerTestDataSet
        '
        Me.SchedulerTestDataSet.DataSetName = "SchedulerTestDataSet"
        Me.SchedulerTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AppointmentsBindingSource
        '
        Me.AppointmentsBindingSource.DataMember = "Appointments"
        Me.AppointmentsBindingSource.DataSource = Me.SchedulerTestDataSet
        '
        'AppointmentsTableAdapter
        '
        Me.AppointmentsTableAdapter.ClearBeforeFill = True
        '
        'ResourcesBindingSource
        '
        Me.ResourcesBindingSource.DataMember = "Resources"
        Me.ResourcesBindingSource.DataSource = Me.SchedulerTestDataSet
        '
        'ResourcesTableAdapter
        '
        Me.ResourcesTableAdapter.ClearBeforeFill = True
        '
        'Form_Hatirlatma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClosed)
        Me.Controls.Add(Me.dtnTarih)
        Me.Controls.Add(Me.shdcAjanda)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Movable = False
        Me.Name = "Form_Hatirlatma"
        Me.Resizable = False
        Me.Text = "AJANDAM"
        CType(Me.shdcAjanda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtnTarih.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtnTarih, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerTestDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents shdcAjanda As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents SchedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents dtnTarih As DevExpress.XtraScheduler.DateNavigator
    Friend WithEvents btnClosed As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents SchedulerTestDataSet As SchedulerTestDataSet
    Friend WithEvents AppointmentsBindingSource As BindingSource
    Friend WithEvents AppointmentsTableAdapter As SchedulerTestDataSetTableAdapters.AppointmentsTableAdapter
    Friend WithEvents ResourcesBindingSource As BindingSource
    Friend WithEvents ResourcesTableAdapter As SchedulerTestDataSetTableAdapters.ResourcesTableAdapter
End Class
