using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JCommerce.ProductAPI.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
