namespace Holecy.Services.Tests;

using Holecy.Services.Models;
using System.Globalization;
using Xunit;

public class ApiInfoTests
{
    [Fact]
    public void Name_ReturnsExpectedValue()
    {
        var apiInfo = new ApiInfo();
        var expectedName = "KMNG";

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
        var apiInfo = new ApiInfo();
        var expectedAssemblyVersion = typeof(ApiInfo).Assembly.GetName().Version?.ToString();

        var assemblyVersion = apiInfo.AssemblyVersion;

        Assert.Equal(expectedAssemblyVersion, assemblyVersion);
    }

    [Fact]
    public void Description_ReturnsExpectedValue()
    {
        // Arrange
        var apiInfo = new ApiInfo();
        var expectedDescription = "Service for converting online manga books into kindle."; // Replace with the actual expected value from your resources

        // Act
        var description = apiInfo.Description;

        // Assert
        Assert.Equal(expectedDescription, description);
    }
}