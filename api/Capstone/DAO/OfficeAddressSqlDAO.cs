using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class OfficeAddressSqlDAO : IOfficeAddressDAO
    {
        private readonly string connectionString;

        public OfficeAddressSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public bool AddOfficeAddress(int officeId, int addressId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {        
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into office_address (officeId, addressId) values (@officeId, @addressId)" , conn);
                    cmd.Parameters.AddWithValue("@officeId", officeId);
                    cmd.Parameters.AddWithValue("@addressId", addressId);

                   int result = cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
    }
}
