using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace doctorsSurgery
{
    class Administration
    {
        public void databaseFill_Patient()
        {
            string fileLocation = "D:/Documents/Uni/Year 2/Software Engineering/my work/Database Data.csv";
            //location of the file to import the data into the database
            string externalData; //a holder for the data that is read in from the stream reader
            string title, firstname, lastname, postcode, address, town, county, dob;
            StreamReader externalFile = new StreamReader(fileLocation);
            string dropHeadder = externalFile.ReadLine();//drops the header of the csv files
int i=0;
            while (externalFile.EndOfStream == false)//loops until it reaches the last entry of the csv file   
            {
                
                externalData = externalFile.ReadLine();
                title = Convert.ToString(externalData.Split(',')[0]);
                firstname = Convert.ToString(externalData.Split(',')[1]);
                lastname = Convert.ToString(externalData.Split(',')[2]);
                postcode = Convert.ToString(externalData.Split(',')[3]);
                address = Convert.ToString(externalData.Split(',')[4]);
                town = Convert.ToString(externalData.Split(',')[5]);
                county = Convert.ToString(externalData.Split(',')[6]);
                dob = Convert.ToString(externalData.Split(',')[7]);
                if (i == 100)
                {
                    MessageBox.Show(title + firstname + lastname + postcode + address + town + county + dob);
                }
                databaseUpdate_Patient(title, firstname, lastname, postcode, address, town, county, dob, i);

                i++;
            }

                MessageBox.Show("Update successful");

            externalFile.Close();//stops the streamReader
        }

        public void databaseFill_Staff()
        {
            string fileLocation = "D:/Documents/Uni/Year 2/Software Engineering/my work/Database Data(Staff).csv";
            //location of the file to import the data into the database
            string externalData; //a holder for the data that is read in from the stream reader
            string title, firstname, lastname, postcode, address, town, county;
            StreamReader externalFile = new StreamReader(fileLocation);
            string dropHeadder = externalFile.ReadLine();//drops the header of the csv files
            
            while (externalFile.EndOfStream == false)//loops until it reaches the last entry of the csv file   
            {

                externalData = externalFile.ReadLine();
                title = Convert.ToString(externalData.Split(',')[0]);
                firstname = Convert.ToString(externalData.Split(',')[1]);
                lastname = Convert.ToString(externalData.Split(',')[2]);
                postcode = Convert.ToString(externalData.Split(',')[3]);
                address = Convert.ToString(externalData.Split(',')[4]);
                town = Convert.ToString(externalData.Split(',')[5]);
                county = Convert.ToString(externalData.Split(',')[6]);
              
                databaseUpdate_Staff(title, firstname, lastname, postcode, address, town, county);
            }

        }

        public void databaseFill_TimeTable()
        {
            string fileLocation = "D:/Documents/Uni/Year 2/Software Engineering/my work/TimeTable.csv";
            //location of the file to import the data into the database
            string externalData; //a holder for the data that is read in from the stream reader
            int ID;
            string monday, tuesday, wednesday, thursday, friday, saturday, sunday;
            StreamReader externalFile = new StreamReader(fileLocation);
            string dropHeadder = externalFile.ReadLine();//drops the header of the csv files
            
            while (externalFile.EndOfStream == false)//loops until it reaches the last entry of the csv file   
            {

                externalData = externalFile.ReadLine();
                ID = Convert.ToInt32(externalData.Split(',')[0]);
                monday = Convert.ToString(externalData.Split(',')[1]);
                tuesday = Convert.ToString(externalData.Split(',')[2]);
                wednesday = Convert.ToString(externalData.Split(',')[3]);
                thursday = Convert.ToString(externalData.Split(',')[4]);
                friday = Convert.ToString(externalData.Split(',')[5]);
                saturday = Convert.ToString(externalData.Split(',')[6]);
                sunday = Convert.ToString(externalData.Split(',')[7]);

                databaseUpdate_TimeTable(ID, monday, tuesday, wednesday, thursday, friday, saturday, sunday);
            }
            
        }

        private void databaseUpdate_Patient(string title, string firstname, string lastname, string postcode, string address, string town, string county, string dob, int i)
        {
            PatientDatasetTableAdapters.Patient_DBTableAdapter tableAdapter;
            tableAdapter = new PatientDatasetTableAdapters.Patient_DBTableAdapter();
            tableAdapter.AdmiFill(title,firstname,lastname,postcode,address,town,county,dob);

            
            if (i == 100)
            {
               // PatientDataset.Patient_DBDataTable x = tableAdapter.GetData();
               // MessageBox.Show(x.DOBColumn.ToString());
            }

        }

        private void databaseUpdate_Staff(string title, string firstname, string lastname, string postcode, string address, string town, string county)
        {
            StaffDatasetTableAdapters.StaffTableAdapter tableAdapter;
            tableAdapter = new StaffDatasetTableAdapters.StaffTableAdapter();
            tableAdapter.Staff_TableFill(title, firstname, lastname, postcode, address, town, county);
        }

        private void databaseUpdate_TimeTable(int ID, string monday, string tuesday, string wednesday, string thursday, string friday, string saturday, string sunday)
        {
            TimetableDataSetTableAdapters.TimeTableTableAdapter tableAdapter;
            tableAdapter = new TimetableDataSetTableAdapters.TimeTableTableAdapter();
            tableAdapter.InsertQuery(ID, monday, tuesday, wednesday, thursday, friday, saturday, sunday);

        }

    }
}

              


