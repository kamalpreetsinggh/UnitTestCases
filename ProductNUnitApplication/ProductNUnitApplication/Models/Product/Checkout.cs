using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductNUnitApplication.Models.Product
{
    public class Checkout
    {
        public List<Product> ProductList { get; set; }
        public double GrandTotal { get; set; }
    }
}
