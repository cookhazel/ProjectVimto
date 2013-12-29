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
        public TabPage current;
        public MainUI()
        {
            InitializeComponent();
            userControl(tabs.SelectedTab); //moves the panel at the bottom so that it is always at the bottom
            tabs.Selecting += new TabControlCancelEventHandler(tabs_Selecting); 
        }

        private void MainUI_Load(object sender, EventArgs e)
        {

        }

        public void tabs_Selecting(object sender, TabControlCancelEventArgs e)
        {
            current = (sender as TabControl).SelectedTab; //changes the name of current every time you click on a tab
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
            //removes the close button from the home tab so that it cant be closed
            if (current == null || current.Name == "tabPage1") 
            {
                Close.Visible = false;
            }
            else
            {
                Close.Visible = true;
            }
        }

        public virtual void btBack_Click(object sender, EventArgs e)
        {
            
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            //*DATASETNAME*TableAdapters.*TABLENAME*TableAdapter *VARIABLE*;
            //*VARIABLE* = new *DATASETNAME*TableAdapters.*TABLENAME*TableAdapter();
            //*VARIABLE*.*QUERY*;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            string tabPage;
            tabPage = current.Name; //current is used up the top. this gives the name of the currently selected tab
            tabs.TabPages.Remove(current); //closes the currently selected tab
        }

        public virtual void NewTab_Click(object sender, EventArgs e)
        {
            string tabPage;
            tabPage = current.Name;
            //tabs.TabPages.Add(/*TAB*/);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabs.TabPages.Add(tabPage2);
            tabs.SelectedTab = tabs.TabPages["tabPage2"];
            MessageBox.Show(tabs.ToString());
        }
    }
}
