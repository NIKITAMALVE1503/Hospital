using Microsoft.AspNetCore.Mvc;
using Hospital.DBModel;
using Hospital.Services.IServices;
using System.Collections.Generic;
using System;

namespace Hospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private readonly IHospitalService _hospitalService;

        public HospitalController(IHospitalService hospitalService)
        {
            _hospitalService = hospitalService;
        }

        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<HospitalDb>> GetAll()
        {
            var result = _hospitalService.GetAllHospitals();
            return result;
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<HospitalDb> GetById(Guid id)
        {
            var result = _hospitalService.GetHospital(id);
            return result;
        }

        [HttpPost("AddHospital")]
        public ActionResult<Patient> AddHospital([FromBody] HospitalDb hospital)
        {
            var result = _hospitalService.AddHospital(hospital);
            if (result == "success")
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(500, result);
            }
        }

        [HttpPost("UpdateHospital")]
        public ActionResult<HospitalDb> UpdateHospital([FromBody] HospitalDb hospital)
        {
            var result = _hospitalService.UpdateHospital(hospital);
            if (result == "success")
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(500, result);
            }
        }

        [HttpPost("DeleteHospital/{id}")]
        public ActionResult<HospitalDb> DeleteHospital(Guid id)
        {
            var result = _hospitalService.DeleteHospital(id);
            if (result == "success")
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(500, result);
            }
        }
    }
}
