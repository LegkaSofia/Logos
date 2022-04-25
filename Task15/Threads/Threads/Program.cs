using System;
using System.Threading;

namespace Threads
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Thread t = new Thread(Method1);
            t.Start();
            t.Join();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} - {1}", nameof(Main), i);
            }
        }

        public static void Method1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} - {1}",nameof(Method1), i);
            } 
        }
    }
}
