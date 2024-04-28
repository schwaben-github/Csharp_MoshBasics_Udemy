public class Person
{
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        int number = 1;
        Increment(number);
        Console.WriteLine(number); // 1

        Person person = new Person() { Age = 20 };
        MakeOld(person);
        Console.WriteLine(person.Age); // 30
    }

    public static void Increment(int number)
    {
        number += 10;
    }

    public static void MakeOld(Person person)
    {
        person.Age += 10;
    }
}