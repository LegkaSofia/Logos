using System.Collections.Generic;

namespace Shop.Models
{
    internal class ProductCollection : List<Product>
    {
        public static ProductCollection operator +(ProductCollection products, Product product)
        {
            products.Add(product);
            return products;
        }

        public static ProductCollection operator +(Product product, ProductCollection products)
        {
            products.Add(product);
            return products;
        }

        public static ProductCollection operator -(Product product, ProductCollection products)
        {
            products.Remove(product);
            return products;
        }

        public static ProductCollection operator -(ProductCollection products, Product product)
        {
            products.Remove(product);
            return products;
        }
    }
}
