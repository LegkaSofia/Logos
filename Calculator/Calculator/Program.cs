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

            static double add(double a, double b)
            {
                return a + b;
            }

            static double minus(double a, double b)
            {
                return a - b;
            }

            static double dilen(double a, double b)
            {
                return a / b;
            }

            static double mnoz(double a, double b)
            {
                return a * b;
            }

            Console.WriteLine("Hello world!");

            Console.WriteLine("Enter a: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter b: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Chose: + - * / ");
            string action = Console.ReadLine();



            if (action == "+")
            {
                c = add(a, b);
                Console.WriteLine("Result: ");
                Console.WriteLine("{0}+{1}={2}", a, b, c);
            }


            if (action == "-")
            {
                c = minus(a, b);
                Console.WriteLine("Result: ");
                Console.WriteLine("{0}-{1}={2}", a, b, c);
            }


            if (action == "*")
            {
                c = mnoz(a, b);
                Console.WriteLine("Result: ");
                Console.WriteLine("{0}*{1}={2}", a, b, c);
            }


            if (action == "/")
            {
                c = dilen(a, b);
                if (b == 0)
                {
                    Console.WriteLine("Result: ");
                    Console.WriteLine("Error:( ");
                }
                else
                {
                    Console.WriteLine("Result: ");
                    Console.WriteLine("{0}/{1}={2}", a, b, c);
                }
            }

            if (action != "+" && action != "-" && action != "*" && action != "/")
            {
                Console.WriteLine("Enter the correct character!");
            }

        }
    }
}
