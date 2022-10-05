namespace Asp06Store.ShopUI.Models
{
    public class EfProductRepository : IProductRepository
    {
        private readonly StoreDbContext _storeDbContext;

        public EfProductRepository(StoreDbContext storeDbContext)
        {
            this._storeDbContext = storeDbContext;
        }
        public PagedData<Product> GetAll(int pageNumber, int pageSize, string category)
        {
            var result = new PagedData<Product>
            {
                PageInfo = new PageInfo
                {
                    PageSize = pageSize,
                    PageNumber = pageNumber
                }
            };

            result.Data = _storeDbContext.Products
                .Where(x => string.IsNullOrWhiteSpace(category) || x.Category.Name == category)
                .Skip((pageNumber -1) * pageSize)
                .Take(pageSize)
                .ToList();
            result.PageInfo.TotalCount = _storeDbContext.Products
                .Where(x => string.IsNullOrWhiteSpace(category) || x.Category.Name == category)
                .Count();
            return result;
        }

        public Product GetById(int id)
        {
            return _storeDbContext.Products.Find(id);
        }
    }
}
