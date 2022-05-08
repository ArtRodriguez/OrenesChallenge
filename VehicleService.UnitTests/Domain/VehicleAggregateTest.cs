using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleService.Domain.AggregatesModel.VehicleAggregate;
using VehicleService.Domain.Exceptions;
using Xunit;

namespace VehicleService.UnitTests.Domain
{
    public class VehicleAggregateTest
    {
        [Fact]
        public void AddOrder_FullVehicle_ThrowsException()
        {
            var vehicle = new Vehicle();
            for (int i = 0; i < 50; i++)
            {
                vehicle.AddOrder($"o{i}");
            }
            Assert.Throws<FullVehicleDomainException>(() => vehicle.AddOrder("LastOrder"));
        }
    }
}
