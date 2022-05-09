using System.Collections.Generic;
using System.Threading.Tasks;

namespace VehicleService.Infrastructure.Queries.Vehicles
{
    public interface IVehicleQueries
    {
        Task<IEnumerable<VehicleDto>> GetVehiclesAsync();
    }
}