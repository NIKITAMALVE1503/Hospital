using Hospital.DBModel;
using System.Collections.Generic;

namespace Hospital.IServices
{
    public interface IPatientService
    {
        public List<Patient> GetAllPatients();
        public Patient GetPatient(int id);
        public string AddPatient(Patient patient);
        public string UpdatePatient(Patient patient);
        public string DeletePatient(int id);
    }
}