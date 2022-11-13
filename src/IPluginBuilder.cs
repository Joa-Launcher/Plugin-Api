using JoaLauncher.Api.Providers;

namespace JoaLauncher.Api;

/// <summary>
/// Used to configure the plugin
/// </summary>
public interface IPluginBuilder
{
    /// <summary>
    /// Adds a global provider of type T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public IPluginBuilder AddGlobalProvider<T>() where T : IProvider;
    
    /// <summary>
    /// Adds a global provider of type T
    /// The provider is only beeing used if the condition is true
    /// The search results are not getting sortet
    /// </summary>
    /// <param name="condition"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public IPluginBuilder AddGlobalProvider<T>(Func<string, bool> condition) where T : IProvider;
    
    /// <summary>
    /// Adds a global search result
    /// </summary>
    /// <param name="searchResult"></param>
    /// <returns></returns>
    public IPluginBuilder AddGlobalResult(ISearchResult searchResult);
}