// See https://aka.ms/new-console-template for more information
public class Animal
{
    public virtual string speak()
    {
        return "Animal sound";
    }
}
public class Dog : Animal
{
    public override string speak()
    {
        return "Woof!";
    }
}

public class Cat : Animal
{
    public override string speak()
    {
        return "Meow!";
    }
}

public class Cow : Animal
{
    public override string speak()
    {
        return "Moo!";
    }
}

public class AnimalMenu
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Select an animal to hear its sound:");
        Console.WriteLine("1. Dog");
        Console.WriteLine("2. Cat");
        Console.WriteLine("3. Cow");
        Console.Write("Enter your choice (1-3): ");
        int choice = int.Parse(Console.ReadLine()!);
        Animal animal;
        switch (choice)
        {
            case 1:
                animal = new Dog();
                break;
            case 2:
                animal = new Cat();
                break;
            case 3:
                animal = new Cow();
                break;
            default:
                Console.WriteLine("Invalid choice. Defaulting to Animal.");
                animal = new Animal();
                break;
        }
        Console.WriteLine("The animal says: " + animal.speak());
    }
}