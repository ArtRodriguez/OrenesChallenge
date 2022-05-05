using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;
using VehicleService.Domain.SeedWork;

namespace VehicleService.Infrastructure
{
    public class VehicleServiceContext : DbContext, IUnitOfWork
    {
        public Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
