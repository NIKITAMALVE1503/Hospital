using Hospital.DBModel;
using System;
using System.Collections.Generic;

namespace Hospital.Services.IServices
{
    public interface IAppointmentService
    {
        public List<Appointment> GetAllAppointments();
        public Appointment GetAppointment(Guid id);
        public string AddAppointment(Appointment appointment);
        public string UpdateAppointment(Appointment appointment);
        public string DeleteAppointment(Guid id);
    }
}
