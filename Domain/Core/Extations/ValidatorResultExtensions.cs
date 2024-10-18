﻿using Domain.Core.PrimitiveTypes;
using Domain.Core.PrimitiveTypes.Result;
using FluentValidation.Results;

namespace Domain.Core.Extations;

public static class ValidatorResultExtensions
{
    public static Error ToError(this ValidationFailure validationResult) =>
        new(validationResult.ErrorCode, validationResult.ErrorMessage);

    public static Result<TValue> ToResult<TValue>(this ValidationResult validationResult, TValue value)
    {
    
        if(validationResult.IsValid) 
            return Result.Success(value);
        else
            return Result.Failure<TValue>(validationResult.Errors.Select(r => r.ToError()).ToArray());
    
    }

    public static Result ToResult(this ValidationResult validationResult)
    {
        if (validationResult.IsValid)
            return Result.Success();
        else
            return Result.Failure(validationResult.Errors.Select(r => r.ToError()).ToArray());
    }
}
