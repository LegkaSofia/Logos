using Shop.Enums;
using Shop.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop
{
    internal class ProductService
    {
        public ProductService()
        {
            Products = new List<Product>
            {
                new Product(WayToBuyProduct.ShopWay | WayToBuyProduct.PickUpWay) { Name = "Apple", Price = 5 },
                new Product(WayToBuyProduct.ShopWay) { Name = "Meat", Price = 58 },
                new Product(WayToBuyProduct.ShopWay | WayToBuyProduct.PickUpWay | WayToBuyProduct.PostWay) { Name = "Banana", Price = 13 }
            };
        }

        public List<Product> Products { get; set; }

        public void Add(Product product)
        {
            Products.Add(product);
        }

        public List<Product> GetAll()
        {
            return Products;
        }

        public void Remove(Product product)
        {
            Products.Remove(product);
        }

        public Product GetByName(string name)
        {
            return Products.FirstOrDefault(p => p.Name == name);
        }
    }
}
