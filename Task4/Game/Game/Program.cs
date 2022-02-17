using System;

namespace Game
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int a = 3;
            Console.WriteLine("Яке число я загадав вiд 1 до 10?");
            Console.WriteLine("Введи своє число: ");
            int guess = int.Parse(Console.ReadLine());

            while(guess != 1 && guess != 2 && guess != 3 && guess != 4 && guess != 5 && guess != 6 && guess != 7 && guess != 8 && guess != 9 && guess != 10)
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
            }

            while (a == guess)
            {
                Console.WriteLine("Ура! Ти вгадав!!!");
                break;
            }

        }
    }
}
