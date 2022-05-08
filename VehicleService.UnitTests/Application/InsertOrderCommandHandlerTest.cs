using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;
using VehicleService.API.Application.Commands.InsertOrder;
using VehicleService.Domain.AggregatesModel.VehicleAggregate;
using Xunit;

namespace VehicleService.UnitTests.Application
{
    public class InsertOrderCommandHandlerTest
    {
        [Fact]
        public async Task Handle_New_Order_Ok()
        {
            // Arrange
            var vehicleId = 1;
            var trackingCode = "X";
            var vehicleRepositoryStub = new Mock<IVehicleRepository>();
            vehicleRepositoryStub.Setup(x => x.GetAsync(vehicleId)).Returns(Task.FromResult(new Vehicle()));
            vehicleRepositoryStub.Setup(x => x.UnitOfWork.SaveEntitiesAsync(default(CancellationToken))).Returns(Task.FromResult(true));
            var insertOrderCommandHandler = new InsertOrderCommandHandler(vehicleRepositoryStub.Object);
            var command = new InsertOrderCommand(vehicleId, trackingCode);
            var cancelationToken = new System.Threading.CancellationToken();
            // Act
            var result = await insertOrderCommandHandler.Handle(command, cancelationToken);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task Handle_Not_Found_Vehicle_Throws_Exception()
        {
            // Arrange
            var vehicleId = 1;
            var trackingCode = "X";
            var vehicleRepositoryStub = new Mock<IVehicleRepository>();
            vehicleRepositoryStub.Setup(x => x.GetAsync(vehicleId)).Returns(Task.FromResult((Vehicle)null));
            vehicleRepositoryStub.Setup(x => x.UnitOfWork.SaveEntitiesAsync(default(CancellationToken))).Returns(Task.FromResult(true));
            var insertOrderCommandHandler = new InsertOrderCommandHandler(vehicleRepositoryStub.Object);
            var command = new InsertOrderCommand(vehicleId, trackingCode);
            var cancelationToken = new System.Threading.CancellationToken();
            // Act            
            // Assert
            await Assert.ThrowsAsync<ArgumentException>(() => insertOrderCommandHandler.Handle(command, cancelationToken));
        }
    }
}
