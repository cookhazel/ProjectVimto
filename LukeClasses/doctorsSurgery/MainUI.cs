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
            userControl(tabs.SelectedTab); 
            tabs.Selecting += new TabControlCancelEventHandler(tabs_Selecting);
        }

        private void MainUI_Load(object sender, EventArgs e)
        {

        }

        public void tabs_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabPage current = (sender as TabControl).SelectedTab;
            userControl(tabs.SelectedTab); 
        }

        protected void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void userControl(TabPage tabpage_NO)
        {
            tabpage_NO.Controls.Add(panel1);
        }

        private void btBack_Click(object sender, EventArgs e)
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

        private void btSubmit_Click(object sender, EventArgs e)
        {
            //databaseMethod(textBox1.Text, textbox2.Text ect ect);
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Administration update1 = new Administration();
        //    update1.databaseFill();
        //}
    }
}
