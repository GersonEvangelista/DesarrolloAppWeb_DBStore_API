﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDB_DOMAIN.Core.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        public int? Stock { get; set; }

        public decimal? Price { get; set; }

        public int? Discount { get; set; }

    }

    public class ProductListDTO
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public IEnumerable<ProductListDTO> Products { get; set; }
    }

}
