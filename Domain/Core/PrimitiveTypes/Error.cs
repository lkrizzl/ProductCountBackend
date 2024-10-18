namespace Domain.Core.PrimitiveTypes;

public record Error(string Code, string Massage)
{
    public static implicit operator string(Error error) => error?.Code ?? string.Empty;
}
