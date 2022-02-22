using System;

namespace Game
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 11);
            Console.WriteLine("Яке число я загадав вiд 1 до 10?");
            Console.WriteLine("Введи своє число: ");
            int guess = int.Parse(Console.ReadLine());

            while (guess > 10 || guess < 1)
            {
                Console.WriteLine("Введи число в заданих межах!");
                guess = int.Parse(Console.ReadLine());
            }

            while (a != guess)
            {
                Console.WriteLine("Спробуй ще!");

                if (a > guess)
                {
                    Console.WriteLine("Введи бiльше число:");
                }
                else
                {
                    Console.WriteLine("Введи менше число:");
                }
                guess = int.Parse(Console.ReadLine());

                while (guess > 10 || guess < 1)
                {
                    Console.WriteLine("Введи число в заданих межах!");
                    guess = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Ура! Ти вгадав!!!");
        }
    }
}
