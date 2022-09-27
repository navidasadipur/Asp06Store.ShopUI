using Asp06Store.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Asp06Store.ShopUI.Controllers
{
    public class BasketController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly Basket sessionBasket;

        public BasketController(IProductRepository productRepository, Basket sessionBasket)
        {
            this._productRepository = productRepository;
            this.sessionBasket = sessionBasket;
        }
        public IActionResult Index(string returnUrl)
        {

            BasketPageViewModel model = new()
            {
                Basket = sessionBasket,
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult AddToBasket(int productId, string returnUrl)
        {
            var product = _productRepository.GetById(productId);
            sessionBasket.Add(product, 1);

            return RedirectToAction(nameof(Index), new { returnUrl = returnUrl});
        }

        public IActionResult RemoveFromBasket(int productId, string returnUrl)
        {
            var product = _productRepository.GetById(productId);
            sessionBasket.Remove(product);

            return RedirectToAction(nameof(Index), new { returnUrl = returnUrl });
        }

        //private Basket GetBasket()
        //{
        //    return HttpContext.Session.GetJson<Basket>("Basket");
        //}

        //private void SaveBasket(Basket basket)
        //{
        //    HttpContext.Session.setJson("Basket", basket);
        //}
    }
}
