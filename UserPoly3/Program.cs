using System; 

// Our Main base class
class Person_005
{
    //getter setter
    public string Name_005 { get; set; }

    //constructor
    public Person_005(string name)
    {
        Name_005 = name;
    }

    //overriding ToString Method
    public override string ToString()
    {
        return $"Name_005: {Name_005}";
    }
}

//derived class of Student
class Student_005 : Person_005
{
    // Constructor 
    public Student_005(string name) : base(name) { }

    //method for studying
    public void Study()
    {
        Console.WriteLine($"{Name_005} is studying.");
    }
}

//derived class of Teacher
class Teacher : Person_005
{
    // Constructor to initialixe and passing the name to the base class constructor
    public Teacher(string name) : base(name) { }

    //method for explaining
    public void Explain()
    {
        Console.WriteLine($"{Name_005} is explaining.");
    }
}

//Our Main Class
class Program
{
    // Entry Point
    static void Main()
    {
        // creating an array for the Person_005
        Person_005[] people = new Person_005[3];

        // Instantniating two student and one teacher objects
        people[0] = new Student_005("Kushal Raj Shrama");
        people[1] = new Student_005("Amrit Paudel");
        people[2] = new Teacher("Bishal");

        foreach (var person in people)
        {
            Console.WriteLine(person);

            // if the person is student call the study method
            if (person is Student_005 student)
                student.Study();
            // If the person is a teacher, call the explain method
            else if (person is Teacher teacher)
                teacher.Explain();
        }
    }
}
