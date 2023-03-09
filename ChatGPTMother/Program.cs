using System;

namespace ChatGPTMother
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Ask me anything");
                if (x == "What's you name")
                {
                    Console.WriteLine("My name is Oscar");
                }
                else if (x == "How old are you")
                {
                    Console.WriteLine("I'm 41 years old");
                }
                
                else if (x == "What are you doing")
                {
                    Console.WriteLine("I'm just watching you");
                }
                
                else if (x == "What's you favourite food?")
                {
                    Console.WriteLine("Chicken Tikka Masala");
                }

                else if (x == "EXIT")
                {
                    break;
                }

                else
                {
                    break;
                }
                


                 
            }
            
        }
    }
}
