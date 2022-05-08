using ClientAppMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientAppMvc.Services
{
    public interface IVehicleService
    {
        Task<IEnumerable<VehicleDto>> GetVehicles();
        Task UpdateLocation(int vehicleId, double latitude, double longitude);
        Task UpdateLocation(UpdateLocationRequest request);
    }
}
