using Domain.Core.PrimitiveTypes.Result;
using MediatR;

namespace Applications.Core.Abstraction.Messaging;

public interface IQuery<TResponce> : IRequest<Result<TResponce>>
{
}
