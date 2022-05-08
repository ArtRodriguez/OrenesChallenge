using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VehicleService.Domain.AggregatesModel.OrderAggregate;
using VehicleService.Domain.AggregatesModel.VehicleAggregate;

namespace VehicleService.API.Application.Commands.DeleteOrder
{
    public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand, bool>
    {
        private readonly IOrderRepository _orderRepository;

        public DeleteOrderCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<bool> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
        {
            // Check if VehicleId exists
            var order = await _orderRepository.GetByTrackingCodeAsync(request.TrackingCode);
            if (order == null)
            {
                throw new ArgumentException($"Order with TrackingCode:{request.TrackingCode} not found");
            }
            _orderRepository.Delete(order);            
            return await _orderRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        }
    }
}
