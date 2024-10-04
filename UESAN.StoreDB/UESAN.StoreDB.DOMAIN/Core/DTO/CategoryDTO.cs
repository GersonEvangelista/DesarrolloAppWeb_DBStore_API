using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UESAN.StoreDB.DOMAIN.Core.Entities;

namespace UESAN.StoreDB.DOMAIN.Core.DTO
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public bool? IsActive { get; set; }
    }

    public class CategoryListDTO //retorna solo el ID y Descripcion
    {
        public int Id { get; set; }
        public string? Description { get; set; }
    }

    public class CategoryDescriptionDTO
    {
        public string? Description { get; set; }
    }

}

