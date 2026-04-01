static class Endpoints
{
    public static void MapEndpoints(this IEndpointRouteBuilder app)
    {
        // TODO: Use setting to select defaulting to utc or local

        var dateTimeApi = app.MapGroup("/datetime");
        dateTimeApi.MapGet("/local", () => DateTime.Now).WithName("GetDateTimeLocal");
        dateTimeApi.MapGet("/utc", () => DateTime.UtcNow).WithName("GetDateTimeUtc");
        dateTimeApi.MapGet("/", () => Results.Redirect("/datetime/local")).WithName("GetDateTime");


        var dateTimeOffsetApi = app.MapGroup("/datetimeoffset");
        dateTimeOffsetApi.MapGet("/local", () => DateTimeOffset.Now).WithName("GetDateTimeOffsetLocal");
        dateTimeOffsetApi.MapGet("/utc", () => DateTimeOffset.UtcNow).WithName("GetDateTimeOffsetUtc");
        dateTimeOffsetApi.MapGet("/", () => Results.Redirect("/datetimeoffset/local")).WithName("GetDateTimeOffset");


        var timeApi = app.MapGroup("/time");
        timeApi.MapGet("/local", () => TimeOnly.FromDateTime(DateTime.Now)).WithName("GetTimeLocal");
        timeApi.MapGet("/utc", () => TimeOnly.FromDateTime(DateTime.UtcNow)).WithName("GetTimeUtc");
        timeApi.MapGet("/", () => Results.Redirect("/time/local")).WithName("GetTime");


        var dateApi = app.MapGroup("/date");
        dateApi.MapGet("/local", () => DateOnly.FromDateTime(DateTime.Now)).WithName("GetDateLocal");
        dateApi.MapGet("/utc", () => DateOnly.FromDateTime(DateTime.UtcNow)).WithName("GetDateUtc");
        dateApi.MapGet("/", () => Results.Redirect("/date/local")).WithName("GetDate");

        // TODO: info on timezone

        // A redirect from the root makes debugging easier
        app.MapGet("/", () => Results.Redirect("/time"));

        // Indicate the caller that he reached the api, but an unmapped path
        app.MapFallback(() => Results.NotFound("Not sure what you are looking for 🧐 Try using a specified path!"));
    }
}