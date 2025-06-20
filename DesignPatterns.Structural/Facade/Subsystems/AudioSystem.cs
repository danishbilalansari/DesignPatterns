namespace DesignPatterns.Structural.Facade.Subsystems;

/// <summary>
/// AudioSystem class. Subsystem for audio playback.
/// </summary>
public class AudioSystem
{
    /// <summary>
    /// Plays audio.
    /// </summary>
    public void PlaySound() => Console.WriteLine("Playing audio...");
}