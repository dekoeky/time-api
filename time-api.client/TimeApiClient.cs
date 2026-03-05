using time_api.client.Facades;

namespace time_api.client;

public class TimeApiClient(HttpClient client)
{
    public TimeFacade Time { get; } = new(client);
    public DateFacade Date { get; } = new(client);
    public DateTimeFacade DateTime { get; } = new(client);
    public DateTimeOffsetFacade DateTimeOffset { get; } = new(client);
}
