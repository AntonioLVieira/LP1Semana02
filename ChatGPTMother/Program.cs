using System;

namespace ChatGPTMother
{
    class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                Console.WriteLine("Ask me anything");
                string x = Console.ReadLine();

                if (x == "What's your name?")
                {
                    Console.WriteLine("My name is Oscar");
                }
                else if (x == "How old are you?")
                {
                    Console.WriteLine("I'm 41 years old");
                }
                
                else if (x == "What are you doing?")
                {
                    Console.WriteLine("I'm just watching you");
                }
                
                else if (x == "What's your favorite food?")
                {
                    Console.WriteLine("Chicken Tikka Masala");
                }

                else if (x == "EXIT")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("I'm not that intelligent");
                }
                


                 
            }
            
        }
    }
}