using Hospital.DBModel;
using Hospital.IServices;
using Hospital.Repository;
using Hospital.Services.IServices;
using System;
using System.Collections.Generic;

namespace Hospital.Services
{
    public class PatientService : IPatientService
    {
        private readonly IBaseRepository<Patient> _patientRepository;

        public PatientService(IBaseRepository<Patient> patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public List<Patient> GetAllPatients()
        {
            var patients = _patientRepository.GetAll();
            return patients;
        }

        public Patient GetPatient(Guid id)
        {
            var patient = _patientRepository.GetById(id);
            return patient;
        }

        public string AddPatient(Patient patient)
        {
            var result = _patientRepository.Add(patient);
            return result.ToString();
        }

        public string DeletePatient(Guid id)
        {
            var result = _patientRepository.Delete(id);
            return result.ToString();
        }

        public string UpdatePatient(Patient patient)
        {
            var result = _patientRepository.Update(patient);
            return result.ToString();
        }
    }
}
