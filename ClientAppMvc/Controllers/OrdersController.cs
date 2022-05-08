using ClientAppMvc.Models;
using ClientAppMvc.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientAppMvc.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetByTrackingCode(string id)
        {            
            return Ok(await _orderService.GetAsync(id));
        }
        [HttpPost]
        public async Task<IActionResult> InsertOrder([FromBody] InsertOrderRequest request)
        {
            await _orderService.InsertOrderAsync(request);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteOrder(string id)
        {
            await _orderService.DeleteOrderAsync(id);
            return Ok();
        }
    }
}
