[![](https://img.shields.io/nuget/v/Soenneker.ServiceBus.Suite.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.ServiceBus.Suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.servicebus.suite/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.servicebus.suite/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.ServiceBus.Suite.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.ServiceBus.Suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.servicebus.suite/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.servicebus.suite/actions/workflows/codeql.yml)

# Soenneker.ServiceBus.Suite

A concoction of Azure Service Bus utilities and libraries.

## Install

```bash
dotnet add package Soenneker.ServiceBus.Suite
```

## Quick start

```csharp
using Soenneker.ServiceBus.Suite.Registrars;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
var result = services.AddServiceBusSuiteAsSingleton();
```

Adds all the Azure Service Bus utilities needed for use.

## What you get

- `ServiceBusSuiteRegistrar` — A concoction of Azure Service Bus utilities and libraries.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `ServiceBusSuiteRegistrar.AddServiceBusSuiteAsSingleton(services)` | Adds all the Azure Service Bus utilities needed for use. | The same service collection, so additional registrations can be chained. |
| `ServiceBusSuiteRegistrar.AddServiceBusSuiteAsScoped(services)` | Adds all the Azure Service Bus utilities needed for use. | The same service collection, so additional registrations can be chained. |
