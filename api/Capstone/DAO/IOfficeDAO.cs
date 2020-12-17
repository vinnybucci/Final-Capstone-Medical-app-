using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public interface IOfficeDAO
    {
        int CreateNewOffice(Office office);
        List<Office> GetMyOffices(int doctorId);
        List<Office> GetAllOffices();
    }
}
