using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace JpnCardsPokemonSdk.Client.Endpoints;

internal static class EndpointFactory
{
    static EndpointFactory()
    {
        var knownTypes = Assembly.GetExecutingAssembly().GetTypes().Where(t =>
            typeof(EndpointObject).IsAssignableFrom(t) &&
            t != typeof(EndpointObject));

        foreach (var knownType in knownTypes) RuntimeHelpers.RunClassConstructor(knownType.TypeHandle);
    }

    private static Dictionary<Type, IApiEndpoint> EndpointMapping { get; } = new();

    public static void RegisterTypeEndpoint<T>(IApiEndpoint endpoint) where T : EndpointObject
    {
        EndpointMapping.Add(typeof(T), endpoint);
    }

    public static IApiEndpoint GetApiEndpoint<T>() where T : EndpointObject
    {
        foreach (var endpointMappingKey in EndpointMapping.Keys.Where(endpointMappingKey =>
                     typeof(T) == endpointMappingKey))
            return EndpointMapping[endpointMappingKey];

        // Todo: Custom exception class
        throw new Exception($"No endpoint had been found for ${typeof(T).FullName}");
    }
}