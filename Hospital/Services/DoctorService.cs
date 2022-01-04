using Hospital.DBModel;
using Hospital.Repository;
using Hospital.Services.IServices;
using System;
using System.Collections.Generic;

namespace Hospital.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IBaseRepository<Doctor> _doctorRepository;

        public DoctorService(IBaseRepository<Doctor> doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public string AddDoctor(Doctor doctor)
        {
            var result = _doctorRepository.Add(doctor);
            return result.ToString();
        }

        public string DeleteDoctor(Guid id)
        {
            var result = _doctorRepository.Delete(id);
            return result.ToString();
        }

        public List<Doctor> GetAllDoctors()
        {
            var doctors = _doctorRepository.GetAll();
            return doctors;
        }

        public Doctor GetDoctor(Guid id)
        {
            var doctor = _doctorRepository.GetById(id);
            return doctor;
        }

        public string UpdateDoctor(Doctor doctor)
        {
            var result = _doctorRepository.Update(doctor);
            return result.ToString();
        }
    }
}
