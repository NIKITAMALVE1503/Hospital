using Hospital.DBModel;
using Hospital.Repository;
using Hospital.Services.IServices;
using System;
using System.Collections.Generic;

namespace Hospital.Services
{
    public class HospitalService : IHospitalService
    {
        private readonly IBaseRepository<HospitalDb> _hospitalRepository;

        public HospitalService(IBaseRepository<HospitalDb> hospitalRepository)
        {
            _hospitalRepository = hospitalRepository;
        }

        public string AddHospital(HospitalDb hospital)
        {
            var result = _hospitalRepository.Add(hospital);
            return result.ToString();
        }

        public string DeleteHospital(Guid id)
        {
            var result = _hospitalRepository.Delete(id);
            return result.ToString();
        }

        public List<HospitalDb> GetAllHospitals()
        {
            var hospitals = _hospitalRepository.GetAll();
            return hospitals;
        }

        public HospitalDb GetHospital(Guid id)
        {
            var hospital = _hospitalRepository.GetById(id);
            return hospital;
        }

        public string UpdateHospital(HospitalDb hospital)
        {
            var result = _hospitalRepository.Update(hospital);
            return result.ToString();
        }
    }
}
