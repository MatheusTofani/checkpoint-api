namespace Checkpoint.Domain.Errors;

public class ForbiddenException : CheckpointBaseException
{
    public ForbiddenException(string? message)
        : base(ErrorCode.ForbiddenException, message) { }

    public ForbiddenException(string? message, Exception? inner)
        : base(ErrorCode.ForbiddenException, message, inner) { }
}
