using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VehicleService.Domain.Exceptions
{
    public class FullVehicleDomainException : Exception
    {
        public FullVehicleDomainException()
        {
        }

        public FullVehicleDomainException(string message) : base(message)
        {
        }

        public FullVehicleDomainException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FullVehicleDomainException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
