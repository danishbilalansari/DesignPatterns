using DesignPatterns.Behavioral.Memento.Memento;

namespace DesignPatterns.Behavioral.Memento.Caretaker;

/// <summary>
/// History class. Caretaker that manages mementos for undo functionality.
/// </summary>
public class History
{
    private readonly Stack<EditorMemento> _history = new();

    /// <summary>
    /// Pushes a memento onto the history stack.
    /// </summary>
    /// <param name="memento">The memento to push.</param>
    public void Push(EditorMemento memento) => _history.Push(memento);

    /// <summary>
    /// Pops a memento from the history stack.
    /// </summary>
    /// <returns>The most recent EditorMemento.</returns>
    public EditorMemento Pop() => _history.Pop();
}
