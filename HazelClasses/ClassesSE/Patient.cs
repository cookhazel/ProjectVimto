using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesSE
{
    class Patient
    {
        private int _patientID;
        private string _name;
        private DateTime _dob;
        private string _address;

        //constructor
        public Patient(string name, int patientID)
        {
            _name = name;
            _patientID = patientID;
        }
    }
}
