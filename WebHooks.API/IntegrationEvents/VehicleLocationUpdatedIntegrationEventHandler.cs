using EventBus.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebHooks.API.IntegrationEvents
{
    public class VehicleLocationUpdatedIntegrationEventHandler : IIntegrationEventHandler<VehicleLocationUpdatedIntegrationEvent>
    {
        private readonly ILogger<VehicleLocationUpdatedIntegrationEventHandler> _logger;

        public VehicleLocationUpdatedIntegrationEventHandler(ILogger<VehicleLocationUpdatedIntegrationEventHandler> logger)
        {
            _logger = logger;
        }

        public async Task Handle(VehicleLocationUpdatedIntegrationEvent integrationEvent)
        {
            _logger.LogInformation("Received VehicleLocationUpdatedIntegrationEventHandler");
        }
    }
}
