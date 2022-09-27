using Asp06Store.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp06Store.ShopUI.Components
{
    public class CategorySideBoxViewComponent : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategorySideBoxViewComponent(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var currentCategory = RouteData?.Values["category"];
            ViewBag.CurrentCategory = currentCategory;
            return View(_categoryRepository.GetAllCategories());
        }
    }
}
