using Domain.Entities;
using System.Net.Http.Json;

namespace Shared.Service
{
    public class TrainingService(IHttpClientFactory httpClientFactory)
    {
        private readonly HttpClient _client = httpClientFactory.CreateClient("Api");

        public async Task Create(Training Training)
        {
            await _client.PostAsJsonAsync("/Training", Training);
        }
    }
}
