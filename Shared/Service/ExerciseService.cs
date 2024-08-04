using Domain.Entities;
using System.Net.Http.Json;

namespace Shared.Service
{
    public class ExerciseService(IHttpClientFactory httpClientFactory)
    {
        private readonly HttpClient _client = httpClientFactory.CreateClient("Api");

        public async Task Create(Exercise exercise)
        {
            await _client.PostAsJsonAsync("/Exercise", exercise);
        }

        public async Task<List<Exercise>> GetAllAsync()
        {
            return await _client.GetFromJsonAsync<List<Exercise>>("/Exercise") ?? [];
        }
    }
}
