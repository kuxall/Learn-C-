using System;


//making interface with 2 functions
// 1. drive 
// 2. boolean refuel 
interface IVehiculo
{
    void Drive();
    bool Refuel(int amount);
}

//

class Car : IVehiculo
{
    private int gasoline;

    //parameterixed constructor
    public Car(int firstgasoline)
    {
        gasoline = firstgasoline;

    }

    //checking condition if the fuel is less than or more than and returning the value
    public void Drive()
    {
        if (gasoline > 0)
        {
            Console.WriteLine("Car is driving");
            gasoline--;
        }
        else
        {
            Console.WriteLine("Car is out of gasoline");
        }
    }
    //checking if the fuel is refueled or not
    public bool Refuel(int amount)
    {
        gasoline += amount;
        return true;
    }
}
// Main class
class Program
{
    //entry point of the program
    static void Main()
    {
        Car car = new Car(0);

        Console.Write("Enter gasoline amount to refuel: ");
        int amount = int.Parse(Console.ReadLine());
        car.Refuel(amount);

        car.Drive();
    }
}