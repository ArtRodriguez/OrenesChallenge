using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VehicleService.API.Application.IntegrationEvents;
using VehicleService.API.Application.IntegrationEvents.Events;
using VehicleService.Domain.Events;

namespace VehicleService.API.Application.DomainEventHandlers.VehicleLocationUpdated
{
    public class VehicleLocationUpdatedDomainEventHandler : INotificationHandler<VehicleLocationUpdatedDomainEvent>
    {
        private readonly ILogger<VehicleLocationUpdatedDomainEventHandler> _logger;
        private readonly IVehicleServiceIntegrationEventService _vehicleServiceIntegrationEventService;

        public VehicleLocationUpdatedDomainEventHandler(ILogger<VehicleLocationUpdatedDomainEventHandler> logger, IVehicleServiceIntegrationEventService vehicleServiceIntegrationEventService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _vehicleServiceIntegrationEventService = vehicleServiceIntegrationEventService;
        }

        public async Task Handle(VehicleLocationUpdatedDomainEvent notification, CancellationToken cancellationToken)
        {            
            var integrationEvent = new VehicleLocationUpdatedIntegrationEvent(
                notification.Vehicle.Id,
                notification.Vehicle.Latitude,
                notification.Vehicle.Longitude,
                notification.Vehicle.Orders.Select(x => x.TrackingCode)
                ); 
            await _vehicleServiceIntegrationEventService.AddAndSaveEventAsync(integrationEvent);
            _logger.LogInformation($"Location of Vehicle {notification.Vehicle.Id} updated to {notification.Vehicle.Latitude}:{notification.Vehicle.Longitude}");            
        }
    }
}
