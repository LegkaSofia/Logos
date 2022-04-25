using System;
using System.Threading;

namespace Bar
{
    internal class Program
    {
        private static ConsoleKey key;

        private static void Main(string[] args)
        {
            Console.CursorVisible = false;
            var @lock = new object();

            var bar = new Bar('#', @lock);

            var t = new Thread(bar.Start);
            var keyThread = new Thread(ReadKey);
            
            t.Start();
            keyThread.Start();

            var line = bar.Height + 1;
            while (!bar.Finished)
            {
                lock (@lock)
                {
                    Console.SetCursorPosition(0, line);
                    Console.Write("Hello");
                    Thread.Sleep(100);
                }

                if (key == ConsoleKey.Escape)
                {
                    break;
                }

                if (key == ConsoleKey.Enter)
                {
                    line++;
                    key = default;
                }
            }

            Console.Write("Finished");
        }

        private static void ReadKey()
        {
            while (key != ConsoleKey.Escape)
            {
                key = Console.ReadKey(true).Key;
            }
        }
    }
}
