using System.Linq;
using Cabinet.Backend.DataLayer;
using Cabinet.Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cabinet.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CarController : ControllerBase
    {
        public CarController(CabinetDbContext _CabinetDB)
        {
            this.CabinetDB = _CabinetDB;
        }

        private readonly CabinetDbContext CabinetDB;

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(CabinetDB.Cars);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var res = CabinetDB.Cars.FirstOrDefault(p => p.ID == id);
            if (res == null)
                return Ok(new Car());

            return Ok(res);
        }
    }
}