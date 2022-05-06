using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleService.Domain.SeedWork;

namespace VehicleService.Domain.AggregatesModel.OrderAggregate
{
    public interface IOrderRepository : IRepository<Order>
    {
        Order Add(Order order);
        Order Update(Order order);
        void Delete(Order order);
        Task<Order> GetAsync(int orderId);
    }
}
