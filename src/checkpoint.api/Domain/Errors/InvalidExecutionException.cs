namespace Checkpoint.Domain.Errors;

public class InvalidExecutionException : CheckpointBaseException
{
    public InvalidExecutionException(string? message)
        : base(ErrorCode.InvalidExecutionException, message) { }

    public InvalidExecutionException(string? message, Exception? inner)
        : base(ErrorCode.InvalidExecutionException, message, inner) { }
}
