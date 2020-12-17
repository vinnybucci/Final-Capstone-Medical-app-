using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Office
    {
        public int OfficeId { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public List<Doctor> DocsInOffice { get; set; }
        public List<Review> OfficeReviews { get; set; }
        public WeekAvailability WeeklyHours { get; set; }
    }
}
