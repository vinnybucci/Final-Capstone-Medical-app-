using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class DoctorSqlDAO : IDoctorDAO
    {
        private readonly string connectionString;

        public DoctorSqlDAO(string dbConnectionString)
        {
            connectionString = dbConnectionString;
        }
      

        public int ChangeDoctorUserStatus(Doctor doctor)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update users set user_role = @doctor_status where user_id = @user_id;", conn);
                    cmd.Parameters.AddWithValue("@doctor_status", doctor.User_Role);
                    cmd.Parameters.AddWithValue("@user_id", doctor.UserId);

                    int result = cmd.ExecuteNonQuery();
                    return result;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public List<Doctor> GetAllDoctors()
        {
            List<Doctor> verifiedDoctorList = new List<Doctor>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        @"select userId, hourlyRate, firstName, lastName from doctor
                        join users on users.user_id = doctor.userId
                        where user_role = 'doctorVerified';", conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Doctor doctorRead = GetDoctorFromReader(reader);
                        verifiedDoctorList.Add(doctorRead);
                    }
                    return verifiedDoctorList;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Doctor GetmyInfo(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        @"select userId, hourlyRate, firstName, lastName from doctor
                        join users on users.user_id = doctor.userId
                        where user_id = @userId;", conn);
                    cmd.Parameters.AddWithValue("@userId", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Doctor doctorRead = null;
                    while (reader.Read())
                    {
                        doctorRead = GetDoctorFromReader(reader);
                    }
                    reader.Close();
                    if (doctorRead != null)
                    {
                        cmd = new SqlCommand(
                            @"select day, startTime, endTime, office.id, office.name from doctor_day
                            join daysOfTheWeek on daysOfTheWeek.dayId=doctor_day.dayId
							join office on doctor_day.officeId=office.id
                            where doctorId = @userId", conn);
                        cmd.Parameters.AddWithValue("@userId", id);
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            if (Convert.ToString(reader["day"]) == "Monday")
                            {
                                string placeholder = Convert.ToString(reader["day"]);
                                doctorRead.WeeklyHours.Monday.Start = reader.GetTimeSpan(1);
                                doctorRead.WeeklyHours.Monday.End = reader.GetTimeSpan(2);
                                doctorRead.WeeklyHours.Monday.OfficeOfDay.OfficeId = Convert.ToInt32(reader["id"]);
                                doctorRead.WeeklyHours.Monday.OfficeOfDay.Name = Convert.ToString(reader["name"]);
                            }
                            if(Convert.ToString(reader["day"]) == "Tuesday")
                            {
                                doctorRead.WeeklyHours.Tuesday.Start = reader.GetTimeSpan(1);
                                doctorRead.WeeklyHours.Tuesday.End = reader.GetTimeSpan(2);
                                doctorRead.WeeklyHours.Tuesday.OfficeOfDay.OfficeId = Convert.ToInt32(reader["id"]);
                                doctorRead.WeeklyHours.Tuesday.OfficeOfDay.Name = Convert.ToString(reader["name"]);
                            }
                            if (Convert.ToString(reader["day"]) == "Wednesday")
                            {
                                doctorRead.WeeklyHours.Wednesday.Start = reader.GetTimeSpan(1);
                                doctorRead.WeeklyHours.Wednesday.End = reader.GetTimeSpan(2);
                                doctorRead.WeeklyHours.Wednesday.OfficeOfDay.OfficeId = Convert.ToInt32(reader["id"]);
                                doctorRead.WeeklyHours.Wednesday.OfficeOfDay.Name = Convert.ToString(reader["name"]);
                            }
                            if (Convert.ToString(reader["day"]) == "Thursday")
                            {
                                doctorRead.WeeklyHours.Thursday.Start = reader.GetTimeSpan(1);
                                doctorRead.WeeklyHours.Thursday.End = reader.GetTimeSpan(2);
                                doctorRead.WeeklyHours.Thursday.OfficeOfDay.OfficeId = Convert.ToInt32(reader["id"]);
                                doctorRead.WeeklyHours.Thursday.OfficeOfDay.Name = Convert.ToString(reader["name"]);
                            }
                            if (Convert.ToString(reader["day"]) == "Friday")
                            {
                                doctorRead.WeeklyHours.Friday.Start = reader.GetTimeSpan(1);
                                doctorRead.WeeklyHours.Friday.End = reader.GetTimeSpan(2);
                                doctorRead.WeeklyHours.Friday.OfficeOfDay.OfficeId = Convert.ToInt32(reader["id"]);
                                doctorRead.WeeklyHours.Friday.OfficeOfDay.Name = Convert.ToString(reader["name"]);
                            }
                            if (Convert.ToString(reader["day"]) == "Saturday")
                            {
                                doctorRead.WeeklyHours.Saturday.Start = reader.GetTimeSpan(1);
                                doctorRead.WeeklyHours.Saturday.End = reader.GetTimeSpan(2);
                                doctorRead.WeeklyHours.Saturday.OfficeOfDay.OfficeId = Convert.ToInt32(reader["id"]);
                                doctorRead.WeeklyHours.Saturday.OfficeOfDay.Name = Convert.ToString(reader["name"]);
                            }
                            if (Convert.ToString(reader["day"]) == "Sunday")
                            {
                                doctorRead.WeeklyHours.Sunday.Start = reader.GetTimeSpan(1);
                                doctorRead.WeeklyHours.Sunday.End = reader.GetTimeSpan(2);
                                doctorRead.WeeklyHours.Sunday.OfficeOfDay.OfficeId = Convert.ToInt32(reader["id"]);
                                doctorRead.WeeklyHours.Sunday.OfficeOfDay.Name = Convert.ToString(reader["name"]);
                            }
                        }

                    }
                    return doctorRead;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public Doctor UpdateMyInfo(Doctor doctor)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        @"update doctor set hourlyRate = @hourlyRate, firstName = @firstName, lastName=@lastName;

                        update doctor_day set startTime=@monStart, endTime=@monEnd where doctorId=@doctorId and dayId=1;
                        update doctor_day set startTime=@tuesStart, endTime=@tuesEnd where doctorId=@doctorId and dayId=2;
                        update doctor_day set startTime=@wedStart, endTime=@wedEnd where doctorId=@doctorId and dayId=3;
                        update doctor_day set startTime=@thursStart, endTime=@thursEnd where doctorId=@doctorId and dayId=4;
                        update doctor_day set startTime=@friStart, endTime=@friEnd where doctorId=@doctorId and dayId=5;
                        update doctor_day set startTime=@satStart, endTime=@satEnd where doctorId=@doctorId and dayId=6;
                        update doctor_day set startTime=@sunStart, endTime=@sunEnd where doctorId=@doctorId and dayId=7;", conn);
                    //for doctor tbl
                    cmd.Parameters.AddWithValue("@hourlyRate", doctor.HourlyRate);
                    cmd.Parameters.AddWithValue("@firstName", doctor.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", doctor.LastName);
                    //for doctor_day tbl
                    cmd.Parameters.AddWithValue("@doctorId", doctor.UserId);
                    cmd.Parameters.AddWithValue("@monStart", doctor.WeeklyHours.Monday.Start);
                    cmd.Parameters.AddWithValue("@monEnd", doctor.WeeklyHours.Monday.End);
                    cmd.Parameters.AddWithValue("@tuesStart", doctor.WeeklyHours.Tuesday.Start);
                    cmd.Parameters.AddWithValue("@tuesEnd", doctor.WeeklyHours.Tuesday.End);
                    cmd.Parameters.AddWithValue("@wedStart", doctor.WeeklyHours.Wednesday.Start);
                    cmd.Parameters.AddWithValue("@wedEnd", doctor.WeeklyHours.Wednesday.End);
                    cmd.Parameters.AddWithValue("@thursStart", doctor.WeeklyHours.Thursday.Start);
                    cmd.Parameters.AddWithValue("@thursEnd", doctor.WeeklyHours.Thursday.End);
                    cmd.Parameters.AddWithValue("@friStart", doctor.WeeklyHours.Friday.Start);
                    cmd.Parameters.AddWithValue("@friEnd", doctor.WeeklyHours.Friday.End);
                    cmd.Parameters.AddWithValue("@satStart", doctor.WeeklyHours.Saturday.Start);
                    cmd.Parameters.AddWithValue("@satEnd", doctor.WeeklyHours.Saturday.End);
                    cmd.Parameters.AddWithValue("@sunStart", doctor.WeeklyHours.Sunday.Start);
                    cmd.Parameters.AddWithValue("@sunEnd", doctor.WeeklyHours.Sunday.End);
                    cmd.ExecuteNonQuery();
                    return doctor;
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public List<Doctor> GetDoctorsByOffice(int officeId)
        {
            try
            {
                List<Doctor> docsInOffice = new List<Doctor>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        @" select userId, firstName, lastName, hourlyRate from doctor
                        join doctor_day on doctor.userId=doctor_day.doctorId
                        where officeId=@officeId
                        group by userId, firstName, lastName, hourlyRate", conn);
                    cmd.Parameters.AddWithValue("@officeId", officeId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Doctor doctorRead = GetDoctorFromReader(reader);
                        docsInOffice.Add(doctorRead);
                    }
                    return docsInOffice;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Doctor> GetOtherDoctorsInOffice(int officeId, int doctorId)
        {
            try
            {
                List<Doctor> docsInOffice = new List<Doctor>();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        @" select userId, firstName, lastName, hourlyRate from doctor
                        join doctor_day on doctor.userId=doctor_day.doctorId
                        where officeId=@officeId
                        group by userId, firstName, lastName, hourlyRate", conn);
                    cmd.Parameters.AddWithValue("@officeId", officeId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Doctor doctorRead = GetDoctorFromReader(reader);
                        if (doctorRead.UserId != doctorId)
                        {
                            docsInOffice.Add(doctorRead);
                        }
                    }
                    return docsInOffice;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private Doctor GetDoctorFromReader(SqlDataReader reader)
        {
            Doctor doctorRead = new Doctor()
            {
                UserId = Convert.ToInt32(reader["userId"]),
                HourlyRate = Convert.ToDecimal(reader["hourlyRate"]),
                FirstName = Convert.ToString(reader["firstName"]),
                LastName = Convert.ToString(reader["lastName"])
            };
            return doctorRead;
        }
    }
}
