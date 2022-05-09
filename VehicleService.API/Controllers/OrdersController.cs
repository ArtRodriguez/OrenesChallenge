using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using VehicleService.API.Application.Commands.DeleteOrder;
using VehicleService.API.Application.Commands.InsertOrder;
using VehicleService.API.Application.Queries.Orders;

namespace VehicleService.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [Authorize]
    public class OrdersController : ControllerBase
    {
        private readonly ILogger<OrdersController> _logger;
        private readonly IMediator _mediator;
        private readonly IOrderQueries _orderQueries;
        public OrdersController(ILogger<OrdersController> logger, IMediator mediator, IOrderQueries orderQueries)
        {
            _logger = logger;
            _mediator = mediator;
            _orderQueries = orderQueries;
        }
        [HttpGet("{trackingCode}")]
        [ProducesResponseType(typeof(IEnumerable<OrderViewModel>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<OrderViewModel>>> GetAsync(string trackingCode)
        {
            return Ok(await _orderQueries.GetOrderByTrackingCodeAsync(trackingCode));
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Post([FromBody] InsertOrderCommand command)
        {
            if(await _mediator.Send(command))
            {
                _logger.LogInformation($"----- Order {command.TrackingCode} inserted in Vehicle {command.VehicleId}");
                return Ok();
            }
            _logger.LogError($"----- Error inserting order {command.TrackingCode} in Vehicle {command.VehicleId}");
            return BadRequest();
        }

        [HttpDelete("{trackingCode}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Delete(string trackingCode)
        {
            if (await _mediator.Send(new DeleteOrderCommand(trackingCode)))
            {
                _logger.LogInformation($"----- Order {trackingCode} deleted");
                return Ok();
            }
            _logger.LogError($"----- Error deleting order {trackingCode}");
            return BadRequest();
        }
    }
}
