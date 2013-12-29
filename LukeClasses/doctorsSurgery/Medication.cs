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
    public partial class Medication : MainUI
    {
        //MedicationDatasetTableAdapters.Medication_DBTableAdapter tableAdapter;
        public Medication()
        {
            InitializeComponent();
            //tableAdapter = new MedicationDatasetTableAdapters.Medication_DBTableAdapter();
        }

        private void Medication_Load(object sender, EventArgs e)
        {
           // MedicationDataset.Medication_DBDataTable mtable = tableAdapter.GetData_1();
            
        }

        private void isExtendibleTextBox_TextChanged(object sender, EventArgs e)
        {
            //run isExtendable
            //if isExtendable returns true
            //set testbox.text=extendable
            //set textbox.colour = green
            //dateTimePicker.visible == true
            //else
            //set textbox.text = not extendable
            //set textbox.colour = red
            
        }

        private void MedicationList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void isExtendable()
        {
            //dataset 
            //MedicationList.SelectedIndex
            //get isestendible bool
            //return bool
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //dataset
            //get max extend
            //set dateTimePicker
            //dateTimePicker.MinDate = DateTime.Today + (Convert.ToDateTime("01/00/0000"));
            //dateTimePicker.MaxDate = max extend from dataset
            //if dateTimePicer selected
            //    set submit button.Enabled
        }

        private void Medication_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicationDataset.Medication_DB' table. You can move, or remove it, as needed.
            //this.medication_DBTableAdapter.Fill(this.medicationDataset.Medication_DB);

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void medicationLabel_Click(object sender, EventArgs e)
        {

        }

        private void medicationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
