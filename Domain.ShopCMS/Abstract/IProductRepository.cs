using Domain.ShopCMS.Entities;
using System.Collections.Generic;

namespace Domain.ShopCMS.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }

}