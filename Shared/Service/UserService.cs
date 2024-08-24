using Domain.Entities;
using System.Net.Http.Json;

namespace Shared.Service;

public class UserService(IHttpClientFactory httpClientFactory)
{
    private readonly HttpClient _client = httpClientFactory.CreateClient("Api");

    public async Task Create(User user)
    {
        var result = await _client.PostAsJsonAsync("/User", user);
        var content = await result.Content.ReadAsStringAsync();
    }

    public async Task Update(User user)
    {
        await _client.PutAsJsonAsync("/User", user);
    }
}
