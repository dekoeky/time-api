using time_api.client.Facades;

namespace time_api.client.Tests.Facades;

[TestClass]
public class TimeFacadeTests() : BaseFacadeTests<TimeFacade>(client => client.Time)
{
    [TestMethod]
    public async Task GetAsync()
    {
        // Arrange
        var cancellationToken = TestContext.CancellationToken;

        // Act
        var time = await Facade.GetAsync(cancellationToken);

        // Assert
        Console.WriteLine(time);
    }

    [TestMethod]
    public async Task GetLocalAsync()
    {
        // Arrange
        var cancellationToken = TestContext.CancellationToken;

        // Act
        var time = await Facade.GetLocalAsync(cancellationToken);

        // Assert
        Console.WriteLine(time);
    }

    [TestMethod]
    public async Task GetUtcAsync()
    {
        // Arrange
        var cancellationToken = TestContext.CancellationToken;

        // Act
        var time = await Facade.GetUtcAsync(cancellationToken);

        // Assert
        Console.WriteLine(time);
    }
}
