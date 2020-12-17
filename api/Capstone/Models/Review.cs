using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int OfficeId { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }
        public int Rating { get; set; }
        //bit in sql bool here? 
        public bool Anonymous { get; set; }

        // Review Responses 
        public int ResponseId { get; set; }
        //reviewId, userId, message in the table 
        public string ResponseMessage { get; set; }
    }
}
