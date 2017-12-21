using Microsoft.EntityFrameworkCore;

namespace web.Models
{
    public class VegaDbContext : DbContext 
    {
      public VegaDbContext(DbContextOptions<VegaDbContext> options) 
          : base(options)
        {
           }   

      public DbSet<UserDetails> userDetails { get; set; } 
      public DbSet<product> product { get; set; } 
       public DbSet<Achat> Achat { get; set; } 
    }
}