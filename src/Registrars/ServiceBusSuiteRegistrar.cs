using Microsoft.Extensions.DependencyInjection;
using Soenneker.ServiceBus.Transmitter.Registrars;

namespace Soenneker.ServiceBus.Suite.Registrars;

/// <summary>
/// A concoction of Azure Service Bus utilities and libraries <para/>
/// </summary>
public static class ServiceBusSuiteRegistrar
{
    /// <summary>
    /// Adds all the Azure Service Bus utilities needed for use <para/>
    /// </summary>
    /// <param name="services"></param>
    public static IServiceCollection AddServiceBusSuiteAsSingleton(this IServiceCollection services)
    {
        services.AddServiceBusTransmitterAsSingleton();

        return services;
    }

    /// <summary>
    /// Adds all the Azure Service Bus utilities needed for use <para/>
    /// </summary>
    /// <param name="services"></param>
    public static IServiceCollection AddServiceBusSuiteAsScoped(this IServiceCollection services)
    {
        services.AddServiceBusTransmitterAsScoped();

        return services;
    }
}