Imports DevExpress.XtraScheduler
Public Class Form_Hatirlatma
    Private Sub btnClosed_Click(sender As Object, e As EventArgs) Handles btnClosed.Click
        Me.Hide()
    End Sub

    Private Sub Form_Hatirlatma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ResourcesTableAdapter.Fill(Me.SchedulerTestDataSet.Resources)
        ' TODO: This line of code loads data into the 'schedulerTestDataSet.Appointments' table. You can move, or remove it, as needed.
        Me.AppointmentsTableAdapter.Fill(Me.SchedulerTestDataSet.Appointments)

        shdcAjanda.Start = Date.Today
        shdcAjanda.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Day
        shdcAjanda.DayView.TopRowTime = New TimeSpan(10, 0, 0)
        shdcAjanda.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
        shdcAjanda.DayView.ResourcesPerPage = 2
        shdcAjanda.DayView.TimeIndicatorDisplayOptions.ShowOverAppointment = True


        AddHandler Me.SchedulerStorage1.AppointmentsChanged, AddressOf OnAppointmentChangedInsertedDeleted
        AddHandler Me.SchedulerStorage1.AppointmentsInserted, AddressOf OnAppointmentChangedInsertedDeleted
        AddHandler Me.SchedulerStorage1.AppointmentsDeleted, AddressOf OnAppointmentChangedInsertedDeleted

    End Sub

    Private Sub OnAppointmentChangedInsertedDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
        AppointmentsTableAdapter.Update(SchedulerTestDataSet)
        SchedulerTestDataSet.AcceptChanges()
    End Sub
End Class