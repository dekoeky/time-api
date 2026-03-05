using Microsoft.AspNetCore.Mvc.Testing;
using time_api.client.Facades;

namespace time_api.client.Tests.Facades;

//[TestClass]
public abstract class BaseFacadeTests<T>(Func<TimeApiClient, T> getFacade) where T : class, IFacade
{
    public TestContext TestContext { get; set; }

    private static WebApplicationFactory<Program> _factory = null!;
    private HttpClient httpClient = null!;
    private TimeApiClient client = null!;
    protected T Facade = null!;


    [ClassInitialize(InheritanceBehavior.BeforeEachDerivedClass)]
    public static void ClassInitialize(TestContext testContext)
    {
        _factory = new WebApplicationFactory<Program>();
    }

    [TestInitialize]
    public void TestInitialize()
    {
        httpClient = _factory.CreateClient();
        client = new TimeApiClient(httpClient);
        Facade = getFacade(client);
    }

    [TestCleanup]
    public void TestCleanup()
    {
        httpClient.Dispose();
    }

    [ClassCleanup(InheritanceBehavior.BeforeEachDerivedClass)]
    public static void ClassCleanup()
    {
        _factory.Dispose();
    }

}
