using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using VehicleService.API.Application.Queries.Vehicles;

namespace VehicleService.API.Controllers
{    
    [Route("api/v1/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly ILogger<VehiclesController> _logger;
        public VehiclesController(ILogger<VehiclesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<VehicleViewModel>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<VehicleViewModel>>> GetVehiclesAsync()
        {
            return Ok(Enumerable.Empty<VehicleViewModel>());
        }

    }
}
