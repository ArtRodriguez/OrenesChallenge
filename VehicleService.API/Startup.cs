using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleService.API.Infrastructure.AutofacModules;
using VehicleService.Domain.AggregatesModel.OrderAggregate;
using VehicleService.Domain.AggregatesModel.VehicleAggregate;
using VehicleService.Infrastructure;
using VehicleService.Infrastructure.Repositories;

namespace VehicleService.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {            
            // Database
            services.AddDbContext<VehicleServiceContext>(opt => opt.UseSqlServer(GetConnectionString()));

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "VehicleService.API", Version = "v1" });
            });

            services.AddTransient<IVehicleRepository, VehicleRepository>();            
            services.AddTransient<IOrderRepository, OrderRepository>();
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {           
            builder.RegisterModule(new MediatorModule());
            builder.RegisterModule(new ApplicationModule(GetConnectionString()));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, VehicleServiceContext context)
        {
            context.Database.Migrate();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "VehicleService.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private string GetConnectionString()
        {
            const string DB_ENV = "ConnectionString";
            string connectionString = Environment.GetEnvironmentVariable(DB_ENV);

            if (connectionString == null)
            {
                connectionString = Configuration.GetConnectionString("DefaultConnection");
            }
            return connectionString;
        }
    }
}
