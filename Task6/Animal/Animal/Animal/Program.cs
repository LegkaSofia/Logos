using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Drink();
            dog.Eat();
            dog.Sleep();
            dog.Speak();
        }
    }
}
