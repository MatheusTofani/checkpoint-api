namespace Checkpoint.Domain.Errors;

public class OperationInProgressException : CheckpointBaseException
{
    public OperationInProgressException(string? message)
        : base(ErrorCode.OperationInProgressException, message) { }

    public OperationInProgressException(string? message, Exception? inner)
        : base(ErrorCode.OperationInProgressException, message, inner) { }
}
