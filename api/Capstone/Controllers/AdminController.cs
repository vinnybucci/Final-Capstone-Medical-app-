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
    public class AdminController : ControllerBase
    {
        private readonly IUserDAO userDAO;
        private readonly IOfficeDAO officeDAO;
        private readonly IAddressDAO addressDAO;
        private readonly IOfficeAddressDAO officeAddressDAO;
        private readonly IDoctorDAO doctorDAO;

        public AdminController(IUserDAO _userDAO, IOfficeDAO _officeDAO, IAddressDAO _addressDAO, IOfficeAddressDAO _officeAddressDAO, IDoctorDAO _doctorDAO)
        {
            userDAO = _userDAO;
            officeDAO = _officeDAO;
            addressDAO = _addressDAO;
            officeAddressDAO = _officeAddressDAO;
            doctorDAO = _doctorDAO;

        }

        [HttpGet]
        public ActionResult<string> BaseAdminTest()
        {
            return Ok("reached admin");
        }

        [HttpGet("getPendingDoctors")] //Done
        public ActionResult<List<User>> GetPendingDoctors()
        {
            try
            {
                List<User> pendingDoctors = userDAO.GetPendingDoctors();
                return pendingDoctors;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpPost("createNewOffice")] //Done
        public ActionResult<Office> CreateNewOffice(Office office)
        {
            try
            {
                int newOfficeId = officeDAO.CreateNewOffice(office);

                if (newOfficeId > 0)
                {
                   int newAddressId = addressDAO.CreateNewOfficeAddress(office);

                    if (newAddressId > 0)
                    {
                        officeAddressDAO.AddOfficeAddress( newOfficeId, newAddressId);
                        office.OfficeId = newOfficeId;
                        return Ok(office);
                    }
                    else //if address sql fails
                    {
                        return BadRequest();
                    }
                }
                else //if office sql fails
                {   
                    return BadRequest();
                }

            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPut("approveDoctorUser")] //Done
        public ActionResult<Doctor> ApproveDoctorUser(Doctor doctor)
        {
            try
            {
                int approvedoc = doctorDAO.ChangeDoctorUserStatus(doctor);
                if (approvedoc == 1)
                {
                    return Ok(doctor);
                }  
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
