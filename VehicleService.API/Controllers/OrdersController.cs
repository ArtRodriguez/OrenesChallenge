using MediatR;
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
        public async Task<IActionResult> Post([FromBody] InsertOrderCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }

        [HttpDelete("{trackingCode}")]
        public async Task<IActionResult> Delete(string trackingCode)
        {
            await _mediator.Send(new DeleteOrderCommand(trackingCode));
            return Ok();
        }
    }
}
