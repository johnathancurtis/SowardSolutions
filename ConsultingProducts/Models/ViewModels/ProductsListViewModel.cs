﻿using System.Collections.Generic;
using ConsultingProducts.Models;

namespace ConsultingProducts.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
