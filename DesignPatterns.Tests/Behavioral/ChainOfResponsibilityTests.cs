using DesignPatterns.Behavioral.ChainOfResponsibility.AbstractHandlers;
using DesignPatterns.Behavioral.ChainOfResponsibility.ConcreteHandlers;
using DesignPatterns.Behavioral.ChainOfResponsibility.Models;

namespace DesignPatterns.Tests.Behavioral;

public class ChainOfResponsibilityTests : BaseTest
{
    private readonly Handler _handlerChain;

    public ChainOfResponsibilityTests()
    {
        var manager = new Manager();
        var director = new Director();
        manager.SetNext(director);
        _handlerChain = manager;
    }

    [Fact]
    public void Handle_Should_Be_Handled_By_Manager_For_Small_Amount()
    {
        // Arrange
        var request = new Request("Purchase", 500);
        var expected = "Manager approved request of 500.";
        using var sw = new StringWriter();
        Console.SetOut(sw);
        
        // Act
        _handlerChain.Handle(request);
        
        // Assert
        Assert.Equal(expected, sw.ToString().Trim());
        
        var standardOutput = new StreamWriter(Console.OpenStandardOutput());
        standardOutput.AutoFlush = true;
        Console.SetOut(standardOutput);
    }

    [Fact]
    public void Handle_Should_Be_Handled_By_Director_For_Medium_Amount()
    {
        // Arrange
        var request = new Request("Purchase", 5000);
        var expected = "Director approved request of 5000.";
        using var sw = new StringWriter();
        Console.SetOut(sw);
        
        // Act
        _handlerChain.Handle(request);
        
        // Assert
        Assert.Equal(expected, sw.ToString().Trim());
        
        var standardOutput = new StreamWriter(Console.OpenStandardOutput());
        standardOutput.AutoFlush = true;
        Console.SetOut(standardOutput);
    }

    [Fact]
    public void Handle_Should_Be_Denied_For_Large_Amount()
    {
        // Arrange
        var request = new Request("Purchase", 50000);
        var expected = "Request denied. Amount too high.";
        using var sw = new StringWriter();
        Console.SetOut(sw);
        
        // Act
        _handlerChain.Handle(request);
        
        // Assert
        Assert.Equal(expected, sw.ToString().Trim());
        
        var standardOutput = new StreamWriter(Console.OpenStandardOutput());
        standardOutput.AutoFlush = true;
        Console.SetOut(standardOutput);
    }
} 