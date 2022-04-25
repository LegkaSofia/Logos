namespace Shop.Models
{
    internal class Check
    {
        public Check()
        {
            Products = new ProductCollection();
        }

        public ProductCollection Products { get; set; }

        public void Add(Product product)
        {
            Products.Add(product);
        }

        public double TotalPrice()
        {
            double sum = 0;
            for (int i = 0; i < Products.Count; i++)
            {
                Product p = Products[i];
                sum = sum + p.Price;
            }
            return sum;
        }

        public double PDV()
        {
            double sum1 = 0;
            for (int i = 0; i < Products.Count; i++)
            {
                Product p = Products[i];
                sum1 = sum1 + p.Price * 0.8;
            }
            return sum1;
        }
    }
}
