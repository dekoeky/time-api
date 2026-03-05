using time_api.client.Facades;

namespace time_api.client.Tests.Facades;

[TestClass]
public class DateTimeFacadeTests() : BaseFacadeTests<DateTimeFacade>(client => client.DateTime)
{
    [TestMethod]
    public async Task GetAsync()
    {
        // Arrange
        var cancellationToken = TestContext.CancellationToken;

        // Act
        var datetime = await Facade.GetAsync(cancellationToken);

        // Assert
        Console.WriteLine(datetime);
    }

    [TestMethod]
    public async Task GetLocalAsync()
    {
        // Arrange
        var cancellationToken = TestContext.CancellationToken;

        // Act
        var datetime = await Facade.GetLocalAsync(cancellationToken);

        // Assert
        Console.WriteLine(datetime);
    }

    [TestMethod]
    public async Task GetUtcAsync()
    {
        // Arrange
        var cancellationToken = TestContext.CancellationToken;

        // Act
        var datetime = await Facade.GetUtcAsync(cancellationToken);

        // Assert
        Console.WriteLine(datetime);
    }
}
