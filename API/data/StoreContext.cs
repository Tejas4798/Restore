using API.entities;
using Microsoft.EntityFrameworkCore;

namespace API.data
{
    public class StoreContext : DbContext
    {
        public StoreContext (DbContextOptions options) :base(options)
        {

        }
        public DbSet <Product> Products { get; set; }
    }
}