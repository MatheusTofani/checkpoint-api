namespace Checkpoint.Domain.Errors;

public class ValidationException : CheckpointBaseException
{
    public ValidationException(string? message)
        : base(ErrorCode.ValidationException, message) { }

    public ValidationException(string? message, Exception? inner)
        : base(ErrorCode.ValidationException, message, inner) { }
}
