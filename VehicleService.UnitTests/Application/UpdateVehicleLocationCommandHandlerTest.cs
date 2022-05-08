using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;
using VehicleService.API.Application.Commands.UpdateVehicleLocation;
using VehicleService.Domain.AggregatesModel.VehicleAggregate;
using Xunit;

namespace VehicleService.UnitTests.Application
{
    public class UpdateVehicleLocationCommandHandlerTest
    {
        [Fact]
        public async Task Handle_New_Location_Ok()
        {
            // Arrange
            int vehicleId = 1;
            double latitude = 1;
            double longitude = 1;
            var vehicleRepositoryStub = new Mock<IVehicleRepository>();
            vehicleRepositoryStub.Setup(x => x.GetAsync(vehicleId)).Returns(Task.FromResult(new Vehicle()));
            vehicleRepositoryStub.Setup(x => x.UnitOfWork.SaveEntitiesAsync(default(CancellationToken))).Returns(Task.FromResult(true));
            var updateVehicleLocationCommandHandler = new UpdateVehicleLocationCommandHandler(vehicleRepositoryStub.Object);
            var command = new UpdateVehicleLocationCommand(vehicleId, latitude, longitude);
            var cancelationToken = new System.Threading.CancellationToken();
            // Act
            var result = await updateVehicleLocationCommandHandler.Handle(command, cancelationToken);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task Handle_Not_Found_Vehicle_Throws_Exception()
        {
            // Arrange
            int vehicleId = 1;
            double latitude = 1;
            double longitude = 1;
            var vehicleRepositoryStub = new Mock<IVehicleRepository>();
            vehicleRepositoryStub.Setup(x => x.GetAsync(vehicleId)).Returns(Task.FromResult((Vehicle)null));
            vehicleRepositoryStub.Setup(x => x.UnitOfWork.SaveEntitiesAsync(default(CancellationToken))).Returns(Task.FromResult(true));
            var updateVehicleLocationCommandHandler = new UpdateVehicleLocationCommandHandler(vehicleRepositoryStub.Object);
            var command = new UpdateVehicleLocationCommand(vehicleId, latitude, longitude);
            var cancelationToken = new System.Threading.CancellationToken();
            // Act            
            // Assert
            await Assert.ThrowsAsync<ArgumentException>(() => updateVehicleLocationCommandHandler.Handle(command, cancelationToken));
        }
    }
}
