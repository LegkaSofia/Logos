using System;

namespace Shop.Enums
{
    [Flags]
    internal enum WayToBuyProduct
    {
        ShopWay = 0,
        PostWay = 1,
        PickUpWay = 2,
    }
}
