using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesSE
{
    class Appointment
    {
        private DateTime _appointmentDate;
        private Staff _staff;
        private Patient _patient;

        //constructor
        public Appointment(Staff staff, Patient patient, DateTime appointmentDate)
        {
            _staff = staff;
            _patient = patient;
            _appointmentDate = appointmentDate;
        }

        public void StoreAppointment()
        {

        }
        public string RequestAppointmentDetails()
        {
            return null;
        }
        public bool ChangeAppointment()
        {
            return false;
        }
        public bool CancelAppointment()
        {
            return false;
        }
    }
}
