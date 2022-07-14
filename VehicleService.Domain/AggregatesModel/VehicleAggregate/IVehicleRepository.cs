using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleService.Domain.SeedWork;

namespace VehicleService.Domain.AggregatesModel.VehicleAggregate
{
    public interface IVehicleRepository : IRepository<Vehicle>
    {
        Vehicle Add(Vehicle vehicle);
        Vehicle Update(Vehicle vehicle);        
        Task<Vehicle> GetAsync(int vehicleId);
        Task<Vehicle> GetByTrackingCodeAsync(string trackingCode);
    }
}
