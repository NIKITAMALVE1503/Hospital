using Hospital.DBModel;
using Hospital.Repository;
using Hospital.Services.IServices;
using System;
using System.Collections.Generic;

namespace Hospital.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IBaseRepository<Appointment> _appointmentRepository;

        public AppointmentService(IBaseRepository<Appointment> appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public string AddAppointment(Appointment appointment)
        {
            var result = _appointmentRepository.Add(appointment);
            return result.ToString();
        }

        public string DeleteAppointment(Guid id)
        {
            var result = _appointmentRepository.Delete(id);
            return result.ToString();
        }

        public List<Appointment> GetAllAppointments()
        {
            var appointments = _appointmentRepository.GetAll();
            return appointments;
        }

        public Appointment GetAppointment(Guid id)
        {
            var appointment = _appointmentRepository.GetById(id);
            return appointment;
        }

        public string UpdateAppointment(Appointment appointment)
        {
            var result = _appointmentRepository.Update(appointment);
            return result.ToString();
        }
    }
}