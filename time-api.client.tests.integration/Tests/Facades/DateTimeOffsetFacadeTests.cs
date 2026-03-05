using time_api.client.Facades;

namespace time_api.client.Tests.Facades;

[TestClass]
public class DateTimeOffsetFacadeTests() : BaseFacadeTests<DateTimeOffsetFacade>(client => client.DateTimeOffset)
{
    [TestMethod]
    public async Task GetAsync()
    {
        // Arrange
        var cancellationToken = TestContext.CancellationToken;

        // Act
        var datetimeoffset = await Facade.GetAsync(cancellationToken);

        // Assert
        Console.WriteLine(datetimeoffset);
    }

    [TestMethod]
    public async Task GetLocalAsync()
    {
        // Arrange
        var cancellationToken = TestContext.CancellationToken;

        // Act
        var datetimeoffset = await Facade.GetLocalAsync(cancellationToken);

        // Assert
        Console.WriteLine(datetimeoffset);
    }

    [TestMethod]
    public async Task GetUtcAsync()
    {
        // Arrange
        var cancellationToken = TestContext.CancellationToken;

        // Act
        var datetimeoffset = await Facade.GetUtcAsync(cancellationToken);

        // Assert
        Console.WriteLine(datetimeoffset);
    }
}
