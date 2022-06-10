using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VehicleService.API.Application.IntegrationEvents;
using VehicleService.Infrastructure;

namespace VehicleService.API.Application.Behaviors
{
    public class TransactionBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        private readonly ILogger<TransactionBehaviour<TRequest, TResponse>> _logger;
        private readonly VehicleServiceContext _vehicleServiceContext;
        private readonly IVehicleServiceIntegrationEventService _vehicleServiceIntegrationEventService;

        public TransactionBehaviour(
            ILogger<TransactionBehaviour<TRequest, TResponse>> logger, 
            VehicleServiceContext vehicleServiceContext, 
            IVehicleServiceIntegrationEventService vehicleServiceIntegrationEventService)
        {
            _logger = logger;
            _vehicleServiceContext = vehicleServiceContext;
            _vehicleServiceIntegrationEventService = vehicleServiceIntegrationEventService;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            try
            {
                var response = default(TResponse);
                if (_vehicleServiceContext.HasActiveTransaction)
                {
                    return await next();
                }
                var strategy = _vehicleServiceContext.Database.CreateExecutionStrategy();
                await strategy.ExecuteAsync(async () =>
                {
                    Guid transactionId;
                    using (var transaction = await _vehicleServiceContext.BeginTransactionAsync())
                    {
                        _logger.LogInformation("----- Begin transaction {TransactionId}", transaction.TransactionId);

                        response = await next();

                        _logger.LogInformation("----- Commit transaction {TransactionId} ", transaction.TransactionId);

                        await _vehicleServiceContext.CommitTransactionAsync(transaction);

                        transactionId = transaction.TransactionId;
                    }
                    await _vehicleServiceIntegrationEventService.PublishEventsThroughEventBusAsync(transactionId);
                });
                return response;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
