using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClientAppMvc.Models
{    
    public class UpdateLocationRequest
    {
        public UpdateLocationRequest()
        {

        }
        public UpdateLocationRequest(int VehicleId, double latitude, double longitude)
        {
            this.VehicleId = VehicleId;
            Latitude = latitude;
            Longitude = longitude;
        }        
        [Required]
        public int VehicleId { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
    }
}
