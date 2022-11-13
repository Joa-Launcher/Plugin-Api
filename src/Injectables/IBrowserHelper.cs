namespace JoaLauncher.Api.Injectables;

/// <summary>
/// A helper to help with Browsers
/// </summary>
public interface IBrowserHelper
{
    /// <summary>
    /// Opens the url in the default Browser
    /// </summary>
    /// <param name="url"></param>
    void OpenWebsite(string url);
}