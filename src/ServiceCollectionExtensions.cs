using System;
using Microsoft.Extensions.DependencyInjection;

namespace Akunich.Extensions.Identifier;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddGuidIdentifierProvider(this IServiceCollection serviceCollection) =>
        serviceCollection.AddSingleton<IIdentifierProvider<Guid>, GuidIdentifierProvider>();
}