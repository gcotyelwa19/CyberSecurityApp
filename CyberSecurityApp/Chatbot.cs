using System;
using System.Threading;

class Chatbot
{
    public void Start(string userName)
    {
        // Borders
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("===================================");
        Console.WriteLine("        CYBERSECURITY CHATBOT");
        Console.WriteLine("===================================");
        Console.ResetColor();

        // greeting already played in Program.Main

        // ASCII art
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(@"
   oooo       .o.       ooooooooo.   oooooo     oooo ooooo  .oooooo..o 
   `888      .888.      `888   `Y88.  `888.     .8'  `888' d8P'    `Y8 
    888     .8""888.      888   .d88'   `888.   .8'    888  Y88bo.       
    888    .8' `888.     888ooo88P'     `888. .8'     888   `""Y8888o.   
    888   .88ooo8888.    888`88b.        `888.8'      888       `""Y88b 
    888  .8'     `888.   888  `88b.       `888'       888  oo     .d8P 
.o. 88P o88o     o8888o o888o  o888o       `8'       o888o 8""""88888P' 
`Y888P                                                                 
");
        Console.ResetColor();

        // Typing effect intro
        Console.ForegroundColor = ConsoleColor.Cyan;
        foreach (char c in "Hello, I am JARVIS — your Cybersecurity Awareness Bot!")
        {
            Console.Write(c);
            Thread.Sleep(40);
        }
        Console.WriteLine();
        Console.ResetColor();

        // Personalized greeting
        Console.WriteLine($"Welcome {userName}! I’m here to help you stay safe online.");

        // Menu loop
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n========= MENU =========");
            Console.WriteLine("1. How are you?");
            Console.WriteLine("2. Purpose of JARVIS");
            Console.WriteLine("3. Password tips");
            Console.WriteLine("4. Phishing awareness");
            Console.WriteLine("5. Malware info");
            Console.WriteLine("6. Firewall basics");
            Console.WriteLine("7. Social engineering");
            Console.WriteLine("8. Safe browsing");
            Console.WriteLine("9. Importance of updates");
            Console.WriteLine("10. Take Cybersecurity Quiz");
            Console.WriteLine("11. What is encryption?");
            Console.WriteLine("12. What is two-factor authentication?");
            Console.WriteLine("13. What is ransomware?");
            Console.WriteLine("14. What is VPN?");
            Console.WriteLine("15. Data breach (coming soon)");
            Console.WriteLine("0. Exit");
            Console.WriteLine("========================");
            Console.ResetColor();

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("I'm functioning at optimal capacity, thank you!");
                    break;
                case "2":
                    Console.WriteLine("My purpose is to raise cybersecurity awareness and help you stay safe online.");
                    break;
                case "3":
                    Console.WriteLine("Always use strong, unique passwords. A mix of letters, numbers, and symbols is best.");
                    break;
                case "4":
                    Console.WriteLine("Phishing is when attackers trick you into giving personal info. Never click suspicious links.");
                    break;
                case "5":
                    Console.WriteLine("Malware is harmful software designed to damage or steal data. Keep your antivirus updated.");
                    break;
                case "6":
                    Console.WriteLine("A firewall acts like a barrier, blocking unauthorized access while allowing safe traffic.");
                    break;
                case "7":
                    Console.WriteLine("Social engineering is when attackers trick people into revealing information. Always verify requests.");
                    break;
                case "8":
                    Console.WriteLine("Safe browsing means avoiding suspicious sites, not downloading unknown files, and keeping your browser updated.");
                    break;
                case "9":
                    Console.WriteLine("Regular updates patch security holes. Always keep your system and apps up to date.");
                    break;
                case "10":
                    Quiz quiz = new Quiz();
                    quiz.Start();
                    break;
                case "11":
                    Console.WriteLine("Encryption is the process of converting data into a code to prevent unauthorized access.");
                    break;
                case "12":
                    Console.WriteLine("Two-factor authentication adds an extra layer of security by requiring a second form of verification.");
                    break;
                case "13":
                    Console.WriteLine("Ransomware is malware that locks your files and demands payment to unlock them.");
                    break;
                case "14":
                    Console.WriteLine("A VPN (Virtual Private Network) hides your IP address and encrypts your internet traffic for privacy.");
                    break;
                case "15":
                    Console.WriteLine("Oh no! It looks like we're still developing that feature 🙂");
                    break;
                case "0":
                    Console.WriteLine("Are you sure you want to exit? (y/n)");
                    string confirm = Console.ReadLine();
                    if (confirm?.ToLower() == "y")
                    {
                        Console.WriteLine("Bye for now! Stay safe online!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Exit cancelled. Returning to menu...");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a number from the menu.");
                    break;
            }
        }
    }
}