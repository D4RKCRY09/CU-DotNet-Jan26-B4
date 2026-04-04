using System.Net.Http.Headers;
using System.Text.Json;
using VagaBondTravelAPI.Models;

namespace TravelFrontend.Services
{
    public class TravelAPIService : ITravelAPIService
    {
        private readonly HttpClient _client;

        public TravelAPIService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<Destination>> GetAllAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "api/Destinations/GetAll")
            {
            };

            var reponse = await _client.SendAsync(request);

            var destinations = await reponse.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<Destination>>(destinations,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
