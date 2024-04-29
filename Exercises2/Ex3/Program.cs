Console.Write("Enter a number: ");
var number = Convert.ToInt32(Console.ReadLine());

var factorial = 1;

for (int i = 1; i <= number; i++)
{
    factorial *= i;
}

Console.WriteLine("Factorial of {0}! = {1}", number, factorial);