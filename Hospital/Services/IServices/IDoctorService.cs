using Hospital.DBModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hospital.Services.IServices
{
    public interface IDoctorService
    {
        public List<Doctor> GetAllDoctors();
        public Doctor GetDoctor(Guid id);
        public string AddDoctor(Doctor doctor);
        public string UpdateDoctor(Doctor doctor);
        public string DeleteDoctor(Guid id);
    }
}
