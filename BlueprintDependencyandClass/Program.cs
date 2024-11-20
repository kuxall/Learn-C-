using System;

//class location
public class Location
{
    //properties
    public double X { get; set; }
    public double Y { get; set; }

    public Location(double x, double y)
    {
        X = x;
        Y = y;
    }

    //overriding the ToString method
    public override string ToString()
    {
        return $"({X}, {Y})";
    }

}

public abstract class Shape
{
    public Location Location { get; set; }
    public Shape(double x, double y)
    {
        Location = new Location(x, y);
    }

    public  double Area()
    {
        return 1;
    }
    public  double Perimeter()
    {
        return 1;
    }

    public override string ToString()
    {
        return $"Location: {Location}";
    }
}

public class Rectangle: Shape
{
    protected double side1, side2;

    //Other essential fucntions if required
}

//declaring the circle that inherits shape
public class Circle : Shape
{
    // declaring the radius
    protected double Radius;
    
}
