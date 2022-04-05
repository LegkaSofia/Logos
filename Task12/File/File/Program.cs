using System;
using System.Text;
using System.Text.Json;
namespace File
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product product = new Product()
            {
                Name = "Pizza",
                Price = 65.99
            };

            string json = JsonSerializer.Serialize(product);

            using (System.IO.FileStream fileStream = System.IO.File.Create("product.txt"))
            {
                fileStream.Write(Encoding.UTF8.GetBytes(json));
            }

            Product product2;

            using (System.IO.FileStream fileStream1 = System.IO.File.OpenRead("product.txt"))
            {
                byte[] buffer = new byte[1024];
                var size = fileStream1.Read(buffer);
                var text = Encoding.UTF8.GetString(buffer).Substring(0, size);
                product2 = JsonSerializer.Deserialize<Product>(text);
            }
            Console.WriteLine($"{product2.Name}\t{product2.Price}");
        }
    }
}
