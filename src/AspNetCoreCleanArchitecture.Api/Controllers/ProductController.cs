using AspNetCoreCleanArchitecture.Domain.Models;
using AspNetCoreCleanArchitecture.Infrastructure.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreCleanArchitecture.Api.Controllers;

[ApiController]
public class ProductController : Controller
{
    private readonly IProductRepository _productRepository;

    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    [HttpGet("[controller]/{id:guid}")]
    public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetByIdAsync(id, cancellationToken);
        // 1f7245b8-cf72-44b9-9cf0-85910d132903
        return Ok(product);
    }

    [HttpPost("[controller]")]
    public async Task<IActionResult> AddAsync(CancellationToken cancellationToken)
    {
        var product = new ProductDto
        {
            Id = Guid.NewGuid(),
            Name = "Dainis Test",
            CreatedDate = DateTime.UtcNow
        };
        
        var result = await _productRepository.AddAsync(product, cancellationToken);
        
        return Ok(result);
    }
}