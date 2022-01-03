using Microsoft.AspNetCore.Mvc;
using Hospital.DBModel;
using System.Collections.Generic;
using Hospital.Services.IServices;

namespace Hospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<Doctor>> GetAll()
        {
            var result = _doctorService.GetAllDoctors();
            return result;
        }

        [HttpGet("GetById/{id}")]
        public ActionResult<Doctor> GetById(int id)
        {
            var result = _doctorService.GetDoctor(id);
            return result;
        }

        [HttpPost("AddDoctor")]
        public ActionResult<Doctor> AddDoctor([FromBody] Doctor doctor)
        {
            var result = _doctorService.AddDoctor(doctor);
            if (result == "success")
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(500, result);
            }
        }

        [HttpPost("UpdateDoctor")]
        public ActionResult<Doctor> UpdateDoctor([FromBody] Doctor doctor)
        {
            var result = _doctorService.UpdateDoctor(doctor);
            if (result == "success")
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(500, result);
            }
        }

        [HttpPost("DeleteDoctor/{id}")]
        public ActionResult<Doctor> DeleteDoctor(int id)
        {
            var result = _doctorService.DeleteDoctor(id);
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