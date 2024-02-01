using System;

// Employee class inheriting the IQuittable interface
public class Employee : IQuittable
{
    // Properties of the Employee class
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Implementation of the Quit method from the IQuittable interface
    public void Quit()
    {
        Console.WriteLine($"Employee {FirstName} {LastName} is quitting!");
    }
}
