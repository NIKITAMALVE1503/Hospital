using Hospital.DBModel;
using Hospital.Repository;
using Hospital.Services.IServices;
using System.Collections.Generic;

namespace Hospital.Services
{
    public class HospitalService : IHospitalService
    {
        private readonly IBaseRepository<HospitalDB> _hospitalRepository;

        public HospitalService(IBaseRepository<HospitalDB> hospitalRepository)
        {
            _hospitalRepository = hospitalRepository;
        }

        public string AddHospital(HospitalDB hospital)
        {
            var result = _hospitalRepository.Add(hospital);
            return result.ToString();
        }

        public string DeleteHospital(int id)
        {
            var result = _hospitalRepository.Delete(id);
            return result.ToString();
        }

        public List<HospitalDB> GetAllHospitals()
        {
            var hospitals = _hospitalRepository.GetAll();
            return hospitals;
        }

        public HospitalDB GetHospital(int id)
        {
            var hospital = _hospitalRepository.GetById(id);
            return hospital;
        }

        public string UpdateHospital(HospitalDB hospital)
        {
            var result = _hospitalRepository.Update(hospital);
            return result.ToString();
        }
    }
}
