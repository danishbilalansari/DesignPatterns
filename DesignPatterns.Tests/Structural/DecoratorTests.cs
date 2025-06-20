using DesignPatterns.Structural.Decorator.ConcreteComponents;
using DesignPatterns.Structural.Decorator.Decorators;

namespace DesignPatterns.Tests.Structural;

public class DecoratorTests : BaseTest
{
    [Fact]
    public void SMSDecorator_Should_Add_SMS_Notification_To_Email()
    {
        // Arrange
        var emailNotifier = new EmailNotifier();
        var smsDecorator = new SMSDecorator(emailNotifier);
        var message = "Test Message";
        
        var expected = new StringWriter();
        expected.WriteLine("Email sent: " + message);
        expected.WriteLine("SMS sent: " + message);

        using var sw = new StringWriter();
        Console.SetOut(sw);

        // Act
        smsDecorator.Send(message);

        // Assert
        Assert.Equal(expected.ToString(), sw.ToString());
        
        var standardOutput = new StreamWriter(Console.OpenStandardOutput());
        standardOutput.AutoFlush = true;
        Console.SetOut(standardOutput);
    }
} 