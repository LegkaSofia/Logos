using System;

namespace ConsoleApp1
{
    struct MyStruct
    {
        public decimal a;
        public int b;
        public int c;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyStruct a = new MyStruct();
            Console.WriteLine("Size of my struct:  {0} ", System.Runtime.InteropServices.Marshal.SizeOf(a));
        }
    }
}
