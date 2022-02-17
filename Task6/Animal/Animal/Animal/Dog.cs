using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Dog : IAnimal
    {
        public void Drink()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Dog drinks water");
        }

        public void Eat()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Dog eats maet");
        }

        public void Sleep()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Dog sleep");
        }

        public void Speak()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Dog spek Gav");
        }
    }
}
