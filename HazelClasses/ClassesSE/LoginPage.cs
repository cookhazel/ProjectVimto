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

                    var query =
                        from record in loginRecords
                        where (record.Username == usernameTextBox.Text) && (record.Password == passwordTextBox.Text)
                        select record;

                    //IQueryable<login> sameQuery = loginRecords.Where(l => l.Username == "Reception").Single<login>();

                    //Calling ToList will return DB results. This is "Deferred Execution"
                    //List<login> list = query.ToList<login>();

                    if (query.Count<login>() == 1)
                    {
                        //var passwordQuery =
                        //    from record in loginRecords
                        //    where record.Password == passwordTextBox.Text
                        //    select record;
                        //need to check that the password is not only exists in the db, but is the one that matches the password 
                        //check the password
                        //Application.Run(new AppointmentUI());
                        new AppointmentUI().Show();
                        this.Hide();

                    }
                    else
                    {
                        //there was either 0 or more than 1 found
                        MessageBox.Show("Incorrect, please enter a valid username/password");
                    }
                }
                //MessageBox.Show(query.ToString());
              
                //check against database
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while logging in, please try again");
            }

            //string databaseLocation = "C:\path\to\database\database.mdf";
            //DataContext dbContext= new DataContext(databaseLocation);
            //Above does not connect to database properly, but it should. Don't know why!
            
            //For some reason, the .mdf cannot be accessed directly as above. This may be what
            //causes dbContext.DatabaseExists() to return false, even though queries work.
            //DataContext using reference to Data.Linq above.
            

           // foreach (var record in query)
             //   MessageBox.Show(record.Password);

        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                _loginButton.PerformClick();
            }
        }

    }
}
