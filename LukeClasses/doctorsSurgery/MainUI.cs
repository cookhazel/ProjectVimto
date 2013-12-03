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
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            
        }

        public void OnTabIndexChanged(object sender, EventArgs e)
        {
            tabPage2.Controls.Add(panel1);
        }

        public void btBack_Click_Click(object sender, EventArgs e)
        {
            /* --Back Button. Also used when opening up new forms--
             * 
             * FormX object1 = new FormX();  //replace FormX with the form you wish to open
             * FormX.RefTo(Current) = this;  //replace (Current) with the form that you are on
             * FormX.Show();                 //starts FormX
             * this.Close();                 //closes the current form
             * 
             */
        }

        public void btSubmit_click_Click(object sender, EventArgs e)
        {
            //databaseMethod(textBox1.Text, textbox2.Text ect ect);
            
        }

        protected void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainUI_Load(object sender, EventArgs e)
        {

        }



        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Administration update1 = new Administration();
        //    update1.databaseFill();
        //}
    }
}
