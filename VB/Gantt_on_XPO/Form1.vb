Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.XtraScheduler

Namespace WindowsFormsApplication9
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			Me.schedulerControl1.Start = DateTime.Today
			InitData()
		End Sub

		Private Sub InitData()
			Dim resources() As String = { "r1", "r2", "r3", "r4", "r5" }
			If xpCollectionResources.Count <= 0 Then
				For i As Integer = 0 To 4
						AddResource(resources(i))
				Next i
			End If
		End Sub
		Private Sub AddResource(ByVal name As String)
			Dim res As New XPOResource(session1)
			res.Name = name
			If xpCollectionResources.Count > 0 Then
				res.ParentResource = CType(xpCollectionResources(0), XPOResource)
			End If
			xpCollectionResources.Add(res)
			res.Save()
		End Sub
		#Region "#appointmentschanges"
		Private Sub schedulerStorage1_AppointmentsChanged(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage1.AppointmentsInserted, schedulerStorage1.AppointmentsChanged
			For Each apt As Appointment In e.Objects
				Dim xpObject As XPOAppointment = TryCast(apt.GetSourceObject(schedulerStorage1), XPOAppointment)
				If xpObject IsNot Nothing Then
					xpObject.Save()
					schedulerStorage1.SetAppointmentId(apt, xpObject.Oid)
				End If
			Next apt
		End Sub
		#End Region ' #appointmentschanged
		#Region "#appointmentdependencieschanged"
		Private Sub schedulerStorage1_AppointmentDependenciesChanged(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage1.AppointmentDependenciesInserted, schedulerStorage1.AppointmentDependenciesChanged
			For Each dependency As AppointmentDependency In e.Objects
				Dim xpObject As XPBaseObject = TryCast(dependency.GetSourceObject(schedulerStorage1), XPBaseObject)
				If xpObject IsNot Nothing Then
					xpObject.Save()
				End If
			Next dependency
		End Sub
		#End Region ' #appointmentdependencieschanged

	End Class

	#Region "xpobjects"
	' XP object
	Public Class XPOAppointment
		Inherits XPObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public AllDay As Boolean ' Appointment.AllDay

		<Size(SizeAttribute.Unlimited)> _
		Public Description As String ' Appointment.Description

		Public Finish As DateTime ' Appointment.End
		Public Label As Integer ' Appointment.Label
		Public Location As String ' Appointment.Location

		<Size(SizeAttribute.Unlimited)> _
		Public Recurrence As String ' Appointment.RecurrenceInfo

		<Size(SizeAttribute.Unlimited)> _
		Public Reminder As String ' Appointment.ReminderInfo

		Public Created As DateTime ' Appointment.Start
		Public Status As Integer ' Appointment.Status
		Public Subject As String ' Appointment.Subject
		Public AppointmentType As Integer ' Appointment.Type

		Public Resource As XPOResource
		Public PercentComplete As Integer
	End Class

	' XP object
	Public Class XPOResource
		Inherits XPObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		<Size(SizeAttribute.Unlimited)> _
		Public Name As String ' Resource.Caption
		Public ParentResource As XPOResource
	End Class
	' XP object
	Public Class XPODependency
		Inherits XPObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Public ParentApt As XPOAppointment
		Public DependentApt As XPOAppointment

		Public Type As Integer
	End Class
	#End Region ' #xpobjects
End Namespace