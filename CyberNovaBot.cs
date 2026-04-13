using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace CyberNova
{
    public class CyberNovaBot
    {

        // METHOD TO PLAY GREETING AUDIO
        public void PlayGreetingAudio()
        {
            try
            {
                Console.WriteLine("Program directory:");
                Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);

                string path = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "greeting.wav"
                );

                if (File.Exists(path))
                {
                    Console.WriteLine("Audio file found. Playing sound...");
                    SoundPlayer player = new SoundPlayer(path);
                    player.PlaySync();
                }
                else
                {
                    Console.WriteLine("Audio file NOT found at:");
                    Console.WriteLine(path);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Audio file could not be played.");
                Console.WriteLine(ex.Message);
            }
        }

        public string GetResponse(string userInput)
        {
            if (string.IsNullOrWhiteSpace(userInput))
                return "Please type a question.";

            string input = userInput.ToLower();

            if (input.Contains("phishing"))
            {
                return "Phishing emails try to trick you into giving personal information. Always verify the sender.";
            }

            if (input.Contains("password"))
            {
                return "Use strong passwords with letters, numbers, and symbols. Never share your password.";
            }

            if (input.Contains("link"))
            {
                return "Be careful with suspicious links. Check the website address before clicking.";
            }

            if (input == "help")
            {
                return "I can help with:\n- Phishing emails\n- Safe password practices\n- Suspicious links";
            }

            if (input == "exit")
            {
                return "Goodbye!";
            }

            return "I can help with cybersecurity topics. Type 'help' to see options.";
        }
    }
}
