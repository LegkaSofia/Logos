using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Dog : Animal
    {
        public override void Say()
        {
            Console.WriteLine("Собака каже Гав");
        }
        
    }
}
