using DesignPatterns.Behavioral.Memento.Memento;

namespace DesignPatterns.Behavioral.Memento.Caretaker;

public class History
{
    private readonly Stack<EditorMemento> _history = new();

    public void Push(EditorMemento memento) => _history.Push(memento);

    public EditorMemento Pop() => _history.Pop();
}
