using Hospital.DBModel;
using System.Collections.Generic;

namespace Hospital.Services.IServices
{
    public interface IDoctorService
    {
        public List<Doctor> GetAllDoctors();
        public Doctor GetDoctor(int id);
        public string AddDoctor(Doctor doctor);
        public string UpdateDoctor(Doctor doctor);
        public string DeleteDoctor(int id);
    }
}
