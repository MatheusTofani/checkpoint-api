namespace Checkpoint.Domain.Errors;

public class OperationRejectedException : CheckpointBaseException
{
    public OperationRejectedException(string? message)
        : base(ErrorCode.OperationRejectedException, message) { }

    public OperationRejectedException(string? message, Exception? inner)
        : base(ErrorCode.OperationRejectedException, message, inner) { }
}
