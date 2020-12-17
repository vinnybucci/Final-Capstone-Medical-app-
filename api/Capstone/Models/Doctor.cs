using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Doctor
    {
        public int UserId { get; set; }
        public decimal HourlyRate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string User_Role { get; set; }
        public WeekAvailability WeeklyHours { get; set; } = new WeekAvailability();
    }
}
