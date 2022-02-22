using System;
using System.Collections.Generic;
using System.Text;

namespace People
{
    class Cashier : Employee
    {
        public override string Position => "Cashier";

        public void Scan()
        {
            Console.WriteLine("{2} {1} {0} scan product", Surname, Name, Position);

        }
    }
}
