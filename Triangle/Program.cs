using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(args[0]);
            string y = args[1];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(y);
                }
                Console.WriteLine(" ");
            }
        }
    }
}
