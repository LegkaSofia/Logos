using Shop.Enums;

namespace Shop.Models
{
    internal class Product : IProduct
    {
        public Product(WayToBuyProduct wayToBuy)
        {
            WayToBuy = wayToBuy;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public WayToBuyProduct WayToBuy { get; private set; }
    }
}