using System.Net.Http.Json;
using T = System.TimeOnly;

namespace time_api.client.Facades;

public class TimeFacade : IFacade
{
    const string group = "/time";

    private readonly HttpClient client;

    internal TimeFacade(HttpClient client)
    {
        this.client = client;
    }

    public Task<T> GetAsync(CancellationToken cancellationToken = default)
        => client.GetFromJsonAsync<T>($"{group}/", cancellationToken);
    public Task<T> GetLocalAsync(CancellationToken cancellationToken = default)
        => client.GetFromJsonAsync<T>($"{group}/local", cancellationToken);
    public Task<T> GetUtcAsync(CancellationToken cancellationToken = default)
        => client.GetFromJsonAsync<T>($"{group}/utc", cancellationToken);
}
