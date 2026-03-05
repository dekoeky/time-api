using Microsoft.AspNetCore.Mvc.Testing;

namespace time_api.Tests;

[TestClass]
public sealed class TimeApiTests
{
    private static WebApplicationFactory<Program> _factory;
    static HttpClient client;
    public TestContext TestContext { get; set; }

    [ClassInitialize]
    public static void ClassInit(TestContext context)
    {
        _factory = new WebApplicationFactory<Program>();
        client = _factory.CreateClient();
    }

    [ClassCleanup]
    public static void ClassCleanup()
    {
        _factory.Dispose();
    }

    [TestMethod]
    [DataRow("/time")]
    [DataRow("/time/local")]
    [DataRow("/time/utc")]
    [DataRow("/date")]
    [DataRow("/date/local")]
    [DataRow("/date/utc")]
    [DataRow("/datetime")]
    [DataRow("/datetime/local")]
    [DataRow("/datetime/utc")]
    [DataRow("/datetimeoffset")]
    [DataRow("/datetimeoffset/local")]
    [DataRow("/datetimeoffset/utc")]
    public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string url)
    {
        // Act
        var response = await client.GetAsync(url, TestContext.CancellationToken);

        // Assert
        response.EnsureSuccessStatusCode(); // Status Code 200-299
        Assert.AreEqual("application/json; charset=utf-8", response.Content.Headers.ContentType?.ToString());
    }
}