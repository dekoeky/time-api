using System.Net.Http.Json;

namespace time_api.client.Facades;

public class TimeFacade(HttpClient client) : IFacade
{
    const string group = "/time";

    public Task<TimeOnly> GetAsync(CancellationToken cancellationToken = default)
        => client.GetFromJsonAsync<TimeOnly>($"{group}/", cancellationToken);

    public Task<TimeOnly> GetLocalAsync(CancellationToken cancellationToken = default)
        => client.GetFromJsonAsync<TimeOnly>($"{group}/local", cancellationToken);

    public Task<TimeOnly> GetUtcAsync(CancellationToken cancellationToken = default)
        => client.GetFromJsonAsync<TimeOnly>($"{group}/utc", cancellationToken);
}
