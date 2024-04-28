Console.WriteLine("Enter width and height of the photo: ");
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

if (width > height)
{
    Console.WriteLine("The photo is in landscape mode.");
}
else
{
    Console.WriteLine("The photo is in portrait mode.");
}