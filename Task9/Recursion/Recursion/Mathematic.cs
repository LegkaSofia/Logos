using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    class Mathematic
    {
        public long Factorial( long n)
        {
            if (n < 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
