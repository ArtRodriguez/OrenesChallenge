using VehicleService.Domain.AggregatesModel.VehicleAggregate;
using VehicleService.Domain.Exceptions;
using Xunit;
using Moq;

namespace VehicleService.UnitTests.Domain
{
    public class VehicleAggregateTest
    {
        [Fact]
        public void UpdateLocation_NewLocation_Ok()
        {
            // Arrange                        
            var vehicle = new Vehicle(0, 0, 0, "");
            var numOrders = vehicle.HistoricalLocations?.Count ?? 0;
            var numDomainEvents = vehicle.DomainEvents?.Count ?? 0;
            // Act
            vehicle.UpdateLocation(1,1);
            // Assert
            Assert.Equal(numOrders + 1, vehicle.HistoricalLocations.Count);            
            Assert.Equal(numDomainEvents + 1, vehicle.DomainEvents.Count);
        }
        [Fact]
        public void UpdateLocation_SameLocation_NotUpdated()
        {
            // Arrange                        
            var vehicle = new Vehicle(0, 0, 0, "");
            var numOrders = vehicle.HistoricalLocations?.Count ?? 0;
            var numDomainEvents = vehicle.DomainEvents?.Count ?? 0;
            // Act
            vehicle.UpdateLocation(0, 0);
            // Assert
            Assert.Equal(numOrders, vehicle.HistoricalLocations?.Count ?? 0);
            Assert.Equal(numDomainEvents, vehicle.DomainEvents?.Count ?? 0);
        }
        [Fact]
        public void AddOrder_NewOrder_Ok()
        {
            // Arrange            
            var vehicle = new Vehicle();
            var numOrders = vehicle.Orders?.Count ?? 0;
            // Act
            vehicle.AddOrder("0");
            // Assert
            Assert.Equal(numOrders + 1, vehicle.Orders.Count);
        }
        [Fact]
        public void AddOrder_FullVehicle_ThrowsException()
        {
            // Arrange            
            var vehicleStub = new Mock<Vehicle>();
            vehicleStub.Setup(x => x.MaxCapacityReached()).Returns(true);
            var vehicle = vehicleStub.Object;
            // Act - Assert
            Assert.Throws<FullVehicleDomainException>(() => vehicle.AddOrder("LastOrder"));
        }
    }
}
