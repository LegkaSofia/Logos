using System;
using System.Collections.Generic;
using System.Text;

namespace People
{
    class Shopper : Employee
    {
        public override string Position => "Shopper";
        public void Buys()
        {
            Console.WriteLine("{2} {1} {0} buys product", Surname, Name, Position);

        }
    }
}
