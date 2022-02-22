namespace Animal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Drink();
            dog.Eat(Food.Meat);
            dog.Sleep();
            dog.Speak();
        }
    }
}
