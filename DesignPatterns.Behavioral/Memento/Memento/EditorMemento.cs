namespace DesignPatterns.Behavioral.Memento.Memento;

public class EditorMemento
{
    public string Content { get; }

    public EditorMemento(string content) => Content = content;
}
