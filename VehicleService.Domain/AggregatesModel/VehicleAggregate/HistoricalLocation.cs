using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleService.Domain.SeedWork;

namespace VehicleService.Domain.AggregatesModel.VehicleAggregate
{
    public class HistoricalLocation : Entity
    {
        public int VehicleId { get; private set; }
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public HistoricalLocation(int vehicleId, double latitude, double longitude)
        {
            VehicleId = vehicleId;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
