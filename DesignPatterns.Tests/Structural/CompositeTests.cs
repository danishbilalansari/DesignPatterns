using DesignPatterns.Structural.Composite.Composite;
using File = DesignPatterns.Structural.Composite.Leaf.File;

namespace DesignPatterns.Tests.Structural;

/// <summary>
/// CompositeTests class. Contains tests for the Composite design pattern implementation.
/// </summary>
public class CompositeTests : BaseTest
{
    /// <summary>
    /// Verifies that the composite structure displays the correct tree hierarchy.
    /// </summary>
    [Fact]
    public void Display_Should_Show_Correct_Tree_Structure()
    {
        // Arrange: Create a folder structure with files and subfolders
        var root = new Folder("root");
        var subfolder = new Folder("subfolder");
        var file1 = new File("file1.txt");
        var file2 = new File("file2.txt");

        root.Add(subfolder);
        root.Add(file1);
        subfolder.Add(file2);

        var expectedLines = new[]
        {
            "-root",
            "---subfolder",
            "-----file2.txt",
            "---file1.txt"
        };

        using var sw = new StringWriter();
        var originalOut = Console.Out;
        Console.SetOut(sw);

        try
        {
            // Act: Display the folder structure
            root.Display(1);

            // Assert: The output should match the expected tree structure
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