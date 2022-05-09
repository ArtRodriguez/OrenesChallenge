using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using VehicleService.API.Application.Commands.InsertOrder;
using VehicleService.API.Controllers;
using VehicleService.Infrastructure.Queries.Orders;
using Xunit;

namespace VehicleService.UnitTests.Controllers
{
    public class OrdersControllerTest
    {
        [Fact]
        public async Task Post_Handler_Returns_True_Ok()
        {
            // Arrange
            var mediatorStub = new Mock<IMediator>();
            var loggerStub = new Mock<ILogger<OrdersController>>();
            var orderQueriesStub = new Mock<IOrderQueries>();
            mediatorStub
                .Setup(x => x.Send(It.IsAny<IRequest<bool>>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(true));
            var ordersController = new OrdersController(loggerStub.Object, mediatorStub.Object, orderQueriesStub.Object);
            // Act
            var result = await ordersController.Post(new InsertOrderCommand(0, "X"));
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public async Task Post_Handler_Returns_False_BadRequest()
        {
            // Arrange
            var mediatorStub = new Mock<IMediator>();
            var loggerStub = new Mock<ILogger<OrdersController>>();
            var orderQueriesStub = new Mock<IOrderQueries>();
            mediatorStub
                .Setup(x => x.Send(It.IsAny<IRequest<bool>>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(false));
            var ordersController = new OrdersController(loggerStub.Object, mediatorStub.Object, orderQueriesStub.Object);
            // Act
            var result = await ordersController.Post(new InsertOrderCommand(0, "X"));
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task Delete_Handler_Returns_True_Ok()
        {
            // Arrange
            var mediatorStub = new Mock<IMediator>();
            var loggerStub = new Mock<ILogger<OrdersController>>();
            var orderQueriesStub = new Mock<IOrderQueries>();
            mediatorStub
                .Setup(x => x.Send(It.IsAny<IRequest<bool>>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(true));
            var ordersController = new OrdersController(loggerStub.Object, mediatorStub.Object, orderQueriesStub.Object);
            // Act
            var result = await ordersController.Delete("X");
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public async Task Delete_Handler_Returns_False_BadRequest()
        {
            // Arrange
            var mediatorStub = new Mock<IMediator>();
            var loggerStub = new Mock<ILogger<OrdersController>>();
            var orderQueriesStub = new Mock<IOrderQueries>();
            mediatorStub
                .Setup(x => x.Send(It.IsAny<IRequest<bool>>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(false));
            var ordersController = new OrdersController(loggerStub.Object, mediatorStub.Object, orderQueriesStub.Object);
            // Act
            var result = await ordersController.Delete("X");
            Assert.IsType<BadRequestResult>(result);
        }
    }
}
