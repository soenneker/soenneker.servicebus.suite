using Microsoft.Extensions.DependencyInjection;
using Soenneker.ServiceBus.Transmitter.Registrars;

namespace Soenneker.ServiceBus.Suite.Registrars;

/// <summary>
/// Registers the Soenneker Service Bus transmitter stack. Concrete receptors are not registered or started by this class.
/// </summary>
public static class ServiceBusSuiteRegistrar
{
    /// <summary>
    /// Adds the transmitter and its singleton dependencies.
    /// </summary>
    /// <param name="services">Service collection that receives the registration.</param>
    /// <returns>The same service collection, so additional registrations can be chained.</returns>
    public static IServiceCollection AddServiceBusSuiteAsSingleton(this IServiceCollection services)
    {
        services.AddServiceBusTransmitterAsSingleton();

        return services;
    }

    /// <summary>
    /// Adds a scoped transmitter facade with the transmitter's shared dependencies.
    /// </summary>
    /// <param name="services">Service collection that receives the registration.</param>
    /// <returns>The same service collection, so additional registrations can be chained.</returns>
    public static IServiceCollection AddServiceBusSuiteAsScoped(this IServiceCollection services)
    {
        services.AddServiceBusTransmitterAsScoped();

        return services;
    }
}
