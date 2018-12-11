using System;

namespace Week03.P12
{
    public class Program
    {
        /// <summary>
        /// Write a function to count a total number of set bits in a 32 bit Integer? 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Functions.PrintByteArray(20);
            Console.WriteLine($"Set bits of {20}: {Functions.CountSetBits(20)}.");
        }
    }
}
