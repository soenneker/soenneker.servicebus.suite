[![](https://img.shields.io/nuget/v/Soenneker.ServiceBus.Suite.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.ServiceBus.Suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.servicebus.suite/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.servicebus.suite/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.ServiceBus.Suite.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.ServiceBus.Suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.servicebus.suite/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.servicebus.suite/actions/workflows/codeql.yml)

# Soenneker.ServiceBus.Suite

A convenience package that references the Soenneker Service Bus transmitter and receptor foundations and provides one registrar for the transmitter stack.

## Installation

```bash
dotnet add package Soenneker.ServiceBus.Suite
```

## Configuration

The transmitter requires these values:

```json
{
  "Azure": {
    "ServiceBus": {
      "ConnectionString": "Endpoint=sb://...",
      "Enable": true,
      "Log": false,
      "TransmitterLogging": false
    }
  }
}
```

Store the connection string in a protected configuration provider. `Enable=false` makes transmitter calls return without sending. The logging switches can expose complete message bodies and should remain disabled for sensitive payloads.

## Register the transmitter stack

```csharp
using Soenneker.ServiceBus.Suite.Registrars;

services.AddServiceBusSuiteAsSingleton();
```

This adds `IServiceBusTransmitter` plus its background queue, message builder, sender cache, queue utility, administration client, and top-level Service Bus client dependencies.

For a scoped transmitter facade:

```csharp
services.AddServiceBusSuiteAsScoped();
```

The scoped variant makes `IServiceBusTransmitter` scoped. Its registrar still uses singleton background-queue, message-builder, sender-cache, administration-client, and data-plane-client services.

## Send a message

```csharp
using Soenneker.ServiceBus.Transmitter.Abstract;

await transmitter.SendMessage(
    message,
    useQueue: false,
    cancellationToken);
```

See `Soenneker.ServiceBus.Transmitter` for foreground versus in-process queued sending, batching, error behavior, and message requirements.

## Receptors are not started automatically

The package references `Soenneker.ServiceBus.Receptor`, so its base types are available, but `AddServiceBusSuiteAsSingleton()` and `AddServiceBusSuiteAsScoped()` do not register a concrete receptor or start a processor.

Register each concrete receptor separately, resolve it during startup, call `Init`, and dispose it during shutdown. Receptors also require queue-management and receive permissions; the transmitter stack requires queue-management and send permissions because it creates missing queues before creating senders.
