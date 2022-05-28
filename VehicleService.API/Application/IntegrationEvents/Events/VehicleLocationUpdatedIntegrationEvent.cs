using EventBus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleService.API.Application.IntegrationEvents.Events
{
    public record VehicleLocationUpdatedIntegrationEvent : IntegrationEvent
    {
        public int VehicleId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public IEnumerable<string> TrackingCodes { get; set; }
        public VehicleLocationUpdatedIntegrationEvent(int vehicleId, double latitude, double longitude, IEnumerable<string> trackingCodes) : base()
        {
            VehicleId = vehicleId;
            Latitude = latitude;
            Longitude = longitude;
            TrackingCodes = trackingCodes;
        }
    }
}
