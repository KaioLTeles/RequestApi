using Microsoft.EntityFrameworkCore;

namespace RequestApi.Models
{
    public class RequestApiContext : DbContext
    {
        public RequestApiContext(DbContextOptions<RequestApiContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}