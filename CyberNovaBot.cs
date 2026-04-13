using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace CyberNova
{
    public class CyberNovaBot
    {

        /// This class has the following Responsibilities:
        /// - Plays greeting audio when the program starts
        /// - Processes user input
        /// - Matches keywords to cybersecurity topics
        /// - Returns appropriate responses
        /// - Provides help information to the user
        /// 


        // METHOD TO PLAY GREETING AUDIO
        public void PlayGreetingAudio()
        {
            try
            {
                
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                    "greeting.wav");


                // Check if the audio file exists
                if (File.Exists(path))
                {
                    Console.WriteLine("Audio file found. Playing sound...");
                    SoundPlayer player = new SoundPlayer(path);
                    player.PlaySync();      // Play the sound and wait until it finishes
                }
                else
                {   
                    // Inform the user if the file is missing
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

        public string GetResponse(string userInput, string userName)

        {
            // Check if the input is empty
            if (string.IsNullOrWhiteSpace(userInput))
                return "Please type a question.";

            string input = userInput.ToLower().Trim();

          

            // Small talk
            if (input.Contains("how are you"))
            {
                return "I am functioning well and ready to help you stay safe online.";
            }

            if (input.Contains("what is your purpose") || input.Contains("purpose"))
            {
                return "My purpose is to educate users about cybersecurity and help them protect themselves from online threats.";
            }


            if (input.Contains("what can you do"))
            {
                return "I can help you understand phishing, password safety, suspicious links, and other cybersecurity topics.";
            }

            // Cybersecurity Topics

            if (input.Contains("phishing"))
            {
                return "Phishing emails try to trick you into giving personal information. Always verify the sender and avoid clicking suspicious links.";
            }

            if (input.Contains("password"))
            {
                return "Use strong passwords with letters, numbers, and symbols. Avoid using personal information and never share your password.";
            }

            if (input.Contains("link") || input.Contains("url"))
            {
                return "Be careful with suspicious links. Always check the website address and make sure it starts with HTTPS.";
            }

            if (input.Contains("malware"))
            {
                return "Malware is harmful software designed to damage or gain unauthorized access to your computer system.";
            }

            if (input.Contains("virus"))
            {
                return "A computer virus is a type of malware that spreads between computers and can damage files or systems.";
            }

            if (input.Contains("ransomware"))
            {
                return "Ransomware is malware that locks your files and demands payment to unlock them.";
            }

            if (input.Contains("cybersecurity"))
            {
                return "Cybersecurity is the practice of protecting computers, networks, and data from cyber threats.";
            }

            if (input.Contains("safe browsing"))
            {
                return "Safe browsing includes avoiding suspicious websites, keeping your software updated, and using secure connections.";
            }

            if (input.Contains("scam"))
            {
                return "Scams are fraudulent attempts to steal money or information. Always verify messages before responding.";
            }

            if (input.Contains("privacy"))
            {
                return "Protect your privacy by using strong passwords, enabling two-factor authentication, and avoiding sharing personal information online.";
            }

            Random rand = new Random();

            string[] replies =
                               {
                                    "You're welcome!",
                                    "No problem! I'm happy to help.",
                                    "Glad I could assist you.",
                                    "Anytime! Stay safe online.",
                                    "You're welcome! Let me know if you need anything else."
                               };

            if (
                input.Contains("thank") ||
                input.Contains("thanks") ||
                input.Contains("thank you") ||
                input.Contains("ok") ||
                input.Contains("okay") ||
                input.Contains("alright")
            )
            {
                return replies[rand.Next(replies.Length)];
            }

            // Help command
            if (input == "help")
            {
                return ShowHelpMenu();
            }

            // Exit command
            if (input == "exit")
            {
                return "Goodbye " + userName + "! Stay safe online.";
            }

            // Default response
            return "I'm not sure about that yet, but I can help with cybersecurity topics. Type 'help' to see available options.";
        }

        private string ShowHelpMenu()
        {
            return
                "I can help you with the following topics:\n" +
                "- Phishing emails\n" +
                "- Safe password practices\n" +
                "- Suspicious links\n" +
                "- Malware and ransomware\n" +
                "- Cybersecurity basics";
        }
    }
}
