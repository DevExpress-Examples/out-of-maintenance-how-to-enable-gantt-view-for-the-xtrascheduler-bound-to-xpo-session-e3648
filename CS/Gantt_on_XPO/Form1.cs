using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraScheduler;

namespace WindowsFormsApplication9 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            this.schedulerControl1.Start = DateTime.Today;
            InitData();
        }

        void InitData() {
            string[] resources = new string[5] { "r1", "r2", "r3", "r4", "r5" };
            if (xpCollectionResources.Count <= 0) {
                for (int i = 0; i < 5; i++) {
                        AddResource(resources[i]);
                }
            }        
        }
        void AddResource(string name) {
            XPOResource res = new XPOResource(session1);
            res.Name = name;
            if (xpCollectionResources.Count > 0)
                res.ParentResource = (XPOResource)xpCollectionResources[0];
            xpCollectionResources.Add(res);            
            res.Save();
        }
        #region #appointmentschanges
        private void schedulerStorage1_AppointmentsChanged(object sender, PersistentObjectsEventArgs e) {
            foreach (Appointment apt in e.Objects) {
                XPOAppointment xpObject = apt.GetSourceObject(schedulerStorage1) as XPOAppointment;
                if (xpObject != null) {
                    xpObject.Save();
                    schedulerStorage1.SetAppointmentId(apt, xpObject.Oid);
                }
            }
        }
        #endregion #appointmentschanged
        #region #appointmentdependencieschanged
        private void schedulerStorage1_AppointmentDependenciesChanged(object sender, PersistentObjectsEventArgs e) {
            foreach (AppointmentDependency dependency in e.Objects) {
                XPBaseObject xpObject = dependency.GetSourceObject(schedulerStorage1) as XPBaseObject;
                if (xpObject != null)
                    xpObject.Save();
            }
        }
        #endregion #appointmentdependencieschanged

    }

    #region xpobjects
    // XP object
    public class XPOAppointment : XPObject {
        public XPOAppointment(Session session) : base(session) { }
        public bool AllDay;              // Appointment.AllDay

        [Size(SizeAttribute.Unlimited)]  // !!! To set the Memo field type.
        public string Description;       // Appointment.Description

        public DateTime Finish;          // Appointment.End
        public int Label;                // Appointment.Label
        public string Location;          // Appointment.Location

        [Size(SizeAttribute.Unlimited)]  // !!! To set the Memo field type.
        public string Recurrence;        // Appointment.RecurrenceInfo

        [Size(SizeAttribute.Unlimited)]  // !!! To set the Memo field type.
        public string Reminder;          // Appointment.ReminderInfo

        public DateTime Created;         // Appointment.Start
        public int Status;               // Appointment.Status
        public string Subject;           // Appointment.Subject
        public int AppointmentType;      // Appointment.Type

        public XPOResource Resource;
        public int PercentComplete;
    }

    // XP object
    public class XPOResource : XPObject {
        public XPOResource(Session session) : base(session) { }

        [Size(SizeAttribute.Unlimited)]  // !!! To set the Memo field type.
        public string Name;              // Resource.Caption
        public XPOResource ParentResource;
    }
    // XP object
    public class XPODependency : XPObject {
        public XPODependency(Session session) : base(session) { }

        public XPOAppointment ParentApt;
        public XPOAppointment DependentApt;

        public int Type;
    }
    #endregion #xpobjects
}