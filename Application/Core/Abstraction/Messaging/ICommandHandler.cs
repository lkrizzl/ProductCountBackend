using Domain.Core.PrimitiveTypes.Result;
using MediatR;

namespace Applications.Core.Abstraction.Messaging;

public interface ICommandHandler<TCommand>
    : IRequestHandler<TCommand, Result> where TCommand : ICommand
{ }

public interface ICommandHandler<TCommand, TResponse> 
    : IRequestHandler<TCommand, Result<TResponse>> 
    where TCommand : ICommand<TResponse>
{ }
