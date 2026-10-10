namespace Checkpoint.Domain.Errors;

public class NotFoundException : CheckpointBaseException
{
    public NotFoundException(string? message)
        : base(ErrorCode.NotFoundException, message) { }

    public NotFoundException(string? message, Exception? inner)
        : base(ErrorCode.NotFoundException, message, inner) { }
}
