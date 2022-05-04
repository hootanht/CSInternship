// base class
public class Animal
{

    public string name;

    public virtual void Display()
    {
        Console.WriteLine("I am an animal");
    }

    protected void Eat()
    {
        Console.WriteLine("I can eat");
    }

}

// derived class of Animal 
public class Dog : Animal
{
    public void GetName()
    {
        Console.WriteLine("My name is " + name);
        //Dog dog = new Dog();
        //dog.Eat();
    }

    public override void Display()
    {
        Console.WriteLine("I am a dog");
    }
}

internal partial class Program
{
    private static void Main(string[] args)
    {
        // object of derived class
        Dog dog = new Dog
        {
            // access field and method of base class
            name = "Jesi"
        };
        dog.Display();
        //dog.Eat();

        // access method from own class
        dog.GetName();

        Console.ReadLine();
    }
}