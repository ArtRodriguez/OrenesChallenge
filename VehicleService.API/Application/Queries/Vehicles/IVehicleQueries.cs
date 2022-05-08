using System.Collections.Generic;
using System.Threading.Tasks;

namespace VehicleService.API.Application.Queries.Vehicles
{
    public interface IVehicleQueries
    {
        Task<IEnumerable<VehicleViewModel>> GetVehiclesAsync();
    }
}