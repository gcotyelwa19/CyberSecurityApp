using System;

class Program
{
    static void Main(string[] args)
    {
        // Play greeting sound before any ASCII/art or bot output
        AudioPlayer audio = new AudioPlayer();
        audio.PlayGreeting();

        // Get user details
        User user = new User();
        Console.Write("Please enter your name: ");
        user.Name = Console.ReadLine();

        // Start chatbot (ASCII/art will appear after the sound)
        Chatbot bot = new Chatbot();
        bot.Start(user.Name);
    }
}
