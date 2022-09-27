using Asp06Store.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp06Store.ShopUI.Components
{
    public class CategorySideBoxViewComponent : ViewComponent
    {
        private readonly IProductRepository productRepository;

        public CategorySideBoxViewComponent(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IViewComponentResult Invoke()
        {
            var currentCategory = RouteData?.Values["category"];
            ViewBag.CurrentCategory = currentCategory;
            return View(productRepository.GetAllCategories());
        }
    }
}
