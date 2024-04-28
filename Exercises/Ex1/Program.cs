Console.Write("Enter a number between 1 and 10: ");
int number = int.Parse(Console.ReadLine());

if (number >= 1 && number <= 10)
{
    Console.WriteLine("Valid number entered: " + number);
}
else
{
    Console.WriteLine("Invalid number. Please enter a number between 1 and 10.");
}
