using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Product
    {

        public string Name { get; set;}
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Product(string name)
        {
            Name = name;
        }

        public Product(double price)
        {
            Price = price;
        }

    }
}
