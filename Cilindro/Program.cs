using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Insira a altura do cilindro: ");
            float altura = float.Parse(Console.ReadLine());

            Console.Write("Insira o raio do cilindro: ");
            float raio = float.Parse(Console.ReadLine());
           
            float volume = MathF.PI * MathF.Pow(raio, 2) * altura;
            float Superficie = 2 * MathF.PI * raio * (raio + altura);

            Console.WriteLine($"O volume do cilindro é: {volume}");
            Console.WriteLine($"A área da superfície do cilindro é: {Superficie}");
        }
    }
}