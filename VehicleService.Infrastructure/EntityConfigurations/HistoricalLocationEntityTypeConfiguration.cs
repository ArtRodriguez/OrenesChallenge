using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleService.Domain.AggregatesModel.VehicleAggregate;

namespace VehicleService.Infrastructure.EntityConfigurations
{
    public class HistoricalLocationEntityTypeConfiguration : IEntityTypeConfiguration<HistoricalLocation>
    {
        public void Configure(EntityTypeBuilder<HistoricalLocation> builder)
        {
            builder.ToTable("HistoricalLocations");
            builder.HasKey(x => x.Id);            
            builder.Ignore(x => x.DomainEvents);
            builder.Property(x => x.Latitude).IsRequired();
            builder.Property(x => x.Longitude).IsRequired();
            builder.Property(x => x.VehicleId).IsRequired();
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.UpdatedAt).IsRequired();
        }
    }
}
