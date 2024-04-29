int sum = 0;
while (true)
{
    Console.Write("Enter a number or \"ok\" to exit: ");
    var input = Console.ReadLine();
    if (input == "ok")
    {
        break;
    }
    sum += Convert.ToInt32(input);
}

Console.WriteLine("Sum of all numbers is: " + sum);