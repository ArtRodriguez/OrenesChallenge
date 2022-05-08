using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VehicleService.Domain.AggregatesModel.VehicleAggregate;

namespace VehicleService.API.Application.Commands.UpdateVehicleLocation
{
    public class UpdateVehicleLocationCommandHandler : IRequestHandler<UpdateVehicleLocationCommand, bool>
    {
        private readonly IVehicleRepository _vehicleRepository;

        public UpdateVehicleLocationCommandHandler(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public async Task<bool> Handle(UpdateVehicleLocationCommand request, CancellationToken cancellationToken)
        {
            var vehicle = await _vehicleRepository.GetAsync(request.VehicleId);
            if (vehicle == null)
            {
                throw new ArgumentException($"Vehicle with Id:{request.VehicleId} not found");
            }
            vehicle.UpdateLocation(request.Latitude, request.Longitude);
            return await _vehicleRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        }
    }
}
