using System.Net.Http.Json;
using T = System.DateOnly;

namespace time_api.client.Facades;

public class DateFacade : IFacade
{
    const string group = "/date";

    private readonly HttpClient client;

    internal DateFacade(HttpClient client)
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
