namespace CustomClasses.Results;

public class ExecutionResult<T>(bool succes, T data, string message)
{
    public bool Succes { get; } = succes;
    public T Data { get; } = data;
    public string Message { get; } = message;
}
