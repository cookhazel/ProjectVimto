using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace doctorsSurgery
{
    class Administration
    {
        public void databaseFill()
        {
            maxPatientInt();
            
            string waveData;
            int ID;
            List<string> title = new List<string>();
            List<string> firstName = new List<string>();
            List<string> lastName = new List<string>();
            List<string> postCode = new List<string>();
            List<string> town = new List<string>();
            List<string> county = new List<string>();
            List<DateTime> DOB = new List<DateTime>();

            string fileLocation = "D:/Documents/Uni/Year 2/Software Engineering/my work/Database Data.csv";  
            StreamReader waveFile = new StreamReader(fileLocation);
            string dropHeadder = waveFile.ReadLine();//drops the header of the csv files
               
            while (waveFile.EndOfStream == false)//loops until it reaches the last entry of the csv file   
            {     
                waveData = waveFile.ReadLine();     
                
               
                //ID.Add(

                
                title.Add(Convert.ToString(waveData.Split(',')[0]));//splits the rows and takes the first column   
                foreach (var T in title)   
                {
                    databaseUpdate(T.ToString(), "Title");
                }               
                
                firstName.Add(Convert.ToString(waveData.Split(',')[1]));           
                foreach (var F in firstName)         
                {
                    databaseUpdate(F.ToString(), "First Name");
                }   
           
            }
            MessageBox.Show("Database Successfully Updates");
            waveFile.Close();//allows the streamReader to read another file      
        }
        static void databaseUpdate(string value, string column)
        {
            SqlConnection connection = new SqlConnection(doctorsSurgery.Properties.Settings.Default.Database1ConnectionString);
            SqlCommand cmd = new SqlCommand();
            connection.Open();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE INTO Data (" + column + ") VALUES (@" + value + ")";
            cmd.Parameters.AddWithValue("@" + column, value);
            cmd.ExecuteNonQuery();
        }
        private int maxPatientInt()
        {
            
            SqlParameter maxID = new SqlParameter();
            SqlConnection connection = new SqlConnection(doctorsSurgery.Properties.Settings.Default.Database1ConnectionString);
            SqlCommand cmd = new SqlCommand();
            
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT(ID) FROM dbo.Patient_DB";
            
            maxID.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(maxID);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            
            


                MessageBox.Show(maxID.ToString());
            
            return Convert.ToInt32(maxID);

            
            
        }
    }

              

}
