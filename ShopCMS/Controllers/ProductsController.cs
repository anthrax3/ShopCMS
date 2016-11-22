using Domain.ShopCMS.Abstract;
using System.Web.Mvc;

namespace ShopCMS.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: Products
        public ActionResult Index()
        {
            return View(_productRepository.Products);
        }
    }
}