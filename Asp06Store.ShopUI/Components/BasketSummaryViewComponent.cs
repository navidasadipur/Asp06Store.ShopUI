﻿using Asp06Store.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp06Store.ShopUI.Components
{
    public class BasketSummaryViewComponent : ViewComponent
    {
        private readonly Basket basket;

        public BasketSummaryViewComponent(Basket basket)
        {
            this.basket = basket;
        }

        public IViewComponentResult Invoke()
        {
            

            return View(basket);
        }
    }
}
