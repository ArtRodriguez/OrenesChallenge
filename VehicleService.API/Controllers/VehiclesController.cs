using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using VehicleService.API.Application.Queries.Vehicles;
using VehicleService.API.Application.Commands.UpdateVehicleLocation;
using MediatR;
using Microsoft.AspNetCore.Authorization;

namespace VehicleService.API.Controllers
{    
    [Route("api/v1/[controller]")]
    [ApiController]
    [Authorize]
    public class VehiclesController : ControllerBase
    {
        private readonly ILogger<VehiclesController> _logger;
        private readonly IMediator _mediator;
        private readonly IVehicleQueries _vehicleQueries;
        public VehiclesController(ILogger<VehiclesController> logger, IMediator mediator, IVehicleQueries vehicleQueries)
        {
            _logger = logger;
            _mediator = mediator;
            _vehicleQueries = vehicleQueries;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<VehicleViewModel>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<VehicleViewModel>>> GetVehiclesAsync()
        {
            return Ok(await _vehicleQueries.GetVehiclesAsync());
        }

        [HttpPut("Location")]
        public async Task<IActionResult> UpdateVehicleLocation([FromBody] UpdateVehicleLocationCommand command)
        {
            if(await _mediator.Send(command))
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
