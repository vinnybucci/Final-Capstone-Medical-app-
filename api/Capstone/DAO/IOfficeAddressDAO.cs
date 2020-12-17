using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public interface IOfficeAddressDAO
    {
        bool AddOfficeAddress(int officeId, int addressId);
    }
}
