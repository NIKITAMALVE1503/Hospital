using Hospital.DBModel;
using System.Collections.Generic;

namespace Hospital.Services.IServices
{
    public interface IHospitalService
    {
        public List<HospitalDB> GetAllHospitals();
        public HospitalDB GetHospital(int id);
        public string AddHospital(HospitalDB hospital);
        public string UpdateHospital(HospitalDB hospital);
        public string DeleteHospital(int id);
    }
}