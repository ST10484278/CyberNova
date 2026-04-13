using System;
using System.Collections.Generic;
using System.Text;

namespace CyberNova
{
    public static class UI_ENHANCER

    {
       
        
            // Set global console style
            public static void SetConsoleStyle()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
            }

            // Divider line
            public static void PrintDivider()
            {
                Console.WriteLine("==============================================================");
            }


            // Bot typing simulation
            public static void SimulateTyping(string message)
            {
                foreach (char c in message)
                {
                    Console.Write(c);
                    Thread.Sleep(20); // typing speed
                }

                Console.WriteLine();
            }

            // Bot message with delay
            public static void DisplayBotMessage(string message)
            {
                Console.Write("\nCyberNova: ");

                Thread.Sleep(400); // pause before speaking

                SimulateTyping(message);
            }

            // User prompt
            public static void DisplayUserPrompt()
            {
                Console.Write("\nYou >>> ");
            }

            // Welcome banner
            public static void DisplayWelcomeBanner()
            {
                PrintDivider();
            Console.WriteLine(@"_________       ______             _____   ________               
__  ____/____  ____  /________________  | / /_  __ \__   _______ _
_  /    __  / / /_  __ \  _ \_  ___/_   |/ /_  / / /_ | / /  __ `/
/ /___  _  /_/ /_  /_/ /  __/  /   _  /|  / / /_/ /__ |/ // /_/ / 
\____/  _\__, / /_.___/\___//_/    /_/ |_/  \____/ _____/ \__,_/  
        /____/                                                    ");

            PrintDivider();
        }
    }
}
