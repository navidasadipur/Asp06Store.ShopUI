namespace Asp06Store.ShopUI.Models;

public class EfOrderRepository : IOrderRepository
{
    private readonly StoreDbContext _storeDbContext;

    public EfOrderRepository(StoreDbContext storeDbContext)
    {
        this._storeDbContext = storeDbContext;
    }
    public void Save(Order order)
    {
        _storeDbContext.AttachRange(order.OrderDetails.Select(d => d.Product));
        _storeDbContext.Orders.Add(order);
        _storeDbContext.SaveChanges();
    }
}

