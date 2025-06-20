namespace DesignPatterns.Structural.Facade.Subsystems;

/// <summary>
/// VideoSystem class. Subsystem for video playback.
/// </summary>
public class VideoSystem
{
    /// <summary>
    /// Plays video.
    /// </summary>
    public void PlayVideo() => Console.WriteLine("Playing video...");
}