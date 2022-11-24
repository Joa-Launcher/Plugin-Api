namespace JoaLauncher.Api.Plugin;

/// <summary>
/// Defines a UI Plugin
/// </summary>
public interface IUiPlugin : IPlugin
{
    /// <summary>
    /// When executed, the plugin should start the UI
    /// </summary>
    /// <param name="port">The port used for communication between the plugin and Joa</param>
    void Start(string port);
    
    /// <summary>
    /// When executed, the plugin should stop the UI
    /// </summary>
    void Stop();
}