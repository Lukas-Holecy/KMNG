// <copyright file="ApiInfoControllerTests.cs" company="Lukas Holecy">
//     Copyright (c) Lukas Holecy. All rights reserved.
// </copyright>

namespace Holecy.Services.Tests.Controllers;

using System.Text.Json;
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
        var expectedApiInfo = new ApiInfo();
        var expectedJson = JsonSerializer.Serialize(expectedApiInfo);

        // Act
        var result = controller.GetAll() as ActionResult<string>;
        var okResult = result.Result as OkObjectResult;

        // Assert
        Assert.NotNull(okResult);
        Assert.Equal(expectedJson, okResult.Value);
    }
}