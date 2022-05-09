using System.Threading.Tasks;
using Xunit;
using Moq;
using MediatR;
using System.Threading;
using Microsoft.Extensions.Logging;
using VehicleService.API.Controllers;
using VehicleService.Infrastructure.Queries.Vehicles;
using VehicleService.API.Application.Commands.UpdateVehicleLocation;
using Microsoft.AspNetCore.Mvc;

namespace VehicleService.UnitTests.Controllers
{
    public class VehiclesControllerTest
    {
        [Fact]
        public async Task UpdateVehicleLocation_Handler_Returns_True_Ok()
        {
            // Arrange
            var mediatorStub = new Mock<IMediator>();
            var loggerStub = new Mock<ILogger<VehiclesController>>();
            var vehicleQueriesStub = new Mock<IVehicleQueries>();
            mediatorStub
                .Setup(x => x.Send(It.IsAny<IRequest<bool>>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(true));
            var vehiclesController = new VehiclesController(loggerStub.Object, mediatorStub.Object, vehicleQueriesStub.Object);
            // Act
            var result = await vehiclesController.UpdateVehicleLocation(new UpdateVehicleLocationCommand(0, 0, 0));
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public async Task UpdateVehicleLocation_Handler_Returns_False_BadRequest()
        {
            // Arrange
            var mediatorStub = new Mock<IMediator>();
            var loggerStub = new Mock<ILogger<VehiclesController>>();
            var vehicleQueriesStub = new Mock<IVehicleQueries>();
            mediatorStub
                .Setup(x => x.Send(It.IsAny<IRequest<bool>>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(false));
            var vehiclesController = new VehiclesController(loggerStub.Object, mediatorStub.Object, vehicleQueriesStub.Object);
            // Act
            var result = await vehiclesController.UpdateVehicleLocation(new UpdateVehicleLocationCommand(0, 0, 0));
            Assert.IsType<BadRequestResult>(result);
        }
    }
}
