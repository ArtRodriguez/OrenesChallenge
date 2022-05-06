using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleService.Domain.AggregatesModel.OrderAggregate;
using VehicleService.Domain.SeedWork;

namespace VehicleService.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly VehicleServiceContext _context;
        public IUnitOfWork UnitOfWork => _context;
        public OrderRepository(VehicleServiceContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Order Add(Order order)
        {
            if (order.IsTransient())
            {
                return _context.Orders.Add(order).Entity;
            }
            return order;
        }

        public void Delete(Order order)
        {
            _context.Orders.Remove(order);
        }

        public async Task<Order> GetAsync(int orderId)
        {
            return await _context.Orders.FindAsync(orderId);
        }

        public Order Update(Order order)
        {
            return _context.Orders.Update(order).Entity;
        }
    }
}
