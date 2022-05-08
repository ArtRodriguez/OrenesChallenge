using ClientAppMvc.Models;
using ClientAppMvc.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientAppMvc.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly IVehicleService _vehicleService;

        public VehiclesController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _vehicleService.GetVehiclesAsync());
        }
       

        [HttpPost]
        public async Task<IActionResult> UpdateLocation([FromBody]UpdateLocationRequest request)
        {
            await _vehicleService.UpdateLocationAsync(request);
            return Ok();
        }
    }
}
