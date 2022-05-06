using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VehicleService.API.Application.Queries.Orders
{
    public record OrderViewModel
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public string TrackingCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
