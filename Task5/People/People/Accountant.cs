using System;
using System.Collections.Generic;
using System.Text;

namespace People
{
    class Accountant : Employee
    {
        public override string Position =>"Accountant";

        public void Calculate()
        {
            Console.WriteLine("{2} {1} {0} calculate money",Surname, Name, Position);
        }
    }
}
