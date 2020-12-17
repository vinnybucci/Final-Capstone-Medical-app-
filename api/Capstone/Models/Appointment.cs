using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public int OfficeId { get; set; }
        public DateTime Date { get; set; } //Maybe?
        public TimeSpan Time { get; set; } //Maybe?
        public string Message { get; set; }
        public bool Virtual { get; set; } //can send 'true/false', will read as '0/1' in db
        public string Status { get; set; }

        //Info for the doctor
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string PatientPhone { get; set; }
        public string PatientEmail { get; set; }
        public DateTime PatientDoB { get; set; }

        //Info for the patient
        public string OfficeName { get; set; }
        public string DoctorFirstName { get; set; }
        public string DoctorLastName { get; set; }
    }
}
