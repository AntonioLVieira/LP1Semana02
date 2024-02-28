using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insere número inteiro não-negativo: ");

            // Recebe a entrada do usuário e converte para byte
            if (byte.TryParse(Console.ReadLine(), out byte n))
            {
                // Realiza as operações e exibe os resultados
                Console.WriteLine($"Resultado da operação de decremento de {n}: {--n}");
                Console.WriteLine($"Resultado da operação de incremento de {n}: {++n}");
            }
            else
            {
                Console.WriteLine("O número tem de ser positivo e inteiro!.");
            }
        }
    }
}