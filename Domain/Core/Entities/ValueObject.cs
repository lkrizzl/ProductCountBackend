using Domain.Core.Extations;
using Domain.Core.PrimitiveTypes.Result;
using FluentValidation;

namespace Domain.Core.Entities;

public record ValueObject()
{
    protected static Result<TValue> Validate<TValue>(AbstractValidator<TValue> validator, TValue instance)
    {
        return validator 
            .Validate(instance)
            .ToResult(instance);
    }
}
