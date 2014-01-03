using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenuUI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public void btnPatient_Click(object sender, EventArgs e)
        {
            // Takes you to find patient form, which I'm in the process of doing
            PatientForm.FormFindPatient.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Log in form comes up here
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelChangeApp_Click(object sender, EventArgs e)
        {
// takes user to appoinment form so appointments can be changed or deleted
        }
    }
}
