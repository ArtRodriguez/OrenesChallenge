using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleService.Infrastructure.Queries.Orders;
using VehicleService.Infrastructure.Queries.Vehicles;

namespace VehicleService.API.Infrastructure.AutofacModules
{
    public class ApplicationModule : Autofac.Module
    {
        public string QueriesConnectionString { get; }

        public ApplicationModule(string queriesConnectionString)
        {
            QueriesConnectionString = queriesConnectionString;

        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new VehicleQueries(QueriesConnectionString)).As<IVehicleQueries>().InstancePerLifetimeScope();
            builder.Register(c => new OrderQueries(QueriesConnectionString)).As<IOrderQueries>().InstancePerLifetimeScope();
        }
    }
}
