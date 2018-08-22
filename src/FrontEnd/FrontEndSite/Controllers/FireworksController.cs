using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEndSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FireworksController : ControllerBase
    {
        [HttpGet]
        public async Task<int> NumberOfFireworks()
        {
            BackEndService service = new BackEndService();
            return await service.GetFireworksCounter();
        }
    }
}