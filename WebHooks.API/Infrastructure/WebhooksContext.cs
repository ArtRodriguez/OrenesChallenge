using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHooks.API.Infrastructure.EntityConfigurations;
using WebHooks.API.Model;

namespace WebHooks.API.Infrastructure
{
    public class WebhooksContext : DbContext
    {
        public WebhooksContext(DbContextOptions<WebhooksContext> options) : base(options)
        {

        }
        public DbSet<WebhookSubscription> WebhookSubscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WebhookSubscriptionEntityConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
