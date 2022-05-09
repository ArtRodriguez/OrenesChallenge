using System;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;

namespace VehicleService.Infrastructure.Queries.Orders
{
    public class OrderQueries : IOrderQueries
    {
        private readonly string _connectionString;

        public OrderQueries(string connectionString)
        {
            _connectionString = !string.IsNullOrWhiteSpace(connectionString) ? connectionString : throw new ArgumentNullException(nameof(connectionString)); ;
        }
        public async Task<OrderDto> GetOrderByTrackingCodeAsync(string trackingCode)
        {
            string query = @"select
								o.Id as OrderId
								,v.Id as VehicleId
								,v.LicensePlate
								,o.TrackingCode
								,v.Latitude
								,v.Longitude
							from
								Orders o
								inner join Vehicles v on v.Id = o.VehicleId
							where
								o.TrackingCode = @TrackingCode";
            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.QuerySingleAsync<OrderDto>(query, new { TrackingCode = trackingCode });
            }
        }
    }
}
