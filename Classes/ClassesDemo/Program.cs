using ClassesDemo.Customer;

class Program
{ 
    static void Main(string[] args)
    {
        var john = new Person();
        john.FirstName = "John";
        john.LastName = "Smith";
        john.Introduce();

        var person = Person.Parse("Mary Jane");
        person.Introduce();

        var result = Person.Calculate(10, 20);
        Console.WriteLine(result);

        var customer = new Customer();
        customer.Id = 1;
        customer.Name = "John";
        customer.Introduce();

    }
}
