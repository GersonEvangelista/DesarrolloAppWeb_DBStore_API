using StoreDB_DOMAIN.Core.DTO;
using StoreDB_DOMAIN.Core.Entities;

namespace StoreDB_DOMAIN.Core.Interfaces
{
    public interface ICategoryRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Category>> GetCategories();
        Task<Category> GetCategoryById(int id);
        Task<int> Insert(Category category);
        Task<bool> Update(Category category);
        Task<Category> GetCategoryWithProducts(int id);
    }
}
