using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
        } // int year, int month, int day, int hour, int minute, int second


        private void _appointmentDateTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void appointmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
//            this.appointmentBindingSource.EndEdit();
//            this.tableAdapterManager.UpdateAll(this.hazelDatabaseDataSet);

        }
    }
}
