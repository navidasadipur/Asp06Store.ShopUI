namespace Asp06Store.ShopUI.Models
{
    public class EfCategoryRepository : ICategoryRepository
    {
        private readonly StoreDbContext _storeDbContext;

        public EfCategoryRepository(StoreDbContext storeDbContext)
        {
            this._storeDbContext = storeDbContext;
        }

        public List<string> GetAllCategories()
        {
            return _storeDbContext.Categories.Select(x => x.Name).ToList();
        }
    }
}
