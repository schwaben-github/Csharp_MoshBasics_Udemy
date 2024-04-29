using System;

var random = new Random();
var secretNumber = random.Next(1, 10);
var chances = 4;

// Console.WriteLine("Secret number is: " + secretNumber);

for (int i = 0; i < chances; i++)
{
    Console.Write("Guess the number: ");
    var guess = Convert.ToInt32(Console.ReadLine());

    if (guess == secretNumber)
    {
        Console.WriteLine("You won");
        return;
    }
}

Console.WriteLine("You lost");