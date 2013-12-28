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
        public AppointmentUI()
        {
            InitializeComponent();
            
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

            //object[] _appointmentTimeSlots = new object[]
            //{
            //    new DateTime(2012, 08, 28, 1, 12, 30, 0),
            //    new DateTime(2013, 09, 16, 2, 14, 0, 0)
            //    //from urrent day onwards, add in times for each of those days
            //};

            _appointmentTimeDropDown.Items.AddRange(weekAppointments);
            //_appointmentTimeDropDown.

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


        

        private void _appointmentDateTime_SelectedIndexChanged(object sender, EventArgs e)
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

                _doctorNurseDropDown.Items.Clear();
                _doctorNurseDropDown.Items.AddRange(staffQuery.ToArray<Staff>());
            }
        }

        private void appointmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
//            this.appointmentBindingSource.EndEdit();
//            this.tableAdapterManager.UpdateAll(this.hazelDatabaseDataSet);

        }

        private void submitAppointment_Click(object sender, EventArgs e)
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
            if (_doctorNurseDropDown != null)
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
        }
    }
}
