using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public interface IReviewDAO
    {
        List<Review> GetOfficeReviews(int officeId); //TODO change return datatype when adding Review class, move to reviewDAO
        Review PostNewReview(Review review); //TODO move to reviewDAO            Add Review Datatype
    }
}
