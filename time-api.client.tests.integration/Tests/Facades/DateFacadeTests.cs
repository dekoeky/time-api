using time_api.client.Facades;

namespace time_api.client.Tests.Facades;

[TestClass]
public class DateFacadeTests() : BaseFacadeTests<DateFacade>(client => client.Date)
{
    [TestMethod]
    public async Task GetAsync()
    {
        // Arrange
        var cancellationToken = TestContext.CancellationToken;

        // Act
        var date = await Facade.GetAsync(cancellationToken);

        // Assert
        Console.WriteLine(date);
    }

    [TestMethod]
    public async Task GetLocalAsync()
    {
        // Arrange
        var cancellationToken = TestContext.CancellationToken;

        // Act
        var date = await Facade.GetLocalAsync(cancellationToken);

        // Assert
        Console.WriteLine(date);
    }

    [TestMethod]
    public async Task GetUtcAsync()
    {
        // Arrange
        var cancellationToken = TestContext.CancellationToken;

        // Act
        var date = await Facade.GetUtcAsync(cancellationToken);

        // Assert
        Console.WriteLine(date);
    }
}