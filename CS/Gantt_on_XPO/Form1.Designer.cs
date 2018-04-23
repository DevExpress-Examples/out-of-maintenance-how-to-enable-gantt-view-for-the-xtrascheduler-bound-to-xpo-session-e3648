namespace WindowsFormsApplication9 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.xpCollectionDependences = new DevExpress.Xpo.XPCollection(this.components);
            this.session1 = new DevExpress.Xpo.Session(this.components);
            this.xpCollectionAppointments = new DevExpress.Xpo.XPCollection(this.components);
            this.xpCollectionResources = new DevExpress.Xpo.XPCollection(this.components);
            this.resourcesTree1 = new DevExpress.XtraScheduler.UI.ResourcesTree();
            this.colName = new DevExpress.XtraScheduler.Native.ResourceTreeColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionDependences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesTree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Gantt;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(581, 425);
            this.schedulerControl1.Start = new System.DateTime(2011, 12, 2, 0, 0, 0, 0);
            this.schedulerControl1.Storage = this.schedulerStorage1;
            this.schedulerControl1.TabIndex = 0;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            // 
            // schedulerStorage1
            // 
            this.schedulerStorage1.AppointmentDependencies.DataSource = this.xpCollectionDependences;
            this.schedulerStorage1.AppointmentDependencies.Mappings.DependentId = "DependentApt!Key";
            this.schedulerStorage1.AppointmentDependencies.Mappings.ParentId = "ParentApt!Key";
            this.schedulerStorage1.AppointmentDependencies.Mappings.Type = "Type";
            this.schedulerStorage1.Appointments.DataSource = this.xpCollectionAppointments;
            this.schedulerStorage1.Appointments.Mappings.AllDay = "AllDay";
            this.schedulerStorage1.Appointments.Mappings.AppointmentId = "Oid";
            this.schedulerStorage1.Appointments.Mappings.Description = "Description";
            this.schedulerStorage1.Appointments.Mappings.End = "Finish";
            this.schedulerStorage1.Appointments.Mappings.Label = "Label";
            this.schedulerStorage1.Appointments.Mappings.Location = "Location";
            this.schedulerStorage1.Appointments.Mappings.PercentComplete = "PercentComplete";
            this.schedulerStorage1.Appointments.Mappings.RecurrenceInfo = "Recurrence";
            this.schedulerStorage1.Appointments.Mappings.ReminderInfo = "Reminder";
            this.schedulerStorage1.Appointments.Mappings.ResourceId = "Resource!Key";
            this.schedulerStorage1.Appointments.Mappings.Start = "Created";
            this.schedulerStorage1.Appointments.Mappings.Status = "Status";
            this.schedulerStorage1.Appointments.Mappings.Subject = "Subject";
            this.schedulerStorage1.Appointments.Mappings.Type = "AppointmentType";
            this.schedulerStorage1.Resources.DataSource = this.xpCollectionResources;
            this.schedulerStorage1.Resources.Mappings.Caption = "Name";
            this.schedulerStorage1.Resources.Mappings.Id = "Oid";
            this.schedulerStorage1.Resources.Mappings.ParentId = "ParentResource!Key";
            this.schedulerStorage1.AppointmentDependenciesInserted += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.schedulerStorage1_AppointmentDependenciesChanged);
            this.schedulerStorage1.AppointmentDependenciesChanged += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.schedulerStorage1_AppointmentDependenciesChanged);
            this.schedulerStorage1.AppointmentsInserted += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.schedulerStorage1_AppointmentsChanged);
            this.schedulerStorage1.AppointmentsChanged += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.schedulerStorage1_AppointmentsChanged);
            // 
            // xpCollectionDependences
            // 
            this.xpCollectionDependences.DeleteObjectOnRemove = true;
            this.xpCollectionDependences.ObjectType = typeof(WindowsFormsApplication9.XPODependency);
            this.xpCollectionDependences.Session = this.session1;
            // 
            // xpCollectionAppointments
            // 
            this.xpCollectionAppointments.DeleteObjectOnRemove = true;
            this.xpCollectionAppointments.ObjectType = typeof(WindowsFormsApplication9.XPOAppointment);
            this.xpCollectionAppointments.Session = this.session1;
            // 
            // xpCollectionResources
            // 
            this.xpCollectionResources.DeleteObjectOnRemove = true;
            this.xpCollectionResources.ObjectType = typeof(WindowsFormsApplication9.XPOResource);
            this.xpCollectionResources.Session = this.session1;
            // 
            // resourcesTree1
            // 
            this.resourcesTree1.ColumnPanelRowHeight = 55;
            this.resourcesTree1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName});
            this.resourcesTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourcesTree1.Location = new System.Drawing.Point(0, 0);
            this.resourcesTree1.Name = "resourcesTree1";
            this.resourcesTree1.SchedulerControl = this.schedulerControl1;
            this.resourcesTree1.Size = new System.Drawing.Size(205, 425);
            this.resourcesTree1.TabIndex = 1;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.resourcesTree1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.schedulerControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(791, 425);
            this.splitContainerControl1.SplitterPosition = 205;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 425);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionDependences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollectionResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesTree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private DevExpress.Xpo.XPCollection xpCollectionAppointments;
        private DevExpress.Xpo.Session session1;
        private DevExpress.Xpo.XPCollection xpCollectionResources;
        private DevExpress.Xpo.XPCollection xpCollectionDependences;
        private DevExpress.XtraScheduler.UI.ResourcesTree resourcesTree1;
        private DevExpress.XtraScheduler.Native.ResourceTreeColumn colName;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    }
}
