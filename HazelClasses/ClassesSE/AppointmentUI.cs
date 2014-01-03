using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace ClassesSE
{
    public partial class AppointmentUI : Form
    {
        // have set _allowSelectedItemEvent to a boolean, so that when the combo boxes are deleted and repopulated, the selectedIndexChanged method is
        // not always allowing the method to perform. Without this, there are a number of bugs.
        private bool _allowSelectedItemEvent = true;
        public AppointmentUI()
        {
            InitializeComponent();
            this.CenterToScreen();
            PopulateAppointments();

            //starting a connection with a database using a  dataContext, in order to perform queries using Linq to SQL.
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["hazelDatabaseConnectionString"].ConnectionString;
            // Because DataContext implements IEDisposable, am using a 'using' so the connection is disposed of when complete. 
            using (DataContext dbContext = new DataContext(connectionString))
            {
                Table<Staff> staffAppointment = dbContext.GetTable<Staff>();

                var query =
                        from record in staffAppointment
                        select record;

                Staff[] staffArray = query.ToArray<Staff>();
                _doctorNurseDropDown.Items.AddRange(staffArray);
            }
            
        } 

        private void PopulateAppointments()
        {
            _appointmentTimeDropDown.Items.Clear();
            // clear just in case there are any items already in the combo box

            //112 appointments in a week
            object[] weekAppointments = new object[112];
            int appointmentIndex = 0;

            //looping through all appointments per day.
            for (int i = 0; i < 7; ++i)
            {
                int day = 9 + i;
                for (int j = 0; j < 8; ++j)
                {
                    weekAppointments[appointmentIndex++] = new DateTime(2013, 12, day, j + 9, 0, 0);
                    weekAppointments[appointmentIndex++] = new DateTime(2013, 12, day, j + 9, 30, 0);
                }
            }

            _appointmentTimeDropDown.Items.AddRange(weekAppointments);
        }
        

        private void _appointmentDateTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if the boolean is true, then perform the functions in the method
            if (_allowSelectedItemEvent)
            {
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["hazelDatabaseConnectionString"].ConnectionString;
                using (DataContext dbContext = new DataContext(connectionString))
                {
                    Table<Appointment> appointments = dbContext.GetTable<Appointment>();

                    var appointmentQuery =
                        from record in appointments
                        where (DateTime)_appointmentTimeDropDown.SelectedItem == record.AppointmentDateTime
                        select record;


                    Table<Staff> staffs = dbContext.GetTable<Staff>();
                    var staffQuery = staffs.Where<Staff>(s => !appointmentQuery.Any<Appointment>(a => a.StaffID == s.Id));
                    // select staff, where app query does not contain any appointments that have that staff id
                    //only select staff where there are no appointments matching their id.

                    Staff currentlySelectedStaff = _doctorNurseDropDown.SelectedItem as Staff;
                    // casting the drop down item as a type Staff

                    //clearing the drop down list to repopulate with available staff.
                    _doctorNurseDropDown.Items.Clear();
                    _doctorNurseDropDown.Items.AddRange(staffQuery.ToArray<Staff>());

                    //check to see if there is something selected, if there is then disable the selectedIndexChanged method and when the
                    //combo box is cleared and re-populated, the selected item will be set back to what there was before. If it is null then
                    //nothing extra needs to be performed and the selectedItemEvent will be set to true.
                    if (currentlySelectedStaff != null)
                    {
                        foreach (Staff s in _doctorNurseDropDown.Items)
                        {
                            if (currentlySelectedStaff.Id == s.Id)
                            {
                                _allowSelectedItemEvent = false;
                                _doctorNurseDropDown.SelectedItem = s;
                            }
                        }
                    }
                }
            }
            else
            {
                _allowSelectedItemEvent = true;
            }
        }

        private void _doctorNurseDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if the boolean is true, then perform the functions below.
            if (_allowSelectedItemEvent)
            {
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["hazelDatabaseConnectionString"].ConnectionString;
                using (DataContext dbContext = new DataContext(connectionString))
                {
                    Table<Appointment> appointments = dbContext.GetTable<Appointment>();

                    var appointmentQuery =
                        from record in appointments
                        where ((Staff)_doctorNurseDropDown.SelectedItem).Id == record.StaffID
                        select record;

                    //DateTime? is an alias for Nullable<DateTime>, which allows non-nullable types to hold null
                    DateTime? currentlySelectedDate = _appointmentTimeDropDown.SelectedItem as DateTime?;
                    //casting _appointmentTimeDropDown.SelectedItem to a type of DateTime
                    PopulateAppointments();
                    //calling Populate Appointments Method.

                    foreach (Appointment app in appointmentQuery)
                    {
                        _appointmentTimeDropDown.Items.Remove(app.AppointmentDateTime);
                        //remove the appointments found from the query, as these are the ones that are booked.
                    }
                    if (currentlySelectedDate != null)
                    {
                        foreach (DateTime d in _appointmentTimeDropDown.Items)
                        {
                            if (currentlySelectedDate == d)
                            {
                                _allowSelectedItemEvent = false;
                                _appointmentTimeDropDown.SelectedItem = d;
                            }
                        }
                    } 
                }
            }
            else
            {
                _allowSelectedItemEvent = true;
            }
        }


        private void appointmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void SubmitAppointment_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["hazelDatabaseConnectionString"].ConnectionString;
            using (DataContext dbContext = new DataContext(connectionString))
            {
                Table<Appointment> appointments = dbContext.GetTable<Appointment>();
                // try catch to handle the NullReference Exception that occurs when a combo box is empty.
                try
                {
                    //construct an appointment
                    Appointment newAppointment = new Appointment();
                    newAppointment.AppointmentDateTime = (DateTime)(_appointmentTimeDropDown.SelectedItem);
                    newAppointment.StaffID = ((Staff)(_doctorNurseDropDown.SelectedItem)).Id;
                    appointments.InsertOnSubmit(newAppointment);
                    dbContext.SubmitChanges();
                    MessageBox.Show("Appointment has been booked");
                    PopulateAppointments();
                    _appointmentTimeDropDown.SelectedItem = null;
                }
                catch (Exception NullE)
                {
                    MessageBox.Show("Please select values");
                }
            }  
        }

        private void _cancelAppointment_Click(object sender, EventArgs e)
        {
            // when this form is closed, it does not close the whole application.
            cancelAppointment cancel = new cancelAppointment();
            cancel.Show();
        } 

        // now appointment is made and we have the appointment ID, we can now pass in the appointment ID to the patient class, and the patient will
        // be added to the appointment where the appointment ID in patient form = appointment ID in db.
    }
}
