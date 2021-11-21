﻿using JCommerce.ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JCommerce.ProductAPI.Repositories
{
    
        public interface IProductRepository
        {
            void Add(Product product);
            IEnumerable<Product> GetAll();
            Product GetBy(Guid id);
            void Remove(Guid id);
            void Update(Product product);
        }
    
}
