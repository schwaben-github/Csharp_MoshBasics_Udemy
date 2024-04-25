namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 2;
            // byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Mosh";
            bool isWorking = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            // Ctrl + X to cut the line
            // View -> Object Browser

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            const float Pi = 3.14f;


            // Implicit Type Conversion
            byte b = 1; // 00000001
            int i = b; // 00000000 00000000 00000000 00000001

            // Explicit Type Conversion
            int j = 1;
            byte c = (byte)j; // casting!

            float f = 1.0f;
            int k = (int)f;  // casting!

            string s = "1";
            int l = Convert.ToInt32(s);
            int m = int.Parse(s);

            int n = 1; // chance of data loss if the number is too big!
            byte o = (byte)n;
            Console.WriteLine(o);

            // Non-compatible types
            var number1 = "1234";
            int number2 = Convert.ToInt32(number1);
            Console.WriteLine(number2);

            // Handling exceptions
            try
            {
                var number3 = "1234";
                byte number4 = Convert.ToByte(number3);
                Console.WriteLine(number4);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte.");
            }

            try
            {
                string str = "true";
                bool b1 = Convert.ToBoolean(str);
                Console.WriteLine(b1);
            }
            catch (Exception)
            {
                Console.WriteLine("The string could not be converted to a boolean.");
            }
        }
    }
}
