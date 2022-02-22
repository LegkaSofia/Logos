using System;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            Cashier cashier = new Cashier();
            cashier.Name = "Gala";
            cashier.Surname = "Zebra";
            cashier.Scan();

            Accountant accountant = new Accountant();
            accountant.Name = "Vika";
            accountant.Surname = "Senuk";
            accountant.Calculate();

            Manager manager = new Manager();
            manager.Name = "Zhenya";
            manager.Surname = "Golova";
            manager.Helps();

            Shopper shopper = new Shopper();
            shopper.Name = "Kata";
            shopper.Surname = "1";
            shopper.Buys();
        }
    }
}
