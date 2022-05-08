using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VehicleService.Domain.AggregatesModel.VehicleAggregate;

namespace VehicleService.API.Application.Commands.InsertOrder
{
    public class InsertOrderCommandHandler : IRequestHandler<InsertOrderCommand, bool>
    {        
        private readonly IVehicleRepository _vehicleRepository;
        public InsertOrderCommandHandler(IVehicleRepository vehicleRepository)
        {            
            _vehicleRepository = vehicleRepository;
        }

        public async Task<bool> Handle(InsertOrderCommand request, CancellationToken cancellationToken)
        {
            // Check if VehicleId exists
            var vehicle = await _vehicleRepository.GetAsync(request.VehicleId);
            if(vehicle == null)
            {
                throw new ArgumentException($"Vehicle with Id:{request.VehicleId} not found");
            }            
            vehicle.AddOrder(request.TrackingCode);
            return await _vehicleRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);            
        }
    }
}
