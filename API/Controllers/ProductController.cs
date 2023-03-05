using API.data;
using API.entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
[Route("api/[Controller]")]
    public class ProductController :ControllerBase
    {    private readonly StoreContext _context;
        
        public ProductController(StoreContext context)
        {
           
            this._context=context;
        }
     [HttpGet]
     public async Task< ActionResult<List<Product>> > GetProductsAsync()
     {
         return await _context.Products.ToListAsync();

         
     }

     [HttpGet("{id}")]
     public  async Task<ActionResult<Product> > GetProductAsync(int id)
     {
        return  await _context.Products.FindAsync(id);
     }


    }
}