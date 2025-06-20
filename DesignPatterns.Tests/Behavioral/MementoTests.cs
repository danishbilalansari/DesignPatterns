using DesignPatterns.Behavioral.Memento.Caretaker;
using DesignPatterns.Behavioral.Memento.Originator;

namespace DesignPatterns.Tests.Behavioral;

public class MementoTests : BaseTest
{
    [Fact]
    public void Restore_Should_Revert_To_Previous_State()
    {
        // Arrange
        var editor = new TextEditor();
        var history = new History();

        // Act
        editor.Content = "State 1";
        history.Push(editor.Save());

        editor.Content = "State 2";
        // Not saving State 2

        editor.Restore(history.Pop());

        // Assert
        Assert.Equal("State 1", editor.Content);
    }
} 