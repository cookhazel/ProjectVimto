using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace doctorsSurgery
{
    class Administration
    {
        public void databaseFill()
        {
            string waveData;
            List<string> title = new List<string>();
            List<string> firstName = new List<string>();

            string fileLocation = "D:/Documents/Uni/Year 2/Software Engineering/my work/Database Data.csv";  
            StreamReader waveFile = new StreamReader(fileLocation);
            string dropHeadder = waveFile.ReadLine();//drops the header of the csv files
               
            while (waveFile.EndOfStream == false)//loops until it reaches the last entry of the csv file   
            {     
                waveData = waveFile.ReadLine();     
                
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
            waveFile.Close();//allows the streamReader to read another file      
        }
        static void databaseUpdate(string value, string column)
        {
            string connectionString = "D:/Documents/Uni/Year 2/Software Engineering/my work/doctorsSurgery/doctorsSurgery/Database1.mdf";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE INTO Data (" + column + ") VALUES (@" + value + ")";
            cmd.Parameters.AddWithValue("@"+column, value);
            cmd.ExecuteNonQuery();
        }
    }

}
