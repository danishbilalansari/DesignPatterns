using DesignPatterns.Behavioral.Memento.Memento;

namespace DesignPatterns.Behavioral.Memento.Originator;

/// <summary>
/// TextEditor class. Originator in the memento pattern.
/// </summary>
public class TextEditor
{
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// Saves the current state to a memento.
    /// </summary>
    /// <returns>An EditorMemento containing the current content.</returns>
    public EditorMemento Save() => new(Content);

    /// <summary>
    /// Restores the state from a memento.
    /// </summary>
    /// <param name="memento">The memento to restore from.</param>
    public void Restore(EditorMemento memento) => Content = memento.Content;
}
