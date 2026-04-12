using System.Media;
using System.IO;
namespace CyberNova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CyberNovaBot bot = new CyberNovaBot();

          
            Console.WriteLine("Please enter your name to begin the conversation.");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " +userName+"! Welcome to cybersecurity chatbot.");
    

            
            Console.WriteLine("Type 'help' for topics.");
            Console.WriteLine("Type 'exit' to quit.");

            while (true)
            {
                Console.Write("\nYou: ");
                string userInput = Console.ReadLine();

                string response = bot.GetResponse(userInput);

                Console.WriteLine("CyberNova: " + response);

                if (userInput.ToLower() == "exit")
                    break;
            }
        }
    }
}
