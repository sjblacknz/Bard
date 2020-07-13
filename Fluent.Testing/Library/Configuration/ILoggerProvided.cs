using System;
using Fluent.Testing.Library.Given;
using Fluent.Testing.Library.Then;

namespace Fluent.Testing.Library.Configuration
{
    public interface ILoggerProvided
    {
        ICustomErrorProviderSupplied Use<T>() where T : IBadRequestProvider, new();

        IStartingScenarioProvided<TScenario> AndBeginsWithScenario<TScenario>(Func<TScenario> createScenario) where TScenario : BeginAScenario, new();
    }
}