Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication9
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
			Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
			Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.xpCollectionDependences = New DevExpress.Xpo.XPCollection(Me.components)
			Me.session1 = New DevExpress.Xpo.Session(Me.components)
			Me.xpCollectionAppointments = New DevExpress.Xpo.XPCollection(Me.components)
			Me.xpCollectionResources = New DevExpress.Xpo.XPCollection(Me.components)
			Me.resourcesTree1 = New DevExpress.XtraScheduler.UI.ResourcesTree()
			Me.colName = New DevExpress.XtraScheduler.Native.ResourceTreeColumn()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xpCollectionDependences, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.session1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xpCollectionAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xpCollectionResources, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.resourcesTree1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' schedulerControl1
			' 
			Me.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Gantt
			Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
			Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
			Me.schedulerControl1.Name = "schedulerControl1"
			Me.schedulerControl1.Size = New System.Drawing.Size(581, 425)
			Me.schedulerControl1.Start = New System.DateTime(2011, 12, 2, 0, 0, 0, 0)
			Me.schedulerControl1.Storage = Me.schedulerStorage1
			Me.schedulerControl1.TabIndex = 0
			Me.schedulerControl1.Text = "schedulerControl1"
			Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
			' 
			' schedulerStorage1
			' 
			Me.schedulerStorage1.AppointmentDependencies.DataSource = Me.xpCollectionDependences
			Me.schedulerStorage1.AppointmentDependencies.Mappings.DependentId = "DependentApt!Key"
			Me.schedulerStorage1.AppointmentDependencies.Mappings.ParentId = "ParentApt!Key"
			Me.schedulerStorage1.AppointmentDependencies.Mappings.Type = "Type"
			Me.schedulerStorage1.Appointments.DataSource = Me.xpCollectionAppointments
			Me.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay"
			Me.schedulerStorage1.Appointments.Mappings.AppointmentId = "Oid"
			Me.schedulerStorage1.Appointments.Mappings.Description = "Description"
			Me.schedulerStorage1.Appointments.Mappings.End = "Finish"
			Me.schedulerStorage1.Appointments.Mappings.Label = "Label"
			Me.schedulerStorage1.Appointments.Mappings.Location = "Location"
			Me.schedulerStorage1.Appointments.Mappings.PercentComplete = "PercentComplete"
			Me.schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "Recurrence"
			Me.schedulerStorage1.Appointments.Mappings.ReminderInfo = "Reminder"
			Me.schedulerStorage1.Appointments.Mappings.ResourceId = "Resource!Key"
			Me.schedulerStorage1.Appointments.Mappings.Start = "Created"
			Me.schedulerStorage1.Appointments.Mappings.Status = "Status"
			Me.schedulerStorage1.Appointments.Mappings.Subject = "Subject"
			Me.schedulerStorage1.Appointments.Mappings.Type = "AppointmentType"
			Me.schedulerStorage1.Resources.DataSource = Me.xpCollectionResources
			Me.schedulerStorage1.Resources.Mappings.Caption = "Name"
			Me.schedulerStorage1.Resources.Mappings.Id = "Oid"
			Me.schedulerStorage1.Resources.Mappings.ParentId = "ParentResource!Key"
'			Me.schedulerStorage1.AppointmentDependenciesInserted += New DevExpress.XtraScheduler.PersistentObjectsEventHandler(Me.schedulerStorage1_AppointmentDependenciesChanged);
'			Me.schedulerStorage1.AppointmentDependenciesChanged += New DevExpress.XtraScheduler.PersistentObjectsEventHandler(Me.schedulerStorage1_AppointmentDependenciesChanged);
'			Me.schedulerStorage1.AppointmentsInserted += New DevExpress.XtraScheduler.PersistentObjectsEventHandler(Me.schedulerStorage1_AppointmentsChanged);
'			Me.schedulerStorage1.AppointmentsChanged += New DevExpress.XtraScheduler.PersistentObjectsEventHandler(Me.schedulerStorage1_AppointmentsChanged);
			' 
			' xpCollectionDependences
			' 
			Me.xpCollectionDependences.DeleteObjectOnRemove = True
			Me.xpCollectionDependences.ObjectType = GetType(WindowsFormsApplication9.XPODependency)
			Me.xpCollectionDependences.Session = Me.session1
			' 
			' xpCollectionAppointments
			' 
			Me.xpCollectionAppointments.DeleteObjectOnRemove = True
			Me.xpCollectionAppointments.ObjectType = GetType(WindowsFormsApplication9.XPOAppointment)
			Me.xpCollectionAppointments.Session = Me.session1
			' 
			' xpCollectionResources
			' 
			Me.xpCollectionResources.DeleteObjectOnRemove = True
			Me.xpCollectionResources.ObjectType = GetType(WindowsFormsApplication9.XPOResource)
			Me.xpCollectionResources.Session = Me.session1
			' 
			' resourcesTree1
			' 
			Me.resourcesTree1.ColumnPanelRowHeight = 55
			Me.resourcesTree1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.colName})
			Me.resourcesTree1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.resourcesTree1.Location = New System.Drawing.Point(0, 0)
			Me.resourcesTree1.Name = "resourcesTree1"
			Me.resourcesTree1.SchedulerControl = Me.schedulerControl1
			Me.resourcesTree1.Size = New System.Drawing.Size(205, 425)
			Me.resourcesTree1.TabIndex = 1
			' 
			' colName
			' 
			Me.colName.FieldName = "Name"
			Me.colName.Name = "colName"
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 0
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.resourcesTree1)
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.schedulerControl1)
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(791, 425)
			Me.splitContainerControl1.SplitterPosition = 205
			Me.splitContainerControl1.TabIndex = 2
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(791, 425)
			Me.Controls.Add(Me.splitContainerControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xpCollectionDependences, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.session1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xpCollectionAppointments, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xpCollectionResources, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.resourcesTree1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
		Private WithEvents schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
		Private xpCollectionAppointments As DevExpress.Xpo.XPCollection
		Private session1 As DevExpress.Xpo.Session
		Private xpCollectionResources As DevExpress.Xpo.XPCollection
		Private xpCollectionDependences As DevExpress.Xpo.XPCollection
		Private resourcesTree1 As DevExpress.XtraScheduler.UI.ResourcesTree
		Private colName As DevExpress.XtraScheduler.Native.ResourceTreeColumn
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
	End Class
End Namespace
