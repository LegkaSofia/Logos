using System;
using System.Collections.Generic;

namespace Shop
{
    internal static class ShopManagmante
    {
        public static Shop Shop = new Shop();
        public static void ShowOptions()
        {
            Console.WriteLine("1 - Show Products");
            Console.WriteLine("2 - Add Product");
            Console.WriteLine("3 - Remove Product");
            Console.WriteLine("4 - Add to Check");
            Console.WriteLine("5 - Show Cart");
        }

        public static void ShowProducts()
        {
            Shop.ShowAllProducts();
        }

        public static void AddProduct()
        {
            Console.WriteLine("Name product: ");
            string name = Console.ReadLine();
            Console.WriteLine("Price product: ");
            double price = double.Parse(Console.ReadLine());
            Shop.AddProduct(name, price);
        }

        public static void RemoveProduct()
        {
            Shop.ShowAllProducts();
            Console.WriteLine("Select product number to delete: ");
            int number = int.Parse(Console.ReadLine());
            List<Product> products = Shop.ProductService.GetAll();
            Product productToDelete = products[number - 1];
            Shop.RemoveProduct(productToDelete.Name);
        }

        public static void AddToCheck()
        {
            Shop.ShowAllProducts();
            Check check = Shop.Check;
            if (check == null)
            {
                check = new Check();
            }
            Console.WriteLine("Select product number to add to check: ");
            int number = int.Parse(Console.ReadLine());
            List<Product> products = Shop.ProductService.GetAll();
            Product productToAdd = products[number - 1];
            check.Add(productToAdd);
            Shop.AddCheck(check);
        }

        public static void ShowCart()
        {
            Check check = Shop.Check;
            if (check == null)
            {
                Console.WriteLine("No products");
                return;
            }

            List<Product> products = check.Products;
            foreach(Product product in products)
            {
                Console.WriteLine("{0} - {1}", product.Name, product.Price);
            }

            Console.WriteLine("Total price: {0} ", check.TotalPrice());
            Console.WriteLine("Profit: {0}", check.PDV());
        }

        public static void HandleChoise()
        {
            var key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.D1)
            {
                ShowProducts();
                return;
            }

            if (key.Key == ConsoleKey.D2)
            {
                AddProduct();
                return;
            }

            if (key.Key == ConsoleKey.D3)
            {
                RemoveProduct();
                return;
            }

            if (key.Key == ConsoleKey.D4)
            {
                AddToCheck();
                return;
            }

            if (key.Key == ConsoleKey.D5)
            {
                ShowCart();
                return;
            }
        }
    }
}
