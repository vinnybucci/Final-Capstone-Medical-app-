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
    public class AdminController:ControllerBase
    {
        private readonly IUserDAO userDAO;

        public AdminController(IUserDAO _userDAO)
        {
            userDAO = _userDAO;
        }

        [HttpGet("/getPendingDoctors")]
        public ActionResult<List<User>> GetPendingDoctors()
        {
            try
            {
                List<User> pendingDoctors = userDAO.GetPendingDoctors();
                return pendingDoctors;
            }
            catch(Exception e)
            {
                throw new NotImplementedException("This method is not implemented");
            }
        }
    }
}
