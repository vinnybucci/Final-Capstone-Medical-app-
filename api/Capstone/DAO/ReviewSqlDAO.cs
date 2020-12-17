using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class ReviewSqlDAO :IReviewDAO
    {
        private readonly string connectionString;

        public ReviewSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

       

        public List<Review> GetOfficeReviews(int officeId)
        {
            try
            {
                List<Review> officeReviews = new List<Review>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"select reviewId, officeId, userId, message, rating, anonymous from officeReviews 
                                                       join office on office.id = officeReviews.officeId where officeId = @officeId;", conn);
                    cmd.Parameters.AddWithValue("@officeId", officeId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Review reviewRead = null;
                    while (reader.Read())
                    {
                         reviewRead = GetReviewFromReader(reader);
                        officeReviews.Add(reviewRead);
                    }
                    return officeReviews;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

       

        public Review PostNewReview(Review review)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into officeReviews (officeId, userId, message, rating, anonymous) values (@officeId, @userId, @message, @rating, @anonymous);", conn);
                    cmd.Parameters.AddWithValue("@officeId", review.OfficeId);
                    cmd.Parameters.AddWithValue("@userId", review.UserId);
                    cmd.Parameters.AddWithValue("@message", review.Message);
                    cmd.Parameters.AddWithValue("@rating", review.Rating);
                    cmd.Parameters.AddWithValue("@anonymous", review.Anonymous);

                    cmd.ExecuteNonQuery();
                    return review;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }


        private Review GetReviewFromReader(SqlDataReader reader)
        {
            Review reviewRead = new Review()
            {
                ReviewId = Convert.ToInt32(reader["reviewId"]),
                OfficeId = Convert.ToInt32(reader["officeId"]),
                UserId = Convert.ToInt32(reader["userId"]),
                Message = Convert.ToString(reader["message"]),
                Rating = Convert.ToInt32(reader["rating"]),
                Anonymous = Convert.ToBoolean(reader["anonymous"])
            };
            return reviewRead;
        }
    }
}
