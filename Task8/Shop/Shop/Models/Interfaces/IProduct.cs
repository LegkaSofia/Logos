using Shop.Enums;

namespace Shop.Models
{
    internal interface IProduct
    {
        string Name { get; set; }

        double Price { get; set; }

        WayToBuyProduct WayToBuy { get; }
    }
}
