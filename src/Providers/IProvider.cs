namespace JoaLauncher.Api.Providers;

public interface IGenericProvider
{
    /// <summary>
    /// A performance critical method used to return search results.
    /// In most cases this method should only return cached search results.
    /// </summary>
    /// <param name="searchString"></param>
    /// <returns></returns>
    public List<SearchResult> GetSearchResults(string searchString);
}

/// <summary>
/// A Provider has the job to provide search results.
/// A Provider can be used at two points
/// 1. It can be registered as a global provider
/// 2. It can be added to a step using the StepBuilder
/// in a search result
/// </summary>
public interface IProvider<in T> : IGenericProvider
{
}

public interface IProvider : IGenericProvider
{
}