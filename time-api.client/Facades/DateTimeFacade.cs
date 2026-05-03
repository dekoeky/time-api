using System.Net.Http.Json;
using T = System.DateTime;

namespace time_api.client.Facades;

public class DateTimeFacade(HttpClient client) : IFacade
{
    private const string group = "/datetime";

    public Task<T> GetAsync(CancellationToken cancellationToken = default)
        => client.GetFromJsonAsync<T>($"{group}/", cancellationToken);

    public Task<T> GetLocalAsync(CancellationToken cancellationToken = default)
        => client.GetFromJsonAsync<T>($"{group}/local", cancellationToken);

    public Task<T> GetUtcAsync(CancellationToken cancellationToken = default)
        => client.GetFromJsonAsync<T>($"{group}/utc", cancellationToken);
}
