namespace WebServer.Tests;

using Holecy.Services.Analysis.Models;
using System.Globalization;
using Xunit;

public class ApiInfoTests
{
    [Fact]
    public void Name_ReturnsExpectedValue()
    {
        var apiInfo = new ApiInfo();
        var expectedName = "Expected Name";

        var name = apiInfo.Name;

        Assert.Equal(expectedName, name);
    }

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

    [Fact]
    public void AssemblyVersion_ReturnsExpectedValue()
    {
        // Arrange
        var apiInfo = new ApiInfo();
        var expectedAssemblyVersion = typeof(ApiInfo).Assembly.GetName().Version?.ToString();

        // Act
        var assemblyVersion = apiInfo.AssemblyVersion;

        // Assert
        Assert.Equal(expectedAssemblyVersion, assemblyVersion);
    }

    [Fact]
    public void Description_ReturnsExpectedValue()
    {
        // Arrange
        var apiInfo = new ApiInfo();
        var expectedDescription = "Expected Description"; // Replace with the actual expected value from your resources

        // Act
        var description = apiInfo.Description;

        // Assert
        Assert.Equal(expectedDescription, description);
    }
}