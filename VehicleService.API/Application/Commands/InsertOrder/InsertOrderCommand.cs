using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VehicleService.API.Application.Commands.InsertOrder
{
    public class InsertOrderCommand : IRequest<bool>
    {
        public InsertOrderCommand(int vehicleId, string trackingCode)
        {
            VehicleId = vehicleId;
            TrackingCode = trackingCode;
        }

        [DataMember]
        [Required]
        public int VehicleId { get; set; }
        [DataMember]
        [Required]
        [MaxLength(20)]
        public string TrackingCode { get; set; }
    }
}
