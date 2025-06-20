using DesignPatterns.Structural.Facade.Subsystems;

namespace DesignPatterns.Structural.Facade.Facade;

/// <summary>
/// MediaFacade class. Facade for audio and video subsystems.
/// </summary>
public class MediaFacade
{
    private readonly AudioSystem _audio = new();
    private readonly VideoSystem _video = new();

    /// <summary>
    /// Plays both video and audio using the subsystems.
    /// </summary>
    public void PlayMedia()
    {
        _video.PlayVideo();
        _audio.PlaySound();
    }
}