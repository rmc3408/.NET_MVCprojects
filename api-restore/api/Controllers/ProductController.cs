using api.Database;
using api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private StoreCtx _Store { get; set; } = default!;

    public ProductController(StoreCtx ctx)
    {
        _Store = ctx;
    }

    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetAll()
    {
        return await _Store.Products.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetOne(int id)
    {
        var product = await _Store.Products.FindAsync(id);
        if (product == null)
        {
            return NotFound();
        }
        return product;
    }
}
