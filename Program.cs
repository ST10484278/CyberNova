using System;
using System.Threading;

namespace CyberNova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UI_ENHANCER.SetConsoleStyle();

            // Create an instance of the chatbot
            CyberNovaBot bot = new CyberNovaBot();


            // Play greeting audio
            bot.PlayGreetingAudio();   

            UI_ENHANCER.DisplayWelcomeBanner();


            // Ask the user for their name
            Console.WriteLine("Please enter your name to begin the conversation.");
            string userName = Console.ReadLine();

            Thread.Sleep(500);

            UI_ENHANCER.DisplayBotMessage(
                "Hello " + userName +
                "! I am CyberNova, your cybersecurity assistant."
            );

            // Display instructions
            Console.WriteLine("Type 'help' to see topics");
            Console.WriteLine("Type 'exit' to quit");

            UI_ENHANCER.PrintDivider();

            // MAIN CONVERSATION LOOP
            while (true)
            {
                UI_ENHANCER.DisplayUserPrompt();

                string userInput = Console.ReadLine();

                string response =
                    bot.GetResponse(userInput, userName);

                UI_ENHANCER.DisplayBotMessage(response);

                if (userInput.ToLower() == "exit")
                    break;
            }

            UI_ENHANCER.PrintDivider();

            UI_ENHANCER.DisplayBotMessage(
                "Session ended. Stay safe online."
            );
        }
    }
}