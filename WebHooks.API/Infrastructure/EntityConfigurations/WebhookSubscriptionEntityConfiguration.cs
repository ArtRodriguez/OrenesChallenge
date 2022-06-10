using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHooks.API.Model;

namespace WebHooks.API.Infrastructure.EntityConfigurations
{
    public class WebhookSubscriptionEntityConfiguration : IEntityTypeConfiguration<WebhookSubscription>
    {
        public void Configure(EntityTypeBuilder<WebhookSubscription> builder)
        {
            builder.ToTable("WebhookSubscriptions");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Date).IsRequired();
            builder.Property(x => x.DestUrl).HasMaxLength(2048).IsRequired();
            builder.Property(x => x.Token).HasMaxLength(2048).IsRequired();
            builder.Property(x => x.UserId).HasMaxLength(50).IsRequired();
        }
    }
}
