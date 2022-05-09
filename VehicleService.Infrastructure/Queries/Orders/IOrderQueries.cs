using System.Threading.Tasks;

namespace VehicleService.Infrastructure.Queries.Orders
{
    public interface IOrderQueries
    {
        Task<OrderDto> GetOrderByTrackingCodeAsync(string trackingCode);
    }
}