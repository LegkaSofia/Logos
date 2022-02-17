using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    interface IAnimal : ISpeakble, IEatable, IDrinkable, ISleepable
    {
    }
}
