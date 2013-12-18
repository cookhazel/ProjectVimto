using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doctorsSurgery
{
    public partial class Home : MainUI
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timetableDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.timetableDataSet.Staff);
            // TODO: This line of code loads data into the 'timetableDataSet.TimeTable' table. You can move, or remove it, as needed.
            this.timeTableTableAdapter.Fill(this.timetableDataSet.TimeTable);
            //dataGridView1.BackgroundColor = Color.LightBlue;
            
            
        }

        private void staffTimetable_Click(object sender, EventArgs e)
        {

        }

       

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void medication_DBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.Rows[0].Cells[0].Style.BackColor = Color.Red;
            //dataGridView1.Rows[0].Cells[0](object sender, EventArgs e)
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Administration update = new Administration();
            update.databaseFill();
            PatientAdministration x = new PatientAdministration();
            x.Show();
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void timeTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}                   
