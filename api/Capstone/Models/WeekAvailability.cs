using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class WeekAvailability
    {
        public DayAvailability Monday { get; set; } = new DayAvailability();
        public DayAvailability Tuesday { get; set; } = new DayAvailability();
        public DayAvailability Wednesday { get; set; } = new DayAvailability();
        public DayAvailability Thursday { get; set; } = new DayAvailability();
        public DayAvailability Friday { get; set; } = new DayAvailability();
        public DayAvailability Saturday { get; set; } = new DayAvailability();
        public DayAvailability Sunday { get; set; } = new DayAvailability();
    }
}
