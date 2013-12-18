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
    public partial class PatientAdministration : Form
    {
        public PatientAdministration()
        {
            InitializeComponent();
        }

        private void patient_DBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.patient_DBBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.patientDataset);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            } 

        }

        private void PatientAdministration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientDataset.Patient_DB' table. You can move, or remove it, as needed.
            this.patient_DBTableAdapter.Fill(this.patientDataset.Patient_DB);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Administration update = new Administration();
            update.databaseFill();
            patient_DBDataGridView.Refresh();
        }

        private void patient_DBDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
