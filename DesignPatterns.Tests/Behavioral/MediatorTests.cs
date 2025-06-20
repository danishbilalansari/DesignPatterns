using DesignPatterns.Behavioral.Mediator.Concrete;

namespace DesignPatterns.Tests.Behavioral;

/// <summary>
/// MediatorTests class. Contains tests for the Mediator design pattern implementation.
/// </summary>
public class MediatorTests : BaseTest
{
    /// <summary>
    /// Verifies that a message sent by one user is received by all other users in the chat.
    /// </summary>
    [Fact]
    public void SendMessage_Should_Be_Received_By_Other_Users()
    {
        // Arrange: Set up the mediator and users
        var mediator = new ChatMediator();
        var user1 = new User("User1", mediator);
        var user2 = new User("User2", mediator);
        var user3 = new User("User3", mediator);
        
        mediator.AddUser(user1);
        mediator.AddUser(user2);
        mediator.AddUser(user3);

        var message = "Hello everyone!";
        var expectedLines = new[]
        {
            "User1 sends: Hello everyone!",
            "User2 receives: Hello everyone!",
            "User3 receives: Hello everyone!"
        };

        using var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);

        try
        {
            // Act: User1 sends a message
            user1.Send(message);

            // Assert: All other users should receive the message
            sw.Flush();
            var output = sw.ToString();
            foreach (var line in expectedLines)
            {
                Assert.Contains(line, output);
            }
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }
} 