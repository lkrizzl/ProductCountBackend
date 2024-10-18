using Domain.Core.PrimitiveTypes;

namespace WebApi.Contracts;

public record ApiErrorResponse(IReadOnlyCollection<Error> Errors);

