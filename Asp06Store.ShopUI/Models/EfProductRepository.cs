namespace asp06Store.ShopUI.Models
{
    public class EfProductRepository : IProductRepository
    {
        private readonly StoreDbContext _storeDbContext;

        public EfProductRepository(StoreDbContext storeDbContext)
        {
            this._storeDbContext = storeDbContext;
        }
        public PagedData<Product> GetAll(int pageNumber, int pageSize)
        {
            var result = new PagedData<Product>
            {
                PageInfo = new PageInfo
                {
                    PageSize = pageSize,
                    PageNumber = pageNumber
                }
            };

            result.Data = _storeDbContext.Products.Skip((pageNumber -1) * pageSize).Take(pageSize).ToList();
            result.PageInfo.TotalCount = _storeDbContext.Products.Count();
            return result;
        }
    }
}
