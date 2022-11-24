using JoaLauncher.Api.Providers;

namespace JoaLauncher.Api;

/// <summary>
/// Is used to Build a new Step. A Step Containt Providers
/// </summary>
public interface IStepBuilder
{
    /// <summary>
    /// Can be used to add a Provider to the Step.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public IStepBuilder AddProvider<T>() where T : IProvider;
    
    public IStepBuilder AddProvider<TProvider, TContext>(TContext providerContext) 
        where TProvider : IProvider<TContext> 
        where TContext : IProviderContext;
}