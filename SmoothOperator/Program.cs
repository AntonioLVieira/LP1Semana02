using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insere número inteiro não-negativo: ");

            if (byte.TryParse(Console.ReadLine(), out byte n))
            {
                Console.WriteLine($"{--n}");
                Console.WriteLine($"{++n}");
                Console.WriteLine($"{n / 2}");
                Console.WriteLine($"{n << 3}");
                Console.WriteLine($"{n ^ 5}");
                Console.WriteLine($"{n > 10}");
            }
            else
            {
                Console.WriteLine("O número tem de ser positivo e inteiro!.");
            }
        }
    }
}