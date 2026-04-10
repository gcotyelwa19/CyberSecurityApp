using System;
using System.Media;
using System.IO;

class AudioPlayer
{
    // Play the greeting.wav located next to the running executable or in the current directory
    public void PlayGreeting()
    {
        string exeDir = AppContext.BaseDirectory ?? Directory.GetCurrentDirectory();
        string path = Path.Combine(exeDir, "greeting.wav");

        if (!File.Exists(path))
        {
            // fallback to current directory
            path = Path.Combine(Directory.GetCurrentDirectory(), "greeting.wav");
        }

        if (!File.Exists(path))
        {
            Console.Error.WriteLine($"greeting.wav not found. Tried: {exeDir} and {Directory.GetCurrentDirectory()}");
            return;
        }

        PlayGreeting(path);
    }

    public void PlayGreeting(string path)
    {
        try
        {
            SoundPlayer player = new SoundPlayer(path);
            player.PlaySync();
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Failed to play sound: {ex.Message}");
        }
    }
}
