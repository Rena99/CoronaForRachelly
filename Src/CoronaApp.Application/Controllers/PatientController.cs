using System;
using System.ComponentModel.DataAnnotations;
using CoronaApp.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoronaApp.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService PatientService;
        public PatientController(IPatientService patientService)
        {
            PatientService = patientService;
        }
        // GET api/<PatientController>/5
        [HttpGet("{id}/{age}")]
        public Patient Get([StringLength(9)]int id,[Range(0, 120)]int age)
        {
            return PatientService.Get(new Patient() { Id = id, Age = age });
        }

        // POST api/<PatientController>
        [HttpPost]
        public void Post([FromBody] Patient value)
        {
            PatientService.Save(value);
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public Object Put(int id, [FromBody] Location location)
        {
            return PatientService.Add(id, location);
        }

        [HttpDelete("{id}")]
        public void Delete(int id, [FromBody] string location)
        {
            PatientService.Delete(id, int.Parse(location));

        }


    }
}






