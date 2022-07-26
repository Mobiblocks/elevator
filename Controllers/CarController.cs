using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElevatorAPIWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ILogger<ElevatorController> _logger;

        public CarController(ILogger<ElevatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Car Controller:\r\n\r\n GET /car/currentservicingfloors \r\n GET /car/nextfloor";
        }

        [Route("currentservicingfloors")]
        public IEnumerable<int> CurrentServicingFloors(string id)
        {
            //implementation here

            return new int[] { 1, 5 };
        }

        [Route("nextfloor")]
        public int TakeMeToFloor(string id)
        {
            //implementation here

            return 25;
        }
    }
}
