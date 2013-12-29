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
        private bool _allowSelectedItemEvent = true;
        public AppointmentUI()
        {
            InitializeComponent();
            PopulateAppointments();

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["hazelDatabaseConnectionString"].ConnectionString;
            using (DataContext dbContext = new DataContext(connectionString))
            {
                Table<Staff> staffAppointment = dbContext.GetTable<Staff>();

                var query =
                        from record in staffAppointment
                        //where staffAppointment // is available
                        select record;

                Staff[] staffArray = query.ToArray<Staff>();
                _doctorNurseDropDown.Items.AddRange(staffArray);
            }
            
        } // int year, int month, int day, int hour, int minute, int second

        private void PopulateAppointments()
        {
            _appointmentTimeDropDown.Items.Clear();
            // clear just in case there are any items already in the combo box
            //112 appointments in a week
            object[] weekAppointments = new object[112];
            int appointmentIndex = 0;

            //mpodify this to show the next 30 days of appointments
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

                    Staff currentlySelectedStaff = _doctorNurseDropDown.SelectedItem as Staff;

                    _doctorNurseDropDown.Items.Clear();
                    _doctorNurseDropDown.Items.AddRange(staffQuery.ToArray<Staff>());

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

                    DateTime currentlySelectedDate = (DateTime)(_appointmentTimeDropDown.SelectedItem);
                    PopulateAppointments();

                    foreach (Appointment app in appointmentQuery)
                    {
                        _appointmentTimeDropDown.Items.Remove(app.AppointmentDateTime);
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
//            this.appointmentBindingSource.EndEdit();
//            this.tableAdapterManager.UpdateAll(this.hazelDatabaseDataSet);

        }

        private void SubmitAppointment_Click(object sender, EventArgs e)
        {
            if (_appointmentTimeDropDown.SelectedItem != null)
            {
                MessageBox.Show("you have selected a time and date");
            }
            else
            {
                MessageBox.Show("Please select a time and date");
            }
            // on click, check both drop downs have been chosen, put this data into the databaase table appointment.
            if (_doctorNurseDropDown.SelectedItem != null)
            {
                MessageBox.Show("you have selected a doctor/nurse");
            }
            else
            {
                MessageBox.Show("You need to select a doctor!");
            }

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["hazelDatabaseConnectionString"].ConnectionString;
            using (DataContext dbContext = new DataContext(connectionString))
            {
                Table<Appointment> appointments = dbContext.GetTable<Appointment>();

                //construct an appointment
                Appointment newAppointment = new Appointment();
                newAppointment.AppointmentDateTime = (DateTime)(_appointmentTimeDropDown.SelectedItem);
                newAppointment.StaffID = ((Staff)(_doctorNurseDropDown.SelectedItem)).Id;
                appointments.InsertOnSubmit(newAppointment);
                dbContext.SubmitChanges();
            }  
        } // now appointment is made and we have the appointment ID, we can now pass in the appointment ID to the patient class, and the patient will
        // be added to the appointment where the appointment ID in patient form = appointment ID in db.
    }
}
