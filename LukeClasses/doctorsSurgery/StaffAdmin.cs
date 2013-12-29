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
    public partial class StaffAdmin : Form
    {
        public StaffAdmin()
        {
            InitializeComponent();
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.staffDataset);

        }

        private void StaffAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staffDataset.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.staffDataset.Staff);

        }

        private void staffDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
