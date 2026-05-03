using System.Net.Http.Json;
using T = System.DateOnly;

namespace time_api.client.Facades;

public class DateFacade(HttpClient client) : IFacade
{
    private const string group = "/date";

    public Task<T> GetAsync(CancellationToken cancellationToken = default)
        => client.GetFromJsonAsync<T>($"{group}/", cancellationToken);

    public Task<T> GetLocalAsync(CancellationToken cancellationToken = default)
        => client.GetFromJsonAsync<T>($"{group}/local", cancellationToken);

    public Task<T> GetUtcAsync(CancellationToken cancellationToken = default)
        => client.GetFromJsonAsync<T>($"{group}/utc", cancellationToken);
}
