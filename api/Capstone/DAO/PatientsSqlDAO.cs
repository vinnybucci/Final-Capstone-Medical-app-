using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class PatientsSqlDAO : IPatientsDAO
    {
        private readonly string connectionString;

        public PatientsSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }

        public Patient GetMyAppointments(Patient patients)
        {
            throw new NotImplementedException();
        }

        public Patient GetMyInfo(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select patientId, firstName, lastName, phone, email, dateOfBirth from patients join users on users.user_id = patients.patientId where user_id = @userId;", conn);
                    cmd.Parameters.AddWithValue("@userId", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Patient patientRead = null;
                    while (reader.Read())
                    {
                        patientRead = GetPatientFromReader(reader);
                    }
                    return patientRead;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public Patient UpdateMyInfo(Patient patients)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update patients set firstName = @firstName, lastName = @lastName, phone = @phone, email = @email, dateOfBirth = @dateOfBirth;", conn);
                    cmd.Parameters.AddWithValue("@firstName", patients.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", patients.LastName);
                    cmd.Parameters.AddWithValue("@phone", patients.Phone);
                    cmd.Parameters.AddWithValue("@email", patients.Email);
                    cmd.Parameters.AddWithValue("@dateOfBirth", patients.DateOfBirth);
                    SqlDataReader reader = cmd.ExecuteReader();

                    return patients;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        private Patient GetPatientFromReader(SqlDataReader reader)
        {
            Patient patientRead = new Patient()
            {
                PatientId = Convert.ToInt32(reader["patientId"]),
                FirstName = Convert.ToString(reader["firstName"]),
                LastName = Convert.ToString(reader["lastName"]),
                Phone = Convert.ToInt32(reader["phone"]),
                Email = Convert.ToString(reader["email"]),
                DateOfBirth = Convert.ToDateTime(reader["dateOfBirth"])

            };
            return patientRead;
        }
    }
}
