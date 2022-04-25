using System;
using System.Threading;

namespace Bar
{
    class Bar
    {
        private object @lock;
        public Bar(char symbol, object @lock)
        {
            Symbol = symbol;
            Height = 2;
            this.@lock = @lock;
        }

        public char Symbol { get; }

        public int Height { get; }

        public bool Finished { get; private set; }

        public void Start()
        {
            var width = Console.WindowWidth;
            var line = 0;
            var position = 0;
            for (var i = 0; i < width; i++)
            {
                for (var j = 0; j < Height; j++)
                {
                    lock (@lock)
                    {
                        Console.SetCursorPosition(position, line + j);
                        Console.Write(Symbol);
                    }
                }

                position++;
                Thread.Sleep(100);
            }

            Finished = true;
        }
    }

}