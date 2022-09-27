using Asp06Store.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp06Store.ShopUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;
        private int pageSize = 2;

        public HomeController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
        public IActionResult Index(int pageNumber = 1, string category = "")
        {
            var viewModel = new ProductListViewModel
            {
                CurrentCategory = category,
                Data = _productRepository.GetAll(pageNumber, pageSize, category)
            };
            return View(viewModel);
        }
    }
}
