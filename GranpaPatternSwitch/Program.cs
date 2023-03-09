using System;

namespace ChatGPTGrandfather
{
    public class Program
    {
        private static void Main(string[] args)
    
            // Colocar questão ao utilizador
            Console.Write("Place your question? ");
            question = Console.ReadLine();

            // Verificar se se trata de uma questão conhecida e determinar uma
            // resposta adequada
             string question, response = question switch
            {
                1 => "How are you?",
                2 => "What's your name?",
                3 => "What's your mission?",
                _ => "You got me, I'm not THAT smart!",
            }

            // Responder adequadamente
            Console.WriteLine(response);
        }
    }
}
