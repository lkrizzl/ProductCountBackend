using Domain.Core.PrimitiveTypes;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Contracts;

namespace WebApi.Infrastructure;

[Route("api")]

public class ApiControler(IMediator mediator) : ControllerBase
{

    protected IMediator Mediator { get; } = mediator;

    protected IActionResult BadRequest(Error error) => BadRequest(new ApiErrorResponse(new[] { error }));

}
