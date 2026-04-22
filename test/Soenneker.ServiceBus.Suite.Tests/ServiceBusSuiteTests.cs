using Soenneker.Tests.HostedUnit;

namespace Soenneker.ServiceBus.Suite.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class ServiceBusSuiteTests : HostedUnitTest
{

    public ServiceBusSuiteTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
