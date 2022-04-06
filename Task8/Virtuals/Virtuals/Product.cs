using System;
using System.Collections.Generic;
using System.Text;

namespace Virtuals
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public virtual double TotalPrice()
        {
            return Price;
        } 
    }
}
