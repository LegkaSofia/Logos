using System;
using System.Collections.Generic;
using System.Text;

namespace Virtuals
{
    class PostProduct : Product
    {
        public double TransferPrice { get; set; }

        public override double TotalPrice()
        {
            return TransferPrice + Price;
        }
    }
}
