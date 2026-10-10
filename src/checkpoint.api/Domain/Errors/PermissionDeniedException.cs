namespace Checkpoint.Domain.Errors;

public class PermissionDeniedException : CheckpointBaseException
{
    public PermissionDeniedException(string? message)
        : base(ErrorCode.PermissionDeniedException, message) { }

    public PermissionDeniedException(string? message, Exception? inner)
        : base(ErrorCode.PermissionDeniedException, message, inner) { }
}
