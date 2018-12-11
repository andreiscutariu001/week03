using System;

namespace Week03.P12
{
    public class Functions
    {
        public static int CountSetBits(int number)
        {
            var bytes = IntToBinaryString(number);
            var setBits = 0;

            foreach (var b in bytes)
            {
                if (b == '1')
                {
                    setBits++;
                }
            }

            return setBits;
        }

        public static void PrintByteArray(int number)
        {
            var s = IntToBinaryString(number);
            Console.WriteLine($"Bits of {number}: {s}.");
        }

        public static string IntToBinaryString(int number)
        {
            const int mask = 1;
            var binary = string.Empty;
            while (number > 0)
            {
                // Logical AND the number and prepend it to the result string
                binary = (number & mask) + binary;
                number = number >> 1;
            }

            return binary;
        }
    }
}