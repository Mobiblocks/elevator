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
    public class ElevatorController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ElevatorController> _logger;

        public ElevatorController(ILogger<ElevatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Elevator Controller:\r\n\r\n GET /elevator/sendcartofloor/5 \r\n GET /elevator/takemetofloor/4";
        }

        [Route("sendcartofloor/{id}")]
        public string SendCarToFloor(string id)
        {
            //implementation here

            return "done. sent to floor " + id;
        }

        [Route("takemetofloor/{id}")]
        public string TakeMeToFloor(string id)
        {
            //implementation here

            return "done. arrived at floor " + id;
        }
    }
}
