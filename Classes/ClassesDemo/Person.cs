public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void Introduce()
    {
        Console.WriteLine("My name is " + FirstName + " " + LastName);
    }

    public static Person Parse(string str)
    {
        var person = new Person();
        person.FirstName = str.Split(' ')[0];
        person.LastName = str.Split(' ')[1];
        return person;
    }

    public static int Calculate(int a, int b)
    {
        return a + b;
    }

    public static void StaticMethod()
    {
        Console.WriteLine("Static Method");
    }

    public void InstanceMethod()
    {
        Console.WriteLine("Instance Method");
    }
}
