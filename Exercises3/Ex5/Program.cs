// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
// If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
// otherwise, display the 3 smallest numbers in the list.

using System;
using System.Linq;

Console.WriteLine("Enter a list of comma separated numbers (e.g 5, 1, 9, 2, 10):");
var input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Invalid List. Please try again.");
    return;
}

var numbers = input.Split(',').Select(n => Convert.ToInt32(n)).ToArray();
if (numbers.Length < 5)
{
    Console.WriteLine("Invalid List. Please try again.");
    return;
}

Array.Sort(numbers);
Console.WriteLine($"The 3 smallest numbers are: {numbers[0]}, {numbers[1]}, {numbers[2]}");
Console.ReadLine();

