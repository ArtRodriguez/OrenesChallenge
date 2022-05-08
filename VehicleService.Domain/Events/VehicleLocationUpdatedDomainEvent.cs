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

        public VehicleLocationUpdatedDomainEvent(Vehicle vehicle)
        {
            Vehicle = vehicle;
        }
    }
}
