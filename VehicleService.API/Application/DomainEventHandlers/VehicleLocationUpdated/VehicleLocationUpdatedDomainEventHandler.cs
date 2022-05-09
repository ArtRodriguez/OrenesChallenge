using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VehicleService.Domain.Events;

namespace VehicleService.API.Application.DomainEventHandlers.VehicleLocationUpdated
{
    public class VehicleLocationUpdatedDomainEventHandler : INotificationHandler<VehicleLocationUpdatedDomainEvent>
    {
        private readonly ILogger<VehicleLocationUpdatedDomainEventHandler> _logger;

        public VehicleLocationUpdatedDomainEventHandler(ILogger<VehicleLocationUpdatedDomainEventHandler> logger)
        {
            _logger = logger;
        }

        public async Task Handle(VehicleLocationUpdatedDomainEvent notification, CancellationToken cancellationToken)
        {
            // ToDo: Send integration event to communicate a location change
            _logger.LogInformation($"Location of Vehicle {notification.Vehicle.Id} updated to {notification.Vehicle.Latitude}:{notification.Vehicle.Longitude}");            
        }
    }
}
