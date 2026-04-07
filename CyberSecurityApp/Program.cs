class Program
{
    static void Main(string[] args)
    {
        // Play greeting sound
        AudioPlayer audio = new AudioPlayer();
        audio.PlayGreeting(@"C:\Users\mbuti\source\repos\CyberSecurityApp\CyberSecurityApp\greeting.wav");

        // Get user details
        User user = new User();
        Console.Write("Please enter your name: ");
        user.Name = Console.ReadLine();

        // Start chatbot
        Chatbot bot = new Chatbot();
        bot.Start(user.Name);
    }
}