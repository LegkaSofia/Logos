namespace Shop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ShopManagmante.ShowOptions();
            while (true)
            {
                ShopManagmante.HandleChoise();
            }
        }
    }
}
