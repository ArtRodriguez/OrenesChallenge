using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;

namespace VehicleService.API.Application.Queries.Vehicles
{
    public class VehicleQueries : IVehicleQueries
    {
        private readonly string _connectionString;

        public VehicleQueries(string connectionString)
        {
            _connectionString = !string.IsNullOrWhiteSpace(connectionString) ? connectionString : throw new ArgumentNullException(nameof(connectionString)); ;
        }

        public async Task<IEnumerable<VehicleViewModel>> GetVehiclesAsync()
        {
            string query = @"with numOrders as (
									select
										VehicleId
										,count(*) as NumOrders
									from
										Orders
									group by
										VehicleId
								)

								select
									Id
									,LicensePlate
									,Latitude
									,Longitude
									,ISNULL(NumOrders,0) as NumOrders
								from
									Vehicles v
									left join numOrders n on n.VehicleId = v.Id";
            using (var connection = new SqlConnection(_connectionString))
            {
				return await connection.QueryAsync<VehicleViewModel>(query);
            }            
        }
    }
}
