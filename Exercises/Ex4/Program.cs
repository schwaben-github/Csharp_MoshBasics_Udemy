Console.Write("Enter the speed limit: ");
int speedLimit = int.Parse(Console.ReadLine());

Console.Write("Enter the speed of the car: ");
int carSpeed = int.Parse(Console.ReadLine());

if (carSpeed <= speedLimit)
{
    Console.WriteLine("The car is within the speed limit.");
}
else
{
    int demeritPoints = (carSpeed - speedLimit) / 5;
    if (demeritPoints > 12)
    {
        Console.WriteLine("License suspended.");
    }
    else
    {
        Console.WriteLine("Demerit points: " + demeritPoints);
    }
}