using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Cabinet.Backend.DataLayer;
using Cabinet.Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cabinet.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        public HomeController(CabinetDbContext _CabinetDB)
        {
            CabinetDb = _CabinetDB;
        }

        private readonly CabinetDbContext CabinetDb;

        [HttpGet]
        public IActionResult GetPersonWithCarName()
        {
            var joined = CabinetDb.Persons.Join(CabinetDb.Cars, p => p.CarID, c => c.ID, (person, car) =>
                new {FullName = person.FirstName + " " + person.LastName, CarName = car.Name});

            return Ok(joined);
        }
    }
}