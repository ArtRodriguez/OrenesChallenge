using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleService.Domain.AggregatesModel.VehicleAggregate;
using VehicleService.Domain.SeedWork;

namespace VehicleService.Infrastructure.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly VehicleServiceContext _context;
        public IUnitOfWork UnitOfWork => _context;
        public VehicleRepository(VehicleServiceContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }        

        public Vehicle Add(Vehicle vehicle)
        {
            if (vehicle.IsTransient())
            {
                vehicle.CreatedAt = DateTime.Now;
                vehicle.UpdatedAt = vehicle.CreatedAt;
                return _context.Vehicles.Add(vehicle).Entity;
            }
            return vehicle;
        }

        public async Task<Vehicle> GetAsync(int vehicleId)
        {
            return await _context.Vehicles.FindAsync(vehicleId);
        }

        public Vehicle Update(Vehicle vehicle)
        {
            vehicle.UpdatedAt = DateTime.Now;
            return _context.Vehicles.Update(vehicle).Entity;
        }
    }
}
