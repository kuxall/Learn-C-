using System;
public class Person
{
    protected int age;
    public void Greet()
    {
        Console.WriteLine("Hello!");
    }
    public void SetAge(int age)
    {
        this.age = age;
    }
}

public class Student : Person
{
    public void study()
    {
        Console.WriteLine("Studying");
    }
    public void ShowAge()
    {
        Console.WriteLine("My age is: {0} years old", age);
    }
}

public class Teacher : Person
{
    public void Explain()
    {
        Console.WriteLine("I'm explaining");
    }
}

public class StudentProfessorTest
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person();
        myPerson.Greet();

        Student myStudent = new Student();
        myStudent.SetAge(25);
        myStudent.Greet();
        myStudent.ShowAge();

        Teacher myTeacher = new Teacher();
        myTeacher.SetAge(45);
        myTeacher.Greet();
        myTeacher.Explain();
    }
}