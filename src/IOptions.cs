namespace JoaLauncher.Api;

/// <summary>
/// Used to retrieve <typeparamref name="TOptions"/> instance.
/// </summary>
/// <typeparam name="TOptions">The type of setting being requested.</typeparam>
public interface IOptions<out TOptions>
    where TOptions : class
{
    /// <summary>
    /// The default configured <typeparamref name="TOptions"/> instance
    /// </summary>
    TOptions Value { get; }
}