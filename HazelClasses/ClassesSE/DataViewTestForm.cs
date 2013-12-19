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
    public partial class DataViewTestForm : Form
    {
        public DataViewTestForm()
        {
            InitializeComponent();
        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loginBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hazelDatabaseDataSet);

        }

        private void DataViewTestForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hazelDatabaseDataSet.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.hazelDatabaseDataSet.login);

        }
    }
}
