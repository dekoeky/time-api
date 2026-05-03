using System.Net.Http.Json;

namespace time_api.client.Facades;

public class DateTimeOffsetFacade(HttpClient client) : IFacade
{
    private const string group = "/datetimeoffset";

    public Task<DateTimeOffset> GetAsync(CancellationToken cancellationToken = default)
     => client.GetFromJsonAsync<DateTimeOffset>($"{group}/", cancellationToken);

    public Task<DateTimeOffset> GetLocalAsync(CancellationToken cancellationToken = default)
        => client.GetFromJsonAsync<DateTimeOffset>($"{group}/local", cancellationToken);

    public Task<DateTimeOffset> GetUtcAsync(CancellationToken cancellationToken = default)
        => client.GetFromJsonAsync<DateTimeOffset>($"{group}/utc", cancellationToken);
}