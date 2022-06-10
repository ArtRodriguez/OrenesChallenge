using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebHooks.API.Model
{
    public class WebhookSubscription
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string DestUrl { get; set; }
        public string Token { get; set; }
        public string UserId { get; set; }
    }
}
