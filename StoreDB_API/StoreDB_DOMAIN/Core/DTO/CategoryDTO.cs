using StoreDB_DOMAIN.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDB_DOMAIN.Core.DTO
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public bool? IsActive { get; set; }

        public virtual ICollection<Product> Product { get; set; } = new List<Product>();
    }

    public class CategoryListDTO
    {
        public int Id { get; set; }
        public string? Description { get; set; }    
    }

    public class CategoryDescriptionDTO
    {
        public string? Description { get; set; }
    }

    public class CategoryProductsDTO
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public IEnumerable<ProductListDTO> Products { get; set; }
    }

}
