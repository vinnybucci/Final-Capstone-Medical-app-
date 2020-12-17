using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public interface IDoctorDAO
    {
        Doctor GetmyInfo(int id);
        Doctor UpdateMyInfo(Doctor doctor);
        int ChangeDoctorUserStatus(Doctor doctor);
        //from patient controller
        List<Doctor> GetAllDoctors();
        List<Doctor> GetDoctorsByOffice(int officeId);
        List<Doctor> GetOtherDoctorsInOffice(int officeId, int doctorId);
    }
}
