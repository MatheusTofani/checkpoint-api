namespace Checkpoint.Domain.Errors;

public class UnprocessableEntityException : CheckpointBaseException
{
    public UnprocessableEntityException(string? message)
        : base(ErrorCode.UnprocessableEntityException, message) { }

    public UnprocessableEntityException(string? message, Exception? inner)
        : base(ErrorCode.UnprocessableEntityException, message, inner) { }
}
