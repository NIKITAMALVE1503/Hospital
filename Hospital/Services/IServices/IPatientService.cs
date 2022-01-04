using Hospital.DBModel;
using System;
using System.Collections.Generic;

namespace Hospital.IServices
{
    public interface IPatientService
    {
        public List<Patient> GetAllPatients();
        public Patient GetPatient(Guid id);
        public string AddPatient(Patient patient);
        public string UpdatePatient(Patient patient);
        public string DeletePatient(Guid id);
    }
}