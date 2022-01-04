using Hospital.DBModel;
using System;
using System.Collections.Generic;

namespace Hospital.Services.IServices
{
    public interface IHospitalService
    {
        public List<HospitalDb> GetAllHospitals();
        public HospitalDb GetHospital(Guid id);
        public string AddHospital(HospitalDb hospital);
        public string UpdateHospital(HospitalDb hospital);
        public string DeleteHospital(Guid id);
    }
}