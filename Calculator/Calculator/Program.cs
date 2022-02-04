using System;

namespace Calculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            Console.WriteLine("Hello world!");

            Console.WriteLine("Chose: + - * / ");
            string action = Console.ReadLine();

            if (action != "+" && action != "-" && action != "*" && action != "/")
            {
                Console.WriteLine("Enter the correct character!");
                return;
            }

            Console.WriteLine("Enter a: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter b: ");
            b = double.Parse(Console.ReadLine());

            if (action == "+")
            {
                c = Add(a, b);
                Console.WriteLine("Result: ");
                Console.WriteLine("{0}+{1}={2}", a, b, c);
            }


            if (action == "-")
            {
                c = Minus(a, b);
                Console.WriteLine("Result: ");
                Console.WriteLine("{0}-{1}={2}", a, b, c);
            }


            if (action == "*")
            {
                c = Mnoz(a, b);
                Console.WriteLine("Result: ");
                Console.WriteLine("{0}*{1}={2}", a, b, c);
            }


            if (action == "/")
            {
                if (b == 0)
                {
                    Console.WriteLine("Result: ");
                    Console.WriteLine("Error:( ");
                }
                else
                {
                    c = Dilen(a, b);
                    Console.WriteLine("Result: ");
                    Console.WriteLine("{0}/{1}={2}", a, b, c);
                }
            }
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Minus(double a, double b)
        {
            return a - b;
        }

        static double Dilen(double a, double b)
        {
            return a / b;
        }

        static double Mnoz(double a, double b)
        {
            return a * b;
        }
    }
}
