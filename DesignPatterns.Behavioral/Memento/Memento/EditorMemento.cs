namespace DesignPatterns.Behavioral.Memento.Memento;

/// <summary>
/// EditorMemento class. Memento for storing the state of the TextEditor.
/// </summary>
public class EditorMemento
{
    /// <summary>
    /// Initializes a new instance of EditorMemento.
    /// </summary>
    /// <param name="content">The content to store.</param>
    public EditorMemento(string content) => Content = content;

    public string Content { get; }
}
