using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleService.Domain.SeedWork;

namespace VehicleService.Domain.AggregatesModel.OrderAggregate
{    
    public class Order : Entity, IAggregateRoot
    {
        public int VehicleId { get; private set;  }
        public string TrackingCode { get; private set; }
        public Order(int vehicleId, string trackingCode)
        {
            VehicleId = vehicleId;
            TrackingCode = trackingCode;
        }
    }
}
