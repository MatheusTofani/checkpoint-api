namespace Checkpoint.Domain.Errors;

public class BankSettingsValidationException : UnprocessableEntityException
{
    public IReadOnlyList<string> InvalidFields { get; }

    public BankSettingsValidationException(IReadOnlyList<string> invalidFields)
        : base("Configuração bancária inválida.")
        => InvalidFields = invalidFields;
}
