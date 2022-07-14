using Moq;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using VehicleService.API.Application.Commands.DeleteOrder;
using VehicleService.Domain.AggregatesModel.OrderAggregate;
using VehicleService.Domain.AggregatesModel.VehicleAggregate;
using Xunit;

namespace VehicleService.UnitTests.Application
{
    public class DeleteOrderCommandHandlerTest
    {

        [Fact]
        public async Task Handle_Existing_Order_Ok()
        {
            // Arrange
            var trackingCode = "X";
            var vehicleRepositoryStub = new Mock<IVehicleRepository>();
            var vehicleStub = new Vehicle();
            vehicleStub.AddOrder(trackingCode);
            vehicleRepositoryStub.Setup(x => x.GetByTrackingCodeAsync(trackingCode)).Returns(Task.FromResult(vehicleStub));
            vehicleRepositoryStub.Setup(x => x.UnitOfWork.SaveEntitiesAsync(default(CancellationToken))).Returns(Task.FromResult(true));
            var deleteOrderCommandHandler = new DeleteOrderCommandHandler(vehicleRepositoryStub.Object);
            var command = new DeleteOrderCommand(trackingCode);
            var cancelationToken = new System.Threading.CancellationToken();
            // Act
            var result = await deleteOrderCommandHandler.Handle(command, cancelationToken);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public async Task Handle_Not_Found_Order_Throws_Exception()
        {
            // Arrange
            var trackingCode = "X";
            var orderRepositoryStub = new Mock<IVehicleRepository>();
            orderRepositoryStub.Setup(x => x.GetByTrackingCodeAsync(trackingCode)).Returns(Task.FromResult((Vehicle)null));
            orderRepositoryStub.Setup(x => x.UnitOfWork.SaveEntitiesAsync(default(CancellationToken))).Returns(Task.FromResult(true));
            var deleteOrderCommandHandler = new DeleteOrderCommandHandler(orderRepositoryStub.Object);
            var command = new DeleteOrderCommand(trackingCode);
            var cancelationToken = new System.Threading.CancellationToken();
            // Act            
            // Assert
            await Assert.ThrowsAsync<ArgumentException>(() => deleteOrderCommandHandler.Handle(command, cancelationToken));
        }
    }
}
