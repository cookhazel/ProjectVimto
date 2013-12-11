using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PatientForm
{
    
    public partial class FormFindPatient : Form
    {
        public class patient
        {
            public string patientID;
            public string name;
            public string DOB;
            public string address;
        }
        public FormFindPatient()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        { 
      
            patient patient1 = new patient();
            Convert.ToString(txtpatientID);
            patient1.patientID = txtpatientID.Text;

            Convert.ToString(txtname);
            patient1.name = txtname.Text;

            patient1.DOB = string.Format("{0:dd/mm/yyyy}", DTdob.Value.ToShortDateString());
             

            Convert.ToString(txtaddress); 
            patient1.address = txtaddress.Text;

            

            MessageBox.Show("Here is what you have entered: " + patient1.patientID + " " + patient1.name + " " + patient1.address + " " + patient1.DOB);
        }

        private void txtpatientID_TextChanged(object sender, EventArgs e)
        {
            txtname.Enabled = false;
            DTdob.Enabled = false;
            txtaddress.Enabled = false;

            if (txtpatientID.Text == string.Empty)
            {
                txtname.Enabled = true;
                DTdob.Enabled = true;
                txtaddress.Enabled = true;
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            txtpatientID.Enabled = false;
            lbl.Text = "Date of Birth OR Address also required";
            if (txtname.Text == string.Empty)
            {
                lbl.Text = "";
                txtpatientID.Enabled = true;
            }
        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {
            DTdob.Enabled = false;
            txtpatientID.Enabled = false;
            if (txtaddress.Text == string.Empty)
            {
                DTdob.Enabled = true;
                txtpatientID.Enabled = true;
            }
        }

        private void DTdob_ValueChanged(object sender, EventArgs e)
        {
            
           
        }
    }
    

}