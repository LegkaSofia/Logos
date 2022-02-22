using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Dog : IAnimal, IHealth
    {
        public int Health { get; set; }

        public void Drink()
        {
            Console.WriteLine("Dog drinks water");
        }

        public void Eat(Food food)
        {
            Console.WriteLine("Dog eats {0}", food);
        }

        public void Sleep()
        {
            Console.WriteLine("Dog sleep");
        }

        public void Speak()
        {
            Console.WriteLine("Dog spek Gav");
        }
    }
}
