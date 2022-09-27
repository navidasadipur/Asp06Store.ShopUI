using Asp06Store.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp06Store.ShopUI.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly Basket _basket;

        public OrderController(IOrderRepository orderRepository, Basket basket)
        {
            this._orderRepository = orderRepository;
            this._basket = basket;
        }

        public IActionResult Checkout()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Checkout(CheckoutViewModel model)
        {
            if (!_basket.Items.Any())
            {
                ModelState.AddModelError("", "There is No Item in Basket");
            }

            if (ModelState.IsValid)
            {
                var order = new Order
                {
                    Name = model.Name,
                    Address = model.Address,
                    City = model.City
                };

                foreach (var item in _basket.Items)
                {
                    order.OrderDetails.Add(new OrderDetail
                    {
                        Product = item.Product,
                        Quantity = item.Quantity
                    });
                }
                _orderRepository.Save(order);
                return RedirectToAction(nameof(Compelete));
            }

            return View(model);
        }

        public IActionResult Compelete()
        {
            return View();
        }
    }
}
