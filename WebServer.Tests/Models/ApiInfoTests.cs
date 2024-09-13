// <copyright file="ApiInfoTests.cs" company="Lukas Holecy">
//     Copyright (c) Lukas Holecy. All rights reserved.
// </copyright>

namespace Holecy.Services.Tests.Models;

using Holecy.Services.Models;
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
        var expectedName = "KMNG";

        var name = ApiInfo.Name;

        Assert.Equal(expectedName, name);
    }

    /// <summary>
    /// Tests that the <see cref="ApiInfo"/> returns the expected version.
    /// </summary>
    [Fact]
    public void Version_ReturnsExpectedValue()
    {
        var expectedVersion = "1";

        var version = ApiInfo.Version;

        Assert.Equal(expectedVersion, version);
    }

    /// <summary>
    /// Tests that the <see cref="ApiInfo"/> returns the expected assembly version.
    /// </summary>
    [Fact]
    public void AssemblyVersion_ReturnsExpectedValue()
    {
        var expectedAssemblyVersion = typeof(ApiInfo).Assembly.GetName().Version?.ToString();

        var assemblyVersion = ApiInfo.AssemblyVersion;

        Assert.Equal(expectedAssemblyVersion, assemblyVersion);
    }

    /// <summary>
    /// Tests that the <see cref="ApiInfo"/> returns the expected description.
    /// </summary>
    [Fact]
    public void Description_ReturnsExpectedValue()
    {
        var expectedDescription = "Service for converting online manga books into kindle.";

        var description = ApiInfo.Description;

        Assert.Equal(expectedDescription, description);
    }
}