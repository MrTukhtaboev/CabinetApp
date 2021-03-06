using System;
using System.Linq;
using Cabinet.Backend.DataLayer;
using Cabinet.Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cabinet.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PersonController : ControllerBase
    {
        public PersonController(CabinetDbContext _CabinetDB)
        {
            this.CabinetDb = _CabinetDB;
        }

        private readonly CabinetDbContext CabinetDb;
        
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(CabinetDb.Persons);
            }
            catch
            {
                return NotFound("Database connecting is failed");
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Person person = CabinetDb.Persons.FirstOrDefault(p => p.ID == id);
            if (person == null)
                return NotFound(person);
            return Ok(person);
        }

        [HttpPost]
        public IActionResult Post(Person person)
        {
            CabinetDb.Persons.Add(person);
            CabinetDb.SaveChanges();
            return Ok("true");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Person per = CabinetDb.Persons.FirstOrDefault(p => p.ID == id);
            CabinetDb.Persons.Remove(per);
            CabinetDb.SaveChanges();
            return Ok("true");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Person person)
        {
            var temp = CabinetDb.Persons.FirstOrDefault(p => p.ID == id);
            temp.FirstName = person.FirstName;
            temp.LastName = person.LastName;
            temp.Username = person.Username;
            temp.Phone = person.Phone;
            CabinetDb.SaveChanges();
            return Ok("true");
        }

        [HttpGet("test")]
        public string TestMethod()
        {
            return DateTime.Now.ToString();
        }
    }
}
