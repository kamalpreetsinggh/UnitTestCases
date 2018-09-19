using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductNUnitApplication.Models.Product;

namespace ProductNUnitApplication.Data
{
    public class ProductData
    {
        public static List<Product> GetProductsList()
        {
            return new List<Product>
            {
                new Product()
                {
                    ProductID = 1,
                    ProductName= "Lenovo Legion",
                    ProductPrice= 105000
                },
                new Product()
                {
                    ProductID = 2,
                    ProductName= "Zara Shirt",
                    ProductPrice= 7999
                },
                new Product()
                {
                    ProductID = 3,
                    ProductName= "Adidas Stan Smith",
                    ProductPrice= 9999
                },
                new Product()
                {
                    ProductID = 4,
                    ProductName= "Armani Jeans",
                    ProductPrice= 25999
                },
                new Product()
                {
                    ProductID = 5,
                    ProductName= "Burberry Purse",
                    ProductPrice= 35999
                },
                new Product()
                {
                    ProductID = 6,
                    ProductName= "Blackberry Suit",
                    ProductPrice= 19999
                },
                new Product()
                {
                    ProductID = 7,
                    ProductName= "Sennheiser Earphones",
                    ProductPrice= 9999
                }
            };
        }
    }
}
