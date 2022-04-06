using System;

namespace Virtuals
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product() { Price = 67.94};
            Product product1 = new PostProduct() { Price = 76.52, TransferPrice = 10 };

            Product[] products = new Product[] { product, product1 };

            foreach (var item in products)
            {
                Console.WriteLine(item.TotalPrice());
            }
        }
    }
}
