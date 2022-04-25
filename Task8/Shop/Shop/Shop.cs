using Shop.Enums;
using Shop.Models;
using System;

namespace Shop
{
    internal class Shop
    {
        public Shop(ProductService productService)
        {
            ProductService = productService;
        }

        public ProductService ProductService { get; }

        public Check Check { get; private set; }

        public void AddCheck(Check check)
        {
            Check = check;
        }

        public void ShowAllProducts()
        {
            int i = 1;

            ProductCollection products = ProductService.GetAll();

            foreach (Product product in products)
            {
                Console.WriteLine("{0} {1} - {2} {3}", i++, product.Name, product.Price, WayToBuyToString(product.WayToBuy));
            }
        }

        public void RemoveProduct(string name)
        {
            Product p = ProductService.GetByName(name);
            ProductService.Remove(p);
        }

        public void AddProduct(string name, double price, WayToBuyProduct wayToBuy)
        {
            Product p = new Product(wayToBuy) { Name = name, Price = price };
            ProductService.Add(p);
        }

        private string WayToBuyToString(WayToBuyProduct way)
        {
            var str = string.Empty;

            if ((way & WayToBuyProduct.ShopWay) == WayToBuyProduct.ShopWay)
            {
                str += " S ";
            }
            if ((way & WayToBuyProduct.PostWay) == WayToBuyProduct.PostWay)
            {
                str += " P ";
            }
            if ((way & WayToBuyProduct.PickUpWay) == WayToBuyProduct.PickUpWay)
            {
                str += " PU ";
            }
            return str;
        }
    }
}
