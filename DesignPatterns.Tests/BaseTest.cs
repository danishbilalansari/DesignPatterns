using Xunit;

/// <summary>
/// BaseTest class. Ensures all derived tests run in a non-parallel collection to avoid shared resource conflicts.
/// </summary>
[Collection("Non-Parallel Collection")]
public abstract class BaseTest { } 