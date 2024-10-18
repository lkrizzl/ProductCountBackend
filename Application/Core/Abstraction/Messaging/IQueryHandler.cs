using Domain.Core.PrimitiveTypes.Result;
using MediatR;

namespace Applications.Core.Abstraction.Messaging;

public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}
