using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleService.Domain.AggregatesModel.VehicleAggregate;

namespace VehicleService.Domain.Events
{
    public class VehicleLocationUpdatedDomainEvent : INotification
    {
        public Vehicle Vehicle { get;  }
        public double PreviousLatitude { get; }
        public double PreviousLongitude { get; }

        public VehicleLocationUpdatedDomainEvent(Vehicle vehicle, double previousLatitude, double previousLongitude)
        {
            Vehicle = vehicle;
            PreviousLatitude = previousLatitude;
            PreviousLongitude = previousLongitude;
        }
    }
}
