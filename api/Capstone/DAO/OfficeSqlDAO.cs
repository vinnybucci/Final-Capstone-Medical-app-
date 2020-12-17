using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class OfficeSqlDAO : IOfficeDAO
    {
        private readonly string connectionString;

        public OfficeSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }


        //********CHECK IOFFICEDAO for breakdown of missing reviews/responses methods


        public int CreateNewOffice(Office office)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into office (phone, name) values (@phone, @name); select scope_identity()", conn);
                    cmd.Parameters.AddWithValue("@phone", office.Phone);
                    cmd.Parameters.AddWithValue("@name", office.Name);

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

        public List<Office> GetAllOffices()
        {
            try
            {
                List<Office> allOffices = new List<Office>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        @"select office.id, name, phone, streetAddress, streetAddress2, city, state, zip from doctor_day
                        join office on office.id = doctor_day.officeId
                        join office_address on office_address.officeId = office.id
                        join addresses on addresses.addressId = office_address.addressId
                        group by office.id, name, phone, streetAddress, streetAddress2, city, state, zip;", conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Office o = new Office();
                        o.OfficeId = Convert.ToInt32(reader["id"]);
                        o.Name = Convert.ToString(reader["name"]);
                        o.Phone = Convert.ToString(reader["phone"]);
                        o.StreetAddress = Convert.ToString(reader["streetAddress"]);
                        o.StreetAddress2 = Convert.ToString(reader["streetAddress2"]);
                        o.City = Convert.ToString(reader["city"]);
                        o.State = Convert.ToString(reader["state"]);
                        o.Zip = Convert.ToString(reader["zip"]);

                        allOffices.Add(o);
                    }
                }
                return allOffices;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Office> GetMyOffices(int doctorId)
        {
            try
            {
                List<Office> doctorsOffices = new List<Office>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        @"select office.id, name, phone, streetAddress, streetAddress2, city, state, zip from doctor_day
                        join office on office.id = doctor_day.officeId
                        join office_address on office_address.officeId = office.id
                        join addresses on addresses.addressId = office_address.addressId
                        where doctorId = @doctorId
                        group by office.id, name, phone, streetAddress, streetAddress2, city, state, zip;", conn);
                    cmd.Parameters.AddWithValue("@doctorId", doctorId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Office o = new Office();
                        o.OfficeId = Convert.ToInt32(reader["id"]);
                        o.Name = Convert.ToString(reader["name"]);
                        o.Phone = Convert.ToString(reader["phone"]);
                        o.StreetAddress = Convert.ToString(reader["streetAddress"]);
                        o.StreetAddress2 = Convert.ToString(reader["streetAddress2"]);
                        o.City = Convert.ToString(reader["city"]);
                        o.State = Convert.ToString(reader["state"]);
                        o.Zip = Convert.ToString(reader["zip"]);

                        doctorsOffices.Add(o);
                    }
                }
                return doctorsOffices;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
