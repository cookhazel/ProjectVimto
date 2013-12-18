using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doctorsSurgery
{
    class Staff
    {
        //attributes
        private string name, staffID;
        private DateTime duty;
        private bool isGP;

        //properties
        public string Name
        {
            get{ return name; }
            set { name = value; }
        }

        public string StaffID
        {
            get{ return staffID; }
            set { staffID = value; }
        }

        public DateTime Duty
        {
            get{ return duty; }
            set { duty = value; }
        }
        
        public string GP
        {
            get { return isGP.ToString(); }
            set { isGP = Convert.ToBoolean(value); }
        }

        //constructors


        //methods
        public Int32 checkAvalibility()
        {
            TimetableDataSetTableAdapters.TimeTableTableAdapter tableAdapter;
            tableAdapter = new TimetableDataSetTableAdapters.TimeTableTableAdapter();
            tableAdapter.GetData();

            //go to database to get avalible days
            //go to database to get avalible times
            //go to database to get on duty info
            MessageBox.Show("CheckAvalibility");
            return 0;
        }
    }
}
