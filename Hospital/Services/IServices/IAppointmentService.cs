using Hospital.DBModel;
using System.Collections.Generic;

namespace Hospital.Services.IServices
{
    public interface IAppointmentService
    {
        public List<Appointment> GetAllAppointments();
        public Appointment GetAppointment(int id);
        public string AddAppointment(Appointment appointment);
        public string UpdateAppointment(Appointment appointment);
        public string DeleteAppointment(int id);
    }
}
