using Domain.Core.PrimitiveTypes;
using FluentValidation;

namespace Domain.Core.Extations;

public static class ValidatorsExtensions
{
    public static IRuleBuilderOptions<T, IProperty> WithError<T, IProperty>(
        this IRuleBuilderOptions<T, IProperty> ruleBuilder, 
        Error failure)
    {
        return ruleBuilder.WithErrorCode(failure.Code).WithMessage(failure.Massage);
    }
}
