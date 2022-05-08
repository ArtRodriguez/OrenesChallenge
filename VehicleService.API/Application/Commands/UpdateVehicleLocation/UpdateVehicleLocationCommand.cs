using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VehicleService.API.Application.Commands.UpdateVehicleLocation
{
    public class UpdateVehicleLocationCommand : IRequest<bool>
    {
        public UpdateVehicleLocationCommand(int VehicleId, double latitude, double longitude)
        {
            this.VehicleId = VehicleId;
            Latitude = latitude;
            Longitude = longitude;
        }
        [DataMember]
        public int VehicleId { get; set; }
        [DataMember]
        public double Latitude { get; set; }
        [DataMember]
        public double Longitude { get; set; }
        
    }
}
