namespace JoaLauncher.Api;

/// <summary>
/// Represents a search result which will be displayed to the user
/// </summary>
public abstract class SearchResult
{
    protected SearchResult(string title, string description, string icon)
    {
        Title = title;
        Description = description;
        Icon = icon;
    }
    
    protected SearchResult(string title, string description, string icon, List<ContextAction> actions)
    {
        Title = title;
        Description = description;
        Icon = icon;
        Actions = actions;
    }

    /// <summary>
    /// The title is a big text displayed on the search result
    /// </summary>
    public string Title { get; }

    /// <summary>
    /// The description is a smaller text below the title
    /// </summary>
    public string Description { get; }

    /// <summary>
    /// The Icon displayed next to the title and description
    /// Should contain the path to the icon. URLs are not supported
    /// </summary>
    public string Icon { get; }

    /// <summary>
    /// A list of <see cref="ContextAction"/> which represent the
    /// possible actions the user could execute on this search result
    /// </summary>
    public List<ContextAction>? Actions { get; }

    /// <summary>
    /// The method which gets called if the user executes the search result
    /// </summary>
    /// <param name="executionContext"></param>
    public abstract void Execute(IExecutionContext executionContext);
}