using learning_api.Models;
using Microsoft.EntityFrameworkCore;

namespace learning_api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}