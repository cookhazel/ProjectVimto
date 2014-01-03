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
    public partial class cancelAppointment : Form
    {
        public cancelAppointment()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void appointmentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.appointmentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hazelDatabaseDataSet);
        }

        private void cancelAppointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hazelDatabaseDataSet.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.hazelDatabaseDataSet.Appointment);
            // setting the ID and appointmentDate and Time columns to specific lengths.
            DataGridViewColumn column = appointmentDataGridView.Columns[1];
            column.Width = 180;
            DataGridViewColumn iDColumn = appointmentDataGridView.Columns[0];
            iDColumn.Width = 50;

            //the functionality for the user to type in data has been disabled in the properties of the form.
        }
    }
}
