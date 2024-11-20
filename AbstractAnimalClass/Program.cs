using System;


// Creatuing a abstract class Animal_005
// and cannot be instantiated directly
abstract class Animal_005
{
    public string Name_005 { get; set; }

    // This should be implemented by derived class
    public abstract void Eat();

    // method for seting name for the animal
    public void SetName(string name)
    {
        Name_005 = name;
    }
    // method for getting name 
    public string GetName()
    {
        return Name_005;
    }
}

class Dog : Animal_005
{
    // implementing the abstract method
    public override void Eat()
    {
        Console.WriteLine($"{Name_005} is eating.");
    }
}

class Program
{
    static void Main()
    {
        //creating object of Dog class
        Dog dog = new Dog();
        Console.WriteLine("Enter the name of the dog: ");
        string name = Console.ReadLine();

        dog.SetName(name);
        Console.WriteLine($"Dog's Name: {dog.GetName()}.");
        dog.Eat();
    }
}