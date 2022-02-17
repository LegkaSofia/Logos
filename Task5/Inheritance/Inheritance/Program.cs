using Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Cat();
        Animal animal1 = new Dog();
        animal.Say();
        animal1.Say();
    }
}