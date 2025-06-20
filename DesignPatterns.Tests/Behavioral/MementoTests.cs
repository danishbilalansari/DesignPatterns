using DesignPatterns.Behavioral.Memento.Caretaker;
using DesignPatterns.Behavioral.Memento.Originator;

namespace DesignPatterns.Tests.Behavioral;

/// <summary>
/// MementoTests class. Contains tests for the Memento design pattern implementation.
/// </summary>
public class MementoTests : BaseTest
{
    /// <summary>
    /// Verifies that the TextEditor can restore its previous state from a memento.
    /// </summary>
    [Fact]
    public void Restore_Should_Revert_To_Previous_State()
    {
        // Arrange: Create the editor and history
        var editor = new TextEditor();
        var history = new History();

        // Act: Save and restore state
        editor.Content = "State 1";
        history.Push(editor.Save());

        editor.Content = "State 2";
        // Not saving State 2

        editor.Restore(history.Pop());

        // Assert: The content should be reverted to State 1
        Assert.Equal("State 1", editor.Content);
    }
} 