﻿using StoreDB_DOMAIN.Core.DTO;

namespace StoreDB_DOMAIN.Core.Interfaces
{
    public interface ICategoryService
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<CategoryListDTO>> GetCategories();
        Task<CategoryListDTO> GetCategoryById(int id);
        Task<CategoryProductsDTO> GetCategoryWithProducts(int id);
        Task<int> Insert(CategoryDescriptionDTO categoryDTO);
        Task<bool> Update(CategoryDTO categoryDTO);
    }
}