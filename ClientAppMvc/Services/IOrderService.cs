using ClientAppMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientAppMvc.Services
{
    public interface IOrderService
    {
        Task InsertOrderAsync(InsertOrderRequest request);
        Task DeleteOrderAsync(string trackingCode);
        Task<OrderDto> GetAsync(string trackingCode);
    }
}
