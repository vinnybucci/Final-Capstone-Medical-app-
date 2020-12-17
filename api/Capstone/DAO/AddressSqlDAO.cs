using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class AddressSqlDAO : IAddressDAO
    {
        private readonly string connectionString;
        public AddressSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public int CreateNewOfficeAddress(Office office)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd;
                    if (office.StreetAddress2 == null || office.StreetAddress2 == "")
                    {
                        cmd = new SqlCommand("insert into addresses (streetaddress,  city, state, zip) values (@streetaddress, @city, @state, @zip); select scope_identity();", conn);
                    }
                    else
                    {
                        cmd = new SqlCommand("insert into addresses (streetaddress, streetaddress2, city, state, zip) values (@streetaddress, @streetaddress2, @city, @state, @zip); select scope_identity();", conn);
                        cmd.Parameters.AddWithValue("@streetaddress2", office.StreetAddress2);
                    }
                    cmd.Parameters.AddWithValue("@streetaddress", office.StreetAddress);
                    cmd.Parameters.AddWithValue("@city", office.City);
                    cmd.Parameters.AddWithValue("@state", office.State);
                    cmd.Parameters.AddWithValue("@zip", office.Zip);

                    object result = cmd.ExecuteScalar();
                    result = (result == DBNull.Value) ? null : result;
                    int newId = Convert.ToInt32(result);
                    return newId;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
    }
}



