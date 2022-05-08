using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClientAppMvc.Models
{
    public class InsertOrderRequest
    {
        [Required]
        public int VehicleId { get; set; }
        [Required]
        [MaxLength(20)]
        public string TrackingCode { get; set; }
    }
}
