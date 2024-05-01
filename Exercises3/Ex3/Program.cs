using System;

var numbers = new int[5];

Console.WriteLine("Enter 5 unique numbers:");
for (int i = 0; i < 5; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    var number = Convert.ToInt32(Console.ReadLine());

    if (Array.IndexOf(numbers, number) != -1)
    {
        Console.WriteLine("You've previously entered this number. Please try again.");
        i--;
        continue;
    }

    numbers[i] = number;
}

Array.Sort(numbers);

Console.WriteLine("Sorted numbers:");
foreach (var number in numbers)
{
    Console.WriteLine(number);
}