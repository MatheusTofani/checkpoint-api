namespace Checkpoint.Domain.Errors;

public abstract class CheckpointBaseException : Exception
{
    public ErrorCode ErrorCode { get; }

    protected CheckpointBaseException(ErrorCode code, string? message)
        : base(message) => ErrorCode = code;

    protected CheckpointBaseException(ErrorCode code, string? message, Exception? inner)
        : base(message, inner) => ErrorCode = code;
}
