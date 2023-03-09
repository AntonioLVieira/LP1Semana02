using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.PositiveInfinity;
            double y = double.NegativeInfinity;
            float v = float.PositiveInfinity;
            float z = float.NegativeInfinity;
            double i = double.PositiveInfinity / double.PositiveInfinity;
            float j = float.PositiveInfinity / float.PositiveInfinity;

            Console.WriteLine("Special PositiveInfinity value of double is: " + x + " and the Special NegativeInfinity value of double is : " + y);
            Console.WriteLine("Special PositiveInfinity value of float is: " + v + " and the Special NegativeInfinity value of float is : " + z);
            Console.WriteLine("Special Value of double: " + i);
            Console.WriteLine("Special Value of float: " + j);

            


        }
    }
}
