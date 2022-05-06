using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using VehicleService.Domain.AggregatesModel.OrderAggregate;
using VehicleService.Domain.AggregatesModel.VehicleAggregate;

namespace VehicleService.Infrastructure.EntityConfigurations
{
    class VehicleEntityTypeConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.ToTable("Vehicles");
            builder.HasKey(x => x.Id);            
            builder.Ignore(x => x.DomainEvents);
            builder.Property(x => x.LicensePlate).HasMaxLength(10).IsRequired();
            builder.Property(x => x.Latitude).IsRequired();
            builder.Property(x => x.Longitude).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.UpdatedAt).IsRequired();

            builder.HasMany<HistoricalLocation>().WithOne().HasForeignKey(x => x.VehicleId);
            builder.HasMany<Order>().WithOne().HasForeignKey(x => x.VehicleId);
        }
    }
}
