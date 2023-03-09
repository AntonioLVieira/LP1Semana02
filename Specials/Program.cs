using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.MaxValue;
            double y = double.MaxValue;
            float z = float.MaxValue;
            Console.WriteLine("Overflow from int.MaxValue is: " + (int) (x + 1));
            Console.WriteLine("Overflow from double.MaxValue is: " + (double) (y + 1) + " - The value stays the same!");
            Console.WriteLine("Overflow from float.MaxValue is: " + (float) (z + 1) + " - The value stays the same!");
            

            


        }
    }
}
