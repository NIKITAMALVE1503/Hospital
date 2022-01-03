//using Hospital.DBModel;

//using Hospital.Repository;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Hospital.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class WeatherForecastController : ControllerBase
//    {
//        private static readonly string[] Summaries = new[]
//        {
//            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//        };

//        private readonly ILogger<WeatherForecastController> _logger;

//        public WeatherForecastController(ILogger<WeatherForecastController> logger)
//        {
//            _logger = logger;
//        }

//        [HttpGet]
//       // public IEnumerable<Doctor> Get()
//        //{
//            //var rng = new Random();
//            //var doc = new Doctor();
            
//            //doc.Id = Guid.NewGuid();
//            //doc.Field = "Surgen";
//            //doc.FirstName = "Nikita";
//            //doc.LastName = "Malve";

//            //var nur=new Nurse();
//            //nur.Id = Guid.NewGuid();
//            //nur.FirstName = "Harry";
//            //nur.LastName = "Potter";
//            //nur.Age = 35;
//            //nur.WardId = 12;

//            //var abc = new DoctorRepository();
//            //abc.AddData(doc);
//            //var doctors= abc.GetDoctor();
//            //var xyz = new NurseRepository();
//            //xyz.DeleteData(nur);

//            //return doctors;


//            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
//            //{
//            //    Date = DateTime.Now.AddDays(index),
//            //    TemperatureC = rng.Next(-20, 55),
//            //    Summary = Summaries[rng.Next(Summaries.Length)]
//            //})
//            //.ToArray();
//       // }
//    }
//}
