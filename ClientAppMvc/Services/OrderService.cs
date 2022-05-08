using ClientAppMvc.Models;
using IdentityModel.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClientAppMvc.Services
{
    public class OrderService : IOrderService
    {
        private readonly ITokenService _tokenService;

        public OrderService(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }
        public async Task DeleteOrderAsync(string trackingCode)
        {
            using (var client = new HttpClient())
            {
                var tokenResponse = await _tokenService.GetToken("vehicleservice.write");
                client.SetBearerToken(tokenResponse.AccessToken);

                var result = await client.DeleteAsync($"http://vehicleservice.api/api/v1/Orders/{trackingCode}");
                if (result.IsSuccessStatusCode)
                {
                    return;                  
                }
            }
            throw new Exception("Unable to retrieve the data");
        }

        public async Task<OrderDto> GetAsync(string trackingCode)
        {
            using (var client = new HttpClient())
            {
                var tokenResponse = await _tokenService.GetToken("vehicleservice.read");
                client.SetBearerToken(tokenResponse.AccessToken);

                var result = await client.GetAsync($"http://vehicleservice.api/api/v1/Orders/{trackingCode}");
                if (result.IsSuccessStatusCode)
                {
                    var model = await result.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<OrderDto>(model);
                    return data;
                }
            }
            throw new Exception("Unable to retrieve the data");
        }

        public async Task InsertOrderAsync(InsertOrderRequest request)
        {
            using (var client = new HttpClient())
            {
                var tokenResponse = await _tokenService.GetToken("vehicleservice.write");
                client.SetBearerToken(tokenResponse.AccessToken);

                var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

                var result = await client.PostAsync("http://vehicleservice.api/api/v1/Orders", content);
                if (result.IsSuccessStatusCode)
                {
                    return;
                }
            }
            throw new Exception("Unable to retrieve the data");
        }
    }
}
