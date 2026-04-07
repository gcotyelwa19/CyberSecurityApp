using System;
using System.Media;

class AudioPlayer
{
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