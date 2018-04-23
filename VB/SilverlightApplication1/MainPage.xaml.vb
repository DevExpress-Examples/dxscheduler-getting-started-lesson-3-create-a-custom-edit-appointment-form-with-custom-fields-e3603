Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.XtraScheduler
Imports DevExpress.Xpf.Scheduler

Namespace SilverlightApplication1
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()

			schedulerControl1.Start = New System.DateTime(2010, 7, 19, 0, 0, 0, 0)

		End Sub

		' Commit changes to the database.
		Private Sub SchedulerStorage_AppointmentCollectionModified(ByVal sender As Object, ByVal e As EventArgs)
			If domainDataSource1.HasChanges Then
				domainDataSource1.SubmitChanges()
			End If
		End Sub

		Private Sub DomainDataSource_LoadedData(ByVal sender As Object, ByVal e As LoadedDataEventArgs)
			If e.HasError Then
				MessageBox.Show("Connection could not be established." & Environment.NewLine & e.Error.Message, "Connection Error", MessageBoxButton.OK)
				e.MarkErrorAsHandled()
			End If
		End Sub

		Private Sub DomainDataSource_SubmittedChanges(ByVal sender As Object, ByVal e As SubmittedChangesEventArgs)
			If e.HasError Then
				MessageBox.Show(e.Error.ToString(), "Submit Changes Error", MessageBoxButton.OK)
				e.MarkErrorAsHandled()
			End If
		End Sub

		Private Sub schedulerControl1_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As EditAppointmentFormEventArgs)
			e.Form = New CustomAppointmentForm(Me.schedulerControl1, e.Appointment)
			e.AllowResize = False
		End Sub
	End Class
End Namespace
