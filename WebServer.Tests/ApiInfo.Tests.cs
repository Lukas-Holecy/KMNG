namespace Holecy.Services.Tests;

using Holecy.Services.Models;
using System.Globalization;
using Xunit;

/// <summary>
/// Tests for the <see cref="ApiInfo"/> class.
/// </summary>
public class ApiInfoTests
{
    /// <summary>
    /// Tests that the <see cref="ApiInfo"/> returns the expected name.
    /// </summary>
    [Fact]
    public void Name_ReturnsExpectedValue()
    {
        var apiInfo = new ApiInfo();
        var expectedName = "KMNG";

        var name = apiInfo.Name;

        Assert.Equal(expectedName, name);
    }

    /// <summary>
    /// Tests that the <see cref="ApiInfo"/> returns the expected version.
    /// </summary>
    [Fact]
    public void Version_ReturnsExpectedValue()
    {
        // Arrange
        var apiInfo = new ApiInfo();
        var expectedVersion = "1";

        // Act
        var version = apiInfo.Version;

        // Assert
        Assert.Equal(expectedVersion, version);
    }

    /// <summary>
    /// Tests that the <see cref="ApiInfo"/> returns the expected assembly version.
    /// </summary>
    [Fact]
    public void AssemblyVersion_ReturnsExpectedValue()
    {
        var apiInfo = new ApiInfo();
        var expectedAssemblyVersion = typeof(ApiInfo).Assembly.GetName().Version?.ToString();

        var assemblyVersion = apiInfo.AssemblyVersion;

        Assert.Equal(expectedAssemblyVersion, assemblyVersion);
    }

    /// <summary>
    /// Tests that the <see cref="ApiInfo"/> returns the expected description.
    /// </summary>
    [Fact]
    public void Description_ReturnsExpectedValue()
    {
        var apiInfo = new ApiInfo();
        var expectedDescription = "Service for converting online manga books into kindle.";

        var description = apiInfo.Description;

        Assert.Equal(expectedDescription, description);
    }
}