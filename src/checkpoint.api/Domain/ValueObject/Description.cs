namespace Checkpoint.Domain.ValueObjects;

public class Description
{
    public string Value { get; private set; }

    public Description(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Descrição não pode ser vazia.");
        }

        Value = value;
    }
}