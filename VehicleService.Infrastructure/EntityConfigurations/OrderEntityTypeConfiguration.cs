using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleService.Domain.AggregatesModel.OrderAggregate;

namespace VehicleService.Infrastructure.EntityConfigurations
{
    class OrderEntityTypeConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(x => x.Id);            
            builder.Property(x => x.TrackingCode).HasMaxLength(20).IsRequired();
            builder.HasIndex(x => x.TrackingCode).IsUnique();
            builder.Property(x => x.VehicleId).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.UpdatedAt).IsRequired();
            builder.Ignore(x => x.DomainEvents);
        }
    }
}
