namespace Checkpoint.Domain.Errors;

public class NotModifiedException : CheckpointBaseException
{
    public NotModifiedException(string? message)
        : base(ErrorCode.NotModifiedException, message) { }

    public NotModifiedException(string? message, Exception? inner)
        : base(ErrorCode.NotModifiedException, message, inner) { }
}
