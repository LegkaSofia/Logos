using System;
using System.Collections.Generic;
using System.Text;

namespace People
{
    class Manager : Employee
    {
        public override string Position => "Manager";

        public void Helps()
        {
            Console.WriteLine("{2} {1} {0} helps people", Surname, Name, Position);
        }
    }
}
