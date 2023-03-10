using System;

namespace HardDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(args[0]);
            if (x % 2 == 0)
            {
                Console.WriteLine("I only want odd numbers!");
            }
            if (x % 2 != 0)
            {
                int count = x - 1;
                for (int i = 1; i <= x; i++)
                {
                    for (int j = 1; j <= count; j++)
                    {
                        Console.Write(" ");

                    }
                    count--;
                    for (int j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();
                }       
                count = 1;
                for (int i = 1; i <= x; i++)
                {
                    for (int j = 1; j <= count; j++)
                    {
                        Console.Write(" ");
                    }
                    count++;
                    for (int j = 1; j <= 2 * (x - i) - 1; j++)
                    {
                        Console.Write(".");
                    }
                    Console.WriteLine();

                }
            }


        
                   
                
                
        
            
        }
            
    }
}

