using System.Net.Http.Json;
using T = System.DateTimeOffset;

namespace time_api.client.Facades;

public class DateTimeOffsetFacade : IFacade
{
    const string group = "/datetimeoffset";

    private readonly HttpClient client;

    internal DateTimeOffsetFacade(HttpClient client)
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