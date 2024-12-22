using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.ServiceBus.Suite.Tests;

[Collection("Collection")]
public class ServiceBusSuiteTests : FixturedUnitTest
{

    public ServiceBusSuiteTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
