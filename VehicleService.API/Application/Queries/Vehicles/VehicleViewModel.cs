using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleService.API.Application.Queries.Vehicles
{
    public record VehicleViewModel
    {
        public int Id { get; set; }
        public string  LicensePlate { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int NumOrders { get; set; }
        
    }
}
