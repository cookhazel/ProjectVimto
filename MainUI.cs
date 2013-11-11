using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//may need IO?

namespace WindowsFormsApplication1 //may have problems with this need to make sure that the names all work together?
{
    public partial class mainUI : Form
    {
        public mainUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
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

        private void submitButton_Click(object sender, EventArgs e)
        {
            //databaseMethod(textBox1.Text, textbox2.Text ect ect);
        }
    }
}
