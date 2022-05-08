using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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
            builder.HasIndex(x => x.LicensePlate).IsUnique();
            builder.Property(x => x.Latitude).IsRequired();
            builder.Property(x => x.Longitude).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.UpdatedAt).IsRequired();

            builder.HasMany(x => x.HistoricalLocations).WithOne().HasForeignKey(x => x.VehicleId).IsRequired();
            builder.HasMany(x => x.Orders).WithOne().HasForeignKey(x => x.VehicleId).IsRequired();
        }
    }
}
