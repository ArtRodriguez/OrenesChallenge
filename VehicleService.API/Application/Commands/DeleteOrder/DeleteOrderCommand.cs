using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VehicleService.API.Application.Commands.DeleteOrder
{
    public class DeleteOrderCommand : IRequest<bool>
    {
        [DataMember]
        [Required]
        public string TrackingCode { get; set; }

        public DeleteOrderCommand(string trackingCode)
        {
            TrackingCode = trackingCode;
        }
    }
}
