using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductNUnitApplication.Data;
using ProductNUnitApplication.Models.Product;
using ProductNUnitApplication.Repository;

namespace ProductNUnitApplication.Controllers
{
    public class ProductController : Controller
    {
        private static readonly List<Product> checkoutProductList = new List<Product>();

        public IActionResult Index()
        {
            return View(ProductData.GetProductsList());
        }

        [HttpPost]
        public IActionResult Index(CustomerType customerType)
        {
            return RedirectToAction("Checkout", customerType);
        }

        public IActionResult AddProduct(string productName, double productPrice)
        {
            checkoutProductList.Add(new Product
            {
                ProductName = productName,
                ProductPrice = productPrice
            });
            return RedirectToAction("Index");
        }

        public IActionResult Checkout(CustomerType customerType)
        {
            Checkout checkout = new Checkout { ProductList = checkoutProductList };

            var total = 0.0;

            switch (customerType)
            {
                case CustomerType.Regular:
                {
                    foreach (var product in checkoutProductList)
                    {
                        total += Calculate.CalculateRegularDiscount(product.ProductPrice);
                    }

                    checkout.GrandTotal = total;
                    break;
                }
                case CustomerType.Premium:
                {
                    foreach (var product in checkoutProductList)
                    {
                        total += Calculate.CalculatePremiumDiscount(product.ProductPrice);
                    }

                    checkout.GrandTotal = total;
                    break;
                }
            }

            checkoutProductList.Clear();

            return View(checkout);
        }
    }
}