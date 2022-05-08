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
    public class VehicleService : IVehicleService
    {
        private readonly ITokenService _tokenService;

        public VehicleService(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        public async Task<IEnumerable<VehicleDto>> GetVehicles()
        {
            using (var client = new HttpClient())
            {
                var tokenResponse = await _tokenService.GetToken("vehicleservice.read");
                client.SetBearerToken(tokenResponse.AccessToken);

                var result = await client.GetAsync("http://vehicleservice.api/api/v1/Vehicles");
                if (result.IsSuccessStatusCode)
                {
                    var model = await result.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<IEnumerable<VehicleDto>>(model);
                    return data;
                }
            }
            throw new Exception("Unable to retrieve the data");
        }

        public async Task UpdateLocation(int vehicleId, double latitude, double longitude)
        {
            var request = new UpdateLocationRequest(vehicleId, latitude, longitude);
            await UpdateLocation(request);
        }

        public async Task UpdateLocation(UpdateLocationRequest request)
        {
            using (var client = new HttpClient())
            {
                var tokenResponse = await _tokenService.GetToken("vehicleservice.write");
                client.SetBearerToken(tokenResponse.AccessToken);

                var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

                var result = await client.PutAsync("http://vehicleservice.api/api/v1/Vehicles/Location", content);
                if (result.IsSuccessStatusCode)
                {
                    return;
                }
            }
            throw new Exception("Unable to retrieve the data");
        }
    }
}
