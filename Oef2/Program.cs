using System;

namespace Oef2
{
    internal class Program
    {
        static double genereerRandom(int x, int y)
        {
            Random rng = new();
            double random = 0;

            if (x == y)
            {
                random = rng.NextDouble() * (2*x);
            }
            else
            {
                random = rng.NextDouble() * (y - x) + x;
            }
            
            
            return random;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(genereerRandom(12,56));
        }
    }
}