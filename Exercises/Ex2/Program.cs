Console.Write("Enter two numbers to compare: ");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("The number {0} is higher.", number1);
}
else
{
    Console.WriteLine("The number {0} is higher.", number2);
}