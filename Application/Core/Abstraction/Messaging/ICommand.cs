using MediatR;
using Domain.Core.PrimitiveTypes.Result;

namespace Applications.Core.Abstraction.Messaging;

public interface ICommand : IRequest<Result>
{
}

public interface ICommand<TReponce> : IRequest<Result<TReponce>>
{
}