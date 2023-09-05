using Microsoft.EntityFrameworkCore;
using stoktakipwebapp.Models;

namespace stoktakipwebapp.Repository
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions opt) :base(opt) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=Stok_Takip_Db; Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
    }


}