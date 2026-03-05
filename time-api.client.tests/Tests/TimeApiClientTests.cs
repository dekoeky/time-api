namespace time_api.client.Tests;

[TestClass]
public sealed class TimeApiClientTests
{
    [TestMethod]
    public void Constructor()
    {
        // Arrange
        using var httpClient = new HttpClient();

        // Act
        var client = new TimeApiClient(httpClient);

        // Assert
        Assert.IsNotNull(client);
        Assert.IsNotNull(client.Time);
        Assert.IsNotNull(client.Date);
        Assert.IsNotNull(client.DateTime);
        Assert.IsNotNull(client.DateTimeOffset);
    }
}
