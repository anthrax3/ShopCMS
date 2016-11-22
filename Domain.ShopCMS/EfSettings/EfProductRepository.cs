using Domain.ShopCMS.Abstract;
using Domain.ShopCMS.Entities;
using System.Collections.Generic;

namespace Domain.ShopCMS.EfSettings
{
    public class EfProductRepository : IProductRepository
    {
        private readonly EfDbContext _context = new EfDbContext();
        public IEnumerable<Product> Products => _context.Products;
    }
}