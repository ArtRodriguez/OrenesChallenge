using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientAppMvc.Models
{
    public record OrderDto
    {
        public int VehicleId { get; set; }
        public string LicensePlate { get; set; }
        public string TrackingCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
