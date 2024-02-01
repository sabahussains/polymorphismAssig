using System;

class Program
{
    static void Main()
    {
        // Create an object of type IQuittable using polymorphism
        IQuittable quittableEmployee = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };

        // Call the Quit() method on the object
        quittableEmployee.Quit();
    }
}
