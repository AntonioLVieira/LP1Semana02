using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio;
            double altura;
            double volume;
            double superficie;

            Console.WriteLine("Qual é a altura do cilindro?");
            raio = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o raio do cilindro?");
            altura = double.Parse(Console.ReadLine());
            volume = Math.PI * (raio * raio) * altura;
            superficie = 2 * Math.PI * (raio + altura);
            Console.WriteLine("O volume do cilindro é: " + volume + "\nA área de superficie do cilindro é: " + superficie);
        }
    }
}
