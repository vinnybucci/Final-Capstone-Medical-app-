using Capstone.DAO;
using Capstone.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase

    {
        private readonly IUserDAO userDAO;
        private readonly IOfficeDAO officeDAO;
        private readonly IAddressDAO addressDAO;
        private readonly IOfficeAddressDAO officeAddressDAO;
        private readonly IDoctorDAO doctorDAO;
        private readonly IAppointmentDAO appointmentDAO;
        private readonly IReviewDAO reviewDAO;
        public DoctorController(IUserDAO _userDAO, IOfficeDAO _officeDAO, IAddressDAO _addressDAO, IOfficeAddressDAO _officeAddressDAO, IDoctorDAO _doctorDAO, IAppointmentDAO _appointmentDAO, IReviewDAO _reviewDAO)
        {
            userDAO = _userDAO;
            officeDAO = _officeDAO;
            addressDAO = _addressDAO;
            officeAddressDAO = _officeAddressDAO;
            doctorDAO = _doctorDAO;
            appointmentDAO = _appointmentDAO;
            reviewDAO = _reviewDAO;

        }

        //TODO ***********ADD DOCTOR/DAY INFO, AS WELL AS OFFICE/DAY
        //Note: when altering the doctor times, we also need to grab the office they work at on that day, and then we can make sure those 2 ids (doc and office) are on the linking table



        [HttpGet] //Dummy Path for testing
        public ActionResult<string> BaseDoctorTest()
        {
            return Ok("reached doctor");
        }

        [HttpGet("{userId}")] //Done
        public ActionResult<Doctor> GetmyInfo(int userId)
        {
            try
            {
                Doctor infoDoc = doctorDAO.GetmyInfo(userId);
                if(infoDoc == null)
                {
                    return NoContent(); 
                }
                return Ok(infoDoc);
            }
            catch (Exception)
            {
               return StatusCode(500);
            }
        }

        [HttpPut("{userId}/update")] //Done
        public ActionResult<Doctor> UpdateMyInfo(Doctor doctor)
        {
            try
            {
                Doctor updateDoc = doctorDAO.UpdateMyInfo(doctor);
                return Ok(updateDoc);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("{userId}/myOffices")] //Done
        public ActionResult<List<Office>> GetMyOffices(int userId)
        {
            try
            {
                List<Office> myOffice = officeDAO.GetMyOffices(userId);
                if (myOffice.Count > 0)
                {
                    return Ok(myOffice);
                }
                else
                {
                    return NoContent();
                }
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("myOffices/{officeId}")] //Done
        public ActionResult<List<Review>> GetMyOfficeReviews(int officeId)
        {
            try
            {
                List<Review> myOfficeReview = reviewDAO.GetOfficeReviews(officeId);
                if(myOfficeReview.Count > 0)
                {
                    return Ok(myOfficeReview);
                }
                else
                {
                    return NoContent();
                }
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("{userId}/getAppointments")] //Done
        public ActionResult<List<Appointment>> GetAppointments(int userId)
        {
            try
            {
                List<Appointment> docAppts = appointmentDAO.GetAppointmentsByDoctor(userId);
                if(docAppts.Count > 0)
                {
                    return Ok(docAppts);
                }
                else
                {
                    return NoContent();
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }

        [HttpPut("respondToPending")] //Done
        public ActionResult RespondToPendingAppointment(Appointment appointment)
        {
            try
            {
                bool respondAppt = appointmentDAO.RespondToPendingAppointment(appointment);
                if (respondAppt == true)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }
    }
}
