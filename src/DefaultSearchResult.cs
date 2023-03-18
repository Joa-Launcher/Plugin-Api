namespace JoaLauncher.Api;

public class DefaultSearchResult : SearchResult
{
    public required Action<IExecutionContext> ExecutionAction { get; set; }
    
    public override void Execute(IExecutionContext executionContext)
    {
        ExecutionAction(executionContext);
    }
}