using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class DayAvailability
    {
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }
        public Office OfficeOfDay { get; set; } = new Office();
    }
}
