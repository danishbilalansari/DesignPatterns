using DesignPatterns.Structural.Facade.Subsystems;

namespace DesignPatterns.Structural.Facade.Facade;

public class MediaFacade
{
    private readonly AudioSystem _audio = new();
    private readonly VideoSystem _video = new();

    public void PlayMedia()
    {
        _video.PlayVideo();
        _audio.PlaySound();
    }
}