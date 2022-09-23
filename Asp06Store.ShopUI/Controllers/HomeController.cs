using asp06Store.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp06Store.ShopUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;
        private int pageSize = 2;

        public HomeController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
        public IActionResult Index(int pageNumber = 1)
        {
            return View(_productRepository.GetAll(pageNumber, pageSize));
        }
    }
}
