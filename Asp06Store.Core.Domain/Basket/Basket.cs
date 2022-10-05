namespace Asp06Store.ShopUI.Models
{
    public class Basket
    {
        private List<BasketItem> _items = new List<BasketItem>();

        public virtual void Add(Product product, int quantity)
        {
            var basketItem = _items.Where(x => x.Product.Id == product.Id).FirstOrDefault();
            if (basketItem != null)
            {
                basketItem.Quantity += quantity;
            }
            else
            {
                _items.Add(new BasketItem
                {
                    Product = product,
                    Quantity = quantity
                });
            }
        }

        public virtual void Remove(Product product) =>
            _items.RemoveAll(x => x.Product.Id == product.Id);

        public int TotalPrice() =>
            _items.Sum(x => x.Product.Price * x.Quantity);

        public virtual void Clear() => _items.Clear();

        public IEnumerable<BasketItem> Items => _items;
    }
}
