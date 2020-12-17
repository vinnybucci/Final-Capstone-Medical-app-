using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public interface IAppointmentDAO
    {
        List<Appointment> GetAppointmentsByDoctor(int userId);
        List<Appointment> GetAppointmentsByPatient(int userId);
        bool RespondToPendingAppointment(Appointment appointment);
        Appointment CreateAppointmentRequest(Appointment appointment);

    }
}
