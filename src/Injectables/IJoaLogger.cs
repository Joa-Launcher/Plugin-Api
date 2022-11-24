namespace JoaLauncher.Api.Injectables;

/// <summary>
/// Can be used to log to the joalog.log file
/// </summary>
public interface IJoaLogger
{
    /// <summary>
    /// Logs the message with the provided LogLevel
    /// </summary>
    /// <param name="message">The message to be logged</param>
    /// <param name="logLevel">The LogLevel that should be used</param>
    public void Log(string message, LogLevel logLevel);
    
    /// <summary>
    /// Logs a message with LogLevel.Info
    /// </summary>
    /// <param name="message">The message to be logged</param>
    public void Info(string message);
    
    /// <summary>
    /// Logs a message with LogLevel.Warning
    /// </summary>
    /// <param name="message">The message to be logged</param>
    public void Warning(string message);
    
    /// <summary>
    /// Logs a message with LogLevel.Error
    /// </summary>
    /// <param name="message">The message to be logged</param>
    public void Error(string message);
    
    /// <summary>
    /// Can be used to time an operatio
    /// The messurement will be stoped and logged if the returned IDisposable gets disposed
    /// <example>
    /// using var _ = _log.TimedOperation(nameof(SomeMethod));
    /// </example>
    /// </summary>
    /// <param name="nameOfMethod">The name of the operation to be logged</param>
    /// <returns>An IDisposable which will trigger the logging if disposed</returns>
    public IDisposable TimedOperation(string nameOfMethod);
    
    public void LogException(Exception e, string logName = "");
}

/// <summary>
/// Represent the different Log levels
/// </summary>
public enum LogLevel
{
    Warning,
    Info,
    Error
}