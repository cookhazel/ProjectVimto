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
    public partial class TimeTableAdmin : Form
    {
        public TimeTableAdmin()
        {
            InitializeComponent();
        }

        private void timeTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.timeTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.timetableDataSet);

        }

        private void TimeTableAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timetableDataSet.TimeTable' table. You can move, or remove it, as needed.
            this.timeTableTableAdapter.Fill(this.timetableDataSet.TimeTable);

        }

        private void timeTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
