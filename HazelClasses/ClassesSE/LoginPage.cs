using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesSE
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            //focus on username text box so when the form loads, it is automatically set to be able to type into the username box
            usernameTextBox.Focus();
            //replace with CenterToParent when LoginPage is instantiated from a main form
            this.CenterToScreen();
        }

        private void loginPage_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["hazelDatabaseConnectionString"].ConnectionString;
                using (DataContext dbContext = new DataContext(connectionString))
                {
                    Table<login> loginRecords = dbContext.GetTable<login>();
                    //query to check the username and password exist and the password entered matches the associated username.
                    var query =
                        from record in loginRecords
                        where (record.Username == usernameTextBox.Text) && (record.Password == passwordTextBox.Text)
                        select record;

                    //MessageBox.Show(query.ToString());

                    //Calling ToList will return DB results. This is "Deferred Execution"
                    //List<login> list = query.ToList<login>();

                    if (query.Count<login>() == 1)
                    {
                        AppointmentUI appointmentPage = new AppointmentUI();  
                        //when the appointmentPage is closed, it closes the whole application.
                        appointmentPage.FormClosed += (closingForm, eventArgs) => this.Close();
                        appointmentPage.Show();

                        this.Hide();
                    }
                    else
                    {
                        //there was either 0 or more than 1 found
                        MessageBox.Show("Incorrect, please enter a valid username/password");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while logging in, please try again");
            }
            
            //For some reason, the .mdf cannot be accessed directly. This may be what
            //causes dbContext.DatabaseExists() to return false, even though queries work.
            //DataContext using reference to Data.Linq above.
  
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //13 is the character code assocaited with the enter key.
            if (e.KeyChar == 13)
            {
                _loginButton.PerformClick();
            }
        }

    }
}
