using System.Threading.Tasks;

namespace VehicleService.API.Application.Queries.Orders
{
    public interface IOrderQueries
    {
        Task<OrderViewModel> GetOrderByTrackingCodeAsync(string trackingCode);
    }
}