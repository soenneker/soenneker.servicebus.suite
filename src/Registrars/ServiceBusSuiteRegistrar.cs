using Microsoft.Extensions.DependencyInjection;
using Soenneker.ServiceBus.Transmitter.Registrars;

namespace Soenneker.ServiceBus.Suite.Registrars;

/// <summary>
/// A concoction of Azure Cosmos utilities and libraries <para/>
/// </summary>
public static class ServiceBusSuiteRegistrar
{
    /// <summary>
    /// Adds all of the Azure Cosmos utilities needed for use <para/>
    /// </summary>
    /// <param name="services"></param>
    public static void AddServiceBusSuite(this IServiceCollection services)
    {
        services.AddServiceBusTransmitter();
    }
}