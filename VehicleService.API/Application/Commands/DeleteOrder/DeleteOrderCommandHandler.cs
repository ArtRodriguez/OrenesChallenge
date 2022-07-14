using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VehicleService.Domain.AggregatesModel.OrderAggregate;
using VehicleService.Domain.AggregatesModel.VehicleAggregate;

namespace VehicleService.API.Application.Commands.DeleteOrder
{
    public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand, bool>
    {
        private readonly IVehicleRepository _vehicleRepository;

        public DeleteOrderCommandHandler(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async Task<bool> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            // Check if VehicleId exists
            var vehicle = await _vehicleRepository.GetByTrackingCodeAsync(request.TrackingCode);
            if (vehicle == null)
            {
                throw new ArgumentException($"Order with TrackingCode:{request.TrackingCode} not found");
            }
            vehicle.DeleteOrder(request.TrackingCode);
            _vehicleRepository.Update(vehicle);            
            return await _vehicleRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        }
    }
}
