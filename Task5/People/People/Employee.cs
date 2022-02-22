using System;
using System.Collections.Generic;
using System.Text;

namespace People
{
   abstract class Employee : Human
    {
        public abstract string Position { get; }
    }
}
