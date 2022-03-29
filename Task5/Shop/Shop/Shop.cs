using System;
using System.Collections.Generic;

namespace Shop
{
    internal class Shop
    {
        public Shop()
        {
            ProductService = new ProductService();
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

            List<Product> products = ProductService.GetAll();
            foreach (Product product in products)
            {
                Console.WriteLine("{0} {1} - {2}", i++, product.Name, product.Price);
            }
        }

        public void RemoveProduct(string name)
        {
            Product p = ProductService.GetByName(name);
            ProductService.Remove(p);
        }

        public void AddProduct(string name, double price)
        {
            Product p = new Product() { Name = name, Price = price };
            ProductService.Add(p);
        }
    }
}
