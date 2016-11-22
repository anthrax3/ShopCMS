using Domain.ShopCMS.Entities;
using System.Data.Entity;

namespace Domain.ShopCMS.EfSettings
{
    public class EfDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

    }
}