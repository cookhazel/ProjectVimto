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
        public Medication()
        {
            InitializeComponent();
        }

        private void Medication_Load(object sender, EventArgs e)
        {

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
    }
}
