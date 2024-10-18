using Application.Products.GetProducts;
using Applications.Products.CreateProduct;
using Applications.Products.DeleteProduct;
using Applications.Products.GetProduct;
using Applications.Products.Responses;
using Domain.Products;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Infrastructure;

namespace WebApi.Controllers;

public class ProductController(IMediator mediator) : ApiControler(mediator)
{

    [HttpGet("products")]
    [ProducesResponseType(typeof(ProductResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> Get()
    {
        var query = new GetProductsQuery();

        var result = await Mediator.Send(query);

        return Ok(result.Value);
    }

    [HttpGet("products/{id:guid}")]
    [ProducesResponseType(typeof(ProductResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(Guid id)
    {
        var query = new GetProductQuery(id);

        var result = await Mediator.Send(query);

        if(result.IsFailure)
        {
            return NotFound(result.Errors);
        }

        return Ok(result.Value);
    }

    [HttpPost("products")]
    [ProducesResponseType(typeof(ProductResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateProduct(string productName, string productDescription, int productCount)
    {
        var command = new CreateProductCommand(productName, productDescription, productCount);

        var result = await Mediator.Send(command);

        if (result.IsFailure)
        {
            return BadRequest(result.Errors);
        }

        return Created();
    }

    [HttpDelete("products/{id:guid}")]
    [ProducesResponseType(typeof(ProductResponse), StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteProduct(Guid id)
    {
        var command = new DeleteProductCommand(id);

        var result = await Mediator.Send(command);

        if (result.IsFailure)
        {
            return NotFound(result.Errors);
        }

        return NoContent();
    }

}
