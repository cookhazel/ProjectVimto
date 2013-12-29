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
            TimetableDataSetTableAdapters.StaffTableAdapter times;
            times = new TimetableDataSetTableAdapters.StaffTableAdapter();
            TimetableDataSet.StaffDataTable t = new TimetableDataSet.StaffDataTable();
            times.TimeTableFill(t);
            dataGridView1.DataSource = t;           
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        //using a dataset
        //{
            //TimetableDataSetTableAdapters.TimeTableTableAdapter times;
            //times = new TimetableDataSetTableAdapters.TimeTableTableAdapter();
            //TimetableDataSet.TimeTableDataTable t = new TimetableDataSet.TimeTableDataTable();
            //times.FillTimeTable(t);
            //dataGridView1.DataSource = t;     
        //}

        private void timeTableFillToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                
           tabs.SelectedTab = tabs.TabPages["tabPage2"];
           MessageBox.Show(tabs.ToString());
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}                   
