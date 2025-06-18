using DesignPatterns.Behavioral.Memento.Memento;

namespace DesignPatterns.Behavioral.Memento.Originator;

public class TextEditor
{
    public string Content { get; set; } = string.Empty;

    public EditorMemento Save() => new(Content);

    public void Restore(EditorMemento memento) => Content = memento.Content;
}
