using System;

namespace ChatGPTOne
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
                    Console.WriteLine("I'm t0kil");
                }
                else if (x == "How old are you?")
                {
                    Console.WriteLine("I'm 20");
                }
                
                else if (x == "What are your hobbies?")
                {
                    Console.WriteLine("I like to go to the gym!");
                }
                
                else if (x == "What do you wanna eat today?")
                {
                    Console.WriteLine("Pizza");
                }

                else if (x == "EXIT")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("I'm not that smart yet");
                }
                


                 
            }
            
        }
    }
}
