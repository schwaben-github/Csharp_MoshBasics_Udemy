// Write a program and ask the user to enter a series of numbers separated by comma.
// Find the maximum of the numbers and display it on the console.

using System;

Console.Write("Enter numbers separated by comma: ");

var input = Console.ReadLine();
var numbers = input.Split(',');
var max = Convert.ToInt32(numbers[0]);

foreach (var number in numbers)
{
    var num = Convert.ToInt32(number);
    if (num > max)
    {
        max = num;
    }
}

Console.WriteLine("Max number is: " + max);