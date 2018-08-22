using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FireworksCounterController : ControllerBase
    {
        [HttpPost]
        public void SetFireworksCounter([FromBody] string fireworksCounter)
        {
            CounterService.FireworksCounter = Int32.Parse(fireworksCounter);
        }

        [HttpGet]
        public int GetFireworksCounter()
        {
            return CounterService.FireworksCounter;
        }
    }
}