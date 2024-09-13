// <copyright file="ApiInfoControllerTests.cs" company="Lukas Holecy">
//     Copyright (c) Lukas Holecy. All rights reserved.
// </copyright>

namespace Holecy.Services.Tests.Controllers;

using Holecy.Services.Controllers;
using Holecy.Services.Models;
using Microsoft.AspNetCore.Mvc;
using Xunit;

/// <summary>
/// Tests for the <see cref="ApiInfoController"/> class.
/// </summary>
public class ApiInfoControllerTests
{
    /// <summary>
    /// Tests that the <see cref="ApiInfoController.GetAll"/> returns the serialized <see cref="ApiInfo"/>.
    /// </summary>
    [Fact]
    public void GetAll_ReturnsSerializedApiInfo()
    {
        // Arrange
        var controller = new ApiInfoController();
        var expectedJson = """
            {
              "Name": "KMNG",
              "Version": "1",
              "AssemblyVersion": "1.0.0.0",
              "Description": "Service for converting online manga books into kindle."
            }
            """;

        // Act
        var result = controller.GetAll();
        var okResult = result.Result as OkObjectResult;

        // Assert
        Assert.NotNull(okResult);
        Assert.Equal(expectedJson, okResult.Value);
    }
}