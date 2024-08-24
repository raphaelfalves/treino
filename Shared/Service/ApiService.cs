using Domain.Entities;
using Domain.Models;
using System.Net.Http.Json;

namespace Shared.Service;

public class ApiService(IHttpClientFactory httpClientFactory)
{
    private readonly HttpClient _client = httpClientFactory.CreateClient("Api");

    public async Task Register(UserCreateRequest registerRequest)
    {
        await _client.PostAsJsonAsync("/Register", registerRequest);
    }
}
