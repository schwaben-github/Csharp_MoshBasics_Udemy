var random = new Random();

const int passwordLength = 10;
var buffer = new char[passwordLength];

for (int i = 0; i < passwordLength; i++)
{
    int randomValue = random.Next(0, 62);
    if (randomValue < 10)
    {
        // Generate a random digit
        buffer[i] = (char)('0' + randomValue);
    }
    else if (randomValue < 36)
    {
        // Generate a random uppercase letter
        buffer[i] = (char)('A' + randomValue - 10);
    }
    else
    {
        // Generate a random lowercase letter
        buffer[i] = (char)('a' + randomValue - 36);
    }
}

var password = new string(buffer);

Console.WriteLine(password);
