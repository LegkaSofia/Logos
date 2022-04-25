using System;
using System.Threading;

namespace Bar
{
    internal class Bar
    {
        public Bar(char symbol)
        {
            Symbol = symbol;
        }

        public char Symbol { get; set; }

        public void Start()
        {
            var width = Console.WindowWidth;
            for (int i = 0; i < width; i++)
            {
                Console.Write(Symbol);
                Thread.Sleep(100);
            }
        }
    }
}
